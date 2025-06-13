---
title: Folder Element (Visual Studio Project Templates)
description: Learn about the Folder element and how it specifies a folder that will be added to the project.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#Folder
helpviewer_keywords:
- Folder element [Visual Studio project templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# Folder element (Visual Studio project templates)

Specifies a folder that will be added to the project.

 \<VSTemplate>
 \<TemplateContent>
 \<Project>
 \<Folder>

## Syntax

```
<Folder Name="Project Folder">
    <Folder> ... </Folder>
    <ProjectItem> ... </ProjectItem>
</Folder>
```

## Attributes and elements
 The following sections describe attribute, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`Name`|Required attribute.<br /><br /> The name of the project folder.|
|`TargetFolderName`|Optional attribute.<br /><br /> Specifies the name to give the folder when a project is created from the template. This attribute is useful for using parameter replacement to create a folder name or naming a folder with an international string that cannot be used directly in the *.zip* file.|

### Child elements

|Element|Description|
|-------------|-----------------|
|`Folder`|Specifies a folder to add to the project. `Folder` elements can contain child `Folder` elements.|
|[ProjectItem](../extensibility/projectitem-element-visual-studio-item-templates.md)|Specifies a file to add to the project.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Project](../extensibility/project-element-visual-studio-templates.md)|Optional child element of [TemplateContent](../extensibility/templatecontent-element-visual-studio-templates.md).|

## Remarks
 `Folder` is an optional child of `Project`.

 You can use any of the following methods to organize project items into folders in a template:

- Include the folders in the template *.zip* file, and add them to the project in the *.vstemplate* file by specifying the path to the file in the `ProjectItem` elements, with no `Folder` elements. This is the recommended method. For example:

     `...`

     `<ProjectItem>\Folder\item.cs</ProjectItem>`

     `<ProjectItem>Form1.cs</ProjectItem>`

     `...`

- Include the folders in the template *.zip* file, and add them to the project in the *.vstemplate* file with `Folder` elements. For example:

     `...`

     `<Folder name="Folder">`

     `<ProjectItem>item.cs</ProjectItem>`

     `</Folder>`

     `<ProjectItem>Form1.cs</ProjectItem>`

     `...`

- Do not include folders in the template *.zip* file, but add folders using the `TargetFileName` attribute of the `ProjectItem` element. For example:

     `...`

     `<ProjectItem TargetFileName="\Folder\item.cs">item.cs</ProjectItem>`

     `<ProjectItem>Form1.cs</ProjectItem>`

     `...`

## Example
 The following example illustrates the metadata for a project template for a Visual C# Windows application.

```
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
            <Folder Name="Properties">
                <ProjectItem>AssemblyInfo.cs</ProjectItem>
                <ProjectItem>Resources.resx</ProjectItem>
                <ProjectItem>Resources.Designer.cs</ProjectItem>
                <ProjectItem>Settings.settings</ProjectItem>
                <ProjectItem>Settings.Designer.cs</ProjectItem>
            </Folder>
        </Project>
    </TemplateContent>
</VSTemplate>
```

## See also
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
- [Creating project and item templates](../ide/creating-project-and-item-templates.md)
- [ProjectItem element (Visual Studio item templates)](../extensibility/projectitem-element-visual-studio-item-templates.md)
