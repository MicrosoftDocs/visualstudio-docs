---
title: Visual Studio support for FIPS
titleSuffix: ''
description: Learn about how Visual Studio supports the Federal Information Processing Standard Publication 140-2 approved mode of operation for Windows, Azure, and .NET.
ms.date: 10/01/2021
ms.topic: article
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Visual Studio support for the FIPS 140-2 approved mode of operation

Starting with [version 16.4](/visualstudio/releases/2019/release-notes-v16.4/), Visual Studio 2019 supports the Federal Information Processing Standard (FIPS) Publication 140-2 approved mode of operation for Windows, Azure, and .NET. And, with [version 16.5](/visualstudio/releases/2019/release-notes-v16.5), Visual Studio now supports the FIPS 140-2 approved mode of operation when you develop [C++ applications that target a remote Linux system](/cpp/linux/set-up-fips-compliant-secure-remote-linux-development/).

To configure the FIPS 140-2 approved mode of operation for Visual Studio, [install .NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48) and then enable the Group Policy setting, **System cryptography: Use FIPS-compliant algorithms for encryption, hashing, and signing**.

For more information about the FIPS 140-2 approved mode of operation and how to enable it, see [FIPS 140-2 Validation](/windows/security/threat-protection/fips-140-validation/).

> [!NOTE]
> The tools that you use to develop apps for non-Microsoft platforms like iOS or Android might not use FIPS-compliant algorithms. Third-party software included with Visual Studio or extensions that you install also might not use FIPS-compliant algorithms. And, development for [SharePoint](/sharepoint/security-for-sharepoint-server/federal-information-processing-standard-security-standards/) solutions doesn't support the FIPS 140-2 approved mode of operation.

## Related content

To learn more about the FIPS 140-2 approved mode of operation for Visual Studio and for other Microsoft products and services, see the following links:

- [Visual Studio: Set up FIPS-compliant secure remote Linux development with C++](/cpp/linux/set-up-fips-compliant-secure-remote-linux-development/)
- [Windows: System cryptography and using FIPS-compliant algorithms for encryption, hashing, and signing](/windows/security/threat-protection/security-policy-settings/system-cryptography-use-fips-compliant-algorithms-for-encryption-hashing-and-signing)
- [.NET Core: FIPS compliance](/dotnet/standard/security/fips-compliance/)
