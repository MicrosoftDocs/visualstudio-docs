---
title: "MaxFrameworkVersion Element (Visual Studio Templates) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "<MaxFrameworkVersion> Element (Visual Studio Templates)"
  - "MaxFrameworkVersion Element (Visual Studio Templates)"
ms.assetid: f732a9d3-fc29-405b-9298-01ea83fc58b8
caps.latest.revision: 9
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
# MaxFrameworkVersion Element (Visual Studio Templates)
Specifies the maximum version of the .NET Framework that is required by the template. It determines whether the template is displayed in the **Templates** section of the **Add New Project** dialog box, based on the value that is selected in the **Target Framework Version** box of the **Add New Project** dialog box.  
  
 \<VSTemplate>  
 \<MaxFrameworkVersion>  
  
## Syntax  
  
```  
<MaxFrameworkVersion> ... </MaxFrameworkVersion>  
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
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Required element.<br /><br /> Categorizes the template and defines how it is displayed in either the **New Project** or the **Add New Item** dialog box.|  
  
## Text Value  
 A text value is required.  
  
 The text must be the highest version number of the .NET Framework that is allowed by the template.  
  
## Remarks  
 `MaxFrameworkVersion` is an optional element. The element in the `TemplateData` section of the .vstemplate file acts as a filter for the **Templates** section of the **Add New Project** dialog box. Only templates whose .NET Framework requirements are less than `MaxFrameworkVersion` element values will be displayed, based on the value that is selected in the **Target Framework Version** box of the **Add New Project** dialog box. The `MaxFrameworkVersion` element should be omitted unless it is required, so as not to inadvertently cause templates from being displayed when they are used with newer versions of the .NET Framework.  
  
## Example  
 The following example illustrates the metadata for a standard [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] class template.  
  
```  
<VSTemplate Type="Item" Version="3.0.0"  
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">  
    <TemplateData>  
        <Name>MyClass</Name>  
        <Description>My custom C# class template.</Description>  
        <Icon>Icon.ico</Icon>  
        <ProjectType>CSharp</ProjectType>  
        <MaxFrameworkVersion>3.5</MaxFrameworkVersion>  
        <DefaultName>MyClass</DefaultName>  
    </TemplateData>  
    <TemplateContent>  
        <ProjectItem>MyClass.cs</ProjectItem>  
    </TemplateContent>  
</VSTemplate>  
```  
  
 In this example, the maximum version of the .NET Framework that is required by the template, represented by `MaxFrameworkVersion`, is 3.5. The above template will be displayed only when you select either 3.0 or 3.5 in the **Target Framework Version** box in the **Add New Project** dialog box.  
  
## See Also  
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)   
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)