---
title: "PromptForSaveOnCreation Element (Visual Studio Templates) | Microsoft Docs"
ms.date: "11/04/2016"
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords:
  - "http://schemas.microsoft.com/developer/vstemplate/2005#PromptForSaveOnCreation"
helpviewer_keywords:
  - "PromptForSaveOnCreation element [Visual Studio project templates]"
ms.assetid: 75174674-0c3c-4b57-b2fd-6ea8e817b67d
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
monikerRange: vs-2017
---
# PromptForSaveOnCreation element (Visual Studio templates)

Specifies whether the user is prompted for a project save location via the **New Project** dialog box when creating a project. If this element is set to `true`, then the user is prompted for a save location. If `false`, then they are not prompted (that is, a temporary project is created).

```xml
\<VSTemplate>
\<TemplateData>
\<PromptForSaveOnCreation>
```

## Syntax

```xml
<PromptForSaveOnCreation> true/false </PromptForSaveOnCreation>
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

 The text must be either `true` or `false`, `true` indicating that the user will be prompted for a save location when creating a new project.

## Remarks
 `PromptForSaveOnCreation` is an optional element. The default value is `false`.

 Temporary projects are projects that you can create and modify without saving the contents of that project on disk.

## Example
 The following example sets the value of `PromptForSaveOnCreation` equal to `false`, which specifies to allow the project to be created as a temporary project.

```xml
<VSTemplate Type="Project" Version="3.0.0"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>My template</Name>
        <Description>A basic template</Description>
        <Icon>TemplateIcon.ico</Icon>
        <ProjectType>CSharp</ProjectType>
        <PromptForSaveOnCreation>false</PromptForSaveOnCreation>
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
- [Create project and item templates](../ide/creating-project-and-item-templates.md)