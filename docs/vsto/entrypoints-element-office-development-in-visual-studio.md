---
title: "&lt;entryPoints&gt; Element (Office Development in Visual Studio) | Microsoft Docs"
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
  - "application manifests [Office development in Visual Studio], <entryPoints> element"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# &lt;entryPoints&gt; Element (Office Development in Visual Studio)
  The `entryPoints` element of the `vstav3` namespace contains all the `entryPoint` elements associated with an Office solution.  
  
## Syntax  
  
```  
<entryPoints>  
    <entryPoint>  
    </entryPoint>  
    <entryPoint>  
    </entryPoint>  
    <entryPoint>  
    </entryPoint>  
</entryPoints>  
```  
  
## Elements and Attributes  
 The `entryPoints` element is required and is in the `vstav3` namespace. There is one `entryPoints` element defined in an application manifest for each Office solution. For example, if you deploy three Office solutions in a multi-project deployment, there are three `entryPoints` elements in the application manifest.  
  
 The `entryPoints` element has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|id|Required for multi-project deployment. The name of the Office solution. The id cannot contain the equal (=) symbol.|  
  
 `entryPoints` has the following elements.  
  
### entryPoint  
 Required. The role of the `entryPoint` element in the `vstav3` namespace is defined in [&#60;entryPoint&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/entrypoint-element-office-development-in-visual-studio.md).  
  
## Document-Level Customization Example  
  
### Description  
 The following code example illustrates the `entryPoints` element in an application manifest for a document-level solution deployed by using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
<vstav3:entryPoints>  
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
</vstav3:entryPoints>  
```  
  
## VSTO Add-in Example  
  
### Description  
 The following code example illustrates an `entryPoints` element in an application manifest for an application-level solution deployed by using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
<vstav3:entryPoints>  
  <vstav3:entryPoint   
    class="ContosoOutlookAddIn.ThisAddIn">  
    <assemblyIdentity   
      name="ContosoOutlookAddIn"   
      version="1.0.0.0"   
      language="neutral"   
      processorArchitecture="msil" />  
  </vstav3:entryPoint>  
</vstav3:entryPoints>  
```  
  
## Multi-Project Deployment Example  
  
### Description  
 The following code example illustrates the `entryPoints` element in an application manifest for a multi-project deployment. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
<vstav3:entryPoints   
  id="ContosoExcel">  
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
</vstav3:entryPoints>  
<vstav3:entryPoints   
  id="ContosoOutlook">  
  <vstav3:entryPoint   
    class="ContosoOutlookAddIn.ThisAddIn">  
    <assemblyIdentity   
      name="ContosoOutlookAddIn"   
      version="1.0.0.0"   
      language="neutral"   
      processorArchitecture="msil" />  
  </vstav3:entryPoint>  
</vstav3:entryPoints>  
```  
  
## See Also  
 [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../vsto/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](/visualstudio/deployment/clickonce-application-manifest)  
  
  