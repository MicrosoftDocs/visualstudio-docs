---
title: ProjectTemplateLink Element (Visual Studio Templates)
description: Learn about the <element> element and how it specifies the path to the .vstemplate file of one project in a multi-project template.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#ProjectTemplateLink
helpviewer_keywords:
- <ProjectTemplateLink> element [Visual Studio Templates]
- ProjectTemplateLink element [Visual Studio Templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# ProjectTemplateLink element (Visual Studio templates)

Specifies the path to the *.vstemplate* file of one project in a multi-project template.

 \<VSTemplate>
 \<TemplateContent>
 \<ProjectCollection>
 \<ProjectTemplateLink>

  -or-

\<VSTemplate>
 \<TemplateContent>
 \<ProjectCollection>
 \<SolutionFolder>
 \<ProjectTemplateLink>

## Syntax

```xml
<ProjectTemplateLink ProjectName="Name">
    PathToTemplateFile
</ProjectTemplateLink>
```

## Attributes and elements
 The following sections describe attribute, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`ProjectName`|Optional attribute.<br /><br /> Specifies the name for each individual project in a multi-project template. The **New Project** dialog box cannot assign names to individual projects.|
|`CopyParameters`|Enables all the variables in the main group template to be copied to each of the linked templates.<br /><br /> The parameters in the linked templates have a prefix `"$ext_*$"`. For example, if in the parent group template the parameter `$projectname$` has a value **ExampleProject1**, when the linked template gets its turn to be executed, it acquires a parameter `$ext_projectname$`, which is a copy of the `$projectname$` parameter from the parent group template.<br /><br /> This enables linked templates to share some common parameters, which may be conveniently created only in the parent group template.<br /><br /> This attribute is optional, and it automatically defaults to `false` when it is not included.<br /><br /> Introduced in Visual Studio 2013 Update 2. To reference the correct product version, see [Reference assemblies delivered in the Visual Studio 2013 SDK Update 2](/previous-versions/dn632168(v=vs.120)).|

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[ProjectCollection](../extensibility/projectcollection-element-visual-studio-templates.md)|Specifies the organization and contents of multi-project templates.|
|[SolutionFolder](../extensibility/solutionfolder-element-visual-studio-templates.md)|Groups projects in multi-project templates.|

## Text value
 A text value is required.

 This text specifies the path to the *.vstemplate* file of the template.

## Remarks
 Multi-project templates act as containers for two or more projects. The `ProjectTemplateLink` element is used to specify the location of the *.vstemplate* file for one of the projects in the template. The *.vstemplate* file of a multi-project template contains one `ProjectTemplateLink` element for each project in the template. For more information on multi-project templates, see [How to: Create multi-project templates](../ide/how-to-create-multi-project-templates.md).

## Example
 This example shows a simple multi-project root *.vstemplate* file. In this example, the template contains two projects, `My Windows Application` and `My Class Library`. The `ProjectName` attribute on the `ProjectTemplateLink` element sets the name for Visual Studio to assign this project. If the `ProjectName` attribute doesn't exist, the name of the *.vstemplate* file is used as the project name.

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
            <ProjectTemplateLink ProjectName="My Class Library" CopyParameters="true">
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