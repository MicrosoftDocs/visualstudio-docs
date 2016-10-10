---
title: "ResolveNativeReference Task"
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
ms.assetid: 56acd101-de77-4eec-92c6-f5c6d2187579
caps.latest.revision: 9
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
# ResolveNativeReference Task
Resolves native references. Implements the <xref:Microsoft.Build.Tasks.ResolveNativeReference?qualifyHint=False> class. This class supports the .NET Framework infrastructure which is not intended to be used directly from your code.  
  
## Task Parameters  
 The following table describes the parameters of the `ResolveNativeReference` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`AdditionalSearchPaths`|Required [String](assetId:///String?qualifyHint=False&autoUpgrade=True)`[]` parameter.<br /><br /> Gets or sets the search paths for resolving assembly identities of native references.|  
|`ContainedComComponents`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` output parameter.<br /><br /> Gets or sets the COM components of the native assembly.|  
|`ContainedLooseEtcFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` output parameter.<br /><br /> Gets or sets the loose Etc files listed in the native manifest.|  
|`ContainedLooseTlbFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` output parameter.<br /><br /> Gets or sets the loose .tlb files of the native assembly.|  
|`ContainedPrerequisiteAssemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` output parameter.<br /><br /> Gets or sets the assemblies that must be present before the manifest can be used.|  
|`ContainedTypeLibraries`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` output parameter.<br /><br /> Gets or sets the type libraries of the native assembly.|  
|`ContainingReferenceFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` output parameter.<br /><br /> Gets or sets the reference files.|  
|`NativeReferences`|Required <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Gets or sets the Win32 native assembly references.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../VS_IDE/TaskExtension-Base-Class.md).  
  
## See Also  
 [Tasks](../VS_IDE/MSBuild-Tasks.md)   
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)