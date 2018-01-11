---
title: "Managing Application Resources (.NET) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "msvse_resedit.dlg.SetCustomTool"
  - "msvse_settingsdesigner.err.formatvalue"
  - "msvse_resedit.err.nameblank"
  - "msvse_resedit.err.duplicatename"
helpviewer_keywords: 
  - "Resource Designer"
  - "resources [Visual Studio]"
  - "Resources page in Project Designer"
  - "application resources [Visual Studio]"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Managing application resources (.NET)

Resource files are files that are part of an application but are not compiled, for example icon files or audio files. Since these files are not part of the compilation process, you can change them without having to recompile your binaries. If you are planning to localize your application, you should use resource files for all the strings and other resources that need to be changed when you localize your application.

For more information about resources in .NET desktop apps, see [Resources in Desktop Apps](/dotnet/framework/resources/index).

## Working with resources

In a managed code project, open the project properties window. You can open the properties window by either:

- right-clicking the project node in **Solution Explorer** and selecting **Properties**
- typing "project properties" in the **Quick Launch** window
- choosing **Alt**+**Enter** in the **Solution Explorer** window

Select the **Resources** tab. You can add a .resx file if your project does not contain one already, add and delete different kinds of resources, and modify existing resources.

## Resources in other project types

Resources are managed differently in .NET projects than in other project types. For more information about resources in:

- Universal Windows Platform (UWP) apps, see [App resources and the Resource Management System](/windows/uwp/app-resources/)
- C++ projects, see [Working with Resource Files](/cpp/windows/working-with-resource-files) and [How to: Create a Resource](/cpp/windows/how-to-create-a-resource)

## See also

[Resources in Desktop Apps (.NET Framework)](/dotnet/framework/resources/index)