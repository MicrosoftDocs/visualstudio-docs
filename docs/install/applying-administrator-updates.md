---
title: Deploy and verify Visual Studio administrator updates
description: Enable, configure, apply, and verify Visual Studio administrator updates with Microsoft Intune or Configuration Manager, including error codes.
ms.date: 11/18/2026
ms.topic: how-to
author: madskristensen
ms.author: madsk
ms.subservice: installation
---
# Deploy and verify Visual Studio administrator updates

<a id="applying-administrator-updates-that-use-microsoft-endpoint-manager-sccm-or-intune"></a>

When Microsoft releases a new Visual Studio update, it also publishes a Visual Studio administrator update package to the Microsoft Update servers. An administrator can distribute this Visual Studio administrator update package through [Windows Server Update Services (WSUS) ↗](/windows-server/administration/windows-server-update-services/get-started/windows-server-update-services-wsus) by using [Configuration Manager (SCCM) ↗](/configmgr/core/understand/introduction), or through [Windows Update for Business (WUfB) ↗](/windows/deployment/update/waas-manage-updates-wufb) by using [Microsoft Endpoint Manager (Intune) ↗](https://endpoint.microsoft.com). The Windows Update agent on the client computers recognizes that the update is available and initiates the update.

This article describes how to enable your management system and client machines to receive Visual Studio administrator updates, the different types and characteristics of administrator updates, how and when to distribute them throughout your organization, what configuration options are available, and how to verify and troubleshoot the result.

Administrator updates are updates, not initial installs. They presume that Visual Studio is already installed on the computer; applying an administrator update doesn't initiate a new installation. For initial installation, start with the [enterprise deployment golden paths](enterprise-deployment-golden-paths.md). For disconnected clients that can't receive updates through your management channel, use the [fully offline workflow](deploy-fully-offline-workstations.md).

## Prerequisites

- An existing, supported Visual Studio installation. Visual Studio administrator updates only apply to Visual Studio servicing versions that are still under support. For more information about which servicing baselines are in support during a particular time frame, see [Visual Studio Product Lifecycle and Servicing ↗](/visualstudio/productinfo/vs-servicing-vs). All supported Visual Studio servicing baselines are kept secure.
- A management system that can deliver the update: Intune-managed devices enrolled in Windows Update for Business with updates for other Microsoft products enabled, or Configuration Manager (current branch) with a WSUS software update point. See [Enable your management system to distribute administrator updates](#enable-your-management-system-to-distribute-administrator-updates).
- Client machines enabled to receive administrator updates by the `AdministratorUpdatesEnabled` policy. See [Enable (or disable) client machines' ability to receive Visual Studio administrator updates](#enable-or-disable-client-machines-ability-to-receive-visual-studio-administrator-updates).
- An account on each client that executes the update, normally `SYSTEM`, with administrative privileges and access to the client's configured product source: the Microsoft-hosted endpoints or a maintained network layout.
- A pilot group, maintenance window, and process for collecting installation results and handling restarts.

## Understanding Visual Studio administrator updates

<a id="1-choose-the-update-and-delivery-channel"></a>

Microsoft publishes the Visual Studio administrator update package to the Microsoft Update system through three distribution channels:

- The [Windows Server Update Services (WSUS) ↗](/windows-server/administration/windows-server-update-services/get-started/windows-server-update-services-wsus) channel, which you typically control by using [Configuration Manager (SCCM) ↗](/configmgr/core/understand/introduction) as part of the [Microsoft Endpoint Manager ↗](/mem/configmgr/core/understand/microsoft-endpoint-manager-faq) device management solution.

- The [Windows Update for Business Microsoft Update ↗](/windows/deployment/update/waas-manage-updates-wufb#types-of-updates-managed-by-windows-update-for-business) channel, which you typically control by using [Intune ↗](/mem/intune/) as part of the [Microsoft Endpoint Manager ↗](https://endpoint.microsoft.com) device management solution. Only security and critical updates are published to this channel.

- The [Microsoft Update Catalog ↗](https://www.catalog.update.microsoft.com) channel, where you can download the package and use it to either [update a layout](create-a-network-installation-of-visual-studio.md#update-the-layout-to-a-specific-version-of-the-product) or update a [client instance](update-visual-studio.md#update-from-the-microsoft-catalog).

Most client machines receive updates through the WSUS/SCCM or Windows Update for Business/Microsoft Update/Intune channels. In both scenarios, Microsoft publishes the Visual Studio administrator update to the Microsoft Update servers, where the native Windows Update client agent detects it as available and applicable.

The Visual Studio administrator update package contains information that the Visual Studio Installer on the client machines needs to download and initiate the update. The Visual Studio Installer downloads the actual product update binaries from wherever the [client machine is configured to download updates from](update-visual-studio.md#configure-source-location-of-updates-1), either from the internet or from a layout. Deploying the package successfully through your management system doesn't by itself prove that the product update completed; [verify the result](#verification-error-codes-and-troubleshooting) on the client.

The administrator update package doesn't contain enough information to perform a clean installation of the product, nor does it contain any of the actual product binaries. The Visual Studio administrator updates are cumulative, which means that any Visual Studio update that has a higher product version number and a later release date is a superset of an older, lower version. Check the package's edition, channel, and version applicability rather than assuming that a higher version applies to every instance.

> [!NOTE]
> By default, the client machine's SYSTEM account downloads and installs the Visual Studio administrator updates. The SYSTEM account must have administrative privileges to the machine, and it [must also have access to the internet or the network layout location to download the updated product bits](#ensuring-the-account-has-the-right-privileges-and-permissions).

## Types and characteristics of administrator updates

There are four types of administrator updates to Visual Studio:

- **Security updates** apply to all Visual Studio editions, such as Enterprise, Professional, and Community. They contain limited, highly targeted, and compatible servicing level changes. Security updates don't advance a client to a later minor version. They're designed to deliver fixes to security vulnerabilities to a client that's already at a particular minor version level. Security updates have at least one security fix, but the security fix might not be in a component or workload that's installed on the client machine. For example, Microsoft might fix a security vulnerability in the .NET components and label the update as a security update, but it doesn't have any meaningful effect on a client machine that has only C++ components installed. Security updates might also contain other reliability fixes or other necessary component updates. Microsoft publishes security updates to all three distribution channels listed previously.

- **Critical updates** deliver highly impactful fixes that don't have an associated Microsoft Security Response Center (MSRC) security advisory. They follow the same applicability and delivery behavior as security updates and are published to all three distribution channels listed previously as "Critical Updates." The Visual Studio team primarily uses critical updates for Visual Studio 2017 version 15.9 and Visual Studio 2019 version 16.11.

- **Feature updates** enable IT admins to advance computers in their organization to a more recent minor version of Visual Studio. Feature updates only apply to Visual Studio editions that are commonly found in enterprises, such as Enterprise, Professional, and Build Tools SKUs. Microsoft publishes all feature updates only to the [Microsoft Update Catalog ↗](https://www.catalog.update.microsoft.com) as "Feature Packs" where they're available to optionally be manually [imported into SCCM Configuration Manager ↗](/mem/configmgr/sum/get-started/synchronize-software-updates#import-updates-from-the-microsoft-update-catalog). Feature updates are cumulative and contain additional quality and prior security fixes.

- **Quality updates** also apply only to those Visual Studio editions that are commonly found in enterprises. They contain limited, highly targeted, and compatible servicing level changes. Quality updates don't advance a client to a later minor version. They're designed to deliver performance and reliability fixes or other necessary component updates to a client that's already at a particular minor version level. Quality updates accumulate along with security updates, and thus contain security fixes only if the security fix is already independently released. Microsoft publishes quality updates only to the [Microsoft Update Catalog ↗](https://www.catalog.update.microsoft.com) as "Updates" where they're available to optionally be manually [imported into SCCM Configuration Manager ↗](/mem/configmgr/sum/get-started/synchronize-software-updates#import-updates-from-the-microsoft-update-catalog).

Security, critical, and quality updates service the applicable baseline. Don't use them as a substitute for a planned feature update.

### Decoding the titles of administrator updates

The title of each administrator update reflects the resultant version of the update. For example,

::: moniker range="=vs-2022"

* **Visual Studio 2022 version 17.0.3 update** classified as "Security Update" applies to any Visual Studio 2022 edition on the client that's on either the [Current channel or the 17.0 LTSC channel](update-visual-studio.md?view=vs-2022&preserve-view=true#configure-source-location-of-updates-1), and brings it **up** to the 17.0.3 version.
* **Visual Studio 2022 version 17.1.0 update** classified as a "Feature Pack" applies to Visual Studio 2022 editions licensed for enterprise use on the client that's on the Current channel, and it updates it to the 17.1.0 version.
* **Visual Studio 2022 version 17.2.7 update** classified as "Security Update" applies to any Visual Studio 2022 edition on the client that's on either the Current channel or the 17.2 LTSC channel, and brings it **up** to the 17.2.7 version.
* **Visual Studio 2022 version 17.3.7 security update** applies to any Visual Studio 2022 edition on the client that's on the Current channel and brings it **up** to the 17.3.7 version.

If the client instance is greater than the version of the administrator update that's being applied, then the administrator update will have no effect.
::: moniker-end

::: moniker range="=visualstudio"

The following hypothetical examples illustrate how to interpret update titles. Check the Microsoft Update Catalog for available updates.

* **Visual Studio 2026 version 18.0.3 update** classified as "Security Update" applies to any Visual Studio 2026 edition on the client that's on the [18.0 Stable channel](update-visual-studio.md?view=visualstudio&preserve-view=true#configure-source-location-of-updates-1), and brings it **up** to the 18.0.3 version.
* **Visual Studio 2026 version 18.1.0 update** classified as a "Feature Pack" applies to Visual Studio 2026 editions licensed for enterprise use on the client that's on the Stable channel, and it updates it to the 18.1.0 version.
* **Visual Studio 2026 version 18.2.7 update** classified as "Security Update" applies to any Visual Studio 2026 edition on the client that's on the Stable channel, and brings it **up** to the 18.2.7 version.
* **Visual Studio 2026 version 18.3.7 security update** applies to any Visual Studio 2026 edition on the client that's on the Stable channel and brings it **up** to the 18.3.7 version.

If the client instance is greater than the version of the administrator update that's being applied, then the administrator update will have no effect.
::: moniker-end

Compare the package title and catalog details with the client's actual edition, channel, and installed version. Don't select an update by title alone or assume that every channel receives every update type.

## Enable your management system to distribute administrator updates

<a id="3-configure-the-deployment-system"></a>

### Use Microsoft Endpoint Manager (Intune) to update cloud-connected devices by using Visual Studio administrator updates

<a id="use-microsoft-endpoint-manager-intune-to-update-to-cloud-connected-devices-using-visual-studio-administrator-updates"></a>

<a id="intune-and-windows-update"></a>

Use [Microsoft Endpoint Manager ↗](https://endpoint.microsoft.com) to configure device policies across your organization, such as enrolling devices into [Windows Update for Business (WUfB) ↗](/windows/deployment/update/waas-manage-updates-wufb) and enabling the [MUUpdateServicePolicy ↗](/windows/client-management/mdm/policy-csp-update#update-allowmuupdateservice). Devices that you configure this way are automatically eligible to receive and install the applicable Visual Studio *security* and *critical* administrator updates through the "Receive updates for other Microsoft products" channel in Windows Update.

Also, apply the Visual Studio client policies described in [Enable (or disable) client machines' ability to receive Visual Studio administrator updates](#enable-or-disable-client-machines-ability-to-receive-visual-studio-administrator-updates), and confirm that the effective settings reach the pilot devices before you expect an update. Deploying Visual Studio as an Intune application doesn't enable this Windows Update route automatically.

### Enable Configuration Manager (SCCM) to receive and distribute Visual Studio administrator updates

<a id="configuration-manager"></a>

You can set up Configuration Manager (SCCM) to synchronize and download the Visual Studio administrator updates from the Windows Server Update Services (WSUS) catalog. SCCM can then deploy the administrator updates to Visual Studio client machines across your organization.

* To run Configuration Manager (SCCM), you need a current licensed version of Windows Server running Microsoft Endpoint Configuration Manager (current branch) and Windows Server Update Services (WSUS). You can't use WSUS itself to deploy these updates; you must use it in conjunction with SCCM.
* You must configure SCCM to receive notifications when Visual Studio administrator update packages are available. Use the following steps to set up notifications. For more information, see [Introduction to software updates in Microsoft Endpoint Configuration Manager (SCCM) ↗](/mem/configmgr/sum/understand/software-updates-introduction).
  1. In the SCCM console, select **Administration** (bottom-left), select **Site Configuration** (middle left), select **Sites**, and select your site server.
  2. On the **Home** tab ribbon at the top, in the **Settings** group, select **Configure Site Components**, and then select **Software Update Point**.
  3. In the **Software Update Point Component Properties** dialog box:
      - On the **Products** tab, under the **Developer Tools, Runtimes, and Redistributables** hierarchy, choose the versions of Visual Studio you want to synchronize.
      - On the **Classifications** tab, make sure "Security Updates", "Critical Updates", "Feature Packs", and "Updates" are selected.
  4. Synchronize the software updates with the WSUS server by choosing **Software Library** (bottom-left), and then on the **Home** tab ribbon at the top, select the **Synchronize Software Updates** button. Synchronizing Software Updates makes the available Visual Studio administrator updates visible in, and able to be deployed from, the SCCM console.

  By default, only Visual Studio *security* and *critical* administrator updates are published to WSUS. If you want to deploy feature or quality administrator updates through SCCM, you need to [manually import them from the Microsoft Catalog ↗](/mem/configmgr/sum/get-started/synchronize-software-updates#import-updates-from-the-microsoft-update-catalog), and then deploy them.

After you perform these steps, you can use the software update management capabilities of Configuration Manager (SCCM) to deploy the Visual Studio administrator updates. Target a pilot collection first; see [Pilot and expand the rollout](#pilot-and-expand-the-rollout). For more information about Configuration Manager (SCCM) functionality and options, see [Deploy software updates in Microsoft Endpoint Configuration Manager (SCCM) ↗](/mem/configmgr/sum/deploy-use/deploy-software-updates).

When you import a package from the Microsoft Update Catalog, review the [`--keepWindowsUpdateOn` option](use-command-line-parameters-to-install-visual-studio.md#administrator-update-command-and-command-line-parameters) and the deployment timeout. The default 10-minute package timeout might be too short. A **Required** deployment makes the `--keepWindowsUpdateOn` option unnecessary.

## Enable or disable client machines' ability to receive Visual Studio administrator updates

<a id="2-prepare-clients-and-product-sources"></a>

You must properly configure the client machines for them to recognize and accept Visual Studio administrator updates through either SCCM or Intune.

### Encoding administrator intent on the client machines

Enable the client computers to receive Visual Studio administrator updates. This step ensures that you don't unintentionally or accidentally push updates to unsuspecting client computers.

Use the **AdministratorUpdatesEnabled** policy, implemented through a registry key, to encode administrator intent. This policy is machine-wide and applies to all Visual Studio instances installed on the client. For details on how to set this policy, see [Configure Visual Studio policies](configure-policies-for-enterprise-deployments.md#controlling-administrator-updates). You need admin access on the client computer to create and set the value of this policy. Also, check whether the user-preference policy **AdministratorUpdatesOptOut** blocks the update; it takes precedence over **AdministratorUpdatesEnabled**.

`AdministratorUpdatesEnabled` and `AllowStandardUserControl` serve different purposes. Administrator-update enrollment doesn't grant manual standard-user Installer permissions, and manual self-service permission doesn't enroll a device for administrator updates.

### Ensuring the account has the right privileges and permissions

By default, the client machine's SYSTEM account downloads and installs the Visual Studio administrator updates. Therefore, the SYSTEM account must have administrative privileges to the machine. Depending on [where the client is configured to obtain the product sources](update-visual-studio.md#configure-source-location-of-updates-1), the SYSTEM account must also either have access to the [Visual Studio endpoints](install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md) on the internet, or have sufficient permissions to read from the network layout location to download the updated product bits. An administrator's interactive access doesn't prove that the update account can read the source.

> [!NOTE]
> To grant permissions to client machines' SYSTEM accounts so they can access a network share, grant permissions to the **Domain Computers** AD group.

For a layout, configure read access through both share and NTFS permissions, and keep write access restricted to administrators. Changing a layout's `response.json` doesn't redirect already-installed instances.

### Visual Studio Client Detector Utility

You must install the [Visual Studio Client Detector Utility ↗](https://support.microsoft.com/help/5001148) on the client machines for the Visual Studio administrator updates to be properly recognized and received. The utility determines where the Visual Studio instances are located on disk.

The Visual Studio Client Detector Utility is included and installed with all Visual Studio product updates that were released on or after May 12, 2020. It's included as a prerequisite with all the Visual Studio administrator updates, and it's also available on the [Microsoft Update Catalog ↗](https://catalog.update.microsoft.com) to deploy and install independently.

## Configuring the client machine to receive Administrator Updates

### Configuration options

Use the following configuration options to tailor the Visual Studio administrator update experience so that it aligns with your organization's deployment preferences and requirements.

The most common configuration options are as follows:

- [**Windows Update for Business Microsoft Update opt-in** ↗](/windows/deployment/update/waas-manage-updates-wufb)

    Cloud-connected client machines that Intune manages must be configured for Windows Update for Business and opted into the [AllowMUUpdateServicePolicy ↗](/windows/client-management/mdm/policy-csp-update#update-allowmuupdateservice) to receive Visual Studio administrator updates through the Windows Update for Business Microsoft Update channel.

- [**Visual Studio administrator update opt-in**](#encoding-administrator-intent-on-the-client-machines)

    This registry key is required for the client machine to receive administrator updates through either the WSUS or Windows Update for Business Microsoft Update channels. It's a machine-wide registry key, which means it applies to all instances of Visual Studio installed on the box.

- **Source location of the updated product bits**

    When you execute the update, the client machines download the updated product bits from either the internet via the Microsoft CDN or from a network layout share that the admin prepares and maintains. In both of these cases, the account on the client machine that executes the update (typically SYSTEM, but [can be customized to USER ↗](/mem/configmgr/apps/deploy-use/create-applications#bkmk_dt-ux)) must have both administrative privileges on the machine and access to the source location of product bits.
    * If the product is sourced from the internet, the SYSTEM account executing the update must have access to at least the [Visual Studio endpoints](install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md).
    * If the product is being sourced from a network layout location, then the following conditions must be true before the administrator update can be successfully deployed:
      * The account executing the update must have permissions to the network share. For example, if SYSTEM accounts are executing the administrator updates, then you need to give the "Domain Computers" group permissions to the network layout share.
      * The client machine must have, at some point, already run the bootstrapper from that network layout location. Ideally, the original client install happens by using the bootstrapper from the network layout, but it's also possible to update by using an updated bootstrapper in that same network location. Either one of these actions embeds, on the client machine, a connection with that particular layout location.
      * The network layout location (where the client is connected to) must be [updated to contain the updated product bits](update-a-network-installation-of-visual-studio.md) that the administrator update wants to deploy. [Maintain the layout](create-a-network-installation-of-visual-studio.md#maintaining-your-layout) before you deploy the client update.

For an exhaustive list of all the supported administrator update behaviors, refer to the [Controlling Administrator Update policies](configure-policies-for-enterprise-deployments.md#controlling-administrator-updates) or the [Use command-line parameters to update Visual Studio](use-command-line-parameters-to-install-visual-studio.md#administrator-update-command-and-command-line-parameters) documentation.

### Methods for configuring an administrator update

You can configure administrator updates in three ways: by using [policies](#policies), by using a [configuration file](#configuration-file) on the client machine, or by using a [modification of the Administrator Update deployment package within SCCM Configuration Manager or Microsoft Endpoint Manager](#manually-updating-the-administrator-updates-package-in-sccm-or-intune).

#### Policies

Administrator updates check for specific policy configurations, such as **AdministratorUpdatesEnabled**, as described in [Configure Visual Studio policies](configure-policies-for-enterprise-deployments.md#controlling-administrator-updates). You need admin access on the client computer to configure policies. Apply policies before rollout rather than changing each update package.

#### Configuration file

You can preserve some settings on the client machine in an optional configuration file. This approach benefits you by setting it once and applying it to all future administrator updates. The configuration file behaves like a registry key and is machine-wide, which means it applies to all installs of Visual Studio installed on the client machine. The standard location for the configuration file is `C:\ProgramData\Microsoft\VisualStudio\updates.config`. If you want to use another location to store the file, you can do so by configuring the **UpdateConfigurationFile** policy and setting the value to the full path of your config file. A configured path that doesn't exist causes the update to fail.

The configuration file, which is in JSON format, supports the option `installerUpdateArgs`, which is an array of strings separated by commas that specify more switches you can pass into the Visual Studio Installer. If the contents of the file include an invalid field or an option that isn't supported, the update fails. This JSON array format differs from command-line usage, where `--installerUpdateArgs` takes one double-quoted string of space-separated switches. For more information, see [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md#administrator-update-command-and-command-line-parameters).

Here's an example configuration file:

```json
{
  "installerUpdateArgs": ["--quiet", "--keepWindowsUpdateOn"],
  "checkPendingReboot": "true"
}
```

#### Manually updating the Administrator Updates Package in SCCM or Intune

An IT admin can manually modify the command-line parameters of an individual administrator update package in either SCCM or Microsoft Endpoint Manager. We don't generally recommend this approach, although it's technically possible. Use policies or the configuration file for repeatable settings. If you customize an individual package's command line, use only its documented parameters and test the resulting command in the deployment context. Changing a command in an Intune application doesn't configure Windows Update delivery.

## Verification, error codes, and troubleshooting

<a id="4-pilot-and-verify-the-update"></a>

### Determining that Visual Studio was updated

You can use one of the following methods to verify that the administrator update was installed correctly:

* On the client computer, start Visual Studio, select **Help** > **About**, and verify that the version number matches the last number in the title of the intended update.
* Use the **vswhere** tool on the client machine to identify the various versions of Visual Studio on the computer, and confirm the intended instance, edition, channel, and target version. For more information, see [Tools for detecting and managing Visual Studio instances](tools-for-managing-visual-studio-instances.md).
* Each administrative update attempt generates several log files in the `%temp%` directory of the account that executes the update. These log files capture the progress of the update operation. For a system-context update, inspect that account's temporary directory rather than only the signed-in developer's `%temp%`. Sort the folder by date and look for files that begin with `dd_updatedriver`, `dd_bootstrapper`, `dd_installer`, and `dd_setup` for the administrative updates, the bootstrapper, the Visual Studio Installer, and the setup engine, respectively. Verify that these log files contain a final result of 0, which indicates that the update was successfully applied. The logs can also show whether the configuration file is being used. For more information, see the [Visual Studio Log Collection Tool ↗](https://www.microsoft.com/download/details.aspx?id=12493).

After a pilot deployment, handle any restart requirement and repeat version detection. Build a representative solution to check required workloads, extensions, licensing, and package restore. Confirm that the instance still uses the intended source for the next update.

### Error codes and conditions

> [!IMPORTANT]
> Remember that Visual Studio must be closed before you install the update. If Visual Studio is open or being used, the update installation will be canceled.

Ask developers to save their work and close Visual Studio before the maintenance window. To prompt developers to save their work and close Visual Studio when an administrator update is blocked by running Visual Studio or setup processes, set the `AdministratorUpdatesNotifications` policy to `1`. This setting also enables update status notifications and respects Windows toast-notification settings. For more information, see [Controlling Administrator Updates](configure-policies-for-enterprise-deployments.md#controlling-administrator-updates).

The documented [`--force` option](use-command-line-parameters-to-install-visual-studio.md#administrator-update-command-and-command-line-parameters) can close Visual Studio and cause loss of unsaved work. For administrator updates, it applies only in user context and is ignored in system context. Don't force-close developers' work as the default recovery action.

Administrator updates might return the following codes:

| Error code | Definition | Suggested action |
|------------|------------|------------------|
| 0          | The administrative update was successfully installed. | Verify the target instance and developer workflow before recording rollout success. |
| 1001       | Visual Studio Installer or a related setup process is running. The update isn't applied. | Let the other setup operation finish, and then retry. |
| 1002       | Visual Studio Installer is paused. The update isn't applied. | Resume or cancel the paused operation, and then retry. |
| 1003       | Visual Studio is in use, so the update was canceled. This condition can be overruled by using the `--force` flag. | Arrange a maintenance window with Visual Studio closed, and then retry. |
| 1004       | No internet detected. The update was unable to contact the internet location holding the updated files. The update isn't applied. | Check network access to the configured product source as the execution account. |
| 1005       | The **AdministratorUpdatesEnabled** registry value is set to **0** or not set at all. The update isn't applied. | Check the effective administrator-update enrollment policy. |
| 1006       | The **AdministratorUpdatesOptOut** registry value is set to **1**. The update isn't applied. The key is intended for client computers that should not be updated by the administrator. | Confirm whether the opt-out is intended. |
| 1007       | The Visual Studio Installer isn't installed. | Install or repair the Visual Studio Installer before retrying. |
| 1009       | The Visual Studio instance is configured to use a layout, but the layout is missing packages to perform the update. | Update the layout to include the required product packages. |
| 3010       | The system requires a reboot. The update might not have been applied. Reboot the computer and attempt the update again. | Restart the client and verify its version; retry if the update didn't apply. |
| 8006       | Update was canceled because a Visual Studio related process is running. | Close Visual Studio related processes, and then retry. |
| 862968     | The update was successful, and a restart is recommended but not required. | Schedule a restart. |
| 8007070    | Update was canceled because there's not enough room on disk. | Free sufficient disk space before retrying. |
| Other      | Error occurred attempting to apply the update. The update isn't applied. | Retain the logs and consult the client error codes. |

For an exhaustive list of client error codes, see [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md#error-codes).

## Pilot and expand the rollout

<a id="5-expand-rollout-and-prepare-the-next-update"></a>

Deploy each update to a pilot group first, verify the results as described in [Verification, error codes, and troubleshooting](#verification-error-codes-and-troubleshooting), and expand to additional device groups only after the pilot meets your success criteria. Track verified instance versions, failed or blocked devices, restarts, and recovery actions. Reuse the validated policies and deployment configuration for the next update, but recheck package applicability and product-source content each time.

Keep a full source available for new installations, modifications, and recovery. For an LTSC baseline, also track [channel eligibility and the planned transition before support ends](control-visual-studio-servicing-with-ltsc.md).

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

[!INCLUDE[install_get_admin_updates_support_md](includes/install_get_admin_updates_support_md.md)]

## See also

To learn more, explore the following additional resources:

* [Golden paths for enterprise deployment](enterprise-deployment-golden-paths.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Configure Visual Studio policies](configure-policies-for-enterprise-deployments.md)
* [Visual Studio Product Lifecycle and Servicing ↗](/visualstudio/productinfo/vs-servicing-vs)
* [Install Visual Studio](install-visual-studio.md)
* [Update Visual Studio](update-visual-studio.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Tools for detecting and managing Visual Studio instances](tools-for-managing-visual-studio-instances.md)
* [Create a network installation of Visual Studio](create-a-network-installation-of-visual-studio.md)
* [Update a Visual Studio client that was installed from a network layout](update-a-network-installation-of-visual-studio.md)
* [Microsoft Update Catalog FAQ ↗](https://www.catalog.update.microsoft.com/faq.aspx)
* [What is Windows Update for Business ↗](/windows/deployment/update/waas-manage-updates-wufb)
* [Intune fundamentals ↗](/mem/intune/fundamentals/)
* [Microsoft Endpoint Configuration Manager (SCCM) documentation ↗](/mem/configmgr)
* [Import updates from Microsoft Catalog into Configuration Manager ↗](/mem/configmgr/sum/get-started/synchronize-software-updates#import-updates-from-the-microsoft-update-catalog)
* [Windows Server Update Services (WSUS) documentation ↗](/windows-server/administration/windows-server-update-services/get-started/windows-server-update-services-wsus)
