---
title: CustomDataSignature Element (Visual Studio Templates)
description: Learn about the CustomDataSignature element and how it specifies the text signature to locate the custom data.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
helpviewer_keywords:
- <CustomDataSignature> Element (Visual Studio Templates)
- CustomDataSignature Element (Visual Studio Templates)
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# CustomDataSignature element (Visual Studio templates)

Specifies the text signature to locate the custom data.

 \<VSTemplate>
 \<TemplateData>
 \<CustomDataSignature>

## Syntax

```
<CustomDataSignature>"string"</CustomDataSignature>
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

 The text is a string that has the text signature that is required to locate the custom data.

## Remarks
 `CustomDataSignature` is an optional element.

## See also
- [Visual Studio Template schema reference](../extensibility/visual-studio-template-schema-reference.md)
- [Creating project and item templates](../ide/creating-project-and-item-templates.md)
