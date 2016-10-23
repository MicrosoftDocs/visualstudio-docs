---
title: "WPF MSBuild Task Reference"
ms.custom: na
ms.date: 10/04/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - jsharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 96df0370-e50f-4ffc-9771-b12fb8721143
caps.latest.revision: 4
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# WPF MSBuild Task Reference
The Windows Presentation Foundation (WPF) build process extends Microsoft build engine (MSBuild) with an additional set of build tasks, including tasks to compile markup and process resources.  
  
## In This Section  
 [FileClassifier](../VS_IDE/FileClassifier-Task.md)  
 Classifies a set of source resources as those that will be embedded into an assembly. If a resource is not localizable, it is embedded into the main application assembly; otherwise, it is embedded into a satellite assembly.  
  
 [GenerateTemporaryTargetAssembly](../VS_IDE/GenerateTemporaryTargetAssembly-Task.md)  
 Generates an assembly if at least one Extensible Application Markup Language (XAML) page in a project references a type that is declared locally in that project. The generated assembly is removed after the build process is completed, or if the build process fails.  
  
 [GetWinFXPath](../VS_IDE/GetWinFXPath-Task.md)  
 Returns the directory of the current Microsoft .NET Framework runtime.  
  
 [MarkupCompilePass1](../VS_IDE/MarkupCompilePass1-Task.md)  
 Converts non-localizable Extensible Application Markup Language (XAML) project files to compiled binary format.  
  
 [MarkupCompilePass2](../VS_IDE/MarkupCompilePass2-Task.md)  
 Performs second-pass markup compilation on Extensible Application Markup Language (XAML) files that reference types in the same project.  
  
 [MergeLocalizationDirectives](../VS_IDE/MergeLocalizationDirectives-Task.md)  
 Merges the localization attributes and comments of one or more XAML binary format files into a single file for the whole assembly.  
  
 [ResourcesGenerator](../VS_IDE/ResourcesGenerator-Task.md)  
 Embeds one or more resources (.jpg, .ico, .bmp, XAML in binary format, and other extension types) into a .resources file.  
  
 [UidManager](../VS_IDE/UidManager-Task.md)  
 Checks, updates, or removes unique identifiers (UIDs), in order to localize all Extensible Application Markup Language (XAML) elements that are included in the source XAML files.  
  
 [UpdateManifestForBrowserApplication](../VS_IDE/UpdateManifestForBrowserApplication-Task.md)  
 Adds the **<hostInBrowser /\>** element to the application manifest (*projectname*.exe.manifest) when a XAML browser application (XBAP) project is built.  
  
## See Also  
 [MSBuild](assetId:///7c49aba1-ee6c-47d8-9de1-6f29a906e20b)