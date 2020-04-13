---
title: Visual Studio support FIPS compliance mode
ms.date: 04/14/2020
ms.topic: conceptual
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
- multiple
---
# FIPS compliance mode support in Visual Studio

Starting with [version 16.4](/visualstudio/releases/2019/release-notes-v16.4/), Visual Studio 2019 supports Federal Information Processing Standard (FIPS) Publication 140-2 compliance mode for Windows, Azure, and .NET. And, with [version 16.5](/visualstudio/releases/2019/release-notes-v16.5/), Visual Studio now supports FIPS 140-2 compliance mode when you develop [C++ applications that target a remote Linux system](/cpp/linux/set-up-fips-compliant-secure-remote-linux-development/). To configure FIPS 140-2 compliance mode for Visual Studio, [install .NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48) and enable the Group Policy setting, **System cryptography: Use FIPS-compliant algorithms for encryption, hashing, and signing**.

For more information about FIPS 140-2 validation and how to enable it, see [FIPS 140-2 Validation](/windows/security/threat-protection/fips-140-validation/).

> [!NOTE]
> The tools that you use to develop apps for non-Microsoft platforms like iOS or Android might not use FIPS 140-2 approved algorithms. Third-party software included with Visual Studio or extensions that you install also might not use FIPS 140-2 approved algorithms. And, development for [SharePoint](/sharepoint/security-for-sharepoint-server/federal-information-processing-standard-security-standards/) solutions does not support FIPS 140-2 compliance mode.

## See also

- [Visual Studio: Set up FIPS-compliant secure remote Linux development with C++](/cpp/linux/set-up-fips-compliant-secure-remote-linux-development/)
- [Windows: System cryptography and using FIPS-compliant algorithms for encryption, hashing, and signing](/windows/security/threat-protection/security-policy-settings/system-cryptography-use-fips-compliant-algorithms-for-encryption-hashing-and-signing)
- [.NET Core: FIPS compliance](/dotnet/standard/security/fips-compliance/)
