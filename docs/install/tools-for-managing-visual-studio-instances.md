---
title: "Tools for detecting and managing Visual Studio instances | Microsoft Docs"
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
ms.assetid: 85686707-14C0-4860-9B7A-66485D43D241
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
# Tools for detecting and managing Visual Studio instances

TODO Add this (From: 
https://review.docs.microsoft.com/en-us/visualstudio/install/visual-studio-administrator-guide?branch=tglee-vsinstall#diagnostics)

## Diagnostics
### How to find and open the Visual Studio registry files
In Visual Studio 2017, the registry settings are stored in a private registry files. The registry files enable multiple installations of Visual Studio side-by-side, on the same machine.

However, these entries are no longer available in the global registry file. Here's how to find and open the registry files for Visual Studio 2017 by using RegEdit.

1. If you have it open, close **Visual Studio**.
2. Start **Regedit.exe**.
3. Select the ```HKEY_LOCAL_MACHINE``` node.
4. From the Regedit main menu, select **File > Load Hive...** and then select the private registry file, which on a Windows 10-based machine, is stored in the **AppData\Local** folder. <br/><br/>```%localappdata%\Microsoft\VisualStudio\<config>\privateregistry.bin```
<br/><br/>
(```<config>``` corresponds to the configuration hive that you would like to browse.)

You will be prompted to provide a hive name, which becomes the name of your isolated hive. After you do so, you should be able to browse the registry under the isolated hive that you created.

> [!IMPORTANT]
> Before you start Visual Studio again, you must unload the isolated hive that you created. To do this, select File -> Unload Hive from the Regedit main menu. (If you do not do this, then Regedit keeps the file locked and Visual Studio will not start.)