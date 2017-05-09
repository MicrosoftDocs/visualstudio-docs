---
title: "Visual Studio administrator guide | Microsoft Docs"
ms.custom: ""
ms.date: "05/06/2017"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords:
  - "network installation, Visual Studio"
  - "administrator guide, Visual Studio"
  - "installing Visual Studio, administrator guide"
ms.assetid: 4af353f5-6cfd-4ebe-bcfb-f42306e451a0
author: "TerryGLee"
ms.author: "tglee"
manager: "ghogen"
translation.priority.ht:
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt:
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Visual Studio 2017 administrator guide

In enterprise environments, it's common for system administrators to deploy installations to end-users from a network share or using systems management software. We've designed the Visual Studio setup engine to support enterprise deployment, allowing system administrators the ability to create a network install location, to pre-configure installation defaults, to deploy product keys during the installation process and to manage product updates after a successful rollout. This administrator guide provides scenario-based guidance for enterprise deployment in common networked environments.

## Steps for deploying Visual Studio 2017 in an enterprise environment

You can deploy Visual Studio 2017 to client workstations as long as each target computer meets the [minimum installation requirements](https://www.visualstudio.com/en-us/productinfo/vs2017-system-requirements-vs). Whether you're deploying through software like System Center or through a batch file, you'll typically want to go through the following steps:

1. [Create a network share containing the Visual Studio product files](create-a-network-installation-of-visual-studio.md) to a network location;

2. [Select the workloads and components](workload-and-component-ids.md) you want to install;

3. [Create a response file](automated-installation-with-response-file.md) containing default installation options. Or alternatively, [build an installation script](use-command-line-parameters-to-install-visual-studio.md) using command-line parameters to control the installation;

4. Optionally, [apply a volume license product key](automatically-apply-product-keys-when-deploying-visual-studio.md) as part of the installation script so that users don't need to activate the software separately;

5. Update the network layout to [control when product updates are delivered to your end-users](controlling-updates-to-visual-studio-deployments.md);

6. Optionally, set registry keys to [control what is cached on client workstations](set-defaults-for-enterprise-deployments.md);

7. Use your deployment technology of choice to execute the script generated in the previous steps on your target developer workstations;

8. [Refresh your network location with the latest updates](update-a-network-installation-of-visual-studio.md) to Visual Studio by running the command you used in step 1 on a regular basis to add updated components.

> [!IMPORTANT]
> Note that installations from a network share will “remember” the source location they came from. This means that a repair of a client machine might need to return to the network share that the client originally installed from. Choose your network location carefully so that it aligns to the lifetime that you expect to have Visual Studio 2017 clients running in your organization.

## Tools
We have made several tools available that will help you [detect and manage installed Visual Studio instances](tools-for-managing-visual-studio-instances.md) on client machines.

> [!TIP]
> In addition to the documentation in the administrator's guide, a good source of information on Visual Studio 2017 setup is [Heath Stewart's blog](https://blogs.msdn.microsoft.com/heaths/tag/vs2017/).

## See also
* [Install Visual Studio 2017](install-visual-studio.md)
* [Install Visual Studio in offline environments](install-visual-studio-in-offline-environment.md)
* [Use command-line parameters to install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md)
  * [Command-line parameter examples](command-line-parameter-examples.md)
* [Report a problem with Visual Studio 2017](../ide/how-to-report-a-problem-with-visual-studio-2017.md)
