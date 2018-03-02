---
title: "&lt;postAction&gt; Element (Office Development in Visual Studio) | Microsoft Docs"
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
  - "application manifests [Office development in Visual Studio], <postAction> element"
  - "<postAction> element"
  - "postAction element"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# &lt;postAction&gt; Element (Office Development in Visual Studio)
  The `postAction` element of the `vstav3` namespace contains the `entrypoint` elements and all `postActionData` elements that are associated with post-deployment actions, which run after Office solutions are installed.  
  
## Syntax  
  
```  
<postAction>  
  <entryPoint>  
  </entryPoint>  
  <postActionData>  
  </postActionData>  
</postAction>  
```  
  
## Elements and Attributes  
 The `postAction` element is optional and it is in the `vstav3` namespace. There is one `postAction` element defined in an application manifest for each post-deployment action.  
  
 The `postAction` element has no attributes.  
  
 `postAction` has the following elements.  
  
### entryPoint  
 Optional. The role of the `entryPoint` element in the `vstav3` namespace is defined in [&#60;entryPoints&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/entrypoints-element-office-development-in-visual-studio.md).  
  
### postActionData  
 Optional. The role of the `postActionData` element in the `vstav3` namespace is defined in [&#60;postActionData&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/postactiondata-element-office-development-in-visual-studio.md).  
  
## Post-Deployment Action Example  
  
### Description  
 The following code example illustrates the `postAction` element in an application manifest for an Office solution that is deployed by using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
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
```  
  
## See Also  
 [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../vsto/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](/visualstudio/deployment/clickonce-application-manifest)  
  
  