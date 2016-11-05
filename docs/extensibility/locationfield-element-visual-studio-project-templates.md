---
title: "LocationField Element (Visual Studio Project Templates) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "http://schemas.microsoft.com/developer/vstemplate/2005#LocationField"
helpviewer_keywords: 
  - "LocationField element [Visual Studio project templates]"
ms.assetid: 6aaaa155-6ce0-4f7f-aa50-8d63d7a7c992
caps.latest.revision: 13
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
# LocationField Element (Visual Studio Project Templates)
Specifies whether or not the **Location** text box in the **New Project** dialog box is enabled, disabled, or hidden for the project template.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<LocationField>  
  
## Syntax  
  
```  
<LocationField> Enabled/Disabled/Hidden </LocationField>  
```  
  
## Attributes and Elements  
 The following sections describe attribute, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Required element.<br /><br /> Categorizes the template and defines how it displays in either the **New Project**.|  
  
## Text Value  
 A text value is required.  
  
 Valid text values are:  
  
-   `Enabled`, which specifies that the **Location** box of the **New Project** dialog box is enabled.  
  
-   `Disabled`, which specifies that the **Location** box of the **New Project** dialog box is disabled.  
  
-   `Hidden`, which specifies that the **Location** box of the **New Project** dialog box is hidden.  
  
## Remarks  
 The default value is `Enabled`.  
  
 The **Location** text box in the **New Project** dialog box enables users to change the default directory in which new projects are saved.  
  
 The value specified in the `Location` element is only honored by the dialog box if the underlying project system supports it.  
  
## Example  
 The following example illustrates the metadata for a [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] template.  
  
```  
<VSTemplate Type="Project" Version="3.0.0"  
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">  
    <TemplateData>  
        <Name>My template</Name>  
        <Description>A basic template</Description>  
        <Icon>TemplateIcon.ico</Icon>  
        <ProjectType>CSharp</ProjectType>  
        <LocationField>Disabled</LocationField>  
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