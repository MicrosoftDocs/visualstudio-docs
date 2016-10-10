---
title: "MSBuild Error MSB3116"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: bf04c587-d0e2-4d68-bbff-da9a985ea70e
caps.latest.revision: 12
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
# MSBuild Error MSB3116
**MSB3116: Application is marked to host in browser but is also marked for online and offline use. Please change your application to online only.**  
  
 When deploying a WPF Web Browser Application, you must set the <xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.HostInBrowser?qualifyHint=False> property to `True`. When <xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.HostInBrowser?qualifyHint=False> is set to `True`, you must set the <xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.DeployManifest.Install?qualifyHint=False> property to `False` (to make the installation available online only). If the latter condition is not met, you will receive this error message.  
  
### To correct this error  
  
-   Set the <xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.DeployManifest.Install?qualifyHint=False> property to `False`.  
  
## See Also  
 <xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.HostInBrowser?qualifyHint=False>   
 <xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.DeployManifest.Install?qualifyHint=False>   
 [Publish Page, Project Designer](../VS_IDE/Publish-Page--Project-Designer.md)