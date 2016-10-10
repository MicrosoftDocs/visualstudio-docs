---
title: "How to: Add a Trusted Publisher to a Client Computer for ClickOnce Applications"
ms.custom: na
ms.date: 10/05/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-deployment
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 35fe324c-45a1-4509-b7be-5c18b4b1b4ab
caps.latest.revision: 10
manager: wpickett
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
# How to: Add a Trusted Publisher to a Client Computer for ClickOnce Applications
With Trusted Application Deployment, you can configure client computers so that your ClickOnce applications run with a higher level of trust without prompting the user. The following procedures show how to use the command-line tool CertMgr.exe to add a publisher's certificate to the Trusted Publishers store on a client computer.  
  
 The commands you use vary slightly depending on whether the certificate authority (CA) that issued your certificate is part of a client's trusted root. If a Windows client computer is part of a domain, it will contain, in a list, CAs that are considered trusted roots. This list is usually configured by the system administrator. If your certificate was issued by one of these trusted roots, or by a CA that chains to one of these trusted roots, you can add the certificate to the client's trusted root store. If, on the other hand, your certificate was not issued by one of these trusted roots, you must add the certificate to both the client's Trusted Root store and Trusted Publisher store.  
  
> [!NOTE]
>  You must add certificates this way on every client computer to which you plan to deploy a ClickOnce application that requires elevated permissions. You add the certificates either manually or through an application you deploy to your clients. You only need to configure these computers once, after which you can deploy any number of ClickOnce applications signed with the same certificate.  
  
 You may also add a certificate to a store programmatically using the <xref:System.Security.Cryptography.X509Certificates.X509Store?qualifyHint=False> class.  
  
 For an overview of Trusted Application Deployment, see [Trusted Application Deployment Overview](../VS_IDE/Trusted-Application-Deployment-Overview.md).  
  
### To add a certificate to the Trusted Publishers store under the trusted root  
  
1.  Obtain a digital certificate from a CA.  
  
2.  Export the certificate into the Base64 X.509 (.cer) format. For more information about certificate formats, see [Export a Certificate](http://go.microsoft.com/fwlink/?LinkId=164793).  
  
3.  From the command prompt on client computers, run the following command:  
  
     **certmgr.exe -add certificate.cer -c -s -r localMachine TrustedPublisher**  
  
### To add a certificate to the Trusted Publishers store under a different root  
  
1.  Obtain a digital certificate from a CA.  
  
2.  Export the certificate into the Base64 X.509 (.cer) format. For more information about certificate formats, see [Export a Certificate](http://go.microsoft.com/fwlink/?LinkId=164793).  
  
3.  From the command prompt on client computers, run the following command:  
  
     **certmgr.exe -add good.cer -c -s -r localMachine Root**  
  
     **certmgr.exe -add good.cer -c -s -r localMachine TrustedPublisher**  
  
## See Also  
 [Walkthrough: Manually Deploying a ClickOnce Application](../VS_IDE/Walkthrough--Manually-Deploying-a-ClickOnce-Application.md)   
 [Securing ClickOnce Applications](../VS_IDE/Securing-ClickOnce-Applications.md)   
 [Code Access Security for ClickOnce Applications](../VS_IDE/Code-Access-Security-for-ClickOnce-Applications.md)   
 [ClickOnce and Authenticode](../VS_IDE/ClickOnce-and-Authenticode.md)   
 [Trusted Application Deployment Overview](../VS_IDE/Trusted-Application-Deployment-Overview.md)   
 [How to: Enable ClickOnce Security Settings](../VS_IDE/How-to--Enable-ClickOnce-Security-Settings.md)   
 [How to: Set a Security Zone for a ClickOnce Application](../VS_IDE/How-to--Set-a-Security-Zone-for-a-ClickOnce-Application.md)   
 [How to: Set Custom Permissions for a ClickOnce Application](../VS_IDE/How-to--Set-Custom-Permissions-for-a-ClickOnce-Application.md)   
 [How to: Debug a ClickOnce Application with Restricted Permissions](../VS_IDE/How-to--Debug-a-ClickOnce-Application-with-Restricted-Permissions.md)   
 [How to: Add a Trusted Publisher to a Client Computer for ClickOnce Applications](../VS_IDE/How-to--Add-a-Trusted-Publisher-to-a-Client-Computer-for-ClickOnce-Applications.md)   
 [How to: Re-sign Application and Deployment Manifests](../VS_IDE/How-to--Re-sign-Application-and-Deployment-Manifests.md)   
 [How to: Configure the ClickOnce Trust Prompt Behavior](../VS_IDE/How-to--Configure-the-ClickOnce-Trust-Prompt-Behavior.md)