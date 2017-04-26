---
title: "Install on low bandwidth or unreliable network environments | Microsoft Docs"
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
ms.assetid: 44DB1998-68CD-4560-870A-EE5B993DCF6E
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

# Install Visual Studio 2017 in an inconsistent quality network
We understand that a lot of customers want a local installer for [Visual Studio 2017](https://go.microsoft.com/fwlink/?linkid=844067). Even though we don't offer an ISO image, it's easy to create a folder that you can use to install when offline.

Here's how.

## Download the setup file you want
**[Download](https://www.visualstudio.com/downloads?utm_source=mscom&utm_campaign=msdocs)** the edition of Visual Studio that you want. Make sure to click **Save**, and then click **Open folder**.

Your setup file&mdash;or to be more specific, a bootstrapper file&mdash;will match or be similar to one of the following.

|Edition | File|  
|-------------|-----------------------|  
|Visual Studio Enterprise |**vs_enterprise.exe**|  
|Visual Studio Professional |**vs_professional.exe**|  
|Visual Studio Community |**vs_community.exe**|

Other supported bootstrappers include vs_buildtools.exe, vs_feedbackclient.exe, vs_teamexplorer.exe, vs_testagent.exe, vs_testcontroller.exe, and vs_testprofessional.exe.

## Create a local installation folder
To create a local layout, use one of the commands from the following examples.

(Make sure that you run the command from your Download directory. Typically, that's `C:\Users\<username>\Downloads` on a computer that is running Windows 10).

- To create a complete local layout with all languages and all features
  - For Visual Studio Enterprise, run: <br>  ```vs_enterprise.exe --layout c:\vs2017layout```
  - For Visual Studio Professional, run: <br> ```vs_professional.exe --layout c:\vs2017layout```
  - For Visual Studio Community, run: <br> ```vs_community.exe --layout c:\vs2017layout```
- To create a partial local layout
  - For Visual Studio Enterprise with all workloads for one localized language, run: <br>  ```vs_enterprise.exe --layout c:\vs2017layout --lang en-US```
  - For Visual Studio Enterprise with one workload for one localized language, run: <br>  ```vs_enterprise.exe --layout c:\vs2017layout --add Microsoft.VisualStudio.Workload.ManagedDesktop --lang en-US```
  - For Visual Studio Enterprise with one workload plus its recommended and optional components, for one localized language, run: <br>  ```vs_enterprise.exe --layout c:\vs2017layout --add Microsoft.VisualStudio.Workload.ManagedDesktop --includeOptional --lang en-US```

For more examples, see the [How to customize your offline installer](create-a-network-installation-of-visual-studio.md#how-to-customize-your-offline-installer) section.

## Install from the local installation folder
Run your installation from the local layout now or later; the choice is yours to make. But when you do, follow these steps.

  1. Run the installation file. For example, run: <br> ```c:\vs2017layout\vs_enterprise.exe```

>  [!NOTE] 
>  For more details about how to customize the local installer see
>  [Create a network-based installation of Visual Studio](create-a-network-installation-of-visual-studio.md)

## See also
* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)

