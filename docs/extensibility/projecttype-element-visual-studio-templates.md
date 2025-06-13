---
title: ProjectType Element (Visual Studio Templates)
description: Learn about the ProjectType element and how it categorizes the project template so that it appears in the New Project or Add New Item dialog box.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#ProjectType
helpviewer_keywords:
- ProjectType element [Visual Studio project templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# ProjectType element (Visual Studio templates)

Categorizes the project template so that it appears under the specified group in the **New Project** or **Add New Item** dialog box.

> [!WARNING]
> Project templates are supported for C++ starting in Visual Studio 2012. They are not supported for C++ in Visual Studio 2010 and earlier versions.

 \<VSTemplate>
 \<TemplateData>
 \<ProjectType>

## Syntax

```xml
<ProjectType> CSharp/VisualBasic/VC/Web </ProjectType>
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
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|

## Text value
 A text value is required.

 This value specifies the type of project the template will create, and must contain one of the following values:

- `CSharp`: Specifies that the template creates a Visual C# project or item.

- `VisualBasic`: Specifies that the template creates a Visual Basic project or item.

- `Web`: Specifies that the template creates a Web project or item. If the `ProjectType` element contains this value, the language of the project or item is defined in the [ProjectSubType Element (Visual Studio Templates)](../extensibility/projectsubtype-element-visual-studio-templates.md).

## Remarks
 `ProjectType` is a required child element of `TemplateData`.

 The value of the `ProjectType` element specifies where the template is located in the **New Project** or **Add New Item** dialog box. For example, a template with a `ProjectType` value of `CSharp` appears under the **Visual C#** node in the **New Project** dialog box.

 A template subtype can be specified by using the [ProjectSubType](../extensibility/projectsubtype-element-visual-studio-templates.md) element.

## Example
 The following example shows the metadata for a project template for a Visual C# application.

```
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
- [Create project and item templates](../ide/creating-project-and-item-templates.md)
- [ProjectSubType element (Visual Studio templates)](../extensibility/projectsubtype-element-visual-studio-templates.md)
