---
title: MSBuild .targets Files
description: Learn about the MSBuild .targets files that contain items, properties, targets, and tasks for common scenarios.
ms.date: 04/17/2024
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- .targets files
- MSBuild, .targets files
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# MSBuild `.targets` files

MSBuild includes several `.targets` files that contain items, properties, targets, and tasks for common scenarios. These files are automatically imported into most Visual Studio project files to simplify maintenance and readability.

SDK-style projects (projects with something like `<Project Sdk="Microsoft.NET.Sdk">`) import `.targets` files differently compared to projects that don't reference an SDK. For SDK-style projects, you don't see the imported `.targets` file in the project file, because those imports are managed by the SDK that you reference. However, SDK-style projects are equivalent to non-SDK-style projects with standard imports before and after the main body of the file, so it's still accurate to say that the standard `.targets` files are imported in those projects. 

.NET SDK targets are installed with the .NET SDK, for example, at `C:\Program Files\dotnet\sdk\{version}\Sdks\Microsoft.NET.Sdk\targets\` for `Microsoft.NET.Sdk` on Windows. For a complete list of SDKs and what `.targets` file they import, see [.NET project SDKs](/dotnet/core/project-sdk/overview).

Projects that don't specify an SDK usually explicitly import one or more `.targets` files to define their build process. For example, C# projects created by earlier versions of Visual Studio import *Microsoft.CSharp.targets*, which imports *Microsoft.Common.targets*. The C# project itself defines the items and properties specific to that project, but the standard build rules for a C# project are defined in the imported `.targets` files.

The `$(MSBuildToolsPath)` value specifies the path of these common `.targets` files. For .NET projects, the path is typically `{Visual Studio installation folder}\MSBuild\Current\Bin\{architecture}`.

> [!NOTE]
> For information about how to create your own targets, see [Targets](../msbuild/msbuild-targets.md). For information about how to use the `Import` element to insert a project file into another project file, see [Import element (MSBuild)](../msbuild/import-element-msbuild.md) and [How to: Use the same target in multiple project files](../msbuild/how-to-use-the-same-target-in-multiple-project-files.md).

## Common `.targets` files

| *.targets* file | Description |
|---------------------------------| - |
| *Microsoft.Common.targets* | Defines the steps in the standard build process for Visual Basic and C# projects.<br /><br /> Imported by the *Microsoft.CSharp.targets* and *Microsoft.VisualBasic.targets* files, which include the following statement: `<Import Project="Microsoft.Common.targets" />` |
| *Microsoft.CSharp.targets* | Defines the steps in the standard build process for Visual C# projects.<br /><br /> Imported by Visual C# project files (`.csproj`). |
| *Microsoft.VisualBasic.targets* | Defines the steps in the standard build process for Visual Basic projects.<br /><br /> Imported by Visual Basic project files (`.vbproj`). |

If you open and view files, you see they're rather thin wrappers around other `.targets` files, usually `Microsoft.{language}.CurrentVersion.targets`, or for cross-targeting scenarios, `Microsoft.{language}.CrossTargeting.targets`.

## Directory.Build.targets

*Directory.Build.targets* is a user-defined file that provides customizations to projects under a directory. This file is automatically imported from *Microsoft.Common.targets* unless the property **ImportDirectoryBuildTargets** is set to **false**. For more information, [Customize your build](customize-your-build.md).

## See also

- [Import element (MSBuild)](../msbuild/import-element-msbuild.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
- [MSBuild](../msbuild/msbuild.md)
