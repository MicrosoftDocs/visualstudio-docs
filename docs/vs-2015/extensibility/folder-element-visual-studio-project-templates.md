---
title: "Folder Element (Visual Studio Project Templates) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/vstemplate/2005#Folder"
helpviewer_keywords: 
  - "Folder element [Visual Studio project templates]"
ms.assetid: 558e3d41-0db5-4c44-82bb-6bb87892b093
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# Folder Element (Visual Studio Project Templates)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

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
  
## Attributes and Elements  
 The following sections describe attribute, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Name`|Required attribute.<br /><br /> The name of the project folder.|  
|`TargetFolderName`|Optional attribute.<br /><br /> Specifies the name to give the folder when a project is created from the template. This attribute is useful for using parameter replacement to create a folder name or naming a folder with an international string that cannot be used directly in the .zip file.|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|`Folder`|Specifies a folder to add to the project. `Folder` elements can contain child `Folder` elements.|  
|[ProjectItem](../extensibility/projectitem-element-visual-studio-item-templates.md)|Specifies a file to add to the project.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Project](../extensibility/project-element-visual-studio-templates.md)|Optional child element of [TemplateContent](../extensibility/templatecontent-element-visual-studio-templates.md).|  
  
## Remarks  
 `Folder` is an optional child of `Project`.  
  
 You can use any of the following methods to organize project items into folders in a template:  
  
- Include the folders in the template .zip file, and add them to the project in the .vstemplate file by specifying the path to the file in the `ProjectItem` elements, with no `Folder` elements. This is the recommended method. For example:  
  
     `...`  
  
     `<ProjectItem>\Folder\item.cs</ProjectItem>`  
  
     `<ProjectItem>Form1.cs</ProjectItem>`  
  
     `...`  
  
- Include the folders in the template .zip file, and add them to the project in the .vstemplate file with `Folder` elements. For example:  
  
     `...`  
  
     `<Folder name="Folder">`  
  
     `<ProjectItem>item.cs</ProjectItem>`  
  
     `</Folder>`  
  
     `<ProjectItem>Form1.cs</ProjectItem>`  
  
     `...`  
  
- Do not include folders in the template .zip file, but add folders using the `TargetFileName` attribute of the `ProjectItem` element. For example:  
  
     `...`  
  
     `<ProjectItem TargetFileName="\Folder\item.cs">item.cs</ProjectItem>`  
  
     `<ProjectItem>Form1.cs</ProjectItem>`  
  
     `...`  
  
## Example  
 The following example illustrates the metadata for a project template for a [!INCLUDE[csprcs](../includes/csprcs-md.md)] Windows application.  
  
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
  
## See Also  
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)   
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)   
 [ProjectItem Element (Visual Studio Item Templates)](../extensibility/projectitem-element-visual-studio-item-templates.md)
