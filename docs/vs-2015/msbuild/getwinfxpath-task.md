---
title: "GetWinFXPath Task | Microsoft Docs"
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
  - "getting the directory of the current .NET Framework runtime [WPF MSBuild]"
  - "GetWinFXPath task [WPF MSBuild], parameters"
  - "GetWinFXPath task [WPF MSBuild]"
  - "obtaining the path to the current .NET Framework runtime [WPF MSBuild]"
ms.assetid: b1dfb467-f3d3-47f3-83ef-af7b0e33a772
caps.latest.revision: 8
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# GetWinFXPath Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The <xref:Microsoft.Build.Tasks.Windows.GetWinFXPath> task returns the directory of the current [!INCLUDE[TLA#tla_winfx](../includes/tlasharptla-winfx-md.md)] runtime.  
  
## Task Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`WinFXPath`|Optional **String** output parameter.<br /><br /> Specifies the real path to the [!INCLUDE[TLA2#tla_winfx](../includes/tla2sharptla-winfx-md.md)] runtime.|  
|`WinFXNativePath`|Required **String** parameter.<br /><br /> Specifies the path to the native [!INCLUDE[TLA2#tla_titlewinfx](../includes/tla2sharptla-titlewinfx-md.md)] runtime.|  
|`WinFXWowPath`|Required **String** parameter.<br /><br /> Specifies the path to the [!INCLUDE[TLA#tla_winfx](../includes/tlasharptla-winfx-md.md)] assemblies in the 32-bit **Windows on Windows** module on 64-bit systems.|  
  
## Remarks  
 If the <xref:Microsoft.Build.Tasks.Windows.GetWinFXPath> task is executing on a 64-bit processor, the **WinFXPath** parameter is set to the path that is stored in the **WinFXWowPath** parameter; otherwise, the **WinFXPath** parameter is set to the path that is stored in the **WinFXNativePath** parameter.  
  
## Example  
 The following example shows how to use the **GetWinFXPath** task to detect the native path to the [!INCLUDE[TLA2#tla_titlewinfx](../includes/tla2sharptla-titlewinfx-md.md)] runtime.  
  
```  
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
  
## See Also  
 [WPF MSBuild Reference](../msbuild/wpf-msbuild-reference.md)   
 [Task Reference](../msbuild/wpf-msbuild-task-reference.md)   
 [MSBuild Reference](../msbuild/msbuild-reference.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)   
 [Building a WPF Application (WPF)](https://msdn.microsoft.com/library/a58696fd-bdad-4b55-9759-136dfdf8b91c)
