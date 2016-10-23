---
title: "GetWinFXPath Task"
ms.custom: na
ms.date: 10/07/2016
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
ms.assetid: b1dfb467-f3d3-47f3-83ef-af7b0e33a772
caps.latest.revision: 5
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
# GetWinFXPath Task
The <xref:Microsoft.Build.Tasks.Windows.GetWinFXPath?qualifyHint=False> task returns the directory of the current Microsoft .NET Framework runtime.  
  
## Task Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`WinFXPath`|Optional **String** output parameter.<br /><br /> Specifies the real path to the .NET Framework runtime.|  
|`WinFXNativePath`|Required **String** parameter.<br /><br /> Specifies the path to the native .NET Framework runtime.|  
|`WinFXWowPath`|Required **String** parameter.<br /><br /> Specifies the path to the Microsoft .NET Framework assemblies in the 32-bit **Windows on Windows** module on 64-bit systems.|  
  
## Remarks  
 If the <xref:Microsoft.Build.Tasks.Windows.GetWinFXPath?qualifyHint=False> task is executing on a 64-bit processor, the **WinFXPath** parameter is set to the path that is stored in the **WinFXWowPath** parameter; otherwise, the **WinFXPath** parameter is set to the path that is stored in the **WinFXNativePath** parameter.  
  
## Example  
 The following example shows how to use the **GetWinFXPath** task to detect the native path to the .NET Framework runtime.  
  
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
 [WPF MSBuild Reference](../VS_IDE/WPF-MSBuild-Reference.md)   
 [Task Reference](../VS_IDE/WPF-MSBuild-Task-Reference.md)   
 [MSBuild Reference](../VS_IDE/MSBuild-Reference.md)   
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)   
 [Building a WPF Application (WPF)](../Topic/Building%20a%20WPF%20Application%20\(WPF\).md)