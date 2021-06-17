---
title: Visual Studio administrator guide
titleSuffix: ''
description: Learn more about how to deploy Visual Studio in an enterprise environment.
ms.date: 04/06/2021
ms.custom: seodec18
ms.topic: overview
helpviewer_keywords:
- network installation, Visual Studio
- administrator guide, Visual Studio
- installing Visual Studio, administrator guide
ms.assetid: 4af353f5-6cfd-4ebe-bcfb-f42306e451a0
author: j-martens
ms.author: jmartens
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Visual Studio administrator guide

In enterprise environments, system administrators typically deploy installations to end users from a network share or by using systems management software. We've designed the Visual Studio setup engine to support enterprise deployment by giving system administrators the ability to create a network install location, to pre-configure installation defaults, to deploy product keys during the installation process, and to manage product updates after a successful rollout.

This administrator guide provides scenario-based guidance for enterprise deployment in networked environments.

## Before you begin

Before you deploy Visual Studio across your organization, there are a few decisions to make and tasks to complete:

::: moniker range=">=vs-2019"

* Make sure that each target computer meets the [minimum installation requirements](/visualstudio/releases/2019/system-requirements/).

::: moniker-end

::: moniker range="vs-2017"

* Make sure that each target computer meets the [minimum installation requirements](/visualstudio/productinfo/vs2017-system-requirements-vs/).

::: moniker-end

* Decide on your servicing needs.

  If your company needs to stay on a feature set longer but still wants to get regular servicing updates, plan to use a servicing baseline. For more information, see the ***Support options for Enterprise and Professional customers*** section of the [Visual Studio product lifecycle and servicing](/visualstudio/releases/2019/servicing#support-options-for-enterprise-and-professional-customers) page, as well as the [Update Visual Studio while on a servicing baseline](update-servicing-baseline.md) page.

* Decide on the update model.

  Where do you want individual client machines to get the product updates from? Specifically, decide whether you want the client to get updates from the internet or from a company-wide local share. Then, if you choose to use a local share, decide whether individual users can update their own clients or if you want an admin to update the clients programmatically. It's best if these decisions were made before the original installation happens on the client machine. For more information, see [Create a network-based installation of Visual Studio](../install/create-a-network-installation-of-visual-studio.md).

  It's possible to update a network installation layout of Visual Studio with the latest product updates so that it can be used both as an installation point for the latest update of Visual Studio, and also to maintain installations that are already deployed to client workstations. For more information, see [Update a network-based installation of Visual Studio](../install/update-a-network-installation-of-visual-studio.md).

  Organizations that utilize enterprise deployment tools can take advantage of the fact that Visual Studio updates are available on the Microsoft Update Catalog and Windows Server Update Services. For more information, see [Enabling administrator updates](../install/enabling-administrator-updates.md) and [Applying administrator updates](../install/applying-administrator-updates.md).

  For computers that are not connected to the internet, creating a minimal layout is the easiest and fastest way to update your offline Visual Studio instances. For more information, see [Update Visual Studio using a minimal offline layout](update-minimal-layout.md).

::: moniker range=">=vs-2019"

* Decide which [workloads and components](workload-and-component-ids.md?view=vs-2019&preserve-view=true) your company needs.

* Decide whether to use a [response file](automated-installation-with-response-file.md?view=vs-2019&preserve-view=true) (that simplifies managing details in the script file).

::: moniker-end

::: moniker range="vs-2017"

* Decide which [workloads and components](workload-and-component-ids.md?view=vs-2017&preserve-view=true) your company needs.

* Decide whether to use a [response file](automated-installation-with-response-file.md?view=vs-2017&preserve-view=true) (that simplifies managing details in the script file).

::: moniker-end

* Decide if you want to enable Group Policy, and if you want to configure Visual Studio to disable customer feedback on individual computers.

::: moniker range=">=vs-2019"

## Step 1 - Download Visual Studio product files

* [Select the workloads and components](workload-and-component-ids.md?view=vs-2019&preserve-view=true) that you want to install.

* [Create a network share for the Visual Studio product files](create-a-network-installation-of-visual-studio.md?view=vs-2019&preserve-view=true).

## Step 2 - Build an installation script

* Build an installation script that uses [command-line parameters](use-command-line-parameters-to-install-visual-studio.md?view=vs-2019&preserve-view=true) to control the installation.

  >[!NOTE]
  > You can simplify scripts by using a [response file](automated-installation-with-response-file.md?view=vs-2019&preserve-view=true). Make sure to create a response file that contains your default installation option.

* (Optional) [Apply a volume license product key](automatically-apply-product-keys-when-deploying-visual-studio.md?view=vs-2019&preserve-view=true) as part of the installation script so that users don't need to activate the software separately.

* (Optional) Update the network layout to [control when and from where product updates are delivered to your end-users](controlling-updates-to-visual-studio-deployments.md?view=vs-2019&preserve-view=true).

* (Optional) Set registry policies that affect the deployment of Visual Studio such as where some packages shared with other versions or instances are installed, [where packages are cached](set-defaults-for-enterprise-deployments.md?view=vs-2019&preserve-view=true) or [whether packages are cached](disable-or-move-the-package-cache.md?view=vs-2019&preserve-view=true).

* (Optional) Set Group Policy. You can also [configure Visual Studio to disable customer feedback](../ide/visual-studio-experience-improvement-program.md) on individual computers.

## Step 3 - Deploy updates

Use your deployment technology of choice to execute your script onto your target developer workstations.

* [Refresh your network location with the latest updates](update-a-network-installation-of-visual-studio.md?view=vs-2019&preserve-view=true) to Visual Studio by running the command you used in step 1 on a regular basis to add updated components.

  You can update Visual Studio by using an update script. To do so, use the [`update`](use-command-line-parameters-to-install-visual-studio.md?view=vs-2019&preserve-view=true) command-line parameter.

  You can deploy Visual Studio updates from the Windows Server Update Services or the Microsoft Update Catalog with tools like System Center Configuration Manager.  Refer to [Applying administrator updates](applying-administrator-updates.md) for more information. 

## Step 4 - (Optional) Use Visual Studio tools to verify installation

We have several tools available to help you [detect and manage installed Visual Studio instances](tools-for-managing-visual-studio-instances.md?view=vs-2019&preserve-view=true) on client machines.

## Advanced configuration

By default, the Visual Studio installation enables custom type inclusion in Bing searches from error list F1 and code links. You can configure Visual Studio to disable the search mechanism from including any custom user types by changing the value of the following registry key by policy:

**“PutCustomTypeInBingSearch” DWORD 0**

The registry is located in the *Software\Microsoft\VisualStudio\16.0_{InstanceId}\Roslyn\Internal\Diagnostics\* directory of your private registry hive. For instructions on how to open the registry hive, see [editing the registry for a Visual Studio instance](tools-for-managing-visual-studio-instances.md?view=vs-2019&preserve-view=true#editing-the-registry-for-a-visual-studio-instance).

::: moniker-end

::: moniker range="vs-2017"

## Step 1 - Download Visual Studio product files

* [Select the workloads and components](workload-and-component-ids.md?view=vs-2017&preserve-view=true) that you want to install.

* [Create a network share for the Visual Studio product files](create-a-network-installation-of-visual-studio.md?view=vs-2017&preserve-view=true).

## Step 2 - Build an installation script

* Build an installation script that uses [command-line parameters](use-command-line-parameters-to-install-visual-studio.md?view=vs-2017&preserve-view=true) to control the installation.

  >[!NOTE]
  > You can simplify scripts by using a [response file](automated-installation-with-response-file.md?view=vs-2017&preserve-view=true). Make sure to create a response file that contains your default installation option.

* (Optional) [Apply a volume license product key](automatically-apply-product-keys-when-deploying-visual-studio.md?view=vs-2017&preserve-view=true) as part of the installation script so that users don't need to activate the software separately.

* (Optional) Update the network layout to [control when and from where product updates are delivered to your end-users](controlling-updates-to-visual-studio-deployments.md?view=vs-2017&preserve-view=true).

* (Optional) Set registry policies that affect the deployment of Visual Studio such as where some packages shared with other versions or instances are installed, [where packages are cached](set-defaults-for-enterprise-deployments.md?view=vs-2019&preserve-view=true) or [whether packages are cached](disable-or-move-the-package-cache.md?view=vs-2017&preserve-view=true).

* (Optional) Set Group Policy. You can also [configure Visual Studio to disable customer feedback](../ide/visual-studio-experience-improvement-program.md) on individual computers.

## Step 3 - Deploy updates

Use your deployment technology of choice to execute your script onto your target developer workstations.

* [Refresh your network location with the latest updates](update-a-network-installation-of-visual-studio.md?view=vs-2017&preserve-view=true) to Visual Studio by running the command you used in step 1 on a regular basis to add updated components.

  You can update Visual Studio by using an update script. To do so, use the [`update`](use-command-line-parameters-to-install-visual-studio.md?view=vs-2019&preserve-view=true) command-line parameter.

  You can deploy Visual Studio updates from the Windows Server Update Services or the Microsoft Update Catalog with tools like System Center Configuration Manager. For more information, see [Applying administrator updates](applying-administrator-updates.md).

## Step 4 - (Optional) Use Visual Studio tools to verify installation

We have several tools available to help you [detect and manage installed Visual Studio instances](tools-for-managing-visual-studio-instances.md?view=vs-2017&preserve-view=true) on client machines.

## Advanced configuration

By default, the Visual Studio installation enables custom type inclusion in Bing searches from error list F1 and code links. You can configure Visual Studio to disable the search mechanism from including any custom user types by changing the value of the following registry key by policy:

**“PutCustomTypeInBingSearch” DWORD 0**

The registry is located in the `Software\Microsoft\VisualStudio\15.0_{InstanceId}\Roslyn\Internal\Diagnostics\` directory of your private registry hive. For instructions on how to open the registry hive, see [editing the registry for a Visual Studio instance](tools-for-managing-visual-studio-instances.md?view=vs-2017&preserve-view=true#editing-the-registry-for-a-visual-studio-instance).

::: moniker-end

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Enabling administrator updates](enabling-administrator-updates.md)
* [Applying administrator updates](applying-administrator-updates.md)
* [Command-line parameter examples](command-line-parameter-examples.md)
* [Install certificates required for Visual Studio offline installation](install-certificates-for-visual-studio-offline.md)
* [Import or export installation configurations](import-export-installation-configurations.md)
* [Visual Studio Setup Archives](https://devblogs.microsoft.com/setup/tag/vs2017/)
* [Visual Studio product lifecycle and servicing](/visualstudio/releases/2019/servicing/)
* [Synchronous autoload settings](../extensibility/synchronously-autoloaded-extensions.md)
