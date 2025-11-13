---
title: Enable admin updates to Visual Studio with Microsoft Endpoint Manager
titleSuffix: ''
description: Explore how to enable distribution of administrator updates to Visual Studio with Microsoft Endpoint Configuration Manager.
ms.date: 11/04/2025
ms.topic: overview
author: anandmeg
ms.author: meghaanand
manager: mijacobs

ms.subservice: installation
---
# Enabling administrator updates to Visual Studio with Microsoft Endpoint Configuration Manager

Every time a new Visual Studio update is released, Microsoft will publish a Visual Studio administrator update package to the Microsoft Update servers. An administrator can then distribute this Visual Studio administrator update package via [Windows Server Update Services (WSUS)](/windows-server/administration/windows-server-update-services/get-started/windows-server-update-services-wsus) by using the [Configuration Manager (SCCM)](/configmgr/core/understand/introduction), or via [Windows Update for Business (WUfB)](/windows/deployment/update/waas-manage-updates-wufb) by using the [Microsoft Endpoint Manager (Intune)](https://endpoint.microsoft.com). The Windows Update agent on the client computers will recognize that the update is available and will initiate the update.

## Use Microsoft Endpoint Manager (Intune) to update to cloud connected devices using Visual Studio administrator updates

[Microsoft Endpoint Manager](https://endpoint.microsoft.com) can be used to configure device policies across the organization such as enrolling the devices into [Windows Update for Business (WUfB)](/windows/deployment/update/waas-manage-updates-wufb) and enabling the [MUUpdateServicePolicy](/windows/client-management/mdm/policy-csp-update#update-allowmuupdateservice). Devices that have been configured in this way will automatically be eligible to receive and install the applicable Visual Studio *security* administrator updates via the "Receive updates for other Microsoft products" channel in Windows Update. 

## Enable Configuration Manager (SCCM) to receive and distribute Visual Studio administrator updates

Configuration Manager (SCCM) can be set up to synchronize and download the Visual Studio administrator updates from the Windows Server Update Services (WSUS) catalog.  SCCM can then deploy the administrator updates to Visual Studio client machines across the organization.  

* To run Configuration Manager (SCCM), you'll need a current licensed version of Windows Server running Microsoft Endpoint Configuration Manager (current branch) and Windows Server Update Services (WSUS). You can’t use WSUS itself to deploy these updates; it must be used in conjunction with SCCM.
* SCCM must be configured to receive notifications when Visual Studio administrator update packages are available. To do that, use the following steps, and for more information, see [Introduction to software updates in Microsoft Endpoint Configuration Manager (SCCM)](/mem/configmgr/sum/understand/software-updates-introduction).
  1. In the SCCM console, select **Administration** (bottom-left), then select **Site Configuration** (middle left), then select **Sites**, and select your site server.
  2. On the **Home** tab ribbon at the top, in the **Settings** group button, select **Configure Site Components**, and then select **Software Update Point**.
  3. In the **Software Update Point Component Properties** dialog box:
      - On the **Products** tab, under the **Developer Tools, Runtimes, and Redistributables** hierarchy, choose the versions of Visual Studio you want to synchronize.
      - On the **Classifications** tab, make sure “Security Updates”, “Feature Packs”, and “Updates” are selected.
  4. Synchronize the software updates with the WSUS server by choosing **Software Library** (bottom-left), and then on the **Home** tab ribbon at the top, select the **Synchronize Software Updates** button. Synchronizing Software Updates will make the available Visual Studio administrator updates visible in, and able to be deployed from, the SCCM console.

  Only Visual Studio *security* Administrator updates are published to WSUS by default. If you want to deploy feature or quality administrator updates through SCCM, you'll need to [manually import them from the Microsoft Catalog](/mem/configmgr/sum/get-started/synchronize-software-updates#import-updates-from-the-microsoft-update-catalog), and then deploy them.

After you perform these steps, you can use the software update management capabilities of Configuration Manager (SCCM) to deploy the Visual Studio administrator updates. The different types and characteristics of Visual Studio administrator updates are described in [Applying administrator updates](./applying-administrator-updates.md), which provides guidance on how and when they should be distributed throughout your organization. 

For more information about Configuration Manager (SCCM) functionality and options, see [Deploy software updates in Microsoft Endpoint Configuration Manager (SCCM)](/mem/configmgr/sum/deploy-use/deploy-software-updates).

## Enable (or disable) client machines' ability to receive Visual Studio administrator updates

The client machines must be configured properly if they're going to recognize and accept Visual Studio administrator updates via either SCCM or Intune. 

### Encoding administrator intent on the client machines

The client computers must be enabled to receive Visual Studio administrator updates. This step is necessary to make sure that the updates aren't unintentionally or accidentally pushed out to unsuspecting client computers.

The **AdministratorUpdatesEnabled** policy, implemented via a registry key, is designed for the administrator to encode administrator intent. For details on how to set this policy, refer to [Configure policies for enterprise deployments](configure-policies-for-enterprise-deployments.md#controlling-administrator-updates). Admin access on the client computer is required to create and set the value of this policy.

### Ensuring the account has the right privileges and permissions

By default, the client machine's SYSTEM account will be downloading and installing the Visual Studio administrator updates. Thus, the SYSTEM account must have administrative privileges to the machine. Additionally, depending on [where the client is configured to obtain the product sources from](/visualstudio/install/update-visual-studio#configure-source-location-of-updates-1), the SYSTEM account must also either have access to the [Visual Studio endpoints](/visualstudio/install/install-and-use-visual-studio-behind-a-firewall-or-proxy-server) on the internet, or have sufficient permissions to read from the network layout location in order to download the updated product bits. 

>[!Note]
> An easy way to grant permissions to client machines' SYSTEM accounts so they can access a network share is to grant permissions to the "Domain Computers" AD group.

## Error codes and conditions

Error codes for Visual Studio Administrator updates are defined on the [Applying Administrator Updates](/visualstudio/install/applying-administrator-updates#error-codes-and-conditions) page. 

### Visual Studio Client Detector Utility

The [Visual Studio Client Detector Utility](https://support.microsoft.com/help/5001148) must be installed on the client machines in order for the Visual Studio administrator updates to be properly recognized and received. This utility is used to determine where the Visual Studio instances are located on disk. 

The Visual Studio Client Detector Utility is included and installed with all Visual Studio product updates that were released on or after May 12, 2020.  It's included as a prerequisite with all the Visual Studio administrator updates, and it's also available on the [Microsoft Update Catalog](https://catalog.update.microsoft.com) to deploy and install independently.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

[!INCLUDE[install_get_admin_updates_support_md](includes/install_get_admin_updates_support_md.md)]

## See also

To learn more, explore the following additional resources:

* [Applying administrator updates](../install/applying-administrator-updates.md)
* [Visual Studio administrator guide](../install/visual-studio-administrator-guide.md)
* [Visual Studio Product Lifecycle and Servicing](/visualstudio/productinfo/vs-servicing-vs)
* [Install Visual Studio](../install/install-visual-studio.md)
* [Update Visual Studio](../install/update-visual-studio.md)
* [Microsoft Update Catalog FAQ](https://www.catalog.update.microsoft.com/faq.aspx)
* [What is Windows Update for Business](/windows/deployment/update/waas-manage-updates-wufb)
* [Intune fundamentals](/mem/intune/fundamentals/)
* [Microsoft Endpoint Configuration Manager (SCCM) documentation](/mem/configmgr)
* [Import updates from Microsoft Catalog into Configuration Manager](/mem/configmgr/sum/get-started/synchronize-software-updates#import-updates-from-the-microsoft-update-catalog)
* [Windows Server Update Services (WSUS) documentation](/windows-server/administration/windows-server-update-services/get-started/windows-server-update-services-wsus)
