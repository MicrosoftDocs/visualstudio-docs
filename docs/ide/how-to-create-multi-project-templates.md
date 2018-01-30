---
title: "Create multi-project templates for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "01/02/2018"
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

Multi-project templates act as containers for two or more projects. When you create a project that is based on a multi-project template from the **New Project** dialog box, every project in the template is added to the solution.

A multi-project template contains two or more project templates, and a root template of type `ProjectGroup`.

Multi-project templates behave differently than single project templates. They have the following unique characteristics:

- Individual projects in a multi-project template cannot be assigned names in the **New Project** dialog box. Instead, use the `ProjectName` attribute on the `ProjectTemplateLink` element in the .vstemplate file to specify a name for each project.

- Multi-project templates can contain projects for different languages, but the entire template itself can only be put in one category. Specify the template category in the `ProjectType` element of the .vstemplate file.

A multi-project template must include the following items, compressed into a .zip file:

- A root .vstemplate file for the entire multi-project template. This root .vstemplate file contains metadata that the **New Project** dialog box displays, and specifies where to find the .vstemplate files for the projects in the template. This file must be located at the root of the .zip file.

- Two or more folders that contain the files that are required for a complete project template. This includes all code files for the project, and also a .vstemplate file for the project.

For example, a multi-project template .zip file that has two projects could have the following files and directories:

- MultiProjectTemplate.vstemplate
- \Project1\Project1.vstemplate
- \Project1\Project1.vbproj
- \Project1\Class.vb
- \Project2\Project2.vstemplate
- \Project2\Project2.vbproj
- \Project2\Class.vb

The root .vstemplate file for a multi-project template differs from a single-project template in the following ways:

- The `Type` attribute of the `VSTemplate` element has the value `ProjectGroup` instead of `Project`. For example:

    ```xml
    <VSTemplate Version="2.0.0" Type="ProjectGroup"
        xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    ```

- The `TemplateContent` element contains a `ProjectCollection` element that has one or more `ProjectTemplateLink` elements that define the paths to the .vstemplate files of the included projects. For example:

    ```xml
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

## To create a multi-project template from an existing solution

1. Create a solution and add two or more projects.

1. Customize the projects until they are ready to be exported to a template.

1. On the **Project** menu, choose **Export Template...**.

   The **Export Template Wizard** opens.

1. On the **Choose Template Type** page, select **Project Template**. Select the project you want to export to a template, and then choose **Next**.

1. On the **Select Template Options** page, enter a name and optional description, icon, and preview image for your template. Choose **Finish**.

   The project is exported into a .zip file and placed in the specified output location.

   > [!NOTE]
   > Each project must be exported to a template separately, so repeat the preceding steps for each project in the solution.

1. Create a directory for your template, with a subdirectory for each project.

1. Extract the contents of each project's .zip file into the corresponding subdirectory that you just created.

1. In the base directory, create an XML file with a **.vstemplate** file extension. This file contains the metadata for the multi-project template. See the example that follows for the structure of the file. Be sure to specify the relative path to each project's .vstemplate file.

1. Select the base directory, and from the right-click or context menu, choose **Send to** > **Compressed (zipped) folder**.

   The files and folders are compressed into a .zip file.

1. Copy the .zip file into the user project template directory. By default, this directory is %USERPROFILE%\Documents\Visual Studio \<version\>\Templates\ProjectTemplates.

1. In Visual Studio, open the **New Project** dialog box and verify that your template appears.

## Two-project example

This example shows a basic multi-project root .vstemplate file. In this example, the template contains two projects, `My Windows Application` and `My Class Library`. The `ProjectName` attribute on the `ProjectTemplateLink` element specifies the name that is given to the project.

> [!TIP]
> If the `ProjectName` attribute is not specified, the name of the .vstemplate file is used as the project name.

```xml
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

```xml
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

[Creating project and item templates](../ide/creating-project-and-item-templates.md)  
[How to: Create project templates](../ide/how-to-create-project-templates.md)  
[Visual Studio template schema reference (extensibility)](../extensibility/visual-studio-template-schema-reference.md)  
[SolutionFolder element (Visual Studio templates)](../extensibility/solutionfolder-element-visual-studio-templates.md)  
[ProjectTemplateLink element (Visual Studio templates)](../extensibility/projecttemplatelink-element-visual-studio-templates.md)
