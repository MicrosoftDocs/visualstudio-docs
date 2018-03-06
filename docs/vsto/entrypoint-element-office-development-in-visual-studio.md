---
title: "&lt;entryPoint&gt; Element (Office Development in Visual Studio) | Microsoft Docs"
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
  - "application manifests [Office development in Visual Studio], <entryPoint> element"
  - "<entryPoint> element"
  - "entryPoint element"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# &lt;entryPoint&gt; Element (Office Development in Visual Studio)
  Each `entryPoint` element of the `vstav3` namespace identifies a customization assembly that should be run when this [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)] application is installed.  
  
## Syntax  
  
```  
<entryPoint class>  
    <assemblyIdentity />  
</entryPoint>  
```  
  
## Elements and Attributes  
 The `entryPoint` element is required and is in the `vstav3` namespace.  
  
 Each `entryPoint` element can contain only one customization assembly. There can be multiple `entryPoint` elements defined in an application manifest.  
  
 The `entryPoint` element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`class`|Required. Identifies a customization assembly to be executed. The syntax for this attribute is *NamespaceName.ClassName*.|  
  
 `entryPoint` has the following element.  
  
### assemblyIdentity  
 Required. The `assemblyIdentity` element in the `vstav3` namespace refers to an existing `assemblyIdentity` element in the [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)] application manifest.  
  
 The role of `assemblyIdentity` and its attributes is defined in [&#60;assemblyIdentity&#62; Element &#40;ClickOnce Application&#41;](/visualstudio/deployment/assemblyidentity-element-clickonce-application).  
  
## Document-Level Customization Example  
  
### Description  
 The following code example illustrates `entryPoint` elements in an application manifest for a document-level Office solution deployed using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
<vstav3:entryPoint   
  class="ContosoExcelWorkbook.ThisWorkbook">  
  <assemblyIdentity   
    name="ContosoExcelWorkbook"   
    version="1.0.0.0"   
    language="neutral"   
    processorArchitecture="msil" />  
</vstav3:entryPoint>  
<vstav3:entryPoint   
  class="ContosoExcelWorkbook.Sheet1">  
  <assemblyIdentity   
    name="ContosoExcelWorkbook"   
    version="1.0.0.0"   
    language="neutral"   
    processorArchitecture="msil" />  
</vstav3:entryPoint>  
<vstav3:entryPoint   
  class="ContosoExcelWorkbook.Sheet2">  
  <assemblyIdentity   
    name="ContosoExcelWorkbook"   
    version="1.0.0.0"   
    language="neutral"   
    processorArchitecture="msil" />  
</vstav3:entryPoint>  
<vstav3:entryPoint   
  class="ContosoExcelWorkbook.Sheet3">  
  <assemblyIdentity   
    name="ContosoExcelWorkbook"   
    version="1.0.0.0"   
    language="neutral"   
    processorArchitecture="msil" />  
</vstav3:entryPoint>  
```  
  
## VSTO Add-in Example  
  
### Description  
 The following code example illustrates an `entryPoint` element in an application manifest for an application-level Office solution deployed using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
<vstav3:entryPoint   
  class="ContosoOutlookAddIn.ThisAddIn">  
  <assemblyIdentity   
    name="ContosoOutlookAddIn"   
    version="1.0.0.0"   
    language="neutral"   
    processorArchitecture="msil" />  
</vstav3:entryPoint>  
```  
  
## See Also  
 [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../vsto/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](/visualstudio/deployment/clickonce-application-manifest)  
  
  