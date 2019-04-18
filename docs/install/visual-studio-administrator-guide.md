---
title: "Visual Studio administrator guide"
titleSuffix: ""
description: "Learn more about how to deploy Visual Studio in an enterprise environment."
ms.date: 04/02/2019
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

In enterprise environments, it's common for system administrators to deploy installations to end-users from a network share or by using systems management software. We've designed the Visual Studio setup engine to support enterprise deployment, allowing system administrators the ability to create a network install location, to pre-configure installation defaults, to deploy product keys during the installation process, and to manage product updates after a successful rollout. This administrator guide provides scenario-based guidance for enterprise deployment in networked environments.

## Deploy Visual Studio in an enterprise environment

::: moniker range="vs-2017"

You can deploy Visual Studio to client workstations as long as each target computer meets the [minimum installation requirements](/visualstudio/productinfo/vs2017-system-requirements-vs/). Whether you're deploying through software like System Center or through a batch file, you'll typically want to go through the following steps:

::: moniker-end

::: moniker range="vs-2019"

You can deploy Visual Studio to client workstations as long as each target computer meets the [minimum installation requirements](/visualstudio/releases/2019/system-requirements/). Whether you're deploying through software like System Center or through a batch file, you'll typically want to go through the following steps:

::: moniker-end

1. [Create a network share that contains the Visual Studio product files](create-a-network-installation-of-visual-studio.md) to a network location.

2. [Select the workloads and components](workload-and-component-ids.md) you want to install.

3. [Create a response file](automated-installation-with-response-file.md) that contains default installation options. Or alternatively, [build an installation script](use-command-line-parameters-to-install-visual-studio.md) that uses command-line parameters to control the installation.

4. Optionally, [apply a volume license product key](automatically-apply-product-keys-when-deploying-visual-studio.md) as part of the installation script so that users don't need to activate the software separately.

5. Update the network layout to [control when product updates are delivered to your end-users](controlling-updates-to-visual-studio-deployments.md).

6. Optionally, set registry keys to [control what is cached on client workstations](set-defaults-for-enterprise-deployments.md).

7. Use your deployment technology of choice to execute the script generated in the previous steps on your target developer workstations.

8. [Refresh your network location with the latest updates](update-a-network-installation-of-visual-studio.md) to Visual Studio by running the command you used in step 1 on a regular basis to add updated components.

> [!IMPORTANT]
> Note that installations from a network share will "remember" the source location they came from. This means that a repair of a client machine might need to return to the network share that the client originally installed from. Choose your network location carefully so that it aligns to the lifetime that you expect to have Visual Studio clients running in your organization.

## Use Visual Studio tools

We have several tools available to help you [detect and manage installed Visual Studio instances](tools-for-managing-visual-studio-instances.md) on client machines.

> [!TIP]
> In addition to the documentation in the administrator guide, a good source of information on Visual Studio setup is the [Visual Studio Setup Archives](https://devblogs.microsoft.com/setup/tag/vs2017/).

## Specify customer feedback settings

By default, the Visual Studio installation enables customer feedback. When you enable Group Policy, you can configure Visual Studio to disable customer feedback on individual computers. To do so, set a registry-based policy on the following key:

**HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\VisualStudio\SQM**

Entry = **OptIn**

Value = (DWORD)
* **0** is opted out
* **1** is opted in

For more information about customer feedback settings, see the [Visual Studio Customer Experience Improvement Program](../ide/visual-studio-experience-improvement-program.md) page.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Install Visual Studio](install-visual-studio.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
  * [Command-line parameter examples](command-line-parameter-examples.md)
  * [Workload and Component ID reference](workload-and-component-ids.md)
* [Create a networked-based installation of Visual Studio](create-a-network-installation-of-visual-studio.md)
  * [Install certificates required for Visual Studio offline installation](install-certificates-for-visual-studio-offline.md)
* [Automate Visual Studio with a response file](automated-installation-with-response-file.md)
* [Automatically apply product keys when deploying Visual Studio](automatically-apply-product-keys-when-deploying-visual-studio.md)
* [Set defaults for enterprise deployments of Visual Studio](set-defaults-for-enterprise-deployments.md)
* [Disable or move the package cache](disable-or-move-the-package-cache.md)
* [Update a networked-based installation of Visual Studio](update-a-network-installation-of-visual-studio.md)
* [Control updates to Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md)
* [Tools for detecting and managing Visual Studio instances](tools-for-managing-visual-studio-instances.md)
* [Visual Studio product lifecycle and servicing](/visualstudio/releases/2019/servicing/)
