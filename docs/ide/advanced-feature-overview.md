---
title: Advanced features of Visual Studio 2017
ms.date: 05/25/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: conceptual
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Features of Visual Studio 2017

The [Visual Studio IDE overview](../ide/visual-studio-ide.md) topic gives a basic introduction to Visual Studio. This article describes features that might be more appropriate for experienced developers, or those who are already familiar with Visual Studio.

Visual Studio 2017 makes it easy to move your apps to the cloud. You can develop cutting edge games and mobile apps.

## Create mobile apps

You can create native mobile apps for different platforms by using C# and Xamarin, or Visual C++, or hybrid apps using JavaScript with Apache Cordova. You can write mobile games for Unity, Unreal, DirectX, Cocos, and more. Visual Studio includes an Android emulator to help you run and debug Android apps.

You can leverage the power of the cloud for your mobile apps by creating Azure app services. Azure app services enable your apps to store data on the cloud, securely authenticate users, and automatically scale its resources up or down to accommodate the needs of your app and your business. To learn more, see [Mobile app development](https://www.visualstudio.com/vs/mobile-app-development/).

## Create cloud apps for Azure

Visual Studio offers a suite of tools that enable you to easily create cloud-enabled applications powered by Microsoft Azure. You can configure, build, debug, package, and deploy applications and services on Microsoft Azure directly from the IDE. To get the Azure tools and project templates, select the **Azure development** workload when you install Visual Studio.

![Azure development workload](../data-tools/media/azure-development-workload.png)

After you install the **Azure development** workload, the following **Cloud** templates for C# are available in the **New Project** dialog:

![Cloud project templates for Visual Studio](media/cloud-project-templates.png)

Visual Studio's [Cloud Explorer](/azure/vs-azure-tools-resources-managing-with-cloud-explorer) lets you view and manage your Azure resources, such as virtual machines, tables, SQL databases, and more. If a particular operation requires the Azure portal, **Cloud Explorer** provides links that take you to the place in the Azure portal you need to go.

![Cloud Explorer in Visual Studio](media/cloud-explorer.png)

You can leverage Azure services for your apps using **Connected Services** such as:

- [Azure Mobile Services](http://azure.microsoft.com/documentation/services/mobile-services/)

- [Azure Storage](/azure/vs-azure-tools-connected-services-storage)

![Visual Studio Connected Services](media/connected-services.png)

Other tools that you might find useful for cloud development are:

- [HockeyApp](https://www.visualstudio.com/hockey-app/), which helps you distribute beta versions, collect live crash reports, and get feedback from real users. In addition, you can integrate Office 365 REST APIs into your own app to connect to data stored in the cloud. For more information, see [these GitHub samples](https://github.com/OfficeDev/?utf8=%E2%9C%93&query=o365).
- [Application Insights](https://marketplace.visualstudio.com/items?itemName=VisualStudioOnlineApplicationInsights.application-insights), which helps you detect and diagnose quality issues in your apps and web services. Application Insights also helps you understand what your users actually do with your app, so you can optimize the user experience.

For more information, see [Move to the Cloud With Visual Studio and Azure](https://www.visualstudio.com/vs/azure-tools/).

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

## Create apps for the web

The web drives our modern world, and Visual Studio can help you write apps for it. You can create web apps using ASP.NET, Node.js, Python, JavaScript and TypeScript. Visual Studio understands web frameworks like Angular, jQuery, Express, and more. ASP.NET Core and .NET Core run on Windows, Mac, and Linux operating systems. [ASP.NET Core](http://www.asp.net/core/overview) is a major update to MVC, WebAPI and SignalR, and runs on Windows, Mac, and Linux.  ASP.NET Core has been designed from the ground up to provide you with a lean and composable .NET stack for building modern cloud-based web apps and services.

For more information, see [Modern web tooling](https://www.visualstudio.com/vs/modern-web-tooling/).

## Build cross-platform apps and games

You can use Visual Studio to build apps and games for macOS, Linux, and Windows, as well as for Android, iOS, and other mobile devices.

- Build [.NET Core](/dotnet/core/) apps that run on Windows, macOS and Linux.

- Build mobile apps for iOS, Android, and Windows in C# and F# by using [Xamarin](https://developer.xamarin.com/guides/cross-platform/windows/visual-studio/).

- Use standard web technologies&mdash;HTML, CSS, and JavaScript&mdash;to build mobile apps for iOS, Android, and Windows by using [Apache Cordova](/visualstudio/cross-platform/tools-for-cordova/).

- Build 2D and 3D games in C# by using [Visual Studio Tools for Unity](../cross-platform/visual-studio-tools-for-unity.md).

- Build native C++ apps for iOS, Android and Windows devices, and share common code in libraries built for iOS, Android, and Windows, by using [C++ for cross-platform development](../cross-platform/visual-cpp-for-cross-platform-mobile-development.md).

- Deploy, test, and debug Android apps with the [Android emulator](../cross-platform/visual-studio-emulator-for-android.md).

Visual Studio can do help you do many more things. For a more complete list, see [www.visualstudio.com](https://www.visualstudio.com/vs/).

## Modular installation

Visual Studio's modular installer enables you to choose and install *workloads*, which are groups of features needed for the programming language or platform you prefer. This strategy helps to keep the footprint of the Visual Studio installation smaller, which means it installs and updates faster too. In addition to improved installation performance, Visual Studio 2017 also has shorter IDE [startup](optimize-visual-studio-startup-time.md) and solution load times.

If you haven't already, you can download Visual Studio 2017 [here](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs).

To learn more about setting up Visual Studio on your system, see [Install Visual Studio 2017](../install/install-visual-studio.md).

## Debug, test, and improve your code

Nothing runs perfectly all the time. When you write code, you need to run it and test it for bugs and performance. Visual Studio's cutting-edge debugging system enables you to debug code running in your local project, on a remote device, or on an emulator such as [the one for Android devices](../cross-platform/visual-studio-emulator-for-android.md). You can step through code one statement at a time and inspect variables as you go. You can set breakpoints that are only hit when a specified condition is true. You can monitor the values of variables as the code runs, and more. All of this can be managed in the code editor itself, so that you don't have to leave your code. To get more details about debugging in Visual Studio, see [Debugger feature tour](../debugger/debugger-feature-tour.md).

For testing, Visual Studio offers unit testing, IntelliTest, load and performance testing, and more. To learn more about testing, see [Testing tools and scenarios](../test/developer-testing-scenarios.md). To learn more about improving the performance of your apps, see [Profiling feature tour](../profiling/profiling-feature-tour.md).

## Deploy your finished application

When your application is ready to deploy to users or customers, Visual Studio provides the tools to do that, whether you're deploying to Microsoft Store, to a SharePoint site, or with InstallShield or Windows Installer technologies. It's all accessible through the IDE. For more information, see [Deploy applications, services, and components](../deployment/deploying-applications-services-and-components.md).

## Manage your source code and collaborate with others

You can manage your source code in Git repos hosted by any provider, including GitHub. Or use [Visual Studio Team Services (VSTS)](/vsts/index) to manage code alongside bugs and work items for your whole project. See [Get started with Git and Team Services (VSTS)](/vsts/git/gitquickstart?tabs=visual-studio) to learn more about managing Git repos in Visual Studio using Team Explorer. Visual Studio also has other built-in source control features. To learn more about them, see [New Git features in Visual Studio 2017 (blog)](https://blogs.msdn.microsoft.com/visualstudioalm/2017/03/06/new-git-features-in-visual-studio-2017/).

Visual Studio Team Services is a cloud-based service for hosting software projects and enabling collaboration in teams. VSTS supports both Git and Team Foundation Source Control systems, as well as Scrum, CMMI and Agile development methodologies. Team Foundation Version Control (TFVC) uses a single, centralized server repository to track and version files. Local changes are always checked in to the central server where other developers can get the latest changes.

Team Foundation Server (TFS) is the application lifecycle management hub for Visual Studio. It enables everyone involved with the development process to participate using a single solution. TFS is useful for managing heterogeneous teams and projects, too.

If you have a Visual Studio Team Services account or a Team Foundation Server on your network, you connect to it through the **Team Explorer** window in Visual Studio. From this window you can check code into or out of source control, manage work items, start builds, and access team rooms and workspaces. You can open **Team Explorer** from the **Quick Launch** box, or on the main menu from **View** > **Team Explorer** or from **Team** > **Manage Connections**.

The following image shows the **Team Explorer** window for a solution that is hosted in VSTS.

![Visual Studio Team Explorer](../ide/media/vs2017_teamexplorer.png)

You can also automate your build process to build the code that the devs on your team have checked into version control. For example, you can build one or more projects nightly or every time that code is checked in. For more information, see [Build and release (VSTS and TFS)](/vsts/build-release/index).

## Extend Visual Studio

If Visual Studio doesn't have the exact functionality you need, you can add it! You can personalize the IDE based on your workflow and style, add support for external tools not yet integrated with Visual Studio, and modify existing functionality to increase your productivity. To find the latest version of the Visual Studio Extensibility Tools (VS SDK), see [Visual Studio SDK](../extensibility/visual-studio-sdk.md).

You can use the .NET Compiler Platform ("Roslyn") to write your own code analyzers and code generators. Find everything you need at [Roslyn](https://github.com/dotnet/Roslyn).

Find [existing extensions](https://marketplace.visualstudio.com/vs) for Visual Studio created by Microsoft developers as well as our development community.

To learn more about extending Visual Studio, see [Extend Visual Studio IDE](https://www.visualstudio.com/vs/extend/).

## Learn more and find out what's new

If you've never used Visual Studio before, look at [Get started developing with Visual Studio](../ide/get-started-developing-with-visual-studio.md), or check out the free Visual Studio courses available on [Microsoft Virtual Academy](https://mva.microsoft.com/product-training/visual-studio-courses#!index=2&lang=1033). If you want to check out the new features in Visual Studio 2017, see [What's new in Visual Studio 2017](../ide/whats-new-in-visual-studio.md).

## See also

- [Visual Studio IDE overview](../ide/visual-studio-ide.md)