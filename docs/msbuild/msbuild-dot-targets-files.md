---
title: MSBuild .targets Files | Microsoft Docs
description: Learn about the MSBuild .targets files that contain items, properties, targets, and tasks for common scenarios.
ms.custom: SEO-VS-2020
ms.date: 02/24/2017
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- .targets files
- MSBuild, .targets files
ms.assetid: f6d98eb4-d2fa-49b7-8e3c-bae1ca3cf596
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# MSBuild .targets files

MSBuild includes several *.targets* files that contain items, properties, targets, and tasks for common scenarios. These files are automatically imported into most Visual Studio project files to simplify maintenance and readability.

 Projects typically import one or more *.targets* files to define their build process. For example a C# project created by Visual Studio will import *Microsoft.CSharp.targets* which imports *Microsoft.Common.targets*. The C# project itself will define the items and properties specific to that project, but the standard build rules for a C# project are defined in the imported *.targets* files.

 The `$(MSBuildToolsPath)` value specifies the path of these common *.targets* files. If the `ToolsVersion` is 4.0, the files are in the following location: *\<WindowsInstallationPath>\Microsoft.NET\Framework\v4.0.30319\\*

> [!NOTE]
> For information about how to create your own targets, see [Targets](../msbuild/msbuild-targets.md). For information about how to use the `Import` element to insert a project file into another project file, see [Import element (MSBuild)](../msbuild/import-element-msbuild.md) and [How to: Use the same target in multiple project files](../msbuild/how-to-use-the-same-target-in-multiple-project-files.md).

## Common .targets files

| *.targets* file | Description |
|---------------------------------| - |
| *Microsoft.Common.targets* | Defines the steps in the standard build process for Visual Basic and C# projects.<br /><br /> Imported by the *Microsoft.CSharp.targets* and *Microsoft.VisualBasic.targets* files, which include the following statement: `<Import Project="Microsoft.Common.targets" />` |
| *Microsoft.CSharp.targets* | Defines the steps in the standard build process for Visual C# projects.<br /><br /> Imported by Visual C# project files (*.csproj*), which include the following statement: `<Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />` |
| *Microsoft.VisualBasic.targets* | Defines the steps in the standard build process for Visual Basic projects.<br /><br /> Imported by Visual Basic project files (*.vbproj*), which include the following statement: `<Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />` |

## Directory.Build.targets

*Directory.Build.targets* is a user-defined file that provides customizations to projects under a directory. This file is automatically imported from *Microsoft.Common.targets* unless the property **ImportDirectoryBuildTargets** is set to **false**. For more information, [Customize your build](customize-your-build.md).

## See also

- [Import element (MSBuild)](../msbuild/import-element-msbuild.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
- [MSBuild](../msbuild/msbuild.md)
