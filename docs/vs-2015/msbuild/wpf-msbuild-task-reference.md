---
title: "WPF MSBuild Task Reference | Microsoft Docs"
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
  - "WPF MSBuild task reference [WPF MSBuild], term/definition table"
  - "build tasks [WPF MSBuild], Microsoft build engine"
  - "build tasks using the Microsoft build engine [WPF MSBuild], compile markup and process resources"
  - "WPF MSBuild task reference [WPF MSBuild]"
ms.assetid: 96df0370-e50f-4ffc-9771-b12fb8721143
caps.latest.revision: 7
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# WPF MSBuild Task Reference
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Windows Presentation Foundation (WPF) build process extends Microsoft build engine (MSBuild) with an additional set of build tasks, including tasks to compile markup and process resources.  
  
## In This Section  
 [FileClassifier](../msbuild/fileclassifier-task.md)  
 Classifies a set of source resources as those that will be embedded into an assembly. If a resource is not localizable, it is embedded into the main application assembly; otherwise, it is embedded into a satellite assembly.  
  
 [GenerateTemporaryTargetAssembly](../msbuild/generatetemporarytargetassembly-task.md)  
 Generates an assembly if at least one [!INCLUDE[TLA#tla_xaml](../includes/tlasharptla-xaml-md.md)] page in a project references a type that is declared locally in that project. The generated assembly is removed after the build process is completed, or if the build process fails.  
  
 [GetWinFXPath](../msbuild/getwinfxpath-task.md)  
 Returns the directory of the current [!INCLUDE[TLA#tla_winfx](../includes/tlasharptla-winfx-md.md)] runtime.  
  
 [MarkupCompilePass1](../msbuild/markupcompilepass1-task.md)  
 Converts non-localizable [!INCLUDE[TLA#tla_xaml](../includes/tlasharptla-xaml-md.md)] project files to compiled binary format.  
  
 [MarkupCompilePass2](../msbuild/markupcompilepass2-task.md)  
 Performs second-pass markup compilation on [!INCLUDE[TLA#tla_xaml](../includes/tlasharptla-xaml-md.md)] files that reference types in the same project.  
  
 [MergeLocalizationDirectives](../msbuild/mergelocalizationdirectives-task.md)  
 Merges the localization attributes and comments of one or more [!INCLUDE[TLA2#tla_xaml](../includes/tla2sharptla-xaml-md.md)] binary format files into a single file for the whole assembly.  
  
 [ResourcesGenerator](../msbuild/resourcesgenerator-task.md)  
 Embeds one or more resources (.jpg, .ico, .bmp, [!INCLUDE[TLA2#tla_xaml](../includes/tla2sharptla-xaml-md.md)] in binary format, and other extension types) into a .resources file.  
  
 [UidManager](../msbuild/uidmanager-task.md)  
 Checks, updates, or removes unique identifiers (UIDs), in order to localize all [!INCLUDE[TLA#tla_xaml](../includes/tlasharptla-xaml-md.md)] elements that are included in the source [!INCLUDE[TLA2#tla_xaml](../includes/tla2sharptla-xaml-md.md)] files.  
  
 [UpdateManifestForBrowserApplication](../msbuild/updatemanifestforbrowserapplication-task.md)  
 Adds the **\<hostInBrowser />** element to the application manifest (*projectname*.exe.manifest) when a [!INCLUDE[TLA#tla_xbap](../includes/tlasharptla-xbap-md.md)] project is built.  
  
## See Also  
 [MSBuild](https://msdn.microsoft.com/7c49aba1-ee6c-47d8-9de1-6f29a906e20b)
