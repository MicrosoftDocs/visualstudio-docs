---
title: "&lt;vstoRuntime&gt; Element (Office Development in Visual Studio) | Microsoft Docs"
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
  - "application manifests [Office development in Visual Studio], <vstoRuntime> element"
  - "<vstoRuntime> element"
  - "vstoRuntime element"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# &lt;vstoRuntime&gt; Element (Office Development in Visual Studio)
  The `vstoRuntime` element of the `vstav3` namespace contains a supported version of the Visual Studio Tools for Office runtime for a specific Office solution.  
  
## Syntax  
  
```  
<vstoRuntime  
    release  
    version  
    supportUrl />  
```  
  
## Elements and Attributes  
 The `vstoRuntime` element is required and is in the `vstav3` namespace. If an Office solution supports two versions of the Visual Studio Tools for Office runtime, there are two `vstoRuntime` elements in the application manifest.  
  
 The `vstoRuntime` element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`release`|Required. The release version of the Visual Studio Tools for Office runtime.|  
|`version`|Required. Version number of the Visual Studio Tools for Office runtime.|  
|`supportUrl`|Optional. Link to the installation location of the Visual Studio Tools for Office runtime.|  
  
 `vstoRuntime` has no elements.  
  
## Example  
 The following code example illustrates the `vstoRuntime` element in an application manifest for an Office solution deployed by using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md).  
  
```  
<vstav3:vstoRuntime  
    release="VSTOR40Beta1"  
    version="10.0.20303"  
    supportUrl="http://www.microsoft.com" />  
```  
  
## See Also  
 [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../vsto/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](/visualstudio/deployment/clickonce-application-manifest)  
  
  