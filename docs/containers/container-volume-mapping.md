---
title: Understand and customize volume mapping in Docker containers
author: ghogen
description: Explore how Visual Studio handles volume mapping for container images, and learn how to customize volume mappings.
ms.author: ghogen
ms.date: 8/19/2025
ms.subservice: container-tools
ms.topic: how-to


#customer intent: As a developer, I want to customize the volumes on my application's container so that I can access the files from my running app.
---

# Customize container volume mapping

For debugging to work in containers, Visual Studio uses volume mapping to map the debugger and NuGet folders from the host machine. Volume mapping is described in the Docker documentation [here](https://docs.docker.com/storage/volumes/). You can view the volume mappings for a container by using the [Containers window in Visual Studio](view-and-diagnose-containers.md).

## Prerequisites

- [Docker Desktop](https://docs.docker.com/desktop/install/windows-install/) or [Podman Desktop](https://podman-desktop.io/downloads).
- [Visual Studio 2019 or later](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) with the **Web Development**, **Azure Tools** workload, and/or **.NET desktop development** workload installed

## Volume mounts in Visual Studio container images

:::moniker range="<=vs-2019"
Here are the volumes that are mounted in your container:

|Volume|Description|
|-|-|
| **App folder** | Contains the project folder where the Dockerfile is located.|
| **NuGet packages folders** | Contains the NuGet packages and fallback folders that are read from the *obj\{project}.csproj.nuget.g.props* file in the project. |
| **Remote debugger** | Contains the bits required to run the debugger in the container depending on the project type. See [Customize container images for debugging](container-debug-customization.md).|
| **Source folder** | Contains the build context that is passed to Docker commands.|

:::moniker-end

::: moniker range="visualstudio"
Here are the volumes that are mounted in your container. What you see in your containers might differ depending on the minor version of Visual Studio you are using.

|Volume|Description|
|-|-|
| **App folder** | Contains the project folder where the Dockerfile is located.|
| **NuGet packages folders** | Contains the NuGet packages and fallback folders that are read from the *obj\{project}.csproj.nuget.g.props* file in the project. |
| **Remote debugger** | Contains the bits required to run the debugger in the container depending on the project type. For more information, see [Customize container images for debugging](container-debug-customization.md).|
| **Source folder** | Contains the build context that is passed to Docker commands.|
| **VSTools** | Contains Visual Studio tools that support working with the container, including support for the debugger, the **Containers** window, handling Azure tokens, the Hot Reload agent, and the Distroless Helper. |

For .NET 8, additional mount points at root and for the app user that contain user secrets and the HTTPS certificate might also be present.

> [!NOTE]
> If you're using Docker Engine in Windows Subsystem for Linux (WSL) without Docker Desktop, set the environment variable `VSCT_WslDaemon=1` to have Visual Studio use WSL paths when creating volume mounts. The NuGet package [Microsoft.VisualStudio.Azure.Containers.Tools.Targets 1.20.0-Preview 1](https://www.nuget.org/packages/Microsoft.VisualStudio.Azure.Containers.Tools.Targets/1.20.0-Preview.1) is also required.

:::moniker-end

::: moniker range="vs-2022"
Here are the volumes that are mounted in your container. What you see in your containers might differ depending on the minor version of Visual Studio 2022 you are using.

|Volume|Description|
|-|-|
| **App folder** | Contains the project folder where the Dockerfile is located.|
| **NuGet packages folders** | Contains the NuGet packages and fallback folders that are read from the *obj\{project}.csproj.nuget.g.props* file in the project. |
| **Remote debugger** | Contains the bits required to run the debugger in the container depending on the project type. For more information, see [Customize container images for debugging](container-debug-customization.md).|
| **Source folder** | Contains the build context that is passed to Docker commands.|
| **VSTools** | Contains Visual Studio tools that support working with the container, including support for the debugger, the **Containers** window, handling Azure tokens, the Hot Reload agent, and the Distroless Helper. |

For .NET 8, additional mount points at root and for the app user that contain user secrets and the HTTPS certificate might also be present.

> [!NOTE]
> **Visual Studio 17.10** If you're using Docker Engine in Windows Subsystem for Linux (WSL) without Docker Desktop, set the environment variable `VSCT_WslDaemon=1` to have Visual Studio use WSL paths when creating volume mounts. The NuGet package [Microsoft.VisualStudio.Azure.Containers.Tools.Targets 1.20.0-Preview 1](https://www.nuget.org/packages/Microsoft.VisualStudio.Azure.Containers.Tools.Targets/1.20.0-Preview.1) is also required.

:::moniker-end

For ASP.NET core web apps, there might be two additional folders for the SSL certificate and the user secrets, which is explained in more detail at [Use SSL for containerized ASP.NET Core apps](container-certificate-management.md)

## Mount a container volume

You can mount another volume using `docker run` command-line arguments.

1. Open the project file for the containerized project.
1. To specify a new command-line argument, add the MSBuild property `DockerfileRunArguments`, and provide the `-v` or `--mount` syntax. For example, the following syntax creates a volume `myvolume` and mounts it in the container in the folder `/scratch`.

   ```xml
   <PropertyGroup>
      <DockerfileRunArguments>-v myvolume:/scratch</DockerfileRunArguments>
   </PropertyGroup>
   ```

   Refer to the Docker documentation for the command-line syntax for the [-v or --mount](https://docs.docker.com/engine/storage/volumes/#choose-the--v-or---mount-flag) options.

## Related content

- [Customize Docker containers in Visual Studio](container-build.md)
- [Dockerfile on Windows](/virtualization/windowscontainers/manage-docker/manage-windows-dockerfile)
- [Linux containers on Windows](/virtualization/windowscontainers/deploy-containers/linux-containers)
