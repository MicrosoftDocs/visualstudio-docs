---
title: "ResolveManifestFiles Task | Microsoft Docs"
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
  - "ResolveManifestFiles task [MSBuild]"
  - "MSBuild, ResolveManifestFiles task"
ms.assetid: e1e14f67-9b69-433f-94d4-a783a68676b2
caps.latest.revision: 8
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# ResolveManifestFiles Task
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Resolves the following items in the build process to files for manifest generation: built items, dependencies, satellites, content, debug symbols, and documentation.  
  
## Parameters  
 The following table describes the parameters of the `ResolveManifestFiles` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`DeploymentManifestEntryPoint`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the name of the deployment manifest.|  
|`EntryPoint`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the managed assembly or ClickOnce manifest reference that is the entry point to the manifest.|  
|`ExtraFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the extra files.|  
|`ManagedAssemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the managed assemblies.|  
|`NativeAssemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the native assemblies.|  
|`OutputAssemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Specifies the generated assemblies.|  
|`OutputDeploymentManifestEntryPoint`|Optional <xref:Microsoft.Build.Framework.ITaskItem> output parameter.<br /><br /> Specifies the output deployment manifest entry point.|  
|`OutputEntryPoint`|Optional <xref:Microsoft.Build.Framework.ITaskItem> output parameter.<br /><br /> Specifies the output entry point.|  
|`OutputFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Specifies the output files.|  
|`PublishFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the publish files.|  
|`SatelliteAssemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies the satellite assemblies.|  
|`SigningManifests`|Optional `Boolean` parameter.<br /><br /> If `true`, the manifests are signed.|  
|`TargetCulture`|Optional `String` parameter.<br /><br /> Specifies the target culture for satellite assemblies.|  
|`TargetFrameworkVersion`|Optional `String` parameter.<br /><br /> Specifies the target .NET Framework version.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../msbuild/taskextension-base-class.md).  
  
## See also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Task Reference](../msbuild/msbuild-task-reference.md)
