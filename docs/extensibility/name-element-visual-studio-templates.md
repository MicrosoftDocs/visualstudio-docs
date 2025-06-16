---
title: Name Element (Visual Studio Templates)
description: Learn about the Name element and how it specifies the name of the template as it appears in the New Project or Add New Item dialog box.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#Name
helpviewer_keywords:
- Name element [Visual Studio project templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# Name element (Visual Studio templates)

Specifies the name of the template as it appears in the **New Project** or **Add New Item** dialog box.

 \<VSTemplate>
 \<TemplateData>
 \<Name>

## Syntax

```xml
<Name> Template Name </Name>
```

```xml
<Name Package="{PackageID}" ID="ResourceID" />
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`Package`|Optional attribute, for advanced user scenarios.<br /><br /> A GUID that specifies the Visual Studio package ID.|
|`ID`|Optional attribute, for advanced user scenarios.<br /><br /> Specifies the Visual Studio resource ID.|

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Required element.<br /><br /> Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|

## Text value
 A text value is required unless the `Package` and `ID` attributes are used.

 The text provides the name of the template.

## Remarks
 `Name` is a required child element of `TemplateData`.

## Example
 The following example shows the metadata for a project template for a Visual C# application.

```xml
<VSTemplate Type="Project" Version="3.0.0"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>My template</Name>
        <Description>A basic template</Description>
        <Icon>TemplateIcon.ico</Icon>
        <ProjectType>CSharp</ProjectType>
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
