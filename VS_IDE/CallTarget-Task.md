---
title: "CallTarget Task"
ms.custom: na
ms.date: 10/04/2016
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
ms.assetid: bb1fe2c4-4383-436f-8326-c24cc4a46150
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
# CallTarget Task
Invokes the specified targets within the project file.  
  
## Task Parameters  
 The following table describes the parameters of the `CallTarget` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`RunEachTargetSeparately`|Optional `Boolean` output parameter.<br /><br /> If `true`, the MSBuild engine is called once per target. If `false`, the MSBuild engine is called once to build all targets. The default value is `false`.|  
|`TargetOutputs`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` output parameter.<br /><br /> Contains the outputs of all built targets.|  
|`Targets`|Optional `String[]` parameter.<br /><br /> Specifies the target or targets to build.|  
|`UseResultsCache`|Optional `Boolean` parameter.<br /><br /> If `true`, the cached result is returned if present.<br /><br /> **Note** When an MSBuild task is run, its output is cached in a scope (ProjectFileName, GlobalProperties)[TargetNames] as a list of build items.|  
  
## Remarks  
 If a target specified in `Targets` fails and `RunEachTargetSeparately` is `true`, the task continues to build the remaining targets.  
  
 If you want to build the default targets, use the [MSBuild Task](../VS_IDE/MSBuild-Task.md) and set the `Projects` parameter equal to `$(MSBuildProjectFile)`.  
  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../VS_IDE/TaskExtension-Base-Class.md).  
  
## Example  
 The following example calls `TargetA` from inside `CallOtherTargets`.  
  
```  
<Project DefaultTargets="CallOtherTargets"  
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
    <Target Name="CallOtherTargets">  
        <CallTarget Targets="TargetA"/>  
    </Target>  
  
    <Target Name="TargetA">  
        <Message Text="Building TargetA..." />  
    </Target>  
  
</Project>  
```  
  
## See Also  
 [Task Reference](../VS_IDE/MSBuild-Task-Reference.md)   
 [Targets](../VS_IDE/MSBuild-Targets.md)