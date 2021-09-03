---
title: Best Practices for Security in VSPackages | Microsoft Docs
description: Learn about the best practices for security in a VSPackage, the basic unit of security and deployment for a Visual Studio application.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- security [Visual Studio SDK]
- security best practices, VSPackages
- best practices, security
ms.assetid: 212a0504-cf6c-4e50-96b0-f2c1c575c0ff
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Best practices for security in VSPackages
To install the [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)] on your computer, you must be running in a context with administrative credentials. The basic unit of security and deployment of a [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] application is the [VSPackage](../../extensibility/internals/vspackages.md). A VSPackage must be registered by using [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)], which also requires administrative credentials.

 Administrators have full permissions to write to the registry and file system, and to run any code. You must have these permissions to develop, deploy, or install a VSPackage.

 As soon as it is installed, a VSPackage is fully trusted. Because of this high level of permission associated with a VSPackage, it is possible to inadvertently install a VSPackage that has malicious intent.

 Users should ensure that they install VSPackages only from trusted sources. Companies developing VSPackages should strongly name and sign them, to assure the user that tampering is prevented. Companies developing VSPackages should examine their external dependencies, such as web services and remote installation, to evaluate and correct any security issues.

 For more information, see [Secure coding guidelines for the .NET Framework](/previous-versions/visualstudio/visual-studio-2008/d55zzx87(v=vs.90)).

## See also
- [Add-in security](/previous-versions/1326zbk3(v=vs.140))
- [DDEX security](/previous-versions/bb163703(v=vs.140))