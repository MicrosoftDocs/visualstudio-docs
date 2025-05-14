---
title: Create multi-project templates
description: Create multi-project templates in Visual Studio that can act as containers for many projects at the same time and containers for projects of different languages.
ms.date: 04/01/2025
ms.topic: how-to
helpviewer_keywords:
- Visual Studio templates, creating multi-project
- project templates, multi-project
- multi-project templates
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Create multi-project templates

Multi-project templates act as containers for two or more Visual Studio projects. When you create a project that's based on a multi-project template, every project in the template is added to the solution.

> [!NOTE]
> The templates discussed in this article are the ones used when you create projects in Visual Studio, not the ones that `dotnet new` creates.

A multi-project template has two or more project templates and a root template of type **ProjectGroup**.

Multi-project templates behave differently than single project templates. They have the following unique characteristics:

- Individual projects in a multi-project template cannot be assigned names when the template is used to create a new project. Instead, use the **ProjectName** attribute on the **ProjectTemplateLink** element in the *vstemplate* file to specify a name for each project.

- Multi-project templates can contain projects for different languages, but the entire template itself can only be put in one category. Specify the template category in the **ProjectType** element of the *vstemplate* file.

A multi-project template must include the following items, compressed into a *.zip* file:

- A root *vstemplate* file for the entire multi-project template. This root *vstemplate* file contains metadata that's displayed in the dialog box where you create a new project. It also specifies where to find the *vstemplate* files for the projects in the template. This file must be located at the root of the *.zip* file.

- Two or more folders that contain the files that are required for a complete project template. The folders include all code files for the project, and also a *vstemplate* file for the project.

For example, a multi-project template *.zip* file that has two projects could have the following files and directories:

- *MultiProjectTemplate.vstemplate*
- *\Project1\MyTemplate.vstemplate*
- *\Project1\Project1.vbproj*
- *\Project1\Class.vb*
- *\Project2\MyTemplate.vstemplate*
- *\Project2\Project2.vbproj*
- *\Project2\Class.vb*

The root *vstemplate* file for a multi-project template differs from a single-project template in the following ways:

- The **Type** attribute of the **VSTemplate** element has the value **ProjectGroup** instead of **Project**. For example:

    ```xml
    <VSTemplate Version="2.0.0" Type="ProjectGroup"
        xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    ```

- The **TemplateContent** element contains a **ProjectCollection** element that has one or more **ProjectTemplateLink** elements that define the paths to the *vstemplate* files of the included projects. For example:

    ```xml
    <TemplateContent>
        <ProjectCollection>
            <ProjectTemplateLink>
                Project1\MyTemplate.vstemplate
            </ProjectTemplateLink>
            <ProjectTemplateLink>
                Project2\MyTemplate.vstemplate
            </ProjectTemplateLink>
        </ProjectCollection>
    </TemplateContent>
    ```

> [!TIP]
> If you only want the multi-project template to appear in the new project dialog box and not the individual projects it contains, mark the inner templates as [hidden](../extensibility/hidden-element-visual-studio-templates.md). For example:
>
> ```xml
> <VSTemplate Type="Project" ... >
>     <TemplateData>
>         ...
>         <Hidden>true</Hidden>
>     </TemplateData>
>     ...
> </VSTemplate>
> ```

## Create a multi-project template from an existing solution

1. Create a solution and add two or more projects.

2. Customize the projects until they are ready to be exported to a template.

   > [!TIP]
   > If you're using [template parameters](template-parameters.md) and you want to refer to variables from the parent template, prefix the name of the parameter with `ext_`. For example, `$ext_safeprojectname$`. Also, set the **CopyParameters** attribute of the **ProjectTemplateLink** element to **true**.
   >
   > ```xml
   > <ProjectTemplateLink ProjectName="MyProject" CopyParameters="true">...</ProjectTemplateLink>
   > ```

3. On the **Project** menu, choose **Export Template**.

   The **Export Template Wizard** opens.

4. On the **Choose Template Type** page, select **Project Template**. Select one of the projects that you want to export to a template, and then choose **Next**. (You'll repeat these steps for each project in the solution.)

5. On the **Select Template Options** page, enter a name and optional description, icon, and preview image for your template. Choose **Finish**.

   The project is exported into a *.zip* file and placed in the specified output location.

   > [!NOTE]
   > Each project must be exported to a template separately, so repeat the preceding steps for each project in the solution.

6. Create a directory for your template, with a subdirectory for each project.

7. Extract the contents of each project's *.zip* file into the corresponding subdirectory that you created.

8. In the base directory, create an XML file with a *.vstemplate* file extension. This file contains the metadata for the multi-project template. See the example that follows for the structure of the file. Be sure to specify the relative path to each project's *vstemplate* file.

9. Select all the files in the base directory, and from the right-click or context menu, choose **Send to** > **Compressed (zipped) folder**.

   The files and folders are compressed into a *.zip* file.

10. Copy the *.zip* file into the user project template directory. By default, this directory is *%USERPROFILE%\Documents\Visual Studio \<version\>\Templates\ProjectTemplates*.

11. In Visual Studio, choose **File** > **New** > **Project** and verify that your template appears.

## Two-project example

This example shows a basic multi-project root *vstemplate* file. In this example, the template has two projects, **My Windows Application** and **My Class Library**. The **ProjectName** attribute on the **ProjectTemplateLink** element specifies the name that is given to the project.

> [!TIP]
> If the **ProjectName** attribute is not specified, the name of the *vstemplate* file is used as the project name.

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

This example uses the **SolutionFolder** element to divide the projects into two groups, **Math Classes** and **Graphics Classes**. The template has four projects, two of which are placed in each solution folder.

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

## Example with project references

This example shows how to add project references to a multi-project template and is essentially an extension of the [multi-project template](#create-multi-project-templates) example.

In this example the solution contains two projects, **MultiProject.Client** and **MultiProject.Shared**. The project **MultiProject.Client** references **MultiProject.Shared**.

The folder structure is as follows:

- *MultiProjectTemplate.vstemplate*
- *\MultiProject.Client\MultiProject.Client.csproj*
- *\MultiProject.Client\MyTemplate.vstemplate*
- *\MultiProject.Shared\MultiProject.Shared.csproj*
- *\MultiProject.Shared\MyTemplate.vstemplate*

When the template is used the *MultiProject* part is being replaced with the project name the user enters.

The *MultiProjectTemplate.vstemplate* looks like the following. Please note that the *ProjectTemplateLink*s have the attribute **CopyParameters** set to *true* and that the **ProjectName** attributes use the template variable [\$safeprojectname\$](./template-parameters.md#reserved-template-parameters).

```xml
<VSTemplate Version="2.0.0" Type="ProjectGroup"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
...
<TemplateContent>
    <ProjectCollection>
        <ProjectTemplateLink ProjectName="$safeprojectname$.Client" CopyParameters="true">
            MultiProject.Client\MyTemplate.vstemplate
        </ProjectTemplateLink>
        <ProjectTemplateLink ProjectName="$safeprojectname$.Shared" CopyParameters="true">
            MultiProject.Shared\MyTemplate.vstemplate
        </ProjectTemplateLink>
    </ProjectCollection>
</TemplateContent>
</VSTemplate>
```

The *MultiProject.Client\MyTemplate.vstemplate* might look something like the following. Please note that the *Project* tag has the attribute **ReplaceParameters** set to *true*.

```xml
<VSTemplate Version="3.0.0" xmlns="http://schemas.microsoft.com/developer/vstemplate/2005" Type="Project">
	...
	<TemplateContent>
		<Project TargetFileName="MultiProject.Client.csproj" File="MultiProject.Client.csproj" ReplaceParameters="true">
            ...
		</Project>
	</TemplateContent>
</VSTemplate>
```

The *MultiProject.Client\MultiProject.Client.csproj* might look something like the following. Please note that the attribute **Include** of the *ProjectReference* uses the template variable [\$ext_safeprojectname\$](./template-parameters.md#reserved-template-parameters)

```xml
<Project>
    ...
	<ItemGroup>
	  <ProjectReference Include="..\$ext_safeprojectname$.Shared\$ext_safeprojectname$.Shared.csproj" />
	</ItemGroup>
</Project>
```

## Related content

- [Creating project and item templates](../ide/creating-project-and-item-templates.md)
- [How to: Create project templates](../ide/how-to-create-project-templates.md)
- [Visual Studio template schema reference (extensibility)](../extensibility/visual-studio-template-schema-reference.md)
- [SolutionFolder element (Visual Studio templates)](../extensibility/solutionfolder-element-visual-studio-templates.md)
- [ProjectTemplateLink element (Visual Studio templates)](../extensibility/projecttemplatelink-element-visual-studio-templates.md)
