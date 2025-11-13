---
title: ProjectCollection Element (Visual Studio Templates)
description: Learn about the ProjectCollection element and how it specifies the organization and contents of multi-project templates.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#ProjectCollection
helpviewer_keywords:
- <ProjectCollection> element [Visual Studio Templates]
- ProjectCollection element [Visual Studio Templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# ProjectCollection element (Visual Studio templates)

Specifies the organization and contents of multi-project templates.

 \<VSTemplate>
 \<TemplateContent>
 \<ProjectCollection>

## Syntax

```xml
<ProjectCollection>
    <ProjectTemplateLink> ... </ProjectTemplateLink>
    <SolutionFolder> ... </SolutionFolder>
</ProjectCollection>
```

## Attributes and elements
 The following sections describe attribute, child elements, and parent elements.

### Attributes
 None.

### Child elements

|Element|Description|
|-------------|-----------------|
|[ProjectTemplateLink](../extensibility/projecttemplatelink-element-visual-studio-templates.md)|Optional element.<br /><br /> Specifies a project in a multi-project template.|
|[SolutionFolder](../extensibility/solutionfolder-element-visual-studio-templates.md)|Optional element.<br /><br /> Groups projects in multi-project templates.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[TemplateContent](../extensibility/templatecontent-element-visual-studio-templates.md)|Required element.<br /><br /> Specifies the contents of the template.|

## Remarks
 Multi-project templates act as containers for two or more projects. The `ProjectCollection` element is used to specify the projects to contain in the template. For more information on multi-project templates, see [How to: Create multi-project templates](../ide/how-to-create-multi-project-templates.md).

## Example
 This example shows a simple multi-project root *.vstemplate* file. In this example, the template contains two projects, `My Windows Application` and `My Class Library`. The `ProjectName` attribute on the `ProjectTemplateLink` element sets the name for Visual Studio to assign this project. If the `ProjectName` attribute does not exist, the name of the *.vstemplate* file is used as the project name.

```
<VSTemplate Version="3.0.0" Type="ProjectGroup"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>Multi-Project Template Sample</Name>
        <Description>An example of a multi-project template</Description>
        <Icon>Icon.ico</Icon>
        <ProjectType>VisualBasic</ProjectType>
    </TemplateData>
    <TemplateContent>
        <ProjectCollection>
            <ProjectTemplateLink ProjectName="My Windows Application">
                WindowsApp\MyTemplate.vstemplate
            </ProjectTemplateLink>
            <ProjectTemplateLink ProjectName="My Class Library">
                ClassLib\MyTemplate.vstemplate
            </ProjectTemplateLink>
        </ProjectCollection>
    </TemplateContent>
</VSTemplate>
```

## See also
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
- [Create project and item templates](../ide/creating-project-and-item-templates.md)
- [How to: Create multi-project templates](../ide/how-to-create-multi-project-templates.md)
