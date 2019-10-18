---
title: "Trusted Application Deployment Overview | Microsoft Docs"
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
  - "ClickOnce deployment, security"
  - "trusted application deployment"
ms.assetid: b24a1702-8fbe-45b1-87a0-9618a0708f1d
caps.latest.revision: 33
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Trusted Application Deployment Overview
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic provides an overview of how to deploy [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] applications that have elevated permissions by using the Trusted Application Deployment technology.  
  
 Trusted Application Deployment, part of the [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment technology, makes it easier for organizations of any size to grant additional permissions to a managed application in a safer, more secure manner without user prompting. With Trusted Application Deployment, an organization  can just configure a client computer to have a list of trusted publishers, who are identified using Authenticode certificates. Thereafter, any [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application signed by one of these trusted publishers receives a higher level of trust.  
  
> [!NOTE]
> Trusted Application Deployment requires one-time configuration of a user's computer. In managed desktop environments, this configuration can be performed by using global policy. If this is not what you want for your application, use permission elevation instead. For more information, see [Securing ClickOnce Applications](../deployment/securing-clickonce-applications.md).  
  
## Trusted Application Deployment Basics  
 The following table shows the objects and roles that are involved in Trusted Application Deployment.  
  
|Object or role|Description|  
|--------------------|-----------------|  
|administrator|The organizational entity responsible for updating and maintaining client computers|  
|trust manager|The subsystem within the common language runtime (CLR) responsible for enforcing client application security.|  
|publisher|The entity that writes and maintains the application.|  
|deployer|The entity that packages and distributes the application to users.|  
|certificate|A cryptographic signature that consists of a public and private key; generally issued by a certification authority (CA) that can vouch for its authenticity.|  
|Authenticode certificate|A certificate with embedded metadata describing, among other things, the uses for which the certificate can be employed.|  
|certification authority|An organization that verifies the identity of publishers and issues them certificates embedded with the publisher's metadata.|  
|root authority|A certification authority that authorizes other Certificate Authorities to issue certificates.|  
|key container|A logical storage space in Microsoft Windows for storing certificates.|  
|trusted publisher|A publisher whose Authenticode certificate has been added to a certificate trust list (CTL) on a client computer.|  
  
 In larger organizations, the publisher and deployer are frequently two separate entities:  
  
- The publisher is the group that creates the [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application.  
  
- The deployer is the group, typically the information technology (IT) department, that distributes [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application to corporate enterprise desktop computers.  
  
  You must follow these steps to take advantage of Trusted Application Deployment:  
  
1. Obtain a certificate for the publisher.  
  
2. Add the publisher to the trusted publishers store on all clients.  
  
3. Create your [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application.  
  
4. Sign the deployment manifest with the publisher's certificate.  
  
5. Publish the application deployment to client computers.  
  
### Obtain a Certificate for the Publisher  
 Digital certificates are a core component of the Microsoft Authenticode authentication and security system. Authenticode is a standard part of the Windows operating system. All [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] applications must be signed with a digital certificate, regardless of whether they participate in Trusted Application Deployment. For a full explanation of how Authenticode works with [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)], see [ClickOnce and Authenticode](../deployment/clickonce-and-authenticode.md).  
  
### Add the Publisher to the Trusted Publishers Store  
 For your [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application to receive a higher level of trust, you must add your certificate as a trusted publisher to each client computer on which the application will run. Performing this task is a one-time configuration. After it is completed, you can deploy as many [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] applications signed with your publisher's certificate as you want, and they will all run with high trust.  
  
 If you are deploying your application in a managed desktop environment; for example, a corporate intranet running the Windows operating system; you can add trusted publishers to a client's store by creating a new certificate trust list (CTL) with Group Policy. For more information, see [Create a certificate trust list for a Group Policy object](http://go.microsoft.com/fwlink/?LinkId=102576).  
  
 If you are not deploying your application in a managed desktop environment, you have the following options for adding a certificate to the trusted publisher store:  
  
- The <xref:System.Security.Cryptography?displayProperty=fullName> namespace.  
  
- CertMgr.exe, which is a component of Internet Explorer and therefore exists on Windows 98 and all later versions. For more information, see [Certmgr.exe (Certificate Manager Tool)](https://msdn.microsoft.com/library/7e953b43-1374-4bbc-814f-53ca1b6b52bb).  
  
### Create a ClickOnce Application  
 A [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application is a [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] client application combined with manifest files that describe the application and supply installation parameters. You can turn your program into a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application by using the **Publish** command in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. Alternatively, you can generate all the files required for [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment by using tools that are included with the [!INCLUDE[winsdklong](../includes/winsdklong-md.md)]. For detailed steps about [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment, see [Walkthrough: Manually Deploying a ClickOnce Application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md).  
  
 Trusted Application Deployment is specific to [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)], and can only be used with [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] applications.  
  
### Sign the Deployment  
 After obtaining your certificate, you must use it to sign your deployment. If you are deploying your application by using the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Publish wizard, the wizard will automatically generate a test certificate for you if you have not specified a certificate yourself. You can also use the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Project Designer window, however, to supply a certificate provided by a CA.  Also see [How to: Publish a ClickOnce Application using the Publish Wizard](https://msdn.microsoft.com/library/31kztyey\(v=vs.110\)) or [How to: Publish a ClickOnce Application using the Publish Wizard](https://msdn.microsoft.com/library/31kztyey\(v=vs.110\)).  
  
> [!CAUTION]
> We do not recommend that the application be deployed with a test certificate.  
  
 You can also sign the application by using the Mage.exe or MageUI.exe SDK tools. For more information, see [Walkthrough: Manually Deploying a ClickOnce Application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md). For a full list of command-line options related to deployment signing, see [Mage.exe (Manifest Generation and Editing Tool)](https://msdn.microsoft.com/library/77dfe576-2962-407e-af13-82255df725a1).  
  
### Publish the Application  
 As soon as you have signed your [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] manifests, the application is ready to publish to your install location. The installation location can be a Web server, a file share, or the local disk. When a client accesses the deployment manifest for the first time, the trust manager must choose whether the [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application has been granted authority or not to run at a higher level of trust by an installed trusted publisher. The trust manager makes this choice by comparing the certificate used to sign the deployment with the certificates stored in the client's trusted publisher store. If the trust manager finds a match, the application runs with high trust.  
  
## Trusted Application Deployment and Permission Elevation  
 If the current publisher is not a trusted publisher, trust manager will use Permission Elevation to query the user about whether he or she wants to grant your application elevated permissions. If permission elevation is disabled by the administrator, however, the application cannot obtain permission to run. The application will not run and no notification will be displayed to the user. For more information about Permission Elevation, see [Securing ClickOnce Applications](../deployment/securing-clickonce-applications.md).  
  
## Limitations of Trusted Application Deployment  
 You can use Trusted Application Deployment to grant elevated trust to [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] applications deployed over the Web or through an enterprise file share. You do not have to use Trusted Application Deployment for [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] applications distributed on a CD, because, by default, these applications are granted full trust.  
  
## See also  
 [Mage.exe (Manifest Generation and Editing Tool)](https://msdn.microsoft.com/library/77dfe576-2962-407e-af13-82255df725a1)   
 [Walkthrough: Manually Deploying a ClickOnce Application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md)
