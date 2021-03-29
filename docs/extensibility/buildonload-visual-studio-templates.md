---
title: BuildOnLoad attribute and element (Visual Studio Templates)
titleSuffix: ""
description: Learn about the BuildOnLoad attribute and element and how it specifies whether to build the project immediately after it's created.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#BuildOnLoad
helpviewer_keywords:
- BuildOnLoad attribute [Visual Studio Templates]
- BuildOnLoad element [Visual Studio Templates]
ms.assetid: 950f5fc1-d041-4090-9a5c-60844768a4cc
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# BuildOnLoad attribute and element

Specifies whether to build the project immediately after it's created. **BuildOnLoad** is both an attribute and an element.

Element hierarchy:

```xml
<VSTemplate>
  <TemplateData>
    <BuildOnLoad>
```

## Element syntax

```xml
<BuildOnLoad> true/false </BuildOnLoad>
```

## Parent elements

|Element|Description|
|-------------|-----------------|
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|

## Text value

A text value is required for the **BuildOnLoad** element. The text must be either `true` or `false`, indicating whether to build the project immediately after it's created.

## Remarks

**BuildOnLoad** is an optional attribute. The default value is `false`.

## Example

The following example illustrates the metadata for a C# template when **BuildOnLoad** is used as an element:

```xml
<VSTemplate Type="Project" Version="3.0.0"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>My template</Name>
        <Description>A basic template</Description>
        <Icon>TemplateIcon.ico</Icon>
        <ProjectType>CSharp</ProjectType>
        <BuildOnLoad>true</BuildOnLoad>
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

- [BuildProjectOnload element](buildprojectonload-element-visual-studio-templates.md)
- [TemplateContent element](../extensibility/templatecontent-element-visual-studio-templates.md)
- [Creating project and item templates](../ide/creating-project-and-item-templates.md)
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
