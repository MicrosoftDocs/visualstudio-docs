---
title: Install Visual Studio Build Tools into a container
titleSuffix: ''
description: Learn how to install Visual Studio Build Tools into a Windows container to support continuous integration and continuous delivery (CI/CD) workflows.
ms.date: 06/09/2021
ms.topic: conceptual
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Install Build Tools into a container

You can install Visual Studio Build Tools into a Windows container to support continuous integration and continuous delivery (CI/CD) workflows. This article guides you through what Docker configuration changes are required as well as what [workloads and components](workload-component-id-vs-build-tools.md) you can install in a container.

[Containers](https://www.docker.com/what-container) are a great way to package a consistent build system you can use not only in a CI/CD server environment but for development environments as well. For example, you can mount your source code into a container to be built by a customized environment while you continue to use Visual Studio or other tools to write your code. If your CI/CD workflow uses the same container image, you can rest assured that your code builds consistently. You can use containers for runtime consistency as well, which is common for micro-services using multiple containers with an orchestration system; however, is beyond the scope of this article.

If Visual Studio Build Tools does not have what you require to build your source code, these same steps can be used for other Visual Studio products. Do note, however, that Windows containers do not support an interactive user interface so all commands must be automated.

## Before you begin

Some familiarity with [Docker](https://www.docker.com/what-docker) is assumed below. If you're not already familiar
with running Docker on Windows, read about how to [install and configure the Docker engine on Windows](/virtualization/windowscontainers/manage-docker/configure-docker-daemon).

The base image below is a sample and may not work for your system. Read [Windows container version compatibility](/virtualization/windowscontainers/deploy-containers/version-compatibility)
to determine which base image you should use for your environment.

## Create and build the Dockerfile

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
 
   ::: moniker range="vs-2017"

   ```dockerfile
   # escape=`

   # Use the latest Windows Server Core image with .NET Framework 4.7.2.
   FROM mcr.microsoft.com/dotnet/framework/sdk:4.8-windowsservercore-ltsc2019

   # Restore the default Windows shell for correct batch processing.
   SHELL ["cmd", "/S", "/C"]

   RUN `
       # Download the Build Tools bootstrapper.
       curl -SL --output vs_buildtools.exe https://aka.ms/vs/15/release/vs_buildtools.exe `
       `
       # Install Build Tools with the Microsoft.VisualStudio.Workload.AzureBuildTools workload, excluding workloads and components with known issues.
       && (start /w vs_buildtools.exe --quiet --wait --norestart --nocache `
           --installPath C:\BuildTools `
           --add Microsoft.VisualStudio.Workload.AzureBuildTools `
           --remove Microsoft.VisualStudio.Component.Windows10SDK.10240 `
           --remove Microsoft.VisualStudio.Component.Windows10SDK.10586 `
           --remove Microsoft.VisualStudio.Component.Windows10SDK.14393 `
           --remove Microsoft.VisualStudio.Component.Windows81SDK `
           || IF "%ERRORLEVEL%"=="3010" EXIT 0) `
       `
       # Cleanup
       && del /q vs_buildtools.exe

   # Define the entry point for the Docker container.
   # This entry point starts the developer command prompt and launches the PowerShell shell.
   ENTRYPOINT ["C:\\BuildTools\\Common7\\Tools\\VsDevCmd.bat", "&&", "powershell.exe", "-NoLogo", "-ExecutionPolicy", "Bypass"]
   ```

   > [!TIP]
   > For a list of workloads and components, see the [Visual Studio Build Tools component directory](workload-component-id-vs-build-tools.md).
   >

   > [!WARNING]
   > If you base your image directly on microsoft/windowsservercore or mcr.microsoft.com/windows/servercore (see [Microsoft syndicates container catalog](https://azure.microsoft.com/blog/microsoft-syndicates-container-catalog/)), the .NET Framework might not install properly and no install error is indicated. Managed code might not run after the install is complete. Instead, base your image on [microsoft/dotnet-framework:4.7.2](https://hub.docker.com/r/microsoft/dotnet-framework) or later. Also note that images that are tagged version 4.7.2 or later might use PowerShell as the default `SHELL`, which will cause the `RUN` and `ENTRYPOINT` instructions to fail.
   >
   > Visual Studio 2017 version 15.8 or earlier (any product) will not properly install on mcr.microsoft.com/windows/servercore:1809 or later. No error is displayed.
   >
   > See [Windows container version compatibility](/virtualization/windowscontainers/deploy-containers/version-compatibility) to see which container OS versions are supported on which host OS versions, and [Known issues for containers](build-tools-container-issues.md) for known issues.
   
   ::: moniker-end

   ::: moniker range="vs-2019"

   ```dockerfile
   # escape=`

   # Use the latest Windows Server Core image with .NET Framework 4.8.
   FROM mcr.microsoft.com/dotnet/framework/sdk:4.8-windowsservercore-ltsc2019

   # Restore the default Windows shell for correct batch processing.
   SHELL ["cmd", "/S", "/C"]

   RUN `
       # Download the Build Tools bootstrapper.
       curl -SL --output vs_buildtools.exe https://aka.ms/vs/16/release/vs_buildtools.exe `
       `
       # Install Build Tools with the Microsoft.VisualStudio.Workload.AzureBuildTools workload, excluding workloads and components with known issues.
       && (start /w vs_buildtools.exe --quiet --wait --norestart --nocache modify `
           --installPath "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\BuildTools" `
           --add Microsoft.VisualStudio.Workload.AzureBuildTools `
           --remove Microsoft.VisualStudio.Component.Windows10SDK.10240 `
           --remove Microsoft.VisualStudio.Component.Windows10SDK.10586 `
           --remove Microsoft.VisualStudio.Component.Windows10SDK.14393 `
           --remove Microsoft.VisualStudio.Component.Windows81SDK `
           || IF "%ERRORLEVEL%"=="3010" EXIT 0) `
       `
       # Cleanup
       && del /q vs_buildtools.exe

   # Define the entry point for the docker container.
   # This entry point starts the developer command prompt and launches the PowerShell shell.
   ENTRYPOINT ["C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\BuildTools\\Common7\\Tools\\VsDevCmd.bat", "&&", "powershell.exe", "-NoLogo", "-ExecutionPolicy", "Bypass"]
   ```

   > [!TIP]
   > For a list of workloads and components, see the [Visual Studio Build Tools component directory](workload-component-id-vs-build-tools.md).
   >

   > [!WARNING]
   > If you base your image directly on microsoft/windowsservercore, the .NET Framework might not install properly and no install error is indicated. Managed code might not run after the install is complete. Instead, base your image on [microsoft/dotnet-framework:4.8](https://hub.docker.com/r/microsoft/dotnet-framework) or later. Also note that images that are tagged version 4.8 or later might use PowerShell as the default `SHELL`, which will cause the `RUN` and `ENTRYPOINT` instructions to fail.
   >
   > See [Windows container version compatibility](/virtualization/windowscontainers/deploy-containers/version-compatibility) to see which container OS versions are supported on which host OS versions, and [Known issues for containers](build-tools-container-issues.md) for known issues.

   ::: moniker-end
   
   ::: moniker range=">=vs-2022"

   ```dockerfile
   # escape=`

   # Use the latest Windows Server Core image with .NET Framework 4.8.
   FROM mcr.microsoft.com/dotnet/framework/sdk:4.8-windowsservercore-ltsc2019

   # Restore the default Windows shell for correct batch processing.
   SHELL ["cmd", "/S", "/C"]

   RUN `
       # Download the Build Tools bootstrapper.
       curl -SL --output vs_buildtools.exe https://aka.ms/vs/17/release/vs_buildtools.exe `
       `
       # Install Build Tools with the Microsoft.VisualStudio.Workload.AzureBuildTools workload, excluding workloads and components with known issues.
       && (start /w vs_buildtools.exe --quiet --wait --norestart --nocache modify `
           --installPath "%ProgramFiles(x86)%\Microsoft Visual Studio\2022\BuildTools" `
           --add Microsoft.VisualStudio.Workload.AzureBuildTools `
           --remove Microsoft.VisualStudio.Component.Windows10SDK.10240 `
           --remove Microsoft.VisualStudio.Component.Windows10SDK.10586 `
           --remove Microsoft.VisualStudio.Component.Windows10SDK.14393 `
           --remove Microsoft.VisualStudio.Component.Windows81SDK `
           || IF "%ERRORLEVEL%"=="3010" EXIT 0) `
       `
       # Cleanup
       && del /q vs_buildtools.exe

   # Define the entry point for the docker container.
   # This entry point starts the developer command prompt and launches the PowerShell shell.
   ENTRYPOINT ["C:\\Program Files (x86)\\Microsoft Visual Studio\\2022\\BuildTools\\Common7\\Tools\\VsDevCmd.bat", "&&", "powershell.exe", "-NoLogo", "-ExecutionPolicy", "Bypass"]
   ```

   > [!TIP]
   > For a list of workloads and components, see the [Visual Studio Build Tools component directory](workload-component-id-vs-build-tools.md).
   >

   > [!WARNING]
   > If you base your image directly on microsoft/windowsservercore, the .NET Framework might not install properly and no install error is indicated. Managed code might not run after the install is complete. Instead, base your image on [microsoft/dotnet-framework:4.8](https://hub.docker.com/r/microsoft/dotnet-framework) or later. Also note that images that are tagged version 4.8 or later might use PowerShell as the default `SHELL`, which will cause the `RUN` and `ENTRYPOINT` instructions to fail.
   >
   > See [Windows container version compatibility](/virtualization/windowscontainers/deploy-containers/version-compatibility) to see which container OS versions are supported on which host OS versions, and [Known issues for containers](build-tools-container-issues.md) for known issues.

   ::: moniker-end
   > [!NOTE]
   > Error code `3010` is used to indicate success with a reboot required, see [MsiExec.exe error messages](/windows/win32/msi/error-codes) for more information.

1. Run the following command within that directory.

   ::: moniker range="vs-2017"

   ```shell
   docker build -t buildtools2017:latest -m 2GB .
   ```

   This command builds the Dockerfile in the current directory using 2 GB of memory. The default 1 GB is not sufficient when some workloads are installed; however, you might be able to build with only 1 GB of memory depending on your build requirements.

   The final image is tagged "buildtools2017:latest" so you can easily run it in a container as "buildtools2017" since the "latest" tag is the default if no tag is specified. If you want to use a specific version of Visual Studio Build Tools 2017 in a more [advanced scenario](advanced-build-tools-container.md), you might instead tag the container with a specific Visual Studio build number as well as "latest" so containers can use a specific version consistently.

   ::: moniker-end

   ::: moniker range="vs-2019"

   ```shell
   docker build -t buildtools2019:latest -m 2GB .
   ```

   This command builds the Dockerfile in the current directory using 2 GB of memory. The default 1 GB is not sufficient when some workloads are installed; however, you might be able to build with only 1 GB of memory depending on your build requirements.

   The final image is tagged "buildtools2019:latest" so you can easily run it in a container as "buildtools2019" since the "latest" tag is the default if no tag is specified. If you want to use a specific version of Visual Studio Build Tools 2019 in a more [advanced scenario](advanced-build-tools-container.md), you might instead tag the container with a specific Visual Studio build number as well as "latest" so containers can use a specific version consistently.

   ::: moniker-end

   ::: moniker range=">=vs-2022"

   ```shell
   docker build -t buildtools:latest -m 2GB .
   ```

   This command builds the Dockerfile in the current directory using 2 GB of memory. The default 1 GB is not sufficient when some workloads are installed; however, you might be able to build with only 1 GB of memory depending on your build requirements.

   The final image is tagged "buildtools:latest" so you can easily run it in a container as "buildtools" since the "latest" tag is the default if no tag is specified. If you want to use a specific version of Visual Studio Build Tools in a more [advanced scenario](advanced-build-tools-container.md), you might instead tag the container with a specific Visual Studio build number as well as "latest" so containers can use a specific version consistently.

   ::: moniker-end

## Using the built image

Now that you have created an image, you can run it in a container to do both interactive and automated builds. The example uses the Developer Command Prompt, so your PATH and other environment variables are already configured.

1. Open a command prompt.

1. Run the container to start a PowerShell environment with all developer environment variables set:

   ::: moniker range="vs-2017"

   ```shell
   docker run -it buildtools2017
   ```

   ::: moniker-end

   ::: moniker range="vs-2019"

   ```shell
   docker run -it buildtools2019
   ```

   ::: moniker-end

   ::: moniker range=">=vs-2022"

   ```shell
   docker run -it buildtools
   ```

   ::: moniker-end

To use this image for your CI/CD workflow, you can publish it to your own [Azure Container Registry](https://azure.microsoft.com/services/container-registry) or other internal [Docker registry](https://docs.docker.com/registry/deploying) so servers need only to pull it.

   > [!NOTE]
   > If the Docker container fails to start, there's likely a Visual Studio installation issue. You can update the Dockerfile to remove the step that calls the Visual Studio batch command. This enables you to start the Docker container and read the installation error logs.
   >
   > In your Dockerfile file, remove the `C:\\BuildTools\\Common7\\Tools\\VsDevCmd.bat` and `&&` parameters from the `ENTRYPOINT` command. The command should now be `ENTRYPOINT ["powershell.exe", "-NoLogo", "-ExecutionPolicy", "Bypass"]`. Next, rebuild the Dockerfile and execute the `run` command to access container files. To locate the installation error logs, go to the `$env:TEMP` directory and locate the `dd_setup_<timestamp>_errors.log` file.
   >
   > After you identify and fix the installation issue, you can add the `C:\\BuildTools\\Common7\\Tools\\VsDevCmd.bat` and `&&` parameters back to the `ENTRYPOINT` command and rebuild your Dockerfile.
   >
   > For more information, see [Known issues for containers](build-tools-container-issues.md).

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Advanced Example for Containers](advanced-build-tools-container.md)
* [Known Issues for Containers](build-tools-container-issues.md)
* [Visual Studio Build Tools workload and component IDs](workload-component-id-vs-build-tools.md)
