---
title: "Best Practices for Security in VSPackages | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "security [Visual Studio SDK]"
  - "security best practices, VSPackages"
  - "best practices, security"
ms.assetid: 212a0504-cf6c-4e50-96b0-f2c1c575c0ff
caps.latest.revision: 19
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Best Practices for Security in VSPackages
To install the [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)] on your computer, you must be running in a context with administrative credentials. The basic unit of security and deployment of a [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] application is the [VSPackages](../../extensibility/internals/vspackages.md). A VSPackage must be registered by using [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)], which also requires administrative credentials.  
  
 Administrators have full permissions to write to the registry and file system, and to run any code. You must have these permissions to develop, deploy, or install a VSPackage.  
  
 As soon as it is installed, a VSPackage is fully trusted. Because of this high level of permission associated with a VSPackage, it is possible to inadvertently install a VSPackage that has malicious intent.  
  
 Users should ensure that they install VSPackages only from trusted sources. Companies developing VSPackages should strongly name and sign them, to assure the user that tampering is prevented. Companies developing VSPackages should examine their external dependencies, such as web services and remote installation, to evaluate and correct any security issues.  
  
 For more information, see Secure Coding Guidelines for the .NET Framework ([http://msdn.microsoft.com/library/d55zzx87.aspx](http://msdn.microsoft.com/library/d55zzx87.aspx)).  
  
## See Also  
 [Add-In Security](../Topic/Add-In%20Security.md)   
 [DDEX Security](http://msdn.microsoft.com/en-us/44a52a70-5c98-450e-993d-4a3b32f69ba8)