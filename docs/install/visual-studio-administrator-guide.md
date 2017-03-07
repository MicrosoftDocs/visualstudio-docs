---
title: "Visual Studio administrator guide | Microsoft Docs"
ms.custom: ""
ms.date: "03/07/2017"
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

You can deploy Visual Studio on a network as long as each target computer meets the [minimum installation requirements](https://www.visualstudio.com/en-us/productinfo/vs2017-system-requirements-vs). You can create a network share by running the setup file with the --layout switch (as described on the [Create an Offline Installation of Visual Studio](create-an-offline-installation-of-visual-studio.md) page) and then copying it from the local machine to the network share.   

 Note that installations from a network share will “remember” the source location they came from. This means that a repair of a client machine might need to return to the network share that the client originally installed from. Choose your network location carefully so that it aligns to the lifetime that you expect to have Visual Studio 2017 clients running in your organization.

## Tools

 We have several tools on offer to help you manage your Visual Studio installations:

* [VS-Setup-Samples](https://github.com/microsoft/vs-setup-samples): C# and C++ samples to help users interrogate the VS instances on their machines.
* [VSWhere](https://github.com/microsoft/vswhere):  a C++ .exe that helps you find core Visual Studio tools.
* [VSSetup.PowerShell](https://github.com/microsoft/vssetup.powershell): powerful PowerShell scripts for common setup-related administration tasks.


## See also
* [Install Visual Studio 2017](install-visual-studio.md)
* [Use command-line parameters to install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md)
* [Create an offline installation of Visual Studio 2017](create-an-offline-installation-of-visual-studio.md)
* [Use Visual Studio workload and component IDs to customize your offline installation](workload-and-component-ids.md)
* [Report a Problem with Visual Studio 2017](../ide/how-to-report-a-problem-with-visual-studio-2017.md)
