---
title: "TemplateID Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#TemplateID"
helpviewer_keywords: 
  - "<TemplateID> element [Visual Studio Templates]"
  - "TemplateID element [Visual Studio Templates]"
ms.assetid: 6ca24b4e-0325-4a9e-855e-0cbbe7361d8f
caps.latest.revision: 15
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
# TemplateID Element (Visual Studio Templates)
Specifies an identifier for an item template that is categorized into a group of item templates by the [TemplateGroupID](../extensibility/templategroupid-element--visual-studio-templates-.md) element.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<TemplateID>  
  
## Syntax  
  
```  
<TemplateID> ... </TemplateID>  
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
|[TemplateData](../extensibility/templatedata-element--visual-studio-templates-.md)|Required element.<br /><br /> Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|  
  
## Text Value  
 A `string` that represents an identifier for an item template that is categorized into a group of item templates by the `TemplateGroupID` element.  
  
## Remarks  
 `TemplateID` is an optional element.  
  
 If a .vstemplate file omits the `TemplateID` element, then the [Name](../extensibility/name-element--visual-studio-templates-.md) element is used as the identifier for the template.  
  
 The value of the `TemplateID` element is used along with project system registration (HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\11.0\Projects\\) to filter templates that appear in the **Add New Item** dialog box.  
  
## See Also  
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)   
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)