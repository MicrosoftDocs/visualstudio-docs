---
title: TemplateContent Element (Visual Studio Templates)
description: Learn about the TemplateContent element and how it specifies the contents of the template.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#TemplateContent
helpviewer_keywords:
- TemplateContent element [Visual Studio project templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# TemplateContent Element (Visual Studio Templates)

Specifies the contents of the template.

Element hierarchy:

```xml
<VSTemplate>
  <TemplateContent>
```

## Syntax

```xml
<TemplateContent>
    ...
</TemplateContent>
```

## Attributes and Elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|[BuildOnLoad](../extensibility/buildonload-visual-studio-templates.md)|Specifies whether to build the solution when a project is created from the template.|

### Child Elements

|Element|Description|
|-------------|-----------------|
|[ProjectCollection](../extensibility/projectcollection-element-visual-studio-templates.md)|Optional element.<br /><br /> Specifies the organization and contents of multi-project templates.|
|[Project](../extensibility/project-element-visual-studio-templates.md)|Optional element.<br /><br /> Specifies files or directories to add to the project.|
|[References](../extensibility/references-element-visual-studio-templates.md)|Optional element.<br /><br /> Specifies the assembly references required for an item template.|
|[ProjectItem](../extensibility/projectitem-element-visual-studio-item-templates.md)|Optional element.<br /><br /> Specifies a file contained in the template.|
|[CustomParameters](../extensibility/customparameters-element-visual-studio-templates.md)|Optional element.<br /><br /> Specifies any custom parameters that are to be used when a project or item  is created from the template.|

### Parent Elements

|Element|Description|
|-------------|-----------------|
|[VSTemplate](../extensibility/vstemplate-element-visual-studio-templates.md)|Required element.<br /><br /> Contains all the metadata for the project template, item template, or starter kit.|

## Remarks
 `TemplateContent` is a required element.

## Example
 The following example shows the metadata for a project template for a Visual C# application.

```xml
<VSTemplate Type="Project" Version="3.0.0"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>My template</Name>
        <Description>A basic starter kit</Description>
        <Icon>TemplateIcon.ico</Icon>
        <ProjectType>CSharp</ProjectType>
    </TemplateData>
    <TemplateContent>
        <Project File="MyStarterKit.csproj">
            <ProjectItem>Form1.cs</ProjectItem>
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

- [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
- [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
