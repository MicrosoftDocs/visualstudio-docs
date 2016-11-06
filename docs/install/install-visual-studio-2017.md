---
title: "Install Visual Studio &quot;15&quot; Preview 5 | Microsoft Docs"
ms.custom: ""
ms.date: "2016-10-21"
ms.prod: "visual-studio-dev14"
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
caps.latest.revision: 18
author: "TerryGLee"
ms.author: "tglee"
manager: "ghogen"
---
# Install Visual Studio 2017 RC
Welcome to a new way to install Visual Studio! In our newest version, we’ve made it easier for you to select and install just the features you need—and we’ve reduced the minimum footprint of Visual Studio so that it installs more quickly and with less system impact than ever before.  
  
 Want to know more about what else is new in Preview 5? See our [release notes](https://www.visualstudio.com/news/releasenotes/vs15-relnotes). And for more in-depth info about how we’ve redesigned the installation experience, see our blog posts, “[Faster and leaner Visual Studio installer](https://blogs.msdn.microsoft.com/visualstudio/2016/04/01/faster-leaner-visual-studio-installer/)” and “[Anatomy of a low-impact Visual Studio installation](https://blogs.msdn.microsoft.com/visualstudio/2016/04/25/anatomy-of-a-low-impact-visual-studio-install/).”  
  
 Ready to install? Let's get started!  
  
> [!CAUTION]
>  This is an unsupported prerelease version of Visual Studio. We do not advise that you use it in a production environment.  
  
## Install the installer  
 When you [download Visual Studio](https://www.visualstudio.com/downloads/visual-studio-next-downloads-vs), you'll get a bootstrapper file that in turn installs our new lightweight installer. This new installer includes everything you need to customize your installation.  
  
1.  Uninstall all previous versions of Visual Studio "15" before you try Preview 5. For more information about how to do this, see the [Installation Issues](https://www.visualstudio.com/news/releasenotes/vs15-relnotes#KIinstall) section of the Preview 5 release notes.  
  
2.  [Download Enterprise "15"](https://www.visualstudio.com/visual-studio-pre-release-downloads/) and click **Save File**.  Then, from your **Downloads** folder, run the `vs_Enterprise.exe` file.  
  
     If you receive a User Account Control notice, click **Yes**.  
  
3.  We’ll ask you to acknowledge the Microsoft [License Terms](https://www.visualstudio.com/support/legal/mt591984) and the Microsoft [Privacy Statement](https://www.visualstudio.com/dn948229). Click **Install** to continue.  
  
     ![Installing Visual Studio '15' Preview 5 &#45; License Terms and Privacy Statement](../install/media/01-installingdev15prev4_licensetermsandprivacystatement.png.PNG "01-InstallingDev15Prev4_LicenseTermsAndPrivacyStatement.PNG")  
  
4.  You’ll see several status screens that show the progress of the installation. After the installer is finished installing, it’s time to pick the feature sets—or workloads—that you want. 
  
## Install workloads  
 Now, you can customize your installation by using workloads. Select one or more of the workloads you want; each workload contains the features you need for the programming language or platform you prefer.  
  
 Here’s how to get them.  
  
1.  Find the workload you want in the **Installing Visual Studio** screen.  
  
     We’ve included a few examples to show you how this works.  
  
     In the following example, we haven’t selected a workload yet, but notice that the **Summary** section shows the **Visual Studio core editor**. With the default core editor, you get basic code editing support for over 20 languages, the ability to open and edit code from any folder without requiring a project, and integrated source code control.  
  
     ![Dev15Prev5-Install-NoWorkloadSelectionYet](../install/media/dev15prev5-install-noworkloadselectionyet.PNG)  
  
     In the following example, we’ve added the **.NET desktop development** workload. Notice that the **Summary** section changes to include the components for this workload:  
  
     ![Dev15Prev5-Install-DotNetWorkloadSelected](../install/media/dev15prev5-install-dotnetworkloadselected.PNG)  
  
     If you scroll down into the **Summary** section, you’ll see some of the **Optional** components that are included in the **Web development** workload:  
  
     ![Dev15Prev5-Install-DotNetWorkloadSelected-ScrollToSeeOptionalComponents](../install/media/dev15prev5-install-dotnetworkloadselected-scrolltoseeoptionalcomponents.PNG)  
  
    > [!NOTE]
    >  You can make any changes you want to what’s preselected for you in the **Optional** section.  
  
2.  After you select the workloads and optional components you want, click **Install**.  
  
    Next, status screens will appear that show the progress of your Visual Studio installation. 
    
3. If you are asked to reboot your computer, do so, and then find and restart the **Microsoft Visual Studio Installer** program.  

    ![00-ModifyingDev15Prev5-FindTheVisualStudioInstaller](../install/media/00-modifyingdev15prev5-findthevisualstudioinstaller.png)

4.    After everything’s installed, you can click either **Modify** to change your workloads, or click **Launch** to start Visual Studio.  

## Install individual components

If you don’t want to use the handy Workloads feature to customize your Visual Studio installation, choose the **Individual Components** option from the Visual Studio Installer, select what you want, and then follow the prompts.
  
## See Also  
* [Modify Visual Studio 2017 RC](../install/modify-visual-studio-2017.md)
* [How to Report a Problem with Visual Studio 2017](../ide/how-to-report-a-problem-with-visual-studio-2017.md)
 