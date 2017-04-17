---
title: "How to: Configure Projects to Target Platforms | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "project settings [Visual Studio], targeting platforms"
  - "platforms, targeting specific CPUs"
  - "project properties [Visual Studio], targeting platforms"
  - "projects [Visual Studio], targeting platforms"
  - "64-bit [Visual Studio]"
  - "64-bit programming [Visual Studio]"
  - "CPUs, targeting specific"
  - "64-bit applications [Visual Studio]"
ms.assetid: 845302fc-273d-4f81-820a-7296ce91bd76
caps.latest.revision: 13
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
# How to: Configure Projects to Target Platforms
[!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] enables you to set up your applications to target different platforms, including 64-bit platforms. For more information on 64-bit platform support in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], see [64-bit Applications](http://msdn.microsoft.com/Library/fd4026bc-2c3d-4b27-86dc-ec5e96018181).  
  
## Targeting Platforms with the Configuration Manager  
 The **Configuration Manager** provides a way for you to quickly add a new platform to target with your project. If you select one of the platforms included with [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], the properties for your project are modified to build your project for the selected platform.  
  
#### To configure a project to target a 64-bit platform  
  
1.  On the menu bar, choose **Build**, **Configuration Manager**.  
  
2.  In the **Active solution platform** list, choose a 64-bit platform for the solution to target, and then choose the **Close** button.  
  
    1.  If the platform that you want doesn’t appear in the **Active solution platform** list, choose **New**.  
  
         The **New Solution Platform** dialog box appears.  
  
    2.  In the **Type or select the new platform** list, choose **x64**.  
  
        > [!NOTE]
        >  If you give your configuration a new name, you may have to modify the settings in the **Project Designer** to target the correct platform.  
  
    3.  If you want to copy the settings from a current platform configuration, choose it, and then choose the **OK** button.  
  
 The properties for all projects that target the 64-bit platform are updated, and the next build of the project will be optimized for 64-bit platforms.  
  
## Targeting Platforms in the Project Designer  
 The Project Designer also provides a way to target different platforms with your project. If selecting one of the platforms included in the list in the **New Solution Platform** dialog box does not work for your solution, you can create a custom configuration name and modify the settings in the **Project Designer** to target the correct platform.  
  
 Performing this task varies based on the programming language you are using. See the following links for more information:  
  
-   For [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] projects, see [/platform (Visual Basic)](/dotnet/visual-basic/reference/command-line-compiler/platform).  
  
-   For [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] projects, see [Build Page, Project Designer (C#)](../ide/reference/build-page-project-designer-csharp.md).  
  
-   For [!INCLUDE[vcprvc](../code-quality/includes/vcprvc_md.md)] projects, see [/clr (Common Language Runtime Compilation)](/cpp/build/reference/clr-common-language-runtime-compilation).  
  
## See Also  
 [Understanding Build Platforms](../ide/understanding-build-platforms.md)   
 [/platform (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/platform-compiler-option)   
 [64-bit Applications](http://msdn.microsoft.com/Library/fd4026bc-2c3d-4b27-86dc-ec5e96018181)   
 [Visual Studio IDE 64-Bit Support](../ide/visual-studio-ide-64-bit-support.md)