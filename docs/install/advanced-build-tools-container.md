---
title: "Advanced example for containers"
description: ""
ms.date: 07/03/2019
ms.topic: conceptual
ms.assetid: e03835db-a616-41e6-b339-92b41d0cfc70
author: heaths
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Advanced example for containers

::: moniker range="vs-2017"

The sample Dockerfile in [Install Build Tools into a container](build-tools-container.md) always uses the [microsoft/dotnet-framework:4.7.2](https://hub.docker.com/r/microsoft/dotnet-framework) image based on the latest microsoft/windowsservercore image and the latest Visual Studio Build Tools installer. If you publish this image to a [Docker registry](https://azure.microsoft.com/services/container-registry) for others to pull, this image might be okay for many scenarios. However, in practice it's more common to be specific about what base image you use, what binaries you download, and which tool versions you install.

::: moniker-end

::: moniker range="vs-2019"

The sample Dockerfile in [Install Build Tools into a container](build-tools-container.md) always uses the [microsoft/dotnet-framework:4.8](https://hub.docker.com/r/microsoft/dotnet-framework) image based on the latest microsoft/windowsservercore image and the latest Visual Studio Build Tools installer. If you publish this image to a [Docker registry](https://azure.microsoft.com/services/container-registry) for others to pull, this image might be okay for many scenarios. However, in practice it's more common to be specific about what base image you use, what binaries you download, and which tool versions you install.

::: moniker-end

The following example Dockerfile uses a specific version tag of the microsoft/dotnet-framework image. Using a specific tag for a base image is commonplace and makes it easy to remember that building or rebuilding images always has the same basis.

> [!NOTE]
> You cannot install Visual Studio into microsoft/windowsservercore:10.0.14393.1593 or any image based on it, which has known issues launching the installer in a container. For more information, see [Known issues for containers](build-tools-container-issues.md).

The following example downloads the latest release of Build Tools. If you want to use an earlier version of Build Tools that you can install into a container later, you must first [create](create-an-offline-installation-of-visual-studio.md) and [maintain](update-a-network-installation-of-visual-studio.md) a layout.

## Install script

To collect logs when an install error occurs, create a batch script that's named "Install.cmd" in the working directory that includes the following content:

```shell
@if not defined _echo echo off
setlocal enabledelayedexpansion

call %*
if "%ERRORLEVEL%"=="3010" (
    exit /b 0
) else (
    if not "%ERRORLEVEL%"=="0" (
        set ERR=%ERRORLEVEL%
        call C:\TEMP\collect.exe -zip:C:\vslogs.zip

        exit /b !ERR!
    )
)
```

## Dockerfile

In the working directory, create the "Dockerfile" with the following content:

::: moniker range="vs-2017"

```dockerfile
# escape=`

# Use a specific tagged image. Tags can be changed, though that is unlikely for most images.
# You could also use the immutable tag @sha256:3eaa3ba18f45e6561f32d8dd927045413f1dd043d7d29fb581f5cb3c6f7d7481
ARG FROM_IMAGE=mcr.microsoft.com/dotnet/framework/sdk:4.7.2-windowsservercore-ltsc2019
FROM ${FROM_IMAGE}

# Copy our Install script.
COPY Install.cmd C:\TEMP\

# Download collect.exe in case of an install failure.
ADD https://aka.ms/vscollect.exe C:\TEMP\collect.exe

# Use the latest release channel. For more control, specify the location of an internal layout.
ARG CHANNEL_URL=https://aka.ms/vs/15/release/channel
ADD ${CHANNEL_URL} C:\TEMP\VisualStudio.chman

# Download and install Build Tools excluding workloads and components with known issues.
ADD https://aka.ms/vs/15/release/vs_buildtools.exe C:\TEMP\vs_buildtools.exe
RUN C:\TEMP\Install.cmd C:\TEMP\vs_buildtools.exe --quiet --wait --norestart --nocache `
    --installPath C:\BuildTools `
    --channelUri C:\TEMP\VisualStudio.chman `
    --installChannelUri C:\TEMP\VisualStudio.chman `
    --all `
    --remove Microsoft.VisualStudio.Component.Windows10SDK.10240 `
    --remove Microsoft.VisualStudio.Component.Windows10SDK.10586 `
    --remove Microsoft.VisualStudio.Component.Windows10SDK.14393 `
    --remove Microsoft.VisualStudio.Component.Windows81SDK

# Start developer command prompt with any other commands specified.
ENTRYPOINT C:\BuildTools\Common7\Tools\VsDevCmd.bat &&

# Default to PowerShell if no other command specified.
CMD ["powershell.exe", "-NoLogo", "-ExecutionPolicy", "Bypass"]
```

   > [!WARNING]
   > Visual Studio 2017 version 15.8 or earlier (any product) will not properly install on mcr\.microsoft\.com\/windows\/servercore:1809 or later. No error is displayed.
   >
   > See [Known issues for containers](build-tools-container-issues.md) for more information.

::: moniker-end

::: moniker range="vs-2019"

```dockerfile
# escape=`

# Use a specific tagged image. Tags can be changed, though that is unlikely for most images.
# You could also use the immutable tag @sha256:324e9ab7262331ebb16a4100d0fb1cfb804395a766e3bb1806c62989d1fc1326
ARG FROM_IMAGE=mcr.microsoft.com/dotnet/framework/sdk:4.8-windowsservercore-ltsc2019
FROM ${FROM_IMAGE}

# Copy our Install script.
COPY Install.cmd C:\TEMP\

# Download collect.exe in case of an install failure.
ADD https://aka.ms/vscollect.exe C:\TEMP\collect.exe

# Use the latest release channel. For more control, specify the location of an internal layout.
ARG CHANNEL_URL=https://aka.ms/vs/16/release/channel
ADD ${CHANNEL_URL} C:\TEMP\VisualStudio.chman

# Download and install Build Tools excluding workloads and components with known issues.
ADD https://aka.ms/vs/16/release/vs_buildtools.exe C:\TEMP\vs_buildtools.exe
RUN C:\TEMP\Install.cmd C:\TEMP\vs_buildtools.exe --quiet --wait --norestart --nocache `
    --installPath C:\BuildTools `
    --channelUri C:\TEMP\VisualStudio.chman `
    --installChannelUri C:\TEMP\VisualStudio.chman `
    --all `
    --remove Microsoft.VisualStudio.Component.Windows10SDK.10240 `
    --remove Microsoft.VisualStudio.Component.Windows10SDK.10586 `
    --remove Microsoft.VisualStudio.Component.Windows10SDK.14393 `
    --remove Microsoft.VisualStudio.Component.Windows81SDK

# Start developer command prompt with any other commands specified.
ENTRYPOINT C:\BuildTools\Common7\Tools\VsDevCmd.bat &&

# Default to PowerShell if no other command specified.
CMD ["powershell.exe", "-NoLogo", "-ExecutionPolicy", "Bypass"]
```

::: moniker-end

Run the following command to build the image in the current working directory:

::: moniker range="vs-2017"

```shell
docker build -t buildtools2017:15.6.27428.2037 -t buildtools2017:latest -m 2GB .
```

::: moniker-end

::: moniker range="vs-2019"

```shell
docker build -t buildtools2019:16.0.28714.193 -t buildtools2019:latest -m 2GB .
```

::: moniker-end

Optionally pass either or both `FROM_IMAGE` or `CHANNEL_URL` arguments using the `--build-arg` command-line switch to specify a different base image or the location of an internal layout to maintain a fixed image.

## Diagnosing install failures

This example downloads specific tools and validates that the hashes match. It also downloads the latest Visual Studio and .NET log collection utility so that if an install failure does occur, you can copy the logs to your host machine to analyze the failure.

::: moniker range="vs-2017"

```shell
> docker build -t buildtools2017:15.6.27428.2037 -t buildtools2017:latest -m 2GB .
Sending build context to Docker daemon

...
Step 8/10 : RUN C:\TEMP\Install.cmd C:\TEMP\vs_buildtools.exe --quiet --wait --norestart --nocache ...
 ---> Running in 4b62b4ce3a3c
The command 'cmd /S /C C:\TEMP\Install.cmd C:\TEMP\vs_buildtools.exe ...' returned a non-zero code: 1603

> docker cp 4b62b4ce3a3c:C:\vslogs.zip "%TEMP%\vslogs.zip"
```

::: moniker-end

::: moniker range="vs-2019"

```shell
> docker build -t buildtools2019:16.0.28714.193 -t buildtools2019:latest -m 2GB .
Sending build context to Docker daemon

...
Step 8/10 : RUN C:\TEMP\Install.cmd C:\TEMP\vs_buildtools.exe --quiet --wait --norestart --nocache ...
 ---> Running in 4b62b4ce3a3c
The command 'cmd /S /C C:\TEMP\Install.cmd C:\TEMP\vs_buildtools.exe ...' returned a non-zero code: 1603

> docker cp 4b62b4ce3a3c:C:\vslogs.zip "%TEMP%\vslogs.zip"
```

::: moniker-end

After the last line finishes executing, open "%TEMP%\vslogs.zip" on your machine, or submit an issue on the [Developer Community](https://developercommunity.visualstudio.com) website.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Install Build Tools into a Container](build-tools-container.md)
* [Known Issues for Containers](build-tools-container-issues.md)
* [Visual Studio Build Tools workload and component IDs](workload-component-id-vs-build-tools.md)
