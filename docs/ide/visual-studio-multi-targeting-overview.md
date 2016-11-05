---
title: "Visual Studio Multi-Targeting Overview | Microsoft Docs"
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
  - "multi-targeting [Visual Studio]"
  - "multitargeting [Visual Studio]"
ms.assetid: b1702c33-0672-4ebc-b779-2b324d6ea880
caps.latest.revision: 36
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
# Visual Studio Multi-Targeting Overview
In this version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], you can specify the version of the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] that is required for your application. Therefore, if you want to use this version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] to continue to develop a project that you started in an earlier version, you do not have to change the framework target. You could also create a solution that contains projects that target different versions of the framework. Framework targeting also helps guarantee that the application uses only functionality that is available in the specified version of the framework.  
  
> [!TIP]
>  You can also target applications for different platforms. For more information, see [Multitargeting](../msbuild/msbuild-multitargeting-overview.md)  
  
## Framework Targeting Features  
 Framework targeting includes the following features:  
  
-   When you open a project that targets an earlier version of the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)], [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)] can automatically upgrade it or leave the target as is.  
  
-   When you create a project, you can specify the version of the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] that you want to target.  
  
-   You can change the version of the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] that an existing project targets.  
  
-   You can target a different version of the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] in each of several projects in the same solution.  
  
-   When you change the version of the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] that a project targets, [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)] makes any required changes to references and configuration files.  
  
 When you work on a project that targets an earlier version of the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)], Visual Studio dynamically changes the development environment, as follows:  
  
-   It filters items in the **New Project** dialog box, the **Add New Item** dialog box, the **Add New Reference** dialog box, and the **Add Service Reference** dialog box to omit choices that are not available in the targeted version.  
  
-   It filters custom controls in the **Toolbox** to remove those that are not available in the targeted version and to show the only the most up-to-date controls when multiple controls are available.  
  
-   It filters IntelliSense to omit language features that are not available in the targeted version.  
  
-   It filters properties in the **Properties** window to omit those that are not available in the targeted version.  
  
-   It filters menu options to omit options that are not available in the targeted version.  
  
-   For builds, it uses the version of the compiler and the compiler options that are appropriate for the targeted version.  
  
> [!NOTE]
>  Framework targeting does not guarantee that your application will run correctly. You must test your application to make sure it runs against the targeted version. You cannot target framework versions that are earlier than the .NET Framework 2.0.  
  
## Selecting a Target Framework Version  
 When you create a project, select the target [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] version in the **New Project** dialog box. The list of available project templates is filtered based on the selection. In an existing project, you can change the target [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] version in the project properties dialog box. For more information, see [How to: Target a Version of the .NET Framework](../ide/how-to-target-a-version-of-the-dotnet-framework.md).  
  
> [!NOTE]
>  In Express editions of Visual Studio, you cannot set the target framework in the **New Project** dialog box.  
  
## Resolving System and User Assembly References  
 To target a .NET Framework version, you must first install the appropriate assembly references. Assembly references for the .NET Framework versions 2.0, 3.0, and 3.5 are included in the .NET Framework 3.5 SP1, which you can download from the [Microsoft Download Center, Microsoft Visual Studio](http://go.microsoft.com/fwlink/?LinkId=227602) website. Assembly references for the .NET Framework 3.5 Client Profile, the .NET Framework 4, the .NET Framework 4 Client Profile, and Silverlight are also available from the [Visual Studio Downloads](http://go.microsoft.com/fwlink/?LinkId=179687) website.  
  
> [!NOTE]
>  A .NET Framework client profile is a subset of the .NET Framework that provides a limited set of libraries and features. For more information about client profiles, see [.NET Framework Client Profile](../Topic/.NET%20Framework%20Client%20Profile.md).  
  
 The **Add Reference** dialog box disables system assemblies that do not pertain to the target [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] version so that they cannot be added to a project inadvertently. (System assemblies are .dll files that are included in a [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] version.) References that belong to a framework version that is later than the targeted version will not resolve, and controls that depend on such a reference cannot be added. If you want to enable such a reference, reset the [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] target of the project to one that includes the reference.  For more information, see [Introduction to the Project Designer](http://msdn.microsoft.com/en-us/898dd854-c98d-430c-ba1b-a913ce3c73d7).  
  
 For more information about assembly references, see [Resolving Assemblies at Design Time](../msbuild/resolving-assemblies-at-design-time.md).  
  
## Enabling LINQ  
 When you target the .NET Framework 3.5 or later, a reference to System.Core and a project-level import for System.Linq (in Visual Basic only) are added automatically. If you want to use LINQ features, you must also turn Option Infer on (in Visual Basic only). The reference and import are removed automatically if you change the target to an earlier .NET Framework version. For more information, see [How to: Create a LINQ Project](../Topic/How%20to:%20Create%20a%20LINQ%20Project.md).  
  
## See Also  
 [Multitargeting](../msbuild/msbuild-multitargeting-overview.md)   
 [.NET Framework Multi-Targeting for ASP.NET Web Projects](../Topic/.NET%20Framework%20Multi-Targeting%20for%20ASP.NET%20Web%20Projects.md)   
 [Platform compatibility and system requirements](http://www.microsoft.com/visualstudio/eng/products/compatibility)