---
title: "MSBuild Error MSB3118"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9bf5b430-0cfb-4da5-a7f7-04d69f20cce1
caps.latest.revision: 7
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# MSBuild Error MSB3118
**MSB3118: Application is set to use application trust, but TargetFrameworkVersion is not v3.5.**  
  
 This error occurs when you set the <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.UseApplicationTrust?qualifyHint=False> property to `True` and set the <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion?qualifyHint=False> property to a version lower than `v3.5` (for example, `v2.0`).  
  
### To correct this error  
  
-   Set the <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion?qualifyHint=False> property to `v3.5` or higher.  
  
## See Also  
 <xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.UseApplicationTrust?qualifyHint=False>   
 <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.UseApplicationTrust?qualifyHint=False>   
 <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion?qualifyHint=False>   
 <xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.HostInBrowser?qualifyHint=False>   
 [Publish Page, Project Designer](../VS_IDE/Publish-Page--Project-Designer.md)   
 [MSBuild Error MSB3116](../VS_not_in_toc/MSBuild-Error-MSB3116.md)   
 [MSBuild Error MSB3117](../VS_not_in_toc/MSBuild-Error-MSB3117.md)   
 [MSBuild Error MSB3119](../VS_not_in_toc/MSBuild-Error-MSB3119.md)   
 [MSBuild Error MSB3174](../VS_not_in_toc/MSBuild-Error-MSB3174.md)   
 [MSBuild Error MSB3185](../VS_not_in_toc/MSBuild-Error-MSB3185.md)