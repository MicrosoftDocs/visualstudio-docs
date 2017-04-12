---
title: "Visual Studio administrator guide | Microsoft Docs"
ms.custom: ""
ms.date: "04/06/2017"
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
# Visual Studio administrator guide for Visual Studio 2017

 You can deploy Visual Studio on a network as long as each target computer meets the [minimum installation requirements](https://www.visualstudio.com/en-us/productinfo/vs2017-system-requirements-vs).

 Whether you're deploying through software like System Center or through a batch file, you'll typically want to go through the following steps:

1. [Cache the Visual Studio product layout](create-an-offline-installation-of-visual-studio.md) to a network location.

2. [Select the workloads and components](workload-and-component-ids.md) you want to install.

3. [Build an installation script](use-command-line-parameters-to-install-visual-studio.md) using the selected items and other command line parameters to control the installation.

4. Optionally, [apply a volume license product key](automatically-apply-product-keys-when-deploying-visual-studio.md) as part of the installation script so that users don't need to activate the software separately.

5. Use your deployment technology of choice to execute the script generated in the previous steps on your target developer workstations.

6. Refresh your network location with the latest updates to Visual Studio by running the command you used in step 1 on a regular basis to add updated components.

> [!IMPORTANT]
>  Note that installations from a network share will “remember” the source location they came from. This means that a repair of a client machine might need to return to the network share that the client originally installed from. Choose your network location carefully so that it aligns to the lifetime that you expect to have Visual Studio 2017 clients running in your organization.

## Tools

 We have made several tools available that will help you detect and manage installed Visual Studio instances on client machines:

* [VSWhere](https://github.com/microsoft/vswhere): a C++ executable that helps you find the location of core Visual Studio tools from an installed instance of Visual Studio.
* [VSSetup.PowerShell](https://github.com/microsoft/vssetup.powershell): PowerShell scripts that use the Setup Configuration API to identify installed instances of Visual Studio.
* [VS-Setup-Samples](https://github.com/microsoft/vs-setup-samples): C# and C++ samples that demonstrate how to use the Setup Configuration API to query an existing installation.

In addition, the [Setup Configuration API](https://msdn.microsoft.com/en-us/library/microsoft.visualstudio.setup.configuration.aspx) provides interfaces for developers who want to build their own utilities for interrogating Visual Studio instances.

>[!TIP]
>For more information about Visual Studio 2017 installation, see [Heath Stewart's blog articles](https://blogs.msdn.microsoft.com/heaths/tag/vs2017/).


## See also
* [Install Visual Studio 2017](install-visual-studio.md)
* [Create an offline installer for Visual Studio 2017](create-an-offline-installation-of-visual-studio.md)
* [Use command-line parameters to install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md)
  * [Command-line parameter examples](command-line-parameter-examples.md)
* [Report a problem with Visual Studio 2017](../ide/how-to-report-a-problem-with-visual-studio-2017.md)
