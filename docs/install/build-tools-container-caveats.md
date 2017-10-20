---
title: "Known issues for containers | Microsoft Docs"
ms.custom: ""
ms.date: "10/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: "140083f1-05bc-4014-949e-fb5802397c7a"
author: "heaths"
ms.author: "heaths"
manager: "ghogen"
---
# Known issues for containers

There a few issues when installing Visual Studio into a Docker container.

## Windows container

The following known issues occur when you install Visual Studio Build Tools 2017 into a Windows container.

* You cannot install Visual Studio into a container based on image microsoft/windowsservercore:10.0.14393.1593. Images tagged with Windows versions older or newer should work.
* You cannot install Windows SDK versions older than 10.0.14393. Certain packages fail to install and workloads that depend on those packages will not work.
* You must pass `-m 2GB` (or more) when building the image. Some workloads require more memory than the default 1 GB when installed.
* You must configure Docker to use disks larger than the default 20 GB.
* You must pass `--norestart` on the command line. As of this writing, attempting to restart a Windows container from within the container returns `ERROR_TOO_MANY_OPEN_FILES` to the host.

## Build Tools container

The following known issues might occur when you use a Build Tools container. To see whether issues have been fixed or if there are other known issues, visit https://developercommunity.visualstudio.com.

* IntelliTrace may not work in [some scenarios](https://github.com/Microsoft/vstest/issues/940) within a container.

## See also

* [Install Build Tools into a Container](build-tools-container.md)
* [Advanced Example for Containers](advanced-build-tools-container.md)
