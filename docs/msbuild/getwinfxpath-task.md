---
title: "GetWinFXPath Task | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "getting the directory of the current .NET Framework runtime [WPF MSBuild]"
  - "GetWinFXPath task [WPF MSBuild], parameters"
  - "GetWinFXPath task [WPF MSBuild]"
  - "obtaining the path to the current .NET Framework runtime [WPF MSBuild]"
ms.assetid: b1dfb467-f3d3-47f3-83ef-af7b0e33a772
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# GetWinFXPath task
The <xref:Microsoft.Build.Tasks.Windows.GetWinFXPath> task returns the directory of the current [!INCLUDE[TLA#tla_winfx](../msbuild/includes/tlasharptla_winfx_md.md)] runtime.

## Task parameters

| Parameter | Description |
|-------------------| - |
| `WinFXPath` | Optional **String** output parameter.<br /><br /> Specifies the real path to the [!INCLUDE[TLA2#tla_winfx](../msbuild/includes/tla2sharptla_winfx_md.md)] runtime. |
| `WinFXNativePath` | Required **String** parameter.<br /><br /> Specifies the path to the native [!INCLUDE[TLA2#tla_titlewinfx](../msbuild/includes/tla2sharptla_titlewinfx_md.md)] runtime. |
| `WinFXWowPath` | Required **String** parameter.<br /><br /> Specifies the path to the [!INCLUDE[TLA#tla_winfx](../msbuild/includes/tlasharptla_winfx_md.md)] assemblies in the 32-bit **Windows on Windows** module on 64-bit systems. |

## Remarks
 If the <xref:Microsoft.Build.Tasks.Windows.GetWinFXPath> task is executing on a 64-bit processor, the **WinFXPath** parameter is set to the path that is stored in the **WinFXWowPath** parameter; otherwise, the **WinFXPath** parameter is set to the path that is stored in the **WinFXNativePath** parameter.

## Example
 The following example shows how to use the **GetWinFXPath** task to detect the native path to the [!INCLUDE[TLA2#tla_titlewinfx](../msbuild/includes/tla2sharptla_titlewinfx_md.md)] runtime.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
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
