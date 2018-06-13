---
title: Security and Localized Satellite Assemblies
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
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
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Security and Localized Satellite Assemblies

If your main assembly uses strong naming, satellite assemblies must be signed with the same private key as the main assembly. If the public/private key pair does not match between the main and satellite assemblies, your resources will not be loaded. For more information on signing assemblies, see [How to: Sign an Assembly with a Strong Name](/dotnet/framework/app-domains/how-to-sign-an-assembly-with-a-strong-name).

 In general, you may need to have your organization's signing group or an external signing organization sign with the private key. This is due to the sensitive nature of the private key: access is often restricted to a few individuals. You can use delayed signing during development. For more information, see [Delay Signing an Assembly](/dotnet/framework/app-domains/delay-sign-assembly).

## See also

- [Assembly Security Considerations](/dotnet/framework/app-domains/assembly-security-considerations)  - [Key Security Concepts](/dotnet/standard/security/key-security-concepts)
- [Introduction to International Applications Based on the .NET Framework](../ide/introduction-to-international-applications-based-on-the-dotnet-framework.md)
- [Localizing Applications](../ide/localizing-applications.md)
- [Globalizing and Localizing Applications](../ide/globalizing-and-localizing-applications.md)