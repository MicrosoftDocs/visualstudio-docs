---
title: "NumberOfParentCategoriesToRollUp (Visual Studio Templates) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords: 
  - "http://schemas.microsoft.com/developer/vstemplate/2005#NumberOfParentCategoriesToRollUp"
helpviewer_keywords: 
  - "NumberOfParentCategoriesToRollUp element [Visual Studio Templates]"
  - "<NumberOfParentCategoriesToRollUp> element [Visual Studio Templates]"
ms.assetid: 6f9d36f5-ae23-4a92-8132-b11799e2c21a
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# NumberOfParentCategoriesToRollUp (Visual Studio Templates)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies the number of parent categories that will display the template in the **New Project** dialog box.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<NumberOfParentCategoriesToRollUp>  
  
## Syntax  
  
```  
<NumberOfParentCategoriesToRollUp>  
    1  
</NumberOfParentCategoriesToRollUp>  
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
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|  
  
## Text Value  
 An `integer` value is required.  
  
 This value specifies the number of parent categories that will display the template in the **New Project** dialog box.  
  
## Remarks  
 `NumberOfParentCategoriesToRollUp` is an optional element.  
  
## Example  
 This example illustrates the metadata for a [!INCLUDE[csprcs](../includes/csprcs-md.md)] Windows application. If a template with this metadata is placed two folder levels below the top level [!INCLUDE[csprcs](../includes/csprcs-md.md)] node, the template will appear in the top level node in the **New Project** dialog box. If the `NumberOfParentCategoriesToRollUp` is not set, the template only appears in the node in which it is physically located.  
  
```  
<VSTemplate Type="Project" Version="3.0.0"  
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">  
    <TemplateData>  
        <Name>My template</Name>  
        <Description>A basic starter kit</Description>  
        <Icon>TemplateIcon.ico</Icon>  
        <ProjectType>CSharp</ProjectType>  
        <NumberOfParentCategoriesToRollUp>2</NumberOfParentCategoriesToRollUp>  
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
