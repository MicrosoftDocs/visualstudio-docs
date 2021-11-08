---
title: Property Element (MSBuild) | Microsoft Docs
description: Learn about the MSBuild Property element, which contains a user-defined property name and value that must be specified as a child of a PropertyGroup element.
ms.custom: SEO-VS-2020
ms.date: 03/13/2017
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- <Property> Element [MSBuild]
- Property Element [MSBuild]
ms.assetid: 69ab08ab-3e76-41dd-a01b-49aa1d2e0cac
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Property element (MSBuild)

Contains a user defined property name and value. Every property used in an MSBuild project must be specified as a child of a `PropertyGroup` element.

 \<Project>
 \<PropertyGroup>

## Syntax

```xml
<Property Condition="'String A' == 'String B'">
    Property Value
</Property>
```

## Attributes and elements

 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`Condition`|Optional attribute.<br /><br /> Condition to be evaluated. For more information, see [Conditions](../msbuild/msbuild-conditions.md).|

### Child elements

 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[PropertyGroup](../msbuild/propertygroup-element-msbuild.md)|Grouping element for properties.|

## Text value

 A text value is optional.

 This text specifies the property value and may contain XML.

## Remarks

 Property names are limited to ASCII chars only. Property values are referenced in the project by placing the property name between "`$(`" and "`)`". For example, `$(builddir)\classes` would resolve to *build\classes*, if the `builddir` property had the value `build`. For more information on properties, see [MSBuild properties](../msbuild/msbuild-properties.md).

## Example

 The following code sets the `Optimization` property to `false` and the `DefaultVersion` property to `1.0` if the `Version` property is empty.

```xml
<PropertyGroup>
    <Optimization>false</Optimization>
    <DefaultVersion Condition="'$(Version)' == ''" >1.0</DefaultVersion>
</PropertyGroup>
```

## See also

- [MSBuild properties](../msbuild/msbuild-properties.md)
- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
