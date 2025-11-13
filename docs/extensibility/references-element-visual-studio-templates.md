---
title: References Element (Visual Studio Templates)
description: Learn about the References element and how it groups the assembly references that the template adds to projects.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#References
helpviewer_keywords:
- <References> element [Visual Studio Templates]
- References element [Visual Studio Templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# References element (Visual Studio templates)

Groups the assembly references that the template adds to projects.

 \<VSTemplate>
 \<TemplateContent>
 \<References>

## Syntax

```xml
<References>
    <Reference>... </Reference>
    <Reference>... </Reference>
    ...
</References>
```

## Attributes and elements
 The following sections describe attribute, child elements, and parent elements.

### Attributes
 None.

### Child elements

|Element|Description|
|-------------|-----------------|
|[Reference](../extensibility/reference-element-visual-studio-templates.md)|Required element.<br /><br /> Specifies the assembly reference to add when the item is added to a project. There must be one or more `Reference` elements in a `References` element.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[TemplateContent](../extensibility/templatecontent-element-visual-studio-templates.md)|Specifies the contents of the template.|

## Remarks
 `References` is an optional child element of `TemplateContent`.

 The `Reference` and `References` elements can only be used in *.vstemplate* files that have a `Type` attribute value of `Item`.

## Example
 The following example illustrates the `TemplateContent` element of an item template. This XML adds references to the *System.dll* and *System.Data.dll* assemblies.

```xml
<TemplateContent>
    <References>
        <Reference>
            <Assembly>
                System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
            </Assembly>
        </Reference>
        <Reference>
            <Assembly>
                System.Data, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
            </Assembly>
        </Reference>
    </References>
    ...
</TemplateContent>
```

## See also
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
- [Creating project and item templates](../ide/creating-project-and-item-templates.md)
