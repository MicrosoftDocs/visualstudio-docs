---
title: Update a network-based installation
description: Learn how to update a Visual Studio client that was installed from a network layout
ms.date: 1/20/2023
ms.topic: conceptual
helpviewer_keywords:
- '{{PLACEHOLDER}}'
- '{{PLACEHOLDER}}'
ms.assetid: 1AF69C0E-0AC9-451B-845D-AE4EDBCEA65C
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Update a Visual Studio client that was installed from a network layout

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

You can and should periodically update all Visual Studio clients so that they receive the latest security and functionality fixes. 

If the Visual Studio client was originally installed via a network layout, then most likely the client machine is part of a "managed environment" meaning that it is governed by a central administrative team and must adhere to organizational policies. To update client machines in a managed environment consider the questions below whose answers will inform how you should approach the update process. 

-  Where are the updates coming from: a network layout or Microsoft hosted servers? And if the update is coming from a network layout, is the network layout prepared?
-  Is the update going to be initiated by the user, or is it an administrator initiated event? Remember that whoever performs the update must have administrator permissions on the client machine.

## Prepare the update source

If you are going to update your client from Microsoft hosted servers, then the client will download and install the latest version available from Microsoft on that [channel](/visualstudio/releases/2022/vs2022-release-rhythm). 

If you are going to update your client from a network layout, then the first step is to prepare the network layout with the updated product. You can [update your existing layout with the latest product updates](create-a-network-installation-of-visual-studio.md#update-or-modify-your-layout) so both new installations and updates will receive the updated version. Or, you can [create a whole new layout](create-a-network-installation-of-visual-studio.md) in a different directory that you can use for updating the client machines.

Make sure that either the user or system account that's running the update has proper access to the network share that contains the layout. For more information, refer to [Troubleshoot network-related errors when you install or use Visual Studio](troubleshooting-network-related-errors-in-visual-studio.md#error-the-product-fails-to-install-or-update-because-network-share-permissions-arent-configured-correctly).

## Enable manual user-initiated client-side updates 
A user on the client machine with sufficient permissions can [manually initiate the Visual Studio update themselves](update-visual-studio.md). The Visual Studio client must be configured properly to look in the right source location for updates so that it can recognize that an update is available. If any files are in use when the update happens, like if Visual Studio is open, then Visual Studio will need to close to complete the update. Occasionally an update will require a reboot.

### Manually configure where the Visual Studio client looks for updates

When Visual Studio is initially installed on the client machine, it records the location where it should check for updates. If Visual Studio was installed from Microsoft hosted servers, then it will by default look for updates from Microsoft hosted servers. If Visual Studio was installed or updated by invoking a bootstrapper on a network layout, then it will look for updates in the [location specified by the layout](automated-installation-with-response-file.md).  

::: moniker range="vs-2019"

With default Visual Studio 2019 functionality, once the client has installed the product, the client's update location configuration is locked and unchangable. The only way to _reliably_ change the source location for updates is to uninstall and reinstall the product using the correct configuration.
 
However, if the Visual Studio client uses the latest Visual Studio 2022 Installer, then the client's source location for updates can be changed. This is useful if you want to install from one layout but have updates come from another layout. There are two ways to get the Visual Studio 2022 Installer onto a client machine. The easiest is to simply install and use the Visual Studio 2022 product. Alternatively, you can [distribute the Visual Studio 2022 installer via your Visual Studio 2019 layouts](create-a-network-installation-of-visual-studio.md#configure-the-layout-to-always-include-and-provide-the-latest-installer).

::: moniker-end

To manually view and configure the update location that the client will look for updates from, bring up the [Update Settings](update-visual-studio.md?view=vs-2022&preserve-view=true#configure-source-location-of-updates-1), make sure it's configured correctly. You can then initiate the update from the client.  

### Update notifications

If there is an update available in the location that the client is looking for updates, then the client will [pop a message or a notification flag](update-visual-studio.md?#use-the-message-box-in-the-ide-1).  

For details on how to control when update notifications are presented to users, see [Control updates to network-based Visual Studio deployments](set-defaults-for-enterprise-deployments.md#controlling-notifications-in-the-visual-studio-ide).

### Manually initiate the update

Users can [manually update](update-visual-studio.md) a Visual Studio instance by: 
  * launching the Visual Studio Installer. If an update is available, they can click **Update**.
  * launching the Visual Studio IDE and responding to the notification flag or message, or choosing Help/Check for updates.  

## Programatically update the client machines
Administrators can programmatically update the client installations of Visual Studio by either issuing the commands to the client-side installer, or by invoking a bootstrapper in the layout.

### Programatically update Visual Studio by using the Visual Studio Installer

You can initiate an update to Visual Studio by programmatically invoking the client's installer and issuing the update command. This command will update Visual Studio based on the updated product available in the [source location for updates](update-visual-studio.md#configure-source-location-of-updates-1). If you want to change the update source location on the client, you can do that programatically by passing in the --channelURI parameter. For example:  

You can change the channel to a network layout _and_ execute an update command on the client like this:

```shell
c:\program files (x86)\microsoft\visual studio\installer\>setup.exe update --installPath "C:\Program Files\Microsoft Visual Studio\2019\Enterprise" --channelURI "\\\\server\\share\\newlayoutdir\\channelmanifest.json"
```
or like this, which sets the source of updates to a Microsoft hosted location:

```shell
c:\program files (x86)\microsoft\visual studio\installer\>setup.exe update --installPath "C:\Program Files\Microsoft Visual Studio\2019\Enterprise" --channelURI "https://aka.ms/vs/16/release/channel"
```

### Programatically update Visual Studio by using a bootstrapper.

You can update Visual Studio by programatically calling a bootstrapper from the same location that you originally installed from. All bootstrappers sourced from Microsoft hosted servers are considered from the same location. If your bootstrapper was on a network layout share, then the [network layout must be updated](create-a-network-installation-of-visual-studio.md#update-or-modify-your-layout) to contain the desired product updates.

```shell
\\server\share\originalinstallVSdirectory\vs_enterprise.exe update --installPath "C:\clientmachine\installpath" --quiet 
```

::: moniker range="vs-2019"

You can also initiate an update your Visual Studio 2019 client by programatically calling a bootstrapper from a _different_ source location that contains the version of the product that you want to update the client to. To do this, you need to get the Visual Studio 2022 installer on the client. The easiest way to enable this is to [ensure your new Visual Studio 2019 layout is using the latest installer](create-a-network-installation-of-visual-studio.md#ensure-your-layout-is-using-the-latest-installer). If you run bootstrapper from a new layout, then the update channel on the client will be set to the [update location specified in the layout](automated-installation-with-response-file.md). For example, you can run this command on the client machine:

::: moniker-end

::: moniker range=">=vs-2022"

You can also initiate an update to your Visual Studio client by programatically calling a bootstrapper from a _different_ source location that contains the version of the product that you want to update the client to. If you run bootstrapper from a new layout, then the update channel on the client will be set to the [update location specified in the layout](automated-installation-with-response-file.md). For example, you can run this command on the client machine:

::: moniker-end

```shell
   \\server\share\desiredupdatelayoutdir\vs_enterprise.exe update --installPath "C:\clientmachine\installpath" --quiet 
```
Whatever the value of the channelURI in the new layout's response.json file will be the location where the client looks for future updates.

> [!NOTE]
> Use the [vswhere.exe command](tools-for-managing-visual-studio-instances.md) to identify the install path of an existing instance of Visual Studio on a client machine.

### Programatically update a client that doesn't have internet access

If your client machine doesn't have internet access, then it _must_ acquire the updates from a network layout. Remember that there are two parts that need to get updated whenever Visual Studio is updated. The first is the installer and the second is the Visual Studio product itself. You can instruct Visual Studio to _explicitly_ look for _both_ of these components from the network layout by running these commands on the client machine. The first command forces the installer to come from the layout, and the second command prevents any packages from being downloaded from Microsoft hosted servers on the internet.

 ```shell
    \\server\share\VSlayoutdirectory\vs_enterprise.exe --quiet --update --wait --offline
    \\server\share\VSlayoutdirectory\vs_enterprise.exe update --installPath "C:\clientmachine\installpath" --noWeb --wait --quiet --norestart
 ```
    
> [!IMPORTANT]
> The `--noWeb` option does not stop Visual Studio setup on an internet-connected computer from _checking_ for updates. Rather, it prevents the client from downloading the product packages. 

## Get support for your network layout

If you experience a problem with your network layout, we want to know about it. The best way to tell us is by using the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE. If you're an IT Administrator and don't have Visual Studio installed, you can submit [**IT Admin feedback here**](https://aka.ms/vs/admin/feedback). When you use this tool, it would be very helpful if you could send the [logs from the VS Collect tool](https://aka.ms/vscollect) which can help us diagnose and fix the problem.

We also offer an [**installation chat**](https://visualstudio.microsoft.com/vs/support/#talktous) (English only) support option for installation-related issues.

We have other support options available, too. See our [Visual Studio Developer Community](https://developercommunity.visualstudio.com/home).

## See also

* [Create and maintain a network layout](create-a-network-installation-of-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Troubleshoot network-related errors when you install or use Visual Studio](troubleshooting-network-related-errors-in-visual-studio.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Tools for detecting and managing Visual Studio instances](tools-for-managing-visual-studio-instances.md)
* [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md)
* [Visual Studio product lifecycle and servicing](/visualstudio/releases/2019/servicing/)
