---
title: Customize container images for debugging
author: ghogen
description: Modify the Dockerfile to customize your container images for both debug and production builds.
ms.author: ghogen
ms.date: 8/25/2025
ms.subservice: container-tools
ms.topic: how-to
---

# Customize container images for debugging

::: moniker range="vs-2019"
This article describes how you can customize your Docker containers for debugging.
::: moniker-end

::: moniker range=">=vs-2022"
This article describes how you can customize your Docker containers when you choose the Dockerfile container build type. If you are using the .NET SDK build type, the customization options are different, and most of the information in this section isn't applicable. Instead, see [Containerize a .NET app with dotnet publish](/dotnet/core/docker/publish-as-container?pivots=dotnet-8-0).
::: moniker-end

:::moniker range="visualstudio"

## Prerequisites

- [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows) or [Podman Desktop](https://podman-desktop.io/downloads).
- [Visual Studio](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta), or for Podman support, [Visual Studio (Insiders)](https://visualstudio.microsoft.com/insiders/?cid=learn-onpage-download-cta), with the **ASP.NET and web development**, **Azure development** workload, and/or **.NET desktop development** workload installed.

:::moniker-end
::: moniker range="vs-2022"

## Prerequisites

- [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows).
- [Visual Studio](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) with the **ASP.NET and web development**, **Azure development** workload, and/or **.NET desktop development** workload installed.

:::moniker-end

::: moniker range="vs-2019"

## Prerequisites

- [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows)
- [Visual Studio 2019 or later](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) with the **ASP.NET and web development**, **Azure development** workload, **.NET desktop development**, and/or **.NET Core cross-platform development** workload installed.

:::moniker-end

## Fast Mode optimizations

When you build in the **Debug** configuration, there are several optimizations that Visual Studio does that help with the performance of the build process for containerized projects. The build process for containerized apps isn't as straightforward as simply following the steps outlined in the Dockerfile. Building in a container is slower than building on the local machine. So, when you build in the **Debug** configuration, Visual Studio actually builds your projects on the local machine, and then shares the output folder to the container using volume mounting. A build with this optimization enabled is called a *Fast* mode build.

:::moniker range="<=vs-2022"
In **Fast** mode, Visual Studio calls `docker build` with an argument that tells Docker to build only the first stage in the Dockerfile (normally the `base` stage). You can change that by setting the MSBuild property, `DockerfileFastModeStage`, described at [Container Tools MSBuild properties](container-msbuild-properties.md). Visual Studio handles the rest of the process without regard to the contents of the Dockerfile. So, when you modify your Dockerfile, such as to customize the container environment or install additional dependencies, you should put your modifications in the first stage. Any custom steps placed in the Dockerfile's `build`, `publish`, or `final` stages aren't executed.
:::moniker-end

:::moniker range="visualstudio"
In **Fast** mode, Visual Studio calls `docker build` or `podman build` with an argument that tells the container runtime to build only the first stage in the Dockerfile (normally the `base` stage). You can change that by setting the MSBuild property, `ContainerFastModeStage`, which replaces the obsolete `DockerfileFastModeStage`. See [Container Tools MSBuild properties](container-msbuild-properties.md). Visual Studio handles the rest of the process without regard to the contents of the Dockerfile. So, when you modify your Dockerfile, such as to customize the container environment or install additional dependencies, you should put your modifications in the first stage. Any custom steps placed in the Dockerfile's `build`, `publish`, or `final` stages aren't executed.
:::moniker-end

This performance optimization normally only occurs when you build in the **Debug** configuration. In the **Release** configuration, the build occurs in the container as specified in the Dockerfile. You can enable this behavior for the Release configuration by setting `ContainerDevelopmentMode` to **Fast** in the project file:

```xml
<PropertyGroup Condition="'$(Configuration)' == 'Release'">
   <ContainerDevelopmentMode>Fast</ContainerDevelopmentMode>
</PropertyGroup>
```

If you want to disable the performance optimization for all configurations, and build as the Dockerfile specifies, then set the **ContainerDevelopmentMode** property to **Regular** in the project file as follows:

```xml
<PropertyGroup>
   <ContainerDevelopmentMode>Regular</ContainerDevelopmentMode>
</PropertyGroup>
```

To restore the performance optimization, remove the property from the project file.

When you start debugging (**F5**), a previously started container is reused, if possible. If you don't want to reuse the previous container, you can use **Rebuild** or **Clean** commands in Visual Studio to force Visual Studio to use a fresh container.

The process of running the debugger depends on the type of project and container operating system:

:::moniker range="visualstudio"
|Scenario|Debugger process|
|-|-|
| **.NET Core apps (Linux containers)**| Visual Studio downloads `vsdbg` and maps it to the container, then it gets called with your program and arguments (that is, `dotnet webapp.dll`). |
| **.NET Core apps (Windows containers)**| Visual Studio uses `onecoremsvsmon` and maps it to the container, runs it as the entry point.|
:::moniker-end

:::moniker range="<=vs-2022"
|Scenario|Debugger process|
|-|-|
| **.NET Core apps (Linux containers)**| Visual Studio downloads `vsdbg` and maps it to the container, then it gets called with your program and arguments (that is, `dotnet webapp.dll`), and then debugger attaches to the process. |
| **.NET Core apps (Windows containers)**| Visual Studio uses `onecoremsvsmon` and maps it to the container, runs it as the entry point.|
| **.NET Framework apps** | Visual Studio uses `msvsmon` and maps it to the container, runs it as part of the entry point where Visual Studio can connect to it, and attaches to the program. This is similar to how you would normally set up remote debugging on another computer or virtual machine.|
:::moniker-end

For information on `vsdbg.exe`, see [Offroad debugging of .NET Core on Linux and OS X from Visual Studio](https://github.com/Microsoft/MIEngine/wiki/Offroad-Debugging-of-.NET-Core-on-Linux---OSX-from-Visual-Studio).

## Modify container image for debugging and production

:::moniker range="<=vs-2022"
To modify the container image for both debugging and production, modify the first stage in the Dockerfile, usually called the `base` stage. Refer to the [Dockerfile reference](https://docs.docker.com/engine/reference/builder/) in the Docker documentation for information about Dockerfile commands.

> [!TIP]
> If your project uses the `DockerfileFastModeStage` MSBuild property, you should select an appropriate stage to add customization that flows to the final stage and the `DockerfileFastModeStage`, if possible. See [Container Tools build properties](container-msbuild-properties.md).
:::moniker-end

:::moniker range="visualstudio"
To modify the container image for both debugging and production, modify the first stage in the Dockerfile, usually called the `base` stage. Refer to the [Dockerfile reference](https://docs.docker.com/engine/reference/builder/) in the Docker documentation for information about Dockerfile commands.

> [!TIP]
> If your project uses the `ContainerFastModeStage` (or the obsolete equivalent `DockerfileFastModeStage`) MSBuild property, you should select an appropriate stage for customization that flows to the final stage and the `ContainerFastModeStage`, if possible. See [Container Tools build properties](container-msbuild-properties.md).
:::moniker-end

:::moniker range=">=vs-2022"

```dockerfile
# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
# <add your commands here>

# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["WebApplication3/WebApplication3.csproj", "WebApplication3/"]
RUN dotnet restore "WebApplication3/WebApplication3.csproj"
COPY . .
WORKDIR "/src/WebApplication3"
RUN dotnet build "WebApplication3.csproj" -c Release -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
RUN dotnet publish "WebApplication3.csproj" -c Release -o /app/publish

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication3.dll"]
```

:::moniker-end
:::moniker range="vs-2019"

```dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
# <add your commands here>

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["WebApplication3/WebApplication3.csproj", "WebApplication3/"]
RUN dotnet restore "WebApplication3/WebApplication3.csproj"
COPY . .
WORKDIR "/src/WebApplication3"
RUN dotnet build "WebApplication3.csproj" -c Release -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
RUN dotnet publish "WebApplication3.csproj" -c Release -o /app/publish

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication3.dll"]
```

:::moniker-end

## Modify container image only for debugging

You can customize your containers in certain ways to help in debugging, such as installing something for diagnostic purposes, without affecting production builds.

:::moniker range="<=vs-2022"
To modify the container only for debugging, create a stage and then use the MSBuild property `DockerfileFastModeStage` to tell Visual Studio to use your customized stage when debugging. Refer to the [Dockerfile reference](https://docs.docker.com/engine/reference/builder/) in the Docker documentation for information about Dockerfile commands.
:::moniker-end

:::moniker range="visualstudio"
To modify the container only for debugging, create a stage and then use the MSBuild property `ContainerFastModeStage` to tell Visual Studio to use your customized stage when debugging. Refer to the [Dockerfile reference](https://docs.docker.com/engine/reference/builder/) in the Docker documentation for information about Dockerfile commands.
:::moniker-end

> [!NOTE]
> The instructions here apply to the single-container case. You can also do the same thing for multiple containers with Docker Compose, but the techniques required for Docker Compose are slightly different. For example, the stage is controlled by a setting in the `dockercompose.debug.yml` file.

In the following example, we install the package `procps-ng`, but only in debug mode. This package supplies the command `pidof`, which Visual Studio requires (when targeting .NET 5 and earlier) but isn't in the Mariner image used here. The stage we use for fast mode debugging is `debug`, a custom stage defined here. The fast mode stage doesn't need to inherit from the `build` or `publish` stage, it can inherit directly from the `base` stage, because Visual Studio mounts a volume that contains everything needed to run the app, as described earlier in this article.

:::moniker range=">=vs-2022"

```dockerfile
#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM base AS debug
RUN tdnf install procps-ng -y

# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["WebApplication1/WebApplication1.csproj", "WebApplication1/"]
RUN dotnet restore "WebApplication1/WebApplication1.csproj"
COPY . .
WORKDIR "/src/WebApplication1"
RUN dotnet build "WebApplication1.csproj" -c Release -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
RUN dotnet publish "WebApplication1.csproj" -c Release -o /app/publish

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication1.dll"]
```

:::moniker-end
:::moniker range="vs-2019"

```dockerfile
#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM base AS debug
RUN tdnf install procps-ng -y

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["WebApplication1/WebApplication1.csproj", "WebApplication1/"]
RUN dotnet restore "WebApplication1/WebApplication1.csproj"
COPY . .
WORKDIR "/src/WebApplication1"
RUN dotnet build "WebApplication1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApplication1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication1.dll"]
```

:::moniker-end

In the project file, add this setting to tell Visual Studio to use your custom stage `debug` when debugging.

:::moniker range="<=vs-2022"

```xml
  <PropertyGroup>
     <!-- other property settings -->
     <DockerfileFastModeStage>debug</DockerfileFastModeStage>
  </PropertyGroup>
```

:::moniker-end

:::moniker range="visualstudio"

```xml
  <PropertyGroup>
     <!-- other property settings -->
     <ContainerFastModeStage>debug</ContainerFastModeStage>
  </PropertyGroup>
```

:::moniker-end

::: moniker range=">=vs-2022"

### Customize debugging images with AOT deployment

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

## Related content

- [Customize Docker containers in Visual Studio](container-build.md)
- [Build a container project from the command line](container-build-from-command-line.md)
