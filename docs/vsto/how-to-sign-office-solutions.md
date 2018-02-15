---
title: "How to: Sign Office Solutions | Microsoft Docs"
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
  - "certificates [Office development in Visual Studio], Office solutions"
  - "security [Office development in Visual Studio], signing Office solutions"
  - "signing manifests [Office development in Visual Studio]"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Sign Office Solutions
  If you sign a solution, you can grant trust to the solution using the certificate as evidence. You can use the same certificate for multiple solutions, and all the solutions will be trusted with no additional security policy updates.  
  
 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]  
  
 If you manually edit application and deployment manifests by using the Manifest Generation and Editing Tool (mage.exe and mageui.exe), you must re-sign the manifests before you can use them. For more information, see [How to: Re-sign Application and Deployment Manifests](/visualstudio/deployment/how-to-re-sign-application-and-deployment-manifests).  
  
## Signing by Using a Certificate  
 A certificate is a file that contains a unique key and the identity of the solution publisher. You can purchase certificates from a certificate authority, or create your own certificate and have a certificate authority sign it.  
  
 Visual Studio signs Office solutions with a temporary certificate to enable debugging. You should not use the temporary certificate in deployed solutions as evidence.  
  
#### To sign an Office solution by using a certificate  
  
1.  On the **Project** menu, click *SolutionName***Properties**.  
  
2.  Click the **Signing** tab.  
  
3.  Select **Sign the ClickOnce manifests**.  
  
4.  Locate the certificate by clicking **Select from Store** or **Select from File** and navigating to the certificate.  
  
5.  To verify that the correct certificate is being used, click **More Details** to view the certificate information.  
  
## See Also  
 [Securing Office Solutions](../vsto/securing-office-solutions.md)   
 [Granting Trust to Office Solutions](../vsto/granting-trust-to-office-solutions.md)   
 [Signing Page, Project Designer](/visualstudio/ide/reference/signing-page-project-designer)  
  
  