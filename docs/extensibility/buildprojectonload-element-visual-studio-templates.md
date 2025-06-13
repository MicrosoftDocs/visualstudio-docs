---
title: BuildProjectOnload Element (Visual Studio Templates)
description: Learn about the BuildProjectOnload element and how it builds only new projects as you create and add them to a solution.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# BuildProjectOnload element (Visual Studio templates)

Builds only new projects as you create and add them to a solution. The entire solution isn't built.

Element hierarchy:

```xml
<VSTemplate>
  <TemplateData>
    <BuildProjectOnLoad>
```

## Syntax

```vb
<BuildProjectOnLoad> true/false </BuildProjectOnLoad>
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
|`TemplateData`|Categorizes the template and defines how it appears in both the **New Project** and the **Add New Item** dialog boxes.|

## Text value
 A text value is required.

 The text must be either `true` or `false` to indicate whether to build only the new project when it's created from the template.

## Remarks
 `BuildProjectOnLoad` is an optional element. The default value is `false`.

## Example
 The following example illustrates the metadata for a Visual C# template.

```xml
<VSTemplate Type="Project" Version="3.0.0"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>My template</Name>
        <Description>A basic template</Description>
        <Icon>TemplateIcon.ico</Icon>
        <ProjectType>CSharp</ProjectType>
        <BuildProjectOnload>true</BuildProjectOnLoad>
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

- [BuildOnLoad attribute and element](buildonload-visual-studio-templates.md)
- [Creating project and item templates](../ide/creating-project-and-item-templates.md)
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
