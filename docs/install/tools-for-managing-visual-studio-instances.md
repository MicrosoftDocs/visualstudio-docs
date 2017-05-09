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

## Detecting existing Visual Studio instances
We have made several tools available that will help you detect and manage installed Visual Studio instances on client machines:

* [VSWhere](https://github.com/microsoft/vswhere): a C++ executable that helps you find the location of core Visual Studio tools from an installed instance of Visual Studio.
* [VSSetup.PowerShell](https://github.com/microsoft/vssetup.powershell): PowerShell scripts that use the Setup Configuration API to identify installed instances of Visual Studio.
* [VS-Setup-Samples](https://github.com/microsoft/vs-setup-samples): C# and C++ samples that demonstrate how to use the Setup Configuration API to query an existing installation.

In addition, the [Setup Configuration API](https://msdn.microsoft.com/en-us/library/microsoft.visualstudio.setup.configuration.aspx) provides interfaces for developers who want to build their own utilities for interrogating Visual Studio instances.

>[!TIP]
>For more information about Visual Studio 2017 installation, see [Heath Stewart's blog articles](https://blogs.msdn.microsoft.com/heaths/tag/vs2017/).


## Editing the registry for a Visual Studio instance
In Visual Studio 2017, registry settings are stored in a private location, which enables multiple side-by-side instances of the same version of Visual Studio on the same machine.

As these entries are not stored in the global registry, there are special instructions for using the Registry Editor to make changes to registry settings:

1. If you have an open instance of Visual Studio 2017, close it.
2. Start `regedit.exe`.
3. Select the `HKEY_LOCAL_MACHINE` node.
4. From the Regedit main menu, select **File -> Load Hive...** and then select the private registry file, which is stored in the **AppData\Local** folder. For example:
   ```
   %localappdata%\Microsoft\VisualStudio\<config>\privateregistry.bin
   ```

> [!NOTE]
> `<config>` corresponds to the instance of Visual Studio that you would like to browse.

You will be prompted to provide a hive name, which becomes the name of your isolated hive. After you do so, you should be able to browse the registry under the isolated hive that you created.

> [!IMPORTANT]
> Before you start Visual Studio again, you must unload the isolated hive that you created. To do this, select File -> Unload Hive from the Regedit main menu. (If you do not do this, then the file will remain locked and Visual Studio will not be able to start.)
