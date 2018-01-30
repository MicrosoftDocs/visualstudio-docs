---
title: "Granting Trust to Office Solutions | Microsoft Docs"
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
  - "security [Office development in Visual Studio], trust"
  - "inclusion lists [Office development in Visual Studio], about inclusion lists"
  - "trust [Office development in Visual Studio], 2007 Office system"
  - "granting trust [Office development in Visual Studio]"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Granting Trust to Office Solutions
  Granting trust to Office solutions means modifying the security policy of each target computer to trust the solution assembly, application manifest, deployment manifest, and document. Trust can be granted to the Office solution by either you or the end user.  
  
 You can grant full trust to the Office solution by signing the application and deployment manifests.  
  
 End users can grant trust to the Office solution by making a trust decision in the [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)] trust prompt.  
  
 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]  
  
##  <a name="Signing"></a> Trusting the Solution by Signing the Application and Deployment Manifests  
 All application and deployment manifests for Office solutions must be signed with a certificate that identifies the publisher. Certificates provide a basis for making trust decisions.  
  
 A temporary certificate is created for you and granted trust at build time so the solution will run while you debug it. If you publish a solution that is signed with a temporary certificate, the end user will be prompted to make a trust decision.  
  
 If you sign the solution with a known and trusted certificate, the solution will automatically be installed without prompting the end user to make a trust decision. For more information about how to obtain a certificate for signing, see [ClickOnce and Authenticode](/visualstudio/deployment/clickonce-and-authenticode). After a certificate is obtained, the certificate must be explicitly trusted by adding it to the Trusted Publishers list. For more information, see [How to: Add a Trusted Publisher to a Client Computer for ClickOnce Applications](/visualstudio/deployment/how-to-add-a-trusted-publisher-to-a-client-computer-for-clickonce-applications).  
  
 If a developer signs the solution with a temporary certificate, an administrator can re-sign the customization with a known and trusted certificate by using the Manifest Generation and Editing Tool (mage.exe), which is one of the Microsoft .NET Framework tools. For more information about signing solutions, see [How to: Sign Office Solutions](../vsto/how-to-sign-office-solutions.md) and [How to: Sign Application and Deployment Manifests](/visualstudio/ide/how-to-sign-application-and-deployment-manifests).  
  
##  <a name="TrustPrompt"></a> Trusting the Solution by Using the ClickOnce Trust Prompt  
 [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)] prompts the end user to make the trust decision if there is no organization-wide policy that trusts the solution's certificate. If the end user grants trust to the solution, an inclusion list entry is created that contains a URL and a public key to store this trust decision. When a trusted customization is run later, the end user is not prompted again.  
  
 Administrators can disable the [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)] trust prompt or require that the prompt occur only for solutions that are signed with an Authenticode certificate. For more information about how to change these settings for the MyComputer, LocalIntranet, Internet, TrustedSites, and UntrustedSites zones, see [How to: Configure the ClickOnce Trust Prompt Behavior](/visualstudio/deployment/how-to-configure-the-clickonce-trust-prompt-behavior).  
  
## See Also  
 [Securing Office Solutions](../vsto/securing-office-solutions.md)   
 [Granting Trust to Documents](../vsto/granting-trust-to-documents.md)   
 [Troubleshooting Office Solution Security](../vsto/troubleshooting-office-solution-security.md)   
 [Specific Security Considerations for Office Solutions](../vsto/specific-security-considerations-for-office-solutions.md)  
  
  