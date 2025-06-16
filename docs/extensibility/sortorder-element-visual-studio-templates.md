---
title: SortOrder Element (Visual Studio Templates)
description: Learn about the SortOrder element and how it specifies a value that is used to arrange the template as it appears in either the New Project or Add New Item dialog box.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#SortOrder
helpviewer_keywords:
- SortOrder element [Visual Studio Templates]
- <SortOrder> element [Visual Studio Templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# SortOrder Element (Visual Studio Templates)

Specifies a value that is used to arrange the template, among other templates in the same category, as it appears in either the **New Project** or **Add New Item** dialog box.

 \<VSTemplate>
 \<TemplateData>
 \<SortOrder>

## Syntax

```
<SortOrder> ... </SortOrder>
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
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Required element.<br /><br /> Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|

## Text Value
 A text value is required.

 An `integer` that represents the sort order value.

## Remarks
 `SortOrder` is an optional element. The default value is 100, and all values must be multiples of 10.

 The `SortOrder` element is ignored for user-created templates. All user-created templates are sorted alphabetically.

 Templates that have low sort order values appear in either the **New Project** or **New Add Item** dialog box before templates that have high sort order values.

## Example
 The following example illustrates the metadata for a standard Visual C# class template.

```
<VSTemplate Type="Item" Version="3.0.0"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>MyClass</Name>
        <Description>My custom C# class template.</Description>
        <Icon>Icon.ico</Icon>
        <ProjectType>CSharp</ProjectType>
        <SortOrder>290</SortOrder>
        <DefaultName>MyClass</DefaultName>
    </TemplateData>
    <TemplateContent>
        <ProjectItem>MyClass.cs</ProjectItem>
    </TemplateContent>
</VSTemplate>
```

 In this example, the `SortOrder` element is relatively high. It is likely that other Visual C# item templates will have a `SortOrder` value lower than `290` and will appear before this template in the **New Item** dialog box.

## See also
- [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
- [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
