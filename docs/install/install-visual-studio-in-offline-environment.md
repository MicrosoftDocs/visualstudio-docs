---
title: "Special considerations for installing Visual Studio in an offline environment | Microsoft Docs"
description: "{{PLACEHOLDER}}"
ms.date: "06/05/2017"
ms.reviewer: "tims"
ms.suite: ""
ms.technology:
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords:
  - "{{PLACEHOLDER}}"
  - "{{PLACEHOLDER}}"
ms.assetid: 9750A3F3-89C7-4A8F-BA75-B0B06BD772C2
author: "timsneath"
ms.author: "tims"
manager: "ghogen"
translation.priority.ht:
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt:
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Special considerations for installing Visual Studio in an offline environment

Visual Studio is primarily designed for installation from an internet-connected machine, since many components are updated regularly. However, with some extra steps, it's possible to deploy Visual Studio in an environment where a working internet connection is unavailable.

## Install certificates needed for Visual Studio offline installation
The Visual Studio setup engine will only install content that is trusted. It does this by checking Authenticode signatures of the content being downloaded and verifying that all content is trusted before installing it. This keeps your environment safe from attacks where the download location is compromised. Visual Studio setup therefore requires that several standard Microsoft root and intermediate certificates are installed and up to date on a user's machine. If the machine has been kept updated with Windows Update, signing certificates are automatically updated, and during installation Visual Studio will refresh certificates as necessary to verify file signatures. 

For enterprises with offline machines that do not have the latest root certificates, an administrator can use the [instructions here](https://technet.microsoft.com/en-us/library/dn265983.aspx) to update them. Alternatively, the necessary certificates are downloaded during the creation of a network layout to the `certificates` folder and can be manually installed by double-clicking the certificate file and then clicking thru the certificate manager wizard. If asked for a password, leave it blank.

If you are scripting the deployment of Visual Studio in an offline environment to client workstations, you should follow these steps:

1. Copy the [Certificate Manager Tool](https://msdn.microsoft.com/en-us/library/e78byta0.aspx) (`certmgr.exe`) to the installation share (for example, `\\server\share\vs2017`). `certmgr.exe` is not included as part of Windows itself, but is available as part of the [Windows SDK](https://developer.microsoft.com/en-US/windows/downloads/windows-10-sdk). 

2. Create a batch file with the following commands:

   ```cmd
   certmgr.exe -add -c certificates\manifestSignCertificates.p12 -n "Microsoft Code Signing PCA 2011" -s -r LocalMachine CA
   
   certmgr.exe -add -c certificates\manifestSignCertificates.p12 -n "Microsoft Root Certificate Authority" -s -r LocalMachine root
   
   certmgr.exe -add -c certificates\manifestCounterSignCertificates.p12 -n "Microsoft Time-Stamp PCA 2010" -s -r LocalMachine CA
   
   certmgr.exe -add -c certificates\manifestCounterSignCertificates.p12 -n "Microsoft Root Certificate Authority" -s -r LocalMachine root
   
   certmgr.exe -add -c certificates\vs_installer_opc.SignCertificates.p12 -n "Microsoft Code Signing PCA" -s -r LocalMachine CA
   
   certmgr.exe -add -c certificates\vs_installer_opc.SignCertificates.p12 -n "Microsoft Root Certificate Authority" -s -r LocalMachine root
   ```

3. Deploy the batch file to the client. This command should be run from an elevated process.

### What are the certificates files in the `certificates` folder?
The three `.p12` files in this folder each contain an intermediate certificate and a root certificate. Most systems that are current with Windows Update will have these certificates already installed.

1. `ManifestSignCertificates.p12` contains:
    * Intermediate certificate: **Microsoft Code Signing PCA 2011**
        * Not required. Improves performance in some scenarios if present.
    * Root certificate: **Microsoft Root Certificate Authority 2011**
        * Required on Windows 7 Service Pack 1 systems that do not have the latest Windows Updates installed.
2. `ManifestCounterSignCertificates.p12`
    * Intermediate certificate: **Microsoft Time-Stamp PCA 2010**
        * Not required. Improves performance in some scenarios if present.
    * Root certificate: **Microsoft Root Certificate Authority 2010**
        * Required for Windows 7 Service Pack 1 systems that do not have the latest Windows Updates installed.
3. `vs_installer_opc.SignCertificates.p12`
    * Intermediate certificate: **Microsoft Code Signing PCA**
        * Required for all systems. Note that systems that with all updates applied from Windows Update may not have this certificate.
    * Root certificate: **Microsoft Root Certificate Authority**
        * Required. This certificate ships with systems running Windows 7 or later.

### Why are the certificates from the `certificates` folder not installed automatically?
When a signature is verified in an online environment, Windows APIs are used to download and add the certificates to the system. Verification that the certificate is trusted and allowed via administrative settings occurs during this process. This verification process cannot occur in most offline environments. Installing the certificates manually allows enterprise administrators to ensure the certificates are trusted and meet the security policy of their organization.

### Checking if certificates are already installed
One way to check on the installing system is to follow these steps:
* Run mmc.exe
* Click on File and select Add/Remove Snap-in
  * Double-click on **Certificates**, select **Computer account** and click **Next**
  * Select **Local computer**, click **Finish**, and click **Ok**
  * Expand **Certificates (Local Computer)**
  * Expand **Trusted Root Certification Authorities** and select **Certificates**
    * Check this list for the necessary root certificates.
  * Expand **Intermediate Certification Authorities** and select **Certificates**
    * Check this list for the required intermediate certificates.
* Click on File and select Add/Remove Snap-in
  * Double-click on **Certificates**, select **My user account**, click **Finish** and **OK**.
  * Expand **Certificates – Current User**
  * Expand **Intermediate Certification Authorities** and select **Certificates**
    * Check this list for the required intermediate certificates.
    
If the certificates names were not in the **Issued To** columns, they will need to be installed.  If an intermediate certificate was only in the **Current User** Intermediate Certificate store, then it is only available to the user that is logged in and could be needed to be installed for other users.

## Install Visual Studio
Having installed the certificates, deployment of Visual Studio can proceed offline without additional special steps, using the [instructions here](create-a-network-installation-of-visual-studio.md#deploying-from-a-network-installation).


## See also
* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Visual Studio workload and component IDs](workload-and-component-ids.md)
