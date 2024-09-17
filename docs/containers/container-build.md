---
title: Customize Docker containers in Visual Studio
author: ghogen
description: Explore Visual Studio fast mode, and modify the Dockerfile to customize your container images for both debug and production builds.
ms.author: ghogen
ms.date: 09/17/2024
ms.subservice: container-tools
ms.topic: how-to
---

# Customize Docker containers in Visual Studio

You can customize your container images by editing the Dockerfile that Visual Studio generates when you add Docker support to your project. Whether you're building a customized container from the Visual Studio IDE, or setting up a command-line build, you need to know how Visual Studio uses the Dockerfile to build your projects. You need to know such details because, for performance reasons, Visual Studio follows a special process for building and running containerized apps that isn't obvious from the Dockerfile.

Suppose you want to make a change in the Dockerfile and see the results in both debugging and in production containers. In that case, you can add commands in the Dockerfile to modify the first stage (usually `base`). See [Modify the container image for debugging and production](container-debug-customization.md#modify-container-image-for-debugging-and-production). But, if you want to make a change only when debugging, but not production, then you should create another stage, and use the `DockerfileFastModeStage` build setting to tell Visual Studio to use that stage for debug builds. See [Modify the container image only for debugging](container-debug-customization.md#modify-container-image-only-for-debugging).

This article explains the Visual Studio build process for containerized apps in some detail, then it contains information on how to modify the Dockerfile to affect both debugging and production builds, or just for debugging.

## Dockerfile builds in Visual Studio

::: moniker range=">=vs-2022"
> [!NOTE]
> This section describes the container build process that Visual Studio uses when you choose the Dockerfile container build type. If you are using the .NET SDK build type, the customization options are different, and the information in this section isn't applicable. Instead, see [Containerize a .NET app with dotnet publish](/dotnet/core/docker/publish-as-container?pivots=dotnet-8-0) and use the properties described at [Customize your container](https://github.com/dotnet/sdk-container-builds/blob/main/docs/ContainerCustomization.md) to configure the container build process.
::: moniker-end

### Multistage build

When Visual Studio builds a project that doesn't use Docker containers, it invokes MSBuild on the local machine and generates the output files in a folder (typically `bin`) under your local solution folder. For a containerized project, however, the build process takes account of the Dockerfile's instructions for building the containerized app. The Dockerfile that Visual Studio uses is divided into multiple stages. This process relies on Docker's *multistage build* feature.

The multistage build feature helps make the process of building containers more efficient, and makes containers smaller by allowing them to contain only the bits that your app needs at run time. Multistage build is used for .NET Core projects, not .NET Framework projects.

The multistage build allows container images to be created in stages that produce intermediate images. As an example, consider a typical Dockerfile. The first stage is called `base` in the Dockerfile that Visual Studio generates, although the tools don't require that name.

```
FROM mcr.microsoft.com/dotnet/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
```

The lines in the Dockerfile begin with the ASP.NET image from Microsoft Container Registry (mcr.microsoft.com) and create an intermediate image `base` that exposes ports 80 and 443, and sets the working directory to `/app`.

The next stage is `build`, which appears as follows:

```
FROM mcr.microsoft.com/dotnet/sdk:3.1-buster-slim AS build
WORKDIR /src
COPY ["WebApplication43/WebApplication43.csproj", "WebApplication43/"]
RUN dotnet restore "WebApplication43/WebApplication43.csproj"
COPY . .
WORKDIR "/src/WebApplication43"
RUN dotnet build "WebApplication43.csproj" -c Release -o /app/build
```

You can see that the `build` stage starts from a different original image from the registry (`sdk` rather than `aspnet`), rather than continuing from base. The `sdk` image has all the build tools, and for that reason it's a lot bigger than the aspnet image, which only contains runtime components. The reason for using a separate image becomes clear when you look at the rest of the Dockerfile:

```
FROM build AS publish
RUN dotnet publish "WebApplication43.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication43.dll"]
```

The final stage starts again from `base`, and includes the `COPY --from=publish` to copy the published output to the final image. This process makes it possible for the final image to be a lot smaller, since it doesn't need to include all of the build tools that were in the `sdk` image.

The following table summarize the stages used in the typical Dockerfile created by Visual Studio:

| Stage | Description |
| - | - |
| base | Creates the base runtime image where the built app is published. Settings that need to be available at runtime go here, such as ports and environment variables. This stage is used when running from VS in fast mode (Default for Debug configuration). |
| build | The project is built in this stage. The .NET SDK base image is used, which has the components required to build your project. |
| publish | This stage derives from the build stage and publishes your project, which will be copied to the final stage. |
| final | This stage configures how to start the app and is used in production or when running from VS in regular mode (Default when not using the Debug configuration). |
| aotdebug | This stage is used as the base for the final stage when launching from VS to support debugging in regular mode (Default when not using the Debug configuration). |

> [!NOTE]
> The `aotdebug` stage is only supported for Linux containers. It is used in Visual Studio 2022 17.11 and later if [native Ahead Of Time (AOT) deployment](/dotnet/core/deploying/native-aot) is enabled on the project.

::: moniker range=">=vs-2022"
### Customize the image for debugging

To support native AOT deployment, the GNU debugger (GDB) is installed, but only on the image used when debugging, not the final runtime image. The Dockerfile includes a build argument `LAUNCHING_FROM_VS` which can be `true` or `false`. If `true`, the `aotdebug` stage is used, which is where GDB is installed. Note that Visual Studio only supports native AOT and GDB for Linux containers.

```Dockerfile
# These ARGs allow for swapping out the base used to make the final image when debugging from VS
ARG LAUNCHING_FROM_VS
# This sets the base image for final, but only if LAUNCHING_FROM_VS has been defined
ARG FINAL_BASE_IMAGE=${LAUNCHING_FROM_VS:+aotdebug}

# ... (other stages omitted)

# This stage is used as the base for the final stage when launching from VS to support debugging in regular mode (Default when not using the Debug configuration)
FROM base as aotdebug
USER root
# Install GDB to support native debugging
RUN apt-get update \
    && apt-get install -y --no-install-recommends \
    gdb
USER app

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM ${FINAL_BASE_IMAGE:-mcr.microsoft.com/dotnet/runtime-deps:8.0} AS final
WORKDIR /app
EXPOSE 8080
COPY --from=publish /app/publish .
ENTRYPOINT ["./WebApplication1"]
```

You can use `aotstage` in the Dockerfile to customize the image used at debug time, without affecting the final image used when not launching from Visual Studio, or in production. For example, you could install a tool for use only during debugging.

:::moniker-end

## Project warmup

*Project warmup* refers to a series of steps that happen when the Docker profile is selected for a project (that is, when a project is loaded or Docker support is added) in order to improve the performance of subsequent runs (**F5** or **Ctrl**+**F5**). This behavior is configurable under **Tools** > **Options** > **Container Tools**. Here are the tasks that run in the background:

- Check that Docker Desktop is installed and running.
- Ensure that Docker Desktop is set to the same operating system as the project.
- Pull the images in the first stage of the Dockerfile (the `base` stage in most Dockerfiles).
- Build the Dockerfile and start the container.

Warmup only happens in **Fast** mode, so the running container has the *app* folder volume-mounted. That means that any changes to the app don't invalidate the container. This behavior improves the debugging performance significantly and decreases the wait time for long running tasks such as pulling large images.

## Next steps

Learn about how to use the Dockerfile stages to customize the images used for debugging and production, for example, how to install a tool on the image only when debugging. See [Configure container images for debugging](container-debug-customization.md).

## Related content

- [MSBuild properties for container projects](container-msbuild-properties.md).
- [Dockerfile on Windows](/virtualization/windowscontainers/manage-docker/manage-windows-dockerfile)
- [Linux containers on Windows](/virtualization/windowscontainers/deploy-containers/linux-containers)
