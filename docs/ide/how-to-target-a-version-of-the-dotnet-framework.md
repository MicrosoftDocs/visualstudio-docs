---
title: "How to: Target a Version of the .NET Framework | Microsoft Docs"
ms.custom: ""
ms.date: "12/08/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "targeting .NET Framework version [Visual Studio]"
  - "versions [Visual Studio], targeting .NET Framework version"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "dotnet"
---
# How to: Target a Version of the .NET Framework

This document describes how to target a version of the .NET Framework when you create a project, and how to change the targeted version in an existing Visual Basic, Visual C#, or Visual F# project.

> [!IMPORTANT]
> For information about how to change the target version for C++ projects, see [How to: Modify the Target Framework and Platform Toolset](/cpp/build/how-to-modify-the-target-framework-and-platform-toolset).

## Targeting a version when you create a project

When you create a project, the version of the .NET Framework that you target determines which templates you can use.

### To target a version when you create a project

1.  On the menu bar, choose **File**, **New**, **Project**.

2.  In the list at the top of the **New Project** dialog box, choose the version of the .NET Framework that you want your project to target.

3.  In the list of installed templates, choose the type of project that you want to create, name the project, and then choose the **OK** button.

    The list of templates shows only those projects that are supported by the version of the .NET Framework that you chose.

## Changing the target version

You can change the targeted version of the .NET Framework in a Visual Basic, Visual C#, or Visual F# project by following this procedure.

For information about how to change the target version for C++ projects, see [How to: Modify the Target Framework and Platform Toolset](/cpp/build/how-to-modify-the-target-framework-and-platform-toolset).

### To change the targeted version

1.  In **Solution Explorer**, open the shortcut menu for the project that you want to change, and then choose **Properties**.

    ![Visual Studio Solution Explorer Properties](../ide/media/vs_slnexplorer_properties.png "vs_slnExplorer_Properties")

2. In the left column of the properties window, choose the **Application** tab.

    ![Visual Studio App Properties Application tab](../ide/media/vs_slnexplorer_properties_applicationtab.png "vs_slnExplorer_Properties_ApplicationTab")

    > [!NOTE]
    > After you create a UWP app, you can't change the targeted version of either Windows or the .NET Framework.

3.  In the **Target Framework** list, choose the version that you want.

4.  In the verification dialog box that appears, choose the **Yes** button.

    The project unloads. When it reloads, it targets the .NET Framework version that you just chose.

    > [!NOTE]
    > If your code contains references to a different version of the .NET Framework than the one that you targeted, error messages may appear when you compile or run the code. To resolve these errors, you must modify the references. See [Troubleshooting .NET Framework Targeting Errors](../msbuild/troubleshooting-dotnet-framework-targeting-errors.md).

## See also

[Visual Studio Multi-Targeting Overview](../ide/visual-studio-multi-targeting-overview.md)  
[Troubleshooting .NET Framework Targeting Errors](../msbuild/troubleshooting-dotnet-framework-targeting-errors.md)  
[Application Page, Project Designer (C#)](../ide/reference/application-page-project-designer-csharp.md)  
[Application Page, Project Designer (Visual Basic)](../ide/reference/application-page-project-designer-visual-basic.md)  
[How to: Modify the Target Framework and Platform Toolset (C++)](/cpp/build/how-to-modify-the-target-framework-and-platform-toolset)