---
title: "Install Visual Studio 2017 | Microsoft Docs"
description: "Learn how to install Visual Studio, step-by-step."
ms.custom: ""
ms.date: "08/30/2017"
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
---
# Install Visual Studio 2017
Welcome to a new way to install Visual Studio! In our newest version, we've made it easier for you to select and install just the features you need. We've also reduced the minimum footprint of Visual Studio so that it installs more quickly and with less system impact than ever before.

Want to know more about what else is new in this version? See our [release notes](https://www.visualstudio.com/news/releasenotes/vs2017-relnotes).

Ready to install? We'll walk you through it, step-by-step.

## Step 1 - Make sure your computer is ready for Visual Studio

Before you begin installing Visual Studio:

1. Check the [system requirements](https://www.visualstudio.com/productinfo/vs2017-system-requirements-vs). This helps you know whether your computer supports Visual Studio 2017.
2. Apply the latest Windows updates. This ensures that your computer has both the latest security updates and the required system components for Visual Studio.
3. Reboot. This ensures that any pending installs or updates don't hinder the Visual Studio install.
4. Free up space. Remove unneeded files and applications from your %SystemDrive% by, for example, running the Disk Cleanup app.

For questions about running previous versions of Visual Studio side-by-side with Visual Studio 2017, see the [Visual Studio compatibility details](https://www.visualstudio.com/productinfo/vs2017-compatibility-vs#compatibility-with-previous-releases).

## Step 2 - Download Visual Studio

Next, download the Visual Studio bootstrapper file. To do so, click the following button, select the edition of Visual Studio 2017 that you want, click **Save**, and then click **Open folder**.

 > [!div class="button"]
 > [Download Visual Studio 2017](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs)
<br/>

|         |         |
|---------|---------|
|  ![movie camera icon for video](media/video-icon.png "Watch a video")  |    [Watch a video](https://mva.microsoft.com/en-US/training-courses-embed/getting-started-with-visual-studio-2017-17798/Download-the-Visual-Studio-Installer-GgrESHD6D_3311787171) on how to download the Visual Studio bootstrapper file and select the edition of Visual Studio that's right for you. |

## Step 3 - Install the Visual Studio installer

Then, run the bootstrapper file to install the Visual Studio Installer. This new lightweight installer includes everything you need to both install and customize Visual Studio 2017.

1.  From your **Downloads** folder, double-click the bootstrapper that matches or is similar to one of the following files:

  * **vs_enterprise.exe** for Visual Studio Enterprise
  * **vs_professional.exe** for Visual Studio Professional
  * **vs_community.exe** for Visual Studio Community  <br><br>

  If you receive a User Account Control notice, click **Yes**.

2.  We'll ask you to acknowledge the Microsoft [License Terms](https://www.visualstudio.com/license-terms/) and the Microsoft [Privacy Statement](https://go.microsoft.com/fwlink/?LinkID=824704). Click **Continue**.  

   ![License Terms and Privacy Statement](media/vs2017-privacy-and-license-terms.PNG "Microsoft License Terms and Privacy Statement")

## Step 4 - Select workloads

After the installer is installed, you can use it to customize your installation by selecting the feature sets—or workloads—that you want. Here's how.

1.  Find the workload you want in the **Installing Visual Studio** screen.

  ![Visual Studio 2017 setup dialog](media/vs2017-workloads.PNG "Install Visual Studio workloads")

     For example, choose the .NET desktop development workload. It comes with the default core editor, which includes basic code editing support for over 20 languages, the ability to open and edit code from any folder without requiring a project, and integrated source code control.  

2.  After you select the workload(s) you want, click **Install**.

    Next, status screens appear that show the progress of your Visual Studio installation.

3.  After the new workloads and components are installed, click **Launch**.

|         |         |
|---------|---------|
|  ![movie camera icon for video](media/video-icon.png "Watch a video")  |    [Watch a video](https://mva.microsoft.com/en-US/training-courses-embed/getting-started-with-visual-studio-2017-17798/Install-Workloads-in-Visual-Studio-2017-jHE19HD6D_1611787171) on how to install the Visual Studio Installer and then install a workload. |

## Step 5 - Select individual components (Optional)

If you don't want to use the Workloads feature to customize your Visual Studio installation, you can do so by installing individual components instead. To do this, click the **Individual components** option from the Visual Studio Installer, select what you want, and then follow the prompts.

  ![Visual Studio 2017 - Install individual components](media/vs2017-components.PNG "Install Visual Studio individual components")

  |         |         |
  |---------|---------|
  |  ![movie camera icon for video](media/video-icon.png "Watch a video")  |   [Watch a video](https://mva.microsoft.com/en-US/training-courses-embed/getting-started-with-visual-studio-2017-17798/Install-Components-in-Visual-Studio-2017-ZMfaVID6D_7411787171) on how to install an individual component by using the Visual Studio Installer. |

## Step 6 - Install language packs (Optional)

By default, the installer program tries to match the language of the operating system when it runs for the first time. To install Visual Studio 2017 in a language of your choosing, click the **Language packs** option from the Visual Studio Installer, and follow the prompts.

  ![Visual Studio 2017 - Install language packs](media/vs2017-languages.PNG "Install Visual Studio language packs")

  |         |         |
  |---------|---------|
  |  ![movie camera icon for video](media/video-icon.png "Watch a video")  |   [Watch a video](https://mva.microsoft.com/en-US/training-courses-embed/getting-started-with-visual-studio-2017-17798/Install-Language-Packs-in-Visual-Studio-2017-ByT7yID6D_9011787171) on how to install a language pack by using the Visual Studio Installer. |

### Change the installer language from the command line

Another way that you can change the default language is by running the installer from the command line. For example, you can force the installer to run in English by using the following command: `vs_installer.exe --locale en-US`. The installer will remember this setting when it is run the next time. The installer supports the following language tokens: zh-cn, zh-tw, cs-cz, en-us, es-es, fr-fr, de-de, it-it, ja-jp, ko-kr, pl-pl, pt-br, ru-ru, and tr-tr.

## Step 7 - Launch Visual Studio

After Visual Studio installation is complete, click the **Launch** button to [Get Started Developing with Visual Studio](../ide/get-started-developing-with-visual-studio.md).

## Get support

Sometimes, things can go wrong. If your Visual Studio installation fails, see the [Troubleshooting Visual Studio 2017 installation and upgrade issues](troubleshooting-installation-issues.md) page for troubleshooting tips.

## See also
* [Update Visual Studio 2017](update-visual-studio.md)
* [Modify Visual Studio 2017](modify-visual-studio.md)
* [Uninstall Visual Studio 2017](uninstall-visual-studio.md)
* [Administrator guide for Visual Studio 2017](visual-studio-administrator-guide.md)
  * [Use command-line parameters to install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md)
* [Create an offline installation of Visual Studio 2017](create-an-offline-installation-of-visual-studio.md)
* [Report a problem with Visual Studio 2017](../ide/how-to-report-a-problem-with-visual-studio-2017.md)