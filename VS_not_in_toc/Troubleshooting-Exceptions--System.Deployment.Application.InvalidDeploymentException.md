---
title: "Troubleshooting Exceptions: System.Deployment.Application.InvalidDeploymentException"
ms.custom: na
ms.date: 10/01/2016
ms.devlang: 
  - JScript
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4361e053-8eaf-44e3-b8ac-95516d8d1832
caps.latest.revision: 22
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
# Troubleshooting Exceptions: System.Deployment.Application.InvalidDeploymentException
An <xref:System.Deployment.Application.InvalidDeploymentException?qualifyHint=False> exception is thrown when the application or its application and deployment manifests are not valid.  
  
## Associated Tips  
 **Make sure the manifests for this application are valid.**  
 An application manifest is an XML file that describes and identifies the shared and private side-by-side assemblies that an application should bind to at run time. These should be the same assembly versions that were used to test the application. Application manifests may also describe metadata for files that are private to the application.  
  
 **Use the ClickOnce feature to deploy the application.**  
 Use ClickOnce to publish Windows applications to a Web server or network file share for simplified installation. For more information, see [ClickOnce Security and Deployment](../VS_IDE/ClickOnce-Security-and-Deployment.md).  
  
## See Also  
 <xref:System.Deployment.Application.InvalidDeploymentException?qualifyHint=False>   
 [Use the Exception Assistant](../Topic/How%20to:%20Use%20the%20Exception%20Assistant.md)   
 [Troubleshooting ClickOnce Deployments](../VS_IDE/Troubleshooting-ClickOnce-Deployments.md)   
 [ClickOnce Deployment for Windows Forms](../Topic/ClickOnce%20Deployment%20for%20Windows%20Forms.md)