---
title: "Task Element (MSBuild) | Microsoft Docs"
ms.date: "03/13/2017"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "Task element [MSBuild]"
  - "<Task> element [MSBuild]"
ms.assetid: d82e2485-e5f0-4936-a357-745bacccc299
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Task element (MSBuild)
Creates and executes an instance of an [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] task. The element name is determined by the name of the task being created.

 \<Project>
 \<Target>

## Syntax

```xml
<Task Parameter1="Value1"... ParameterN="ValueN"
    ContinueOnError="WarnAndContinue/true/ErrorAndContinue/ErrorAndStop/false"
    Condition="'String A' == 'String B'" >
    <Output... />
</Task>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`Condition`|Optional attribute. Condition to be evaluated. For more information, see [Conditions](../msbuild/msbuild-conditions.md).|
|`ContinueOnError`|Optional attribute. Can contain one of the following values:<br /><br /> -   **WarnAndContinue** or **true**. When a task fails, subsequent tasks in the [Target](../msbuild/target-element-msbuild.md) element and the build continue to execute, and all errors from the task are treated as warnings.<br />-   **ErrorAndContinue**. When a task fails, subsequent tasks in the `Target` element and the build continue to execute, and all errors from the task are treated as errors.<br />-   **ErrorAndStop** or **false** (default). When a task fails, the remaining tasks in the `Target` element and the build aren't executed, and the entire `Target` element and the build is considered to have failed.<br /><br /> Versions of the .NET Framework before 4.5 supported only the `true` and `false` values.<br /><br /> For more information, see [How to: Ignore errors in tasks](../msbuild/how-to-ignore-errors-in-tasks.md).|
|`Parameter`|Required if the task class contains one or more properties labeled with the `[Required]` attribute.<br /><br /> A user-defined task parameter that contains the parameter value as its value. There can be any number of parameters in the `Task` element, with each attribute mapping to a .NET property in the task class.|

### Child elements

|Element|Description|
|-------------|-----------------|
|[Output](../msbuild/output-element-msbuild.md)|Stores outputs from the task in the project file. There may be zero or more `Output` elements in a task.|

### Parent elements

| Element | Description |
| - | - |
| [Target](../msbuild/target-element-msbuild.md) | Container element for [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] tasks. |

## Remarks
 A `Task` element in an [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] project file creates an instance of a task, sets properties on it, and executes it. The `Output` element stores output parameters in properties or items to be used elsewhere in the project file.

 If there are any [OnError](../msbuild/onerror-element-msbuild.md) elements in the parent `Target` element of a task, they will still be evaluated if the task fails and `ContinueOnError` has a value of `false`. For more information on tasks, see [Tasks](../msbuild/msbuild-tasks.md).

## Example
 The following code example creates an instance of the [Csc task](../msbuild/csc-task.md) class, sets six of the properties, and executes the task. After execution, the value of the `OutputAssembly` property of the object is placed into an item list named `FinalAssemblyName`.

```xml
<Target Name="Compile" DependsOnTarget="Resources" >
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
- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
