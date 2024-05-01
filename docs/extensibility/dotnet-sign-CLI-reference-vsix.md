---
title: Dotnet sign CLI Reference for VSIX Packages
description: The dotnet sign command can sign VSIX packages using certificates from PFX, Windows Certificate Manager (WCM), or Cryptographic Service Providers (CSP).
ms.topic: how-to
helpviewer_keywords:
- signature
- signing
- sign
- pfx
- sha256
- authenticode
- vsix
- packages
author: javierdlg
ms.author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
ms.date: 04/11/2024
---

# Dotnet Sign CLI Reference for VSIX Packages

## Name

`sign` - Dotnet tool used to sign files and containers using PFX, CER, or P7B certificates on disk or from Windows Certificate Manager (WCM), Cryptographic Service Providers (CSP), or Azure Key Vault.

## Synopsis

```dotnetcli
sign code certificate-store [<PATH(s)>]
    [-o|--output <PATH>]
    [-b|--base-directory <wORKINGDIRECTORY>]
    [-f|--force]
    [-m|--max-concurrency <MAXCONCURRENCY>]
    [-fl|--filelist <FILELISTPATH>]
    [-s|--sha1 <SHA>]
    [-d|--description <DESCRIPTION>]
    [-u|--descriptionUrl <URL>]
    [-cf|--certificate-file <PATH>]
    [-p|--password <PASSWORD>]
    [-csp|--crypto-service-provider <CSPNAME>]
    [-k|--key-container <HASHALGORITHM>]
    [-km|--use-machine-key-container]
    [-fd|--file-digest <DIGEST>]
    [-t|--timestamp-url <URL>]
    [-tr|--timestamp-rfc3161 <URL>]
    [-td|--timestamp-digest <DIGEST>]

sign code certificate-store -h|--help
```

## Description

`sign` is a Dotnet tool that recursively signs files and containers with a certificate and private. The certificate and private key can be obtained from either a file (PFX, P7B, CER) or from a certificate installed in a certificate store by providing a SHA-1 fingerprint. USB keys can be accessed using a [Cryptographic Service Provider](/windows/win32/seccrypto/cryptographic-service-providers) implemented by the manufacturer and accessed from the certificate store.

## Installation
Install Sign globally using `dotnet tool install sign --version <version> --global`, where `<version>` is the latest available version under [Sign (nuget.org)](https://www.nuget.org/packages/sign).

## Arguments

- **`VSIX-paths(s)`**

  Specifies the file path to the VSIX package to be signed.

## Options

- **`-o|--output <PATH>`**

  The output file. If omitted, input is overwritten. Must be a directory if multiple files are specified.

- **`-b|--base-directory <PATH>`**

  Base directory for files to override the working directory.

- **`--f|--force`**

  Overwrites a signature if it exists.

- **`-m|--max-concurrency <MAXCONCURRENCY>`**

  Maximum concurrency (default is 4)

- **`-fl | --filelist <PATH>`**

  Path to a file with a list of file paths to sign within a container. Supports glob patterns and recursively enters and signs matching files for nested containers.

- **`-s|--sha1 <SHA>`**

   SHA-1 thumbprint used to identify a certificate within a certificate store.

- **`-d|--description <DESCRIPTION>`**

   Description of the signing certificate.

- **`-u|--certificate-store-location <STORENAME>`**

   Description Url of the signing certificate.

- **`-cf|--certificate-file <PATH>`**

   PFX, P7B, or CER file containing a certificate and potentially a private key.

- **`-p|--certificate-fingerprint <FINGERPRINT>`**

   Optional password for certificate file.

- **`-csp|--certificate-password <PASSWORD>`**

   Cryptographic Service Provider containing the private key.

- **`-k|--key-container <HASHALGORITHM>]`**

   Private key container name.

- **`-km|--use-machine-key-container]`**

   Use a machine-level private key container instead of the default user-level container.

- **`-fd | --file-digest <DIGEST>`**

   The digest algorithm to hash the file with.
   
- **`-t|--timestamp-url <URL>`**

   RFC 3161 timestamp server URL. [default: http://timestamp.acs.microsoft.com/]

- **`-tr | --timestamp-rfc3161 <URL>`**

   Specifies the RFC 3161 timestamp server's URL.

- **`-td|--timestamp-digest <DIGEST>`**

  Used with the -tr switch to request a digest algorithm used by the RFC 3161 timestamp server.

- **`-?|-h|--help`**

  Prints a description of how to use the command.

## Examples

- Sign *contoso.vsix* with a certificate imported to either user or machine certificate store:

  ```dotnetcli
  sign contoso.vsix -s 24D58920B2D24D00A7DF07FB9523B36E -d "Constoso VSIX Signature" -u "http://www.contoso.com"
  ```

- Sign *contoso.vsix* with certificate *cert.pfx* (not password protected):

  ```dotnetcli
  sign contoso.vsix -s 24D58920B2D24D00A7DF07FB9523B36E -cf cert.pfx -d "Constoso VSIX Signature" -u "http://www.contoso.com"
  ```

- Sign *contoso.vsix* with certificate *cert.pfx* (password protected):

  ```dotnetcli
  sign contoso.vsix -s 24D58920B2D24D00A7DF07FB9523B36E -cf cert.pfx -p <password> -d "Constoso VSIX Signature" -u "http://www.contoso.com"
  ```

- Sign multiple VSIX packages - *contoso.vsix* and *all .vsix files in the directory specified* with certificate *cert.pfx* (not password protected):

  ```dotnetcli
  sign *.vsix -s 24D58920B2D24D00A7DF07FB9523B36E -cf cert.pfx -d "Constoso VSIX Signature" -u "http://www.contoso.com"
  ```

- Sign *contoso.vsix* with a certificate stored in a secure USB drive

  ```dotnetcli
  sign contoso.vsix -s 24D58920B2D24D00A7DF07FB9523B36E -csp "Microsoft Software Key Storage Provider" -k "NuGetSigning 0B2D249223B36D00A7DF07FB95E24D58" -d "Constoso VSIX Signature" -u "http://www.contoso.com"
  ```
  > [!NOTE]
  > When the `-k` option isn't provided, the tool checks all containers in the provided CSP for a matching SHA-1 Thumbprint certificate.

- Sign *contoso.vsix* with a certificate stored in a secure USB drive specifying algorithm digest, timestamp server, and a custom output path for the signed VSIX

  ```dotnetcli
  sign contoso.vsix -s 24D58920B2D24D00A7DF07FB9523B36E -csp "Microsoft Software Key Storage Provider" -k "NuGetSigning 0B2D249223B36D00A7DF07FB95E24D58" -d "Constoso VSIX Signature" -u "http://www.contoso.com" -t sha256 -fd sha256 -o "ContosoSigned.vsix"
  ```