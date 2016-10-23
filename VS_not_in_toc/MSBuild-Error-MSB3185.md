---
title: "MSBuild Error MSB3185"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 032c63c5-d662-42ba-84e1-e3ccca8cee05
caps.latest.revision: 11
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
# MSBuild Error MSB3185
**MSB3185: EntryPoint not specified for manifest.**  
  
 This error is generated when a manifest does not specify an entry point. This error can apply to both the application manifest and the deployment manifest.  
  
### To correct this error  
  
-   If using the GenerateApplicationManifest task, make sure that you specify a valid entry point or set the TargetFrameworkVersion property to "v3.5" or higher. For an application manifest, a valid entry point is an .exe file.  
  
-   If using the GenerateDeploymentManifest task, make sure that you specify valid entry points in your manifests. For a deployment manifest, a valid entry point is an application manifest.  
  
## See Also  
 <xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.HostInBrowser?qualifyHint=False>   
 <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion?qualifyHint=False>   
 [Publish Page, Project Designer](../VS_IDE/Publish-Page--Project-Designer.md)   
 [<PackageFiles\> Element](../VS_IDE/-PackageFiles--Element--Bootstrapper-.md)   
 [MSBuild Error MSB3116](../VS_not_in_toc/MSBuild-Error-MSB3116.md)   
 [MSBuild Error MSB3117](../VS_not_in_toc/MSBuild-Error-MSB3117.md)   
 [MSBuild Error MSB3118](../VS_not_in_toc/MSBuild-Error-MSB3118.md)   
 [MSBuild Error MSB3174](../VS_not_in_toc/MSBuild-Error-MSB3174.md)