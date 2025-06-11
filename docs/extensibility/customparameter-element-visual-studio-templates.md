---
title: CustomParameter Element (Visual Studio Templates)
description: Learn about the CustomParameter element and how it contains a custom parameter name and value to use when a project or item is created from the template.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#CustomParameter
helpviewer_keywords:
- CustomParameters element [Visual Studio project templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# CustomParameter element (Visual Studio templates)

Contains a custom parameter name and value to use when a project or item is created from the template.

## Syntax

```
<CustomParameter Name="name" Value="value">
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`Name`|Required. The name of the parameter. The format for parameters is $*name*$.|
|`Value`|Required. The replacement value for the parameter.|

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[CustomParameters](../extensibility/customparameters-element-visual-studio-templates.md)|Groups the custom parameters that are to be passed to the template wizard when the wizard makes parameter replacements.|

## Remarks
 When a template contains `CustomParameter` elements, every instance the `Name` attribute is replaced with the `Value` attribute in the created project or item files.

## Example
 The following example shows how to use several custom parameters in a template. When a project or item is created from a template with the following custom parameters, all instances of `$color1$` and `$color2$` in the template files will be replaced with `Red` and `Blue`, respectively.

```
<CustomParameters>
    <CustomParameter Name="$color1$" Value="Red"/>
    <CustomParameter Name="$color2$" Value="Blue "/>
</CustomParameters>
```

## See also
- [CustomParameters element (Visual Studio templates)](../extensibility/customparameters-element-visual-studio-templates.md)
- [Template parameters](../ide/template-parameters.md)
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
