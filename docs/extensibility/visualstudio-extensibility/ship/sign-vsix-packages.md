---
title: Sign VSIX packages
description: Learn how to digitally sign Visual Studio extension VSIX packages using the Sign CLI tool for security, integrity verification, and trust.
ms.date: 04/01/2026
ms.topic: how-to
ms.author: tinali
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
monikerRange: ">=vs-2022"
---

# Sign VSIX packages

Extension assemblies don't need to be signed before they can run in Visual Studio, but it's a good practice to do so.

Adding a digital signature to a VSIX package secures your extension and prevents tampering. During install, the VSIX installer displays the signature and a link to the certificate. If the contents of the VSIX are modified without updating the signature, the installer warns the user of an invalid package signature.

## Get a code signing certificate

Valid certificates can be obtained from a public certificate authority such as:

- [Certum ↗](https://www.certum.eu/certum/cert,offer_en_open_source_cs.xml)
- [Comodo ↗](https://www.comodo.com/e-commerce/code-signing/code-signing-certificate.php)
- [DigiCert ↗](https://www.digicert.com/code-signing/)
- [GlobalSign ↗](https://www.globalsign.com/en/code-signing-certificate/)
- [SSL.com ↗](https://www.ssl.com/certificates/code-signing/)

The complete list of certification authorities trusted by Windows can also be obtained from [http://aka.ms/trustcertpartners ↗](/security/trusted-root/participants-list).

You can use self-issued certificates for testing purposes. However, VSIX packages signed using self-issued certificates are not accepted by Visual Studio Marketplace. Learn more about [generating self-signed certificates with the .NET CLI ↗](/dotnet/core/additional-tools/self-signed-certificates-guide).

## Sign a VSIX with Sign CLI

[Sign CLI ↗](https://github.com/dotnet/sign) is a dotnet tool that supports local signing and Azure Key Vault cloud signing. It's published on [NuGet as `sign` ↗](https://www.nuget.org/packages/sign). While VSIXSignTool is still available, future improvements are focused on Sign CLI.

For local signing, Sign CLI supports certificates and private keys stored in:

- `PFX`, `P7B`, or `CER` files
- Windows Certificate Manager
- A USB device with access via a [Cryptographic Service Provider ↗](/windows/win32/seccrypto/cryptographic-service-providers) (CSP)

### Install Sign CLI

1. Open a [Developer PowerShell ↗](/visualstudio/ide/reference/command-prompt-powershell) instance.
2. Verify nuget.org is added as a NuGet source:

   ```powershell
   dotnet nuget list source
   dotnet nuget add source -n NuGet.org https://api.nuget.org/v3/index.json
   ```

3. Install Sign CLI:

   ```powershell
   dotnet tool install sign --version <version> --global
   ```

   Replace `<version>` with the latest available version from [NuGet ↗](https://www.nuget.org/packages/sign).

For offline or isolated environments, download the Sign CLI NuGet package and install it using:

```powershell
dotnet tool install --global --add-source <path-to-folder> sign --version <version>
```

### Sign CLI reference

Once installed, access Sign CLI using `sign code <command> <options>`. Get help by running `sign code -h`.

> [!IMPORTANT]
> Sign CLI only supports `SHA-256`, `SHA-384`, and `SHA-512` as valid fingerprint algorithms. You can get fingerprints using PowerShell:
> `Get-FileHash -Algorithm SHA256 <path to .cer file> | Format-Table -AutoSize`

> [!IMPORTANT]
> Sign CLI only supports `RSA` algorithms. Using `ECDSA` to generate your fingerprint will fail signature validation during install (it doesn't block installation, but an "Invalid signature" warning appears).

#### Synopsis

```
sign code certificate-store [<PATH(s)>]
    [-cf|--certificate-file <PATH>]
    [-p|--password <PASSWORD>]
    [-cfp|--certificate-fingerprint <SHA>]
    [-csp|--crypto-service-provider <CSPNAME>]
    [-k|--key-container <CONTAINERNAME>]
    [-km|--use-machine-key-container]
    [-d|--description <DESCRIPTION>]
    [-u|--descriptionUrl <URL>]
    [-fd|--file-digest <DIGEST>]
    [-t|--timestamp-url <URL>]
    [-tr|--timestamp-rfc3161 <URL>]
    [-td|--timestamp-digest <DIGEST>]
    [-o|--output <PATH>]
    [-b|--base-directory <WORKINGDIRECTORY>]
    [-f|--force]
    [-m|--max-concurrency <MAXCONCURRENCY>]
    [-fl|--filelist <FILELISTPATH>]
    [-i|--interactive]
```

#### Common options

| Option | Description |
|--------|-------------|
| `-cf\|--certificate-file` | PFX, P7B, or CER file containing a certificate and potentially a private key |
| `-p\|--password` | Optional password for certificate file |
| `-cfp\|--certificate-fingerprint` | SHA-256, SHA-384, or SHA-512 fingerprint used to identify a certificate |
| `-csp\|--crypto-service-provider` | Cryptographic Service Provider containing a private key |
| `-k\|--key-container` | Private key container name |
| `-d\|--description` | Description of the signing certificate |
| `-t\|--timestamp-url` | RFC 3161 timestamp server URL (default: `http://timestamp.acs.microsoft.com/`) |
| `-o\|--output` | Output file or folder. If omitted, input is overwritten |
| `-f\|--force` | Overwrites an existing signature |

### Signing examples

**Sign using a PFX file:**

```powershell
sign code certificate-store -cfp 80BB567B...52CB95D4C -cf "D:\Certs\cert.pfx" -d "My Extension" -t "http://timestamp.acs.microsoft.com/" "MyExtension.vsix"
```

**Sign using Windows Certificate Manager:**

```powershell
sign code certificate-store -cfp A87A60A6F...894559B98 -csp "Microsoft Software Key Storage Provider" -d "My Extension" -t "http://timestamp.acs.microsoft.com/" "MyExtension.vsix"
```

**Sign using a USB hardware key:**

```powershell
sign code certificate-store -cfp B113E82D...F5CF294BE0B -csp "eToken Base Cryptographic Provider" -d "My Extension" -t "http://timestamp.acs.microsoft.com/" "MyExtension.vsix"
```

**Sign multiple VSIX files:**

```powershell
sign code certificate-store *.vsix -cfp 24D589...FB9523B36E -cf cert.pfx -d "My Extension" -u "http://www.contoso.com"
```

## Related content

- [Publish and distribute extensions](overview.md)
- [Publish to the Marketplace](publish-to-marketplace.md)
