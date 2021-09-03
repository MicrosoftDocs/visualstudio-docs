---
title: Add trusted publisher to client box (ClickOnce)
description: Learn how to add a certificate to a client computer so that your ClickOnce applications run at a higher trust level without prompting the user.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - ClickOnce deployment, install without prompting
  - trusted application deployment, Trusted Publishers
ms.assetid: 35fe324c-45a1-4509-b7be-5c18b4b1b4ab
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload: 
  - multiple
---
# How to: Add a trusted publisher to a client computer for ClickOnce applications
With Trusted Application Deployment, you can configure client computers so that your [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] applications run with a higher level of trust without prompting the user. The following procedures show how to use the command-line tool CertMgr.exe to add a publisher's certificate to the Trusted Publishers store on a client computer.

 The commands you use vary slightly depending on whether the certificate authority (CA) that issued your certificate is part of a client's trusted root. If a Windows client computer is part of a domain, it will contain, in a list, CAs that are considered trusted roots. This list is usually configured by the system administrator. If your certificate was issued by one of these trusted roots, or by a CA that chains to one of these trusted roots, you can add the certificate to the client's trusted root store. If, on the other hand, your certificate was not issued by one of these trusted roots, you must add the certificate to both the client's Trusted Root store and Trusted Publisher store.

> [!NOTE]
> You must add certificates this way on every client computer to which you plan to deploy a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application that requires elevated permissions. You add the certificates either manually or through an application you deploy to your clients. You only need to configure these computers once, after which you can deploy any number of [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] applications signed with the same certificate.

 You may also add a certificate to a store programmatically using the <xref:System.Security.Cryptography.X509Certificates.X509Store> class.

 For an overview of Trusted Application Deployment, see [Trusted application deployment overview](../deployment/trusted-application-deployment-overview.md).

### To add a certificate to the Trusted Publishers store under the trusted root

1. Obtain a digital certificate from a CA.

2. Export the certificate into the Base64 X.509 (*.cer*) format. For more information about certificate formats, see [Export a certificate](/previous-versions/windows/it-pro/windows-server-2008-R2-and-2008/cc730988(v=ws.10)).

3. From the command prompt on client computers, run the following command:

     **certmgr.exe -add certificate.cer -c -s -r localMachine TrustedPublisher**

### To add a certificate to the Trusted Publishers store under a different root

1. Obtain a digital certificate from a CA.

2. Export the certificate into the Base64 X.509 (*.cer*) format. For more information about certificate formats, see [Export a Certificate](/previous-versions/windows/it-pro/windows-server-2008-R2-and-2008/cc730988(v=ws.10)).

3. From the command prompt on client computers, run the following command:

     **certmgr.exe -add good.cer -c -s -r localMachine Root**

     **certmgr.exe -add good.cer -c -s -r localMachine TrustedPublisher**

## See also
- [Walkthrough: Manually deploy a ClickOnce application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md)
- [Secure ClickOnce applications](../deployment/securing-clickonce-applications.md)
- [Code access security for ClickOnce applications](../deployment/code-access-security-for-clickonce-applications.md)
- [ClickOnce and Authenticode](../deployment/clickonce-and-authenticode.md)
- [Trusted application deployment overview](../deployment/trusted-application-deployment-overview.md)
- [How to: Enable ClickOnce security settings](../deployment/how-to-enable-clickonce-security-settings.md)
- [How to: Set a security zone for a ClickOnce application](../deployment/how-to-set-a-security-zone-for-a-clickonce-application.md)
- [How to: Set custom permissions for a ClickOnce application](../deployment/how-to-set-custom-permissions-for-a-clickonce-application.md)
- [How to: Debug a ClickOnce application with restricted permissions](securing-clickonce-applications.md)
- [How to: Add a trusted publisher to a client computer for ClickOnce applications](../deployment/how-to-add-a-trusted-publisher-to-a-client-computer-for-clickonce-applications.md)
- [How to: Re-sign application and deployment manifests](../deployment/how-to-re-sign-application-and-deployment-manifests.md)
- [How to: Configure the ClickOnce trust prompt behavior](../deployment/how-to-configure-the-clickonce-trust-prompt-behavior.md)