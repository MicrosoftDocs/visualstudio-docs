---
title: "Update a network-based installation of Visual Studio | Microsoft Docs"
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
ms.assetid: 1AF69C0E-0AC9-451B-845D-AE4EDBCEA65C
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
# Update a network-based installation of Visual Studio

## How to update a local layout
You might want to update your local layout at a later date. Here's how.
* To refresh your local layout folder so that it includes the latest updates, run the same ```--layout``` command you ran when initially creating the layout. Make sure to point to the same folder that you used before with the same customizations (e.g. specific workloads and languages); this way, only those components that have been updated since you last ran ```--layout``` will be downloaded.  If you host a layout on a file share, it is recommended that you update a private copy of the layout (e.g. c:\vs2017offline) and after all of the updated content is downloaded, copy it to your file share (e.g. \\\\MyServer\products\VS2017).  If you don't do this, there is a greater chance that any users running setup while the layout is being updated may not be able to get all of the content from the layout since it is not completely updated.

## How to update an installed Visual Studio 
* Users can update a Visual Studio instance that was installed from an offline installation folder:
  * Run the Visual Studio Installer.
  * Then click **Update**.  
* Administrators can update their clients version of Visual Studio without any user interaction
  * Update the Visual Studio Installer:<br>```vs_enterprise.exe --quiet -–update```
  * Update the Visual Studio instance:<br>```vs_enterprise.exe update --installPath "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise" --quiet --wait –-norestart```
* For details on how to control when update notifications are presented to users, see [Install Visual Studio in an offline environment](install-visual-studio-in-offline-environment.md).

## See also
* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)

