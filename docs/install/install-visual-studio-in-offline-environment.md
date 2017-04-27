---
title: "Special considerations for installing Visual Studio in an offline environment | Microsoft Docs"
description: "{{PLACEHOLDER}}"
ms.date: "04/14/2017"
ms.reviewer: ""
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

## Create a local layout
* For details, see [Create a network-based installation of Visual Studio](create-a-network-installation-of-visual-studio.md)

## Install certificates needed by VS Setup
VS Setup will only install content that is trusted.  It checks Authenticode signatures of the content being downloaded and verifies it is trusted before installing it.  Machines with internet access will automatically download and install any certificates necessary to verify file signatures.  However, if you are operating in an offline environment, or on a system with poor internet connectivity, this may not be possible.  For users in that environment, you need to ensure that the necessary certificates are pre-installed.  These certificates are downloaded by the executing machine to the "certificates" folder when creating an offline installation.
 
You can install the certificates on the client by manually double-clicking the certificate file and then clicking thru the certificate manager wizard.  If asked for a password, leave it blank.

To script the installation of the certificates, follow these steps:
1.  Copy certmgr.exe to the installation share (ex: ```\\server\share\vs2017```). Certmgr.exe is included with the Windows SDK, which can be installed as an optional component in the �Universal Windows Platform development� workload. (ex: ```"C:\Program Files (x86)\Windows Kits\10\bin\x86\certmgr.exe"```)

2.  Create a batch file with the following commands:
```batch
    \\server\share\vs2017\certmgr.exe -add -c \\server\share\vs2017\certificates\manifestSignCertificates.p12 -n "Microsoft Code Signing PCA" -s -r LocalMachine CA
    \\server\share\vs2017\certmgr.exe -add -c \\server\share\vs2017\certificates\manifestSignCertificates.p12 -n "Microsoft Root Certificate Authority" -s -r LocalMachine root
    \\server\share\vs2017\certmgr.exe -add -c \\server\share\vs2017\certificates\manifestCounterSignCertificates.p12 -n "Microsoft Time-Stamp PCA" -s -r LocalMachine CA
    \\server\share\vs2017\certmgr.exe -add -c \\server\share\vs2017\certificates\manifestCounterSignCertificates.p12 -n "Microsoft Root Certificate Authority" -s -r LocalMachine root
    \\server\share\vs2017\certmgr.exe -add -c \\server\share\vs2017\certificates\vs_installer_opc.SignCertificates.p12 -n "Microsoft Code Signing PCA" -s -r LocalMachine CA
    \\server\share\vs2017\certmgr.exe -add -c \\server\share\vs2017\certificates\vs_installer_opc.SignCertificates.p12 -n "Microsoft Root Certificate Authority" -s -r LocalMachine root
```
3.  Run the batch file on the client from an administrator command shell or elevated process.

#### �Why are the certificates from the �certificates� folder not installed automatically?�  
When a signature is verified in an online environment, Windows API�s are used to download and add the certificates to the system.  Verification that the certificate is trusted and allowed via administrative settings occurs during this process.  This verification process cannot occur in most offline environments.  Installing the certificates manually allows the user to ensure the certificates are trusted and meet administrator requirements.


## Install Visual Studio
* Users can do this by running ```vs_enterprise.exe``` in the offline layout folder.  Then, select the additional workloads and components you want to install and proceed with setup.  All the content will be installed from the offline layout.
* Admins can do this without requiring any user interaction by running:<br>```vs_enterprise.exe --quiet --wait -�norestart```
  * Most likely administrators will want to install more than just the core editor and will want to include other workloads and components.  To do that, run a command similar to this but with the workloads, components, and product languages you want:<br>```vs_enterprise.exe --installPath "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise" --quiet --wait -�norestart --add Microsoft.VisualStudio.Workload.ManagedDesktop --addProductLang de-DE```

## See also
* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Visual Studio workload and component IDs](workload-and-component-ids.md)
