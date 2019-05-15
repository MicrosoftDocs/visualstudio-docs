---
title: "MergeLocalizationDirectives Task | Microsoft Docs"
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
  - "localizing XAML [WPF MSBuild], moving comments and attributes to a separate file"
  - "MergeLocalizationDirectives task [WPF MSBuild], parameters"
  - "MergeLocalizationDirectives task [WPF MSBuild]"
  - "moving localization comments and attributes to a separate file [WPF MSBuild]"
ms.assetid: 9095b4f1-88da-4194-914b-ee1456826830
caps.latest.revision: 8
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# MergeLocalizationDirectives Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The <xref:Microsoft.Build.Tasks.Windows.MergeLocalizationDirectives> task merges the localization attributes and comments of one or more [!INCLUDE[TLA2#tla_xaml](../includes/tla2sharptla-xaml-md.md)] binary format files into a single file for the whole assembly.  
  
## Task Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`GeneratedLocalizationFiles`|Required **ITaskItem[]** parameter.<br /><br /> Specifies the list of localization directives files for individual files in [!INCLUDE[TLA2#tla_xaml](../includes/tla2sharptla-xaml-md.md)] binary format.|  
|`OutputFile`|Required **String** output parameter.<br /><br /> Specifies the output path of the compiled localization-directives assembly.|  
  
## Remarks  
 You can add localization attributes and comments to [!INCLUDE[TLA#tla_xaml](../includes/tlasharptla-xaml-md.md)] content. With [!INCLUDE[TLA#tla_wpf](../includes/tlasharptla-wpf-md.md)] localization support, you can strip out localization attributes and comments, and put them in a .loc file that is separate from the generated assembly. You can do this by using the **LocalizationPropertyStorage** attribute. For more information about localization attributes and comments, and **LocalizationPropertyStorage**, see [Localization Attributes and Comments](https://msdn.microsoft.com/library/ead2d9ac-b709-4ec1-a924-39927a29d02f).  
  
## Example  
 The following example merges the localization comments of several [!INCLUDE[TLA2#tla_xaml](../includes/tla2sharptla-xaml-md.md)] binary format files into a single .loc file.  
  
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
 [WPF MSBuild Reference](../msbuild/wpf-msbuild-reference.md)   
 [Task Reference](../msbuild/wpf-msbuild-task-reference.md)   
 [MSBuild Reference](../msbuild/msbuild-reference.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)   
 [Building a WPF Application (WPF)](https://msdn.microsoft.com/library/a58696fd-bdad-4b55-9759-136dfdf8b91c)
