---
title: "What's New in Visual Studio 2017 | Microsoft Docs"
ms.custom: ""
ms.date: "10/6/2017"
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
ms.technology: 
  - "vs-acquisition"
---
# What&#39;s New in Visual Studio 2017
#### Updated for the 15.4 release
Unparalleled productivity for any dev, any app, and any platform. Use Visual Studio 2017 to develop apps for Android, iOS, Windows, Linux, web, and cloud. Code fast, debug and diagnose with ease, test often, and release with confidence. You can also extend and customize Visual Studio by building your own extensions. Use version control, be agile, and collaborate efficiently with this release!

Here is a high-level recap of the changes we've made since Visual Studio 2015:

* **Redefined fundamentals**. A new setup experience means that you can install more quickly and install what you want when you need it. Whether you want to load large solutions and projects, or work on folders of code, or even a single file of code, Visual Studio starts faster. And, Visual Studio helps you stay focused on the big picture, especially for teams embracing DevOps.
* **Performance and productivity**. We have focused on new and modern mobile, cloud, and desktop development capabilities. And, we've also improved the overall acquisition, performance, and general developer productivity experiences. Visual Studio starts faster, is more responsive, and uses less memory than before.
* **Cloud app development with Azure**. A built-in suite of Azure tools enable you to easily create cloud-first apps powered by Microsoft Azure. Visual Studio makes it easy to configure, build, debug, package, and deploy apps and services on Azure.
* **Mobile app development**. In Visual Studio 2017, you can innovate and get results fast with Xamarin, which unifies your multi-platform mobile requirements by using one core codebase and set of skills. Go mobile with your existing teams, technology investments, and C# code to deliver consumer-grade experiences ahead of schedule and under budget. Accelerate every step of the mobile lifecycle to deliver world-class consumer experiences or a portfolio of productivity apps to empower your workforce.
* **Cross-platform development** Seamlessly deliver software to any targeted platform. Extend DevOps processes to SQL Server through Redgate Data Tools and safely automate database deployments from Visual Studio. Develop and release multiplatform games by using Visual Studio Tools for Unity. Or, use .NET Core to write apps and libraries that run unmodified across Windows, Linux, and macOS operating systems. (And **new in 15.3**: Get side-by-side support for .NET Core 2.0 SDKs.)

> [!NOTE]
> For a complete list of new features and functionality in Visual Studio 2017, see the [Release Notes](https://www.visualstudio.com/news/releasenotes/vs2017-relnotes).

Here is more detailed information about some of the most notable improvements and new features in Visual Studio 2017.

## Redefined fundamentals
### A new setup experience

[Download Visual Studio 2017](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs) or [Check Visual Studio system requirements](https://www.visualstudio.com/en-us/productinfo/vs2017-system-requirements-vs)

 Visual Studio makes it easier and faster to install just the features you need, when you need them. And, it uninstalls cleanly, too.

 The most important change to note when you install Visual Studio is its new setup experience. On the **Workloads** tab, you'll see installation options that are grouped to represent common frameworks, languages, and platforms. It covers everything from .NET desktop development to C++ application development on Windows, Linux, and iOS.

Choose the workloads you need, and change them when you need to.

 ![Visual Studio 2017 setup dialog](../install/media/install-visual-studio-enterprise.png "Visual Studio 2017 setup screen")

Want to pick your own components instead of using workloads? Select the **Individual components** tab from the installer. Want to install Language Packs without also having to change the Windows language option? Choose the **Language packs** tab of the installer.  

To learn more about the new installation experience, including step-by-step instructions that walk you through it, see our [Install Visual Studio](../install/install-visual-studio.md) page.

## Performance and productivity
### Sign in across multiple accounts  
We've introduced a new identity service in Visual Studio that allows you to share user accounts across Team Explorer, Azure Tools, Windows Store publishing, and more.

You can stay signed in longer, too. Visual Studio won't ask you to sign in again every 12 hours. To learn more, see the [Fewer Visual Studio Sign-in Prompts](https://blogs.msdn.microsoft.com/visualstudio/2016/08/15/fewer-visual-studio-sign-in-prompts/) blog post.

### Start Visual Studio faster
The new Visual Studio Performance Center can help you optimize your IDE start-up time. The Performance Center lists all the extensions and tool windows that might slow down the IDE startup. You can use it to improve startup performance by determining when extensions start, or whether tool windows are open at startup.

### Decrease solution load time
Working on solutions that contain large numbers of projects doesn't mean you have to work with all the files or projects at one time. Now you can edit and debug without waiting for Visual Studio to load every project. To try this out with managed projects, turn on the  **Lightweight Solution load** from Tools -> Options -> Projects and Solutions.

  ![Options dialog box in Visual Studio 2017](../ide/media/vs2017ide-lightweight-solution-load.png "Visual Studio 2017 - Options dialog box - Lightweight solution load for all solutions")

### Faster on-demand loading of extensions
Visual Studio is moving its extensions (and working with third-party extensions too) so that they load on-demand, rather than at IDE startup. Curious about which extensions impact startup, solution load, and typing performance? You can see this information in Help -> Manage Visual Studio Performance.

  ![Options dialog box in Visual Studio 2017](../ide/media/vs2017ide-manage-vs-perf.png "Visual Studio Help dialog box - Performance Management")

#### Manage your extensions with Roaming Extensions Manager
It's easier to set up each development environment with your favorite extensions when you sign in to Visual Studio. The new Roaming Extension Manager keeps track of all your favorite extensions by creating a synchronized list in the cloud.  

To see a list of your extensions in Visual Studio, click  Tools > Extensions & Updates, and then click the Roaming Extension Manager.

![Visual Studio 2017 - Extensions and Updates dialog](../ide/media/vs2017ide-extensions-and-updates.png "Visual Studio 2017 - Tools > Extensions and Updates dialog")

The Roaming Extension Manager tracks all the extensions you install, but you can choose which ones you want to add to your Roaming list.

![Visual Studio 2017 - Extensions and Updates dialog](../ide/media/vs2017ide-RoamingExtensionManager.png "Visual Studio 2017 - Roaming Extension Manager")

When you use the Roaming Extension Manager, there are three icon types on your list:
* ![Roamed icon](../ide/media/vs2017ide-roamedicon.png "Roamed Icon") ***Roamed***: An extension that is part of this Roaming List, but not installed on your machine.
  (You can install these by using the **Download** button.)
* ![Roamed & Installed icon](../ide/media/vs2017ide-roamedinstalledicon.png "Roamed & Installed Icon") ***Roamed & Installed***: All extensions that are part of this Roaming List and installed in your dev environment.
  (If you decide you do not want to roam, you can remove these by using the **Stop Roaming** button.)
* ![Installed icon](../ide/media/vs2017ide-installedicon.png "Installed Icon") ***Installed***: All extensions that are installed in this environment, but are not part of your Roaming List.
  (You can add extensions to the Roaming List by using the **Start Roaming** button.)

Any extension that you download while you are signed in is added to your list as **Roamed & Installed** and is part of your Roaming list, which gives you access to it from any machine.

### Experience live architecture dependency validation and live unit testing
As you type code in the text editor, Visual Studio notifies you in real time of architectural dependency rule violations by using Dependency Validation diagrams (a.k.a. Layer diagrams).

Errors appear in the Error List and squiggles appear in the text editor showing you the precise location of the violation. You are now less likely to introduce unwanted dependencies.

![Live Architecture Validation](../ide/media/vs2017ide-LiveArchitectureDepedendencyValidation.png "Live Architecture Dependency validation")

#### Live unit testing
In Visual Studio Enterprise 2017, live unit testing gives you live unit test results and code coverage in the editor while you are coding. It works with C# and Visual Basic projects for both the .NET Framework and .NET Core, and it supports three test frameworks of MSTest, xUnit, and NUnit.

![Live Unit Testing](../ide/media/lut-codewindow.png "An example of our new Live Unit Testing feature in the Enterprise edition of Visual Studio")

For more information, see the [Live Unit Testing in Visual Studio 2017 Enterprise](https://blogs.msdn.microsoft.com/visualstudio/2017/03/09/live-unit-testing-in-visual-studio-2017-enterprise/) blog post.

#### Set up a CI/CD pipeline to run automated tests efficiently
Automated testing is a key part of any DevOps pipeline. It allows you to consistently and reliably test and release your solution on much shorter cycles. CI/CD (Continuous Integration and Continuous Delivery) flows can help make the process more efficient.

For more information about automated tests, see the [CI/CD pipeline for automated tests in DevOps](https://blogs.msdn.microsoft.com/visualstudioalmrangers/2017/04/20/set-up-a-cicd-pipeline-to-run-automated-tests-efficiently/) blog post.

And, for more information about what's new in the [Continuous Delivery Tools for Visual Studio](https://marketplace.visualstudio.com/items?itemName=VSIDEDevOpsMSFT.ContinuousDeliveryToolsforVisualStudio) DevLabs extension, see the [Committing with Confidence: Commit Time Code Quality](https://blogs.msdn.microsoft.com/visualstudio/2017/08/21/committing-with-confidence-commit-time-code-quality-information-updated/) blog post.

### A focus on accessibility
**New in 15.3**, we made over 1,700 targeted fixes to improve compatibility between Visual Studio and the assistive technologies that many of our customers use. There are dozens of scenarios that are more compatible with screen readers, high contrast themes, and other assistive technologies than ever before. The debugger, editor and shell have all gotten significant improvements, too.

For more information, see the [Accessibility improvements in Visual Studio 2017 version 15.3](https://blogs.msdn.microsoft.com/visualstudio/2017/08/14/accessibility-improvements-in-visual-studio-2017-version-15-3/) blog post.

### Visual Studio IDE enhancements
#### Use new refactorings
**New in 15.3**, we’ve added a handful of new refactorings, to include:
*	Resolve merge conflict
*	Add parameter (from CallSite)
*	Generate overrides
*	Add named argument
*	Add null-check for parameters
*	Insert digit-separators into literals
*	Change base for numeric literals (for example, hex to binary)
*	Convert if-to-switch
*	Remove unused variable

For more information, see the [Refactoring, Code Generation, and Quick Actions in Visual Studio](refactoring-code-generation-quick-actions.md) page.  

#### Interact with Git
When you are working with a project in Visual Studio, you can set up and quickly commit and publish your code to a Git service. You can also manage your Git repositories by using menu clicks from buttons in the bottom right-hand corner of the IDE.

![Visual Studio 2017 interacts with the Git dialog](../ide/media/vsIDE-GitInteraction.png "Git tools in the Visual Studio IDE")

#### Experience improved navigation controls
We've refreshed the navigation experience to help you get from A to B with greater confidence and fewer distractions.

* **Go To Definition (Ctrl+click or F12)** &ndash; **new in 15.4**: mouse users have an easier way to navigate to the definition of a member by pressing **Ctrl** and then clicking the member. Pressing **Ctrl** and hovering over a code symbol will underline it and turn it into a link. See [Go To Definition and Peek Definition](../ide/go-to-and-peek-definition.md) for more information.  

* **Go To Implementation (Ctrl+F12)** &ndash; navigate from any base type or member to its various implementations.

* **Go To All (Ctrl+T or Ctrl+,)** &ndash; navigate directly to any file/type/member/symbol declaration. You can filter your result list or use the query syntax (for example, "f searchTerm" for files, "t searchTerm" for types, etc.).

 ![Improved Go To All](../ide/media/vs2017ide-navigation-go-to.png "Example of the improved Go To All feature")

* **Find All References (Shift+F12)** &ndash; with syntax colorization, you can group Find All Reference results by a combination of project, definition, and path. You can also "lock" results so that you can continue to find other references without losing your original results.

 ![New Find All References tool](../ide/media/vs2017ide-find-all-references.png "Example of the new Find All References tool")

* **Structure Visualizer** &ndash; dotted, gray vertical lines (indent guides) act as landmarks in code to provide context within your frame of view. You may recognize them from the popular Productivity Power Tools. You can use them to visualize and discover what block of code you're in at any time without having to scroll. Hovering over the lines displays a tooltip that shows you the opening of that block and its parents. It's available for all the languages supported via TextMate grammars, as well as C#, Visual Basic, and XAML.  

![Visual Studio 2017 structure visualizer](../ide/media/vsIDE-StructureVisualizer.png "Structure visualizer in Visual Studio")

For more information about our new productivity features, see the [Productivity in Visual Studio 2017](https://blogs.msdn.microsoft.com/visualstudio/2016/11/28/productivity-in-visual-studio-2017-rc/) blog post by Mark Wilson-Thomas.

### Visual C++
You'll see several improvements in Visual Studio, such as distributing C++ Core Guidelines with Visual Studio, updating the compiler by adding enhanced support for C++11 and C++ features, and adding and updating functionality in the C++ libraries. We've also improved the performance of the C++ IDE, installation workloads, and more.

As well, we've fixed over 250 bugs and reported issues in the compiler and tools, many submitted by customers through [Microsoft Connect](https://connect.microsoft.com/VisualStudio "Microsoft Connect").

For complete details, see our [What's New for Visual C++ in Visual 2017](/cpp/top/what-s-new-for-visual-cpp-in-visual-studio) page.  

### Debugging and Diagnostics
#### Run to Click:
Now, you can more easily skip ahead during debugging without setting a breakpoint to stop on the line you want. When you are stopped in the debugger, just click the icon that appears next to the line of code. Your code will run and stop on that line the next time it is hit in your code path.

![Visual Studio 2017 debug - Run To Click](../ide/media/vs2017ide-RunToClick.png "Run To Click in Visual Studio debug & diagnostics")

#### The New Exception Helper:
The new Exception Helper helps you view your exception information at-a-glance. The information is presented in a compact form with instant access to inner exceptions. When you diagnose a NullReferenceException, you can quickly see what was null right inside the Exception Helper.

![The New Exception Helper dialog in Visual Studio](../ide/media/vs2017ide-ExceptionHelper.png "The New Exception Helper dialog")

For more information, see the [Using the New Exception Helper in Visual Studio](https://blogs.msdn.microsoft.com/visualstudioalm/2016/03/31/using-the-new-exception-helper-in-visual-studio-15-preview/) blog post.

## Cloud app development with Azure
### Azure Functions Tools
As part of the "Azure development" workload, we've included tools to help you develop Azure functions by using pre-compiled C# class libraries. Now you can build, run, and debug on your local development machine and then publish directly to Azure from Visual Studio.

For more information, see the [Azure Functions Tools for Visual Studio](https://docs.microsoft.com/azure/azure-functions/functions-develop-vs) page.

## Mobile app development
### Xamarin
As part of the "Mobile development with .NET" workload, developers familiar with C#, .NET, and Visual Studio can deliver native Android, iOS, and Windows apps by using Xamarin. Developers can enjoy the same the power and productivity when working with Xamarin for mobile apps, including remote debugging on Android, iOS, and Windows devices&mdash;without having to learn native coding languages like Objective-C or Java.

For more information, see the [Visual Studio and Xamarin](../cross-platform/visual-studio-and-xamarin.md) page.

### Entitlements editor
**New in 15.3**: For your iOS development needs, we've added a stand-alone Entitlements editor. It includes a user-friendly UI that can be easily browsed. To launch it, double-click your entitlements.plist file.

![Entitlement editor for Xamarin](../ide/media/xamarin-entitlements-editor.png "Entitlement editor for Xamarin")

## Cross-platform development
### Redgate Data Tools
To extend DevOps capabilities to SQL Server database development, Redgate Data Tools are now available in Visual Studio.

Included with Visual Studio 2017 Enterprise:
- [Redgate ReadyRoll Core](http://www.red-gate.com/products/sql-development/readyroll/entrypage/microsoft-and-readyroll?utm_source=microsoft&utm_medium=link&utm_campaign=readyroll&utm_term=docs-newinvs) helps you develop migration scripts, manage database changes using source control, and safely automate deployments of SQL Server database changes alongside applications changes.
- [Redgate SQL Prompt Core](http://www.red-gate.com/products/sql-development/sql-prompt/entrypage/microsoft-and-sql-prompt?utm_source=microsoft&utm_medium=link&utm_campaign=sqlprompt&utm_term=docs-newinvs) helps you write SQL more quickly and accurately with the help of intelligent code completion. SQL Prompt autocompletes database and system objects and keywords, and offers column suggestions as you type. This results in cleaner code and fewer errors because you don't have to remember every column name or alias.

Included with all editions of Visual Studio 2017:
- [Redgate SQL Search](http://www.red-gate.com/products/sql-development/sql-search/?utm_source=microsoft&utm_medium=link&utm_campaign=sqlsearch&utm_term=docs-newinvs) increases your productivity by helping you quickly find SQL fragments and objects across multiple databases.

To learn more, see our [Redgate Data Tools in Visual Studio 2017](https://blogs.msdn.microsoft.com/visualstudio/2017/03/07/redgate-data-tools-in-visual-studio-2017/) blog post.

### Visual Studio Tools for Unity
As part of the "Games development for Unity" workload, we've included tools to help you develop cross-platform to create 2D and 3D games and interactive content. Create once and publish to 21 platforms, including all mobile platforms, WebGL, Mac, PC and Linux desktop, web, or consoles by using Visual Studio 2017 and Unity 5.6.

For more information, see the [Visual Studio Tools for Unity](../cross-platform/visual-studio-tools-for-unity.md) page.

### .NET Core
.NET Core is a general purpose, modular, cross-platform, and open source implementation of the .NET Standard and contains many of the same APIs as the .NET Framework.

The .NET Core platform is made of several components, which include the managed compilers, the runtime, the base class libraries, and numerous application models, such as ASP.NET Core. .NET Core supports three main operating systems: Windows, Linux, and macOS. You can use .NET Core in device, cloud, and embedded/IoT scenarios.

And, it now includes Docker support.  

**New in 15.3**: Visual Studio 2017 version 15.3 supports .NET Core 2.0 development. Using .NET Core 2.0 requires downloading and installing the .NET Core 2.0 SDK separately.  

For more information, see the [.NET Core Guide](https://docs.microsoft.com/dotnet/core/index) page.

## Talk to us  
 Why send feedback to the Visual Studio team? Because we take customer feedback seriously. It drives much of what we do.  

If you want to make a suggestion about how we can improve Visual Studio, or report a problem, please see the [Talk to Us](../ide/talk-to-us.md) page.  

### Report a problem  
 Sometimes, a message isn't enough to convey the full impact of a problem you've encountered. If you experience a hang, crash, or other performance issue, you can easily share repro steps and supporting files (such as screenshots, and trace and heap dump files) with us by using the **Report a Problem** tool. For more information about how to use this tool, see the [How to Report a Problem](how-to-report-a-problem-with-visual-studio-2017.md) page.  

### Track your issue in Connect  
 If want to track the status of your Visual Studio feedback, go to [Connect](http://connect.microsoft.com/) and report the bug there. After you report it, you can return to Connect to track its status.  

## See Also
* [Visual Studio 2017 Release Notes](https://www.visualstudio.com/news/vs2015-vs)
* [What's New in Visual C++](/cpp/top/what-s-new-for-visual-cpp-in-visual-studio)
* [What's New in C#](https://docs.microsoft.com/dotnet/csharp/csharp-7)  
* [What's New for Team Foundation Server](https://www.visualstudio.com/docs/whats-new)
* [What's New in Visual Studio for Mac](https://www.visualstudio.com/vs/visual-studio-mac/)
