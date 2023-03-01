---
title: SDKReference Element (Visual Studio Templates) | Microsoft Docs
description: Learn about the SDKReference element and how it specifies that the item template uses an SDK reference.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.technology: vs-ide-general
ms.topic: reference
ms.assetid: 72c8b352-0b7a-42b3-ba5d-2a2d1e90c34b
author: maiak
ms.author: maiak
manager: jmartens
ms.workload:
- vssdk
---
# SDKReference Element (Visual Studio Templates)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Specifies that the item template uses an SDK reference.

## Syntax

```xml
<VSTemplate>
    <TemplateContent>
        <References>
            <Reference>
                <SDKReference>SDKname</SDKReference>
```

## Attributes and Elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes
 None.

### Child Elements
 None.

### Parent Elements

|Element|Description|
|-------------|-----------------|
|[Reference](../extensibility/reference-element-visual-studio-templates.md)|Specifies the assembly reference to add when the item is added to a project.|

## Text Value
 A text value is required.

## Remarks
 This text specifies the SDK reference to add to a project when the item template is instantiated.

```xml
<VSTemplate Version="3.0.0" xmlns="http://schemas.microsoft.com/developer/vstemplate/2005" Type="Item">
    <TemplateData> . . . </TemplateData>
    <TemplateContent>
        <References>
            <Reference>
                <SDKReference>Microsoft Visual C++ Runtime Package, Version=11.0.0.0</SDKReference>
...
```

## See also
- [References Element (Visual Studio Templates)](../extensibility/references-element-visual-studio-templates.md)
- [Reference Element (Visual Studio Templates)](../extensibility/reference-element-visual-studio-templates.md)
- [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
- [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
