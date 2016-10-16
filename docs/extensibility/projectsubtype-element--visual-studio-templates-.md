---
title: "ProjectSubType Element (Visual Studio Templates)"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "http://schemas.microsoft.com/developer/vstemplate/2005#ProjectSubType"
helpviewer_keywords: 
  - "ProjectSubType element [Visual Studio Templates]"
  - "<ProjectSubType> element [Visual Studio Templates]"
ms.assetid: f6895cd4-3e95-4f0e-aa9e-8c7750f46ed4
caps.latest.revision: 13
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.ht: 
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
# ProjectSubType Element (Visual Studio Templates)
Classifies the template into a subcategory of the value specified in the `ProjectType` element.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<ProjectSubType>  
  
## Syntax  
  
```  
<ProjectSubType> SubType </ProjectSubType>  
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
|[TemplateData](../extensibility/templatedata-element--visual-studio-templates-.md)|Required element.<br /><br /> Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|  
  
## Text Value  
 A text value is required.  
  
 This value specifies the subcategory of the template.  
  
## Remarks  
 `ProjectSubType` is an optional child element of `TemplateData`.  
  
 The `ProjectSubType` element provides a subcategory to the [ProjectType](../extensibility/projecttype-element--visual-studio-templates-.md) element. This value can include:  
  
-   `SmartDevice-NETCFv1`: Specifies that the template targets the [!INCLUDE[Compact](../extensibility/includes/compact_md.md)] version 1.0.  
  
-   `SmartDevice-NETCFv2`: Specifies that the tempalate targets the [!INCLUDE[Compact](../extensibility/includes/compact_md.md)] version 2.0.  
  
 If a template contains a `ProjectType` element with a value of `Web`, the `ProjectSubType` element specifies the programming language of the template. This element can have the following values:  
  
-   `CSharp`: Specifies that the template creates a [!INCLUDE[csprcs](../datatools/includes/csprcs_md.md)] Web project or item.  
  
-   `VisualBasic`: Specifies that the template creates a [!INCLUDE[vbprvb](../codequality/includes/vbprvb_md.md)] Web project or item.  
  
## Example  
 The following example shows the metadata for a project template for a [!INCLUDE[csprcs](../datatools/includes/csprcs_md.md)] device application targeting the [!INCLUDE[Compact](../extensibility/includes/compact_md.md)] version 2.0.  
  
```  
<VSTemplate Type="Project" Version="3.0.0"  
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">  
    <TemplateData>  
        <Name>My template</Name>  
        <Description>A basic device template</Description>  
        <Icon>TemplateIcon.ico</Icon>  
        <ProjectType>CSharp</ProjectType>  
        <ProjectSubType>SmartDevice-NETCFv2</ProjectSubType>  
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
 [ProjectType Element (Visual Studio Templates)](../extensibility/projecttype-element--visual-studio-templates-.md)