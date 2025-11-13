---
title: MaxFrameworkVersion Element (Visual Studio Templates)
description: Learn about the MaxFrameworkVersion element and how it specifies the maximum version of the .NET Framework that is required by the template.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
helpviewer_keywords:
- <MaxFrameworkVersion> Element (Visual Studio Templates)
- MaxFrameworkVersion Element (Visual Studio Templates)
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# MaxFrameworkVersion element (Visual Studio templates)

Specifies the maximum version of the .NET Framework that is required by the template. It determines the highest value available in the **Target Framework Version** dropdown of the **New Project** dialog. In order for users to be able to select a framework version, you must also specify [RequiredFrameworkVersion](../extensibility/requiredframeworkversion-element-visual-studio-templates.md) as the minimum .NET Framework version for the template.

> [!IMPORTANT]
> Starting in Visual Studio 2017 version 15.6, the **Target Framework Version** dropdown is no longer a filter for displayed templates in the **Templates** section of the **New Project** dialog. Instead, the **Target Framework Version** dropdown functions as a framework picker for the selected template.

 \<VSTemplate>
 \<TemplateData>
 \<MaxFrameworkVersion>

## Syntax

```xml
<MaxFrameworkVersion> ... </MaxFrameworkVersion>
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

 The text must be the highest version number of the .NET Framework that is allowed by the template.

## Remarks

`MaxFrameworkVersion` is an optional element. The `MaxFrameworkVersion` element should be omitted unless it is required, so as not to inadvertently limit the supported range of .NET Framework versions for the template. It should also be omitted if .NET Framework is not applicable to the template.

## Example

The following example illustrates the metadata for a standard Visual C# class template.

```xml
<VSTemplate Type="Item" Version="3.0.0"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>MyClass</Name>
        <Description>My custom C# class template.</Description>
        <Icon>Icon.ico</Icon>
        <ProjectType>CSharp</ProjectType>
        <RequiredFrameworkVersion>3.0</RequiredFrameworkVersion>
        <MaxFrameworkVersion>4.7.1</MaxFrameworkVersion>
        <DefaultName>MyClass</DefaultName>
    </TemplateData>
    <TemplateContent>
        <ProjectItem>MyClass.cs</ProjectItem>
    </TemplateContent>
</VSTemplate>
```

In this example, the maximum version of the .NET Framework that is required by the template, represented by `MaxFrameworkVersion`, is 4.7.1. A project created with this template can target .NET Framework versions up to 4.7.1.

## See also

- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
- [Creating project and item templates](../ide/creating-project-and-item-templates.md)
