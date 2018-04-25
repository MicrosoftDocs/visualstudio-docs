---
title: Overview of Visual Studio 2017
ms.date: 02/05/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: conceptual
author: gewarren
f1_keywords:
  - vs.startpage
  - VS.StartPage.HowDoI
  - MSDNSTART
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Visual Studio IDE overview

The Visual Studio interactive development environment (IDE) is a creative launching pad that you can use to view and edit nearly any kind of code, and then debug, build, and publish apps for Android, iOS, Windows, the web, and the cloud. There are versions available for Mac and Windows. This topic introduces you to the features of the Visual Studio IDE. We'll walk through some things you can do with Visual Studio and how to install and use it, create a simple project, get pointers on debugging and deploying code, and take a tour of the various tool windows.

## What can you do with the Visual Studio IDE?

Do you want to create an app for an Android phone? You can do that. How about create a cutting edge game using C++? You can do that too and much, much more. Visual Studio provides templates that help you make websites, games, desktop apps, mobile apps, apps for Office, and more.

![Visual Studio projects](../ide/media/VSIDE_Tour_Projects_List.png)

Or, you can simply open some code you get from almost anywhere and get working. See a project on GitHub that you like? Just clone the repository, open it in Visual Studio, and start coding!

### Create mobile apps

You can create native mobile apps for different platforms by using C# and Xamarin, or Visual C++, or hybrid apps using JavaScript with Apache Cordova. You can write mobile games for Unity, Unreal, DirectX, Cocos, and more. Visual Studio includes an Android emulator to help you run and debug Android apps.

You can leverage the power of the cloud for your mobile apps by creating Azure app services. Azure app services enable your apps to store data on the cloud, securely authenticate users, and automatically scale its resources up or down to accommodate the needs of your app and your business. To learn more, see [Mobile app development](https://www.visualstudio.com/vs/mobile-app-development/).

### Create cloud apps for Azure

Visual Studio offers a suite of tools that enable you to easily create cloud-enabled applications powered by Microsoft Azure. You can configure, build, debug, package, and deploy applications and services on Microsoft Azure directly from the IDE. To get Azure Tools for .NET, select the **Azure development** workload when you install Visual Studio. For more information, see [Visual Studio Tools for Azure](https://www.visualstudio.com/vs/azure-tools/).

You can leverage Azure services for your apps using Connected Services such as:

- [Azure Mobile Services](http://azure.microsoft.com/documentation/services/mobile-services/)

- [Azure Storage](http://azure.microsoft.com/documentation/services/storage/)

[HockeyApp](https://www.visualstudio.com/hockey-app/) helps you distribute beta versions, collect live crash reports, and get feedback from real users. In addition, you can integrate Office 365 REST APIs into your own app to connect to data stored in the cloud. For more information, see [these GitHub samples](https://github.com/OfficeDev/?utf8=%E2%9C%93&query=o365).

[Application Insights](https://marketplace.visualstudio.com/items?itemName=VisualStudioOnlineApplicationInsights.application-insights) helps you detect and diagnose quality issues in your apps and web services. Application Insights also helps you understand what your users actually do with your app, so you can optimize the user experience.

### Create apps for the web

The web drives our modern world, and Visual Studio can help you write apps for it. You can create web apps using ASP.NET, Node.js, Python, JavaScript and TypeScript. Visual Studio understands web frameworks like Angular, jQuery, Express, and more. ASP.NET Core and .NET Core run on Windows, Mac, and Linux operating systems. [ASP.NET Core](http://www.asp.net/core/overview) is a major update to MVC, WebAPI and SignalR, and runs on Windows, Mac, and Linux.  ASP.NET Core has been designed from the ground up to provide you with a lean and composable .NET stack for building modern cloud-based web apps and services.

For more information, see [Modern web tooling](https://www.visualstudio.com/vs/modern-web-tooling/).

### Build cross-platform apps and games

You can use Visual Studio to build apps and games for macOS, Linux, and Windows, as well as for Android, iOS, and other mobile devices.

- Build [.NET Core](/dotnet/core/) apps that run on Windows, macOS and Linux.

- Build mobile apps for iOS, Android, and Windows in C# and F# by using [Xamarin](https://developer.xamarin.com/guides/cross-platform/windows/visual-studio/).

- Use standard web technologies&mdash;HTML, CSS, and JavaScript&mdash;to build mobile apps for iOS, Android, and Windows by using [Apache Cordova](/visualstudio/cross-platform/tools-for-cordova/).

- Build 2D and 3D games in C# by using [Visual Studio Tools for Unity](../cross-platform/visual-studio-tools-for-unity.md).

- Build native C++ apps for iOS, Android and Windows devices, and share common code in libraries built for iOS, Android, and Windows, by using [C++ for cross-platform development](../cross-platform/visual-cpp-for-cross-platform-mobile-development.md).

- Deploy, test, and debug Android apps with the [Android emulator](../cross-platform/visual-studio-emulator-for-android.md).

Visual Studio can do help you do many more things. For a more complete list, see [www.visualstudio.com](https://www.visualstudio.com/vs/).

## Install the Visual Studio IDE

To get started, download Visual Studio and install it on your system. You can download it at [Visual Studio 2017](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs).

Visual Studio is now more lightweight than ever. The modular installer enables you to choose and install *workloads*, which are groups of features needed for the programming language or platform you prefer. This strategy helps keep the footprint of the Visual Studio installation smaller than ever before, which means it installs and updates faster too. In addition to improved installation performance, Visual Studio 2017 also has shorter IDE start-up and solution load times.

To learn more about setting up Visual Studio on your system, see [Install Visual Studio 2017](../install/install-visual-studio.md). To follow the steps for [creating a program](#create-a-program), be sure to select the **.NET Core cross-platform development** workload during the installation.

![Visual Studio Installer](../ide/media/overview-net-core-workload.png)

## Sign in

When you start Visual Studio for the first time, you can optionally sign in using your Microsoft account, or your work or school account. Being signed in lets you synchronize Visual Studio settings, such as window layouts, across multiple devices. It also connects you automatically to the services you might need, such as Azure subscriptions and [Visual Studio Team Services](/vsts/).

## Create a program

One good way to learn about something is to use it! Let's dive in and create a new, simple program.

1. Open Visual Studio. On the menu, choose **File** > **New** > **Project**.

  ![File > New Project on menu bar](../ide/media/VSIDE_Tour_NewProject1.png)

1. The **New Project** dialog box shows several project templates. Choose the **.NET Core** category under **Visual C#**, and then choose the **Console App (.NET Core)** template. In the **Name** text box, type "HelloWorld". Select the **OK** button.

  ![.NET Core app template](../ide/media/overview-new-project-dialog.png)

  > [!NOTE]
  > If you don't see the **.NET Core** category, you need to install the **.NET Core cross-platform development** workload. To do this, choose the **Open Visual Studio Installer** link on the bottom left of the **New Project** dialog. After **Visual Studio Installer** opens, scroll down and select the **.NET Core cross-platform development** workload, and then choose **Modify**.

   Visual Studio uses the template to create your project. It is a simple "Hello World" application that calls the <xref:System.Console.WriteLine> method to display the literal string "Hello World!" in the console window.

1. Shortly, you should see something like the following screenshot:

  ![Visual Studio IDE](../ide/media/overview-ide-console-app.png)

   The C# code for your application is shown in the editor window, which takes up most of the space. Notice that the code syntax is automatically colorized to indicate different types of code, such as keywords and types. In addition, small, vertical dashed lines in the code indicate which braces match one another, and line numbers help you locate code later. You can choose the small, boxed minus signs to collapse or expand code. This code outlining feature lets you hide code you don't need, helping to minimize onscreen clutter.

   The project files are listed on the right side in a window called **Solution Explorer**.

  ![Visual Studio IDE with red boxes](../ide/media/overview-ide-console-app-red-boxes.png)

  There are other menus and tool windows available, but let's move on for now.

1. Now, start the app. You can do this by choosing **Start Without Debugging** from the **Debug** menu on the menu bar. You can also press **Ctrl**+**F5**.

  ![Debug > Start without debugging menu](../ide/media/overview-start-without-debugging.png)

  Visual Studio builds the app, and a console window opens with the message "Hello World!". You now have a running app!

  ![Console window](../ide/media/overview-console-window.png)

1. To close the console window, press any key on your keyboard.

1. Let's add some additional code to the app. Add the following C# code before the line that says `Console.WriteLine("Hello World!");`:

   ```csharp
   Console.WriteLine("\nWhat is your name?");
   var name = Console.ReadLine();
   ```

   This code displays "What is your name?" in the console window, and waits until the user enters some text followed by the **Enter** key.

1. Now change the line that says `Console.WriteLine("Hello World!");` to the following code:

   ```csharp
   Console.WriteLine($"\nHello {name}!");
   ```

1. Run the app again by selecting **Debug** > **Start Without Debugging** or by pressing **Ctrl**+**F5**.

   Visual Studio rebuilds the app, and a console window opens and prompts you for your name.

1. Enter your name in the console window and press **Enter**.

   ![Console window input](media/overview-console-input.png)

1. Press any key to close the console window.

## Debug, test, and improve your code

Nothing runs perfectly all the time. When you write code, you need to run it and test it for bugs and performance. Visual Studio's cutting edge debugging system enables you to debug code running in your local project, on a remote device, or on an emulator such as [the one for Android devices](../cross-platform/visual-studio-emulator-for-android.md). You can step through code one statement at a time and inspect variables as you go. You can set breakpoints that are only hit when a specified condition is true. You can monitor the values of variables as the code runs, and more. All of this can be managed in the code editor itself, so that you don't have to leave your code. To get more details about debugging in Visual Studio, see [Debugger feature tour](../debugger/debugger-feature-tour.md).

For testing, Visual Studio offers unit testing, IntelliTest, load and performance testing, and more. To learn more about testing, see [Testing tools and scenarios](../test/developer-testing-scenarios.md). To learn more about improving the performance of your apps, see [Profiling feature tour](../profiling/profiling-feature-tour.md).

## Deploy your finished application

When your application is ready to deploy to users or customers, Visual Studio provides the tools to do that, whether you're deploying to Microsoft Store, to a SharePoint site, or with InstallShield or Windows Installer technologies. It's all accessible through the IDE. For more information, see [Deploy applications, services, and components](../deployment/deploying-applications-services-and-components.md).

## Quick tour of the IDE

To give you a high-level visual overview of Visual Studio, the following image shows Visual Studio with an open project along with several key tool windows you will most likely use:

- [Solution Explorer](../ide/solutions-and-projects-in-visual-studio.md) lets you view, navigate, and manage your code files. Solution Explorer can help organize your code by grouping the files into solutions and projects.

- The [Editor](../ide/writing-code-in-the-code-and-text-editor.md) window, where you'll likely spend a majority of your time, shows your code and enables you to edit source code and design a UI.

- The [Output](../ide/reference/output-window.md) window is where Visual Studio sends its notifications, such as debugging and error messages, compiler warnings, publishing status messages, and more. Each message source has its own tab.

- [Team Explorer (VSTS)](/vsts/user-guide/work-team-explorer) lets you track work items and share code with others using version control technologies such as [Git](https://git-scm.com/) and [Team Foundation Version Control (TFVC)](/vsts/tfvc/overview).

- [Cloud Explorer](/azure/vs-azure-tools-resources-managing-with-cloud-explorer) lets you view and manage your Azure resources, such as virtual machines, tables, SQL databases, and more. If a particular operation requires the Azure portal, Cloud Explorer provides links that take you to the place in the Azure portal you need to go.

![The Visual Studio IDE](../ide/media/visualstudioide.png)

Following are some other common productivity features in Visual Studio:

- The [Quick Launch](../ide/reference/quick-launch-environment-options-dialog-box.md) search box is a great way to rapidly find what you need in Visual Studio. Just start entering in the name of whatever you are looking for, and Visual Studio lists results that take you exactly where you want to go. **Quick Launch** also shows links that start the Visual Studio Installer for any workload or individual component.

  ![Quick Launch search box](../ide/media/VSIDE_Tour_QuickLaunch.png)

- [Refactoring](../ide/refactoring-in-visual-studio.md) includes operations such as intelligent renaming of variables, moving selected lines of code into a separate function, moving code to other locations, reordering function parameters, and more.

 ![Refactoring](../ide/media/VSIDE_refactor.png)

- **IntelliSense** is an umbrella term for a set of popular features that display type information about your code directly in the editor and, in some cases, write small bits of code for you. It's like having basic documentation inline in the editor, which saves you from having to look up type information in a separate help window. IntelliSense features vary by language. For more information, see [C# IntelliSense](../ide/visual-csharp-intellisense.md), [Visual C++ IntelliSense](../ide/visual-cpp-intellisense.md), [JavaScript IntelliSense](../ide/javascript-intellisense.md), and [Visual Basic IntelliSense](../ide/visual-basic-specific-intellisense.md). The following illustration shows some IntelliSense features at work:

  ![Visual Studio Member List](../ide/media/vs2017_Intellisense.png)

- **Squiggles** are wavy red underlines that alert you to errors or potential problems in your code in real time as you type. This enables you to fix them immediately without waiting for the error to be discovered during compilation or run time. If you hover over the squiggle, you see additional information about the error. A light bulb may also appear in the left margin with suggestions for how to fix the error. For more information, see [Quick Actions](../ide/quick-actions.md).

 ![Squiggles](../ide/media/vs2017_squiggle.png)

- The [Call Hierarchy](../ide/reference/call-hierarchy.md) window can be opened on the text editor context menu to show the methods that call, and are called by, the method under the caret (insertion point).

 ![Call Hierarchy window](../ide/media/VSIDE_call_hierarchy.png)

- [CodeLens](../ide/find-code-changes-and-other-history-with-codelens.md) enables you to find references and changes to your code, linked bugs, work items, code reviews, and unit tests, all without leaving the editor.

 ![CodeLens](../ide/media/codelensoverview.png)

- The [Peek to Definition](../ide/how-to-view-and-edit-code-by-using-peek-definition-alt-plus-f12.md) window shows a method or type definition inline, without navigating away from your current context.

 ![Peek to Definition](../ide/media/VSIDE_peek_definition.png)

- The **Go To Definition** context menu option takes you directly to the place where the function or object is defined. Other navigation commands are also available by right-clicking in the editor.

 ![Go to Definition](../ide/media/VSIDE_go_to_definition.png)

## Manage your source code and collaborate with others

You can manage your source code in Git repos hosted by any provider, including GitHub. Or use [Visual Studio Team Services (VSTS)](/vsts/index) to manage code alongside bugs and work items for your whole project. See [Get started with Git and Team Services (VSTS)](/vsts/git/gitquickstart?tabs=visual-studio) to learn more about managing Git repos in Visual Studio using Team Explorer. Visual Studio also has other built-in source control features. To learn more about them, see [New Git features in Visual Studio 2017 (blog)](https://blogs.msdn.microsoft.com/visualstudioalm/2017/03/06/new-git-features-in-visual-studio-2017/).

Visual Studio Team Services is a cloud-based service for hosting software projects and enabling collaboration in teams. VSTS supports both Git and Team Foundation Source Control systems, as well as Scrum, CMMI and Agile development methodologies. Team Foundation Version Control (TFVC) uses a single, centralized server repository to track and version files. Local changes are always checked in to the central server where other developers can get the latest changes.

Team Foundation Server (TFS) is the application lifecycle management hub for Visual Studio. It enables everyone involved with the development process to participate using a single solution. TFS is useful for managing heterogeneous teams and projects, too.

If you have a Visual Studio Team Services account or a Team Foundation Server on your network, you connect to it through the **Team Explorer** window in Visual Studio. From this window you can check code into or out of source control, manage work items, start builds, and access team rooms and workspaces. You can open **Team Explorer** from the **Quick Launch** box, or on the main menu from **View** > **Team Explorer** or from **Team** > **Manage Connections**.

The following image shows the **Team Explorer** window for a solution that is hosted in VSTS.

![Visual Studio Team Explorer](../ide/media/vs2017_teamexplorer.png)

You can also automate your build process to build the code that the devs on your team have checked into version control. For example, you can build one or more projects nightly or every time that code is checked in. For more information, see [Build and release (VSTS and TFS)](/vsts/build-release/index).

## Connect to services, databases, and cloud-based resources

The cloud is critical for today's online world, and Visual Studio provides you the means to leverage it. For example, the Connected Services feature enables you to connect your app to services. Your apps can use it to store their data on Azure storage, among other things.

![Connected services](../ide/media/VSIDE_Tour_Connected_Services.png)

Choosing a service on the **Connected Services** page starts a **Connected Services** wizard that configures your project and downloads the necessary NuGet packages to help get you started coding against the service.

You can view and manage your Azure-based cloud resources within Visual Studio using [Cloud Explorer](/azure/vs-azure-tools-resources-managing-with-cloud-explorer). Cloud Explorer shows the Azure resources in all the accounts managed under the Azure subscription you are logged into. You can get **Cloud Explorer** by selecting the **Azure development** workload in the Visual Studio installer.

![Cloud Explorer](../ide/media/VSIDE_CloudExplorer.png)

**Server Explorer** helps you browse and manage SQL Server instances and assets locally, remotely, and on Azure, Salesforce.com, Office 365, and websites. To open **Server Explorer**, on the main menu, choose **View** > **Server Explorer**. See [Add new connections](../data-tools/add-new-connections.md) for more information on using Server Explorer.

[SQL Server Data Tools (SSDT)](/sql/ssdt/download-sql-server-data-tools-ssdt) is a powerful development environment for SQL Server, Azure SQL Database and Azure SQL Data Warehouse. It enables you to build, debug, maintain, and refactor databases. You can work with a database project, or directly with a connected database instance on- or off-premises.

**SQL Server Object Explorer** in Visual Studio provides a view of your database objects similar to SQL Server Management Studio. SQL Server Object Explorer enables you to do light-duty database administration and design work, including editing table data, comparing schemas, executing queries by using contextual menus right from SQL Server Object Explorer, and more.

![SQL Server Object Explorer](../ide/media/vs2015_sqlobjectexplorer.png)

## Extend Visual Studio

If Visual Studio doesn't have the exact functionality you need, you can add it! You can personalize the IDE based on your workflow and style, add support for external tools not yet integrated with Visual Studio, and modify existing functionality to increase your productivity. To find the latest version of the Visual Studio Extensibility Tools (VS SDK), see [Visual Studio SDK](../extensibility/visual-studio-sdk.md).

You can use the .NET Compiler Platform ("Roslyn") to write your own code analyzers and code generators. Find everything you need at [Roslyn](https://github.com/dotnet/Roslyn).

Find [existing extensions](https://marketplace.visualstudio.com/vs) for Visual Studio created by Microsoft developers as well as our development community.

To learn more about extending Visual Studio, see [Extend Visual Studio IDE](https://www.visualstudio.com/vs/extend/).

## Learn more and find out what's new

If you've never used Visual Studio before, look at [Get started developing with Visual Studio](../ide/get-started-developing-with-visual-studio.md), or check out the free Visual Studio courses available on [Microsoft Virtual Academy](https://mva.microsoft.com/product-training/visual-studio-courses#!index=2&lang=1033). If you want to check out the new features in Visual Studio 2017, see [What's new in Visual Studio 2017](../ide/whats-new-in-visual-studio.md).

Congratulations on completing the tour of the Visual Studio IDE! We hope you learned something useful about some of its main features.

## See also

* [Visual Studio IDE](https://www.visualstudio.com/vs/)
* [Visual Studio downloads](https://www.visualstudio.com/downloads/)
* [The Visual Studio blog](https://blogs.msdn.microsoft.com/visualstudio/)
* [Visual Studio forums](https://social.msdn.microsoft.com/Forums/vstudio/home?category=visualstudio%2Cvsarch%2Cvsdbg%2Cvstest%2Cvstfs%2Cvsdata%2Cvsappdev%2Cvisualbasic%2Cvisualcsharp%2Cvisualc)
* [Microsoft Virtual Academy](https://mva.microsoft.com/)