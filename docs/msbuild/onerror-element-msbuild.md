---
title: "OnError Element (MSBuild) | Microsoft Docs"
ms.date: "03/13/2017"
ms.topic: "reference"
f1_keywords:
  - "http://schemas.microsoft.com/developer/msbuild/2003#OnError"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "OnError Element [MSBuild]"
  - "<OnError Element [MSBuild]"
ms.assetid: 765767d3-ecb7-4cd9-ba1e-d9468964dddc
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# OnError element (MSBuild)
Causes one or more targets to execute, if the `ContinueOnError` attribute is `false` for a failed task.

 \<Project>
 \<Target>
 \<OnError>

## Syntax

```xml
<OnError ExecuteTargets="TargetName"
    Condition="'String A'=='String B'" />
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`Condition`|Optional attribute.<br /><br /> Condition to be evaluated. For more information, see [Conditions](../msbuild/msbuild-conditions.md).|
|`ExecuteTargets`|Required attribute.<br /><br /> The targets to execute if a task fails. Separate multiple targets with semicolons. Multiple targets are executed in the order specified.|

### Child elements
 None.

### Parent elements

| Element | Description |
| - | - |
| [Target](../msbuild/target-element-msbuild.md) | Container element for [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] tasks. |

## Remarks
 [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] executes the `OnError` element if one of the `Target` element's tasks fails with the `ContinueOnError` attribute set to `ErrorAndStop` (or `false`). When the task fails, the targets specified in the `ExecuteTargets` attribute is executed. If there is more than one `OnError` element in the target, the `OnError` elements are executed sequentially when the task fails.

 For information about the `ContinueOnError` attribute, see [Task element (MSBuild)](../msbuild/task-element-msbuild.md). For information about targets, see [Targets](../msbuild/msbuild-targets.md).

## Example
 The following code executes the `TaskOne` and `TaskTwo` tasks. If `TaskOne` fails, [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] evaluates the `OnError` element and executes the `OtherTarget` target.

```xml
<Target Name="ThisTarget">
    <TaskOne ContinueOnError="ErrorAndStop">
    </TaskOne>
    <TaskTwo>
    </TaskTwo>
    <OnError ExecuteTargets="OtherTarget" />
</Target>
```

## See also
- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
- [Targets](../msbuild/msbuild-targets.md)
