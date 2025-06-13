---
title: Assembly Element (Visual Studio Templates)
titleSuffix: ""
description: Learn about the Assembly element and how it specifies information about an assembly, which the template uses to add a reference of that assembly to projects.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#Assembly
helpviewer_keywords:
- Assembly element [Visual Studio templates]
- <Assembly> element [Visual Studio templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# Assembly element (Visual Studio templates)

Specifies information about an assembly, which the template uses to add a reference of that assembly to projects.

 \<VSTemplate>
 \<TemplateContent>
 \<References>
 \<Reference>
 \<Assembly>

## Syntax

```
<Assembly> AssemblyName </Assembly>
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
|[Reference](../extensibility/reference-element-visual-studio-templates.md)|Specifies the assembly reference to add when the item is added to a project.|

## Text value
 A text value is required.

 This text specifies the assembly to add to a project when the item template is instantiated. This assembly name must be specified in one of the following ways:

- As a full assembly name. For example:

    ```
    <Assembly>
        MyAssembly, Version=1.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, Custom = null.
    </Assembly>
    ```

- As simple text reference. For example:

    ```
    <Assembly> System </Assembly>
    ```

## Remarks
 `Assembly` is a required child element of `Reference`.

 The `Reference`, `References,` and `Assembly` elements can only be used in *.vstemplate* files that have a `Type` attribute value of `Item`.

## Example
 The following example illustrates the `TemplateContent` element of an item template. This XML adds references to the *System.dll* and *System.Data.dll* assemblies.

```
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
