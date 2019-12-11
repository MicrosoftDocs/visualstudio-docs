---
title: "ClickOnce and Authenticode | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - ".pfx files"
  - "ClickOnce deployment, Authenticode"
  - "Authenticode, ClickOnce"
  - "ClickOnce deployment, certificates"
  - "ClickOnce deployment, security"
ms.assetid: ab5b6712-f32a-4e33-842f-e88ab4818ccf
caps.latest.revision: 20
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# ClickOnce and Authenticode
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Authenticode* is a Microsoft technology that uses industry-standard cryptography to sign application code with digital certificates that verify the authenticity of the application's publisher. By using Authenticode for application deployment, [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] reduces the risk of a Trojan horse. A Trojan horse is a virus or other harmful program that a malicious third party misrepresents as a legitimate program coming from an established, trustworthy source. Signing [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployments with a digital certificate is an optional step to verify that the assemblies and files are not tampered.  
  
 The following sections describe the different types of digital certificates used in Authenticode, how certificates are validated using Certificate Authorities (CAs), the role of time-stamping in certificates, and the methods of storage available for certificates.  
  
## Authenticode and Code Signing  
 A *digital certificate* is a file that contains a cryptographic public/private key pair, along with metadata describing the publisher to whom the certificate was issued and the agency that issued the certificate.  
  
 There are various types of Authenticode certificates. Each one is configured for different types of signing. For [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] applications, you must have an Authenticode certificate that is valid for code signing. If you attempt to sign a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application with another type of certificate, such as a digital e-mail certificate, it will not work. For more information, see [Introduction to Code Signing](https://go.microsoft.com/fwlink/?LinkId=179452).  
  
 You can obtain a certificate for code signing in one of three ways:  
  
- Purchase one from a certificate vendor.  
  
- Receive one from a group in your organization responsible for creating digital certificates.  
  
- Generate your own certificate with MakeCert.exe, which is included with the [!INCLUDE[winsdklong](../includes/winsdklong-md.md)].  
  
### How Using Certificate Authorities Helps Users  
 A certificate generated using the MakeCert.exe utility is commonly called a *self-cert* or a *test cert*. This kind of certificate works much the same way that a .snk file works in the .NET Framework. It consists solely of a public/private cryptographic key pair, and contains no verifiable information about the publisher. You can use self-certs to deploy [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] applications with high trust on an intranet. However, when these applications run on a client computer, [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] will identify them as coming from an Unknown Publisher. By default, [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] applications signed with self-certs and deployed over the Internet cannot utilize Trusted Application Deployment.  
  
 By contrast, if you receive a certificate from a CA, such as a certificate vendor, or a department within your enterprise, the certificate offers more security for your users. It not only identifies the publisher of the signed software, but it verifies that identity by checking with the CA that signed it. If the CA is not the root authority, Authenticode will also "chain" back to the root authority to verify that the CA is authorized to issue certificates. For greater security, you should use a certificate issued by a CA whenever possible.  
  
 For more information about generating self-certs, see [Makecert.exe (Certificate Creation Tool)](https://msdn.microsoft.com/library/b0343f8e-9c41-4852-a85c-f8a0c408cf0d).  
  
### Timestamps  
 The certificates used to sign [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] applications expire after a certain length of time, typically twelve months. In order to remove the need to constantly re-sign applications with new certificates, [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] supports timestamp. When an application is signed with a timestamp, its certificate will continue to be accepted even after expiration, provided the timestamp is valid. This allows [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] applications with expired certificates, but valid timestamps, to download and run. It also allows installed applications with expired certificates to continue to download and install updates.  
  
 To include a timestamp in an application server, a timestamp server must be available. For information about how to select a timestamp server, see [How to: Sign Application and Deployment Manifests](../ide/how-to-sign-application-and-deployment-manifests.md).  
  
### Updating Expired Certificates  
 In earlier versions of the .NET Framework, updating an application whose certificate had expired could cause that application to stop functioning. To resolve this problem, use one of the following methods:  
  
- Update the .NET Framework to version 2.0 SP1 or later on Windows XP, or version 3.5 or later on Windows Vista.  
  
- Uninstall the application, and reinstall a new version with a valid certificate.  
  
- Create a command-line assembly that updates the certificate. Step-by-step information about this process can be found at [Microsoft Support Article 925521](https://go.microsoft.com/fwlink/?LinkId=179454).  
  
### Storing Certificates  
  
- You can store certificates as a .pfx file on your file system, or you can store them inside of a key container. A user on a Windows domain can have a number of key containers. By default, MakeCert.exe will store certificates in your personal key container, unless you specify that it should save it to a .pfx instead. Mage.exe and MageUI.exe, the [!INCLUDE[winsdkshort](../includes/winsdkshort-md.md)] tools for creating [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployments, enable you to use certificates stored in either fashion.  
  
## See Also  
 [ClickOnce Security and Deployment](../deployment/clickonce-security-and-deployment.md)   
 [Securing ClickOnce Applications](../deployment/securing-clickonce-applications.md)   
 [Trusted Application Deployment Overview](../deployment/trusted-application-deployment-overview.md)   
 [Mage.exe (Manifest Generation and Editing Tool)](https://msdn.microsoft.com/library/77dfe576-2962-407e-af13-82255df725a1)
