---
title: "Install Visual Studio 2017 RC | Microsoft Docs"
description: "Learn how to install Visual Studio, step-by-step."
ms.custom: ""
ms.date: "11/18/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
f1_keywords:
  - "vs.about"
helpviewer_keywords:
  - "install Visual Studio Preview"
  - "install Visual Studio"
  - "installing Visual Studio"
  - "dev15"
  - "set up Visual Studio"
  - "Visual Studio setup"
  - "Visual Studio installer"
ms.assetid: 8d4297e4-9f43-4f12-95ec-22e61154480e
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
# Install Visual Studio 2017 RC
Welcome to a new way to install Visual Studio! In our newest version, we’ve made it easier for you to select and install just the features you need—and we’ve reduced the minimum footprint of Visual Studio so that it installs more quickly and with less system impact than ever before.  

 Want to know more about what else is new in RC? See our [release notes](https://www.visualstudio.com/news/releasenotes/vs15-relnotes). And for more in-depth info about how we’ve redesigned the installation experience, see our blog posts, “[Faster and leaner Visual Studio installer](https://blogs.msdn.microsoft.com/visualstudio/2016/04/01/faster-leaner-visual-studio-installer/)” and “[Anatomy of a low-impact Visual Studio installation](https://blogs.msdn.microsoft.com/visualstudio/2016/04/25/anatomy-of-a-low-impact-visual-studio-install/).”  

 Ready to install? We'll walk you through it, step-by-step. Let's get started.  

## Install the installer  
 When you download Visual Studio 2017 RC, you'll get a bootstrapper file that in turn installs our new lightweight installer. This new installer includes everything you need to customize your installation.  

> [!IMPORTANT]
> If you have a Preview release of Visual Studio 2017 installed on your computer, you will be prompted to remove it prior to installing Visual Studio 2017 RC.

1.  [Download Visual Studio Enterprise 2017 RC](https://www.visualstudio.com/vs/visual-studio-2017-rc/) and click **Save**.  Then, from your **Downloads** folder, run the `vs_Enterprise.exe` file.  

     If you receive a User Account Control notice, click **Yes**.  

2.  We’ll ask you to acknowledge the Microsoft [License Terms](https://www.visualstudio.com/support/legal/mt591984) and the Microsoft [Privacy Statement](https://www.visualstudio.com/dn948229). Click **Install** to continue.  

  ![License Terms and Privacy Statement](media/01-installingdev15prev4-licensetermsandprivacystatement.png "Microsoft License Terms and Privacy Statement")  

3.  You’ll see several status screens that show the progress of the installation. After the installer is finished installing, it’s time to pick the feature sets—or workloads—that you want.

## Install workloads  
 Now, you can customize your installation by using workloads. Select one or more of the workloads you want; each workload contains the features you need for the programming language or platform you prefer.  

 Here’s how to get them.  

1.  Find the workload you want in the **Installing Visual Studio** screen.  

  ![Visual Studio 2017 RC setup dialog](../ide/media/willow1.png "Installing Visual Studio 2017")

     For example, choose the .NET Desktop development workload. It comes with the default core editor, which includes basic code editing support for over 20 languages, the ability to open and edit code from any folder without requiring a project, and integrated source code control.  

2.  After you select the workload(s) you want, click **Install**.  

    Next, status screens will appear that show the progress of your Visual Studio installation.

3.  After the new workloads and components are installed, click **Launch**.

## Install individual components

If you don’t want to use the handy Workloads feature to customize your Visual Studio installation, click the **Individual components** option from the Visual Studio Installer, select what you want, and then follow the prompts.

  ![Visual Studio 2017 - Install individual components](media/vs2017install-IndividualComponents.PNG "Install Visual Studio individual components")

## Install language packs

To install Visual Studio 2017 RC in a language of your choosing, click the **Language packs** option from the Visual Studio Installer, and follow the prompts.

  ![Visual Studio 2017 - Install language packs](media/vs2017install-LanguagePacks.PNG "Install Visual Studio language packs")

  > [!IMPORTANT]
  > While Visual Studio 2017 RC in general is supported for use in a production environment, those workloads and components that are marked "Preview" in the installation UI are not supported for use in a production environment.
  
## Changing the installer language

By default, the installer program tries to match the language of the operating system when run for the first time. The installer will remember this setting. The setting can later be changed by running the installer from the command line. For example, the user can force the installer to run in English by running `vs_installer.exe --locale en-US`. This setting will then be remembered when the installer is run the next time. The installer supports the following language tokens: zh-CN, zh-TW, cs-CZ, en-US, fr-FR, de-DE, it-IT, ja-JP, ko-KR, pl-PL, pt-BR, ru-RU, es-ES, and tr-TR. 

## See Also  
* [Modify Visual Studio 2017 RC](modify-visual-studio.md)
* [Uninstall Visual Studio 2017 RC](uninstall-visual-studio.md)
* [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
* [How to Report a Problem with Visual Studio 2017](../ide/how-to-report-a-problem-with-visual-studio-2017.md)
