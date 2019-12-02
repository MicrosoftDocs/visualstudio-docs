---
title: "MSBuild .targets Files | Microsoft Docs"
ms.date: "02/24/2017"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - ".targets files"
  - "MSBuild, .targets files"
ms.assetid: f6d98eb4-d2fa-49b7-8e3c-bae1ca3cf596
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# MSBuild .targets files
[!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] includes several *.targets* files that contain items, properties, targets, and tasks for common scenarios. These files are automatically imported into most [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] project files to simplify maintenance and readability.

 Projects typically import one or more *.targets* files to define their build process. For example a [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] project created by [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] will import *Microsoft.CSharp.targets* which imports *Microsoft.Common.targets*. The [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] project itself will define the items and properties specific to that project, but the standard build rules for a [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] project are defined in the imported *.targets* files.

 The `$(MSBuildToolsPath)` value specifies the path of these common *.targets* files. If the `ToolsVersion` is 4.0, the files are in the following location: *\<WindowsInstallationPath>\Microsoft.NET\Framework\v4.0.30319\\*

> [!NOTE]
> For information about how to create your own targets, see [Targets](../msbuild/msbuild-targets.md). For information about how to use the `Import` element to insert a project file into another project file, see [Import element (MSBuild)](../msbuild/import-element-msbuild.md) and [How to: Use the same target in multiple project files](../msbuild/how-to-use-the-same-target-in-multiple-project-files.md).

## Common .targets files

| *.targets* file | Description |
|---------------------------------| - |
| *Microsoft.Common.targets* | Defines the steps in the standard build process for [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] and [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] projects.<br /><br /> Imported by the *Microsoft.CSharp.targets* and *Microsoft.VisualBasic.targets* files, which include the following statement: `<Import Project="Microsoft.Common.targets" />` |
| *Microsoft.CSharp.targets* | Defines the steps in the standard build process for Visual C# projects.<br /><br /> Imported by Visual C# project files (*.csproj*), which include the following statement: `<Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />` |
| *Microsoft.VisualBasic.targets* | Defines the steps in the standard build process for Visual Basic projects.<br /><br /> Imported by Visual Basic project files (*.vbproj*), which include the following statement: `<Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />` |

## Directory.Build.targets
*Directory.Build.targets* is a user-defined file that provides customizations to projects under a directory. This file is automatically imported from *Microsoft.Common.targets* unless the property **ImportDirectoryBuildTargets** is set to **false**. For more information, [Customize your build](customize-your-build.md).

## See also
- [Import element (MSBuild)](../msbuild/import-element-msbuild.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
- [MSBuild](../msbuild/msbuild.md)
