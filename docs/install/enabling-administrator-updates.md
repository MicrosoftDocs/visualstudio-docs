---
title: Enabling administrator updates to Visual Studio with Microsoft Endpoint Configuration Manager
titleSuffix: ''
description: Learn more about how to deploy administrator updates to Visual Studio.
ms.date: 11/3/2022
ms.topic: overview
ms.assetid: 546fbad6-f12b-49cf-bccc-f2e63e051a18
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Enabling administrator updates to Visual Studio with Microsoft Endpoint Configuration Manager

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

When Microsoft releases a new Visual Studio update, Microsoft will simultaneously publish a corresponding Visual Studio administrator update package to the Microsoft Update servers. An administrator can then distribute the Visual Studio administrator update package via [Windows Server Update Services (WSUS)](/windows-server/administration/windows-server-update-services/get-started/windows-server-update-services-wsus) by using the [Configuration Manager (SCCM)](/configmgr/core/understand/introduction), or via [Windows Update for Business (WUfB)](/windows/deployment/update/waas-manage-updates-wufb) by using the [Microsoft Endpoint Manager (Intune)](https://endpoint.microsoft.com).

## Use Microsoft Endpoint Manager (Intune) to update to cloud connected devices using Visual Studio administrator updates

[Microsoft Endpoint Manager](https://endpoint.microsoft.com) can be used to configure device policies across the organization such as enrolling the devices into [Windows Update for Business (WUfB)](/windows/deployment/update/waas-manage-updates-wufb) and enabling the [MUUpdateServicePolicy](/install/windows/client-management/mdm/policy-csp-update#update-allowmuupdateservice). Devices that have been configured in this way will automatically be eligible to receive and install the applicable Visual Studio administrator updates via the "Receive updates for other Microsoft products" channel in Windows Update. 

## Enable Configuration Manager (SCCM) to receive and distribute Visual Studio administrator updates

Configuration Manager (SCCM) can be set up to synchronize and download the Visual Studio administrator updates from the Windows Server Update Services (WSUS) catalog, and then deploy it to Visual Studio client machines across the organization.  

* First, to run Configuration Manager (SCCM), you'll need a current licensed version of Windows Server running Microsoft Endpoint Configuration Manager (current branch) and Windows Server Update Services (WSUS). You can’t use WSUS itself to deploy these updates; it must be used in conjunction with SCCM.

* SCCM must be configured to receive notifications when Visual Studio administrator update packages are available. To do that, use the following steps, and for more information, see [Introduction to software updates in Microsoft Endpoint Configuration Manager (SCCM)](/mem/configmgr/sum/understand/software-updates-introduction).

  1. In the SCCM console, select **Administration** (bottom-left), then select **Site Configuration** (middle left), then select **Sites**, and select your site server.

  2. On the **Home** tab ribbon at the top, in the **Settings** group button, select **Configure Site Components**, and then select **Software Update Point**.

  3. In the **Software Update Point Component Properties** dialog box:

    * On the **Products** tab, under the **Developer Tools, Runtimes, and Redistributables** hierarchy, choose the versions of Visual Studio you want to synchronize.

    * On the **Classifications** tab, make sure “Security Updates”, “Feature Packs”, and “Updates” are selected.

  4. Next, synchronize the software updates with the WSUS server by choosing **Software Library** (bottom-left), and then on the **Home** tab ribbon at the top, select the **Synchronize Software Updates** button. Synchronizing Software Updates will make the available Visual Studio administrator updates visible in, and able to be deployed from, the SCCM console.

Note that only Visual Studio security Administrator updates are published to WSUS by default. If you want to deploy feature or quality administrator updates through SCCM, you'll need to [manually import them from the Microsoft Catalog and then deploy them](/mem/configmgr/sum/get-started/synchronize-software-updates#import-updates-from-the-microsoft-update-catalog).

After you perform these steps, you can use the software update management capabilities of Configuration Manager (SCCM) to deploy the Visual Studio administrator updates. The different types and characteristics of Visual Studio administrator updates are described in [Applying administrator updates](./applying-administrator-updates.md), which provides guidance about how and when they should be distributed throughout your organization. For more information about Configuration Manager (SCCM) functionality and options, see [Deploy software updates in Microsoft Endpoint Configuration Manager (SCCM)](/mem/configmgr/sum/deploy-use/deploy-software-updates).

## Enable (or disable) client machines' ability to receive Visual Studio administrator updates from Configuration Manager (SCCM)

The client machines must be configured properly if they are going to recognize and accept Visual Studio administrator updates. 

### Visual Studio Client Detector Utility

The [Visual Studio Client Detector Utility](https://support.microsoft.com/help/5001148) must be installed on the client machines in order for the Visual Studio administrator updates to be properly recognized and received. This utility was included and installed with all Visual Studio product updates that were released on or after May 12, 2020, it is included as a pre-requisite with all the Visual Studio administrator updates, and it is also available on the [Microsoft Update Catalog](https://catalog.update.microsoft.com) to deploy and install independently. 

### Encoding administrator intent on the client machines

The client computers must be enabled to receive Visual Studio administrator updates. This step is necessary to make sure that the updates are not unintentionally or accidentally pushed out to unsuspecting client computers.

The **AdministratorUpdatesEnabled** policy, implemented via a registry key, is designed for the administrator to encode administrator intent. For details on how to set this policy, refer to [Set Policies for Enterprise Deployments](set-defaults-for-enterprise-deployments.md). Admin access on the client computer is required to create and set the value of this policy.

* **AdministratorUpdatesEnabled** policy set to **1** configures the client computer to accept Administrator Updates via WSUS/SCCM.
* **AdministratorUpdatesEnabled** policy set to **2** configures the client computer to accept Administrator Updates via _either_ WSUS/SCCM or WUfB/Intune.
* AdministratorUpdatesEnabled policy set to 0 or absent blocks administrator updates from being applied to the client computer.

### Ensuring the account has the right privileges and permissions
By default, the client machine's SYSTEM account will be downloading and installing the Visual Studio administrator updates. This means that the SYSTEM account must have administrative privileges to the machine. Additionally, depending on [where the client is configured to obtain the product sources from](/visualstudio/install/update-visual-studio#configure-source-location-of-updates-1), the SYSTEM account must also have access to at least to either the [Visual Studio endpoints](/visualstudio/install/install-and-use-visual-studio-behind-a-firewall-or-proxy-server) on the internet or permissions to read from the network layout location in order to download the updated product bits. Note: an easy way to grant permissions to a network share for a collection of client machines' SYSTEM accounts is to grant permissions to the "Domain Computers" AD group.

## Feedback and support

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

You can use the following methods to provide feedback about Visual Studio administrator updates or report issues that affect the updates:

* Refer to the [Troubleshooting Visual Studio installation and upgrade issues](../install/troubleshooting-installation-issues.md) guidance.
* Ask questions to the community at the [Visual Studio Setup Q&A Forum](/answers/topics/vs-setup.html).
* Go to the [Visual Studio support page](https://visualstudio.microsoft.com/vs/support/), and check whether your issue is listed in the FAQ.  You can also select the [Support Link](https://visualstudio.microsoft.com/vs/support/#talktous) button for chat help.
* [Provide feature feedback or report a problem](https://aka.ms/vs/wsus/feedback) to the Visual Studio team regarding this experience of enabling administrator updates.
* Contact your organization’s technical account manager for Microsoft.

## See also

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
