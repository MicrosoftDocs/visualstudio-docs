---
title: PreviewImage Element (Visual Studio Templates)
description: Learn about the PreviewImage element and how it specifies the file name for the preview image that will appear in the New Project or Add New Item dialog box.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
helpviewer_keywords:
- <PreviewImage> Element (Visual Studio Templates)
- PreviewImage Element (Visual Studio Templates)
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# PreviewImage element (Visual Studio templates)

Specifies the preview image, as a file name, for the preview image that will appear in either the **New Project** or **Add New Item** dialog box.

 \<VSTemplate>
 \<TemplateData>
 \<PreviewImage>

## Syntax

```
<PreviewImage>"filename"</PreviewImage>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes
 None.

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Required element.<br /><br /> Categorizes the template and defines how it is displayed in either the **New Project** or the **Add New Item** dialog box.|

## Text value
 A text value is required.

 The text must be a string that represents a file name.

## Remarks
 `PreviewImage` is an optional element.

## See also
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
- [Creating project and item templates](../ide/creating-project-and-item-templates.md)
