---
title: "UidManager Task | Microsoft Docs"
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
  - "UidManager task [WPF MSBuild]"
  - "UidManager task [WPF MSBuild], parameters"
  - "managing UIDs when localizing XAML elements [WPF MSBuild]"
  - "localizing XAML elements [WPF MSBuild], managing UIDs"
  - "checking UIDs when localizing XAML elements [WPF MSBuild]"
ms.assetid: 4fc7b5a5-11b0-46ca-9656-8c2a0b08d1fe
caps.latest.revision: 8
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# UidManager Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The <xref:Microsoft.Build.Tasks.Windows.UidManager> task checks, updates, or removes unique identifiers (UIDs), in order to localize all [!INCLUDE[TLA#tla_xaml](../includes/tlasharptla-xaml-md.md)] elements that are included in the source [!INCLUDE[TLA2#tla_xaml](../includes/tla2sharptla-xaml-md.md)] files.  
  
## Task Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`IntermediateDirectory`|Optional **String** parameter.<br /><br /> Specifies the directory that is used to back up the source [!INCLUDE[TLA2#tla_xaml](../includes/tla2sharptla-xaml-md.md)] files that are specified by the **MarkupFiles** parameter.|  
|`MarkupFiles`|Required **ITaskItem[]** parameter.<br /><br /> Specifies the source [!INCLUDE[TLA2#tla_xaml](../includes/tla2sharptla-xaml-md.md)] files to include for UID checking, updating, or removing.|  
|`Task`|Required **String** parameter.<br /><br /> Specifies the UID management task that you want to perform. Valid options are **Check**, **Update**, or **Remove**.|  
  
## Example  
 The following example uses the <xref:Microsoft.Build.Tasks.Windows.UidManager> task to check that the specified source [!INCLUDE[TLA2#tla_xaml](../includes/tla2sharptla-xaml-md.md)] files contain [!INCLUDE[TLA2#tla_xaml](../includes/tla2sharptla-xaml-md.md)] elements that have appropriate UIDs.  
  
```  
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
  
## See Also  
 [WPF MSBuild Reference](../msbuild/wpf-msbuild-reference.md)   
 [Task Reference](../msbuild/wpf-msbuild-task-reference.md)   
 [MSBuild Reference](../msbuild/msbuild-reference.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)   
 [Building a WPF Application (WPF)](https://msdn.microsoft.com/library/a58696fd-bdad-4b55-9759-136dfdf8b91c)   
 [How to: Localize an Application](https://msdn.microsoft.com/library/5001227e-9326-48a4-9dcd-ba1b89ee6653)
