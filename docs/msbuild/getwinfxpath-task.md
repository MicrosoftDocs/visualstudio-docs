---
title: "GetWinFXPath Task"
description: Learn how to use the MSBuild GetWinFXPath task, which returns the directory of the current .NET runtime.
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "getting the directory of the current .NET Framework runtime [WPF MSBuild]"
  - "GetWinFXPath task [WPF MSBuild], parameters"
  - "GetWinFXPath task [WPF MSBuild]"
  - "obtaining the path to the current .NET Framework runtime [WPF MSBuild]"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# GetWinFXPath task

The <xref:Microsoft.Build.Tasks.Windows.GetWinFXPath> task returns the directory of the current .NET runtime.

## Task parameters

| Parameter | Description |
|-------------------| - |
| `WinFXPath` | Optional **String** output parameter.<br /><br /> Specifies the real path to the .NET runtime. |
| `WinFXNativePath` | Required **String** parameter.<br /><br /> Specifies the path to the native .NET runtime. |
| `WinFXWowPath` | Required **String** parameter.<br /><br /> Specifies the path to the .NET assemblies in the 32-bit **Windows on Windows** module on 64-bit systems. |

## Remarks

 If the <xref:Microsoft.Build.Tasks.Windows.GetWinFXPath> task is executing on a 64-bit processor, the **WinFXPath** parameter is set to the path that is stored in the **WinFXWowPath** parameter; otherwise, the **WinFXPath** parameter is set to the path that is stored in the **WinFXNativePath** parameter.

## Example

 The following example shows how to use the **GetWinFXPath** task to detect the native path to the .NET runtime.

```xml
<Project>
  <UsingTask
    TaskName="Microsoft.Build.Tasks.Windows.GetWinFXPath"
    AssemblyFile="C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\PresentationBuildTasks.dll" />
  <Target Name="GetWinFXPathTask">
    <GetWinFXPath
      WinFXNativePath="c:\WinFXNative"
      WinFXWowPath="c:\WinFXWowNative" />
  </Target>
  <Import Project="$(MSBuildBinPath)\Microsoft.WinFX.targets" />
</Project>
```

## See also

- [WPF MSBuild reference](../msbuild/wpf-msbuild-reference.md)
- [Task reference](../msbuild/wpf-msbuild-task-reference.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
- [Build a WPF application (WPF)](/dotnet/framework/wpf/app-development/building-a-wpf-application-wpf)
