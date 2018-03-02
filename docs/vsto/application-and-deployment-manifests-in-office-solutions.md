---
title: "Application and Deployment Manifests in Office Solutions | Microsoft Docs"
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
  - "manifests [Office development in Visual Studio]"
  - "deployment manifests [Office development in Visual Studio]"
  - "application manifests [Office development in Visual Studio]"
  - "assemblies [Office development in Visual Studio], updating"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Application and Deployment Manifests in Office Solutions
  An application manifest is an XML file that provides information that is used by an Office solution to locate and update its assemblies. An application manifest can be used with a deployment manifest, which is an XML file stored on the server that provides the information needed to locate the most current version of the application manifest and assemblies.  
  
 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]  
  
## Manifest Structure for Office Solutions  
 For Microsoft Office solutions created by using the Office development tools in Visual Studio, all manifests are based on the standard ClickOnce schema. When you deploy your Office solutions, the application manifests for both document-level and VSTO Add-in projects are located in the ClickOnce cache. The deployment manifests are not copied to the client computer.  
  
 For information about the contents of application and deployment manifests for Office projects, see [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md) and [Deployment Manifests for Office Solutions](../vsto/deployment-manifests-for-office-solutions.md).  
  
## Creating Application and Deployment Manifests  
 Application manifests are created automatically as part of the build process. Every time you build a document-level project, the location of the deployment manifest is embedded in the document as a custom document property. For VSTO Add-ins, the location of the deployment manifest is stored in the registry.  
  
 For more information about the **Publish Wizard**, see [Deploying an Office Solution by Using ClickOnce](../vsto/deploying-an-office-solution-by-using-clickonce.md).  
  
 For more information about how manifests work with Office solutions, see [Deploying an Office Solution](../vsto/deploying-an-office-solution.md).  
  
## See Also  
 [Architecture of Document-Level Customizations](../vsto/architecture-of-document-level-customizations.md)   
 [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)   
 [Designing and Creating Office Solutions](../vsto/designing-and-creating-office-solutions.md)   
 [Application Manifests for Office Solutions](../vsto/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../vsto/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](/visualstudio/deployment/clickonce-application-manifest)   
 [ClickOnce Deployment Manifest](/visualstudio/deployment/clickonce-deployment-manifest)  
  
  