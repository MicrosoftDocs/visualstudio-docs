---
title: "ImportGroup Element | Microsoft Docs"
ms.date: "03/13/2017"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "<ImportGroup> element [MSBuild]"
  - "ImportGroup element [MSBuild]"
ms.assetid: dac3fa2d-6678-4017-af35-93686f53f302
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# ImportGroup element
Contains a collection of `Import` elements that are grouped under an optional condition. For more information, see [Import element (MSBuild)](../msbuild/import-element-msbuild.md).

 \<Project>
 \<ImportGroup>

## Syntax

```xml
<ImportGroup Condition="'String A' == 'String B'">
    <Import ... />
    <Import ... />
</ImportGroup>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`Condition`|Optional attribute.<br /><br /> The condition to be evaluated. For more information, see [Conditions](../msbuild/msbuild-conditions.md).|

### Child elements

|Element|Description|
|-------------|-----------------|
|[Import](../msbuild/import-element-msbuild.md)|Imports the contents of one project file into another project file.|

### Parent elements

| Element | Description |
| - | - |
| [Project](../msbuild/project-element-msbuild.md) | Required root element of an [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] project file. |

## Example
 The following code example shows the `ImportGroup` element.

```xml
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
    <ImportGroup>
        <Import Project="$(Targets1.targets)" />
        <Import Project="$(Targets2.targets)" />
    </ImportGroup>
...
</Project>
```

## See also
- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
- [Items](../msbuild/msbuild-items.md)
