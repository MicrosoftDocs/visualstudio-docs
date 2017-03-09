---
title: "Install Visual Studio 2017 | Microsoft Docs"
description: "Learn how to install Visual Studio, step-by-step."
ms.custom: ""
ms.date: "03/07/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
f1_keywords:
  - "vs.about"
helpviewer_keywords:
  - "install Visual Studio"
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
# Install Visual Studio 2017
Welcome to a new way to install Visual Studio! In our newest version, we’ve made it easier for you to select and install just the features you need—and we’ve reduced the minimum footprint of Visual Studio so that it installs more quickly and with less system impact than ever before.  

 Want to know more about what else is new? See our [release notes](https://www.visualstudio.com/news/releasenotes/vs15-relnotes). And for more in-depth info about how we’ve redesigned the installation experience, see our blog posts, “[Faster and leaner Visual Studio installer](https://blogs.msdn.microsoft.com/visualstudio/2016/04/01/faster-leaner-visual-studio-installer/)” and “[Anatomy of a low-impact Visual Studio installation](https://blogs.msdn.microsoft.com/visualstudio/2016/04/25/anatomy-of-a-low-impact-visual-studio-install/).”  

 Ready to install? We'll walk you through it, step-by-step. Let's get started.  

## Install the installer  
 When you download Visual Studio 2017, you'll get a bootstrapper file that in turn installs our new lightweight installer. This new installer includes everything you need to customize your installation.  

> [!IMPORTANT]
> If you have a Preview release of Visual Studio 2017 installed on your computer, you will be prompted to remove it prior to installing Visual Studio 2017.

1.  **[Download Visual Studio 2017](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs)** and click **Save**. Then, from your **Downloads** folder, run the bootstrapper file that matches the edition you chose.

  * **vs_enterprise.exe** for Visual Studio Enterprise
  * **vs_professional.exe** for Visual Studio Professional
  * **vs_community.exe** for Visual Studio Community  <br><br>

  If you receive a User Account Control notice, click **Yes**.  

2.  We'll ask you to acknowledge the Microsoft [License Terms](https://www.visualstudio.com/license-terms/) and the Microsoft [Privacy Statement](https://go.microsoft.com/fwlink/?LinkID=824704). Click **Install** to continue.  

   ![License Terms and Privacy Statement](media/vs2017-privacy-and-license-terms.PNG "Microsoft License Terms and Privacy Statement")  

3.  You’ll see several status screens that show the progress of the installation. After the installer is finished installing, it’s time to pick the feature sets—or workloads—that you want.

## Install workloads  
 Now, you can customize your installation by using workloads. Select one or more of the workloads you want; each workload contains the features you need for the programming language or platform you prefer.  

 Here’s how to get them.  

1.  Find the workload you want in the **Installing Visual Studio** screen.  

  ![Visual Studio 2017 setup dialog](media/vs2017-workloads.PNG "Installing Visual Studio 2017")

     For example, choose the .NET desktop development workload. It comes with the default core editor, which includes basic code editing support for over 20 languages, the ability to open and edit code from any folder without requiring a project, and integrated source code control.  

2.  After you select the workload(s) you want, click **Install**.  

    Next, status screens will appear that show the progress of your Visual Studio installation.

3.  After the new workloads and components are installed, click **Launch**.

## Install individual components

If you don’t want to use the handy Workloads feature to customize your Visual Studio installation, click the **Individual components** option from the Visual Studio Installer, select what you want, and then follow the prompts.

  ![Visual Studio 2017 - Install individual components](media/vs2017-workloads.PNG "Install Visual Studio individual components")

## Install language packs

To install Visual Studio 2017 in a language of your choosing, click the **Language packs** option from the Visual Studio Installer, and follow the prompts.

  ![Visual Studio 2017 - Install language packs](media/vs2017-languages.PNG "Install Visual Studio language packs")

### Change the installer language

By default, the installer program tries to match the language of the operating system when it runs for the first time. The installer remembers this setting. You can change this setting by running the installer from the command line. For example, you can force the installer to run in English by using the following command: `vs_installer.exe --locale en-US`. The installer will remember this setting when it is run the next time. The installer supports the following language tokens: zh-CN, zh-TW, cs-CZ, en-US, fr-FR, de-DE, it-IT, ja-JP, ko-KR, pl-PL, pt-BR, ru-RU, es-ES, and tr-TR.


## See also  
* [Modify Visual Studio 2017](modify-visual-studio.md)
* [Uninstall Visual Studio 2017](uninstall-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [How to Report a Problem with Visual Studio 2017](../ide/how-to-report-a-problem-with-visual-studio-2017.md)
