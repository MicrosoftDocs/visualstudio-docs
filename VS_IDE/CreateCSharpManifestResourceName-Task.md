---
title: "CreateCSharpManifestResourceName Task"
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
ms.assetid: 2ace88c1-d757-40a7-8158-c1d3f5ff0511
caps.latest.revision: 8
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
# CreateCSharpManifestResourceName Task
Creates a Visual C#-style manifest name from a given .resx file name or other resource.  
  
## Parameters  
 The following table describes the parameters of the [CreateCSharpManifestResourceName Task](../VS_IDE/CreateCSharpManifestResourceName-Task.md).  
  
|Parameter|Description|  
|---------------|-----------------|  
|`ManifestResourceNames`|<xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False> `[]` output read-only parameter.<br /><br /> The resulting manifest names.|  
|`ResourceFiles`|Required `String` parameter.<br /><br /> The name of the resource file from which to create the Visual C# manifest name.|  
|`RootNamespace`|Optional `String` parameter.<br /><br /> The root namespace of the resource file, typically taken from the project file. May be `null`.|  
|`PrependCultureAsDirectory`|Optional `Boolean` parameter.<br /><br /> If `true`, the culture name is added as a directory name just before the manifest resource name. Default value is `true`.|  
|`ResourceFilesWithManifestResourceNames`|Optional read-only `String` output parameter.<br /><br /> Returns the name of the resource file that now includes the manifest resource name.|  
  
## Remarks  
 The [CreateVisualBasicManifestResourceName Task](../VS_IDE/CreateVisualBasicManifestResourceName-Task.md) determines the appropriate manifest resource name to assign to a given .resx or other resource file. The task provides a logical name to a resource file, and then attaches it to an output parameter as metadata.  
  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../VS_IDE/TaskExtension-Base-Class.md).  
  
## See Also  
 [Tasks](../VS_IDE/MSBuild-Tasks.md)   
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)