---
title: "Trusting Office Solutions by Using Inclusion Lists | Microsoft Docs"
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
  - "permissions [Office development in Visual Studio]"
  - "inclusion lists [Office development in Visual Studio], about inclusion lists"
  - "security [Office development in Visual Studio], inclusion lists"
  - "inclusion lists [Office development in Visual Studio]"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Trusting Office Solutions by Using Inclusion Lists
  Inclusion lists enable users to grant trust to Office solutions that are signed with a certificate that identifies the publisher. Inclusion lists are user-specific, and they can be used for document-level customizations and VSTO Add-ins.  
  
 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]  
  
 When a user starts an Office solution that has not been granted trust for that user, the Microsoft Office solution prompts him or her for a security decision with a [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)] trust prompt. If the user decides to trust the solution, the customization runs and the user is not prompted the next time.  
  
## Inclusion List and Windows Installer  
 Installing Office solutions into the Program Files directory by using Windows Installer requires administrator rights. For Office solutions in the Program Files directory, the Visual Studio Tools for Office Runtime no longer checks the inclusion list because the Office solutions have already been granted FullTrust permission.  
  
## ClickOnce Trust Prompt  
 By using the [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)] implementation for Office solutions, administrators can configure the trust prompt level to allow prompting, disable prompting, or require a trusted certificate. This configuration is done by using a registry key that controls access to the inclusion list.  
  
 If prompting is disabled, only solutions that have a trusted and known certificate can be installed. If the prompting level is set to Authenticode required, the solution must be signed with a certificate from a known authority, but it does not require a certificate that chains to a trusted root authority (a trusted certificate). If prompting is allowed, the solution could be signed with a certificate with an unknown identity. In this scenario, the trust decision is deferred to the end user, and a temporary certificate would be sufficient to install a solution.  
  
 For more information, see [How to: Configure Inclusion List Security](../vsto/how-to-configure-inclusion-list-security.md) and Table 2, titled Prompting Level Registry Key Value Launch Effects, in [Configuring ClickOnce Trusted Publishers](http://go.microsoft.com/fwlink/?LinkId=94774).  
  
## Structure of the Inclusion List  
 A valid inclusion list entry has two parts: a path to the deployment manifest, and the public key used to sign the solution. After a solution is added to the inclusion list, it is considered trusted. When the Office solution runs, the Office application compares the public key in the inclusion list with the signing key in the deployment manifest to verify that the solution that is currently running is the same as the original trusted version.  
  
## See Also  
 [Granting Trust to Office Solutions](../vsto/granting-trust-to-office-solutions.md)   
 [Securing Office Solutions](../vsto/securing-office-solutions.md)  
  
  