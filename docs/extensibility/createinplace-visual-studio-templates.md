---
title: CreateInPlace element (Visual Studio Templates)
description: Learn about the CreateInPlace element and how it specifies whether to create the project and perform parameter replacement in a specific or temporary location.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#CreateInPlace
helpviewer_keywords:
- CreateInPlace element [Visual Studio Templates]
- <CreateInPlace> element [Visual Studio Templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# CreateInPlace element (Visual Studio templates)

Specifies whether to create the project and perform parameter replacement in the specified location, or perform parameter replacement in a temporary location and then save the project to the specified location.

 \<VSTemplate>
 \<TemplateData>
 \<CreateInPlace>

## Syntax

```
<CreateInPlace> true/false </CreateInPlace>
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
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|

## Text value
 A text value is required.

 The text must be either `true` or `false`. If `true`, the project is created and parameter replacement is performed in the location specified in the **New Project** dialog box. If `false`, parameter replacement is performed in a temporary location and the project is then copied to the specified location.

## Remarks
 `CreateInPlace` is an optional element. The default value is `true`.

## Example
 The following example illustrates the metadata for a Visual C# template.

```
<VSTemplate Type="Project" Version="3.0.0"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>My template</Name>
        <Description>A basic template</Description>
        <Icon>TemplateIcon.ico</Icon>
        <ProjectType>CSharp</ProjectType>
        <CreateInPlace>false</CreateInPlace>
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
- [Create project and item templates](../ide/creating-project-and-item-templates.md)
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
