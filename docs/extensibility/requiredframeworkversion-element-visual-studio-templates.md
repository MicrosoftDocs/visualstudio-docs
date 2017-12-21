---
title: "RequiredFrameworkVersion Element (Visual Studio Templates) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "<RequiredFrameworkVersion> (Visual Studio Templates)"
  - "RequiredFrameworkVersion (Visual Studio Templates)"
ms.assetid: 08a4f609-51a5-4723-b89f-99277fb18871
caps.latest.revision: 10
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# RequiredFrameworkVersion Element (Visual Studio Templates)
Specifies the minimum .NET Framework version that is required by the template.Schema Hierarchy.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<RequiredFrameworkVersion>  
  
## Syntax  
  
```  
<RequiredFrameworkVersion> .... </RequiredFrameworkVersion>  
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
  
 The text must be the minimum version number of the .NET Framework that is required for the template.  
  
## Remarks  
 `RequiredFrameworkVersion` is an optional element. Use this element if the template only supports a specific minimum version, and later versions if any, of the .NET Framework.  
  
## See Also  
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)   
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)   
 [Targeting a Specific .NET Framework Version](../ide/targeting-a-specific-dotnet-framework-version.md)