---
title: "CallTarget Task | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "CallTarget task [MSBuild]"
  - "MSBuild, CallTarget task"
ms.assetid: bb1fe2c4-4383-436f-8326-c24cc4a46150
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# CallTarget task
Invokes the specified targets within the project file.

## Task parameters
 The following table describes the parameters of the `CallTarget` task.

| Parameter | Description |
|---------------------------| - |
| `RunEachTargetSeparately` | Optional `Boolean` input parameter.<br /><br /> If `true`, the [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] engine is called once per target. If `false`, the [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] engine is called once to build all targets. The default value is `false`. |
| `TargetOutputs` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the outputs of all built targets. |
| `Targets` | Optional `String[]` parameter.<br /><br /> Specifies the target or targets to build. |
| `UseResultsCache` | Optional `Boolean` parameter.<br /><br /> If `true`, the cached result is returned if present.<br /><br /> **Note** When an MSBuild task is run, its output is cached in a scope (ProjectFileName, GlobalProperties)[TargetNames] as a list of build items. |

## Remarks
 If a target specified in `Targets` fails and `RunEachTargetSeparately` is `true`, the task continues to build the remaining targets.

 If you want to build the default targets, use the [MSBuild task](../msbuild/msbuild-task.md) and set the `Projects` parameter equal to `$(MSBuildProjectFile)`.

 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example
 The following example calls `TargetA` from inside `CallOtherTargets`.

```xml
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

## See also
- [Task reference](../msbuild/msbuild-task-reference.md)
- [Targets](../msbuild/msbuild-targets.md)