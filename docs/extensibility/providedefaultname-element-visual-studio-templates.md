---
title: ProvideDefaultName Element (Visual Studio Templates)
description: Learn about the ProvideDefaultName element and how it specifies if Visual Studio will generate a default Visual Studio name in the Add New Item or New Project dialog box.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#ProvideDefaultName
helpviewer_keywords:
- ProvideDefaultName element [Visual Studio project templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# ProvideDefaultName element (Visual Studio templates)

Specifies whether the Visual Studio project system will generate a default name for the template in the **Add New Item** or **New Project** dialog box.

 \<VSTemplate>
 \<TemplateData>
 \<ProvideDefaultName>

## Syntax

```xml
<ProvideDefaultName> true/false </ProvideDefaultName>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes
 None.

### Child Elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Required element.<br /><br /> Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|

## Text value
 A text value is required.

 The text must be either `true` or `false`, indicating whether or not to generate a default name for the template in the **Add New Item** or **New Project** dialog box.

## Remarks
 `ProvideDefaultName` is an optional element. The default value is `true`.

 If the `ProvideDefaultName` element is `false`, the **Name** boxes of the **Add New Item** and **New Project** dialog boxes contain the value `<Enter_name>`.

 Use the [DefaultName](../extensibility/defaultname-element-visual-studio-templates.md) element to specify the default name of the project or item in the **Add New Item** and **New Project** dialog boxes. When the value of the `ProvideDefaultName` element is `true`, omission of the `DefaultName` element for projects populates the dialog box with the template's name, that is, the value from the [Name](../extensibility/name-element-visual-studio-templates.md) element.

## Example
 The following code example sets the `ProvideDefaultName` element to `false`.

```
<VSTemplate Type="Item" Version="3.0.0"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>MyClass</Name>
        <Description>My custom C# class.</Description>
        <Icon>Icon.ico</Icon>
        <ProjectType>CSharp</ProjectType>
        <ProvideDefaultName>false</ProvideDefaultName>
    </TemplateData>
    <TemplateContent>
        <ProjectItem>MyClass.cs</ProjectItem>
    </TemplateContent>
</VSTemplate>
```

## See also
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
- [Create project and item templates](../ide/creating-project-and-item-templates.md)
