---
title: "PreviewImage Element (Visual Studio Templates) | Microsoft Docs"
ms.date: "11/04/2016"
ms.technology: vs-ide-general
ms.topic: reference
helpviewer_keywords:
  - "<PreviewImage> Element (Visual Studio Templates)"
  - "PreviewImage Element (Visual Studio Templates)"
ms.assetid: d1796f20-523b-4e0d-8ac3-ca87f3b5a9b6
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
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