---
title: "Application and deployment manifests in Office solutions"
description: Learn how an application manifest is an XML file that provides information that is used by an Office solution to locate and update its assemblies.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: 02/02/2017
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "manifests [Office development in Visual Studio]"
  - "deployment manifests [Office development in Visual Studio]"
  - "application manifests [Office development in Visual Studio]"
  - "assemblies [Office development in Visual Studio], updating"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# Application and deployment manifests in Office solutions
  An application manifest is an XML file that provides information that is used by an Office solution to locate and update its assemblies. An application manifest can be used with a deployment manifest, which is an XML file stored on the server that provides the information needed to locate the most current version of the application manifest and assemblies.

 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

## Manifest structure for Office solutions
 For Microsoft Office solutions created by using the Office development tools in Visual Studio, all manifests are based on the standard ClickOnce schema. When you deploy your Office solutions, the application manifests for both document-level and VSTO Add-in projects are located in the ClickOnce cache. The deployment manifests are not copied to the client computer.

 For information about the contents of application and deployment manifests for Office projects, see [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md) and [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md).

## Create application and deployment manifests
 Application manifests are created automatically as part of the build process. Every time you build a document-level project, the location of the deployment manifest is embedded in the document as a custom document property. For VSTO Add-ins, the location of the deployment manifest is stored in the registry.

 For more information about the **Publish Wizard**, see [Deploy an Office solution by using ClickOnce](../vsto/deploying-an-office-solution-by-using-clickonce.md).

 For more information about how manifests work with Office solutions, see [Deploy an Office solution](../vsto/deploying-an-office-solution.md).

## See also

- [Architecture of document-level customizations](../vsto/architecture-of-document-level-customizations.md)
- [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)
- [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md)
- [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md)
- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)
- [ClickOnce deployment manifest](../deployment/clickonce-deployment-manifest.md)