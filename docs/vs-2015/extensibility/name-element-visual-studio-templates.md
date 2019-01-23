---
title: "Name Element (Visual Studio Templates) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/vstemplate/2005#Name"
helpviewer_keywords: 
  - "Name element [Visual Studio project templates]"
ms.assetid: 48788dbf-7da0-4443-8061-aab966fc22c8
caps.latest.revision: 18
ms.author: gregvanl
manager: jillfra
---
# Name Element (Visual Studio Templates)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies the name of the template as it appears in the **New Project** or **Add New Item** dialog box.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<Name>  
  
## Syntax  
  
```  
<Name> Template Name </Name>  
```  
  
```  
<Name Package="{PackageID}" ID="ResourceID" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Package`|Optional attribute, for advanced user scenarios.<br /><br /> A GUID that specifies the Visual Studio package ID.|  
|`ID`|Optional attribute, for advanced user scenarios.<br /><br /> Specifies the Visual Studio resource ID.|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Required element.<br /><br /> Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|  
  
## Text Value  
 A text value is required unless the `Package` and `ID` attributes are used.  
  
 The text provides the name of the template.  
  
## Remarks  
 `Name` is a required child element of `TemplateData`.  
  
## Example  
 The following example shows the metadata for a project template for a [!INCLUDE[csprcs](../includes/csprcs-md.md)] application.  
  
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
