---
title: "Known issues for containers"
description: "Learn more about the known issues that might occur when you install Visual Studio Build Tools into a Windows container."
ms.date: 07/03/2019
ms.custom: "seodec18"
ms.topic: conceptual
ms.assetid: "140083f1-05bc-4014-949e-fb5802397c7a"
author: heaths
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Known issues for containers

There are a few issues when installing Visual Studio into a Docker container.

## Windows container

The following known issues occur when you install Visual Studio Build Tools into a Windows container.

::: moniker range="vs-2017"

* You cannot install Visual Studio into a container based on image microsoft/windowsservercore:10.0.14393.1593. Images tagged with Windows versions before or after 10.0.14393 should work.

* You cannot install Windows SDK version 10.0.14393 or earlier. Certain packages fail to install and workloads that depend on those packages will not work.

::: moniker-end

* Pass `-m 2GB` (or more) when building the image. Some workloads require more memory than the default 1 GB when installed.
* Configure Docker to use disks larger than the default 20 GB.
* Pass `--norestart` on the command line. As of this writing, attempting to restart a Windows container from within the container returns `ERROR_TOO_MANY_OPEN_FILES` to the host.
* If you base your image directly on microsoft/windowsservercore, the .NET Framework might not install properly and no install error is indicated. Managed code might not run after the install is complete. Instead, base your image on [microsoft/dotnet-framework:4.7.1](https://hub.docker.com/r/microsoft/dotnet-framework) or later. As an example, you might see an error when building with MSBuild that's similar to the following:

  > C:\BuildTools\MSBuild\15.0\bin\Roslyn\Microsoft.CSharp.Core.targets(84,5): error MSB6003: The specified task executable "csc.exe" could not be run. Could not load file or assembly 'System.IO.FileSystem, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.

::: moniker range="vs-2017"

* You cannot install Visual Studio 2017 version 15.8 or earlier (any product) on mcr.microsoft.com/windows/servercore:1809 or later. See https://aka.ms/setup/containers/servercore1809 for more information.

::: moniker-end

## Build Tools container

The following known issues might occur when you use a Build Tools container. To see whether issues have been fixed or if there are other known issues, visit https://developercommunity.visualstudio.com.

* IntelliTrace might not work in [some scenarios](https://github.com/Microsoft/vstest/issues/940) within a container.
* On older versions of Docker for Windows, the default container image size is only 20 GB and will not fit Build Tools. Follow [instructions to change image size](/virtualization/windowscontainers/manage-containers/container-storage#storage-limits) to 127 GB or more.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Install Build Tools into a Container](build-tools-container.md)
* [Advanced Example for Containers](advanced-build-tools-container.md)
* [Visual Studio Build Tools workload and component IDs](workload-component-id-vs-build-tools.md)
