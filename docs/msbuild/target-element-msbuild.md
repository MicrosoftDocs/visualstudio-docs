---
title: Target Element (MSBuild)
description: Learn about the MSBuild Target element, which contains a set of tasks for MSBuild to execute sequentially. 
ms.date: 06/13/2019
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#Target
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- Target element [MSBuild]
- <Target> element [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Target element (MSBuild)

Contains a set of tasks for MSBuild to execute sequentially.

 \<Project>
 \<Target>

## Syntax

```xml
<Target Name="Target Name"
        Inputs="Inputs"
        Outputs="Outputs"
        Returns="Returns"
        KeepDuplicateOutputs="true/false"
        BeforeTargets="Targets"
        AfterTargets="Targets"
        DependsOnTargets="DependentTarget"
        Condition="'String A' == 'String B'"
        Label="Label">
    <Task>... </Task>
    <PropertyGroup>... </PropertyGroup>
    <ItemGroup>... </ItemGroup>
    <OnError... />
</Target>
```

## Attributes and elements

 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`Name`|Required attribute.<br /><br /> The name of the target. A target name may contain any character except `$@()%*?.`.|
|`Condition`|Optional attribute.<br /><br /> The condition to be evaluated. If the condition evaluates to `false`, the target will not execute the body of the target or any targets that are set in the `DependsOnTargets` attribute. For more information about conditions, see [Conditions](../msbuild/msbuild-conditions.md).|
|`Inputs`|Optional attribute.<br /><br /> The files that form inputs into this target. Multiple files are separated by semicolons. The timestamps of the files will be compared with the timestamps of files in `Outputs` to determine whether the `Target` is up to date. For more information, see [Incremental builds](../msbuild/incremental-builds.md), [How to: Build incrementally](../msbuild/how-to-build-incrementally.md), and [Transforms](../msbuild/msbuild-transforms.md).|
|`Outputs`|Optional attribute.<br /><br /> The files that form outputs into this target. Multiple files are separated by semicolons. The timestamps of the files will be compared with the timestamps of files in `Inputs` to determine whether the `Target` is up to date. For more information, see [Incremental builds](../msbuild/incremental-builds.md), [How to: Build incrementally](../msbuild/how-to-build-incrementally.md), and [Transforms](../msbuild/msbuild-transforms.md).|
|`Returns`|Optional attribute.<br /><br /> The set of items that will be made available to tasks that invoke this target, for example, MSBuild tasks. Multiple targets are separated by semicolons. If the targets in the file have no `Returns` attributes, the Outputs attributes are used instead for this purpose.|
|`KeepDuplicateOutputs`|Optional Boolean attribute.<br /><br /> If `true`, multiple references to the same item in the target's Returns are recorded.  By default, this attribute is `false`.|
|`BeforeTargets`|Optional attribute.<br /><br /> A semicolon-separated list of target names.  When specified, indicates that this target should run before the specified target or targets. This lets the project author extend an existing set of targets without modifying them directly. For more information, see [Target build order](../msbuild/target-build-order.md).|
|`AfterTargets`|Optional attribute.<br /><br /> A semicolon-separated list of target names. When specified, indicates that this target should run after the specified target or targets. This lets the project author extend an existing set of targets without modifying them directly. For more information, see [Target build order](../msbuild/target-build-order.md).|
|`DependsOnTargets`|Optional attribute.<br /><br /> The targets that must be executed before this target can be executed or top-level dependency analysis can occur. Multiple targets are separated by semicolons.|
|`Label`|Optional attribute.<br /><br /> An identifier that can identify or order system and user elements.|

### Child elements

| Element | Description |
| - | - |
| [Task](../msbuild/task-element-msbuild.md) | Creates and executes an instance of an MSBuild task. There may be zero or more tasks in a target. |
| [PropertyGroup](../msbuild/propertygroup-element-msbuild.md) | Contains a set of user-defined `Property` elements. A `Target` element may contain `PropertyGroup` elements. |
| [ItemGroup](../msbuild/itemgroup-element-msbuild.md) | Contains a set of user-defined `Item` elements. A `Target` element may contain `ItemGroup` elements. For more information, see [Items](../msbuild/msbuild-items.md). |
| [OnError](../msbuild/onerror-element-msbuild.md) | Causes one or more targets to execute if the `ContinueOnError` attribute is ErrorAndStop (or `false`) for a failed task. There may be zero or more `OnError` elements in a target. If `OnError` elements are present, they must be the last elements in the `Target` element.<br /><br /> For information about the `ContinueOnError` attribute, see [Task element (MSBuild)](../msbuild/task-element-msbuild.md). |

### Parent elements

| Element | Description |
| - | - |
| [Project](../msbuild/project-element-msbuild.md) | Required root element of an MSBuild project file. |

## Remarks

 The first target to execute is specified at run time. Targets can have dependencies on other targets. For example, a target for deployment depends on a target for compilation. The MSBuild engine executes dependencies in the order in which they appear in the `DependsOnTargets` attribute, from left to right. For more information, see [Targets](../msbuild/msbuild-targets.md).

 MSBuild is import-order dependent, and the last definition of a target with a specific `Name` attribute is the definition used.

 A target is only executed once during a build, even if more than one target has a dependency on it.

 If a target is skipped because its `Condition` attribute evaluates to `false`, it can still be executed if it is invoked later in the build and its `Condition` attribute evaluates to `true` at that time.

 Before MSBuild 4, `Target` returned any items that were specified in the `Outputs` attribute.  To do this, MSBuild had to record these items in case tasks later in the build requested them. Because there was no way to indicate which targets had outputs that callers would require, MSBuild accumulated all items from all `Outputs` on all invoked `Target`s. This lead to scaling problems for builds that had a large number of output items.

 If the user specifies a `Returns` on any `Target` element in a project, then only those `Target`s that have a `Returns` attribute record those items.

 A `Target` may contain both an `Outputs` attribute and a `Returns` attribute.  `Outputs` is used with `Inputs` to determine whether the target is up-to-date. `Returns`, if present, overrides the value of `Outputs` to determine which items are returned to callers.  If `Returns` is not present, then `Outputs` will be made available to callers except in the case described earlier.

 Before MSBuild 4, any time that a `Target` included multiple references to the same item in its `Outputs`, those duplicate items would be recorded. In very large builds that had a large number of outputs and many project interdependencies, this would cause a large amount of memory to be wasted because the duplicate items were not of any use. When the `KeepDuplicateOutputs` attribute is set to `true`, these duplicates are recorded.

## Example

 The following code example shows a `Target` element that executes the `Csc` task.

```xml
<Target Name="Compile" DependsOnTargets="Resources" Returns="$(TargetPath)">
    <Csc Sources="@(CSFile)"
          TargetType="library"
          Resources="@(CompiledResources)"
          EmitDebugInformation="$(includeDebugInformation)"
          References="@(Reference)"
          DebugType="$(debuggingType)" >
        <Output TaskParameter="OutputAssembly"
                  ItemName="FinalAssemblyName" />
    </Csc>
</Target>
```

## See also

- [Targets](../msbuild/msbuild-targets.md)
- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
