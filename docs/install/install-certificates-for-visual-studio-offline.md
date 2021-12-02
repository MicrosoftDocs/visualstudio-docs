---
title: Install certificates for an offline installation
description: Learn how to install certificates for a Visual Studio offline installation.
ms.date: 03/29/2021
ms.topic: how-to
helpviewer_keywords:
- '{{PLACEHOLDER}}'
- '{{PLACEHOLDER}}'
ms.assetid: 9750A3F3-89C7-4A8F-BA75-B0B06BD772C2
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Install certificates required for Visual Studio offline installation

Visual Studio is primarily designed to be installed on an internet-connected machine, since many components are updated regularly. However, with some extra steps, it's possible to deploy Visual Studio in an environment where a working internet connection is unavailable.

The Visual Studio setup engine installs only content that is trusted. It does this by checking Authenticode signatures of the content being downloaded and verifying that all content is trusted before installing it. This keeps your environment safe from attacks where the download location is compromised. Visual Studio setup therefore requires that several standard Microsoft root and intermediate certificates are installed and up-to-date on a user's machine. If the machine has been kept up to date with Windows Update, signing certificates usually are up to date. If the machine is connected to the internet, during installation Visual Studio may refresh certificates as necessary to verify file signatures. If the machine is offline, the certificates must be refreshed another way.

## How to refresh certificates when offline

There are three options for installing or updating certificates in an offline environment.

### Option 1 - Manually install certificates from a layout folder

::: moniker range="vs-2017"

When you create a [network layout](../install/create-a-network-installation-of-visual-studio.md) or a [local offline cache](../install/create-an-offline-installation-of-visual-studio.md), the necessary certificates are downloaded to the Certificates folder. You can then manually install the certificates by double-clicking each of the certificate files, and then clicking through the Certificate Manager wizard. If asked for a password, leave it blank.

**Update**: For Visual Studio 2017 version 15.8 Preview 2 or later, you can manually install the certificates by right-clicking each of the certificate files, selecting Install Certificate, and then clicking through the Certificate Manager wizard.

::: moniker-end

::: moniker range=">=vs-2019"

When you create a [network layout](../install/create-a-network-installation-of-visual-studio.md) or a [local offline cache](../install/create-an-offline-installation-of-visual-studio.md), the necessary certificates are downloaded to the Certificates folder. You can manually install the certificates by right-clicking each of the certificate files, selecting Install Certificate, and then clicking through the Certificate Manager wizard. If asked for a password, leave it blank.

::: moniker-end

### Option 2 - Distribute trusted root certificates in an enterprise environment

For enterprises with offline machines that do not have the latest root certificates, an administrator can use the instructions on the [Configure Trusted Roots and Disallowed Certificates](/previous-versions/windows/it-pro/windows-server-2012-R2-and-2012/dn265983(v=ws.11)) page to update them.

### Option 3 - Install certificates as part of a scripted deployment of Visual Studio

If you are scripting the deployment of Visual Studio in an offline environment to client workstations, you should follow these steps:

1. Copy the [Certificate Manager Tool](/dotnet/framework/tools/certmgr-exe-certificate-manager-tool) (certmgr.exe) to the network layout or local cache installation location. Certmgr.exe is not included as part of Windows itself, but is available as part of the [Windows SDK](https://developer.microsoft.com/windows/downloads/windows-10-sdk).

2. Create a batch file with the following commands:

   ```shell
   certmgr.exe -add [layout path]\certificates\manifestRootCertificate.cer -n "Microsoft Root Certificate Authority 2011" -s -r LocalMachine root

   certmgr.exe -add [layout path]\certificates\manifestCounterSignRootCertificate.cer -n "Microsoft Root Certificate Authority 2010" -s -r LocalMachine root

   certmgr.exe -add [layout path]\certificates\vs_installer_opc.RootCertificate.cer -n "Microsoft Root Certificate Authority 2010" -s -r LocalMachine root
   ```
   
   Alternatively, create a batch file that uses certutil.exe, which ships with Windows, with the following commands:
   
      ```shell
   certutil.exe -addstore -f "Root" "[layout path]\certificates\manifestRootCertificate.cer"

   certutil.exe -addstore -f "Root" "[layout path]\certificates\manifestCounterSignRootCertificate.cer"

   certutil.exe -addstore -f "Root" "[layout path]\certificates\vs_installer_opc.RootCertificate.cer"
   ```

3. Deploy the batch file to the client. This command should be run from an elevated process.

## What are the certificates files in the Certificates folder?

* **manifestRootCertificate.cer** contains:
  * Root certificate: **Microsoft Root Certificate Authority 2011**
* **manifestCounterSignRootCertificate.cer** and **vs_installer_opc.RootCertificate.cer** contain:
  * Root certificate: **Microsoft Root Certificate Authority 2010**
 
The Visual Studio Installer requires only the root certificates to be installed on the system. All of these certificates are required for Windows 7 Service Pack 1 systems that do not have the latest Windows Updates installed.

## Why are the certificates from the Certificates folder not installed automatically?

When a signature is verified in an online environment, Windows APIs are used to download and add the certificates to the system. Verification that the certificate is trusted and allowed via administrative settings occurs during this process. This verification process cannot occur in most offline environments. Installing the certificates manually allows enterprise administrators to ensure the certificates are trusted and meet the security policy of their organization.

## Checking if certificates are already installed

One way to check on the installing system is to follow these steps:

1. Run **mmc.exe**.<br/>
  a. Click **File**, and then select **Add/Remove Snap-in**.<br/>
  b. Double-click **Certificates**, select **Computer account**, and then click **Next**.<br/>
  c. Select **Local computer**, click **Finish**, and then click **OK**.<br/>
  d. Expand **Certificates (Local Computer)**.<br/>
  e. Expand **Trusted Root Certification Authorities**, and then select **Certificates**.<br/>
    * Check this list for the necessary root certificates.<br/>

   f. Expand **Intermediate Certification Authorities**, and then select **Certificates**.<br/>
    * Check this list for the required intermediate certificates.<br/>

2. Click **File**, and then select **Add/Remove Snap-in**.<br/>
  a. Double-click **Certificates**, select **My user account**, click **Finish**, and then click **OK**.<br/>
  b. Expand **Certificates – Current User**.<br/>
  c. Expand **Intermediate Certification Authorities**, and then select **Certificates**.<br/>
    * Check this list for the required intermediate certificates.<br/>

If the certificates names were not in the **Issued To** columns, they must be installed.  If an intermediate certificate was only in the **Current User** Intermediate Certificate store, then it is available only to the user that is logged in. You might need to install it for other users.

## Install Visual Studio

After you install the certificates on the client machine, then you are ready to [install Visual Studio from the local cache](../install/create-an-offline-installation-of-visual-studio.md#step-3---install-visual-studio-from-the-local-cache), or [deploy Visual Studio from the network layout share](/visualstudio/install/create-a-network-installation-of-visual-studio#install-visual-studio-onto-a-client-machine-from-a-network-installation) to the client machine.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Create a network installation of Visual Studio](../install/create-a-network-installation-of-visual-studio.md)
* [Create an offline installation of Visual Studio](../install/create-an-offline-installation-of-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)

