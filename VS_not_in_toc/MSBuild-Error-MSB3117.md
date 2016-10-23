---
title: "MSBuild Error MSB3117"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 18aec642-6000-4626-bf75-f3547769c780
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
# MSBuild Error MSB3117
**MSB3117: Application is set to host in browser but the TargetFrameworkVersion is set to v2.0.**  
  
 A WPF Web Browser Application was deployed with the <xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.HostInBrowser?qualifyHint=False> property set to `True`, but TargetFrameworkVersion was set to `v2.0` or `v3.0`. If you use this setting, you must also set the <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion?qualifyHint=False> property to a value of `v3.5` or higher.  
  
### To correct this error  
  
-   Set the <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion?qualifyHint=False> property to a value of `v3.5` or higher.  
  
## See Also  
 <xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.HostInBrowser?qualifyHint=False>   
 <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion?qualifyHint=False>   
 [Publish Page, Project Designer](../VS_IDE/Publish-Page--Project-Designer.md)   
 [MSBuild Error MSB3116](../VS_not_in_toc/MSBuild-Error-MSB3116.md)   
 [MSBuild Error MSB3118](../VS_not_in_toc/MSBuild-Error-MSB3118.md)   
 [MSBuild Error MSB3174](../VS_not_in_toc/MSBuild-Error-MSB3174.md)   
 [MSBuild Error MSB3185](../VS_not_in_toc/MSBuild-Error-MSB3185.md)