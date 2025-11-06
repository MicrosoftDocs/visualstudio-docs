---
title: Visual Studio administrator guide
titleSuffix: ''
description: Explore deployment options for Visual Studio in an enterprise environment, including acquiring the software and methods for deploying and updating the installation.
ms.date: 11/03/2025
ms.topic: overview
helpviewer_keywords:
- network installation, Visual Studio
- administrator guide, Visual Studio
- installing Visual Studio, administrator guide
author: anandmeg
ms.author: meghaanand
manager: mijacobs

ms.subservice: installation
---
# Visual Studio administrator guide

In enterprise environments, system administrators typically deploy and update software on end users machines. The Visual Studio product integrates well in these types of environments by giving system administrators the ability to manage and control when and how the Visual Studio software is deployed and updated. Visual Studio can be acquired from the internet, from a network share, or from a product cache, and it can be deployed and updated manually, programmatically or by using systems management software. Visual Studio provides the ability to create and maintain acquisition locations, pre-configure installation defaults, deploy product keys during the installation process, and manage product updates after a successful rollout. This administrator guide provides quick links to scenario-based guidance for enterprise deployment.

## Research and plan before you begin

Make a plan for how you deploy Visual Studio across your organization. It's best if your plan and decisions are made before the original installation happens on the client machine. The following guidelines describe key things to consider.

::: moniker range="=visualstudio"

- Make sure that each target computer meets the [minimum installation requirements](/visualstudio/releases/2026/vs-system-requirements). Visual Studio doesn't support application virtualization solutions such as Microsoft App-V or MSIX for Windows or non-Microsoft app virtualization technologies.

::: moniker-end

::: moniker range="=vs-2022"

- Make sure that each target computer meets the [minimum installation requirements](/visualstudio/releases/2022/system-requirements). Visual Studio doesn't support application virtualization solutions such as Microsoft App-V or MSIX for Windows or non-Microsoft app virtualization technologies.

::: moniker-end

::: moniker range="=vs-2019"

- Make sure that each target computer meets the [minimum installation requirements](/visualstudio/releases/2019/system-requirements). Visual Studio doesn't support application virtualization solutions such as Microsoft App-V or MSIX for Windows or non-Microsoft app virtualization technologies.

::: moniker-end

- Clarify your security and compatibility needs. Microsoft recommends that your organization always uses the latest and most secure software.

::: moniker range="=vs-2019"

- Make sure you understand the support options for Enterprise and Professional customers. For more information, see [Visual Studio product lifecycle and servicing](/visualstudio/releases/2019/servicing-vs2019#support-options-for-enterprise-and-professional-customers).  
  
::: moniker-end

::: moniker range=">=visualstudio"
<!-- tbd No new servicing article yet. -->
<!-- tbd Search Admin guide for DEV18 links to articles under the VS 2022 TOC node, since these would need to update to corresponding NEW 2026 articles. -->
- If your company needs to stay on a feature set longer but still wants to get regular servicing security updates, you should plan to use a long-term servicing channel (LTSC). For more information, see the **Support options for Enterprise and Professional customers** section of the [Visual Studio product lifecycle and servicing](/visualstudio/releases/2026/servicing-vs2026#enterprise-professional-and-build-tools-editions-support) page.  
::: moniker-end

::: moniker range="vs-2022"

- If your company needs to stay on a feature set longer but still wants to get regular servicing security updates, you should plan to use a long-term servicing channel (LTSC). For more information, see the **Support options for Enterprise and Professional customers** section of the [Visual Studio product lifecycle and servicing](/visualstudio/releases/2022/servicing-vs2022#enterprise-professional-and-build-tools-editions-support) page.  

::: moniker-end  

- Follow [Windows security baselines](/windows/security/threat-protection/windows-security-baselines). Microsoft is dedicated to providing its customers with secure operating systems, such as Windows 11 and Windows Server, and secure apps, such as Microsoft Edge. In addition to the security assurance of its products, Microsoft also enables you to have fine control over your environments by providing various configuration capabilities.

### Plan how to install and initialize Visual Studio

- How does Visual Studio get originally installed on the machine? The action of *initially* installing Visual Studio by using a bootstrapper requires administrative privileges on the machine. Do users have the ability to install the product themselves or does an IT admin need to facilitate it through an elevated process?

- How do you license and [distribute entitlement subscriptions within your organization](/visualstudio/subscriptions/admin-responsibilities)? Does the installation require [product keys](/visualstudio/subscriptions/product-keys)?

- What [group policy settings](/visualstudio/install/configure-policies-for-enterprise-deployments) need to be configured on your client machines? Can you use the [Administrative Templates (ADMX)](./administrative-templates.md) or the [Microsoft Intune settings catalog](https://devblogs.microsoft.com/visualstudio/configure-visual-studio-policies-using-microsoft-endpoint-manager-intune/) to configure policies across your organization? 

- Which [workloads and components](workload-and-component-ids.md) does your company need? Do you plan to utilize [vsconfig files](import-export-installation-configurations.md) to standardize your teams' installations?

### Plan for regular updates

- Where should your client machines acquire the product updates from? This often depends on whether clients have access to the internet or not. Should they get their updates from an IT-managed and maintained [company-wide network layout](update-a-network-installation-of-visual-studio.md), or should they acquire the updates from the internet?

- Who is allowed to update the client machines? By default, the action of updating Visual Studio requires administrative privileges on the machine, although starting in August 2023, an admin can delegate update capability to standard users by configuring the [`AllowStandardUserControl` policy](https://aka.ms/vs/setup/policies). Standard users can never use the bootstrapper, though. The `AllowStandardUserControl` policy just enables them to use the Visual Studio Installer functionality after the installer is already installed on the client. Are users allowed to update their machines, or does an admin need to invoke it centrally or programmatically via a system context process?

- When should the updates happen? Should it be left to the user's discretion to decide when to update, or are there organizational policies that govern timeliness of updates? 

> [!Tip] 
> We encourage all organizations to [enroll their client machines into Visual Studio Administrator Updates](https://aka.ms/vs/admin/updates/au/blog), a system that delivers security updates on a monthly basis to devices that are enrolled in [Windows Update for Business](/windows/deployment/update/waas-manage-updates-wufb).

## Install Visual Studio

The following resources help with the initial installation of Visual Studio in common enterprise scenarios. You typically only have to do this once.

- **[Review the Install Visual Studio documentation](install-visual-studio.md)** to get a high level overview of the installation options available to end users. [Select the workloads and components](workload-and-component-ids.md) that you want available for installation on your client machines.  

- **[Download the correct Visual Studio bootstrapper to install the product](create-a-network-installation-of-visual-studio.md#download-the-visual-studio-bootstrapper-to-create-the-layout).** There are different bootstrappers available for you to choose from. Some bootstrappers install a particular version of the product, while other bootstrappers initialize the servicing baseline channel. You must be an administrator on the machine to execute any of the bootstrappers.

- **[Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)**. Use various parameters or use an [installation configuration vsconfig file](import-export-installation-configurations.md) to programmatically control or customize your Visual Studio installation. You can build an installation script that automates the installation process. For more information, see [Command-line parameter examples](command-line-parameter-examples.md).

- **[Create a layout (network installation) of Visual Studio](create-a-network-installation-of-visual-studio.md)**. A layout is a cache of the Visual Studio files in a folder on your network that you can use for both the initial installation as well as all product updates. A layout can be used if your client machines have limited internet connectivity. You can use an [installation configuration vsconfig file](import-export-installation-configurations.md) to initialize the contents of the layout. You can use a [response file](automated-installation-with-response-file.md), which allows you to set defaults when [installing the product](deploy-a-layout-onto-a-client-machine.md). After your layout is created, you should [maintain it regularly](create-a-network-installation-of-visual-studio.md#maintaining-your-layout). Remember to make sure that either the user or system account that's running the update has proper access to the network share that contains the layout. For more information, see [Troubleshoot network-related errors](/troubleshoot/developer/visualstudio/installation/troubleshoot-network-related-errors#error-the-product-fails-to-install-or-update-because-network-share-permissions-arent-configured-correctly).

- **[Deploy a layout onto client machines within your organization](deploy-a-layout-onto-a-client-machine.md)**. Learn how to install Visual Studio from a layout onto client machines across your organization.

- **[Install required certificates for offline installation](/visualstudio/install/install-certificates-for-visual-studio-offline)**. Install necessary certificates if the client machine is disconnected from the internet.

- **[Configure policies that govern machine-wide Visual Studio behavior](/visualstudio/install/configure-policies-for-enterprise-deployments)**. Configure and deploy policies across your organization, such as opting in to Administrator Updates, allowing standard users to update, and removing out-of-support components. The Visual Studio policies are available in the [Microsoft Intune settings catalog](/mem/intune/configuration/settings-catalog) as well as the [Visual Studio Administrative Templates (ADMX)](./administrative-templates.md).

- **[Automatically apply product or subscription keys when deploying Visual Studio](automatically-apply-product-keys-when-deploying-visual-studio.md)**. You can programmatically apply a subscription or product key as part of a script that's used to automate the deployment of Visual Studio so that users don't need to activate the software separately. You can set this key either during an installation of Visual Studio or after an installation completes. 

- **[Install and use Visual Studio and Azure Services behind a firewall or proxy server](install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md)**. If your organization uses security measures such as a firewall or a proxy server, then there are domain URLs that you might want to add to an *allowlist* and ports and protocols that you might want to open so that you have the best experience when you install and use Visual Studio and Azure Services. 

## Update Visual Studio

The following resources help you keep your Visual Studio updated, current, and secure. The best practice is to plan for monthly updates.

- **[Review the Update Visual Studio documentation](update-visual-studio.md)** to get a high level overview of the update options available to end users, and how end users are notified that updates are available.  

- **[Configure the long-term servicing channel (LTSC)](update-visual-studio.md#configure-source-location-of-updates-1)** if you want to tightly control when and where updates come from.

- **[Enable standard users with the flexibility to update on demand](/visualstudio/install/configure-policies-for-enterprise-deployments)** if your organizational allows it.

- **[Enabling administrator updates to Visual Studio with Microsoft Endpoint Configuration Manager](enabling-administrator-updates.md)**. [Apply administrator updates that use Microsoft Endpoint Manager](applying-administrator-updates.md) through the [Microsoft Configuration Manager](/mem/configmgr/core/understand/configuration-manager-faq) software collection which includes all Intune and SCCM managed devices that are enrolled in [Windows Update for Business](/windows/deployment/update/waas-manage-updates-wufb). This is our recommended approach for how enterprises stay secure. To learn more, see [Deploy Visual Studio updates to devices enrolled in Windows Update for Business](https://aka.ms/vs/admin/updates/au/blog).

- **[Keep your layout (network installation) updated](create-a-network-installation-of-visual-studio.md#maintaining-your-layout)** regularly so that it remains current and secure with the latest product updates. Layouts are meant to be used as both as an installation point for new client installs of Visual Studio as well as a source of updated product bits for installations that are already deployed to client workstations. Visual Studio releases security updates on patch Tuesday, the second Tuesday of the month, and we strongly recommend that you update your layouts on a monthly cadence immediately afterwards.

- **[Use command-line parameters to update Visual Studio](use-command-line-parameters-to-install-visual-studio.md)**. Use various parameters to programmatically update Visual Studio. For more information, see [Command-line parameter examples](command-line-parameter-examples.md).

- **[Update client machines that are based on a network layout](update-a-network-installation-of-visual-studio.md)**. After you update your layout, you can then update your client installations of Visual Studio from the updated network layout. This scenario is also designed to work with Administrator Updates, and for [clients that aren't connected to the internet](update-a-network-installation-of-visual-studio.md#programmatically-update-a-client-that-doesnt-have-internet-access).

- **For computers that are not connected to the internet or not attached to a layout**, you can [update Visual Studio using a minimal offline layout](update-minimal-layout.md). 

## Configure Visual Studio

- **Configure policies that affect the behavior of Visual Studio.** Use the [Microsoft Intune settings catalog](/mem/intune/configuration/settings-catalog) or the [Visual Studio Administrative Templates (ADMX)](./administrative-templates.md) to easily configure Visual Studio policies on client machines across your organization. This includes [configuring policies that govern installation and update behavior](./configure-policies-for-enterprise-deployments.md) such as who is allowed to update, where some packages shared with other versions or instances are installed, where and whether packages are cached, if administrator updates should be enabled or how they should be applied, which update channels are available and how they're presented to the client, if unsupported components should be removed during an update, and how notifications appear or don't appear. This also includes configuring policies that govern customer feedback, [telemetry](https://aka.ms/vs/admx/telemetry), [Live Share](https://aka.ms/vsls-policies), and [Dev Tunnels](https://aka.ms/devtunnels/vs/admx)behavior.

- **[Create custom bootstrapper packages](../deployment/creating-bootstrapper-packages.md)**. Learn advanced techniques for how to create custom bootstrapper packages to further control your installation configuration by creating product and package manifests. 

- **[Import or export installation configurations](import-export-installation-configurations.md)** to other machines or to layouts.

## Manage, modify, or repair Visual Studio

- **[Tools for detecting, verifying, and managing Visual Studio instances](tools-for-managing-visual-studio-instances.md)** on client machines.

- **[Troubleshoot Visual Studio installation and upgrade issues](/troubleshoot/developer/visualstudio/installation/troubleshoot-installation-issues)**. Get help when you're installing or updating Visual Studio, and learn how to report a problem if you're blocked. These tips include step-by-step instructions that should resolve most online or offline installation issues. 

- **[Repair Visual Studio](repair-visual-studio.md) to fix update issues**. Sometimes your Visual Studio installation becomes damaged or corrupted. A repair is useful for fixing install-time issues across all install operations, including updates. 

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## Related content

* [Enable administrator updates](enabling-administrator-updates.md)
* [Apply administrator updates](applying-administrator-updates.md)
* [Use command-line parameters to install, update, and manage Visual Studio](/visualstudio/install/use-command-line-parameters-to-install-visual-studio)
* [Configure policies for enterprise deployments of Visual Studio](/visualstudio/install/configure-policies-for-enterprise-deployments)
* [Visual Studio Administrative Templates](./administrative-templates.md)
* [Install certificates required for Visual Studio offline installation](install-certificates-for-visual-studio-offline.md)
* [Visual Studio product lifecycle and servicing](/visualstudio/productinfo/vs-servicing)
* [Synchronous autoload settings](../extensibility/synchronously-autoloaded-extensions.md)
