---
title: "&lt;customHostSpecified&gt; Element (Office Development in Visual Studio) | Microsoft Docs"
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
  - "application manifests [Office development in Visual Studio], <customHostSpecified> element"
  - "<customHostSpecified> element"
  - "customHostSpecified element"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# &lt;customHostSpecified&gt; Element (Office Development in Visual Studio)
  The `customHostSpecified` element indicates that this solution is not a stand-alone application. Office solutions contain components that are hosted inside Microsoft Office applications.  
  
## Syntax  
  
```  
<customHostSpecified />  
```  
  
## Elements and Attributes  
 The `customHostSpecified` element is required for Office solutions. This element is in the `co.v1` namespace and specifies that this deployment contains a component that will be deployed inside of a custom host, and is not a stand-alone application.  
  
 This element is a child of the first `<entrypoint>` element in the application manifest. There can be no other child elements in that `<entrypoint>` element or [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)] will raise a validation error during installation.  
  
 This element has no attributes and no child elements.  
  
## Example  
 The following code example illustrates the `customHostSpecified` element in an application manifest for an Office  solution. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md).  
  
```  
<entryPoint>  
    <co.v1:customHostSpecified />  
</entryPoint>  
```  
  
## See Also  
 [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../vsto/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](/visualstudio/deployment/clickonce-application-manifest)  
  
  