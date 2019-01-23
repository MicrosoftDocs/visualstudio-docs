---
title: "EnableEditOfLocationField Element (Visual Studio Templates) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
helpviewer_keywords: 
  - "EnableEditOfLocationField (Visual Studio project templates)"
ms.assetid: 51a91963-8a3f-4741-928e-bc90c11473bb
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# EnableEditOfLocationField Element (Visual Studio Templates)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies if the user can edit the location field.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<EnableEditOfLocationField>  
  
## Syntax  
  
```  
<EnableEditOfLocationField> true/false </EnableEditOfLocationField>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None  
  
### Child Elements  
 None  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Required element.<br /><br /> Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|  
  
## Text Value  
 A text value is required.  
  
 The text must be either `true` or `false`, indicating whether or not the user can edit the **Location** text box on the **New Project** dialog box.  
  
## Remarks  
 `EnableEditOfLocationField` is an optional element. The default value is `true`, which allows the user to edit the value in the **Location** text box in the **New Project** dialog box.  
  
 In the **New Project** dialog box, the **Location** text box specifies the directory where a new project is saved.  
  
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
        <EnableEditOfLocationField>false</EnableEditOfLocationField>  
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
