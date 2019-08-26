---
title: "Visual Studio administrator guide"
titleSuffix: ""
description: "Learn more about how to deploy Visual Studio in an enterprise environment."
ms.date: 06/02/2019
ms.custom: "seodec18"
ms.topic: conceptual
helpviewer_keywords:
  - "network installation, Visual Studio"
  - "administrator guide, Visual Studio"
  - "installing Visual Studio, administrator guide"
ms.assetid: 4af353f5-6cfd-4ebe-bcfb-f42306e451a0
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Visual Studio administrator guide

In enterprise environments, system administrators typically deploy installations to end-users from a network share or by using systems management software. We've designed the Visual Studio setup engine to support enterprise deployment by giving system administrators the ability to create a network install location, to pre-configure installation defaults, to deploy product keys during the installation process, and to manage product updates after a successful rollout.

This administrator guide provides scenario-based guidance for enterprise deployment in networked environments.

## Before you begin

Before you deploy Visual Studio across your organization, there are a few decisions to make and tasks to complete:

::: moniker range="vs-2019"

* Make sure that each target computer meets the [minimum installation requirements](/visualstudio/releases/2019/system-requirements/).

* Decide on your servicing needs.

  If your company needs to stay on a feature set longer but still wants to get regular servicing updates, plan to use a servicing baseline. For more information, see the ***Support options for Enterprise and Professional customers*** section of the [Visual Studio product lifecycle and servicing](/visualstudio/releases/2019/servicing#support-options-for-enterprise-and-professional-customers) page, as well as the [How to: Update Visual Studio while on a servicing baseline](update-servicing-baseline.md) page.

  If you plan to apply servicing updates along with cumulative feature updates, then you can choose the latest bits.

* Decide on the update model.

  Where do you want individual client machines to get updates? Specifically, decide whether you want to get updates from the internet or from a company-wide local share. Then, if you choose to use a local share, decide whether individual users can update their own clients or if you want an admin to update the clients programmatically.

* Decide which [workloads and components](workload-and-component-ids.md?view=vs-2019) your company needs.

* Decide whether to use a [response file](automated-installation-with-response-file.md?view=vs-2019) (that simplifies managing details in the script file).

* Decide if you want to enable Group Policy, and if you want to configure Visual Studio to disable customer feedback on individual computers.

::: moniker-end

::: moniker range="vs-2017"

* Make sure that each target computer meets the [minimum installation requirements](/visualstudio/productinfo/vs2017-system-requirements-vs/).

* Decide on your servicing needs.

  If your company needs to stay on a feature set longer but still wants to get regular servicing updates, plan to use a servicing baseline. For more information, see the ***Support for older versions of Visual Studio*** section of the [Visual Studio product lifecycle and servicing](/visualstudio/releases/2019/servicing#support-for-older-versions-of-visual-studio) page, as well as the [How to: Update Visual Studio while on a servicing baseline](update-servicing-baseline.md) page.

  If you plan to apply servicing updates along with cumulative feature updates, then you can choose the latest bits.

* Decide on the update model.

  Where do you want individual client machines to get updates? Specifically, decide whether you want to get updates from the internet or from a company-wide local share. Then, if you choose to use a local share, decide whether individual users can update their own clients or if you want an admin to update the clients programmatically.

* Decide which [workloads and components](workload-and-component-ids.md?view=vs-2017) your company needs.

* Decide whether to use a [response file](automated-installation-with-response-file.md?view=vs-2017) (that simplifies managing details in the script file).

* Decide if you want to enable Group Policy, and if you want to configure Visual Studio to disable customer feedback on individual computers.

::: moniker-end

::: moniker range="vs-2019"

## Step 1 - Download Visual Studio product files

* [Select the workloads and components](workload-and-component-ids.md?view=vs-2019) that you want to install.

* [Create a network share for the Visual Studio product files](create-a-network-installation-of-visual-studio.md?view=vs-2019).

## Step 2 - Build an installation script

* Build an installation script that uses [command-line parameters](use-command-line-parameters-to-install-visual-studio.md?view=vs-2019) to control the installation.

  >[!NOTE]
  > You can simplify scripts by using a [response file](automated-installation-with-response-file.md?view=vs-2019). Make sure to create a response file that contains your default installation option.

* (Optional) [Apply a volume license product key](automatically-apply-product-keys-when-deploying-visual-studio.md?view=vs-2019) as part of the installation script so that users don't need to activate the software separately.

* (Optional) Update the network layout to [control when and from where product updates are delivered to your end-users](controlling-updates-to-visual-studio-deployments.md?view=vs-2019).

* (Optional) Set registry policies that affect the deployment of Visual Studio such as where some packages shared with other versions or instances are installed, [where packages are cached](set-defaults-for-enterprise-deployments.md?view=vs-2019) or [whether packages are cached](disable-or-move-the-package-cache.md?view=vs-2019).

* (Optional) Set Group Policy. You can also [configure Visual Studio to disable customer feedback](../ide/visual-studio-experience-improvement-program.md) on individual computers.

## Step 3 - Deploy

* Use your deployment technology of choice to execute your script onto your target developer workstations.

## Step 4 - Deploy updates

* [Refresh your network location with the latest updates](update-a-network-installation-of-visual-studio.md?view=vs-2019) to Visual Studio by running the command you used in step 1 on a regular basis to add updated components.

  You can update Visual Studio by using an update script. To do so, use the [`update`](use-command-line-parameters-to-install-visual-studio.md?view=vs-2019) command-line parameter.

## Step 5 - (Optional) Use Visual Studio tools

We have several tools available to help you [detect and manage installed Visual Studio instances](tools-for-managing-visual-studio-instances.md?view=vs-2019) on client machines.

::: moniker-end

::: moniker range="vs-2017"

## Step 1 - Download Visual Studio product files

* [Select the workloads and components](workload-and-component-ids.md?view=vs-2017) that you want to install.

* [Create a network share for the Visual Studio product files](create-a-network-installation-of-visual-studio.md?view=vs-2017).

## Step 2 - Build an installation script

* Build an installation script that uses [command-line parameters](use-command-line-parameters-to-install-visual-studio.md?view=vs-2017) to control the installation.

  >[!NOTE]
  > You can simplify scripts by using a [response file](automated-installation-with-response-file.md?view=vs-2017). Make sure to create a response file that contains your default installation option.

* (Optional) [Apply a volume license product key](automatically-apply-product-keys-when-deploying-visual-studio.md?view=vs-2017) as part of the installation script so that users don't need to activate the software separately.

* (Optional) Update the network layout to [control when and from where product updates are delivered to your end-users](controlling-updates-to-visual-studio-deployments.md?view=vs-2017).

* (Optional) Set registry policies that affect the deployment of Visual Studio such as where some packages shared with other versions or instances are installed, [where packages are cached](set-defaults-for-enterprise-deployments.md?view=vs-2019) or [whether packages are cached](disable-or-move-the-package-cache.md?view=vs-2017).

* (Optional) Set Group Policy. You can also [configure Visual Studio to disable customer feedback](../ide/visual-studio-experience-improvement-program.md) on individual computers.

## Step 3 - Deploy

* Use your deployment technology of choice to execute your script onto your target developer workstations.

## Step 4 - Deploy updates

* [Refresh your network location with the latest updates](update-a-network-installation-of-visual-studio.md?view=vs-2017) to Visual Studio by running the command you used in step 1 on a regular basis to add updated components.

  You can update Visual Studio by using an update script. To do so, use the [`update`](use-command-line-parameters-to-install-visual-studio.md?view=vs-2019) command-line parameter.

## Step 5 - (Optional) Use Visual Studio tools

We have several tools available to help you [detect and manage installed Visual Studio instances](tools-for-managing-visual-studio-instances.md?view=vs-2017) on client machines.

::: moniker-end

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Command-line parameter examples](command-line-parameter-examples.md)
* [Install certificates required for Visual Studio offline installation](install-certificates-for-visual-studio-offline.md)
* [Import or export installation configurations](import-export-installation-configurations.md)
* [Visual Studio Setup Archives](https://devblogs.microsoft.com/setup/tag/vs2017/)
* [Visual Studio product lifecycle and servicing](/visualstudio/releases/2019/servicing/)
* [Synchronous autoload settings](../extensibility/synchronously-autoloaded-extensions.md)
