---
title: "&lt;postActionData&gt; Element (Office Development in Visual Studio) | Microsoft Docs"
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
  - "<postActionData> element"
  - "application manifests [Office development in Visual Studio], <postActionData> element"
  - "postActionData element"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# &lt;postActionData&gt; Element (Office Development in Visual Studio)
  The `postActionData` element of the `vstav3` namespace specifies the data associated with any post-deployment action that runs after Office solutions are installed.  
  
## Syntax  
  
```  
<postActionData>  
</postActionData>  
```  
  
## Elements and Attributes  
 The `postActionData` element is optional and is in the `vstav3` namespace. There is one `postActionData` element defined in an application manifest for each post-deployment action.  
  
 The `postActions` element has no attributes.  
  
 `postActions` has no child elements.  
  
## Post-Deployment Action Example  
  
### Description  
 The following code example illustrates the `postAction` element in an application manifest for an Office solution deployed by using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
<vstav3:postActionData>  
  data in any format  
</vstav3:postActionData>  
```  
  
## See Also  
 [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../vsto/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](/visualstudio/deployment/clickonce-application-manifest)  
  
  