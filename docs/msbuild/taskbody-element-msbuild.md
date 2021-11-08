---
title: Task Element of UsingTask (MSBuild) | Microsoft Docs
description: Learn about the Task element of the MSBuild UsingTask, which contains the data that is passed to a UsingTask TaskFactory.
ms.custom: SEO-VS-2020
ms.date: 03/13/2017
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- Task element [MSBuild]
- <Task> element [MSBuild]
ms.assetid: 49d8741b-f1ea-4470-94fd-a1ac27341a6a
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Task element of UsingTask (MSBuild)

Contains the data that is passed to a `UsingTask` `TaskFactory`. For more information, see [UsingTask element (MSBuild)](../msbuild/usingtask-element-msbuild.md).

 \<Project>
 \<UsingTask>
 \<Task>

## Syntax

```xml
<Task Evaluate="true/false" />
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
|Data|The text between the `Task` tags is sent verbatim to the `TaskFactory`.|

### Parent elements

| Element | Description |
| - | - |
| [UsingTask](../msbuild/usingtask-element-msbuild.md) | Provides a way to register tasks in MSBuild. There may be zero or more `UsingTask` elements in a project. |

## Example

 The following example shows how to use the `Task` element with an `Evaluate` attribute.

```xml
<UsingTask TaskName="MyTask" AssemblyName="My.Assembly" TaskFactory="MyTaskFactory">
       <ParameterGroup>
              <Parameter1 ParameterType="System.String" Required="False" Output="False"/>
              <Parameter2 ParameterType="System.Int" Required="True" Output="False"/>
              ...
</ParameterGroup>
       <Task Evaluate="true">
       ... Task factory-specific data ...
       </Task>
</UsingTask>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
