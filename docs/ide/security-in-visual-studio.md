---
title: Security in Visual Studio
ms.date: 02/17/2017
ms.prod: visual-studio-dev15
ms.technology:  vs-ide-general
ms.topic: conceptual
helpviewer_keywords:
  - "code access security, coding errors"
  - "security [.NET Framework], about security"
ms.assetid: 318c34ce-f643-468c-83a1-843196f5d845
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Security in Visual Studio

You should consider security in all aspects of your application development, from design to deployment. Start by running Visual Studio as securely as possible. See [User permissions](../ide/user-permissions-and-visual-studio.md).

 To help you effectively develop secure applications, you should have a fundamental understanding of security concepts and the security features of the platforms for which you develop. You should also understand secure coding techniques.

## Understand security
 [Security](/dotnet/standard/security/index)
 Describes .NET Framework code access security, role-based security, security policy, and security tools.

 [Defend your code with top ten security tips every developer must know](http://go.microsoft.com/fwlink/?LinkId=72877)
 Describes the issues that you should watch out for so that you don't compromise your data or your system.

## Code for security
 Most coding errors that result in security vulnerabilities occur because developers make incorrect assumptions when working with user input or because they don't fully understand the platform for which they're developing.

 [Secure coding guidelines](/dotnet/standard/security/secure-coding-guidelines)
 Provides guidelines for classifying your components to address security issues.

 [Security best practices](/cpp/top/security-best-practices-for-cpp)
 Discusses buffer overruns and the complete picture of the Microsoft Visual C++ security checks feature provided by the /GS compile-time flag.

## Build for security
 Security is also an important consideration in the build process.  A few additional steps can improve the security of a deployed app, and help prevent unauthorized reverse engineering, spoofing, or other attacks.

 [Dotfuscator Community Edition (CE)](dotfuscator/index.md)
 Explains how to set up and start using the free PreEmptive Protection - Dotfuscator Community Edition to protect .NET assemblies from reverse-engineering and unauthorized use (such as unauthorized debugging).

 [Manage assembly and manifest signing](managing-assembly-and-manifest-signing.md)
 Discusses strong-name signing, which can be used to uniquely identify software components, preventing name spoofing.