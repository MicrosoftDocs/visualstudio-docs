---
title: Learn how to set the container entry point for Docker containers in Visual Studio
author: ghogen
description: Understand and configure the custom container entry point set by Visual Studio based on the project type and the container operating system.
ms.author: ghogen
ms.date: 9/10/2025
ms.subservice: container-tools
ms.topic: conceptual
---

# Set the container entry point

A container entry point is a process that is configured to run when a container is started.

:::moniker range="visualstudio"

## Prerequisites

- [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows) or [Podman Desktop](https://podman-desktop.io/downloads).
- [Visual Studio](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta), or for Podman support, [Visual Studio (Insiders)](https://visualstudio.microsoft.com/insiders/?cid=learn-onpage-download-cta), with the **ASP.NET and web development**, **Azure development** workload, and/or **.NET desktop development** workload installed

:::moniker-end
::: moniker range="vs-2022"

## Prerequisites

- [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows).
- [Visual Studio](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) with the **ASP.NET and web development**, **Azure development** workload, and/or **.NET desktop development** workload installed

:::moniker-end

::: moniker range="vs-2019"

## Prerequisites

- [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows)
- [Visual Studio 2019 or later](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) with the **ASP.NET and web development**, **Azure development** workload, **.NET desktop development**, and/or **.NET Core cross-platform development** workload installed

:::moniker-end

## Entry point by project type

Visual Studio uses a custom container entry point depending on the project type and the container operating system, here are the different combinations:

:::moniker range="<=vs-2019"
|Container type|Entry point|
|-|-|
| **Linux containers** | The entry point is `tail -f /dev/null`, which is an infinite wait to keep the container running. When the app is launched through the debugger, it's the debugger that is responsible to run the app (that is, `dotnet webapp.dll`). If launched without debugging, the tooling runs a `docker exec -i {containerId} dotnet webapp.dll` to run the app.|
| **Windows containers**| The entry point is something like `C:\remote_debugger\x64\msvsmon.exe /noauth /anyuser /silent /nostatus` which runs the debugger, so it's listening for connections. This method applies when the debugger runs the app. When launched without debugging, a `docker exec` command is used. For .NET Framework web apps, the entry point is slightly different where `ServiceMonitor` is added to the command.|
:::moniker-end

:::moniker range="vs-2022"
|Container type|Entry point|
|-|-|
| **Linux containers** | For .NET 6 and later, the entry point is `dotnet --roll-forward Major /VSTools/DistrolessHelper/DistrolessHelper.dll --wait`. For .NET 5 and earlier, the entry point is `tail -f /dev/null`. These processes use an infinite wait to keep the container running when the app is not running. When the app is launched, with or without debugging, it's the debugger that is responsible to run the app (that is, `dotnet webapp.dll`) and keep the container running.|
| **Windows containers**| The entry point is something like `C:\remote_debugger\x64\msvsmon.exe /noauth /anyuser /silent /nostatus` which runs the debugger, so it's listening for connections. For .NET Framework web apps, the entry point is slightly different where `ServiceMonitor` is added to the command.|
:::moniker-end

:::moniker range="visualstudio"
|Container type|Entry point|
|-|-|
| **Linux containers** | For .NET 6 and later, the entry point is `dotnet --roll-forward Major /VSTools/DistrolessHelper/DistrolessHelper.dll --wait`. For .NET 5 and earlier, the entry point is `tail -f /dev/null`. These processes use an infinite wait to keep the container running when the app is not running. When the app is launched, with or without debugging, it's the debugger that is responsible to run the app (that is, `dotnet webapp.dll`). `DistrolessHelper` monitors the app process, and exits with the app's exit code when the app process ends.|
| **Windows containers**| The entry point is something like `C:\remote_debugger\x64\msvsmon.exe /noauth /anyuser /silent /nostatus` which runs the debugger, so it's listening for connections.|
:::moniker-end

The container entry point can only be modified in Docker Compose projects, not in single-container projects. See [Docker Compose properties - Customize the app startup process](docker-compose-properties.md#customize-the-app-startup-process).

## Related content

- [MSBuild properties for container projects](container-msbuild-properties.md).
- [MSBuild](../msbuild/msbuild.md)
- [Dockerfile on Windows](/virtualization/windowscontainers/manage-docker/manage-windows-dockerfile)
- [Linux containers on Windows](/virtualization/windowscontainers/deploy-containers/linux-containers)
