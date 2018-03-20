---
title: "MaxFrameworkVersion Element (Visual Studio Templates) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
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
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# MaxFrameworkVersion Element (Visual Studio Templates)
Specifies the maximum version of the .NET Framework that is required by the template. It determines the highest value available in the **Target Framework Version** dropdown of the **New Project Dialog**. In order for users to select from the available frameworks in a template's supported range, [RequiredFrameworkVersion](../extensibility/requiredframeworkversion-element-visual-studio-templates.md) also needs to be specified as the minimum .NET Framework version.

> [!IMPORTANT]
> As of Visual Studio 2017 version 15.6, the **Target Framework Version** dropdown is no longer a filter for displayed templates in the **Templates** section of the **New Project Dialog**. Instead, the dropdown functions as a framework picker for the selected template.

 \<VSTemplate>
 \<TemplateData>
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
 `MaxFrameworkVersion` is an optional element. The `MaxFrameworkVersion` element should be omitted unless it is required, so as not to inadvertently limit the supported range of .NET Framework versions for the template. It should also be omitted if .NET Framework is not applicable to the template.
  
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
        <RequiredFrameworkVersion>3.0</RequiredFrameworkVersion>
        <MaxFrameworkVersion>4.7.1</MaxFrameworkVersion>  
        <DefaultName>MyClass</DefaultName>  
    </TemplateData>  
    <TemplateContent>  
        <ProjectItem>MyClass.cs</ProjectItem>  
    </TemplateContent>  
</VSTemplate>  
```  
  
 In this example, the maximum version of the .NET Framework that is required by the template, represented by `MaxFrameworkVersion`, is 4.7.1. A project created with this template can target .NET Framework versions upto 4.7.1.  
  
## See Also  
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)   
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
