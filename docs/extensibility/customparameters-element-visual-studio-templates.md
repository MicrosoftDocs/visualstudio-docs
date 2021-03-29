---
title: CustomParameters Element (Visual Studio Templates) | Microsoft Docs
description: Learn about the CustomParameters element and how it groups the custom parameters that are to be passed to the template wizard when the wizard makes parameter replacements.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#CustomParameters
helpviewer_keywords:
- CustomParameters element [Visual Studio project templates]
ms.assetid: cf3efc91-1532-4022-bbb8-a18658424fee
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# CustomParameters element (Visual Studio templates)
Groups the custom parameters that are to be passed to the template wizard when the wizard makes parameter replacements.

## Syntax

```
<CustomParameters>
    <CustomParameter/>
    <CustomParameter/>
</CustomParameters>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes
 None.

### Child elements

|Element|Description|
|-------------|-----------------|
|[CustomParameter](../extensibility/customparameter-element-visual-studio-templates.md)|Optional element.<br /><br /> Contains a custom parameter name and value to use when a project or item is created from the template. There may be zero or more `CustomParameter` elements in a `CustomParameters` element.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[TemplateContent](../extensibility/templatecontent-element-visual-studio-templates.md)|Specifies the contents of the template.|

## Remarks

## Example
 The following example shows how to use several custom parameters in a template. When a project or item is created from a template with the following custom parameters, all instances of `$color1$` and `$color2$` in the template files will be replaced with `Red` and `Blue`, respectively.

```
<CustomParameters>
    <CustomParameter Name="$color1$" Value="Red"/>
    <CustomParameter Name="$color2$" Value="Blue "/>
</CustomParameters>
```

## See also
- [CustomParameter element (Visual Studio templates)](../extensibility/customparameter-element-visual-studio-templates.md)
- [Template parameters](../ide/template-parameters.md)
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
