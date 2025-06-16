---
title: Hidden Element (Visual Studio Templates)
description: Learn about the Hidden element and how it specifies whether the template appears in either the new project or Add New Item dialog boxes.
ms.date: 04/17/2019
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#Hidden
helpviewer_keywords:
- Hidden element [Visual Studio project template]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# Hidden element (Visual Studio templates)

Specifies whether the template appears in either the new project or **Add New Item** dialog boxes.

```xml
<VSTemplate>
    <TemplateData>
        <Hidden>
```

## Syntax

```xml
<Hidden>true</Hidden>
<Hidden>false</Hidden>
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
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Required element.<br /><br /> Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|

## Text value

A text value is required.

The text must be either `true` or `false`, indicating whether or not the template will appear in the **New Project** or **Add New Item** dialog boxes.

## Remarks

`Hidden` is an optional element.

If specified, no other child elements of the `TemplateData` element are required.

## Example

The following example illustrates the metadata for a C# template.

```xml
<VSTemplate Type="Project" Version="3.0.0"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>My template</Name>
        <Description>A basic template</Description>
        <Icon>TemplateIcon.ico</Icon>
        <ProjectType>CSharp</ProjectType>
        <Hidden>true</Hidden>
    </TemplateData>
    <TemplateContent>
        <Project File="MyTemplate.csproj">
            <ProjectItem>Form1.cs<ProjectItem>
            <ProjectItem>Form1.Designer.cs</ProjectItem>
            <ProjectItem>Program.cs</ProjectItem>
            <ProjectItem>Properties\AssemblyInfo.cs</ProjectItem>
            <ProjectItem>Properties\Resources.resx</ProjectItem>
            <ProjectItem>Properties\Resources.Designer.cs</ProjectItem>
            <ProjectItem>Properties\Settings.settings</ProjectItem>
            <ProjectItem>Properties\Settings.Designer.cs</ProjectItem>
        </Project>
    </TemplateContent>
</VSTemplate>
```

## See also

- [Template schema reference](../extensibility/visual-studio-template-schema-reference.md)
- [Create project and item templates](../ide/creating-project-and-item-templates.md)
