---
title: Update a network-based installation
description: Update a Visual Studio client installed from a network layout and make sure the client is receiving the latest security and functionality fixes. 
ms.date: 9/26/2024
ms.topic: conceptual
helpviewer_keywords:
- '{{PLACEHOLDER}}'
- '{{PLACEHOLDER}}'
author: anandmeg
ms.author: meghaanand
manager: mijacobs

ms.subservice: installation
---
# Update a Visual Studio client that was installed from a layout

> 📣 **We'd love to hear your feedback!**
> *Please take a moment to complete this [survey](https://aka.ms/learnlayoutfeedback) and let us know how we can improve the layout experience. Thank you for your support!*

You can and should periodically update all Visual Studio installations so that they receive the latest security and functionality fixes. 

If Visual Studio is installed on a machine in an organization and was originally installed from a layout, then most likely the client machine is part of a "managed environment", meaning that it is governed by a central administrative team and must adhere to organizational policies. To update client machines in managed environments, consider the questions below because the answers will inform how you should approach the update process. 

-  Where are the updates coming from: a layout or Microsoft hosted servers? If the update is coming from a layout, has the layout been updated? Is the layout hosted on a network share or on an internal intranet webserver?
-  Is the update going to be initiated [manually by the user](#manually-initiate-the-update-on-the-client-machine), or is it an administrator initiated event, like via an [administrator update](#use-administrator-updates-to-update-the-client-machines) or via a [programmatic command](#programmatically-update-the-client-machines)? Remember that whoever performs the update must have administrator permissions on the client machine.

## Prepare the update source

If your clients are [configured to acquire updates](update-visual-studio.md?view=vs-2022&preserve-view=true#configure-source-location-of-updates-1) from Microsoft hosted servers, then they must have access to the internet. During the update, the clients will download and install the latest version available from Microsoft on the [update channel](/visualstudio/releases/vs18/release-rhythm) that the client is subscribed to. 

If your clients are [configured to acquire updates](update-visual-studio.md#configure-source-location-of-updates-1) from a layout, then the first step before updating the client is to make sure that the layout itself contains the updated version of Visual Studio. The IT administrator should either [update the existing layout with the latest product updates](create-a-network-installation-of-visual-studio.md#maintaining-your-layout) so that both new client installations or client updates can receive the updated version, or they can [create a whole new layout](create-a-network-installation-of-visual-studio.md) in a different layout directory that you can use to update the client machines. Best practice is to update the layouts on the second Tuesday of the month right after the security updates are released.

Make sure that either the user or system account that's running the update has proper access to the network share or internal website that contains the layout. For more information, refer to [Troubleshoot network-related errors when you install or use Visual Studio](/troubleshoot/developer/visualstudio/installation/troubleshoot-network-related-errors#error-the-product-fails-to-install-or-update-because-network-share-permissions-arent-configured-correctly).

## Manually initiate the update on the client machine

A user on the client machine with sufficient permissions can [manually initiate the Visual Studio update themselves](update-visual-studio.md). The Visual Studio client will look in its [source location for updates](update-visual-studio.md?view=vs-2022&preserve-view=true#configure-source-location-of-updates-1) to determine if any update packages are available. That's why it's important to keep the source layout updated. 

Users can [manually update](update-visual-studio.md) a Visual Studio instance by: 
  * launching the Visual Studio Installer. If an update is available, they can click **Update**.
  * launching the Visual Studio IDE and responding to the notification flag or message, or choosing **Help > Check for Updates** for updates.  

If any files are in use when the update starts, for example, if Visual Studio is open, then the update will be blocked until Visual Studio is closed. Occasionally, an update will require a reboot.
 
### Manually configure where the Visual Studio client looks for updates

When Visual Studio is initially installed on the client machine, it records the location where it should check for updates. If Visual Studio was installed from Microsoft hosted servers, then it will by default look for updates from Microsoft hosted servers. If Visual Studio was [installed or updated by invoking a bootstrapper on a network layout](deploy-a-layout-onto-a-client-machine.md#install-from-a-network-layout) or by [running the script to install from a webhosted layout](deploy-a-layout-onto-a-client-machine.md#install-from-an-internal-intranet-location), then it will look for updates in the [location specified by the layout](automated-installation-with-response-file.md#configure-the-response-file-used-when-installing-from-a-layout).  

::: moniker range="vs-2019"

With default Visual Studio 2019 functionality, once the client has installed the product, the client's update location configuration is locked and unchangeable. The only way to *reliably* change the source location for updates is to uninstall and reinstall the product using the correct configuration.
 
However, if the Visual Studio client uses the latest Visual Studio 2022 Installer, then the client's source location for updates can be changed. This is useful if you want to install from one layout but have updates come from another layout. There are several ways to get the Visual Studio 2022 Installer onto a client machine. The easiest way is to use any version of Visual Studio that was shipped after June 2023, because these versions automatically contain the latest installer. Another way is to install and use the Visual Studio 2022 product. Lastly, you can [distribute the Visual Studio 2022 Installer via your Visual Studio 2019 layouts](create-a-network-installation-of-visual-studio.md#configure-the-layout-to-always-include-and-provide-the-latest-installer).

::: moniker-end

To manually view and configure the update location that the client will look for updates from, bring up the [Update Settings](update-visual-studio.md#configure-source-location-of-updates-1) and make sure it's configured correctly. You can then initiate the update from the client.  

### Update notifications

If there's an update available in the location that the client is looking for updates, then the client will [pop a message or a notification flag](update-visual-studio.md?#use-the-message-box-in-the-ide-1).  

For details on how to control when update notifications are presented to users, see [Control updates to network-based Visual Studio deployments](configure-policies-for-enterprise-deployments.md#controlling-notifications-in-the-visual-studio-ide).

## Use administrator updates to update the client machines

If you're in an organization, the recommended best practice is to enroll your client machines into [Visual Studio administrator updates](enabling-administrator-updates.md). Visual Studio security releases typically become available on "patch Tuesdays", which is the second Tuesday of the month. The IT Administrator should develop a habit of maintaining and updating their layouts on a monthly basis, like on the morning of the second Wednesday of the month, and they [use Microsoft Endpoint Manager to deploy the Visual Studio security updates to the client machines across their organization](applying-administrator-updates.md). Administrator updates will trigger clients to go look at their [update source location](update-visual-studio.md#configure-source-location-of-updates-1) for any new updates, and if the layout has been updated, then the update will be automatically applied to the client machine (presuming that Visual Studio isn't in use). 

## Programmatically update the client machines
Administrators can programmatically update the client installations of Visual Studio by either issuing the commands to the client-side installer or by invoking a bootstrapper in the network layout.

### Programmatically update Visual Studio by using the Visual Studio Installer

You can initiate an update to Visual Studio by programmatically invoking the client's installer and issuing the update command. This command will update Visual Studio based on the product bits that are available in the [source location for updates](update-visual-studio.md#configure-source-location-of-updates-1). If you want to change the update source location on the client while performing the update, you can do that programmatically by passing in the `--channelUri` parameter alongside the update command. For example:  

You can change the channel to a network layout *and* execute an update command on the client like this:

```shell
"C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe" update --installPath "C:\Program Files\Microsoft Visual Studio\2019\Enterprise" --channelUri "\\\\server\\share\\newlayoutdir\\channelmanifest.json"
```

or like this, which sets the source of updates to a Microsoft hosted location:

```shell
"C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe" update --installPath "C:\Program Files\Microsoft Visual Studio\2022\Enterprise" --channelUri "https://aka.ms/vs/17/release/channel"
```

Note that in the previous two examples, you can't initiate execution of the installer programmatically from the same directory that the installer resides in.

### Programmatically update Visual Studio by using a bootstrapper

You can update Visual Studio by programmatically calling a bootstrapper from the same location that you originally installed from. If you downloaded a bootstrapper from Microsoft, then if your client has access to the internet, you can download and use any updated bootstrapper to update your Visual Studio client. Pay attention to the bootstrapper's channel, because it may cause the client's update channel to change. 

If your bootstrapper is located on a network layout share, then the administrator should first [update the network layout](create-a-network-installation-of-visual-studio.md#maintaining-your-layout) to contain the Visual Studio product updates before the client can use that bootstrapper to update.

The following example updates the client using the existing bootstrapper in the original network layout. This method assumes that the IT administrator has already updated the layout.

```shell
\\server\share\originalinstallVSdirectory\vs_enterprise.exe update --installPath "C:\clientmachine\installpath" --quiet 
```

::: moniker range="vs-2019"

You can also initiate an update to your Visual Studio 2019 client by programmatically calling a bootstrapper from a *different* network layout location that contains the version of the product that you want to update the client to. To do this, you need to get the Visual Studio 2022 Installer on the client. The easiest way to enable this is to [ensure your new Visual Studio 2019 layout is using the latest installer](create-a-network-installation-of-visual-studio.md#ensure-your-layout-is-using-the-latest-installer). If you run the bootstrapper from a new network hosted layout, then the update channel on the client will be set to the [update location specified in the layout](automated-installation-with-response-file.md). For example, you can run this command on the client machine using a new bootstrapper in a new network hosted layout:

::: moniker-end

::: moniker range=">=vs-2022"

You can also initiate an update to your Visual Studio client by programmatically calling a bootstrapper from a *different* network layout location that contains the version of the product that you want to update the client to. If you run bootstrapper from a new network hosted layout, then the update channel on the client will be set to the [update location specified in the layout](automated-installation-with-response-file.md). For example, you can run this command on the client machine using a new bootstrapper in a new network hosted layout:

::: moniker-end

```shell
   \\server\share\desiredupdatelayoutdir\vs_enterprise.exe update --installPath "C:\clientmachine\installpath" --quiet 
```
Whatever the value of the channelUri in the new layout's `response.json` file will be the location where the client looks for future updates.

> [!NOTE]
> Use the [vswhere.exe command](tools-for-managing-visual-studio-instances.md) to identify the install path of an existing instance of Visual Studio on a client machine.

### Programmatically update a client that doesn't have internet access

If your client machine doesn't have internet access, then it *must* acquire the updates from a layout. Remember that there are two parts that need to get updated whenever Visual Studio is updated. The first is the installer and the second is the Visual Studio product itself. For network hosted layouts, you can invoke either the bootstrapper or the installer to update the client. For intranet webserver hosted layouts, you can update by invoking the installer on the client. The following example illustrates both situations, and both assume that the administrator has already updated the layout itself to the most secure bits.

This example instructs Visual Studio to *explicitly* look for *both* of these components from a network layout. The first command forces the installer to update from the layout, and the second command prevents any packages from being downloaded from Microsoft hosted servers on the internet.

 ```shell
    \\server\share\VSlayoutdirectory\vs_enterprise.exe --quiet --update --wait --offline
    \\server\share\VSlayoutdirectory\vs_enterprise.exe update --installPath "C:\clientmachine\installpath" --noWeb --wait --quiet --norestart
 ```

This example instructs Visual Studio to update itself from the content included in the internal intranet webserver hosted layout. 

 ```shell
    "C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe" update --installPath "C:\Program Files\Microsoft Visual Studio\2019\Enterprise"
 ```
 
## Get support for your network layout

If you experience a problem with your network layout, we want to know about it. The best way to tell us is by using the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE. If you're an IT Administrator and don't have Visual Studio installed, you can submit [**IT Admin feedback here**](https://aka.ms/vs/admin/feedback). When you use this tool, it would be very helpful if you could send the [logs from the VS Collect tool](https://aka.ms/vscollect) which can help us diagnose and fix the problem.

We also offer an [**installation chat**](https://visualstudio.microsoft.com/vs/support/#talktous) (English only) support option for installation-related issues.

We have other support options available, too. See our [Visual Studio Developer Community](https://developercommunity.visualstudio.com/home).

## Related content

* [Create and maintain a network layout](create-a-network-installation-of-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Troubleshoot network-related errors when you install or use Visual Studio](/troubleshoot/developer/visualstudio/installation/troubleshoot-network-related-errors)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Tools for detecting and managing Visual Studio instances](tools-for-managing-visual-studio-instances.md)
* [Configure policies for enterprise deployments of Visual Studio](configure-policies-for-enterprise-deployments.md)
* [Visual Studio product lifecycle and servicing](/visualstudio/productinfo/vs-servicing)
