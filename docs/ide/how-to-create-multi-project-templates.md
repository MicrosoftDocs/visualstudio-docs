---
title: "How to: Create Multi-Project Templates | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio templates, creating multi-project templates"
  - "project templates, creating multi-project templates"
  - "multi-project templates"
ms.assetid: 8c7f7065-137e-40ad-868d-37e007270efd
caps.latest.revision: 16
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
---
# How to: Create Multi-Project Templates
Multi-project templates act as containers for two or more projects. When a project based on a multi-project template is created from the **New Project** dialog box, every project in the template is added to the solution.  

 A multi-project template is two-or more project templates along with a root template of type `ProjectGroup`.

 Multi-project templates also behave differently than normal templates. Multi-project templates have the following unique characteristics:  
  
-   Individual projects in a multi-project template cannot be assigned names by the **New Project** dialog box. Instead, use the `ProjectName` attribute on the `ProjectTemplateLink` element to specify the name for each project. For more information, see the first example in the following section.  
  
-   Multi-project templates can contain projects written in different languages, but the entire template itself can only be put in one category by using the `ProjectType` element.  
  
### To create a multi-project template  
  
1.  Create the projects to include in the multi-project template:
    1.  Create a project.  
  
    > [!NOTE]
    >  Use only valid identifier characters when naming a project that will be the source for a template. A template exported from a project named with invalid characters can cause compilation errors in future projects based on the template. For more information on valid identifier characters, see [Declared Element Names](/dotnet/visual-basic/programming-guide/language-features/declared-elements/declared-element-names).  
  
    2.  Edit the project until it is ready to be exported as a template.  
  
    3.  As appropriate, edit the code files to indicate where parameter replacement should take place. For more information on parameter replacement, see [How to: Substitute Parameters in a Template](../ide/how-to-substitute-parameters-in-a-template.md).  
  
    4.  On the **Project** menu, click **Export Template**. The **Export Template** wizard opens.  
  
    5.  Click **Project Template**.  
  
    6.  If you have more than one project in your current solution, select the projects you want to export to a template.  
  
    7.  Click **Next**.  
  
    8.  Select an icon and a preview image for your template. These will appear in the **New Project** dialog box.  
  
    9. Enter a template name and description.  
  
    10. Click **Finish**. Your project is exported into a .zip file and placed in the specified output location, and, if selected, imported into [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
2.  Extract the .vstemplate file from the generated zip file into the same directory as the project file used to export the template.

3.  Create a root .vstemplate file that to contain the metadata for the multi-project template. For more information, see the first example in the following section.  
  
4.  Select the files and folders to include in your template, right-click the selection, click **Send To**, and then click **Compressed (zipped) Folder**. The files and folders are compressed into a .zip file.  
  
> [NOTE!]
> A multi-project template must include the following items, compressed into a .zip file:  
>   
> -   A root .vstemplate file for the entire multi-project template. This root .vstemplate file contains the metadata that the **New Project** dialog box displays, and specifies where to find the .vstemplate files for the projects in this template. This file must be located at the root of the .zip file.  
>   
> -   One or more folders that contain the files that are required for a complete project template. This includes all code files for the project, and also a .vstemplate file for the project.  
>   
> For example, a multi-project template .zip file that has two projects could have the following files and directories:  
>   
>  MultiProjectTemplate.vstemplate  
>   
>  \Project1\Project1.vstemplate  
>   
>  \Project1\Project1.vbproj  
>   
>  \Project1\Class.vb  
>   
>  \Project2\Project2.vstemplate  
>   
>  \Project2\Project2.vbproj  
>   
>  \Project2\Class.vb  
>   
>  The root .vstemplate file for a multi-project template differs from a single-project template in the following ways:  
>   
> -   The `Type` attribute of the `VSTemplate` element contains the value `ProjectGroup`. For example:  
>   
>     ```  
>     <VSTemplate Version="2.0.0" Type="ProjectGroup"  
>         xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">  
>     ```  
>   
> -   The `TemplateContent` element contains a `ProjectCollection` element that has one or more `ProjectTemplateLink` elements that define the paths to the .vstemplate files of the included projects. For example:  
>   
>     ```  
>     <TemplateContent>  
>         <ProjectCollection>  
>             <ProjectTemplateLink>  
>                 Project1\Project1.vstemplate  
>             </ProjectTemplateLink>  
>             <ProjectTemplateLink>  
>                 Project2\Project2.vstemplate  
>             </ProjectTemplateLink>  
>         </ProjectCollection>  
>     </TemplateContent>  
>     ```  
>   
  
5.  Put the .zip template file in the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] project template directory. By default, this directory is \My Documents\Visual Studio *Version*\Templates\ProjectTemplates\\.  
  
## Example  
 This example shows a basic multi-project root .vstemplate file. In this example, the template contains two projects, `My Windows Application` and `My Class Library`. The `ProjectName` attribute on the `ProjectTemplateLink` element sets the name for [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] to assign this project. If the `ProjectName` attribute does not exist, the name of the .vstemplate file is used as the project name.  
  
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
  
## Example  
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
  
## See Also  
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)   
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)   
 [How to: Create Project Templates](../ide/how-to-create-project-templates.md)   
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)   
 [SolutionFolder Element (Visual Studio Templates)](../extensibility/solutionfolder-element-visual-studio-templates.md)   
 [ProjectTemplateLink Element (Visual Studio Templates)](../extensibility/projecttemplatelink-element-visual-studio-templates.md)
