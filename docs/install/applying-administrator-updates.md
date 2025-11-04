---
title: Apply admin updates to Visual Studio with Microsoft Endpoint Manager
titleSuffix: ''
description: Apply administrator updates to Visual Studio with Microsoft Endpoint Configuration Manager, view configurations, explore update distribution, view reports, and more.
ms.date: 11/04/2025
ms.topic: overview
author: anandmeg
ms.author: meghaanand
manager: mijacobs

ms.subservice: installation
---
# Applying administrator updates that use Microsoft Endpoint Manager (SCCM or Intune)

This document describes different types and characteristics of Visual Studio administrator updates. In this article, you'll find information on how and when they should be distributed throughout your organization, what configuration options are available, and how to view reports and troubleshoot. 

## Prerequisites

For more information about the prerequisites for using administrator updates, see [Enabling administrator updates](../install/enabling-administrator-updates.md). 

Remember that administrator updates are updates, not initial installs. They presume that Visual Studio is already installed on the computer. In other words, applying administrator updates won't initiate a brand new installation.

## Understanding Visual Studio administrator updates

The Visual Studio administrator update package that is published to the Microsoft Update system is available through three distribution channels:

   1. The [Windows Server Update Servers (WSUS)](/windows-server/administration/windows-server-update-services/get-started/windows-server-update-services-wsus) channel, which is typically controlled by the [SCCM Configuration Manager](/configmgr/core/understand/introduction) part of the [Microsoft Endpoint Manager](/mem/configmgr/core/understand/microsoft-endpoint-manager-faq) device management solution.
   2. The [Windows Update for Business Microsoft Update](/windows/deployment/update/waas-manage-updates-wufb#types-of-updates-managed-by-windows-update-for-business) channel, which is typically controlled by the [Intune](/mem/intune/) part of the [Microsoft Endpoint Manager](https://endpoint.microsoft.com) device management solution. Currently, only security updates are published to this channel.
   3. The [Microsoft Update Catalog](https://www.catalog.update.microsoft.com) channel, where you can download the package and use it to either [update a layout](./create-a-network-installation-of-visual-studio.md#update-the-layout-to-a-specific-version-of-the-product) or update a [client instance](./update-visual-studio.md#update-from-the-microsoft-catalog).

The vast majority of client machines are updated using the WSUS/SCCM or Windows Update for Business/Microsoft Update/Intune channels. In both of these scenarios, the Visual Studio administrator update is published to the Microsoft Update servers, where it is then detected as available and applicable by the native Windows Update client agent. 

The Visual Studio administrator update package contains information that the Visual Studio installer on the client machines needs to be able to download and initiate the update. The Visual Studio Installer downloads the actual product update binaries from wherever the [client machine is configured to download updates from](./update-visual-studio.md#configure-source-location-of-updates-1) - either from the internet or from a layout. 

The administrator update package doesn’t contain enough information to perform a clean installation of the product, nor does it contain any of the actual product binaries. The Visual Studio administrator updates are cumulative, which means that any Visual Studio update that has a higher product version number and a later release date is a superset of an older, lower version.

>[!NOTE] 
> By default, the client machine's SYSTEM account will download and install the Visual Studio administrator updates, which means that the SYSTEM account must have administrative privileges to the machine, and it [must also have access to the internet or the network layout location in order to download the updated product bits](#methods-for-configuring-an-administrator-update).  

Visual Studio administrator updates only apply to Visual Studio servicing versions that are still under support. For more information about which Visual Studio servicing baselines are still in support during a particular time frame, see [Visual Studio Product Lifecycle and Servicing](/visualstudio/productinfo/vs-servicing-vs). All supported Visual Studio servicing baselines will be kept secure.  

## Types and characteristics of administrator updates

There are three types of administrator updates to Visual Studio:

- **Security updates** are applicable to all Visual Studio editions (for example, Enterprise, Professional, Community, etc.), and they contain limited, highly targeted and compatible servicing level changes. Security updates won't advance a client to a later minor version; they're designed to deliver fixes to security vulnerabilities to a client that is already at a particular minor version level. Security updates will have at least one security fix in them, but the security fix may or may not be in a component or workload that’s installed on the client machine. For example, we could fix a security vulnerability in the .NET components, and we would label the update as a security update, but it wouldn’t really have any meaningful effect on a client machine that had only C++ components installed. Security updates may also contain other reliability fixes or other necessary component updates. Security updates are published to all three distribution channels listed previously.

- **Feature updates** enable IT admins to advance computers in their organization to a more recent minor version of Visual Studio. Feature updates only apply to Visual Studio editions that are commonly found in enterprises, such as Enterprise, Professional, and Build Tools SKUs. All feature updates will be published only to the [Microsoft Update Catalog](https://www.catalog.update.microsoft.com) as “Feature Packs” where they're available to optionally be manually [imported into SCCM Configuration Manager](/mem/configmgr/sum/get-started/synchronize-software-updates#import-updates-from-the-microsoft-update-catalog). Feature updates are cumulative and will contain additional quality and prior security fixes.

- **Quality updates** are also only applicable to those Visual Studio editions that are commonly found in enterprises, and they contain limited, highly targeted and compatible servicing level changes. Quality updates won't advance a client to a later minor version; they're designed to deliver performance and reliability fixes or other necessary component updates to a client that is already at a particular minor version level. Quality updates accumulate along with security updates, and thus will contain security fixes only if the security fix has already been independently released. Quality updates are also published only to the [Microsoft Update Catalog](https://www.catalog.update.microsoft.com) as “Updates” where they're available to optionally be manually [imported into SCCM Configuration Manager](/mem/configmgr/sum/get-started/synchronize-software-updates#import-updates-from-the-microsoft-update-catalog).

### Decoding the titles of administrator updates

The title of each administrator update the resultant version of the update. For example,

::: moniker range="vs-2019"

* **Visual Studio 2019 version 16.0.0 to 16.9.0 update** classified as a “Feature Pack” will apply to Visual Studio 2019 editions licensed for enterprise use on the client between the entire product version range of 16.0.0 through 16.9.0, and it will update client edition to 16.9.0. 
* **Visual Studio 2019 version 16.0.0 to 16.11.21 update** classified as "Security Updates” will apply to Visual Studio 2019 editions licensed for enterprise use on the client between versions 16.0.0 through 16.11.20, and it will update those client editions to 16.11.21.
* **Visual Studio 2019 version 16.11.21 security update** will apply to Visual Studio 2019 editions licensed for enterprise use on the client between versions 16.0.0 through 16.11.20, and it will update those client editions to 16.11.21.

::: moniker-end

::: moniker range="=vs-2022"

* **Visual Studio 2022 version 17.0.3 update** classified as "Security Update" will apply to any Visual Studio 2022 edition on the client that is on either the [Current channel or the 17.0 LTSC channel](/visualstudio/install/update-visual-studio?view=vs-2022&preserve-view=true#configure-source-location-of-updates-1), and bring it **up** to the 17.0.3 version.  
* **Visual Studio 2022 version 17.1.0 update** classified as a "Feature Pack" will apply to Visual Studio 2022 editions licensed for enterprise use on the client that is on the Current channel, and it will update it to the 17.1.0 version. 
* **Visual Studio 2022 version 17.2.7 update** classified as "Security Update" will apply to any Visual Studio 2022 edition on the client that is on either the Current channel or the 17.2 LTSC channel, and bring it **up** to the 17.2.7 version. 
* **Visual Studio 2022 version 17.3.7 security update** will apply to any Visual Studio 2022 edition on the client that is on the Current channel and bring it **up** to the 17.3.7 version. 

If the client instance is greater than the version of the administrator update that's being applied, then the administrator update will have no effect.
::: moniker-end

::: moniker range="=visualstudio"
<!-- tbd Needs review-->
* **Visual Studio 2026 version 18.0.3 update** classified as "Security Update" will apply to any Visual Studio 2026 edition on the client that is on the [18.0 Stable channel](/visualstudio/install/update-visual-studio?view=visualstudio&preserve-view=true#configure-source-location-of-updates-1), and bring it **up** to the 18.0.3 version.  
* **Visual Studio 2026 version 18.1.0 update** classified as a "Feature Pack" will apply to Visual Studio 2026 editions licensed for enterprise use on the client that is on the Stable channel, and it will update it to the 18.1.0 version. 
* **Visual Studio 2026 version 18.2.7 update** classified as "Security Update" will apply to any Visual Studio 2026 edition on the client that is on the Stable channel, and bring it **up** to the 18.2.7 version. 
* **Visual Studio 2026 version 18.3.7 security update** will apply to any Visual Studio 2026 edition on the client that is on the Stable channel and bring it **up** to the 18.3.7 version. 

If the client instance is greater than the version of the administrator update that's being applied, then the administrator update will have no effect.
::: moniker-end

## Configuring the client machine to receive Administrator Updates

### Configuration options

There are a few configuration options that are can be used to tailor the Visual Studio administrator update experience so that it's compatible and aligned with your organization’s deployment preferences and requirements. 

The most common configuration options are as follows:

- [**Windows Update for Business Microsoft Update opt-in**](/windows/deployment/update/waas-manage-updates-wufb)**

    Cloud connected client machines that are managed by Intune must be configured for Windows Update for Business and opted into the [AllowMUUpdateServicePolicy](/windows/client-management/mdm/policy-csp-update#update-allowmuupdateservice) in order to receive Visual Studio administrator updates through the Windows Update for Business Microsoft Update channel. 

- [**Visual Studio administrator update opt-in**](../install/enabling-administrator-updates.md#encoding-administrator-intent-on-the-client-machines)

    This registry key is required for the client machine to receive administrator updates through either the WSUS or Windows Update for Business Microsoft Update channels. It's a machine-wide registry key, which means it applies to all instances of Visual Studio installed on the box.

- **Source location of the updated product bits**

    When executing the update, the client machines will download the updated product bits from either the internet via the Microsoft CDN or from a network layout share that the admin has prepared and maintained. In both of these cases, the account on the client machine that is executing the update (typically SYSTEM, but [can be customized to USER](/mem/configmgr/apps/deploy-use/create-applications#bkmk_dt-ux)) must have both administrative privileges on the machine and access to the source location of product bits. 
    * If the product is being sourced from the internet, then the SYSTEM account executing the update must have access to at least the [Visual Studio endpoints](/visualstudio/install/install-and-use-visual-studio-behind-a-firewall-or-proxy-server). 
    * If the product is being sourced from a network layout location then the following conditions must be true before the administrator update can be successfully deployed:
    * The account executing the update must have permissions to the network share. For example, if SYSTEM accounts are executing the administrator updates, then you'll need to give the "Domain Computers" group permissions to the network layout share.  
    * The client machine must have, at some point, already run the bootstrapper from that network layout location. Ideally, the original client install would have happened using the bootstrapper from the network layout, but it's also possible to have just installed an update using an updated bootstrapper in that same network location. Either one of these actions would embed, on the client machine, a connection with that particular layout location.
    * The network layout location (where the client is connected to) must be [updated to contain the updated product bits](../install/update-a-network-installation-of-visual-studio.md) that the administrator update wants to deploy.

For an exhaustive list of all the supported administrator update behaviors, refer to the [Controlling Administrator Update Group Policies](./configure-policies-for-enterprise-deployments.md#controlling-administrator-updates) or the [Use command-line parameters to update Visual Studio](./use-command-line-parameters-to-install-visual-studio.md#administrator-update-command-and-command-line-parameters) documentation.

### Methods for configuring an administrator update

There are three main methods of configuring administrator updates: via [policies](#policies)) via a [configuration file](#configuration-file) on the client machine, or via a [modification of the Administrator Update deployment package within SCCM Configuration Manager or Microsoft Endpoint Manager](#manually-updating-the-administrator-updates-package-in-sccm-or-intune).   

#### Policies

Administrator updates look for specific policy configuration such as **AdministratorUpdatesEnabled** as described in [Configure policies for enterprise deployments](./configure-policies-for-enterprise-deployments.md#controlling-administrator-updates). Admin access on the client computer is required to configure policies.

#### Configuration file

Some settings can be preserved on the client machine in an optional configuration file, which has the benefit of setting it only once and having it apply to all future administrator updates. The configuration file approach behaves like a registry key and is machine wide, which means it will apply to all installs of Visual Studio installed on the client machine. The standard location for the configuration file is at `C:\ProgramData\Microsoft\VisualStudio\updates.config`. However, if you wish to use another location to store the file, you can do so by configuring the **UpdateConfigurationFile** policy and set the value to the path of your config file. 

  The configuration file, which is in JSON format, supports the option `installerUpdateArgs`, which is an array of strings separated by commas that specify more switches you can pass into the Visual Studio installer. If the contents of the file include an invalid field or an option that isn't supported, then the update will fail. For more information, see [Use command-line parameters to install Visual Studio](./use-command-line-parameters-to-install-visual-studio.md#administrator-update-command-and-command-line-parameters).

   Here's an example configuration file:

  ```json
  "installerUpdateArgs" : ["--quiet", "--keepWindowsUpdateOn"], 
  "checkPendingReboot" :  "true" 
  ```

#### Manually updating the Administrator Updates Package in SCCM or Intune

The command-line parameters of an individual administrator update package can be manually modified in either SCCM or Microsoft Endpoint Manager by the IT Admin. We don't generally recommend this approach, although it's technically possible.

## Verification, error codes, and troubleshooting

### Determining that Visual Studio was updated

You can use one of the following methods to verify that the administrator update was installed correctly:

* On the client computer, start Visual Studio, select **Help** > **About**, and verify that the version number matches the last number in the title of the intended update.
* Use the **vswhere** tool on the client machine to identify the various versions of Visual Studio on the computer. For more information, see [Tools for detecting and managing Visual Studio instances](../install/tools-for-managing-visual-studio-instances.md).
* Each administrative update attempt generates several log files in the client machine’s `%temp%` directory that captures the progress of the update operation. Sort the folder by date and look for files that begin `dd_updatedriver`, `dd_bootstrapper`, `dd_client`, and `dd_setup` for the administrative updates, the bootstrapper, the Visual Studio Installer, and the setup engine, respectively. Verify that these log files contain a 0, indicating that the update was successfully applied. These log files can also be used to verify that the configuration file is being used. Refer to the [Visual Studio Log Collection Tool](https://www.microsoft.com/download/details.aspx?id=12493) for further details.

### Error codes and conditions

>[!IMPORTANT]
> Remember that Visual Studio must be closed before you install the update. If Visual Studio is open or being used, the update installation will be canceled.

Administrator updates may return the following return codes:  

| Error code | Definition                                                                                                    |
|------------|---------------------------------------------------------------------------------------------------------------|
| 0          | The administrative update was successfully installed.                                                         |
| 1001       | Visual Studio Installer or a related setup process is running. The update is not applied.                     |
| 1002       | Visual Studio Installer is paused. The update is not applied.                                                 |
| 1003       | Visual Studio is in use, so the update was canceled. This condition can be overruled using the `--force` flag. |
| 1004       | No internet detected. The update was unable to contact the internet location holding the updated files. The update is not applied. |
| 1005       | The **AdministratorUpdatesEnabled** registry value is set to **0** or not set at all. The update is not applied. |
| 1006       | The **AdministratorUpdatesOptOut** registry value is set to **1**. The update is not applied. The key is intended for client computers that should not be updated by the administrator. |
| 1007       | The Visual Studio Installer is not installed.                                                                 |
| 1009       | The Visual Studio instance is configured to use a layout, but the layout is missing packages to perform the update. |
| 3010       | The system requires a reboot. The update may or may not have been applied. Reboot the computer and attempt the update again. |
| 8006       | Update was canceled because VS related process is running                                                    |
| 862968     | The update was successful, and a restart is recommended but not required.                                     |
| 8007070    | Update was canceled because there's not enough room on disk.                                     |
| Other      | Error occurred attempting to apply the update. The update is not applied.                                     |

For an exhaustive list of client error codes, see [Use command-line parameters to install Visual Studio](./use-command-line-parameters-to-install-visual-studio.md#error-codes).

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

[!INCLUDE[install_get_admin_updates_support_md](includes/install_get_admin_updates_support_md.md)]

## See also

To learn more, explore the following additional resources:

* [Enabling administrator updates](../install/enabling-administrator-updates.md)
* [Visual Studio administrator guide](../install/visual-studio-administrator-guide.md)
* [Visual Studio Product Lifecycle and Servicing](/visualstudio/productinfo/vs-servicing-vs)
* [Install Visual Studio](../install/install-visual-studio.md)
* [Update Visual Studio](../install/update-visual-studio.md)
* [Using Command Line Parameters to install Visual Studio](../install/use-command-line-parameters-to-install-visual-studio.md)
* [Tools for detecting and managing Visual Studio instances](../install/tools-for-managing-visual-studio-instances.md)
* [Create a network installation of Visual Studio](../install/create-a-network-installation-of-visual-studio.md)
* [Update a Visual Studio client that was installed from a network layout](../install/update-a-network-installation-of-visual-studio.md)
* [Microsoft Update Catalog FAQ](https://www.catalog.update.microsoft.com/faq.aspx)
* [Microsoft Endpoint Configuration Manager (SCCM) documentation](/mem/configmgr)
* [Import updates from Microsoft Catalog into Configuration Manager](/mem/configmgr/sum/get-started/synchronize-software-updates#import-updates-from-the-microsoft-update-catalog)
* [Windows Server Update Services (WSUS) documentation](/windows-server/administration/windows-server-update-services/get-started/windows-server-update-services-wsus)
