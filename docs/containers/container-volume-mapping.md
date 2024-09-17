---
title: Understand volume mapping in Docker containers in Visual Studio
author: ghogen
description: Explore how Visual Studio handles volume mapping for container images.
ms.author: ghogen
ms.date: 09/17/2024
ms.subservice: container-tools
ms.topic: conceptual
---

## Container volume mapping

For debugging to work in containers, Visual Studio uses volume mapping to map the debugger and NuGet folders from the host machine. Volume mapping is described in the Docker documentation [here](https://docs.docker.com/storage/volumes/). You can view the volume mappings for a container by using the [Containers window in Visual Studio](view-and-diagnose-containers.md).

:::moniker range="<=vs-2019"
Here are the volumes that are mounted in your container:

|Volume|Description|
|-|-|
| **App folder** | Contains the project folder where the Dockerfile is located.|
| **NuGet packages folders** | Contains the NuGet packages and fallback folders that are read from the *obj\{project}.csproj.nuget.g.props* file in the project. |
| **Remote debugger** | Contains the bits required to run the debugger in the container depending on the project type. See the [Debugging](#debugging) section.|
| **Source folder** | Contains the build context that is passed to Docker commands.|

:::moniker-end

::: moniker range=">=vs-2022"
Here are the volumes that are mounted in your container. What you see in your containers might differ depending on the minor version of Visual Studio 2022 you are using.

|Volume|Description|
|-|-|
| **App folder** | Contains the project folder where the Dockerfile is located.|
| **HotReloadAgent** | Contains the files for the hot reload agent. |
| **HotReloadProxy** | Contains the files required to run a service that enables the host reload agent to communicate with Visual Studio on the host. |
| **NuGet packages folders** | Contains the NuGet packages and fallback folders that are read from the *obj\{project}.csproj.nuget.g.props* file in the project. |
| **Remote debugger** | Contains the bits required to run the debugger in the container depending on the project type. This is explained in more detail in the [Debugging](#debugging) section.|
| **Source folder** | Contains the build context that is passed to Docker commands.|
| **TokenService.Proxy** | Contains the files required to run a service the enables VisualStudioCredential to communicate with Visual Studio on the host. |

For .NET 8, additional mount points at root and for the app user that contain user secrets and the HTTPS certificate might also be present. And in Visual Studio 17.10 preview, the Hot Reload and Token Service volume, along with another component, the Distroless Helper, are combined under a single mount point, `/VSTools`.

> [!NOTE]
> **Visual Studio 17.10 preview** If you're using Docker Engine in Windows Subsystem for Linux (WSL) without Docker Desktop, set the environment variable `VSCT_WslDaemon=1` to have Visual Studio use WSL paths when creating volume mounts. The NuGet package [Microsoft.VisualStudio.Azure.Containers.Tools.Targets 1.20.0-Preview 1](https://www.nuget.org/packages/Microsoft.VisualStudio.Azure.Containers.Tools.Targets/1.20.0-Preview.1) is also required.

:::moniker-end

For ASP.NET core web apps, there might be two additional folders for the SSL certificate and the user secrets, which is explained in more detail at [Use SSL for containerized ASP.NET Core apps](container-certificate-management.md)

## Related content

- [Customize Docker containers in Visual Studio](container-build.md)
- [Dockerfile on Windows](/virtualization/windowscontainers/manage-docker/manage-windows-dockerfile)
- [Linux containers on Windows](/virtualization/windowscontainers/deploy-containers/linux-containers)
