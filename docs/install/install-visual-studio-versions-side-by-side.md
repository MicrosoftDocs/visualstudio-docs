---
title: "Install Visual Studio Versions Side-by-Side | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "side-by-side installations [Visual Studio]"
  - "Help [Visual Studio], installing"
  - "install multiple versions of Visual Studio"
ms.assetid: 4d00f240-4910-4699-aaf3-cda6461f0c29
caps.latest.revision: 48
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
# Install Visual Studio Versions Side-by-Side
You can install this version of Visual Studio on a computer that already has an earlier version installed. If you encounter an installation failure, you can use the [log collection tool](http://go.microsoft.com/fwlink/?LinkId=262077) to collect information about the failures so you can debug the issues yourself.  
  
> [!NOTE]
>  We recommend that you install [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] versions in the order in which they were released. For example, install Visual Studio 2013 before you install Visual Studio 2015.  
  
 Before you install versions side by side, review the following conditions:  
  
-   If you use Visual Studio 2015 to open a solution that was created in [!INCLUDE[vs_dev12](../extensibility/includes/vs_dev12_md.md)], you can later open and modify the solution again in the older version as long as you haven't implemented any features that are specific to Visual Studio 2015.  
  
-   If you try to use Visual Studio 2015 to open a solution that was created in [!INCLUDE[vs_dev12](../extensibility/includes/vs_dev12_md.md)] or an earlier version, you might need to modify your projects and files to be compatible with Visual Studio 2015. For more information, see the [Port, Migrate, and Upgrade Visual Studio Projects](../misc/port-migrate-and-upgrade-visual-studio-projects-in-visual-studio-15-rc.md) page.  
  
-   If you uninstall a version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] on a computer that has more than one version installed, the file associations for [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] are removed for all versions. You can remap these file associations by using the **Restore File Associations** button on the **Environment**, **General** page of the [Options](../ide/reference/general-environment-options-dialog-box.md) dialog box.  
  
-   Visual Studio doesn't automatically upgrade extensions because not all extensions are compatible. You must reinstall the extensions from the [Visual Studio Gallery](http://go.microsoft.com/fwlink/?LinkId=178891) or the software publisher.  
  
## .NET Framework Versions and Side-by-Side Installations  
  
-   Visual Basic, Visual C#, and Visual F# projects use the **Target Framework** option in the **Project Designer** to specify which version of the .NET Framework a project uses. For a C++ project, you can manually change the target framework by modifying the .vcxproj file. For more information, see [Version Compatibility](../Topic/Version%20Compatibility%20in%20the%20.NET%20Framework.md).  
  
     When you create a project, you can specify which version of the .NET Framework the project targets in the **.NET Framework** list in the **New Project** dialog box.  
  
     For language-specific information, see the appropriate topic in the following table.  
  
    |Language|Topic|  
    |--------------|-----------|  
    |[!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)]|[Application Page, Project Designer (Visual Basic)](../ide/reference/application-page-project-designer-visual-basic.md)|  
    |Visual C#|[Application Page, Project Designer (C#)](../ide/reference/application-page-project-designer-csharp.md)|  
    |Visual F#|[Configuring Projects](../Topic/Configuring%20Projects%20\(F%23\).md)|  
    |C++|[How to: Modify the Target Framework and Platform Toolset](../Topic/How%20to:%20Modify%20the%20Target%20Framework%20and%20Platform%20Toolset.md)|  
    |[!INCLUDE[jsprjscript](../debugger/debug-interface-access/includes/jsprjscript_md.md)]|[Running a JScript Application on a Previous Version of the Common Language Runtime](http://msdn.microsoft.com/en-us/bbea51b5-ac03-4e6c-b9a6-f487ef63eda5)|  
  
## See Also  
 [Install Visual Studio](../install/install-visual-studio-2015.md)
 [Port, Migrate, and Upgrade Visual Studio Projects](../misc/port-migrate-and-upgrade-visual-studio-projects-in-visual-studio-15-rc.md)   
 [Building C/C++ Isolated Applications and Side-by-side Assemblies](/visual-cpp/build/building-c-cpp-isolated-applications-and-side-by-side-assemblies)   
 [Customizing Development Settings in Visual Studio](http://msdn.microsoft.com/en-us/22c4debb-4e31-47a8-8f19-16f328d7dcd3)