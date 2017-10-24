---
title: "&lt;friendlyName&gt; Element (Office Development in Visual Studio) | Microsoft Docs"
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
  - "application manifests [Office development in Visual Studio], <friendlyName> element"
ms.assetid: 80250fbf-fccf-4baa-948e-ace7f4449e9c
caps.latest.revision: 19
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
---
# &lt;friendlyName&gt; Element (Office Development in Visual Studio)
  The `friendlyName` element of the `vstov4` namespace stores the name that appears in the list of installed programs.  
  
## Syntax  
  
```  
<friendlyName>  
</friendlyName>  
```  
  
## Elements and Attributes  
 The `friendlyName` element is in the `vstov4` namespace. The value appears in the list of installed programs on the computer, and in the COM VSTO Add-ins dialog box of Microsoft Office applications.  
  
 The `friendlyName` element has no attributes or child elements.  
  
## VSTO Add-in Example  
  
### Description  
 The following code example illustrates the `friendlyName` element in an application-level solution deployed by using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
<vstov4:friendlyName>  
  ContosoOutlookAddIn  
</vstov4:friendlyName>  
```  
  
## See Also  
 [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../vsto/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](/visualstudio/deployment/clickonce-application-manifest)  
  
  