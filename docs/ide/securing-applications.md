---
title: Security
ms.date: 06/01/2018
ms.topic: conceptual
helpviewer_keywords:
  - "security [Visual Studio], applications"
  - "application design, securability"
ms.assetid: 7d32c4cf-8bec-4307-a2a8-42f0ceddf3eb
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Secure applications

You should consider security in all aspects of your application development, from design to deployment. Start by running Visual Studio as securely as possible. See [User permissions](../ide/user-permissions-and-visual-studio.md).

To help you effectively develop secure applications, you should have a fundamental understanding of security concepts and the security features of the platforms for which you develop. You should also understand secure coding techniques.

## Code for security

Most coding errors that result in security vulnerabilities occur because developers make incorrect assumptions when working with user input, or because they don't fully understand the platform for which they're developing.

- [Secure coding guidelines](/dotnet/standard/security/secure-coding-guidelines) describes the different ways .NET code can be designed to work with the security system.
- [Security best practices for C++](/cpp/top/security-best-practices-for-cpp) contains information about security tools and practices for C++ developers.

## Build for security

Security is also an important consideration in the build process. A few additional steps can improve the security of a deployed app and help prevent unauthorized reverse engineering, spoofing, or other attacks:

- [Dotfuscator](dotfuscator/index.md) is free and helps to protect .NET assemblies from reverse-engineering and unauthorized use such as unauthorized debugging.
- [Strong-name signing](managing-assembly-and-manifest-signing.md) can be used to uniquely identify software components and prevent name spoofing.

## See also

- [Security in .NET](/dotnet/standard/security/index)
- [Azure security](/azure/security/)
- [Windows 10 Mobile security guide](/windows/security/threat-protection/windows-10-mobile-security-guide)
- [Apache Cordova platform security features](/visualstudio/cross-platform/tools-for-cordova/security/best-practices?view=toolsforcordova-2017)
- [ASP.NET Core security](/aspnet/core/security/?view=aspnetcore-2.1)
- [Windows Forms security](/dotnet/framework/winforms/windows-forms-security)