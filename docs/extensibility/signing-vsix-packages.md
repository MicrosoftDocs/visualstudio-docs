---
title: Signing VSIX packages
description: Learn about signing extension assemblies. The VSIX installer displays a message that a VSIX is signed and information about the signature itself.
ms.date: 4/10/2024
ms.topic: how-to
helpviewer_keywords:
- signature
- signing
- authenticode
- vsix
- packages
author: javierdlg
ms.author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---

# Signing VSIX Packages
Extension assemblies don't need to be signed before they can run in Visual Studio, but it's a good practice to do so.

Adding a digital signature to a VSIX package secures your extension and prevents tampering. During install, the VSIX installer displays the signature and a link to the certificate. If the contents of the VSIX are modified without updating the signature, the installer only warns the user of an invalid package signature. This guide assumes you have already [created a VSIX](../extensibility/getting-started-with-the-vsix-project-template.md).

## Get a code signing certificate

Valid certificates can be obtained from a public certificate authority such as:

- [Certum](https://www.certum.eu/certum/cert,offer_en_open_source_cs.xml)
- [Comodo](https://www.comodo.com/e-commerce/code-signing/code-signing-certificate.php)
- [DigiCert](https://www.digicert.com/code-signing/)
- [GlobalSign](https://www.globalsign.com/en/code-signing-certificate/)
- [SSL.com](https://www.ssl.com/certificates/code-signing/)

The complete list of certification authorities trusted by Windows can also be obtained from [http://aka.ms/trustcertpartners](/security/trusted-root/participants-list).

You can use self-issued certificates for testing purposes. However, VSIX packages signed using self-issued certificates are not accepted by Visual Studio Marketplace. Learn more about [generating self-signed certificates with the .NET CLI](/dotnet/core/additional-tools/self-signed-certificates-guide).

## Signing a VSIX with Sign CLI
VSIXSignTool has been deprecated in favor of [Sign CLI (github.com)](https://github.com/dotnet/sign). This tool is published to NuGet as a dotnet tool under [Sign (nuget.org)](https://www.nuget.org/packages/sign) and supports local signing or using Azure Key Vault cloud signing.

For local signing, Sign CLI supports certificates and private keys stored in any combination of these locations:
- `PFX`, `P7B`, or `CER` files
- Imported into Windows Certificate Manager
- Stored in a USB device with access via a [Cryptographic Service Provider](/windows/win32/seccrypto/cryptographic-service-providers) (CSP)

### Installing Sign CLI
1. Open a [Developer PowerShell](/visualstudio/ide/reference/command-prompt-powershell) instance.

1. Verify nuget.org is added and enabled as a NuGet source.
    - Check your sources using `dotnet nuget list source` 
    - Add NuGet.org as a source using `dotnet nuget add source -n NuGet.org https://api.nuget.org/v3/index.json`

1. Install Sign by running `dotnet tool install sign --version <version> --global`, where `<version>` is the latest available version under [Sign (nuget.org)](https://www.nuget.org/packages/sign).
    - `--global` is optional and installs the tool in the .NET tools default location that is automatically added to the PATH environment variable.

### Offline Installation of Sign CLI
For isolated environments you can download the latest Sign CLI NuGet package and install it using:

```dotnetcli
dotnet tool install --global --add-source <path-to-folder> <tool-name> --version <version>
```

For example:

```dotnetcli
dotnet tool install --global --add-source D:\NuGetTools sign --version 99.0
```

### Using Sign CLI
Once installed, Sign CLI can be accessed in a Developer PowerShell instance using `sign code <command> <options>`. For a breakdown of the options see [Sign CLI Reference for VSIX Packages](../extensibility/dotnet-sign-CLI-reference-vsix.md). You can get help from command line by typing `sign code -h`.

> [!IMPORTANT]
> Sign CLI only supports `SHA-256`, `SHA-384`, and `SHA-512` as valid fingerprint algorithms. You can use PowerShell to get fingerprints using: `Get-FileHash -Algorithm SHA256 <path to .cer file> | Format-Table -AutoSize`

- Signing using a PFX file with a SHA-256 fingerprint:

```dotnetcli
sign code certificate-store -cfp 80BB567B...52CB95D4C -cf "D:\Certs\f5ec6169345347a7cd2f83af662970d5d0bfc914.pfx" -d "My VSIX Signature" -t "http://timestamp.acs.microsoft.com/" "C:\Users\Contoso\Downloads\FingerSnapper2022.vsix"
```

> [!NOTE]
> PFX files contain both certificate and private key used for signing and don't comply with C/A Browser Forum requirements for Extended Validation (EV) and non-EV signing. it's recommended to only use private keys stored in a Hardened Secure Module (HSM) device and access them using a Cryptographic Service Provider (CSP).

- Signing using Microsoft Certificate Manager and a SHA512 fingerprint (-csp option):

```dotnetcli
sign code certificate-store -cfp A87A60A6F...894559B98 -csp "Microsoft Software Key Storage Provider" -d "VSIX Signature" -t "http://timestamp.acs.microsoft.com/" "C:\Users\Contoso\Downloads\FingerSnapper2022.vsix"
```

- Signing using a private key in a USB drive (-csp option):

```dotnetcli
sign code certificate-store -cfp B113E82D...F5CF294BE0B -csp "eToken Base Cryptographic Provider" -d "VSIX Signature" -t "http://timestamp.acs.microsoft.com/" "C:\Users\Contoso\Downloads\FingerSnapper2022.vsix"
```

- Signing using a USB drive using a specific key container (-csp and -k options):

```dotnetcli
sign code certificate-store -cfp 15BB56B0...1ACB959D0 -csp "eToken Base Cryptographic Provider" -k "NuGet Signing.629c9149345347cd2f83af6f5ec70d5d0a7bf616" -d "VSIX Signature" -t "http://timestamp.acs.microsoft.com/" "C:\Users\Contoso\Downloads\FingerSnapper2022.vsix"
```

## Related content
- [Shipping Visual Studio Extensions](../extensibility/shipping-visual-studio-extensions.md)
- [Sign CLI Reference for VSIX Packages](../extensibility/dotnet-sign-CLI-reference-vsix.md)
