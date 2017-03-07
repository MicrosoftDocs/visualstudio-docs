---
title: "What's New in Visual Studio 2017 | Microsoft Docs"
ms.custom: ""
ms.date: "03/07/2017"
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
Welcome to Visual Studio 2017. You can use Visual Studio to create great apps and games for the web, for the Windows Store, for the Windows desktop, for Android, and for iOS.

Visual Studio's Integrated Development Environment, or IDE, provides you with a large suite of tools, including everything from powerful app templates, to code editing, debugging and deployment, to team productivity tools, access to build and consume cloud services, extensions and more.  

In this, our newest version of Visual Studio, we've focused on performance and productivity improvements. Performance-wise, we've made Visual Studio start faster, be more responsive, and use less memory than ever before. And productivity-wise, we've added or updated features that can help you be more efficient while you use Visual Studio.

> [!NOTE]
> For a complete list of new features and functionality in Visual Studio 2017, see the [Release Notes](https://www.visualstudio.com/news/vs2015-vs).   

Here is a high-level recap of the changes we've made in Visual Studio:

* **Performance and productivity**. We have focused not only on new, modern mobile, cloud, and desktop development capabilities, but we've also improved the overall acquisition, performance, and general developer productivity experiences. Visual Studio starts faster, is more responsive, and uses less memory than before.
* **Redefined fundamentals**. A new setup experience means that you can install more quickly and tailor the IDE to your needs. There is a faster, overall IDE from the start-up experience&mdash;to loading large solutions and projects, to working on folders of code&mdash;rather than requiring a project-file or solution. Visual Studio 2017 helps developers stay focused on the big picture. For teams embracing DevOps, Visual Studio streamlines your code editing and debugging productivity with refactoring enhancements and features such as [live unit testing](#live-unit-testing) and real-time [architectural dependency validation](#experience-live-architecture-dependency-validation-and-live-unit-testing).
* **Cloud app development with Azure**. A built-in suite of Azure tools that enable developers to easily create cloud-first applications powered by Microsoft Azure. Visual Studio makes it easy to configure, build, debug, package, and deploy applications and services on Microsoft Azure directly from the IDE.
* **Mobile app development**. With advanced debugging and profiling tools and unit test generation features, Visual Studio 2017 with Xamarin makes it faster and easier than ever for you to build, connect, and tune mobile apps for Android, iOS, and Windows, as built with C#. You can also choose to develop mobile apps with Apache Cordova or with Visual C++ cross-platform library development, all in Visual Studio.

And here are more details on our most notable changes.

## Performance improvements

### A new setup experience  
[Download Visual Studio 2017](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs) or [Check Visual Studio system requirements](https://www.visualstudio.com/en-us/productinfo/vs2017-system-requirements-vs)

 We've redesigned the Visual Studio setup experience to make it even easier to install just the features you need, when you need them. We've made Visual Studio install more quickly and with less system impact. And, it uninstalls cleanly, too.

 The most important change you'll see when you install Visual Studio is its new setup experience. On the **Workloads** tab, you'll see installation options that are grouped to represent common frameworks, languages, and platforms - covering everything from .NET desktop development to C++ application development on Windows, Linux, and iOS.   

 ![Visual Studio 2017 setup dialog](../install/media/vs2017-workloads.PNG "Visual Studio 2017 setup screen")

Choose the workloads you need, and change them up when you need to.

We've also added different ways to install Visual Studio. Want to pick your own components instead of using workloads? Simply select the **Individual components** tab from the installer. Want to install Language Packs without also having to change the Windows language option? Choose the **Language packs** tab of the installer.  

To learn even more about the new installation experience, including step-by-step instructions that walk you through it, see our [Install Visual Studio](../install/install-visual-studio.md) page.

### Start Visual Studio faster
If Visual Studio detects that it’s startup time is slow, it provides a new Visual Studio Performance Center to help you optimize your IDE. The Performance Center lists all the extensions and tool windows that might be slowing down the IDE startup. You can use it to improve startup performance by determining when extensions start, or whether tool windows are open at startup.

### Decrease solution load time
Working on solutions that contain upwards of 100 projects doesn't mean you have to work with all the files or projects at once. Now you can edit and debug without waiting for Visual Studio to load every project. To try this out with managed projects, turn on the  **Lightweight Solution load** from Tools -> Options -> Projects and Solutions.

  ![Options dialog box in Visual Studio 2017](../ide/media/vs2017ide-LightweightSolutionLoad.PNG "Visual Studio 2017 - Options dialog box - Lightweight Solution Load")

### Faster on-demand loading of extensions
Visual Studio is moving its extensions (and working with third-party extensions too), so that they load on-demand, rather than at IDE startup. Curious about which extensions impact startup, solution load, and typing performance? You can see this information in Help -> Manage Visual Studio Performance.

  ![Options dialog box in Visual Studio 2017](../ide/media/vs2017ide-manage-vs-perf.png "Visual Studio Help dialog box - Performance Management")

## Productivity improvements

### Sign in across multiple accounts  
We've introduced a new identity service in Visual Studio 2017 that allows you to share user accounts across Microsoft developer tools, such as Team Explorer, Azure Tools, Windows Store publishing, and more.

As well, you can stay signed in longer; we won't ask you to sign in again every 12 hours. To learn more, see the [Fewer Visual Studio Sign-in Prompts](https://blogs.msdn.microsoft.com/visualstudio/2016/08/15/fewer-visual-studio-sign-in-prompts/) blog post.

### Manage your extensions with Roaming Extensions Manager
Now it's even easier to set up each development environment with your favorite extensions when you sign in to Visual Studio. Our new Roaming Extension Manager keeps track of all your favorite extensions by creating a synchronized list in the cloud.  

To see a list of your extensions in Visual Studio, click  Tools > Extensions & Updates, and then click the Roaming Extension Manager.

![Visual Studio 2017 - Extensions and Updates dialog](../ide/media/vs2017ide-extensions-and-updates.png "Visual Studio 2017 - Tools > Extensions and Updates dialog")

The Roaming Extension Manager tracks all the extensions you install, but you can choose which ones you want to add to your Roaming list.

![Visual Studio 2017 - Extensions and Updates dialog](../ide/media/vs2017ide-RoamingExtensionManager.png "Visual Studio 2017 - Roaming Extension Manager")

When you use the Roaming Extension Manager, you will notice 3 icon types on your list:
* ![Roamed icon](../ide/media/vs2017ide-roamedicon.png "Roamed Icon") ***Roamed***: An extension that is part of this Roaming List, but not installed on your machine.
  (You can install these by using the **Download** button.)
* ![Roamed & Installed icon](../ide/media/vs2017ide-roamedinstalledicon.png "Roamed & Installed Icon") ***Roamed & Installed***: All extensions that are part of this Roaming List and installed in your dev environment.
  (If you decide you do not want to roam, you can remove these by using the **Stop Roaming** button.)
* ![Installed icon](../ide/media/vs2017ide-installedicon.png "Installed Icon") ***Installed***: All extensions that are installed in this environment, but are not part of your Roaming List.
  (You can add extensions to the Roaming List by using the **Start Roaming** button.)

These icons show you the current roaming status of your extensions. Any extension that you download while you are signed in is added to your list as **Roamed & Installed** and is part of your Roaming list, which gives you access to it from any machine!

### Experience live architecture dependency validation and live unit testing

In Visual Studio Enterprise 2017, if you have set up Dependency Validation diagrams (a.k.a. Layer diagrams), you can now be notified in real-time of architectural dependency rule violations as you type code in the Code Editor.

Errors appear in the Error List, and squiggles in the text editor show you the precise location of a violation. Now, you're less likely to introduce unwanted dependencies.

![Live Architecture Validation](../ide/media/vs2017ide-LiveArchitectureDepedendencyValidation.png "Live Architecture Dependency validation")

#### Live Unit Testing:

In Visual Studio Enterprise 2017, live unit testing visualizes unit test results and code coverage live on the editor, while you are coding. It works with C#/VB projects for the .NET Framework and supports three test frameworks of MSTest, xUnit, and NUnit.

![Live Unit Testing](../ide/media/lut-codewindow.png "An example of our new Live Unit Testing feature in the Enterprise edition of Visual Studio")

### Visual Studio IDE enhancements
#### Interact with Git:
When you have created a project or are working with a project in Visual Studio, you can setup and quickly commit and publish your code to a Git service and manage your Git repositories by using menu clicks from buttons in the bottom right-hand corner of the IDE.

![Visual Studio 2017 interact with Git dialog](../ide/media/vsIDE-GitInteraction.png "Git tools in the Visual Studio IDE")

#### View and navigate code with Structure Visualizer:
The Structure Visualizer draws structure guide lines (a.k.a indent guides) on your code so you can easily visualize and discover what block of code you’re in at any time without having to scroll. Hovering the lines shows tooltips that let you see the opening of that block and its parents. This feature is available for all the languages supported via TextMate grammars languages as well as Visual C#, Visual Basic, and XAML.

![Visual Studio 2017 structure visualizer](../ide/media/vsIDE-StructureVisualizer.png "Structure visualizer in Visual Studio")

#### Experience an improved Navigate To:
When you can quickly and easily navigate your code, it's immensely powerful and can dramatically improve productivity. Whether you’re drilling in to a bug, finding the implications of a refactoring, or just figuring out an unfamiliar codebase, tools that get you around quickly and confidently and that help you know where you are can make a big difference.

![Improved Navigate To](../ide/media/vs2017ide-navigation-go-to.png "Example of the improved Navigate To feature")

The new Go To (Ctrl + , or Ctrl + T) experience is a fast, complete search that lets you quickly find files, types, methods, and other kinds of symbols in your code.

#### Use our new Find All References tool

Find all references (Shift+F12) now helps you get around fast even in really complex codebases. It does so by providing advanced grouping, filtering, sorting, and searching within your results. For some languages, such as C#, the results are colorized just like they are in the editor. C++ lets you see which references are read and which are write. All this gets you a clear understanding of your references and gets you to that line of code you need with confidence.

![New Find All References tool](../ide/media/vs2017ide-find-all-references.png "Example of the new Find All References tool")

### Visual C++
Visual Studio 2017 brings many updates and fixes to the Visual C++ environment. We've fixed over 250 bugs and reported issues in the compiler and tools, many submitted by customers through [Microsoft Connect](https://connect.microsoft.com/VisualStudio "Microsoft Connect").

We've also made several improvements, to include distributing C++ Core Guidelines with Visual Studio, updating the compiler by adding enhanced support for C++11 and C++ features, adding and updating functionality in the C++ libraries, and improving the performance of the C++ IDE, installation workloads, and more.

For complete details, see our [What's New for Visual C++ in Visual 2017](/cpp/top/what-s-new-for-visual-cpp-in-visual-studio) page.  


### Debugging and Diagnostics
Several improvements have been made to improve both the performance of debugging, and your productive debugging experiences.

#### Run to Click:
Now, you can more easily skip ahead without setting a breakpoint to stop on the line you desire. When you are stopped in the debugger, simply click the icon that appears next to the line of code that your mouse is over. Your code will run and stop on that line the next time it is hit in your code path.


![Visual Studio 2017 debug - Run To Click](../ide/media/vs2017ide-RunToClick.png "Run To Click in Visual Studio debug & diagnostics")

#### The New Exception Helper:

You can use the new Exception Helper to view your exception information at a glance in a compact, non-modal dialog with instant access to inner exceptions.

Quickly see what was null right inside the Exception Helper when you diagnose a NullReferenceException.

You can also exclude breaking on exception types that are thrown from specific modules by clicking the checkbox to add a condition when you are stopped at a thrown exception.

![The New Exception Helper dialog in Visual Studio](../ide/media/vs2017ide-ExceptionHelper.png "The New Exception Helper dialog")

For more information, see the [Using the New Exception Helper in Visual Studio](https://blogs.msdn.microsoft.com/visualstudioalm/2016/03/31/using-the-new-exception-helper-in-visual-studio-15-preview/) blog post.

## Talk to us  
 Why send feedback to the Visual Studio team? Because we take customer feedback seriously. It drives a lot of what we do.  

If you'd like to make suggestion about how we can improve Visual Studio, or to report a problem, please see the [Talk to Us](../ide/talk-to-us.md) page for more details.  

### Report a problem  
 Sometimes, a message isn't enough to convey the full impact of a problem you've encountered. If you experience a hang, crash, or other performance issue, you can easily share repro steps and supporting files (such as screenshots and trace & heap dump files) with us by using the **Report a Problem** tool. For more information about how to use this tool, see the [How to Report a Problem](how-to-report-a-problem-with-visual-studio-2017.md) page.  

### Track your issue in Connect  
 If you’d like to track the status of your Visual Studio feedback, simply go to [Connect](http://connect.microsoft.com/) and report the bug there. After you report it, you can return to Connect to track its status.  

## See Also  
* [What's New in Visual Studio, by Mark Wilson-Thomas](https://blogs.msdn.microsoft.com/visualstudio/2016/11/28/productivity-in-visual-studio-2017-rc/)
* [What's New in Visual C++](/cpp/top/what-s-new-for-visual-cpp-in-visual-studio)
* [What's New in C#](https://docs.microsoft.com/en-us/dotnet/articles/csharp/csharp-7)  
* [What's New for Team Foundation Server](https://www.visualstudio.com/en-us/docs/whats-new)
* [Visual Studio Release Notes](https://www.visualstudio.com/news/vs2015-vs)
