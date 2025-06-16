---
title: ProjectSubType Element (Visual Studio Templates)
description: Learn about the ProjectSubType element and how it classifies the template into a subcategory of the value specified in the ProjectType element.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#ProjectSubType
helpviewer_keywords:
- ProjectSubType element [Visual Studio Templates]
- <ProjectSubType> element [Visual Studio Templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# ProjectSubType element (Visual Studio templates)

Classifies the template into a subcategory of the value specified in the `ProjectType` element.

 \<VSTemplate>
 \<TemplateData>
 \<ProjectSubType>

## Syntax

```xml
<ProjectSubType> SubType </ProjectSubType>
```

## Attributes and elements
 The following sections describe attribute, child elements, and parent elements.

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

 This value specifies the subcategory of the template.

## Remarks
 `ProjectSubType` is an optional child element of `TemplateData`.

 The `ProjectSubType` element provides a subcategory to the [ProjectType](../extensibility/projecttype-element-visual-studio-templates.md) element. This value can include:

- `SmartDevice-NETCFv1`: Specifies that the template targets the .NET Compact Framework version 1.0.

- `SmartDevice-NETCFv2`: Specifies that the template targets the .NET Compact Framework version 2.0.

  If a template contains a `ProjectType` element with a value of `Web`, the `ProjectSubType` element specifies the programming language of the template. This element can have the following values:

- `CSharp`: Specifies that the template creates a Visual C# Web project or item.

- `VisualBasic`: Specifies that the template creates a Visual Basic Web project or item.

## Example
 The following example shows the metadata for a project template for a Visual C# device application targeting the .NET Compact Framework version 2.0.

```
<VSTemplate Type="Project" Version="3.0.0"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>My template</Name>
        <Description>A basic device template</Description>
        <Icon>TemplateIcon.ico</Icon>
        <ProjectType>CSharp</ProjectType>
        <ProjectSubType>SmartDevice-NETCFv2</ProjectSubType>
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
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
- [Creating project and item templates](../ide/creating-project-and-item-templates.md)
- [ProjectType element (Visual Studio templates)](../extensibility/projecttype-element-visual-studio-templates.md)
