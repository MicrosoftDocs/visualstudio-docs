---
title: "MergeLocalizationDirectives Task | Microsoft Docs"
description: Learn how MSBuild uses the MergeLocalizationDirectives task to merge the localization attributes and comments of XAML binary format files into a single file.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "localizing XAML [WPF MSBuild], moving comments and attributes to a separate file"
  - "MergeLocalizationDirectives task [WPF MSBuild], parameters"
  - "MergeLocalizationDirectives task [WPF MSBuild]"
  - "moving localization comments and attributes to a separate file [WPF MSBuild]"
ms.assetid: 9095b4f1-88da-4194-914b-ee1456826830
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
  - "multiple"
---
# MergeLocalizationDirectives task

The <xref:Microsoft.Build.Tasks.Windows.MergeLocalizationDirectives> task merges the localization attributes and comments of one or more XAML binary format files into a single file for the whole assembly.

## Task parameters

| Parameter | Description |
|------------------------------| - |
| `GeneratedLocalizationFiles` | Required **ITaskItem[]** parameter.<br /><br /> Specifies the list of localization directives files for individual files in XAML binary format. |
| `OutputFile` | Required **String** output parameter.<br /><br /> Specifies the output path of the compiled localization-directives assembly. |

## Remarks

You can add localization attributes and comments to XAML content. With Windows Presentation Foundation (WPF) localization support, you can strip out localization attributes and comments, and put them in a *.loc* file that is separate from the generated assembly. You can do this by using the **LocalizationPropertyStorage** attribute. For more information about localization attributes and comments, and **LocalizationPropertyStorage**, see [Localization attributes and comments](/dotnet/framework/wpf/advanced/localization-attributes-and-comments).

## Example

The following example merges the localization comments of several XAML binary format files into a single *.loc* file.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <UsingTask
    TaskName="Microsoft.Build.Tasks.Windows.MergeLocalizationDirectives"
    AssemblyFile="C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\PresentationBuildTasks.dll" />
  <Target Name="MergeLocalizationDirectivesTask">
    <MergeLocalizationDirectives
      GeneratedLocalizationFiles="obj\debug\page1.loc;obj\debug\page2.loc;obj\debug\page3.loc"
      OutputFile="obj\debug\WPFMSBuildSample.loc" />
  </Target>
</Project>
```

## See also

- [WPF MSBuild reference](../msbuild/wpf-msbuild-reference.md)
- [WPF MSBuild task reference](../msbuild/wpf-msbuild-task-reference.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
- [MSBuild task reference](../msbuild/msbuild-task-reference.md)
- [Build a WPF application (WPF)](/dotnet/framework/wpf/app-development/building-a-wpf-application-wpf)
