---
title: "&lt;description&gt; Element (Office Development in Visual Studio) | Microsoft Docs"
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
  - "description element"
  - "<description> element"
  - "application manifests [Office development in Visual Studio], <description> element"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# &lt;description&gt; Element (Office Development in Visual Studio)
  The `description` element of the `vstov4` namespace stores the description for the Office solution that appears in the COM add-ins dialog box of Microsoft Office applications.  
  
## Syntax  
  
```  
<description>  
</description>  
```  
  
## Elements and Attributes  
 Optional. The `description` element is in the `vstov4` namespace. It contains the description of the add-in that appears in the COM add-ins dialog box of Microsoft Office applications.  
  
 The `description` element has no attributes or elements.  
  
## VSTO Add-in Example  
  
### Description  
 The following code example illustrates the `description` element for an application-level solution deployed by using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
<vstov4:description>  
  ContosoOutlookAddIn - Outlook add-in   
  created with Visual Studio Tools for Office  
</vstov4:description>  
```  
  
## See Also  
 [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../vsto/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](/visualstudio/deployment/clickonce-application-manifest)  
  
  