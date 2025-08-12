---
title: "UidManager Task"
description: Learn how the MSBuild UidManager task checks, updates, or removes unique identifiers (UIDs), to localize all XAML elements in the source XAML files.
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "UidManager task [WPF MSBuild]"
  - "UidManager task [WPF MSBuild], parameters"
  - "managing UIDs when localizing XAML elements [WPF MSBuild]"
  - "localizing XAML elements [WPF MSBuild], managing UIDs"
  - "checking UIDs when localizing XAML elements [WPF MSBuild]"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# UidManager task

The <xref:Microsoft.Build.Tasks.Windows.UidManager> task checks, updates, or removes unique identifiers (UIDs), in order to localize all XAML elements that are included in the source XAML files.

## Task parameters

| Parameter | Description |
|-------------------------| - |
| `IntermediateDirectory` | Optional **String** parameter.<br /><br /> Specifies the directory that is used to back up the source XAML files that are specified by the **MarkupFiles** parameter. |
| `MarkupFiles` | Required **ITaskItem[]** parameter.<br /><br /> Specifies the source XAML files to include for UID checking, updating, or removing. |
| `Task` | Required **String** parameter.<br /><br /> Specifies the UID management task that you want to perform. Valid options are **Check**, **Update**, or **Remove**. |

## Example

 The following example uses the <xref:Microsoft.Build.Tasks.Windows.UidManager> task to check that the specified source XAML files contain XAML elements that have appropriate UIDs.

```xml
<Project>
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