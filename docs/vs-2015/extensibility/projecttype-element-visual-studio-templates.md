---
title: "ProjectType Element (Visual Studio Templates) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/vstemplate/2005#ProjectType"
helpviewer_keywords: 
  - "ProjectType element [Visual Studio project templates]"
ms.assetid: ccf9d83f-c7f3-49c7-a31f-e1f22bec004c
caps.latest.revision: 20
ms.author: gregvanl
manager: jillfra
---
# ProjectType Element (Visual Studio Templates)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Categorizes the project template so that it appears under the specified group in the **New Project** or **Add New Item** dialog box.  
  
> [!WARNING]
> Project templates are supported for C++ starting in Visual Studio 2012. They are not supported for C++ in Visual Studio 2010 and earlier versions.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<ProjectType>  
  
## Syntax  
  
```  
<ProjectType> CSharp/VisualBasic/VC/Web </ProjectType>  
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
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|  
  
## Text Value  
 A text value is required.  
  
 This value specifies the type of project the template will create, and must contain one of the following values:  
  
- `CSharp`: Specifies that the template creates a [!INCLUDE[csprcs](../includes/csprcs-md.md)] project or item.  
  
- `VisualBasic`: Specifies that the template creates a [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] project or item.  
  
- `Web`: Specifies that the template creates a Web project or item. If the `ProjectType` element contains this value, the language of the project or item is defined in the [ProjectSubType Element (Visual Studio Templates)](../extensibility/projectsubtype-element-visual-studio-templates.md).  
  
## Remarks  
 `ProjectType` is a required child element of `TemplateData`.  
  
 The value of the `ProjectType` element specifies where the template is located in the **New Project** or **Add New Item** dialog box. For example, a template with a `ProjectType` value of `CSharp` appears under the **Visual C#** node in the **New Project** dialog box.  
  
 A template subtype can be specified by using the [ProjectSubType](../extensibility/projectsubtype-element-visual-studio-templates.md) element.  
  
## Example  
 The following example shows the metadata for a project template for a [!INCLUDE[csprcs](../includes/csprcs-md.md)] application.  
  
```  
<VSTemplate Type="Project" Version="3.0.0"  
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">  
    <TemplateData>  
        <Name>My template</Name>  
        <Description>A basic starter kit</Description>  
        <Icon>TemplateIcon.ico</Icon>  
        <ProjectType>CSharp</ProjectType>  
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
 [ProjectSubType Element (Visual Studio Templates)](../extensibility/projectsubtype-element-visual-studio-templates.md)
