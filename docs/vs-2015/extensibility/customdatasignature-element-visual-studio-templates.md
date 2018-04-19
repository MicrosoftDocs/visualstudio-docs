---
title: "CustomDataSignature Element (Visual Studio Templates) | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "<CustomDataSignature> Element (Visual Studio Templates)"
  - "CustomDataSignature Element (Visual Studio Templates)"
ms.assetid: 8c3db51d-7014-4484-802a-15aa1353dbdb
caps.latest.revision: 7
ms.author: "gregvanl"
manager: "ghogen"
---
# CustomDataSignature Element (Visual Studio Templates)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The latest version of this topic can be found at [CustomDataSignature Element (Visual Studio Templates)](https://docs.microsoft.com/visualstudio/extensibility/customdatasignature-element-visual-studio-templates).  
  
Specifies the text signature to locate the custom data.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<CustomDataSignature>  
  
## Syntax  
  
```  
<CustomDataSignature>"string"</CustomDataSignature>  
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
  
 The text is a string that has the text signature that is required to locate the custom data.  
  
## Remarks  
 `CustomDataSignature` is an optional element.  
  
## See Also  
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)   
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)

