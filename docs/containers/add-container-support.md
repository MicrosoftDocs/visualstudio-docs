---
title: Add support for Docker containers
description: Learn how to containerize your projects by adding Docker support, and choose whether to work with a Dockerfile, or build a containerized app without a Dockerfile.
author: ghogen
ms.author: ghogen
ms.topic: overview
ms.date: 2/21/2025
ms.subservice: container-tools
---

# Add support for Docker containers

You can add support for Docker containers in supported Visual Studio project types, such as ASP.NET web projects and others. See the [overview](overview.md) for information about supported project types in your version of Visual Studio.

::: moniker range="vs-2019"

## Prerequisites

- [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows)
- [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) with the **Web Development**, **Azure Tools** workload, and/or **.NET Core cross-platform development** workload installed
- [.NET Core Development Tools](https://dotnet.microsoft.com/download/dotnet-core/) for development with .NET Core.
- To publish to Azure Container Registry, an Azure subscription. [Sign up for a free trial](https://azure.microsoft.com/offers/ms-azr-0044p/).
:::moniker-end

::: moniker range=">=vs-2022"

## Prerequisites

- [Docker Desktop](https://www.docker.com/get-docker)
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) with the **Web Development**, **Azure Tools** workload, and/or **.NET desktop development** workload installed
- To publish to Azure Container Registry, an Azure subscription. [Sign up for a free trial](https://azure.microsoft.com/offers/ms-azr-0044p/).
:::moniker-end

### Add Docker support when you create a project

You can enable Docker support during project creation by selecting **Enable Docker Support** when you create a new project, as shown in the following screenshot:

::: moniker range="vs-2019"
![Screenshot showing how to enable Docker Support for new ASP.NET Core web app in Visual Studio.](./media/overview/vs-2019/enable-docker-support-visual-studio.png)
::: moniker-end
::: moniker range=">=vs-2022"
![Screenshot showing how to enable Docker Support for new ASP.NET Core web app in Visual Studio.](./media/overview/vs-2022/enable-docker-support-visual-studio.png)
::: moniker-end

> [!NOTE]
> For .NET Framework projects (not .NET Core), only Windows containers are available.

:::moniker range="<=vs-2019"
> [!NOTE]
> When creating a .NET Framework or .NET Core console project, there's no option to **Add Docker support**. After a .NET Core console application project is created, the **Add Docker support** option is available. .NET Framework console application projects don't support the **Add Docker support** option after the project is created. After creation, both .NET Framework or .NET Core console projects support the **Add Container Orchestrator Support** option using Service Fabric or Docker Compose.
:::moniker-end
:::moniker range=">=vs-2022"
> [!NOTE]
> If you're using the full .NET Framework console project template, the supported option is **Add Container Orchestrator support** after project creation, with options to use Service Fabric or Docker Compose. Adding support at project creation and **Add Docker support** for a single project without orchestration are not available options.
:::moniker-end

### Add Docker support to an existing project

You can add Docker support to an existing project by selecting **Add** > **Docker Support** in **Solution Explorer**. The **Add > Docker Support** and **Add > Container Orchestrator Support** commands are located on the right-click menu (or context menu) of the project node for an ASP.NET Core project in **Solution Explorer**, as shown in the following screenshot:

:::moniker range="<=vs-2019"
![Screenshot showing how to add Docker Support menu option in Visual Studio.](./media/overview/add-docker-support-menu.png)
:::moniker-end
:::moniker range=">=vs-2022"
![Screenshot showing how to add Docker Support menu option in Visual Studio.](./media/overview/vs-2022/add-docker-support.png)
:::moniker-end

:::moniker range="<=vs-2019"

## Add Docker support

When you add or enable Docker support, Visual Studio adds the following to the project:

- a *Dockerfile* file
- a `.dockerignore` file
- a NuGet package reference to the Microsoft.VisualStudio.Azure.Containers.Tools.Targets

The Dockerfile you add resembles the following code. In this example, the project was named `WebApplication-Docker`, and you chose Linux containers:

```dockerfile
#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["WebApplication-Docker/WebApplication-Docker.csproj", "WebApplication-Docker/"]
RUN dotnet restore "WebApplication-Docker/WebApplication-Docker.csproj"
COPY . .
WORKDIR "/src/WebApplication-Docker"
RUN dotnet build "WebApplication-Docker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApplication-Docker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication-Docker.dll"]
```

:::moniker-end
:::moniker range=">=vs-2022"

## Choose the container build type and other options

When you add or enable Docker support to a .NET 7 or later project, Visual Studio shows the **Container Scaffolding Options** dialog box, which gives you the choice of operating system (Linux or Windows), but also the ability to choose the container build type, either **Dockerfile** or **.NET SDK**. This dialog box doesn't appear in .NET Framework projects or Azure Functions projects.

In 17.11 and later, you can also specify the **Container Image Distro** and the **Docker Build Context**.

![Screenshot showing the Container Scaffolding Options dialog for adding Docker support.](./media/overview/vs-2022/container-scaffolding-options.png)

**Container Image Distro** specifies which OS image your containers use as the base image. This list changes if you switch between Linux and Windows as the container type.

The following images are available:

Windows:

- Windows Nano Server (recommended, only available 8.0 and later, not preset for [Native Ahead-of-time (AOT) deployment](/dotnet/core/deploying/native-aot/) projects)
- Windows Server Core (only available 8.0 and later)

Linux:

- Default (Debian, but the tag is "8.0")
- Debian
- Ubuntu
- Chiseled Ubuntu
- Alpine

> [!NOTE]
> Containers based on the Chiseled Ubuntu image and that use [Native Ahead-of-time (AOT) deployment](/dotnet/core/deploying/native-aot/) can only be debugged in Fast Mode. See [Customize Docker containers in Visual Studio](container-build.md).

**Docker Build Context** specifies the folder that is used for the Docker build. See [Docker build context](https://docs.docker.com/build/building/context/). The default is the solution folder, which is recommended. All the files needed for a build need to be under this folder, which is not the case if you choose the project folder or some other folder.

### Dockerfile container build type

If you choose the **Dockerfile** container build type, Visual Studio adds the following to the project:

- a *Dockerfile* file
- a `.dockerignore` file
- a NuGet package reference to the Microsoft.VisualStudio.Azure.Containers.Tools.Targets

The Dockerfile you add will resemble the following code. In this example, the project was named `WebApplication-Docker`, and you chose Linux containers:

```dockerfile
#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WebApplication-Docker/WebApplication-Docker.csproj", "WebApplication-Docker/"]
RUN dotnet restore "WebApplication-Docker/WebApplication-Docker.csproj"
COPY . .
WORKDIR "/src/WebApplication-Docker"
RUN dotnet build "WebApplication-Docker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApplication-Docker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication-Docker.dll"]
```

### .NET SDK container build type

With Visual Studio 2022 17.9 and later with the .NET 7 SDK installed, in ASP.NET Core projects that target .NET 6 or later, you have the option of using .NET SDK's built-in support for container builds, which means you don't need a Dockerfile; see [Containerize a .NET app with dotnet publish](/dotnet/core/docker/publish-as-container?pivots=dotnet-8-0). Instead, you configure your containers using MSBuild properties in the project file, and the settings for launching the containers with Visual Studio are encoded in a `.json` configuration file, *launchSettings.json*.

![Screenshot showing the Container Scaffolding Options dialog for adding Docker support with .NET SDK selected as the container build type.](./media/overview/vs-2022/container-scaffolding-options-net-sdk.png)

Here, choose **.NET SDK** as the container build type to use .NET SDK's container management instead of a Dockerfile.

**Container Image Distro** specifies which OS image your containers use as the base image. This list changes if you switch between Linux and Windows as the container. See the previous section for a list of available images.

The .NET SDK container build entry in *launchSettings.json* looks like the following code:

```json
"Container (.NET SDK)": {
  "commandName": "SdkContainer",
  "launchBrowser": true,
  "launchUrl": "{Scheme}://{ServiceHost}:{ServicePort}",
  "environmentVariables": {
    "ASPNETCORE_HTTPS_PORTS": "8081",
    "ASPNETCORE_HTTP_PORTS": "8080"
  },
  "publishAllPorts": true,
  "useSSL": true
}
```

The .NET SDK manages some of the settings that would have been encoded in a Dockerfile, such as the container base image, and the environment variables to set. The settings available in the project file for container configuration are listed at [Customizing your container](https://github.com/dotnet/sdk-container-builds/blob/main/docs/ContainerCustomization.md). For example, the **Container Image Distro** is saved in the project file as the `ContainerBaseImage` property. You can change it later by editing the project file.

```xml
<PropertyGroup>
    <ContainerBaseImage>mcr.microsoft.com/dotnet/runtime:8.0-alpine-amd64</ContainerBaseImage>
</PropertyGroup>
```

:::moniker-end

## Next steps

For further details on the services implementation and use of Visual Studio tools for working with containers, read the following articles:

[Docker in Visual Studio](container-tools.md)

[Debugging apps in a local Docker container](edit-and-refresh.md)

[Deploy an ASP.NET container to a container registry using Visual Studio](hosting-web-apps-in-docker.md)

[Deploy to Azure App Service](deploy-app-service.md)

[Deploy to Azure Container Apps using Visual Studio](/azure/container-apps/deploy-visual-studio)

## Related content

- [Visual Studio Container Tools for Docker](overview.md)
