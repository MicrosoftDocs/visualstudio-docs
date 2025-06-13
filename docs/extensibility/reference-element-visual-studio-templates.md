---
title: Reference Element (Visual Studio Templates)
description: Learn about the Reference element and how it specifies the assembly reference to add when the item is added to a project.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#Reference
helpviewer_keywords:
- Reference element [Visual Studio templates]
- <Reference> element [Visual Studio templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# Reference element (Visual Studio templates)

Specifies the assembly reference to add when the item is added to a project.

 \<VSTemplate>
 \<TemplateContent>
 \<References>
 \<Reference>

## Syntax

```xml
<Reference>
    <Assembly> ... </Assembly>
</Reference>
```

## Attributes and elements
 The following sections describe attribute, child elements, and parent elements.

### Attributes
 None.

### Child elements

|Element|Description|
|-------------|-----------------|
|[Assembly](../extensibility/assembly-element-visual-studio-templates.md)|Required element.<br /><br /> Specifies information about an assembly, which the template uses to add a reference of that assembly to projects. There must be one `Assembly` element in every `Reference` element.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[References](../extensibility/references-element-visual-studio-templates.md)|Groups the assembly references that the template adds to projects.|

## Remarks
 `Reference` is a required child element of `References`.

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
- [Create project and item templates](../ide/creating-project-and-item-templates.md)
