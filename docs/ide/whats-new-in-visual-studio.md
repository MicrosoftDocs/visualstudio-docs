---
title: "What&#39;s New in Visual Studio 2015 | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords:
  - "VS.StartPage.WhatsNew"
helpviewer_keywords:
  - "Visual Studio, what's new"
  - "what's new [Visual Studio]"
ms.assetid: 7307e180-ba28-4774-8a43-cbb980085a71
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
# What&#39;s New in Visual Studio 2017
Welcome to Visual Studio 2017 RC, an integrated suite of developer productivity tools, cloud services, and extensions that enable you and your team to create great apps and games for the web, for Windows Store, for the desktop, for Android, and for iOS.  

 This page highlights some of the most important features that are new since our previous version, Visual Studio 2015. For a complete list of what’s new in Visual Studio 2017 RC, see the [Release Notes](https://www.visualstudio.com/news/vs2015-vs).   

## A new setup experience  
[Download Visual Studio Enterprise 2017 RC](https://aka.ms/vs/15/preview/vs_enterprise) or [Compare Visual Studio editions](https://www.visualstudio.com/vs/compare/)

 We've redesigned the Visual Studio setup experience to make it even easier to install just the features you need, when you need them. We've also reduced the minimum footprint, so that Visual Studio installs more quickly with less system impact. And, it uninstalls cleanly, too.

 The most important change you'll see when you install Visual Studio is its new install experience. On the **Workloads** tab, you'll see installation options that are grouped to represent common frameworks, languages, and platforms - covering everything from .NET desktop development to data science with R, Python, and F#.  

 ![Visual Studio 2017 RC Setup Dialog](../ide/media/willow1.png "VS20117RC_Setup_screen")

Choose the workloads you need, and change them up when you need to. The smallest install is just a few hundred megabytes, yet still contains basic code editing support for more than twenty languages along with source code control.

We've also added different ways to install Visual Studio. Want to pick your own components instead of using workloads? Simply select the **Individual components** tab from the installer. Want to install Language Packs without also having to change the Windows language option? Choose the **Install language** tab of the installer.  

To learn more about the new installation experience, including step-by-step instructions that walk you through it, see our [Install Visual Studio](.../install/install-visual-studio-2017.md) page.

>[!NOTE]
>Because this is a prerelease, we still have a few things to work on. To learn more, see the [Known Issues](https://www.visualstudio.com/news/vs2015-vs#knownissues) section of the Release Notes.

## Sign in across multiple accounts  
We've introduced a new identity service in Visual Studio 2017 RC that allows you to share user accounts across Microsoft developer tools, such as Team Explorer, Azure Tools, Windows Store publishing, and more.

As well, you can stay signed in longer; we won't ask you to sign in again every 12 hours. To learn more, see the [Fewer Visual Studio Sign-in Prompts](https://blogs.msdn.microsoft.com/visualstudio/2016/08/15/fewer-visual-studio-sign-in-prompts/) blog post.

## Visual Studio IDE enhancements
### Interact with Git
Controls in the bottom corner of the Visual Studio IDE enable you to quickly commit and publish your projects to Git and manage your Git repositories.

![Visual Studio 2017 RC Setup Dialog](../ide/media/vsIDE-GitInteraction.png "Git-tools-in-the-VS2017RC-IDE")

### View and navigate code with Structure Visualizer
A new feature called Structure Visualizer is available in the Visual Studio code editor. This feature displays vertical guidelines between nested areas of code, making it easier for you to view and navigate through your code. This feature is available for all TextMate-backed languages as well as Visual C#, Visual Basic, and XAML.

![Visual Studio 2017 RC Setup Dialog](../ide/media/vsIDE-StructureVisualizer.png "Structure-Visualizer-in-VS2017RC")

### Start Visual Studio faster
If Visual Studio detects that IDE startup time is slow, it provides a new Visual Studio Performance Center to help you speed things up. The Performance Center lists all the extensions and tool windows that are slowing down IDE startup. You can use it to improve startup performance by determining when extensions start, or whether tool windows are open at startup.

### Experience an improved Navigate To
We've improved the Navigate To function. We've simplified the Navigate To window, and we've added support for additional filter characters that enable you to narrow your code searches.

### Create apps in even more programming languages
You can create apps in Visual Studio using a larger number of programming languages than in previous versions, and solutions and projects are no longer required. Your code gets syntax colorization, basic statement completion, and in some cases, Navigate To and other support. If your favorite language isn’t supported, you can create support for it by using TextMate Grammars.

## Visual C++
Visual Studio 2017 RC brings many updates and fixes to the Visual C++ environment. We've fixed over 250 bugs and reported issues in the compiler and tools, many submitted by customers through [Microsoft Connect](https://connect.microsoft.com/VisualStudio "Microsoft Connect").

We've also made several improvements, to include distributing C++ Core Guidelines with Visual Studio, updating the compiler by adding enhanced support for C++11 and C++ features, adding and updating functionality in the C++ libraries, and improving the performance of the C++ IDE, installation workloads, and more.

For complete details, see our [What's New for Visual C++ in Visual 2017 RC](...top/what-s-new-for-visual-cpp-in-visual-studio.md) page.  


## Debugging and Diagnostics
#### Run to Click
Now, while you are debugging, you can click the icon next to a line of code to run that line. You no longer have to set temporary breakpoints to perform several steps to execute your code and stop on the line you want.


## Please give feedback  
 Why send feedback to the Visual Studio team? Because we take customer feedback seriously. In fact, we review all of your feedback. It drives a lot of what we do.  

For more information on how to make a suggestion about Visual Studio features, see [Talk to Us](../ide/talk-to-us.md).  

### Report a problem  
 Sometimes, a quick note isn't enough to convey the full impact of a problem you've encountered. For the times when you have a hang, crash, or performance issue, you can easily share repro steps, crash dumps, and trace files by using the **Report a Problem** tool.  

 For more information about how to report of problem and how to include supporting files, see [How to Report a Problem with Visual Studio 2017](.../how-to-report-a-problem-with-visual-studio-2017.md).  

### Track your issue in Connect  
 If you’d like to track the status of your Visual Studio feedback, go to [Connect](http://connect.microsoft.com/) and report the bug there. After you report it, you can return to Connect to track its status.  

## See Also  
 [What's New in Visual C++](../.md)   
 [What's New in C#](../.md)   
 [What's New in Visual Basic](../.md)   
 [What's New in the .NET Framework](../.md)   
 [What's New in ALM](../.md)   
 [What's New in JavaScript](../.md)   
 [What's New in Python](../.md)   
