---
title: "UidManager Task | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "UidManager task [WPF MSBuild]"
  - "UidManager task [WPF MSBuild], parameters"
  - "managing UIDs when localizing XAML elements [WPF MSBuild]"
  - "localizing XAML elements [WPF MSBuild], managing UIDs"
  - "checking UIDs when localizing XAML elements [WPF MSBuild]"
ms.assetid: 4fc7b5a5-11b0-46ca-9656-8c2a0b08d1fe
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# UidManager task
The <xref:Microsoft.Build.Tasks.Windows.UidManager> task checks, updates, or removes unique identifiers (UIDs), in order to localize all [!INCLUDE[TLA#tla_xaml](../msbuild/includes/tlasharptla_xaml_md.md)] elements that are included in the source [!INCLUDE[TLA2#tla_xaml](../msbuild/includes/tla2sharptla_xaml_md.md)] files.

## Task parameters

| Parameter | Description |
|-------------------------| - |
| `IntermediateDirectory` | Optional **String** parameter.<br /><br /> Specifies the directory that is used to back up the source [!INCLUDE[TLA2#tla_xaml](../msbuild/includes/tla2sharptla_xaml_md.md)] files that are specified by the **MarkupFiles** parameter. |
| `MarkupFiles` | Required **ITaskItem[]** parameter.<br /><br /> Specifies the source [!INCLUDE[TLA2#tla_xaml](../msbuild/includes/tla2sharptla_xaml_md.md)] files to include for UID checking, updating, or removing. |
| `Task` | Required **String** parameter.<br /><br /> Specifies the UID management task that you want to perform. Valid options are **Check**, **Update**, or **Remove**. |

## Example
 The following example uses the <xref:Microsoft.Build.Tasks.Windows.UidManager> task to check that the specified source [!INCLUDE[TLA2#tla_xaml](../msbuild/includes/tla2sharptla_xaml_md.md)] files contain [!INCLUDE[TLA2#tla_xaml](../msbuild/includes/tla2sharptla_xaml_md.md)] elements that have appropriate UIDs.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <UsingTask
    TaskName="Microsoft.Build.Tasks.Windows.UidManager"
    AssemblyFile="C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\PresentationBuildTasks.dll" />
  <Target Name="UidManagerTask">
    <UidManager
      Task="Check"
      MarkupFiles="Page1.xaml;Page2.xaml"
      IntermediateDirectory="c:\UidManagerIntermediateDirectory" />
  </Target>
</Project>
```

## See also
- [WPF MSBuild reference](../msbuild/wpf-msbuild-reference.md)
- [Task reference](../msbuild/wpf-msbuild-task-reference.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
- [Build a WPF application (WPF)](/dotnet/framework/wpf/app-development/building-a-wpf-application-wpf)
- [How to: Localize an application](/dotnet/framework/wpf/advanced/how-to-localize-an-application)