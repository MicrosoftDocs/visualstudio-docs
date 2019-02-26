---
title: "PropertyGroup Element (MSBuild) | Microsoft Docs"
ms.date: "03/13/2017"
ms.topic: "reference"
f1_keywords:
  - "http://schemas.microsoft.com/developer/msbuild/2003#PropertyGroup"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "<PropertyGroup> element [MSBuild]"
  - "PropertyGroup element [MSBuild]"
ms.assetid: ff1e6c68-b9a1-4263-a1ce-dc3b829a64d4
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# PropertyGroup element (MSBuild)
Contains a set of user-defined [Property](../msbuild/property-element-msbuild.md) elements. Every `Property` element used in an [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] project must be a child of a `PropertyGroup` element.

 \<Project>
 \<PropertyGroup>

## Syntax

```xml
<PropertyGroup Condition="'String A' == 'String B'">
    <Property1>...</Property1>
    <Property2>...</Property2>
</PropertyGroup>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|Condition|Optional attribute.<br /><br /> Condition to be evaluated. For more information, see [Conditions](../msbuild/msbuild-conditions.md).|

### Child elements

|Element|Description|
|-------------|-----------------|
|[Property](../msbuild/property-element-msbuild.md)|Optional element.<br /><br /> A user defined property name, which contains the property value. There may be zero or more *Property* elements in a `PropertyGroup` element.|

### Parent elements

| Element | Description |
| - | - |
| [Project](../msbuild/project-element-msbuild.md) | Required root element of an [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] project file. |

## Example
 The following code example shows how to set properties based on a condition. In this example, if the value of the `CompileConfig` property is `DEBUG`, the `Optimization`, `Obfuscate`, and `OutputPath` properties inside of the `PropertyGroup` element are set.

```xml
<PropertyGroup Condition="'$(CompileConfig)' == 'DEBUG'" >
    <Optimization>false</Optimization>
    <Obfuscate>false</Obfuscate>
    <OutputPath>$(OutputPath)\debug</OutputPath>
</PropertyGroup>
```

## See also
- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
- [MSBuild properties](../msbuild/msbuild-properties.md)
