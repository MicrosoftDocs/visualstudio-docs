---
title: "Special considerations for installing Visual Studio in an offline environment | Microsoft Docs"
description: "{{PLACEHOLDER}}"
ms.date: "05/09/2017"
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

## Create a network installation layout
* For details, see [Create a network-based installation of Visual Studio](create-a-network-installation-of-visual-studio.md)

## Install certificates needed for Visual Studio offline installation
The Visual Studio setup engine will only install content that is trusted.  It checks Authenticode signatures of the content being downloaded and verifies it is trusted before installing it.  Machines with internet access will automatically download and install any certificates necessary to verify file signatures.  However, if you are operating in an offline environment, or on a system with poor internet connectivity, this may not be possible.  For users in that environment, you need to ensure that the necessary certificates are pre-installed.  These certificates are downloaded by the executing machine to the "certificates" folder when creating an offline installation.

You can install the certificates on the client by manually double-clicking the certificate file and then clicking thru the certificate manager wizard. If asked for a password, leave it blank.

To script the installation of the certificates, follow these steps:

1. Copy certmgr.exe to the installation share (for example, `\server\share\vs2017`). `certmgr.exe` is included with the Windows SDK, which can be installed as an optional component in the _Universal Windows Platform development_ workload. (ex: `"C:\Program Files (x86)\Windows Kits\10\bin\x86\certmgr.exe"`)

2. Create a batch file with the following commands:

```cmd
\\server\share\vs2017\certmgr.exe -add -c \\server\share\vs2017\certificates\manifestSignCertificates.p12 -n "Microsoft Code Signing PCA" -s -r LocalMachine CA

\\server\share\vs2017\certmgr.exe -add -c \\server\share\vs2017\certificates\manifestSignCertificates.p12 -n "Microsoft Root Certificate Authority" -s -r LocalMachine root

\\server\share\vs2017\certmgr.exe -add -c \\server\share\vs2017\certificates\manifestCounterSignCertificates.p12 -n "Microsoft Time-Stamp PCA" -s -r LocalMachine CA

\\server\share\vs2017\certmgr.exe -add -c \\server\share\vs2017\certificates\manifestCounterSignCertificates.p12 -n "Microsoft Root Certificate Authority" -s -r LocalMachine root

\\server\share\vs2017\certmgr.exe -add -c \\server\share\vs2017\certificates\vs_installer_opc.SignCertificates.p12 -n "Microsoft Code Signing PCA" -s -r LocalMachine CA

\\server\share\vs2017\certmgr.exe -add -c \\server\share\vs2017\certificates\vs_installer_opc.SignCertificates.p12 -n "Microsoft Root Certificate Authority" -s -r LocalMachine root
```

3. Run the batch file on the client from an administrator command shell or elevated process.

### Why are the certificates from the `certificates` folder not installed automatically?
When a signature is verified in an online environment, Windows APIs are used to download and add the certificates to the system. Verification that the certificate is trusted and allowed via administrative settings occurs during this process. This verification process cannot occur in most offline environments. Installing the certificates manually allows the user to ensure the certificates are trusted and meet administrator requirements.

## Install Visual Studio
Having installed the certificates, deployment of Visual Studio can proceed offline without additional special steps, using the [instructions here](create-a-network-installation-of-visual-studio.md#deploying-from-a-network-installation).


## See also
* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Visual Studio workload and component IDs](workload-and-component-ids.md)
