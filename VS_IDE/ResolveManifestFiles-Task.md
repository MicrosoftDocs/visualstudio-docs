---
title: "ResolveManifestFiles Task"
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
ms.assetid: e1e14f67-9b69-433f-94d4-a783a68676b2
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
# ResolveManifestFiles Task
Resolves the following items in the build process to files for manifest generation: built items, dependencies, satellites, content, debug symbols, and documentation.  
  
## Parameters  
 The following table describes the parameters of the `ResolveManifestFiles` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`DeploymentManifestEntryPoint`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False> parameter.<br /><br /> Specifies the name of the deployment manifest.|  
|`EntryPoint`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False> parameter.<br /><br /> Specifies the managed assembly or ClickOnce manifest reference that is the entry point to the manifest.|  
|`ExtraFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Specifies the extra files.|  
|`ManagedAssemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Specifies the managed assemblies.|  
|`NativeAssemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Specifies the native assemblies.|  
|`OutputAssemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` output parameter.<br /><br /> Specifies the generated assemblies.|  
|`OutputDeploymentManifestEntryPoint`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False> output parameter.<br /><br /> Specifies the output deployment manifest entry point.|  
|`OutputEntryPoint`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False> output parameter.<br /><br /> Specifies the output entry point.|  
|`OutputFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` output parameter.<br /><br /> Specifies the output files.|  
|`PublishFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Specifies the publish files.|  
|`SatelliteAssemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Specifies the satellite assemblies.|  
|`SigningManifests`|Optional `Boolean` parameter.<br /><br /> If `true`, the manifests are signed.|  
|`TargetCulture`|Optional `String` parameter.<br /><br /> Specifies the target culture for satellite assemblies.|  
|`TargetFrameworkVersion`|Optional `String` parameter.<br /><br /> Specifies the target .NET Framework version.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../VS_IDE/TaskExtension-Base-Class.md).  
  
## See Also  
 [Tasks](../VS_IDE/MSBuild-Tasks.md)   
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)