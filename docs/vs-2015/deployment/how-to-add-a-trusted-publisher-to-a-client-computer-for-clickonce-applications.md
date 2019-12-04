---
title: "How to: Add a Trusted Publisher to a Client Computer for ClickOnce Applications | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "ClickOnce deployment, install without prompting"
  - "trusted application deployment, Trusted Publishers"
ms.assetid: 35fe324c-45a1-4509-b7be-5c18b4b1b4ab
caps.latest.revision: 12
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Add a Trusted Publisher to a Client Computer for ClickOnce Applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

With Trusted Application Deployment, you can configure client computers so that your [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] applications run with a higher level of trust without prompting the user. The following procedures show how to use the command-line tool CertMgr.exe to add a publisher's certificate to the Trusted Publishers store on a client computer.  
  
 The commands you use vary slightly depending on whether the certificate authority (CA) that issued your certificate is part of a client's trusted root. If a Windows client computer is part of a domain, it will contain, in a list, CAs that are considered trusted roots. This list is usually configured by the system administrator. If your certificate was issued by one of these trusted roots, or by a CA that chains to one of these trusted roots, you can add the certificate to the client's trusted root store. If, on the other hand, your certificate was not issued by one of these trusted roots, you must add the certificate to both the client's Trusted Root store and Trusted Publisher store.  
  
> [!NOTE]
> You must add certificates this way on every client computer to which you plan to deploy a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application that requires elevated permissions. You add the certificates either manually or through an application you deploy to your clients. You only need to configure these computers once, after which you can deploy any number of [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] applications signed with the same certificate.  
  
 You may also add a certificate to a store programmatically using the <xref:System.Security.Cryptography.X509Certificates.X509Store> class.  
  
 For an overview of Trusted Application Deployment, see [Trusted Application Deployment Overview](../deployment/trusted-application-deployment-overview.md).  
  
### To add a certificate to the Trusted Publishers store under the trusted root  
  
1. Obtain a digital certificate from a CA.  
  
2. Export the certificate into the Base64 X.509 (.cer) format. For more information about certificate formats, see [Export a Certificate](https://go.microsoft.com/fwlink/?LinkId=164793).  
  
3. From the command prompt on client computers, run the following command:  
  
     **certmgr.exe -add certificate.cer -c -s -r localMachine TrustedPublisher**  
  
### To add a certificate to the Trusted Publishers store under a different root  
  
1. Obtain a digital certificate from a CA.  
  
2. Export the certificate into the Base64 X.509 (.cer) format. For more information about certificate formats, see [Export a Certificate](https://go.microsoft.com/fwlink/?LinkId=164793).  
  
3. From the command prompt on client computers, run the following command:  
  
     **certmgr.exe -add good.cer -c -s -r localMachine Root**  
  
     **certmgr.exe -add good.cer -c -s -r localMachine TrustedPublisher**  
  
## See Also  
 [Walkthrough: Manually Deploying a ClickOnce Application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md)   
 [Securing ClickOnce Applications](../deployment/securing-clickonce-applications.md)   
 [Code Access Security for ClickOnce Applications](../deployment/code-access-security-for-clickonce-applications.md)   
 [ClickOnce and Authenticode](../deployment/clickonce-and-authenticode.md)   
 [Trusted Application Deployment Overview](../deployment/trusted-application-deployment-overview.md)   
 [How to: Enable ClickOnce Security Settings](../deployment/how-to-enable-clickonce-security-settings.md)   
 [How to: Set a Security Zone for a ClickOnce Application](../deployment/how-to-set-a-security-zone-for-a-clickonce-application.md)   
 [How to: Set Custom Permissions for a ClickOnce Application](../deployment/how-to-set-custom-permissions-for-a-clickonce-application.md)   
 [How to: Debug a ClickOnce Application with Restricted Permissions](../deployment/how-to-debug-a-clickonce-application-with-restricted-permissions.md)   
 [How to: Add a Trusted Publisher to a Client Computer for ClickOnce Applications](../deployment/how-to-add-a-trusted-publisher-to-a-client-computer-for-clickonce-applications.md)   
 [How to: Re-sign Application and Deployment Manifests](../deployment/how-to-re-sign-application-and-deployment-manifests.md)   
 [How to: Configure the ClickOnce Trust Prompt Behavior](../deployment/how-to-configure-the-clickonce-trust-prompt-behavior.md)
