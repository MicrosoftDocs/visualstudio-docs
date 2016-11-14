---
title: "How to: Target a Version of the .NET Framework | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "targeting .NET Framework version [Visual Studio]"
  - "versions [Visual Studio], targeting .NET Framework version"
ms.assetid: dea62d25-3d1b-492e-a6cc-b5154489800a
caps.latest.revision: 50
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Target a Version of the .NET Framework
This document describes how to target a version of the .NET Framework when you create a project and how to change the targeted version in an existing Visual Basic, Visual C#, or Visual F# project.  
  
> [!IMPORTANT]
>  For information about how to change the target version for C++ projects, see [How to: Modify the Target Framework and Platform Toolset](../Topic/How%20to:%20Modify%20the%20Target%20Framework%20and%20Platform%20Toolset.md).  
  
 **In this topic**  
  
-   [Targeting a version when you create a project](../ide/how-to-target-a-version-of-the-dotnet-framework.md#bkmk_new)  
  
-   [Changing the target version](../ide/how-to-target-a-version-of-the-dotnet-framework.md#bkmk_existing)  
  
##  <a name="bkmk_new"></a> Targeting a version when you create a project  
 When you create a project, the version of the .NET Framework that you target determines which templates you can use.  
  
> [!NOTE]
>  In Express editions of Visual Studio, you must create the project first, and then you can change the target, as [Changing the target version](../ide/how-to-target-a-version-of-the-dotnet-framework.md#bkmk_existing) describes later in this topic.  
  
#### To target a version when you create a project  
  
1.  On the menu bar, choose **File**, **New**, **Project**.  
  
2.  In the list at the top of the **New Project** dialog box, choose the version of the .NET Framework that you want your project to target.  
  
    > [!NOTE]
    >  Typically, only one version of the .NET Framework is installed with Visual Studio. If you want to target another version, you must first make sure that it's installed. See [Visual Studio Multi-Targeting Overview](../ide/visual-studio-multi-targeting-overview.md).  
  
3.  In the list of installed templates, choose the type of project that you want to create, name the project, and then choose the **OK** button.  
  
     The list of templates shows only those projects that are supported by the version of the .NET Framework that you chose.  
  
##  <a name="bkmk_existing"></a> Changing the target version  
 You can change the targeted version of the .NET Framework in a Visual Basic, Visual C#, or Visual F# project by following this procedure.  
  
#### To change the targeted version  
  
1.  In **Solution Explorer**, open the shortcut menu for the project that you want to change, and then choose **Properties**.  
  
     ![Visual Studio Solution Explorer Properties](../ide/media/vs_slnexplorer_properties.png "vs_slnExplorer_Properties")  
  
    > [!IMPORTANT]
    >  For information about how to change the target version for C++ projects, see [How to: Modify the Target Framework and Platform Toolset](../Topic/How%20to:%20Modify%20the%20Target%20Framework%20and%20Platform%20Toolset.md).  
  
2.  In the left column of the properties window, choose the **Application** tab.  
  
     ![Visual Studio App Properties Application tab](../ide/media/vs_slnexplorer_properties_applicationtab.png "vs_slnExplorer_Properties_ApplicationTab")  
  
    > [!NOTE]
    >  After you create a Windows Store app, you can't change the targeted version of either Windows or the .NET Framework.  
  
3.  In the **Target Framework** list, choose the version that you want.  
  
4.  In the verification dialog box that appears, choose the **Yes** button.  
  
     The project unloads. When it reloads, it targets the .NET Framework version that you just chose.  
  
    > [!NOTE]
    >  If your code contains references to a different version of the .NET Framework than the one that you targeted, error messages may appear when you compile or run the code. To resolve these errors, you must modify the references. See [Troubleshooting .NET Framework Targeting Errors](../msbuild/troubleshooting-dotnet-framework-targeting-errors.md).  
  
## See Also  
 [Visual Studio Multi-Targeting Overview](../ide/visual-studio-multi-targeting-overview.md)   
 [.NET Framework Multi-Targeting for ASP.NET Web Projects](../Topic/.NET%20Framework%20Multi-Targeting%20for%20ASP.NET%20Web%20Projects.md)   
 [Troubleshooting .NET Framework Targeting Errors](../msbuild/troubleshooting-dotnet-framework-targeting-errors.md)   
 [Application Page, Project Designer (C#)](../ide/reference/application-page-project-designer-csharp.md)   
 [Application Page, Project Designer (Visual Basic)](../ide/reference/application-page-project-designer-visual-basic.md)   
 [Configuring Projects](../Topic/Configuring%20Projects%20\(F%23\).md)   
 [How to: Modify the Target Framework and Platform Toolset](../Topic/How%20to:%20Modify%20the%20Target%20Framework%20and%20Platform%20Toolset.md)