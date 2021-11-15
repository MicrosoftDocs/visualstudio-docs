---
title: Applying administrator updates to Visual Studio with Microsoft Endpoint Configuration Manager
titleSuffix: ''
description: Learn how to apply administrator updates to Visual Studio.
ms.date: 04/16/2021
ms.topic: overview
ms.assetid: 9a3fdb28-db3d-4970-bc17-7417a985f0fb
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Applying administrator updates that use Microsoft Endpoint Configuration Manager

This document describes different types and characteristics of Visual Studio administrator updates. Below, you will find information about how and when they should be distributed throughout your organization, what configuration options are available, and how to view reports and troubleshoot. For more information about the pre-requisites for using administrator updates, see [Enabling administrator updates](../install/enabling-administrator-updates.md). Administrator updates presumes that Visual Studio is already installed on the computer. Applying administrator updates will not initiate a brand new installation.

## Understanding Visual Studio administrator updates

The Visual Studio administrator update package that is published to Microsoft Update for consumption by the Microsoft Catalog and WSUS contains information that the Configuration Manager needs to be able to download and distribute the Visual Studio update to client machines. It also contains information that an IT administrator needs in order to decide which updates to distribute throughout the organization. It can also be used to facilitate maintenance of network layouts. The Visual Studio administrator update packages don’t contain enough information to do a fresh installation of the product, nor do they contain any of the actual product binaries that are published to the Content Delivery Network. Visual Studio administrator updates are cumulative, just like regular Visual Studio updates. You can assume that any Visual Studio update that has a higher product version number and a later release date is a superset of an older, lower version.

Visual Studio administrator updates apply to Visual Studio servicing versions that are under support. For more information about which Visual Studio servicing baselines are still in support during a particular timeframe, see [Visual Studio Product Lifecycle and Servicing](/visualstudio/productinfo/vs-servicing-vs). All supported Visual Studio servicing baselines will be kept secure.  

## Types and characteristics of administrator updates

There are three types of administrator updates to Visual Studio:

* **Security updates** are applicable to all Visual Studio editions (e.g. Enterprise, Professional, Community, etc.), and they contain limited, highly targeted and compatible servicing level changes. Security updates will not advance a client to a later minor version; they are designed to deliver fixes to security vulnerabilities to a client that is already at a particular minor version level. Security updates will have at least one security fix in them, but the security fix may or may not be in a component or workload that’s installed on the client machine. For example, we could fix a security vulnerability in the .NET components, and we would label the update as a security update, but it wouldn’t really have any meaningful effect on a client machine that had only C++ components installed. Security updates may also contain other reliability fixes or other necessary component updates. Security updates are published to both the [Microsoft Update Catalog](https://www.catalog.update.microsoft.com/Home.aspx) (MUC) and [Windows Server Update Services](/windows-server/administration/windows-server-update-services/get-started/windows-server-update-services-wsus), where they are classified as "Security Updates".
* **Feature updates** enable IT admins to advance computers in their organization to a more recent minor version of Visual Studio. Feature updates only apply to Visual Studio editions that are commonly found in enterprises, such as Enterprise, Professional, and Build Tools SKUs. All feature updates will be published to the Microsoft Update Catalog as “Feature Packs,” and they are available to optionally manually [import into Configuration Manager from the Microsoft Update Catalog](/mem/configmgr/sum/get-started/synchronize-software-updates#import-updates-from-the-microsoft-update-catalog). Feature updates are cumulative and will contain additional quality and prior security fixes. See the [configuration options section](#understanding-configuration-options) below for instructions about how to configure a client machine to remain on a servicing baseline and prevent feature updates from being delivered to specific clients.
* **Quality updates** are also only applicable to those Visual Studio editions that are commonly found in enterprises, and they contain limited, highly targeted and compatible servicing level changes. Quality updates will not advance a client to a later minor version; they are designed to deliver performance and reliability fixes or other necessary component updates to a client that is already at a particular minor version level. Quality updates accumulate along with security updates, and thus will contain security fixes only if the security fix has already been independently released. Quality updates are published to the Microsoft Update Catalog as “Updates”, and they are also available to optionally manually [import into Configuration Manager](/mem/configmgr/sum/get-started/synchronize-software-updates#import-updates-from-the-microsoft-update-catalog).

### Decoding the titles of administrator updates

The title of each administrator update describes both the applicable version range and the resultant version of the update. For example,

::: moniker range="vs-2017"

* **Visual Studio 2017 version 15.9.0 to 15.9.35 update** classified as a “Security Update” will apply to any Visual Studio 2017 edition on the client between versions 15.9.0 through 15.9.35, and it will update those client editions to 15.9.35.
* **Visual Studio 2017 version 15.0.0 to 15.9.0 update** classified as a “Feature Pack” will apply to Visual Studio 2017 editions licensed for enterprise use on the client between the entire product version range of 15.0.0 through 15.9.0, and it will update those client editions to 15.9.0. Applying this feature pack basically enables the clients to then receive security updates. 
* **Visual Studio 2017 version 15.9.0 to 15.9.37 update** classified as simply “Updates” will apply to Visual Studio 2017 editions licensed for enterprise use on the client between versions 15.9.0 through 15.9.37, and it will update those client editions to 15.9.37.

::: moniker-end

::: moniker range="vs-2019"

* **Visual Studio 2019 version 16.7.0 to 16.7.12 update** classified as a “Security Update” will apply to any Visual Studio 2019 edition on the client between versions 16.7.0 through 16.7.12, and it will update those client editions to 16.7.12.  
* **Visual Studio 2019 version 16.0.0 to 16.9.0 update** classified as a “Feature Pack” will apply to Visual Studio 2019 editions licensed for enterprise use on the client between the entire product version range of 16.0.0 through 16.9.0, and it will update those client editions (that haven’t been configured to remain on an earlier servicing baseline) to 16.9.0. 
* **Visual Studio 2019 version 16.8.0 to 16.8.7 update** classified as simply “Updates” will apply to Visual Studio 2019 editions licensed for enterprise use on the client between versions 16.8.0 through 16.8.7, and it will update those client editions to 16.8.7.

::: moniker-end

::: moniker range=">=vs-2022"

::: moniker-end

## Using Configuration Manager to deploy Visual Studio updates

### Understanding configuration options

There are a few configuration options that are can be used to tailor the Visual Studio administrator updates so that they’re compatible and aligned with your organization’s deployment preferences and requirements. The most common configuration options are listed below. For an exhaustive list of all the supported administrator update behaviors, see [Use command-line parameters to install Visual Studio](../install/use-command-line-parameters-to-install-visual-studio.md) and pay attention only to those that correspond to the "update" action.

* **[Administrator update opt-in](../install/enabling-administrator-updates.md#encoding-administrator-intent-on-the-client-machines)**: This registry key is required for the client machine to receive administrator updates. It is a machine-wide key, which means it applies to all instances of Visual Studio installed on the box.
* **Visual Studio user opt-out**: Visual Studio users can use a separate machine-wide **AdministratorUpdatesOptOut** registry key to *opt out* of receiving Visual Studio administrator updates. The purpose of this key is to allow the Visual Studio user to have some control over having updates automatically applied to the machine. To configure the client computer to block administrator updates, set the **AdministratorUpdatesOptOut** REG_DWORD key to **1**. The absence of the key, or a set value of **0**, means that the Visual Studio user wants to receive administrator updates to Visual Studio.
    Note that the **AdministratorUpdatesOptOut** key for encoding user preference is prioritized over the **AdministratorUpdatesEnabled** key, which encodes the IT admin intent. If **AdministratorUpdatesOptOut** is set to **1**, the update will be blocked on the client, even if the **AdministratorUpdatesEnabled** key is also set to **1**. This action assumes that IT admins can access and monitor which developers chose to opt out, and that the two parties can then discuss whose needs are more important. IT admins can always change either key whenever they want.
* **Location of the updated product bits**: Most of the time, client machines download the updated product bits from the internet via the Microsoft CDN. This scenario requires the client machines to have internet access. Some enterprises, however, restrict client machines to only install and update bits from an internal network layout location. To ensure that administrator updates can be applied using updated bits that are on an internal network location, the following conditions must be true before the administrator update can be successfully deployed: 
  * The client machine must have, at some point, already run the bootstrapper from that network layout location. Ideally, the original client install would have happened using the bootstrapper from the network layout, but it's also possible to have just installed an update using an updated bootstrapper in that same network location. Either one of these actions would embed, on the client machine, a connection with that particular layout location.
  * The network layout location (where the client is connected to) must be [updated to contain the updated product bits](../install/update-a-network-installation-of-visual-studio.md) that the administrator update wants to deploy.

::: moniker range=">=vs-2019"

* **Servicing baseline stickiness**: As described above, administrator feature updates advance a Visual Studio installation to a more current minor version of the product. Sometimes, however, Visual Studio users need to remain at a particular stable and secure servicing baseline level, and they want to control when their machines advances to a more current minor version. To configure a client machine to remain on a servicing baseline and ignore undesired administrator feature updates sent to it, you’ll need to create and set the **BaselineStickinessVersions2019** Reg_SZ data value to a string that represents the preferred baseline that the client machine should snap to and stay on. The string can contain an allowable servicing baseline version such as **16.7.0**.  
     If the `BaselineStickinessVersions2019` registry value is malformed, then all administrator feature updates will be blocked from installing on the machine. Make sure you pay attention to the [supported timeframes for Visual Studio feature updates](/visualstudio/productinfo/vs-servicing-vs). Also, regardless of the presence or value of the `BaselineStickinessVersions2019` key, while it is technically possible to apply administrator feature updates that have reached the end of their lifetimes, we don't recommend it because they will be out of support and thus potentially insecure.

::: moniker-end

* **Force the update to occur even if Visual Studio is in use**: Visual Studio must be closed before you install the update. If Visual Studio is open or being used, the update installation will be aborted. An easy way to ensure that Visual Studio is closed is to configure Confirmation Manager to apply the update right after a machine reboot. You can also use the `--force` parameter to force shut down Visual Studio. Forcing Visual Studio to close might cause loss of work, so use it with caution. Running an administrator update in the default system context will ignore the `–-force` flag, so you will need to configure the administrator Update to be run in user context.

### Methods for configuring an administrator update

There are three main methods of configuring administrator updates: a registry key, a configuration file on the client machine, or a modification of the Configuration Manager deployment package itself.   

* **Registry key**: Administrator updates look for specific registry keys in any of the standard Visual Studio locations as described in [Set defaults for enterprise deployments](../install/set-defaults-for-enterprise-deployments.md). Options that are controlled by registry keys are items such as **AdministratorUpdatesOptOut** Reg_DWORD, **AdministratorUpdatesOptOut** Reg_DWORD, and **BaselineStickinessVersions2019** Reg_SZ. Admin access on the client computer is required to create and set the value of registry keys.

* **Configuration file**: Some settings can be preserved on the client machine in an optional configuration file, which has the benefit of setting it only once and having it apply to all future administrator updates. The configuration file approach behaves like a registry key and is machine wide, which means it will apply to all installs of Visual Studio installed on the client machine. The standard location for the configuration file is at `C:\ProgramData\Microsoft\VisualStudio\updates.config`. However, if you wish to use another location to store the file, you can do so by creating a Reg_SZ registry key called **UpdateConfigurationFile** and setting the value of this key to the path of your config file. This registry key can be place in any of the Visual Studio registry locations as described in [Set defaults for enterprise deployments](../install/set-defaults-for-enterprise-deployments.md). If you choose to add a registry value for a custom configuration file location, it will look for that file; if the file doesn’t exist, then an exception will be thrown and the update will fail.

     The configuration file, which is in JSON format, supports the option `installerUpdateArgs` which is an array of strings separated by commas that specify more switches you can pass into the Visual Studio installer. If the contents of the file include an invalid field or an option that is not supported, then the update will fail. For more information, see [Use command-line parameters to install Visual Studio](../install/use-command-line-parameters-to-install-visual-studio.md).

   Here's an example configuration file:

  ```json
  "installerUpdateArgs" : ["--quiet", "--noWeb"], 
  "checkPendingReboot" :  "true" 
  ```

* **Manually updating the Administrator Updates Package in SCCM**: The command-line parameters of an individual administrator update package in SCCM can also be manually modified.

## Verification, reports, and troubleshooting error codes

### Determining that Visual Studio was updated

You can use one of the following methods to verify that the administrator update was installed correctly:

* On the client computer, start Visual Studio, select **Help** > **About**, and verify that the version number matches the last number in the title of the intended update.
* Use the **vswhere** tool on the client machine to identify the various versions of Visual Studio on the computer. For more information, see [Tools for detecting and managing Visual Studio instances](../install/tools-for-managing-visual-studio-instances.md).
* Each administrative update attempt generates several log files in the client machine’s `%temp%` directory that captures the progress of the update operation. Sort the folder by date and look for files that begin `dd_updatedriver`, `dd_bootstrapper`, `dd_client`, and `dd_setup` for the administrative updates, the bootstrapper, the Visual Studio Installer, and the setup engine, respectively. Verify that these log files contain a 0, indicating that the update was successfully applied. Note that these log files can also be used to verify that the configuration file is being used. Refer to the [Visual Studio Log Collection Tool](https://www.microsoft.com/download/details.aspx?id=12493) for further details.

### Error codes and conditions

>[!IMPORTANT]
> Remember that Visual Studio must be closed before you install the update. If Visual Studio is open or being used, the update installation will be canceled.

Administrative updates may return the following return codes:  

| Error code | Definition                                                                                                                                                                                                  |
|------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| 0          | The administrative update was successfully installed.                                                                                                                                                       |
| 1001       | Visual Studio Installer or a related setup process is running. The update is not applied.                                                                                                                   |
| 1002       | Visual Studio Installer is paused. The update is not applied.                                                                                                                                               |
| 1003       | Visual Studio is running. The update is not applied. This condition can be overruled using the `--force` flag.                                                                                              |
| 1004       | No internet detected. The update was unable to contact the internet location holding the updated files. The update is not applied.                                                                          |
| 1005       | The **AdministratorUpdatesEnabled** registry value is set to **0** or not set at all. The update is not applied.                                                                                            |
| 1006       | The **AdministratorUpdatesOptOut** registry value is set to **1**. The update is not applied. The key is intended for client computers that should not be updated by the administrator.                     |
| 1007       | The Visual Studio Installer is not installed.                                                                                                                                                               |
| 1008       | The **BaselineStickinessVersions2019** registry value is not in a readable format. The registry value must include **All** or valid versions with the build number set to 0 explicitly, for example, X.Y.0. |
| 3010       | The system requires a reboot. The update may or may not have been applied. Reboot the computer and attempt the update again.                                                                                |
| Other      | Error occurred attempting to apply the update. The update is not applied.                                                                                                                                   |

For an exhaustive list of client error codes, see [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md).

## Feedback and support

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

You can use the following methods to provide feedback about Visual Studio administrator updates or report issues that affect the updates:

* Refer to the [Troubleshooting Visual Studio installation and upgrade issues](../install/troubleshooting-installation-issues.md) guidance.
* Ask questions to the community at the [Visual Studio Setup Q&A Forum](/answers/topics/vs-setup.html).
* Go to the [Visual Studio support page](https://visualstudio.microsoft.com/vs/support/), and check whether your issue is listed in the FAQ.  You can also select the [Support Link](https://visualstudio.microsoft.com/vs/support/#talktous) button for chat help.
* [Provide feature feedback or report a problem](https://aka.ms/vs/wsus/feedback) to the Visual Studio team regarding this experience of applying administrator updates.
* Contact your organization’s technical account manager for Microsoft.

## See also

* [Enabling administrator updates](../install/enabling-administrator-updates.md)
* [Visual Studio administrator guide](../install/visual-studio-administrator-guide.md)
* [Visual Studio Product Lifecycle and Servicing](/visualstudio/productinfo/vs-servicing-vs)
* [Visual Studio 2019 Release Notes](/visualstudio/releases/2019/release-notes)
* [Visual Studio 2017 Release Notes](/visualstudio/releasenotes/vs2017-relnotes)
* [Install Visual Studio](../install/install-visual-studio.md)
* [Using Command Line Parameters to install Visual Studio](../install/use-command-line-parameters-to-install-visual-studio.md)
* [Tools for detecting and managing Visual Studio instances](../install/tools-for-managing-visual-studio-instances.md)
* [Create a network installation of Visual Studio](../install/create-a-network-installation-of-visual-studio.md)
* [How to define settings in a response file](../install/automated-installation-with-response-file.md)
* [Control updates to network-based Visual Studio deployments](../install/controlling-updates-to-visual-studio-deployments.md)
* [Microsoft Update Catalog FAQ](https://www.catalog.update.microsoft.com/faq.aspx)
* [Microsoft Endpoint Configuration Manager (SCCM) documentation](/mem/configmgr)
* [Import updates from Microsoft Catalog into Configuration Manager](/mem/configmgr/sum/get-started/synchronize-software-updates#import-updates-from-the-microsoft-update-catalog)
* [Windows Server Update Services (WSUS) documentation](/windows-server/administration/windows-server-update-services/get-started/windows-server-update-services-wsus)
