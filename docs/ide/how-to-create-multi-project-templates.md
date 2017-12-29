---
title: "Create multi-project templates for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio templates, creating multi-project"
  - "project templates, multi-project"
  - "multi-project templates"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
---
# How to: Create multi-project templates

Multi-project templates act as containers for two or more projects. When a project is created from a multi-project template, every project in the template is added to the solution.

A multi-project template must include the following items, compressed into a .zip file:

- A root .vstemplate file for the entire multi-project template. This root .vstemplate file contains the metadata that the **New Project** dialog box displays, and specifies where to find the .vstemplate files for the projects in this template. This file must be located at the root of the .zip file.

- One or more folders that contain the files that are required for a complete project template. This includes all code files for the project, and also a .vstemplate file for the project.

For example, a multi-project template .zip file that has two projects could have the following files and directories:

MultiProjectTemplate.vstemplate

\Project1\Project1.vstemplate

\Project1\Project1.vbproj

\Project1\Class.vb

\Project2\Project2.vstemplate

\Project2\Project2.vbproj

\Project2\Class.vb

The root .vstemplate file for a multi-project template differs from a single-project template in the following ways:

- The `Type` attribute of the `VSTemplate` element contains the value `ProjectGroup`. For example:

    ```
    <VSTemplate Version="2.0.0" Type="ProjectGroup"
        xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    ```

- The `TemplateContent` element contains a `ProjectCollection` element that has one or more `ProjectTemplateLink` elements that define the paths to the .vstemplate files of the included projects. For example:

    ```
    <TemplateContent>
        <ProjectCollection>
            <ProjectTemplateLink>
                Project1\Project1.vstemplate
            </ProjectTemplateLink>
            <ProjectTemplateLink>
                Project2\Project2.vstemplate
            </ProjectTemplateLink>
        </ProjectCollection>
    </TemplateContent>
    ```

Multi-project templates also behave differently than normal templates. Multi-project templates have the following unique characteristics:

- Individual projects in a multi-project template cannot be assigned names by the **New Project** dialog box. Instead, use the `ProjectName` attribute on the `ProjectTemplateLink` element to specify the name for each project. For more information, see the first example in the section that follows.

- Multi-project templates can contain projects for different languages, but the entire template itself can only be put in one category by using the `ProjectType` element.

## To create a multi-project template

1. Create the projects to include in the multi-project template.

1. Create .vstemplate files for every project. For more information, see [How to: Create Project Templates](../ide/how-to-create-project-templates.md).

1. Create a root .vstemplate file that csontain the metadata for the multi-project template. For more information, see the example that follows.

1. Select the files and folders to include in your template, right-click the selection, click **Send To**, and then click **Compressed (zipped) Folder**.

   The files and folders are compressed into a .zip file.

1. Put the .zip template file in the Visual Studio project template directory. By default, this directory is %USERPROFILE%\Documents\Visual Studio <version>\Templates\ProjectTemplates\\.

## Two-project example

This example shows a basic multi-project root .vstemplate file. In this example, the template contains two projects, `My Windows Application` and `My Class Library`. The `ProjectName` attribute on the `ProjectTemplateLink` element specifies the name that is given to the project.

> [!TIP]
> If the `ProjectName` attribute is not specified, the name of the .vstemplate file is used as the project name.

```
<VSTemplate Version="2.0.0" Type="ProjectGroup"
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

## Example with solution folders

This example uses the `SolutionFolder` element to divide the projects into two groups, `Math Classes` and `Graphics Classes`. The template contains four projects, two of which are placed in each solution folder.

```
<VSTemplate Version="2.0.0" Type="ProjectGroup"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>Multi-Project Template Sample</Name>
        <Description>An example of a multi-project template</Description>
        <Icon>Icon.ico</Icon>
        <ProjectType>VisualBasic</ProjectType>
    </TemplateData>
    <TemplateContent>
        <ProjectCollection>
            <SolutionFolder Name="Math Classes">
                <ProjectTemplateLink ProjectName="MathClassLib1">
                    MathClassLib1\MyTemplate.vstemplate
                </ProjectTemplateLink>
                <ProjectTemplateLink ProjectName="MathClassLib2">
                    MathClassLib2\MyTemplate.vstemplate
                </ProjectTemplateLink>
            </SolutionFolder>
            <SolutionFolder Name="Graphics Classes">
                <ProjectTemplateLink ProjectName="GraphicsClassLib1">
                    GraphicsClassLib1\MyTemplate.vstemplate
                </ProjectTemplateLink>
                <ProjectTemplateLink ProjectName="GraphicsClassLib2">
                    GraphicsClassLib2\MyTemplate.vstemplate
                </ProjectTemplateLink>
            </SolutionFolder>
        </ProjectCollection>
    </TemplateContent>
</VSTemplate>
```

## See also

[Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)  
[Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)  
[How to: Create Project Templates](../ide/how-to-create-project-templates.md)  
[Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)  
[SolutionFolder Element (Visual Studio Templates)](../extensibility/solutionfolder-element-visual-studio-templates.md)  
[ProjectTemplateLink Element (Visual Studio Templates)](../extensibility/projecttemplatelink-element-visual-studio-templates.md)