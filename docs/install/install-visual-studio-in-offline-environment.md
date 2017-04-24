---
title: "Install Visual Studio in an offline environment | Microsoft Docs"
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
# Install Visual Studio in an offline environment

## Create an offline layout
* For details, see [Create a network-based installation of Visual Studio](create-a-network-installation-of-visual-studio.md)

## Install certificates needed by VS Setup
VS Setup will only install content that is trusted.  It checks Authenticode signatures of the content being downloaded and verifies it is trusted before installing it.  Machines with internet access will automatically download and install any certificates needed to verify file signatures.  However, if you are operating in an offline environment, this is not possible.  For users in that environment, you need to ensure that the needed certificates are already installed.  When creating a layout, the required certificates are created in the "certificates" folder.  

You can install the certificates by manually double-clicking the certificate file and then clicking thru the certificate manager wizard.  If asked for a password, leave it blank.

To script the installation of the certificates, you can run a command like this (repeat similar for all the certificate files):
```batch
"C:\Program Files (x86)\Windows Kits\8.1\bin\x86\certmgr.exe" -all -add -c \\server\share\VS2017\certificates\manifestSignCertificates.p12 -s -r localMachine root
```
Or run this PowerShell script.  Ensure that PowerShell is run as an administrator.
```batch
$certificatesPath = [System.IO.Path]::GetDirectoryName($myInvocation.MyCommand.Definition)
Get-ChildItem -Path "$certificatesPath" -Filter *.p12 | Import-PfxCertificate -CertStoreLocation cert:\localMachine\my
```

# TODO: verify this works.  DougHall will update this if there is a better/easier way to do this.


## Install Visual Studio
* Users can do this by running ```vs_enterprise.exe``` in the offline layout folder.  Then, select the additional workloads and components you want to install and proceed with setup.  All the content will be installed from the offline layout.
* Admins can do this without requiring any user interaction by running:<br>```vs_enterprise.exe --quiet --wait -–norestart```
  * Most likely administrators will want to install more than just the core editor and will want to include other workloads and components.  To do that, run a command similar to this but with the workloads, components, and product languages you want:<br>```vs_enterprise.exe --installPath "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise" --quiet --wait -–norestart --add Microsoft.VisualStudio.Workload.ManagedDesktop --addProductLang de-DE```

## See also
* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Visual Studio workload and component IDs](workload-and-component-ids.md)
