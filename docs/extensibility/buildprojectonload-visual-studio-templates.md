---
title: BuildProjectOnLoad attribute (Visual Studio Templates)
ms.date: "11/04/2016"
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/vstemplate/2005#BuildOnLoad"
helpviewer_keywords: 
  - "BuildProjectOnLoad attribute [Visual Studio Templates]"
ms.assetid: 950f5fc1-d041-4090-9a5c-60844768a4cc
author: "gregvanl"
ms.author: "gregvanl"
manager: douge
ms.workload: 
  - "vssdk"
---
# BuildProjectOnLoad attribute (Visual Studio templates)
Specifies whether to build the project immediately after it's created.
  
### Parent elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|  
  
## Text value  
 A text value is required.  
  
 The text must be either `true` or `false`, indicating whether to build the project immediately after it's created.  
  
## Remarks  
 `BuildProjectOnLoad` is an optional attribute. The default value is `false`. 
  
## See also  

- [TemplateContent element (Visual Studio templates)](../extensibility/templatecontent-element-visual-studio-templates.md)   
- [Creating project and item templates](../ide/creating-project-and-item-templates.md)   
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)