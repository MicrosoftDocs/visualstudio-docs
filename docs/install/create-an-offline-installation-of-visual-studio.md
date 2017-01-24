---
title: "Create an offline installation of Visual Studio 2017 RC | Microsoft Docs"
description: "Learn how to create an offline installation of Visual Studio."
ms.custom: ""
ms.date: "12/07/2016"
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
If you want to install [Visual Studio 2017 RC](https://www.visualstudio.com/vs/visual-studio-2017-rc/) on another machine that doesn't have internet access, you can do so by first creating an offline installation layout that contains all the Visual Studio files and components you need.

You can then install Visual Studio to the target machine by using the offline installation layout that you created.     

> [!WARNING]
> Currently, the Android SDK does not support an offline installation experience. If you install Android SDK Setup items on a computer that is not connected to the internet, the installation might fail. For more information about this, go to the [Troubleshoot an offline installation](#tshootofflineinstall) section in this topic.


#### To create an offline installation layout of Visual Studio
1. Download the Visual Studio setup executable file to a drive on your local machine.
  For example, [download the vs_enterprise.exe file](https://www.visualstudio.com/vs/visual-studio-2017-rc/).
2. Run `vs_enterprise.exe` with the following arguments (switches) from a command prompt:

   a. Add `--layout <path>`, where `<path>` is the location where you want the layout to download to. Note that relative paths (e.g. `..\vs2017`) are not supported at present. By default, all languages are downloaded. (See Example A.)

   > [!WARNING]
   > Currently, an offline installation of Visual Studio 2017 RC will silently fail to install if the layout location is a root directory (for example, D:&#92;). This is very common when an offline installation layout is created at the root of an ISO image. To work around this issue, please use a directory for the layout location. For example, use D:&#92;VS2017.

   b. Restrict the download to a subset of the available languages by providing the `--lang <language>` argument, where `<language>` is one or more of the ISO country codes.  (See Example B and Example C.)

### Examples
**Example A**: Install all languages
  > ```vs_enterprise.exe --layout C:\vs2017```

**Example B**: Install one language  
  > ```vs_enterprise.exe --layout C:\vs2017 --lang en-US```

**Example C**: Install multiple languages
  > ```vs_enterprise.exe --layout C:\vs2017 --lang en-US de-DE ja-JP```

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
As updates become available for Visual Studio 2017 RC, you can run the `--layout` command again, pointing to the same layout folder, to ensure that the folder contains the latest components. Only those components that have been updated since the last time `--layout` was run will be downloaded.

## <a id="tshootofflineinstall"> </a>Troubleshoot an installation layout
When you install offline from your offline install cache, you might see warning messages about not being able to install some components and packages. The following table includes possible solutions for these scenarios.

| Component or Package | Solution |
| -------------------- | -------- |
|Android SDK Setup (API Level)| You must have an internet connection to install Android SDK (API Level) packages. If you are on a restricted network, you must allow access to the following URLs when you install Visual Studio: <br><br> - http://dl.google.com:443 <br>- http://dl-ssl.google.com:443 <br>  - https://dl-ssl.google.com/android/repository/*<br><br>For more information about how to resolve possible issues with proxy settings, see the [Visual Studio install failures (Android SDK Setup) behind a Proxy](https://blogs.msdn.microsoft.com/peterhauge/2016/09/22/visual-studio-2015-install-failures-android-sdk-setup-behind-a-proxy/) blog post.  |  

 > [!IMPORTANT]
 > While Visual Studio 2017 RC in general is supported for use in a production environment, those workloads and components that are marked "Preview" in the installation UI are not supported for use in a production environment.

 ## See also
 * [Install Visual Studio](install-visual-studio.md)
 * [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
 * [Report a problem with Visual Studio](../ide/how-to-report-a-problem-with-visual-studio-2017.md)
