---
title: "&lt;document&gt; Element (Office Development in Visual Studio) | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "document element"
  - "application manifests [Office development in Visual Studio], <document> element"
  - "<document> element"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# &lt;document&gt; Element (Office Development in Visual Studio)
  The `document` element of the `vstov4` namespace stores customization-specific information for document-level customizations.  
  
## Syntax  
  
```  
<document solutionId />  
```  
  
## Elements and Attributes  
 Required only for document-level customizations. The `document` element is in the `vstov4` namespace. The `document` element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`solutionId`|Required. The GUID used by the Visual Studio Tools for Office runtime to uniquely identify a document-level solution. This value is stored as the _AssemblyLocation custom document property. For more information, see [Custom Document Properties Overview](../vsto/custom-document-properties-overview.md).|  
  
 `document` has no child elements.  
  
## Document-Level Customization Example  
  
### Description  
 The following code example illustrates the `document` element in a document-level Office solution deployed by using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
<vstov4:document   
  solutionId="73e" />  
```  
  
## See Also  
 [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../vsto/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](/visualstudio/deployment/clickonce-application-manifest)  
  
  