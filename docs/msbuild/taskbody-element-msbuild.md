---
title: "TaskBody Element (MSBuild) | Microsoft Docs"
ms.date: "03/13/2017"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "TaskBody element [MSBuild]"
  - "<TaskBody> element [MSBuild]"
ms.assetid: 49d8741b-f1ea-4470-94fd-a1ac27341a6a
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# TaskBody element (MSBuild)
Contains the data that is passed to a `UsingTask` `TaskFactory`. For more information, see [UsingTask element (MSBuild)](../msbuild/usingtask-element-msbuild.md).

 \<Project>
 \<UsingTask>
 \<TaskBody>

## Syntax

```xml
<TaskBody Evaluate="true/false" />
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`Evaluate`|Optional Boolean attribute.<br /><br /> If `true`, MSBuild evaluates any inner elements, and expands items and properties before it passes the information to the `TaskFactory` when the task is instantiated.|

### Child elements

|Element|Description|
|-------------|-----------------|
|Data|The text between the `TaskBody` tags is sent verbatim to the `TaskFactory`.|

### Parent elements

| Element | Description |
| - | - |
| [UsingTask](../msbuild/usingtask-element-msbuild.md) | Provides a way to register tasks in [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)]. There may be zero or more `UsingTask` elements in a project. |

## Example
 The following example shows how to use the `TaskBody` element with an `Evaluate` attribute.

```xml
<UsingTask TaskName="MyTask" AssemblyName="My.Assembly" TaskFactory="MyTaskFactory">
       <ParameterGroup>
              <Parameter1 ParameterType="System.String" Required="False" Output="False"/>
              <Parameter2 ParameterType="System.Int" Required="True" Output="False"/>
              ...
</ParameterGroup>
       <TaskBody Evaluate="true">
      ... Task factory-specific data ...
       </TaskBody>
</UsingTask>
```

## See also
- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
