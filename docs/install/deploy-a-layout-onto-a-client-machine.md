---
title: Deploy a network-based installation
description: Learn how to deploy a network layout of Visual Studio within an enterprise.
ms.date: 6/2/2023
ms.topic: conceptual
helpviewer_keywords:
- '{{PLACEHOLDER}}'
- '{{PLACEHOLDER}}'
ms.assetid: 
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Deploy Visual Studio from a layout onto a client machine

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
 

In order to deploy a layout to a client machine, you'll need to consider the following topics 

- [**Prepare the layout**](create-a-network-installation-of-visual-studio.md): Make sure that your layout is ready to install onto the client
- [**Prepare the client machines**](#prepare-the-client-machines): Ensure that your client machines are ready to install Visual Studio and your users have the right permissions.
- [**Configure global policies on the client machine**](configure-policies-for-enterprise-deployments.md): Control other Visual Studio installation, update, notification, and download behavior.  
- [**Configure initial client installation defaults**](automated-installation-with-response-file.md): Initialize your client's installation with customized settings
- [**Perform regular updates**](update-a-network-installation-of-visual-studio.md): Keep your client machines updated and secure.

## Install Visual Studio onto a client machine from a layout

Administrators can deploy a Visual Studio layout onto client workstations as part of an installation script.  

### Install from a network layout

A user with administrator permissions can install Visual Studio from a network layout in an unattended mode by running the following command. The response.json in the layout will provide the default configuration settings for the installation. 

```shell
\\server\products\VS\vs_enterprise.exe --quiet --wait 
```

> [!NOTE] 
> Be patient. Make sure you `--wait` for both the installer and the product to finish. When installing or updating a client from a layout, the installer is always the first thing to get installed or updated, and then the Visual Studio product itself will get installed or updated. **Both** of these processes need to finish in order to be considered a successful update.   
>
> When executing the install or update as part of an unattended automated batch file, the `--wait` option is helpful to ensure that the `vs_enterprise.exe` process waits until the installation is complete before it returns an exit code. This is useful if an enterprise administrator wants to perform further actions on a completed installation, such as [apply a product key to a successful installation](automatically-apply-product-keys-when-deploying-visual-studio.md). Using the --wait option prevents subsequent operations from kicking off prematurely. If you do not use `--wait`, the `vs_enterprise.exe` process can exit before both parts of the installation are complete, and thus will return an inaccurate exit code that doesn't represent the state of the install operation.

### Install from an internal intranet location

Some enterprises want to host the layout on an intranet location to better manage geographical performance bottlenecks and take advantage of web caching. In order to do this, a user with administrator permissions must run a elevated PowerShell script similar to below to initialize the installation on the client machine. 

```shell
    #Do the initial installation from the web hosted layout onto the client in an elevated PowerShell script

    #ADMIN CONFIGURATION
    #Enter layout URI here
    $LayoutUri = “http://MyCompanyIntranetSite/VS2022Enterprise/”

    #Enter bootstrapper name which is present in layout.
    $BootstrapperName = “vs_Enterprise.exe”

    #Add any arguments which you intend to send to bootstrapper.
    $Arguments = “–passive --wait”

    #SCRIPT FUNCTIONALITY
    #Forming URI for bootstrapper
    Write-Verbose “LayoutUri: $LayoutUri”
    $BootstrapperUri = “$LayoutUri/$BootstrapperName”
    Write-Verbose “BootstrapperUri: $BootstrapperUri”

    $Arguments += " --layoutUri $LayoutUri"
    Write-Verbose “Arguments: $Arguments”

    #Creating temp folder and download bootstrapper
    $VSLayoutFolderPath = Join-Path -Path $env:TEMP -ChildPath VSLayout
    $BootstrapperFile = Join-Path -Path $VSLayoutFolderPath -ChildPath $BootstrapperName
    Write-Verbose “The bootstrapper path is: $BootstrapperFile”

    if (Test-Path $VSLayoutFolderPath)
    {
    Write-Verbose “The directory exists - $VSLayoutFolderPath”
    if (Test-Path $BootstrapperFile)
    {
    Write-Verbose “Deleting file - $BootstrapperFile”
    Remove-Item $BootstrapperFile
    }
    }
    else
    {
    Write-Verbose “Creating folder - $VSLayoutFolderPath”
    New-Item -ItemType Directory -Path $VSLayoutFolderPath
    }

    Write-Verbose “Downloading bootstrapper from - $BootstrapperUri to $BootstrapperFile”
    Invoke-WebRequest -Uri $BootstrapperUri -OutFile $BootstrapperFile
    
    Write-Verbose “Starting bootstrapper -$BootstrapperFile with arguments $Arguments”
    start-process $BootstrapperFile $Arguments
```

## Prepare the client machines

### Permissions
Make sure that either the user or system account that's running the installation has proper access to the network share that contains the layout. For more information, refer to [Troubleshoot network-related errors when you install or use Visual Studio](troubleshooting-network-related-errors-in-visual-studio.md).

### Install on a client that doesn't have internet access

You'll need to make sure that any [offline client machines have the right certificates installed](install-certificates-for-visual-studio-offline.md).

When you install from a layout, the installer on the client will always look for the Visual Studio packages in the layout's location. However, if the installer tries to install components that are _not_ included in the layout, then it will attempt to acquire the Visual Studio packages from the [update source](update-visual-studio.md#configure-source-location-of-updates-1). For non-internet-connected clients, administrators typically ensure that the layout's update source default setting points back to itself ([by configuring the channelUri in the response.json](automated-installation-with-response-file.md#configure-the-response-file-used-when-installing-from-a-layout) and that the [client's update settings](update-visual-studio.md#configure-source-location-of-updates-1) are configured to look in the layout.  

If you want to _prevent_ the Visual Studio installer from attempting to download any content from the web that may be missing from your network layout, you can try to use the [`--noWeb` parameter](use-command-line-parameters-to-install-visual-studio.md#layout-command-and-command--line-parameters). If `--noWeb` is used and the layout is missing a component that is selected to be installed, then the setup will simply fail. 

If you get an error message that says "A product matching the following parameters cannot be found", make sure that you are using the `--noweb` switch.

## Error codes

If you used the `--wait` parameter, then depending on the result of the operation, the `%ERRORLEVEL%` environment variable is set to one of the following values:

[!INCLUDE[install-error-codes-md](includes/install-error-codes-md.md)]

### Get support for deploying your layout

If you experience a problem deploying your layout onto a client machine, we want to know about it. The best way to tell us is by using the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE. If you're an IT Administrator and don't have Visual Studio installed, you can submit [**IT Admin feedback here**](https://aka.ms/vs/admin/feedback). When you use this tool, it would be very helpful if you could send the logs by the [VS Collect tool](https://aka.ms/vscollect) which can help us diagnose and fix the problem.

We also offer an [**installation chat**](https://visualstudio.microsoft.com/vs/support/#talktous) (English only) support option for installation-related issues.

We have other support options available, too. See our [Visual Studio Developer Community](https://developercommunity.visualstudio.com/home).

## See also

- [Visual Studio administrator guide](visual-studio-administrator-guide.md)
- [Update a network-based installation of Visual Studio](update-a-network-installation-of-visual-studio.md)
- [Troubleshoot network-related errors when you install or use Visual Studio](troubleshooting-network-related-errors-in-visual-studio.md)
- [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md)
- [Configure policies for enterprise deployments of Visual Studio](configure-policies-for-enterprise-deployments.md) 
- [Visual Studio product lifecycle and servicing](/visualstudio/productinfo/vs-servicing/)
- [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
- [Visual Studio workload and component IDs](workload-and-component-ids.md)
- [Install certificates required for Visual Studio offline installation](install-certificates-for-visual-studio-offline.md)
