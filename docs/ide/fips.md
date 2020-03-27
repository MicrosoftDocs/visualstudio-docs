---
title: Visual Studio support for FIPS compliance
ms.date: 03/27/2020
ms.topic: conceptual
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
- multiple
---
# FIPS support in Visual Studio 

Starting with [version 16.4](/visualstudio/releases/2019/release-notes-v16.4/), Visual Studio 2019 now supports [Federal Information Processing Standard (FIPS) Publication 140-2](/windows/security/threat-protection/fips-140-validation/) compliance for Windows, Azure, and .NET apps and solutions.

> [!NOTE]
> Apps and solutions that you develop for non-Microsoft platforms like Linux, iOS, or Android might not use FIPS 140-2 approved algorithms. Third-party software included with Visual Studio or extensions that you install also might not use FIPS 140-2 approved algorithms. And, development for SharePoint solutions does not support FIPS 140-2 compliance mode.

To configure FIPS 140-2 compliance mode for Visual Studio, [install .NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48) and then enable the Windows group policy setting: "System cryptography: Use FIPS compliant algorithms for encryption, hashing, and signing."

## What is FIPS?

The FIPS 140-2 standard defines cryptographic algorithms approved for use by U.S. Federal government computer systems for the protection of sensitive data. 

An implementation of an approved cryptographic algorithm is considered FIPS 140-compliant only if it has been submitted for and has passed National Institute of Standards and Technology (NIST) validation. An implementation of an algorithm that hasn't been submitted can't be considered FIPS-compliant even if it produces identical data as a validated implementation of the same algorithm. 

The FIPS requirement to use approved and validated algorithms applies only to the protection of sensitive data. Systems and applications can use weak or non-validated cryptographic implementations for non-security purposes, such as in a hash table for indexing and lookup purposes.

## What FIPS mode does

Enabling FIPS mode makes Windows and its subsystems use only FIPS-validated cryptographic algorithms. An example is [Schannel](/windows/win32/com/schannel), the system component that provides [SSL](/windows/win32/http/ssl-certificates) and TLS to applications. When FIPS mode is enabled, Schannel disallows SSL 2.0 and 3.0, protocols that fall short of the FIPS standards. Applications such as web browsers that use Schannel then cannot connect to HTTPS web sites that don't use at least TLS 1.0.

Enabling FIPS mode also causes the .NET Framework to disallow the use of non-validated algorithms. 

## See also

- [Linux, C++, & Visual Studio: Set up FIPS-compliance secure remote](/cpp/linux/set-up-fips-compliant-secure-remote-linux-development/)
- [App behavior with WIP](/windows/security/information-protection/windows-information-protection/app-behavior-with-wip)
