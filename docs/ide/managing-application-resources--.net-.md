---
title: "Managing Application Resources (.NET)"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "msvse_resedit.dlg.SetCustomTool"
  - "msvse_settingsdesigner.err.formatvalue"
  - "msvse_resedit.err.nameblank"
  - "msvse_resedit.err.duplicatename"
helpviewer_keywords: 
  - "editors [Visual Studio], Resource Designer"
  - "Resource Designer"
  - "resources [Visual Studio], managing"
  - "Resources page in Project Designer"
  - "resources types, Resource Designer"
  - "application resources [Visual Studio]"
  - "Project Designer, Resources page"
ms.assetid: f2582734-8ada-4baa-8a7c-e2ef943ddf7e
caps.latest.revision: 20
ms.author: "kempb"
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
# Managing Application Resources (.NET)
Resource files are files that are part of an application but are not compiled, for example icon files or audio files. Since these files are not part of the compilation process, you can change them without having to recompile your binaries. If you are planning to localize your application, you should use resource files for all the strings and other resources that need to be changed when you localize your application.  
  
 For more information about resources in .NET desktop apps, see [Resources in Desktop Apps](../Topic/Resources%20in%20Desktop%20Apps.md). For more information about resources in C++ desktop apps, see [Working with Resource Files](../Topic/Working%20with%20Resource%20Files.md).  
  
 Windows Store apps use a different resource model from desktop apps. For information about resources in Windows Store apps, see [Defining Application Resources](https://msdn.microsoft.com/en-us/library/windows/apps/hh465228.aspx) on the Windows Dev Center website.  
  
## Working with Resources  
 In a managed code project, open the project properties window (right-click the project node in **Solution Explorer** and select **Properties**, or type **project properties** in the **Quick Launch** window, or type ALT + ENTER in the **Solution Explorer** window). Select the **Resources** tab. You can add a .resx file if your project does not contain one already, add and delete different kinds of resources, and modify existing resources.  
  
 To find out how to work with resources in C++ projects, see [How to: Create a Resource](../Topic/How%20to:%20Create%20a%20Resource.md).