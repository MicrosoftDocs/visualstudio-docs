---
title: ItemMetadata Element (MSBuild) | Microsoft Docs
description: Learn about the MSBuild ItemMetadata element, which contains a user-defined item metadata key that has the metadata value.
ms.custom: SEO-VS-2020
ms.date: 03/13/2017
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- ItemMetadata Element [MSBuild]
- <ItemMetadata> Element [MSBuild]
ms.assetid: e3db5122-202d-43a9-b2f4-3e0ec4ed3d08
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# ItemMetadata element (MSBuild)

Contains a user-defined item metadata key, which contains the item metadata value. An item may have any number of metadata key-value pairs.

 \<Project>
 \<ItemGroup>
 \<Item>

## Syntax

```xml
<ItemMetadataName> Item Metadata value</ItemMetadataName>
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
|[Item](../msbuild/item-element-msbuild.md)|A user-defined element that defines the inputs for the build process.|

## Text value

 A text value is optional.

 This text specifies the item metadata value, which can be either text or XML.

## Example

 The following code example shows how to add `Culture` metadata with the value `fr` to the item `CSFile`.

```xml
<ItemGroup>
    <CSFile Include="main.cs" >
        <Culture>fr</Culture>
    </CSFile>
</ItemGroup>
```

## See also

- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
- [Items](../msbuild/msbuild-items.md)
