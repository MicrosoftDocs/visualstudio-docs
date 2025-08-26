---
title: Customize Docker containers in Visual Studio
author: ghogen
description: Explore Visual Studio fast mode, and modify the Dockerfile to customize your container images for both debug and production builds.
ms.author: ghogen
ms.date: 09/17/2024
ms.subservice: container-tools
ms.topic: how-to
---

# Customize containers in Visual Studio

You can customize your container images by editing the Dockerfile that Visual Studio generates when you add container support to your project. Whether you're building a customized container from the Visual Studio IDE, or setting up a command-line build, you need to know how Visual Studio uses the Dockerfile to build your projects. You need to know such details because, for performance reasons, Visual Studio follows a special process for building and running containerized apps that isn't obvious from the Dockerfile.

:::moniker range="visualstudio"
Suppose you want to make a change in the Dockerfile and see the results in both debugging and in production containers. In that case, you can add commands in the Dockerfile to modify the first stage (usually `base`). See [Modify the container image for debugging and production](container-debug-customization.md#modify-container-image-for-debugging-and-production). But, if you want to make a change only when debugging, but not production, then you should create another stage, and use the `ContainerFastModeStage` build setting to tell Visual Studio to use that stage for debug builds. See [Modify the container image only for debugging](container-debug-customization.md#modify-container-image-only-for-debugging).
:::moniker-end

:::moniker range="<=vs-2022"
Suppose you want to make a change in the Dockerfile and see the results in both debugging and in production containers. In that case, you can add commands in the Dockerfile to modify the first stage (usually `base`). See [Modify the container image for debugging and production](container-debug-customization.md#modify-container-image-for-debugging-and-production). But, if you want to make a change only when debugging, but not production, then you should create another stage, and use the `DockerfileFastModeStage` build setting to tell Visual Studio to use that stage for debug builds. See [Modify the container image only for debugging](container-debug-customization.md#modify-container-image-only-for-debugging).
:::moniker-end

This article explains the Visual Studio build process for containerized apps in some detail, then it contains information on how to modify the Dockerfile to affect both debugging and production builds, or just for debugging.

## Dockerfile builds in Visual Studio

::: moniker range=">=vs-2022"
> [!NOTE]
> This section describes the container build process that Visual Studio uses when you choose the Dockerfile container build type. If you are using the .NET SDK build type, the customization options are different, and the information in this section isn't applicable. Instead, see [Containerize a .NET app with dotnet publish](/dotnet/core/docker/publish-as-container?pivots=dotnet-8-0) and use the properties described at [Customize your container](https://github.com/dotnet/sdk-container-builds/blob/main/docs/ContainerCustomization.md) to configure the container build process.
::: moniker-end

### Multistage build

When Visual Studio builds a project that doesn't use Docker containers, it invokes MSBuild on the local machine and generates the output files in a folder (typically `bin`) under your local solution folder. For a containerized project, however, the build process takes account of the Dockerfile's instructions for building the containerized app. The Dockerfile that Visual Studio uses is divided into multiple stages. This process relies on Docker's *multistage build* feature.

The multistage build feature helps make the process of building containers more efficient, and makes containers smaller by allowing them to contain only the bits that your app needs at run time.

:::moniker range="<=vs-2022"
Multistage build is used for .NET Core projects, not .NET Framework projects.
:::moniker-end

The multistage build allows container images to be created in stages that produce intermediate images. As an example, consider a typical Dockerfile. The first stage is called `base` in the Dockerfile that Visual Studio generates, although the tools don't require that name.

```Dockerfile
# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
```

The lines in the Dockerfile begin with the ASP.NET image from Microsoft Container Registry (mcr.microsoft.com) and create an intermediate image `base` that exposes ports 80 and 443, and sets the working directory to `/app`.

The next stage is `build`, which appears as follows:

```Dockerfile
# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["WebApplication43/WebApplication43.csproj", "WebApplication43/"]
RUN dotnet restore "WebApplication43/WebApplication43.csproj"
COPY . .
WORKDIR "/src/WebApplication43"
RUN dotnet build "WebApplication43.csproj" -c Release -o /app/build
```

You can see that the `build` stage starts from a different original image from the registry (`sdk` rather than `aspnet`), rather than continuing from base. The `sdk` image has all the build tools, and for that reason it's a lot bigger than the aspnet image, which only contains runtime components. The reason for using a separate image becomes clear when you look at the rest of the Dockerfile:

```Dockerfile
# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
RUN dotnet publish "WebApplication43.csproj" -c Release -o /app/publish

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication43.dll"]
```

The final stage starts again from `base`, and includes the `COPY --from=publish` to copy the published output to the final image. This process makes it possible for the final image to be a lot smaller, since it doesn't need to include all of the build tools that were in the `sdk` image.

The following table summarizes the stages used in the typical Dockerfile created by Visual Studio:

:::moniker range=">=vs-2022"

| Stage | Description |
| - | - |
| base | Creates the base runtime image where the built app is published. Settings that need to be available at runtime go here, such as ports and environment variables. This stage is used when running from VS in fast mode (Default for Debug configuration). |
| build | The project is built in this stage. The .NET SDK base image is used, which has the components required to build your project. |
| publish | This stage derives from the build stage and publishes your project, which will be copied to the final stage. |
| final | This stage configures how to start the app and is used in production or when running from VS in regular mode (Default when not using the Debug configuration). |
| aotdebug | This stage is used as the base for the final stage when launching from VS to support debugging in regular mode (Default when not using the Debug configuration). |

> [!NOTE]
> The `aotdebug` stage is only supported for Linux containers. It is used in Visual Studio 2022 17.11 and later if [native Ahead Of Time (AOT) deployment](/dotnet/core/deploying/native-aot) is enabled on the project.
:::moniker-end
:::moniker range="vs-2019"

| Stage | Description |
| - | - |
| base | Creates the base runtime image where the built app is published. Settings that need to be available at runtime go here, such as ports and environment variables. This stage is used when running from VS in fast mode (Default for Debug configuration). |
| build | The project is built in this stage. The .NET SDK base image is used, which has the components required to build your project. |
| publish | This stage derives from the build stage and publishes your project, which will be copied to the final stage. |
| final | This stage configures how to start the app and is used in production or when running from VS in regular mode (Default when not using the Debug configuration). |

:::moniker-end

## Project warmup

*Project warmup* refers to a series of steps that happen when the Container profile is selected for a project (that is, when a project is loaded or container support is added) in order to improve the performance of subsequent runs (**F5** or **Ctrl**+**F5**). This behavior is configurable under **Tools** > **Options** > **Container Tools**. Here are the tasks that run in the background:

:::moniker range="visualstudio"
- Check that the container runtime (Docker Desktop or Podman) is installed and running.
- Ensure that Docker Desktop is set to the same operating system as the project. (This check is not applicable to Podman, which only supports Linux containers.)
- Pull the images in the first stage of the Dockerfile (the `base` stage in most Dockerfiles).
- Build the Dockerfile and start the container.
:::moniker-end

:::moniker range="<=vs-2022"
- Check that Docker Desktop is installed and running.
- Ensure that Docker Desktop is set to the same operating system as the project.
- Pull the images in the first stage of the Dockerfile (the `base` stage in most Dockerfiles).
- Build the Dockerfile and start the container.
:::moniker-end

Warmup only happens in **Fast** mode, so the running container has the *app* folder volume-mounted. That means that any changes to the app don't invalidate the container. This behavior improves the debugging performance significantly and decreases the wait time for long running tasks such as pulling large images.

## Enable detailed container tools logs

For diagnostic purposes, you can enable certain Container Tools logs. You can enable these logs by setting certain environment variables. For single container projects, the environment variable is `MS_VS_CONTAINERS_TOOLS_LOGGING_ENABLED`, which then logs in `%tmp%\Microsoft.VisualStudio.Containers.Tools`. For Docker Compose projects, it's `MS_VS_DOCKER_TOOLS_LOGGING_ENABLED`, which then logs in `%tmp%\Microsoft.VisualStudio.DockerCompose.Tools`.

:::moniker range=">=vs-2022"
> [!WARNING]
> When logging is enabled and you're using a token proxy for Azure authentication, authentication credentials could be logged as plain text. See [Configure Azure authentication](container-tools-configure.md#configure-azure-authentication).
:::moniker-end

## Next steps

Learn about how to use the Dockerfile stages to customize the images used for debugging and production, for example, how to install a tool on the image only when debugging. See [Configure container images for debugging](container-debug-customization.md).

## Related content

- [MSBuild properties for container projects](container-msbuild-properties.md).
- [Dockerfile on Windows](/virtualization/windowscontainers/manage-docker/manage-windows-dockerfile)
- [Linux containers on Windows](/virtualization/windowscontainers/deploy-containers/linux-containers)
