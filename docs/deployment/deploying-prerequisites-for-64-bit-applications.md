---
title: "Deploying Prerequisites for 64-bit Applications | Microsoft Docs"
description: Learn about the redistributables that you can use as prerequisites for ClickOnce deployment of applications on 64-bit platforms.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "deploying applications [Visual Studio], 64-bit"
  - "64-bit [Visual Studio]"
  - "64-bit programming [Visual Studio]"
  - "64-bit applications [Visual Studio]"
ms.assetid: 87399e20-5510-41e4-b5b7-4a87c5773f21
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload:
  - "multiple"
---
# Deploy prerequisites for 64-bit applications
ClickOnce deployment supports the installation of applications on 64-bit platforms. The target platforms are **x86** for 32-bit platforms, **x64** for machines supporting the AMD64 and EM64T instruction sets, and **Itanium** for the 64-bit Itanium processor.

## Prerequisites
 The following table lists the redistributables that you can use as prerequisites for your 64-bit application's installation.

 If you select a prerequisite that does not have 64-bit components, you may see a warning stating that the selected packages are not available for the 64-bit platform.

| Redistributable | x64 support | IA64 support |
| - |-------------|--------------|
| [!INCLUDE[vsto_runtime](../deployment/includes/vsto_runtime_md.md)] | Yes | No |
| Visual C++ 2010 Runtime Libraries (IA64) | No | Yes |
| Visual C++ 2010 Runtime Libraries (x64) | Yes | No |
| Microsoft .NET Framework 4 (x86 and x64) | Yes | |
| Microsoft .NET Framework 4 Client Profile (x86 and x64) | Yes | |

## See also
- [Deploy applications, services, and components](../deployment/deploying-applications-services-and-components.md)
- [How to: Install prerequisites with a ClickOnce application](../deployment/how-to-install-prerequisites-with-a-clickonce-application.md)
- [64-bit applications](/dotnet/framework/64-bit-apps)