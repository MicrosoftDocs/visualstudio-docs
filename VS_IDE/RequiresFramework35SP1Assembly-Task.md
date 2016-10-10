---
title: "RequiresFramework35SP1Assembly Task"
ms.custom: na
ms.date: 10/10/2016
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
ms.assetid: 755c018a-8a8b-4c94-8aee-3f171fc419e5
caps.latest.revision: 6
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
# RequiresFramework35SP1Assembly Task
Determines whether the application requires the .NET Framework 3.5 SP1.  
  
## Parameters  
 The following table describes the parameters of the `RequiresFramework35SP1Assembly` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Assemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Specifies the assemblies that are referenced in the application.|  
|`CreateDesktopShortcut`|Optional `Boolean` parameter.<br /><br /> If `true`, creates a shortcut icon on the desktop during installation.|  
|`DeploymentManifestEntryPoint`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False> parameter.<br /><br /> Specifies the manifest file name for the application.|  
|`EntryPoint`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False> parameter.<br /><br /> Specifies the assembly that should be executed when the application is run.|  
|`ErrorReportUrl`|Optional `String` parameter.<br /><br /> Specifies the Web site that is displayed in dialog boxes that are encountered during ClickOnce installations.|  
|`Files`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Specifies the list of files that will be deployed when the application is published.|  
|`ReferencedAssemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Specifies the assemblies that are referenced in the project.|  
|`RequiresMinimumFramework35SP1`|Optional `Boolean` output parameter.<br /><br /> If `true`, the application requires the .NET Framework 3.5 SP1.|  
|`SigningManifests`|Optional `Boolean` output parameter.<br /><br /> If `true`, the ClickOnce manifests are signed.|  
|`SuiteName`|Optional `String` parameter.<br /><br /> Specifies the name of the folder on the **Start** menu in which the application will be installed.|  
|`TargetFrameworkVersion`|Optional `String` parameter.<br /><br /> Specifies the version of the .NET Framework that this application targets.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../VS_IDE/TaskExtension-Base-Class.md).  
  
## See Also  
 [Tasks](../VS_IDE/MSBuild-Tasks.md)   
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)