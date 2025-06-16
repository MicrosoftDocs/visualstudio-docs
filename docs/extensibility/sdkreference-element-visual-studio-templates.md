---
title: SDKReference Element (Visual Studio Templates)
description: Learn about the SDKReference element and how it specifies that the item template uses an SDK reference.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# SDKReference Element (Visual Studio Templates)

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
