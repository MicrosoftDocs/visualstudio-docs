---
title: Visual Studio support FIPS compliance mode
ms.date: 04/10/2020
ms.topic: conceptual
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
- multiple
---
# FIPS compliance mode support in Visual Studio

Starting with [version 16.4](/visualstudio/releases/2019/release-notes-v16.4/), Visual Studio 2019 supports [Federal Information Processing Standard (FIPS) Publication 140-2](/windows/security/threat-protection/fips-140-validation/) compliance mode for Windows, Azure, and .NET apps and solutions. And, with [version 16.5](/visualstudio/releases/2019/release-notes), Visual Studio now supports FIPS 140-2 compliance mode when you develop [C++ applications that target a remote Linux system](/cpp/linux/set-up-fips-compliant-secure-remote-linux-development/).

> [!NOTE]
> The tools that you use to develop apps for non-Microsoft platforms like iOS or Android might not use FIPS 140-2 approved algorithms. Third-party software included with Visual Studio or extensions that you install also might not use FIPS 140-2 approved algorithms. And, development for SharePoint solutions does not support FIPS 140-2 compliance mode.

## Enable FIPS mode

To configure FIPS 140-2 compliance mode for Visual Studio, [install .NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48). Then, in Windows, enable the Group Policy setting, **System cryptography: Use FIPS-compliant algorithms for encryption, hashing, and signing**. Here's how:

1. Press **Windows+R** to open the Run dialog, and then enter **gpedit.msc**.

1. In **Local Computer Policy**, expand **Computer Configuration > Windows Settings > Security Settings > Local Policies**, and then select **Security Options**.

1. Under **Policy**, select **System cryptography: Use FIPS-compliant algorithms for encryption, hashing, and signing**, and then press **Enter** to open its dialog box.

1. In the **Local Security Setting** tab, select **Enabled**, and then choose **OK** to save your changes.

> [!WARNING]
> Enabling FIPS mode may cause some applications to break or behave unexpectedly.

## See also

- [Linux, C++, & Visual Studio: Set up FIPS-compliance secure remote](/cpp/linux/set-up-fips-compliant-secure-remote-linux-development/)
- [.NET Core FIPS compliance](/dotnet/standard/security/fips-compliance/)
- [System cryptography: Use FIPS compliant algorithms for encryption, hashing, and signing](/windows/security/threat-protection/security-policy-settings/system-cryptography-use-fips-compliant-algorithms-for-encryption-hashing-and-signing)
- [FIPS 140-2 Validation](/windows/security/threat-protection/fips-140-validation/)
- [FIPS 140-2: Security Requirements for Cryptographic Modules](https://csrc.nist.gov/publications/detail/fips/140/2/final) (from NIST)
- [Cryptographic Algorithm Validation Program: Validation Notes](https://csrc.nist.gov/projects/cryptographic-algorithm-validation-program/Validation-Notes) (from NIST)
- [SSH Server Configuration](https://www.ssh.com/ssh/sshd_config)
