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
# How to: Create Multi-Project Templates

Multi-project templates act as containers for two or more projects. When a project based on a multi-project template is created from the **New Project** dialog box, every project in the template is added to the solution.

A multi-project template contains two or more project templates, and a root template of type `ProjectGroup`.

Multi-project templates behave differently than single project templates. They have the following unique characteristics:

- Individual projects in a multi-project template cannot be assigned names in the **New Project** dialog box. Instead, use the `ProjectName` attribute on the `ProjectTemplateLink` element to specify a name for each project.

- Multi-project templates can contain projects for different languages, but the entire template itself can only be put in one category. Specify the template category in the `ProjectType` element.

A multi-project template must include the following items, compressed into a .zip file:

- A root .vstemplate file for the entire multi-project template. This root .vstemplate file contains metadata that the **New Project** dialog box displays, and specifies where to find the .vstemplate files for the projects in the template. This file must be located at the root of the .zip file.

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

## To create a multi-project template from an existing solution

1. Create a solution and add two or more projects.

    > [!NOTE]
    > Use only valid identifier characters when naming a project that will be the source for a template. Otherwise, compilation errors can occur in projects that are created from the template. For more information about valid identifier characters, see [Declared element names (Visual Basic)](/dotnet/visual-basic/programming-guide/language-features/declared-elements/declared-element-names) or [Identifiers (C++)](/cpp/cpp/identifiers-cpp). Alternatively, you can use [template parameters](../ide/template-parameters.md) to use "safe" names for classes and namespaces.

1. Edit the projects until they are ready to be exported as a template. For example, you might want to edit code files to indicate where parameter replacement should take place. See [How to: Substitute parameters in a template](../ide/how-to-substitute-parameters-in-a-template.md).

1. On the **Project** menu, choose **Export Template...**.

   The **Export Template Wizard** opens.

1. Choose **Project Template**.

1. Select the projects you want to export to a template, then choose **Next**.

1. Select an icon and a preview image for your template. These will appear in the **New Project** dialog box.

1. Enter a template name and description, then choose **Finish**.

   Your project is exported into a .zip file and placed in the specified output location, and, if selected, imported into Visual Studio.

1. Extract the .vstemplate file from the generated zip file into the same directory as the project file that was used to export the template.

1. Create a root .vstemplate file that contains the metadata for the multi-project template. For more information, see the example that follows.

1. Select the files and folders to include in your template, right-click the selection, choose **Send To** and then **Compressed (zipped) Folder**.

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

[Creating project and item templates](../ide/creating-project-and-item-templates.md)  
[How to: Create project templates](../ide/how-to-create-project-templates.md)  
[Visual Studio template schema reference (extensibility)](../extensibility/visual-studio-template-schema-reference.md)  
[SolutionFolder element (Visual Studio templates)](../extensibility/solutionfolder-element-visual-studio-templates.md)  
[ProjectTemplateLink element (Visual Studio templates)](../extensibility/projecttemplatelink-element-visual-studio-templates.md)
