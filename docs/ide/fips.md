---
title: Visual Studio support for FIPS compliance
ms.date: 03/31/2020
ms.topic: conceptual
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
- multiple
---
# FIPS compliance support in Visual Studio 

Starting with [version 16.4](/visualstudio/releases/2019/release-notes-v16.4/), Visual Studio 2019 supports [Federal Information Processing Standard (FIPS) Publication 140-2](/windows/security/threat-protection/fips-140-validation/) compliance for Windows, Azure, and .NET apps and solutions. And, with [version 16.5](/visualstudio/releases/2019/release-notes), Visual Studio now supports FIPS 140-2 compliance mode when you develop [C++ applications that target a remote Linux system](/cpp/linux/set-up-fips-compliant-secure-remote-linux-development/).

> [!NOTE]
> Apps and solutions that you develop for non-Microsoft platforms like iOS or Android might not use FIPS 140-2 approved algorithms. Third-party software included with Visual Studio or extensions that you install also might not use FIPS 140-2 approved algorithms. And, development for [SharePoint] solutions does not support FIPS 140-2 compliance mode.

To configure FIPS 140-2 compliance mode for Visual Studio, [install .NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48) and then enable the Windows group policy setting, **System cryptography: Use FIPS compliant algorithms for encryption, hashing, and signing**.

## What is FIPS?

The FIPS 140-2 standard defines cryptographic algorithms approved for use by U.S. Federal government computer systems for the protection of sensitive data. 

An implementation of an approved cryptographic algorithm is considered FIPS 140-compliant only if it has been submitted for and has passed National Institute of Standards and Technology (NIST) validation. An implementation of an algorithm that hasn't been submitted can't be considered FIPS-compliant even if it produces identical data as a validated implementation of the same algorithm. 

The FIPS requirement to use approved and validated algorithms applies only to the protection of sensitive data. Systems and applications can use weak or non-validated cryptographic implementations for non-security purposes, such as in a hash table for indexing and lookup purposes.

## What FIPS mode does 

Enabling FIPS mode makes Windows and its subsystems use only FIPS-validated cryptographic algorithms. An example is [Schannel](/windows/win32/com/schannel), the system component that provides [SSL](/windows/win32/http/ssl-certificates) and TLS to applications. When FIPS mode is enabled, Schannel disallows SSL 2.0 and 3.0, protocols that fall short of the FIPS standards. Applications such as web browsers that use Schannel then cannot connect to HTTPS web sites that don't use at least TLS 1.0. 

Enabling FIPS mode also causes the .NET Framework to disallow the use of non-validated algorithms.  

## FIPS mode in Visual Studio

Say something here...and include info about setting up a remote.

### Connect to the remote system in Visual Studio

1. In Visual Studio, choose **Tools > Options** on the menu bar to open the **Options** dialog. Then, select **Cross Platform > Connection Manager** to open the Connection Manager dialog.

   If you haven't set up a connection in Visual Studio before, when you build your project for the first time, Visual Studio opens the Connection Manager dialog for you.

1. In the Connection Manager dialog, choose the **Add** button to add a new connection.

   ![Connection Manager](/cpp/media/settings_connectionmanager.png)

   The **Connect to Remote System** window is displayed.

   ![Connect to Remote System](/cpp/media/connect.png)

1. In the **Connect to Remote System** dialog, enter the connection details of your remote machine.

   | Entry | Description
   | ----- | ---
   | **Host Name**           | Name or IP address of your target device
   | **Port**                | Port that the SSH service is running on, typically 22
   | **User name**           | User to authenticate as
   | **Authentication type** | Choose Private Key for a FIPS-compliant connection
   | **Private key file**    | Private key file created for ssh connection
   | **Passphrase**          | Passphrase used with private key selected above

   Change the authentication type to **Private Key**. Enter the path to your private key in the **Private key file** field. You can use the **Browse** button to navigate to your private key file instead. Then, enter the passphrase used to encrypt your private key file in the **Passphrase** field.

1. Choose the **Connect** button to attempt a connection to the remote computer.

   If the connection succeeds, Visual Studio configures IntelliSense to use the remote headers. 

   If the connection fails, the entry boxes that need to be changed are outlined in red.

   ![Connection Manager Error](/cpp/linux/media/settings_connectionmanagererror.png)

   For more information on troubleshooting your connection, see [Connect to your remote Linux computer](/cpp/linux/connect-to-your-remote-linux-computer.md).

### Command-line utility for the Connection Manager  

**Visual Studio 2019 version 16.5 or later**: ConnectionManager.exe is a command-line utility to manage remote development connections outside of Visual Studio. It's useful for tasks such as provisioning a new development machine. Or, you can use it to set up Visual Studio for continuous integration. For examples and a complete reference to the ConnectionManager command, see [ConnectionManager reference](/cpp/linux/connectionmanager-reference.md).  

## FIPS mode in Windows

It's possible to enable FIPS mode globally in Windows.

1. To enable FIPS mode, press **Windows+R** to open the Run dialog, and then run gpedit.msc.

1. Expand **Local Computer Policy > Computer Configuration > Windows Settings > Security Settings > Local Policies** and select **Security Options**.

1. Under **Policy**, select **System cryptography: Use FIPS-compliant algorithms for encryption, hashing, and signing**, and then press **Enter** to open its dialog box.

1. In the **Local Security Setting** tab, select **Enabled** or **Disabled**, and then choose **OK** to save your changes.

> [!WARNING]
> Enabling FIPS mode may cause some applications to break or behave unexpectedly. For more information, see the blog post, [Why We're Not Recommending "FIPS mode" Anymore](https://techcommunity.microsoft.com/t5/microsoft-security-baselines/why-we-8217-re-not-recommending-8220-fips-mode-8221-anymore/ba-p/701037).

## See also

- [Linux, C++, & Visual Studio: Set up FIPS-compliance secure remote](/cpp/linux/set-up-fips-compliant-secure-remote-linux-development/)
- [.NET Core FIPS compliance](/dotnet/standard/security/fips-compliance/)
- [System cryptography: Use FIPS compliant algorithms for encryption, hashing, and signing](/windows/security/threat-protection/security-policy-settings/system-cryptography-use-fips-compliant-algorithms-for-encryption-hashing-and-signing)
- [FIPS 140-2 Validation](/windows/security/threat-protection/fips-140-validation/)
- [FIPS 140-2: Security Requirements for Cryptographic Modules](https://csrc.nist.gov/publications/detail/fips/140/2/final) (from NIST)
- [Cryptographic Algorithm Validation Program: Validation Notes](https://csrc.nist.gov/projects/cryptographic-algorithm-validation-program/Validation-Notes) (from NIST)
- [SSH Server Configuration](https://www.ssh.com/ssh/sshd_config)