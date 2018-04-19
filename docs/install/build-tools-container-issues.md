---
title: "Known issues for containers"
description: "Learn more about the known issues that might occur when you install Visual Studio Build Tools 2017 into a Windows container."
ms.custom: ""
ms.date: 04/18/2018
ms.technology: vs-acquisition
ms.prod: visual-studio-dev15
ms.topic: conceptual
ms.assetid: "140083f1-05bc-4014-949e-fb5802397c7a"
author: heaths
ms.author: tglee
manager: douge
ms.workload:
  - "multiple"
---
# Known issues for containers

There are a few issues when installing Visual Studio into a Docker container.

## Windows container

The following known issues occur when you install Visual Studio Build Tools 2017 into a Windows container.

* You cannot install Visual Studio into a container based on image microsoft/windowsservercore:10.0.14393.1593. Images tagged with Windows versions older or newer should work.
* You cannot install Windows SDK versions older than 10.0.14393. Certain packages fail to install and workloads that depend on those packages will not work.
* Pass `-m 2GB` (or more) when building the image. Some workloads require more memory than the default 1 GB when installed.
* Configure Docker to use disks larger than the default 20 GB.
* Pass `--norestart` on the command line. As of this writing, attempting to restart a Windows container from within the container returns `ERROR_TOO_MANY_OPEN_FILES` to the host.
* If you base your image directly on microsoft/windowsservercore, the .NET Framework may not install properly and no install error is indicated. Managed code may not run after the install is complete. Instead, base your image on [microsoft/dotnet-framework:4.7.1](https://hub.docker.com/r/microsoft/dotnet-framework) or newer. As an example, you may see an error when building with MSBuild like:

  > C:\BuildTools\MSBuild\15.0\bin\Roslyn\Microsoft.CSharp.Core.targets(84,5): error MSB6003: The specified task executable "csc.exe" could not be run. Could not load file or assembly 'System.IO.FileSystem, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.

## Build Tools container

The following known issues might occur when you use a Build Tools container. To see whether issues have been fixed or if there are other known issues, visit https://developercommunity.visualstudio.com.

* IntelliTrace may not work in [some scenarios](https://github.com/Microsoft/vstest/issues/940) within a container.

## Get support

Sometimes, things can go wrong. If your Visual Studio installation fails, see the [Troubleshooting Visual Studio 2017 installation and upgrade issues](troubleshooting-installation-issues.md) page. If none of the troubleshooting steps help, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

Here are a few more support options:

* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues and find answers in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/).
* You can also engage with us and other Visual Studio developers through the [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio). (This option requires a [GitHub](https://github.com/) account.)

## See also

* [Install Build Tools into a Container](build-tools-container.md)
* [Advanced Example for Containers](advanced-build-tools-container.md)
* [Visual Studio Build Tools 2017 workload and component IDs](workload-component-id-vs-build-tools.md)
