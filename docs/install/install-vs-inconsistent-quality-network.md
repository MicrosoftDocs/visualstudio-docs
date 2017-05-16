---
title: "Install on low bandwidth or unreliable network environments | Microsoft Docs"
description: "Describes how the Visual Studio installer works in unreliable network conditions, and explains how to download install files before beginning the installation."
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

# Install Visual Studio 2017 on low bandwidth or unreliable network environments
We designed the new Visual Studio 2017 installer to work well in a wide variety of network and machine conditions.

- The files you'll need to install Visual Studio are distributed on a global delivery network, so we can get them to you from a local server;
- During the installation process, we try three different download technologies (WebClient, BITS and WinInet) to minimize interference with anti-virus and proxy software;
- The new workload-based model means you'll need to install less than with previous versions of Visual Studio.

We therefore recommend that you give the new web installer a try - we think you'll find it a good experience. But if you want to be sure that you've downloaded the installation files successfully before you start installing Visual Studio, we've got you covered. You can use the command line to create a local cache of the files you need before starting the install.

Here's how.

## Download the Visual Studio bootstrapper
Start by downloading the Visual Studio bootstrapper for your chosen edition of Visual Studio.

Your setup file&mdash;or to be more specific, a bootstrapper file&mdash;will match or be similar to one of the following.

| Edition                    | File                                                                    |
|----------------------------|-------------------------------------------------------------------------|
| Visual Studio Community    | [vs_community.exe](https://aka.ms/vs/15/release/vs_community.exe)       |
| Visual Studio Professional | [vs_professional.exe](https://aka.ms/vs/15/release/vs_professional.exe) |
| Visual Studio Enterprise   | [vs_enterprise.exe](https://aka.ms/vs/15/release/vs_enterprise.exe)     |

## Create a local install cache
To create a local layout, open a command prompt and use one of the commands from the following examples. The examples here assume that you've downloaded the Visual Studio Community bootstrapper: adjust the command as appropriate for your edition.

- For .NET web and .NET desktop development, run:
  ```
  vs_community.exe --layout c:\vs2017layout --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Component.GitHub.VisualStudio --includeOptional --lang en-US
  ```
- For .NET desktop and Office development, run:
  ```
  vs_community.exe --layout c:\vs2017layout --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.Office --includeOptional --lang en-US
  ```
- For C++ desktop development, run:
  ```
  vs_community.exe --layout c:\vs2017layout --add Microsoft.VisualStudio.Workload.NativeDesktop --includeRecommended --lang en-US
  ```

- To create a complete local layout with all features (this will take a long time - we have _lots_ of features!), run:
  ```
  vs_community.exe --layout c:\vs2017layout --lang en-US
  ```

If you want to install a language other than English, change `en-US` to a locale from the list at the bottom of this page. Use this [list of the components and workloads available](workload-and-component-ids.md) to further customize your installation cache as necessary.

## Install from the local cache
When you run from a local install cache, we'll use the local versions of each of these files. But if you select components during installation that aren't in the cache, we'll attempt to download them from the internet.

To ensure that you only install the files you've downloaded, use the same command-line options that you used to create the layout cache. For example, if you created a layout cache with the following command:

```
vs_community.exe --layout c:\vs2017layout --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Component.GitHub.VisualStudio --includeOptional --lang en-US
```

use this command to run the installation:

```
c:\vs2017layout\vs_community.exe --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Component.GitHub.VisualStudio --includeOptional
```

## List of language locales
| **Language-locale** | **Language** |
| ----------------------- | --------------- |  
| cs-CZ | Czech |
| de-DE | German |
| en-US | English |
| es-ES | Spanish |
| fr-FR | French |
| it-IT | Italian |
| ja-JP | Japanese |
| ko-KR | Korean |
| pl-PL | Polish |
| pt-BR | Portuguese - Brazil |
| ru-RU | Russian |
| tr-TR | Turkish |
| zh-CN | Chinese - Simplified |
| zh-TW | Chinese - Traditional |

## See also
* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
