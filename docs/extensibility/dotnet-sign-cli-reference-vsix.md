---
title: Sign CLI reference for VSIX packages
description: The Sign CLI command can sign VSIX packages using certificates from PFX, Windows Certificate Manager (WCM), or Cryptographic Service Providers (CSP).
ms.topic: reference
helpviewer_keywords:
- signature
- signing
- sign
- pfx
- sha256
- authenticode
- vsix
- packages
- dotnet
author: javierdlg
ms.author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
ms.date: 04/11/2024
---

# Sign CLI Reference for VSIX Packages

`sign` - Dotnet tool used to sign files and containers using PFX, CER, or P7B certificates on disk or from Windows Certificate Manager (WCM), Cryptographic Service Providers (CSP), or Azure Key Vault.

> [!IMPORTANT]
> Sign CLI only supports `SHA-256`, `SHA-384`, and `SHA-512` as valid fingerprint algorithms. You can use PowerShell to get fingerprints using: `Get-FileHash -Algorithm SHA256 <path to .cer file> | Format-Table -AutoSize`

> [!IMPORTANT]
> Sign CLI only supports `RSA` algorithms, therefore using `ECDSA` to generate your fingerprint will fail signature validation during install. This doesn't block installation, but a “Invalid signature” warnings will show up under the VSIX Installer window during installation.

## Synopsis

```dotnetcli
sign code certificate-store [<PATH(s)>]
    [-cf|--certificate-file <PATH>]
    [-p|--password <PASSWORD>]
    [-cfp|--certificate-fingerprint <SHA>]
    [-csp|--crypto-service-provider <CSPNAME>]
    [-k|--key-container <HASHALGORITHM>]
    [-km|--use-machine-key-container]
    [-d|--description <DESCRIPTION>]
    [-u|--descriptionUrl <URL>]
    [-fd|--file-digest <DIGEST>]
    [-t|--timestamp-url <URL>]
    [-tr|--timestamp-rfc3161 <URL>]
    [-td|--timestamp-digest <DIGEST>]
    [-o|--output <PATH>]
    [-b|--base-directory <wORKINGDIRECTORY>]
    [-f|--force]
    [-m|--max-concurrency <MAXCONCURRENCY>]
    [-fl|--filelist <FILELISTPATH>]
    [-i]|--interactive

sign code certificate-store -h|--help
```

## Description

`Sign CLI` is a Dotnet tool that recursively signs files and containers with a certificate and private. The certificate and private key can be obtained from either a file (PFX, P7B, CER) or from a certificate installed in a certificate store by providing a `SHA-256`, `SHA-384`, or `SHA-512` fingerprint. USB keys can be accessed using a [Cryptographic Service Provider](/windows/win32/seccrypto/cryptographic-service-providers) (CSP) implemented by the manufacturer and accessed from the certificate store.

## Installation
Install Sign CLI globally using `dotnet tool install sign --prerelease --global`

### Offline Installation of Sign CLI
For isolated environments you can download a Sign CLI NuGet package and install it using:

```dotnetcli
dotnet tool install --global --add-source <path-to-folder> <tool-name> --version <version>
```

## Arguments

- **`VSIX-paths(s)`**

  Specifies the path(s) to the VSIX package to be signed.

## Options

- **`-cf|--certificate-file <PATH>`**

   PFX, P7B, or CER file containing a certificate and potentially a private key.

- **`-p|--password <PASSWORD>`**

   Optional password for certificate file.

- **`-cfp|--certificate-fingerprint <SHA>`**

   SHA-256, SHA-384, or SHA-512 fingerprint used to identify a certificate before signing.

- **`-csp|--crypto-service-provider <CSP NAME>`**

   Cryptographic Service Provider containing a private key. 
   
  > [!NOTE]
  > You can see all available CSPs by running `certutil -csplist`, where legacy CSPs specify a "Provider Type" and CNG providers usually have "Key Storage Provider" in their names. `certutil -csptest "<provider name>"` provides more information on specific providers.

- **`-k|--key-container <CONTAINER NAME>]`**

   Private key container name.

  > [!NOTE]
  > You can find all keys stored within a CSP by running `certutil -csp <Provider Name> -key`.

- **`-km|--use-machine-key-container]`**

   Use a machine-level private key container instead of the default user-level container.

- **`-d|--description <DESCRIPTION>`**

   Description of the signing certificate.

- **`-u|--descriptionUrl <URL>`**

   Description Url of the signing certificate.

- **`-fd | --file-digest <DIGEST>`**

   Digest algorithm to hash the file with.
   
- **`-t|--timestamp-url <URL>`**

   RFC 3161 timestamp server URL. [default: http://timestamp.acs.microsoft.com/]

- **`-tr | --timestamp-rfc3161 <URL>`**

   Specifies the RFC 3161 timestamp server's URL.

- **`-td|--timestamp-digest <DIGEST>`**

  Used with `-tr` switch to request a digest algorithm used by the RFC 3161 timestamp server.

- **`-o|--output <PATH>`**

  The output file or folder if multiple files are specified. If omitted, input is overwritten.

- **`-b|--base-directory <PATH>`**

  Base directory for files to override the working directory.

- **`--f|--force`**

  Overwrites a signature if it exists.

- **`-m|--max-concurrency <MAXCONCURRENCY>`**

  Maximum concurrency (default is 4)

- **`-fl | --filelist <PATH>`**

  Path to file containing paths of files to sign or to exclude from signing within the container.

- **`-?|-h|--help`**

  Prints a description of how to use the command.

- **`-i|--interactive`**

  Prompt for user input, which is required in some scenarios, such as when using a user-protected key, where a password must be entered by the user.

## Examples

- Sign *contoso.vsix* with a certificate imported to the **user** certificate store:

  ```dotnetcli
  sign code certificate-store contoso.vsix -cfp 24D589...FB9523B36E -d "Constoso VSIX Signature" -u "http://www.contoso.com"
  ```

- Sign *contoso.vsix* with certificate *cert.pfx* (not password protected) using a SHA-512 fingerprint:

  ```dotnetcli
  sign code certificate-store contoso.vsix -cfp A87A6F...894559B981 -cfpa sha512 -cf D:\certificates\cert.pfx -d "Constoso VSIX Signature" -u "http://www.contoso.com"
  ```

- Sign *contoso.vsix* with certificate *cert.pfx* (password protected):

  ```dotnetcli
  sign code certificate-store contoso.vsix -cfp 24D589...FB9523B36E -cf cert.pfx -p <password> -d "Constoso VSIX Signature" -u "http://www.contoso.com"
  ```

- Sign multiple VSIX packages - *contoso.vsix* and *all .vsix files in the directory specified* with certificate *cert.pfx* (not password protected):

  ```dotnetcli
  sign code certificate-store *.vsix -cfp 24D589...FB9523B36E -cf cert.pfx -d "Constoso VSIX Signature" -u "http://www.contoso.com"
  ```

- Sign *contoso.vsix* with a certificate stored in a secure USB drive.

  ```dotnetcli
  sign code certificate-store contoso.vsix -cfp 24D589...FB9523B36E -csp "Microsoft Software Key Storage Provider" -k "VsixSigning 0B2D249223B36D00A7DF07FB95E24D58" -d "Constoso VSIX Signature" -u "http://www.contoso.com"
  ```

- Sign *contoso.vsix* with a certificate stored in a secure USB drive and accessed from the **machine** certificate store (-km option).

  ```dotnetcli
  sign code certificate-store contoso.vsix -cfp 24D589...FB9523B36E -csp "Microsoft Software Key Storage Provider" -k "VsixSigning 0B2D249223B36D00A7DF07FB95E24D58" -km -d "Constoso VSIX Signature" -u "http://www.contoso.com"
  ```

  > [!NOTE]
  > When `-k` option isn't provided, the tool checks all containers in the provided CSP for a matching SHA fingerprint certificate.

- Sign *contoso.vsix* with a certificate stored in a secure USB drive specifying file digest algorithm (-fd), timestamp server (-t), and a custom output path (-o) for the signed VSIX.

  ```dotnetcli
  sign code certificate-store contoso.vsix -cfp 24D589...FB9523B36E -csp "Microsoft Software Key Storage Provider" -k "VsixSigning 0B2D249223B36D00A7DF07FB95E24D58" -d "Constoso VSIX Signature" -u "http://www.contoso.com" -t "http://timestamp.acs.microsoft.com/" -fd sha256 -o "ContosoSigned.vsix"
  ```
