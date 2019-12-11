---
title: "VSTemplate Element (Visual Studio Templates) | Microsoft Docs"
ms.date: "11/04/2016"
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords:
  - "http://schemas.microsoft.com/developer/vstemplate/2005#VSTemplate"
helpviewer_keywords:
  - "VSTemplate element [Visual Studio project templates]"
ms.assetid: f8ac561b-3b0b-4246-9ec9-118d2447e9a9
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# VSTemplate element (Visual Studio Templates)
Contains all the metadata about the project template, item template, or starter kit.

## Syntax

```csharp
<VSTemplate Type="TemplateType" Version="x.x.x">
    <TemplateData>    </TemplateData>
    <TemplateContent>    </TemplateContent>
    ...
</VSTemplate>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

| Attribute | Description |
|-----------| - |
| `Type` | Identifies the template as a project template or an item template. This attribute can have a value of `Project` or `Item`. |
| `Version` | Specifies a version number for the template. Templates in [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] and [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)] have a `Version` attribute value of `3.0.0`. |

### Child elements

|Element|Description|
|-------------|-----------------|
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Required element.<br /><br /> Specifies data that categorizes the template, and defines how it displays in the **New Project** or **Add New Item** dialog box.|
|[TemplateContent](../extensibility/templatecontent-element-visual-studio-templates.md)|Required element.<br /><br /> Specifies the contents of the template.|
|[WizardExtension](../extensibility/wizardextension-element-visual-studio-templates.md)|Optional element.|
|[WizardData](../extensibility/wizarddata-element-visual-studio-templates.md)|Optional element.|

### Parent elements
 None.

## Remarks
 The `VSTemplate` element is the root element of *.vstemplate* files.

## Example
 The following example shows the metadata for a project template for a [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] application.

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
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
- [Creating project and item templates](../ide/creating-project-and-item-templates.md)