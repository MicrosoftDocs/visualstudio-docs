---
title: "CustomDataSignature Element (Visual Studio Templates) | Microsoft Docs"
ms.date: "11/04/2016"
ms.technology: vs-ide-general
ms.topic: reference
helpviewer_keywords:
  - "<CustomDataSignature> Element (Visual Studio Templates)"
  - "CustomDataSignature Element (Visual Studio Templates)"
ms.assetid: 8c3db51d-7014-4484-802a-15aa1353dbdb
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
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