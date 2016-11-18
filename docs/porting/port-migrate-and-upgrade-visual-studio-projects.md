---
title: "Port, Migrate, and Upgrade Visual Studio Projects | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords:
  - "Win8ExpressDesktopBlock"
  - "w8trefactor"
  - "VS.ReviewProjectAndSolutionChangesDialog.UpgradeRetarget"
  - "ProjectCompatibilityDlgHelpTopic"
  - "VS.ReviewProjectAndSolutionChangesDialog.Upgrade"
helpviewer_keywords:
  - "conversion, projects"
  - "asset compatibility"
  - "projects, conversion"
ms.assetid: bee759bd-6ff5-4c2e-913a-ea7d3c906c29
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
# Port, Migrate, and Upgrade Visual Studio Projects
When you move to a newer version of Visual Studio, you'll want to know if  you must modify any of the solutions, projects, files, and other assets that you created in earlier versions *before* you run them in recent versions.

 Many widely used assets behave the same in our newest version, Visual Studio 2017 RC, as they do in our recent version, Visual Studio 2015. They will also behave the same in our earlier versions, Visual Studio 2013, and Visual Studio 2012.

 For example, in Visual Studio 2017 RC, you can open a project that was created in Visual Studio 2015 or Visual Studio 2013, change it, and then reopen it in Visual Studio 2017 RC; your changes persist and the project behaves the same as it does in the earlier version. The same is true for many assets that were created in Visual Studio 2012.  

 If you use Visual Studio 2015 together with Visual Studio 2013, Visual Studio 2012, or Visual Studio 2010 SP1, you can create and modify projects and files in any of these versions. You can transfer projects and files among the versions as long as you don't add features that are not supported by one of the versions. (For more information about which features specific to which versions, see our [Release Notes](https://www.visualstudio.com/vs/release-notes/).)
