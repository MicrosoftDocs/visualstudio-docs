---
title: "Install Visual Studio Build Tools into a container"
titleSuffix: ""
description: "Learn how to install Visual Studio Build Tools into a Windows container to support continuous integration and continuous delivery (CI/CD) workflows."
ms.date: 04/18/2018
ms.custom: "seodec18"
ms.topic: conceptual
ms.assetid: d5c038e2-e70d-411e-950c-8a54917b578a
author: heaths
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Install Build Tools into a container

You can install Visual Studio Build Tools into a Windows container to support continuous integration and continuous delivery (CI/CD) workflows. This article guides you through what Docker configuration changes are required as well as what [workloads and components](workload-component-id-vs-build-tools.md) you can install in a container.

[Containers](https://www.docker.com/what-container) are a great way to package a consistent build system you can use not only in a CI/CD server environment but for development environments as well. For example, you can mount your source code into a container to be built by a customized environment while you continue to use Visual Studio or other tools to write your code. If your CI/CD workflow uses the same container image, you can rest assured that your code builds consistently. You can use containers for runtime consistency as well, which is common for micro-services using multiple containers with an orchestration system; however, is beyond the scope of this article.

If Visual Studio Build Tools does not have what you require to build your source code, these same steps can be used for other Visual Studio products. Do note, however, that Windows containers do not support an interactive user interface so all commands must be automated.

## Overview

Using [Docker](https://www.docker.com/what-docker), you create an image from which you can create containers that build your source code. The example Dockerfile installs the latest Visual Studio Build Tools and some other helpful programs often used for building source code. You can further modify your own Dockerfile to include other tools and scripts to run tests, publish build output, and more.

If you have already installed Docker for Windows, you can skip to step 3.

## Step 1. Enable Hyper-V

Hyper-V is not enabled by default. It must be enabled to start Docker for Windows, since currently only Hyper-V isolation is supported for Windows 10.

* [Enable Hyper-V on Windows 10](https://docs.microsoft.com/virtualization/hyper-v-on-windows/quick-start/enable-hyper-v)
* [Enable Hyper-V on Windows Server 2016](https://docs.microsoft.com/windows-server/virtualization/hyper-v/get-started/install-the-hyper-v-role-on-windows-server)

> [!NOTE]
> Virtualization must be enabled on your machine. It is typically enabled by default; however, if Hyper-V install fails, refer to your system documentation for how to enable virtualization.

## Step 2. Install Docker for Windows

If you use Windows 10, you can [download and install Docker Community Edition](https://docs.docker.com/docker-for-windows/install). If you use Windows Server 2016, follow [instructions to install Docker Enterprise Edition](https://docs.docker.com/install/windows/docker-ee).

## Step 3. Switch to Windows Containers

You can install Build Tools only on Windows, which requires you [switch to Windows containers](https://docs.docker.com/docker-for-windows/#getting-started-with-windows-containers). Windows containers on Windows 10 support only [Hyper-V isolation](https://docs.microsoft.com/virtualization/windowscontainers/manage-containers/hyperv-container), while Windows containers on Windows Server 2016 support both Hyper-V and process isolation.

## Step 4. Expand maximum container disk size

Visual Studio Build Tools - and to a greater extent, Visual Studio - require lots of disk space for all the tools that get installed. Even though the example Dockerfile disables the package cache, the disk size of container images must be increased to accommodate the space required. Currently on Windows, you can only increase disk size by changing the Docker configuration.

**On Windows 10**:

1. [Right-click on the Docker for Windows icon](https://docs.docker.com/docker-for-windows/#docker-settings) in the system tray and click **Settings**.
2. [Click on the Daemon](https://docs.docker.com/docker-for-windows/#docker-daemon) section.
3. [Toggle the **Basic**](https://docs.docker.com/docker-for-windows/#edit-the-daemon-configuration-file) button to **Advanced**.
4. Add the following JSON array property to increase disk space to 120 GB (more than enough for Build Tools with room to grow).

   ```json
   {
     "storage-opts": [
       "size=120GB"
     ]
   }
   ```

   This property is added to anything you already have. For example, with these changes applied to the default daemon configuration file, you should now see:

   ```json
   {
     "registry-mirrors": [],
     "insecure-registries": [],
     "debug": true,
     "experimental": true,
     "storage-opts": [
       "size=120GB"
     ]
   }
   ```

5. Click **Apply**.

**On Windows Server 2016**:

1. Stop the "docker" service:

   ```shell
   sc.exe stop docker
   ```

2. From an elevated command prompt, edit "%ProgramData%\Docker\config\daemon.json" (or whatever you specified to `dockerd --config-file`).
3. Add the following JSON array property to increase disk space to 120 GB (more than enough for Build Tools with room to grow).

   ```json
   {
     "storage-opts": [
       "size=120GB"
     ]
   }
   ```

   This property is added to anything you already have.
4. Save and close the file.
5. Start the "docker" service:

   ```shell
   sc.exe start docker
   ```

## Step 5. Create and build the Dockerfile

Save the following example Dockerfile to a new file on your disk. If the file is named simply "Dockerfile", it is recognized by default.

> [!WARNING]
> This example Dockerfile excludes only earlier Windows SDKs that cannot be installed into containers. Earlier releases cause the build command to fail.

1. Open a command prompt.

1. Create a new directory (recommended):

   ```shell
   mkdir C:\BuildTools
   ```

1. Change directories to this new directory:

   ```shell
   cd C:\BuildTools
   ```

1. Save the following content to C:\BuildTools\Dockerfile.

   ```dockerfile
   # escape=`

   # Use the latest Windows Server Core image with .NET Framework 4.7.1.
   FROM microsoft/dotnet-framework:4.7.1

   # Restore the default Windows shell for correct batch processing.
   SHELL ["cmd", "/S", "/C"]

   # Download the Build Tools bootstrapper.
   ADD https://aka.ms/vs/15/release/vs_buildtools.exe C:\TEMP\vs_buildtools.exe

   # Install Build Tools excluding workloads and components with known issues.
   RUN C:\TEMP\vs_buildtools.exe --quiet --wait --norestart --nocache `
       --installPath C:\BuildTools `
       --all `
       --remove Microsoft.VisualStudio.Component.Windows10SDK.10240 `
       --remove Microsoft.VisualStudio.Component.Windows10SDK.10586 `
       --remove Microsoft.VisualStudio.Component.Windows10SDK.14393 `
       --remove Microsoft.VisualStudio.Component.Windows81SDK `
    || IF "%ERRORLEVEL%"=="3010" EXIT 0

   # Start developer command prompt with any other commands specified.
   ENTRYPOINT C:\BuildTools\Common7\Tools\VsDevCmd.bat &&

   # Default to PowerShell if no other command specified.
   CMD ["powershell.exe", "-NoLogo", "-ExecutionPolicy", "Bypass"]
   ```

   > [!WARNING]
   > If you base your image directly on microsoft/windowsservercore, the .NET Framework might not install properly and no install error is indicated. Managed code might not run after the install is complete. Instead, base your image on [microsoft/dotnet-framework:4.7.1](https://hub.docker.com/r/microsoft/dotnet-framework) or later. Also note that images that are tagged version 4.7.1 or later might use PowerShell as the default `SHELL`, which will cause the `RUN` and `ENTRYPOINT` instructions to fail.
   >
   > Visual Studio 2017 version 15.8 or earlier (any product) will not properly install on mcr\.microsoft\.com\/windows\/servercore:1809 or later. No error is displayed.
   >
   > See [Known issues for containers](build-tools-container-issues.md) for more information.

4. Run the following command within that directory.

   ```shell
   docker build -t buildtools2017:latest -m 2GB .
   ```

   This command builds the Dockerfile in the current directory using 2 GB of memory. The default 1 GB is not sufficient when some workloads are installed; however, you might be able to build with only 1 GB of memory depending on your build requirements.

   The final image is tagged "buildtools2017:latest" so you can easily run it in a container as "buildtools2017" since the "latest" tag is the default if no tag is specified. If you want to use a specific version of Visual Studio Build Tools 2017 in a more [advanced scenario](advanced-build-tools-container.md), you might instead tag the container with a specific Visual Studio build number as well as "latest" so containers can use a specific version consistently.

## Step 6. Using the built image

Now that you have created an image, you can run it in a container to do both interactive and automated builds. The example uses the Developer Command Prompt, so your PATH and other environment variables are already configured.

1. Open a command prompt.

1. Run the container to start a PowerShell environment with all developer environment variables set:

   ```shell
   docker run -it buildtools2017
   ```

To use this image for your CI/CD workflow, you can publish it to your own [Azure Container Registry](https://azure.microsoft.com/services/container-registry) or other internal [Docker registry](https://docs.docker.com/registry/deploying) so servers need only to pull it.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Advanced Example for Containers](advanced-build-tools-container.md)
* [Known Issues for Containers](build-tools-container-issues.md)
* [Visual Studio Build Tools workload and component IDs](workload-component-id-vs-build-tools.md)
