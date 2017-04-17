---
title: "New Project Generation: Under the Hood, Part Two | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "projects [Visual Studio], new project dialog"
  - "projects [Visual Studio], new project generation"
ms.assetid: 73ce91d8-0ab1-4a1f-bf12-4d3c49c01e13
caps.latest.revision: 14
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# New Project Generation: Under the Hood, Part Two
In [New Project Generation: Under the Hood, Part One](../../extensibility/internals/new-project-generation-under-the-hood-part-one.md) we saw how the **New Project** dialog Box is populated. Let's assume you've selected a **Visual C# Windows Application**, filled out the **Name** and **Location** text boxes, and clicked OK.  
  
## Generating the Solution Files  
 Choosing an application template directs [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] to unzip and open the corresponding .vstemplate file, and to launch a template to interpret the XML commands in this file. These commands create projects and project items in the new or existing solution.  
  
 The template unpacks source files, called item templates, from the same .zip folder that holds the .vstemplate file. The template copies these files to the new project, customizing them accordingly. For an overview of project and item templates, see [NIB: Visual Studio Templates](http://msdn.microsoft.com/en-us/141fccaa-d68f-4155-822b-27f35dd94041).  
  
### Template Parameter Replacement  
 When the template copies an item template to a new project, it replaces any template parameters with strings to customize the file. A template parameter is a special token that is preceded and followed by a dollar sign, for example, $date$.  
  
 Let's look at a typical project item template. Extract and examine Program.cs in the Program Files\Microsoft Visual Studio 8\Common7\IDE\ProjectTemplates\CSharp\Windows\1033\WindowsApplication.zip folder.  
  
```  
using System;  
using System.Collections.Generic;  
using System.Windows.Forms;  
  
namespace $safeprojectname$  
{  
    static class Program  
    {  
        // source code deleted here for brevity  
    }  
}  
```  
  
 If you create a new Windows application project named Simple, the template replaces the `$safeprojectname$` parameter with the name of the project.  
  
```  
using System;  
using System.Collections.Generic;  
using System.Windows.Forms;  
  
namespace Simple  
{  
    static class Program  
    {  
        // source code deleted here for brevity  
    }  
}  
```  
  
 For a complete list of template parameters, see [Template Parameters](../../ide/template-parameters.md).  
  
## A Look Inside a .VSTemplate File  
 A basic .vstemplate file has this format  
  
```  
<VSTemplate Version="2.0.0"     xmlns="http://schemas.microsoft.com/developer/vstemplate/2005"     Type="Project">  
    <TemplateData>  
    </TemplateData>  
    <TemplateContent>  
    </TemplateContent>  
</VSTemplate>  
```  
  
 We looked at the \<TemplateData> section in the [New Project Generation: Under the Hood, Part One](../../extensibility/internals/new-project-generation-under-the-hood-part-one.md). The tags in this section are used to control the appearance of the **New Project** dialog box.  
  
 The tags in the \<TemplateContent> section control the generation of new projects and project items. Here's the \<TemplateContent> section from the cswindowsapplication.vstemplate file in the \Program Files\Microsoft Visual Studio 8\Common7\IDE\ProjectTemplates\CSharp\Windows\1033\WindowsApplication.zip folder.  
  
```  
<TemplateContent>  
  <Project File="WindowsApplication.csproj" ReplaceParameters="true">  
    <ProjectItem ReplaceParameters="true"  
      TargetFileName="Properties\AssemblyInfo.cs">  
      AssemblyInfo.cs  
    </ProjectItem>  
    <ProjectItem TargetFileName="Properties\Resources.resx">  
      Resources.resx  
    </ProjectItem>  
    <ProjectItem ReplaceParameters="true"       TargetFileName="Properties\Resources.Designer.cs">  
      Resources.Designer.cs  
    </ProjectItem>  
    <ProjectItem TargetFileName="Properties\Settings.settings">  
      Settings.settings  
    </ProjectItem>  
    <ProjectItem ReplaceParameters="true"       TargetFileName="Properties\Settings.Designer.cs">  
      Settings.Designer.cs  
    </ProjectItem>  
    <ProjectItem ReplaceParameters="true" OpenInEditor="true">  
      Form1.cs  
    </ProjectItem>  
    <ProjectItem ReplaceParameters="true">  
      Form1.Designer.cs  
    </ProjectItem>  
    <ProjectItem ReplaceParameters="true">  
      Program.cs  
    </ProjectItem>  
  </Project>  
</TemplateContent>  
```  
  
 The \<Project> tag controls the generation of a project, and the \<ProjectItem> tag controls the generation of a project item. If the parameter ReplaceParameters is true, the template will customize all template parameters in the project file or item. In this case, all project items are customized, except for Settings.settings.  
  
 The TargetFileName parameter specifies the name and relative path of the resulting project file or item. This lets you create a folder structure for your project. If you don't specify this argument, the project item will have the same name as the project item template.  
  
 The resulting Windows application folder structure looks like this:  
  
 ![SimpleSolution](../../extensibility/internals/media/simplesolution.png "SimpleSolution")  
  
 The first and only \<Project> tag in the template reads:  
  
```  
<Project File="WindowsApplication.csproj" ReplaceParameters="true">  
```  
  
 This instructs the New Project template to create the Simple.csproj project file by copying and customizing the template item windowsapplication.csproj.  
  
### Designers and References  
 You can see in the Solution Explorer that the Properties folder is present and contains the expected files. But what about project references and designer file dependencies, such as Resources.Designer.cs to Resources.resx, and Form1.Designer.cs to Form1.cs?  These are set up in the Simple.csproj file when it is generated.  
  
 Here's the \<ItemGroup> from Simple.csproj that creates the project references:  
  
```  
<ItemGroup>  
    <Reference Include="System" />  
    <Reference Include="System.Data" />  
    <Reference Include="System.Deployment" />  
    <Reference Include="System.Drawing" />  
    <Reference Include="System.Windows.Forms" />  
    <Reference Include="System.Xml" />  
</ItemGroup>  
```  
  
 You can see that these are the six project references that appear in the Solution Explorer. Here's a section from another \<ItemGroup>. Many lines of code have been deleted for clarity. This section makes Settings.Designer.cs dependent on Settings.settings:  
  
```  
<ItemGroup>  
    <Compile Include="Properties\Settings.Designer.cs">  
        <DependentUpon>Settings.settings</DependentUpon>  
    </Compile>  
</ItemGroup>  
```  
  
## See Also  
 [New Project Generation: Under the Hood, Part One](../../extensibility/internals/new-project-generation-under-the-hood-part-one.md)  
 [MSBuild](../../msbuild/msbuild.md)