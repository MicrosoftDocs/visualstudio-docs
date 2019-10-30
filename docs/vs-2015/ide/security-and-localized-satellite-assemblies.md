---
title: "Security and Localized Satellite Assemblies | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
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
author: jillre
ms.author: jillfra
manager: jillfra
---
# Security and Localized Satellite Assemblies
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

If your main assembly uses strong naming, satellite assemblies must be signed with the same private key as the main assembly. If the public/private key pair does not match between the main and satellite assemblies, your resources will not be loaded. For more information on signing assemblies, see [How to: Sign an Assembly with a Strong Name](https://msdn.microsoft.com/library/2c30799a-a826-46b4-a25d-c584027a6c67).

 In general, you may need to have your organization's signing group or an external signing organization sign with the private key. This is due to the sensitive nature of the private key: access is often restricted to a few individuals. You can use delayed signing during development. For more information, see [Delay Signing an Assembly](https://msdn.microsoft.com/library/9d300e17-5bf1-4360-97da-2aa55efd9070).

## See Also
 [Assembly Security Considerations](https://msdn.microsoft.com/library/1b5439c1-f3d5-4529-bd69-01814703d067)
 [Key Security Concepts](https://msdn.microsoft.com/library/3cfced4f-ea02-4e66-ae98-d69286363e98)
 [Introduction to International Applications Based on the .NET Framework](../ide/introduction-to-international-applications-based-on-the-dotnet-framework.md)
 [Localizing Applications](../ide/localizing-applications.md)
 [Globalizing and Localizing Applications](../ide/globalizing-and-localizing-applications.md)
