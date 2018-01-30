---
title: "Custom Document Properties Overview | Microsoft Docs"
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
  - "documents [Office development in Visual Studio], custom properties"
  - "custom document properties"
  - "document-level customizations [Office development in Visual Studio], custom properties"
  - "Office documents [Office development in Visual Studio], custom properties"
  - "_AssemblyLocation property"
  - "_AssemblyName property"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Custom Document Properties Overview
  When you build a document-level project, Visual Studio adds two custom properties to the document in the project: _AssemblyLocation and _AssemblyName. When a user opens a document, the Microsoft Office application checks for these custom document properties. If they exist in the document, the application loads the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)], which starts the customization. For more information, see [Architecture of Office Solutions in Visual Studio](../vsto/architecture-of-office-solutions-in-visual-studio.md).  
  
 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]  
  
## _AssemblyName  
 This property contains the CLSID of an interface in the Office solution loader component of the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)]. The CLSID value is 4E3C66D5-58D4-491E-A7D4-64AF99AF6E8B. You should never change this value.  
  
## _AssemblyLocation  
 This property contains a string that provides details about the deployment manifest for the customization. For more information about manifests, see [Application and Deployment Manifests in Office Solutions](../vsto/application-and-deployment-manifests-in-office-solutions.md).  
  
 The_AssemblyLocation property value can have different formats, depending on how the solution is deployed:  
  
-   If the solution is published to be installed from a Web site, UNC path, or a CD or USB drive, the _AssemblyLocation property has the format *DeploymentManifestPath*|*SolutionID*. The following string is an example:  
  
     file://deployserver/MyShare/ExcelWorkbook1.vsto|74744e4b-e4d6-41eb-84f7-ad20346fe2d9  
  
-   If you are running or debugging the solution from Visual Studio, the _AssemblyLocation property has the format *DeploymentManifestName*|*SolutionID*|vstolocal. The following string is an example:  
  
     ExcelWorkbook1.vsto|74744e4b-e4d6-41eb-84f7-ad20346fe2d9|vstolocal  
  
 The *SolutionID* is a GUID that the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] uses to identify the solution. The *SolutionID* is automatically generated when you build the project. The **vstolocal** term indicates to the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] that the assembly should be loaded from the same folder as the document.  
  
## See Also  
 [Architecture of Office Solutions in Visual Studio](../vsto/architecture-of-office-solutions-in-visual-studio.md)   
 [Architecture of Document-Level Customizations](../vsto/architecture-of-document-level-customizations.md)   
 [Application and Deployment Manifests in Office Solutions](../vsto/application-and-deployment-manifests-in-office-solutions.md)   
 [How to: Publish an Office Solution by Using ClickOnce](http://msdn.microsoft.com/en-us/2b6c247e-bc04-4ce4-bb64-c4e79bb3d5b8)   
 [How to: Create and Modify Custom Document Properties](../vsto/how-to-create-and-modify-custom-document-properties.md)  
  
  