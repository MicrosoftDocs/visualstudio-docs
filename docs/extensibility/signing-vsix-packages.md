---
title: Signing VSIX Packages
description: Learn about signing extension assemblies. The VSIX installer displays a message that a VSIX is signed and information about the signature itself.
ms.date: 4/10/2024
ms.topic: how-to
helpviewer_keywords:
- signature
- signing
- authenticode
- vsix
- packages
author: jadelaga
ms.author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---
# Signing VSIX Packages

Extension assemblies don't need to be signed before they can run in Visual Studio, but it's a good practice to do so.

Adding a digital signature to a VSIX package secures your extension and prevents tampering. During install, the VSIX installer displays the signature and a hyperlink to the certificate. If the contents of the VSIX where modified, the VSIX installer marks the signature as invalid. Invalid signatures don't block installing extensions, but the user is warned.

> [!IMPORTANT]
> Beginning with Visual Studio 2015, VSIX packages signed using anything other than SHA256 encryption will be identified as having an invalid signature. VSIX installation is not blocked but the user will be warned.

## Signing a VSIX with Dotnet Sign
VSIXSignTool has migrated to [Dotnet/Sign (github.com)](https://github.com/dotnet/sign) and is now accessible as a dotnet tool. This tool is published to NuGet package as [Sign (nuget.org)](https://www.nuget.org/packages/sign) and can be used for local or cloud signing using Azure Key Vault.

Sign supports certificates and private keys stored in any combination of these locations:
- `PFX`, `P7B`, or `CER` files
- Imported into Windows Certificate Manager
- Stored in a USB device with access via a Cryptographic Service Provider (CSP)

#### Installing Dotnet Sign
1. Open a [Developer PowerShell](https://learn.microsoft.com/en-us/visualstudio/ide/reference/command-prompt-powershell?view=vs-2022) instance.

1. Verify nuget.org is added and enabled as a NuGet source.
    - Check your sources using `dotnet nuget list source` 
    - Add NuGet.org as a source using `dotnet nuget add source -n NuGet.org https://api.nuget.org/v3/index.json`

1. Install Sign by running `dotnet tool install sign --version <version> --global`, where `<version>` is the latest available version under [Sign (nuget.org)](https://www.nuget.org/packages/sign)
    - `--global` is optional but allows using sign outside of the PowerShell instance.


#### Using Dotnet Sign
Once installed, Sign can be accessed in a Developer PowerShell instance using `sign code <command> <options>`. For a breakdown of the options see [Dotnet Sign CLI Reference for VSIX Packages](../extensibility/dotnet-sign-CLI-reference-vsix.md).

- Signing using a PFX file with certificate and private key:
```shell
sign code certificate-store -s f5ec6169345347a7cd2f83af662970d5d0bfc914  -cf "D:\Certs\f5ec6169345347a7cd2f83af662970d5d0bfc914.pfx" -d "VSIX Signature" -u "http://timestamp.acs.microsoft.com/" "C:\Users\Contoso\Downloads\FingerSnapper2022.vsix"
```
##### Note: PFX files contain both certificate and private key used for signing and don't comply with C/A Browser Forum requirements for Extended Validation (EV) and non-EV signing. it's recommended to only use private keys stored in a Hardened Secure Module (HSM) device.

- Signing using Microsoft Certificate Manager:
```shell
code certificate-store -s f5ec6169345347a7cd2f83af662970d5d0bfc914 -csp "Microsoft Software Key Storage Provider" -d "VSIX Signature" -u "http://timestamp.acs.microsoft.com/" "C:\Users\Contoso\Downloads\FingerSnapper2022.vsix"
```

- Signing using a private key in a USB drive:
```shell
code certificate-store -s f5ec6169345347a7cd2f83af662970d5d0bfc914 -csp "eToken Base Cryptographic Provider" -d "VSIX Signature" -u "http://timestamp.acs.microsoft.com/" "C:\Users\Contoso\Downloads\FingerSnapper2022.vsix"
```

- Signing using a USB drive using a specific key container:
```shell
code certificate-store -s f5ec6169345347a7cd2f83af662970d5d0bfc914 -csp "eToken Base Cryptographic Provider" -k "NuGet Signing.629c9149345347cd2f83af6f5ec70d5d0a7bf616" -d "VSIX Signature" -u "http://timestamp.acs.microsoft.com/" "C:\Users\Contoso\Downloads\FingerSnapper2022.vsix"
```

#### Signing using PFX files


## Related content
- [Shipping Visual Studio Extensions](../extensibility/shipping-visual-studio-extensions.md)
- [Dotnet Sign CLI Reference for VSIX Packages](../extensibility/dotnet-sign-CLI-reference-vsix.md)