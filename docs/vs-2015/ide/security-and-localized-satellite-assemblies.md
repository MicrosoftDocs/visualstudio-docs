---
title: "Security and Localized Satellite Assemblies | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "key pairs for strong-named assemblies"
  - "strong-named assemblies, security considerations"
  - "satellite assemblies, localized"
  - "code signing, assemblies"
  - "security [Visual Studio], assemblies"
  - "strong-named assemblies, localized"
  - "assemblies [Visual Studio], security"
  - "localization, satellite assemblies"
ms.assetid: 6d953840-b301-47d5-8d34-30c1b29b5071
caps.latest.revision: 9
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
---
# Security and Localized Satellite Assemblies
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

If your main assembly uses strong naming, satellite assemblies must be signed with the same private key as the main assembly. If the public/private key pair does not match between the main and satellite assemblies, your resources will not be loaded. For more information on signing assemblies, see [How to: Sign an Assembly with a Strong Name](../Topic/How%20to:%20Sign%20an%20Assembly%20with%20a%20Strong%20Name.md).  
  
 In general, you may need to have your organization's signing group or an external signing organization sign with the private key. This is due to the sensitive nature of the private key: access is often restricted to a few individuals. You can use delayed signing during development. For more information, see [Delay Signing an Assembly](../Topic/Delay%20Signing%20an%20Assembly.md).  
  
## See Also  
 [Assembly Security Considerations](../Topic/Assembly%20Security%20Considerations.md)   
 [Key Security Concepts](../Topic/Key%20Security%20Concepts.md)   
 [Introduction to International Applications Based on the .NET Framework](../ide/introduction-to-international-applications-based-on-the-dotnet-framework.md)   
 [Localizing Applications](../ide/localizing-applications.md)   
 [Globalizing and Localizing Applications](../ide/globalizing-and-localizing-applications.md)

