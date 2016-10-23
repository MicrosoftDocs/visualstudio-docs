---
title: "MergeLocalizationDirectives Task"
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
ms.assetid: 9095b4f1-88da-4194-914b-ee1456826830
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
# MergeLocalizationDirectives Task
The <xref:Microsoft.Build.Tasks.Windows.MergeLocalizationDirectives?qualifyHint=False> task merges the localization attributes and comments of one or more XAML binary format files into a single file for the whole assembly.  
  
## Task Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`GeneratedLocalizationFiles`|Required **ITaskItem[]** parameter.<br /><br /> Specifies the list of localization directives files for individual files in XAML binary format.|  
|`OutputFile`|Required **String** output parameter.<br /><br /> Specifies the output path of the compiled localization-directives assembly.|  
  
## Remarks  
 You can add localization attributes and comments to Extensible Application Markup Language (XAML) content. With Windows Presentation Foundation (WPF) localization support, you can strip out localization attributes and comments, and put them in a .loc file that is separate from the generated assembly. You can do this by using the **LocalizationPropertyStorage** attribute. For more information about localization attributes and comments, and **LocalizationPropertyStorage**, see [Localization Attributes and Comments](../Topic/Localization%20Attributes%20and%20Comments.md).  
  
## Example  
 The following example merges the localization comments of several XAML binary format files into a single .loc file.  
  
```  
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
  
## See Also  
 [WPF MSBuild Reference](../VS_IDE/WPF-MSBuild-Reference.md)   
 [Task Reference](../VS_IDE/WPF-MSBuild-Task-Reference.md)   
 [MSBuild Reference](../VS_IDE/MSBuild-Reference.md)   
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)   
 [Building a WPF Application (WPF)](../Topic/Building%20a%20WPF%20Application%20\(WPF\).md)