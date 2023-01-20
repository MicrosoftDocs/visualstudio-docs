---
title: Visual Studio administrator guide
titleSuffix: ''
description: Learn more about how to deploy Visual Studio in an enterprise environment.
ms.date: 1/20/2023
ms.topic: overview
helpviewer_keywords:
- network installation, Visual Studio
- administrator guide, Visual Studio
- installing Visual Studio, administrator guide
ms.assetid: 4af353f5-6cfd-4ebe-bcfb-f42306e451a0
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Visual Studio administrator guide

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

In enterprise environments, system administrators typically deploy and update software on end users machines. The Visual Studio product integrates well in these types of environments by giving system administrators the ability to manage and control when and how the Visual Studio software is deployed and updated. Visual Studio can be acquired from the internet, from a network share, or from a product cache, and it can be deployed and updated manually, programatically or by using systems management software. Visual Studio provides the ability to create and maintain acquisition locations, pre-configure installation defaults, deploy product keys during the installation process, and manage product updates after a successful rollout. This administrator guide provides quick links to scenario-based guidance for enterprise deployment.

## Research and plan before you begin

You will need to make a plan for how you deploy Visual Studio across your organization. Below lists some of the key things to think about, and it's best if your plan and decisions are made before the original installation happens on the client machine. 

::: moniker range="=vs-2022"

- Make sure that each target computer meets the [minimum installation requirements](/visualstudio/releases/2022/system-requirements). Note that Visual Studio does not support application virtualization solutions such as Microsoft App-V or MSIX for Windows or third-party app virtualization technologies.

::: moniker-end

::: moniker range="=vs-2019"

- Make sure that each target computer meets the [minimum installation requirements](/visualstudio/releases/2019/system-requirements). Note that Visual Studio does not support application virtualization solutions such as Microsoft App-V or MSIX for Windows or third-party app virtualization technologies.

::: moniker-end

- Clarify your security and compatibility needs. Microsoft recommends that your organization always uses the latest and most secure software.

::: moniker range="=vs-2019"

 - Make sure you understand the support options for Enterprise and Professional customers. For more information, refer to the [Visual Studio product lifecycle and servicing](/visualstudio/releases/2019/servicing-vs2019#support-options-for-enterprise-and-professional-customers) page.  
  
::: moniker-end

::: moniker range=">=vs-2022"

- If your company needs to stay on a feature set longer but still wants to get regular servicing security updates, you should plan to use a long-term servicing channel (LTSC). For more information, see the **Support options for Enterprise and Professional customers** section of the [Visual Studio product lifecycle and servicing](/visualstudio/releases/2022/servicing-vs2022#enterprise-professional-and-build-tools-editions-support) page.  
  
::: moniker-end  

- Follow [Windows security baselines](/windows/security/threat-protection/windows-security-baselines). Microsoft is dedicated to providing its customers with secure operating systems, such as Windows 10 and Windows Server, and secure apps, such as Microsoft Edge. In addition to the security assurance of its products, Microsoft also enables you to have fine control over your environments by providing various configuration capabilities.

### Plan for how Visual Studio should be installed and initialized 

   - How does Visual Studio get originally installed on the machine? The action of installing Visual Studio requires administrative privileges on the machine. Do users have the ability to install the product themselves or will an IT admin need to facilitate it through an elevated process?

   - How are you licensing and [distributing entitlement subscriptions within your organization](/visualstudio/subscriptions/admin-responsibilities)? Does the installation require [product keys](/visualstudio/subscriptions/product-keys)?

   - What [group policy settings](/visualstudio/install/set-defaults-for-enterprise-deployments) need to be configured on your client machines? Can you use the [Administrative Templates (ADMX)](./administrative-templates.md) to configure policies across your organization? 

   - Which [workloads and components](workload-and-component-ids.md) does your company need?  
   
### Plan for how Visual Studio will be regularly updated

   - Where should your client machines acquire the product updates from? This often depends on if clients have access to the internet or not. Should they get their updates from an IT managed and maintained [company-wide network layout](update-a-network-installation-of-visual-studio.md), or should they acquire the updates from the internet? 
   - Who is allowed to update the client machines? Currently, the action of updating Visual Studio requires administrative privileges on the machine. Are users allowed to update their machines, or does an admin need to invoke it centrally or programatically via a system context process? 
   - When should the updates happen? Should it be left to the user's discretion to decide when to update, or are there organizational policies that govern timeliness of updates? 

> [!Tip] 
> We encourage all organizations to [enroll their client machines into Visual Studio Administrator Updates](https://aka.ms/vs/admin/updates/au/blog), a system which delivers security updates on a monthly basis to devices that are enrolled in [Windows Update for Business](/windows/deployment/update/waas-manage-updates-wufb).   

## Install Visual Studio

The following resources will help you do the initial install of Visual Studio in common enterprise scenarios. You'll typically only have to do this once.

- **[Review the Install Visual Studio documentation](install-visual-studio.md)** to get a high level overview of the installation options available to end users. [Select the workloads and components](workload-and-component-ids.md) that you want available for install on your client machines.  

- **[Acquire the correct Visual Studio bootstrapper to install the product](/visualstudio/install/create-a-network-installation-of-visual-studio#download-the-visual-studio-bootstrapper-to-create-the-network-layout).** There are different bootstrappers available for you to choose from. Some bootstrappers install a very particular version of the product, while other bootstrappers initialize the servicing baseline channel. 

- **[Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)**. Use a variety of parameters to programmatically control or customize your Visual Studio installation. You can build an installation script that automates the installation process. For more information, see [command line parameter examples](command-line-parameter-examples.md).

- **[Create a layout (network installation) of Visual Studio](create-a-network-installation-of-visual-studio.md)**. A layout is a cache of the Visual Studio files in a folder on your network that you can use for both the initial installation as well as all product updates. A layout can be used if your client machines have limited internet connectivity. You can use a [response file](automated-installation-with-response-file.md), which allows you to set defaults when [installing the product onto client machines using the layout as a source](create-a-network-installation-of-visual-studio.md#install-visual-studio-onto-a-client-machine-from-a-network-installation). After your layout is created, you should [maintain it regularly](create-a-network-installation-of-visual-studio.md#update-or-modify-your-layout). Remember to make sure that either the user or system account that's running the update has proper access to the network share that contains the layout. For more information, refer to [Troubleshoot network-related errors when you install or use Visual Studio](troubleshooting-network-related-errors-in-visual-studio.md#error-the-product-fails-to-install-or-update-because-network-share-permissions-arent-configured-correctly).

- **[Install required certificates for offline installation](/visualstudio/install/install-certificates-for-visual-studio-offline)**. Install necessary certificates if the client machine is completely disconnected from the internet.

- **[Configure the policies that govern machine wide Visual Studio behavior](/visualstudio/install/set-defaults-for-enterprise-deployments)**. Configure and deploy policies, such as opting in to Administrator Updates and removing out-of-support components, across your organization. The [Visual Studio Administrative Templates (ADMX)](./administrative-templates.md) lists out all the Visual Studio policies that are available for administrators to configure.

- **[Automatically apply product or subscription keys when deploying Visual Studio](automatically-apply-product-keys-when-deploying-visual-studio.md)**. You can programmatically apply a subscription or product key as part of a script that is used to automate the deployment of Visual Studio so that users don't need to activate the software separately. You can set this key either during an installation of Visual Studio or after an installation completes. 

- **[Install and use Visual Studio and Azure Services behind a firewall or proxy server](install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md)**. If your organization uses security measures such as a firewall or a proxy server, then there are domain URLs that you might want to add to an "allowlist" and ports and protocols that you might want to open so that you have the best experience when you install and use Visual Studio and Azure Services. 

## Update Visual Studio

The following resources will help you keep your Visual Studio updated, current, and secure. Best practice is to plan for monthly updates.

- **[Review the Update Visual Studio documentation](update-visual-studio.md)** to get a high level overview of the update options available to end users, and how end users are notified that updates are available.  

- **[Make sure you have configured the long-term servicing channel (LTSC) properly](./update-visual-studio.md#configure-source-location-of-updates-1)** if you want to tightly control when and where updates come from.

- **[Enable Administrator Updates using Microsoft Endpoint Configuration Manager (SCCM and Intune)](enabling-administrator-updates.md)**. [Visual Studio administrator updates are available and deployable](applying-administrator-updates.md) through the [Microsoft Endpoint Manager](/mem/configmgr/core/understand/microsoft-endpoint-manager-faq) software collection which includes all Intune and SCCM managed devices that are enrolled in [Windows Update for Business](/windows/deployment/update/waas-manage-updates-wufb). This is our recommended approach for how enterprises stay secure. [Learn more here](https://aka.ms/vs/admin/updates/au/blog).

- **[Keep your layout (network installation) updated](create-a-network-installation-of-visual-studio.md#update-or-modify-your-layout)** on a regular basis so that it remains current and secure with the latest product updates. Layouts are meant to be used as both as an installation point for new client installs of Visual Studio as well as a source of updated product bits for installations that are already deployed to client workstations. Visual Studio releases security updates on patch Tuesday, the second Tuesday of the month, and we strongly recommend that you update your layouts on a monthly cadence immediately afterwards.

- **[Use command-line parameters to update Visual Studio](use-command-line-parameters-to-install-visual-studio.md)**. Use a variety of parameters to programmatically update Visual Studio. For more information, see [command line parameter examples](command-line-parameter-examples.md).

- **[Update client machines that are based on a network layout](update-a-network-installation-of-visual-studio.md)**. After you've updated your layout, you can then update your client installations of Visual Studio from the updated network layout. This scenario is also designed to work with Administrator Updates, and for [clients that are not connected to the internet](update-a-network-installation-of-visual-studio.md#programatically-update-a-client-that-doesnt-have-internet-access). 
 
- **For computers that are not connected to the internet or not attached to a layout**, you can [update Visual Studio using a minimal offline layout](update-minimal-layout.md). 

## Configure Visual Studio

- **Configure policies that affect the behavior of Visual Studio** Use the [Visual Studio Administrative Templates (ADMX)](./administrative-templates.md) to easily configure Visual Studio policies on client machines across your organization. This includes [configuring policies that govern acquisition behavior](./set-defaults-for-enterprise-deployments.md) such as where some packages shared with other versions or instances are installed, where and whether packages are cached, if administrator updates should be enabled or how they should be applied, which update channels are available and how they're presented to the client, if unsupported components should be removed during an update, and how notifications appear or don't appear. This also includes configuring policies that govern customer feedback, [telemetry](https://aka.ms/vs/admx/telemetry), and [Live Share](https://aka.ms/vsls-policies) behavior.

- **[Create custom bootstrapper packages](../deployment/creating-bootstrapper-packages.md)**. Learn advanced techniques for how to create custom bootstrapper packages to further control your installation configuration by creating product and package manifests. 

* **[Import or export installation configurations](import-export-installation-configurations.md)** to other machines or to layouts.

## Manage, Modify or Repair Visual Studio

- **[Detect, verify, and manage installed Visual Studio instances](tools-for-managing-visual-studio-instances.md)** on client machines.

- **[Get troubleshooting tips](troubleshooting-installation-issues.md)**. Get help when you’re installing or updating Visual Studio, and learn how to report a problem if you’re blocked. These tips include step-by-step instructions that should resolve most online or offline installation issues. 

- **[Repair Visual Studio](repair-visual-studio.md) to fix update issues**. Sometimes your Visual Studio installation becomes damaged or corrupted. A repair is useful for fixing install-time issues across all install operations, including updates. 

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Enabling administrator updates](enabling-administrator-updates.md)
* [Applying administrator updates](applying-administrator-updates.md)
* [Use command-line parameters to install, update, and manage Visual Studio](/visualstudio/install/use-command-line-parameters-to-install-visual-studio)
* [Configure policies for enterprise deployments of Visual Studio](/visualstudio/install/set-defaults-for-enterprise-deployments)
* [Visual Studio Administrative Templates](./administrative-templates.md)
* [Install certificates required for Visual Studio offline installation](install-certificates-for-visual-studio-offline.md)
* [Visual Studio product lifecycle and servicing](/visualstudio/productinfo/vs-servicing)
* [Synchronous autoload settings](../extensibility/synchronously-autoloaded-extensions.md)
