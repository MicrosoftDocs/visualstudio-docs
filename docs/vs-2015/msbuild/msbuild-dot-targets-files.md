---
title: "MSBuild .Targets Files | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - ".Targets files"
  - "MSBuild, .Targets files"
ms.assetid: f6d98eb4-d2fa-49b7-8e3c-bae1ca3cf596
caps.latest.revision: 20
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# MSBuild .Targets Files
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

[!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] includes several .targets files that contain items, properties, targets, and tasks for common scenarios. These files are automatically imported into most [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] project files to simplify maintenance and readability.  
  
 Projects typically import one or more .targets files to define their build process. For example a [!INCLUDE[csprcs](../includes/csprcs-md.md)] project created by [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] will import Microsoft.CSharp.targets which imports Microsoft.Common.targets. The [!INCLUDE[csprcs](../includes/csprcs-md.md)] project itself will define the items and properties specific to that project, but the standard build rules for a [!INCLUDE[csprcs](../includes/csprcs-md.md)] project are defined in the imported .targets files.  
  
 The `$(MSBuildToolsPath)` value specifies the path of these common .targets files. If the `ToolsVersion` is 4.0, the files are in the following location: `WindowsInstallationPath\Microsoft.NET\Framework\v4.0.30319\`  
  
> [!NOTE]
> For information about how to create your own targets, see [Targets](../msbuild/msbuild-targets.md). For information about how to use the `Import` element to insert a project file into another project file, see [Import Element (MSBuild)](../msbuild/import-element-msbuild.md) and [How to: Use the Same Target in Multiple Project Files](../msbuild/how-to-use-the-same-target-in-multiple-project-files.md).  
  
## Common .Targets Files  
  
|.Targets file|Description|  
|-------------------|-----------------|  
|Microsoft.Common.targets|Defines the steps in the standard build process for [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] and [!INCLUDE[csprcs](../includes/csprcs-md.md)] projects.<br /><br /> Imported by the Microsoft.CSharp.targets and Microsoft.VisualBasic.targets files, which include the following statement: `<Import Project="Microsoft.Common.targets" />`|  
|Microsoft.CSharp.targets|Defines the steps in the standard build process for Visual C# projects.<br /><br /> Imported by Visual C# project files (.csproj), which include the following statement: `<Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />`|  
|Microsoft.VisualBasic.targets|Defines the steps in the standard build process for Visual Basic projects.<br /><br /> Imported by Visual Basic project files (.vbproj), which include the following statement: `<Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />`|  
  
## See Also  
 [Import Element (MSBuild)](../msbuild/import-element-msbuild.md)   
 [MSBuild Reference](../msbuild/msbuild-reference.md)  
 [MSBuild](msbuild.md)
