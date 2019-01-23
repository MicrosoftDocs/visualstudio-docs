---
title: "EnableLocationBrowseButton Element (Visual Studio Templates) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/vstemplate/2005#EnableLocationBrowseButton"
helpviewer_keywords: 
  - "EnableLocationBrowseButton [Visual Studio project templates]"
ms.assetid: a12d10d8-af49-482a-af77-e084fd07a47d
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# EnableLocationBrowseButton Element (Visual Studio Templates)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies whether the **Browse** button is available in the **New Project** dialog box, so that users can easily modify the default directory where a new project is saved.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<EnableLocationBrowseButton>  
  
## Syntax  
  
```  
<EnableLocationBrowseButton> true/false </EnableLocationBrowseButton>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Required element.<br /><br /> Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|  
  
## Text Value  
 A text value is required.  
  
 The text must be either `true` or `false`, indicating whether or not to display the **Browse** button on the **New Project** dialog box.  
  
## Remarks  
 `EnableLocationBrowseButton` is an optional element. The default value is `true`, which displays the **Browse** button in the **New Project** dialog box.  
  
 In the **New Project** dialog box, the **Location** text box specifies the directory where a new project is saved. The **Browse** button helps you modify this directory by displaying the **Project Location** dialog box, which enables you to easily navigate to a different directory that is available from your computer, and then choose it as the directory where the new project is saved.  
  
## Example  
 The following example illustrates the metadata for a [!INCLUDE[csprcs](../includes/csprcs-md.md)] Windows application.  
  
```  
<VSTemplate Type="Project" Version="3.0.0"  
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">  
    <TemplateData>  
        <Name>My template</Name>  
        <Description>A basic starter kit</Description>  
        <Icon>TemplateIcon.ico</Icon>  
        <ProjectType>CSharp</ProjectType>  
        <EnableLocationBrowseButton>false</EnableLocationBrowseButton>  
    </TemplateData>  
    <TemplateContent>  
        <Project File="MyStarterKit.csproj">  
            <ProjectItem>Form1.cs<ProjectItem>  
            <ProjectItem>Form1.Designer.cs</ProjectItem>  
            <ProjectItem>Program.cs</ProjectItem>  
            <ProjectItem>Properties\AssemblyInfo.cs</ProjectItem>  
            <ProjectItem>Properties\Resources.resx</ProjectItem>  
            <ProjectItem>Properties\Resources.Designer.cs</ProjectItem>  
            <ProjectItem>Properties\Settings.settings</ProjectItem>  
            <ProjectItem>Properties\Settings.Designer.cs</ProjectItem>  
        </Project>  
    </TemplateContent>  
</VSTemplate>  
```  
  
## See Also  
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)   
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
