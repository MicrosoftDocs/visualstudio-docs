---
title: Output Element (MSBuild) | Microsoft Docs
description: See attributes, elements, and an example of the MSBuild Output element, which stores task output values in items and properties.
ms.custom: SEO-VS-2020
ms.date: 03/13/2017
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#Output
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- <Output> Element [MSBuild]
- Output Element [MSBuild]
ms.assetid: 34bc7cd1-efd3-4b57-b691-4584eeb6a0e9
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Output element (MSBuild)

Stores task output values in items and properties.

 \<Project>
 \<Target>
 \<Task>
 \<Output>

## Syntax

```xml
<Output TaskParameter="Parameter"
    PropertyName="PropertyName"
    Condition = "'String A' == 'String B'" />
```

## Attributes and elements

 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`TaskParameter`|Required attribute.<br /><br /> The name of the task's output parameter.|
|`PropertyName`|Either the `PropertyName` or `ItemName` attribute is required.<br /><br /> The property that receives the task's output parameter value. Your project can then reference the property with the $(\<PropertyName>) syntax. This property name can either be a new property name or a name that is already defined in the project.<br /><br /> This attribute cannot be used if `ItemName` is also being used.|
|`ItemName`|Either the `PropertyName` or `ItemName` attribute is required.<br /><br /> The item that receives the task's output parameter value. Your project can then reference the item with the @(\<ItemName>) syntax. The item name can either be a new item name or a name that is already defined in the project. When the item name is an existing item, the output parameter values are added to the existing item. <br /><br /> This attribute cannot be used if `PropertyName` is also being used.|
|`Condition`|Optional attribute.<br /><br /> Condition to be evaluated. For more information, see [Conditions](../msbuild/msbuild-conditions.md).|

### Child elements

 None.

### Parent elements

| Element | Description |
| - | - |
| [Task](../msbuild/task-element-msbuild.md) | Creates and executes an instance of an MSBuild task. |

## Example

 The following code example shows the `Csc` task being executed inside of a `Target` element. The items and properties passed to the task parameters are declared outside of the scope of this example. The value from the output parameter `OutputAssembly` is stored in the `FinalAssemblyName` item, and the value from the output parameter `BuildSucceeded` is stored in the `BuildWorked` property. For more information, see [Tasks](../msbuild/msbuild-tasks.md).

```xml
<Target Name="Compile" DependsOnTargets="Resources">
    <Csc  Sources="@(CSFile)"
            TargetType="library"
            Resources="@(CompiledResources)"
            EmitDebugInformation="$(includeDebugInformation)"
            References="@(Reference)"
            DebugType="$(debuggingType)"
            OutputAssembly="$(builtdir)\$(MSBuildProjectName).dll" >
        <Output TaskParameter="OutputAssembly"
                  ItemName="FinalAssemblyName" />
        <Output TaskParameter="BuildSucceeded"
                  PropertyName="BuildWorked" />
    </Csc>
</Target>
```

## See also

- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
- [Tasks](../msbuild/msbuild-tasks.md)
