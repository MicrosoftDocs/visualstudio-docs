---
title: "WPF MSBuild Task Reference | Microsoft Docs"
description: See a task reference for the Windows Presentation Foundation (WPF) build process, which extends MSBuild with additional tasks.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "WPF MSBuild task reference [WPF MSBuild], term/definition table"
  - "build tasks [WPF MSBuild], Microsoft build engine"
  - "build tasks using the Microsoft build engine [WPF MSBuild], compile markup and process resources"
  - "WPF MSBuild task reference [WPF MSBuild]"
ms.assetid: 96df0370-e50f-4ffc-9771-b12fb8721143
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
  - "multiple"
---
# WPF MSBuild task reference

The Windows Presentation Foundation (WPF) build process extends Microsoft build engine (MSBuild) with an additional set of build tasks, including tasks to compile markup and process resources.

## In this section

- [FileClassifier](../msbuild/fileclassifier-task.md)

 Classifies a set of source resources as those that will be embedded into an assembly. If a resource is not localizable, it is embedded into the main application assembly; otherwise, it is embedded into a satellite assembly.

- [GenerateTemporaryTargetAssembly](../msbuild/generatetemporarytargetassembly-task.md)

 Generates an assembly if at least one XAML page in a project references a type that is declared locally in that project. The generated assembly is removed after the build process is completed, or if the build process fails.

- [GetWinFXPath](../msbuild/getwinfxpath-task.md)

 Returns the directory of the current .NET Framework runtime.

- [MarkupCompilePass1](../msbuild/markupcompilepass1-task.md)

 Converts non-localizable XAML project files to compiled binary format.

- [MarkupCompilePass2](../msbuild/markupcompilepass2-task.md)

 Performs second-pass markup compilation on XAML files that reference types in the same project.

- [MergeLocalizationDirectives](../msbuild/mergelocalizationdirectives-task.md)

 Merges the localization attributes and comments of one or more XAML binary format files into a single file for the whole assembly.

- [ResourcesGenerator](../msbuild/resourcesgenerator-task.md)

 Embeds one or more resources (*.jpg*, *.ico*, *.bmp*, XAML in binary format, and other extension types) into a *.resources* file.

- [UidManager](../msbuild/uidmanager-task.md)

 Checks, updates, or removes unique identifiers (UIDs), in order to localize all XAML elements that are included in the source XAML files.

- [UpdateManifestForBrowserApplication](../msbuild/updatemanifestforbrowserapplication-task.md)

 Adds the **\<hostInBrowser />** element to the application manifest (*\<projectname>.exe.manifest*) when a XAML  Browser Application (XBAP) project is built.

## See also

- [MSBuild](../msbuild/msbuild.md)