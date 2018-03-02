---
title: "&lt;postActions&gt; Element (Office Development in Visual Studio) | Microsoft Docs"
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
  - "application manifests [Office development in Visual Studio], <postActions> element"
  - "postActions element"
  - "<postActions> element"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# &lt;postActions&gt; Element (Office Development in Visual Studio)
  The `postActions` element of the `vstav3` namespace contains all the `postAction` elements that describe post-deployment actions, which run after Office solutions are installed.  
  
## Syntax  
  
```  
<postActions>  
  <postAction>  
    <entryPoint>  
    </entryPoint>  
    <postActionData>  
    </postActionData>  
  </postAction>  
</postActions>  
```  
  
## Elements and Attributes  
 The `postActions` element is optional and it is in the `vstav3` namespace. There is only one `postActions` element defined in an application manifest.  
  
 The `postActions` element has no attributes.  
  
 `postActions` has the following element.  
  
### postAction  
 Optional. The role of the `postAction` element in the `vstav3` namespace is defined in [&#60;postAction&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/postaction-element-office-development-in-visual-studio.md).  
  
## Post-Deployment Action Example  
  
### Description  
 The following code example illustrates the `postActions` element in an application manifest for an Office solution deployed by using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
<vstav3:postActions>  
  <vstav3:postAction>  
    <vstav3:entryPoint   
      class="PostDeploymentAction.PostDeploymentActionSample">  
      <assemblyIdentity   
        name="PostDeploymentAction"   
        version="1.0.0.0"   
        language="neutral"   
        processorArchitecture="msil" />  
    </vstav3:entryPoint>  
    <vstav3:postActionData>  
    </vstav3:postActionData>  
  </vstav3:postAction>  
</vstav3:postActions>  
```  
  
## See Also  
 [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../vsto/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](/visualstudio/deployment/clickonce-application-manifest)  
  
  