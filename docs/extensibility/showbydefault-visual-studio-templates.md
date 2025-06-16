---
title: ShowByDefault element (Visual Studio Templates)
description: Learn about the ShowByDefault element and how, when set to false, it specifies that the template will only be displayed under the specified TemplateGroupID.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#ShowByDefault
helpviewer_keywords:
- <ShowByDefault> element [Visual Studio Templates]
- ShowByDefault element [Visual Studio Templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# ShowByDefault element (Visual Studio Templates)

If `false`, specifies that the template will only be displayed under the specified [TemplateGroupID](../extensibility/templategroupid-element-visual-studio-templates.md).

 \<VSTemplate>
 \<TemplateData>
 \<ShowByDefault>

## Syntax

```
<ShowByDefault> true/false </ShowByDefault>
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
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|

## Text Value
 A text value is required.

 The text must be either `true` or `false`. If true, specifies that the template will be displayed for all project types. If false, the template will only be displayed under the specified `TemplateGroupID`.

## Remarks
 `ShowByDefault` is an optional element. The default value is `true`.

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
        <ShowByDefault>false</ShowByDefault>
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
- [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
- [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
- [TemplateGroupID Element (Visual Studio Templates)](../extensibility/templategroupid-element-visual-studio-templates.md)
