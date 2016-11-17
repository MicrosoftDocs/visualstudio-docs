---
title: "Create an Offline Installation of Visual Studio 2017 RC | Microsoft Docs"
description: "Learn how to create an offline installation of Visual Studio."
ms.custom: ""
ms.date: "11/16/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords:
  - "offline installation [Visual Studio]"
  - "offline install [Visual Studio]"
  - "ISO [Visual Studio]"
ms.assetid: 7bd7e724-7bfd-43f1-9935-981919be5a00
author: "TerryGLee"
ms.author: "tglee"
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
# Create an offline installation of Visual Studio 2017 RC

## Create a layout
You can create an offline installation layout that contains all the files you need to install [Visual Studio 2017 RC](https://www.visualstudio.com/vs/visual-studio-2017-rc/) without requiring Internet access.  

#### To create an offline installation layout of Visual Studio
1. Download the Visual Studio setup executable file to a drive on your local machine.
  For example, [download the vs_enterprise.exe file](https://www.visualstudio.com/vs/visual-studio-2017-rc/).
2. Run `vs_enterprise.exe` with the following arguments (switches) from a command prompt:

   a. Add `--layout <path>`, where `<path>` is the location where you want the layout to download to. By default, all languages are downloaded. (See Example A.)

   b. Restrict the download to a single language by providing the `--lang <language>` argument, where `<language>` is one of the ISO country codes.  (See Example B and Example C.)

### Examples
**Example A**: Install all languages
  > ```vs_enterprise.exe --layout C:\layout```

**Example B**: Install one language  
  > ```vs_enterprise.exe --layout C:\layout --lang en-US```

**Example C**: Install multiple languages
  > ```vs_enterprise.exe --layout C:\layout --lang en-US de-DE ja-JP```

### Country codes  
| ISO Code | Language |
| -----   | ----- |
| cs-CZ	| Czech |
| de-DE	| German |
| en-US	| English |
| es-ES	| Spanish |
| fr-FR	| French |
| it-IT	| Italian |
| ja-JP	| Japanese |
| ko-KR	| Korean |
| pl-PL	| Polish |
| pt-BR	| Portuguese - Brazil |
| ru-RU	| Russian |
| tr-TR	| Turkish |
| zh-CN	| Chinese - Simplified |
| zh-TW	| Chinese - Traditional |


## Install from a layout
#### To install Visual Studio from an offline installation layout
1. On the target machine, navigate to the **Certificates** folder, which is in the Layout folder.
2. Right-click and install each certificate in the **Certificates** folder.

  (If you are prompted for a password after you install a certificate, click **Continue**.)  
3. Run `vs_enterprise.exe` from the **Layout** folder.

> [!CAUTION]
> The offline installation layout currently creates some files with restricted permissions (ACLs) that prevent access by all users.  Make sure that you adjust the permissions (ACLs) so that they grant Read access to other users  *before*  you share the offline install.

## Update an installation layout
As updates become available for Visual Studio 2017 RC, you can run the `--layout` command again, pointing to the same layout folder, to  ensure that the folder contains the latest components. Only those components that have been updated since the last time `--layout` was run will be downloaded. 
