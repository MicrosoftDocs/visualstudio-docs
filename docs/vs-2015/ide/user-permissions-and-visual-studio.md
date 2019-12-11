---
title: "User Permissions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "Visual Studio, user permissions"
  - "user permissions"
  - "administrative privileges"
  - "permissions"
ms.assetid: 70485ed7-6342-41bf-8250-7a6826e21b98
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: jillfra
---
# User Permissions and Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For reasons of security you should run Visual Studio as a normal user whenever possible.

> [!WARNING]
> You should also make sure not to compile, launch, or debug any Visual Studio solution that does not come from a trusted person or a trusted location.

 You can do nearly everything in the Visual Studio IDE as a normal user, but, you need administrator permissions to complete the following tasks:

|Area|Task|For more information|
|----------|----------|--------------------------|
|Installation|Installing Visual Studio.|[Installing Visual Studio 2015](../install/install-visual-studio-2015.md)|
||Upgrading from a trial edition of Visual Studio.|[How to: Upgrade from a Trial Edition of Visual Studio](../install/how-to-upgrade-from-a-trial-edition-of-visual-studio.md)|
||Installing, updating, or removing local Help content.|[Install and Manage Local Content](../ide/install-and-manage-local-content.md)|
|Application types|Developing solutions for SharePoint 2010.|[Requirements for Developing SharePoint Solutions](https://msdn.microsoft.com/library/ae8ff69d-4540-4380-ab0b-845f7108e89c)|
||Acquiring a developer license for [!INCLUDE[win8_appstore_long](../includes/win8-appstore-long-md.md)].|[Get a developer license (Windows Store apps)](https://go.microsoft.com/fwlink/?LinkID=241313)|
|Toolbox|Adding classic COM controls to the **Toolbox**.|[Using the Toolbox](../ide/using-the-toolbox.md)|
|Add-ins|Installing and using add-ins that were written by using classic COM in the IDE.|[Creating Add-ins and Wizards](https://msdn.microsoft.com/library/c5a47c21-6668-4de3-898d-afa969317e73)|
|Building|Using post-build events that register a component.|[Understanding Custom Build Steps and Build Events](https://msdn.microsoft.com/library/beb2f017-3e9f-4b2c-9b57-2572fd2628e4)|
||Including a registration step when you build C++ projects.|[Understanding Custom Build Steps and Build Events](https://msdn.microsoft.com/library/beb2f017-3e9f-4b2c-9b57-2572fd2628e4)|
|Debugging|Debugging applications that run with elevated permissions.|[Debugger Settings and Preparation](../debugger/debugger-settings-and-preparation.md)|
||Debugging applications that a run under a different user account, such as ASP.NET websites.|[Debugging ASP.NET and AJAX Applications](../debugger/debugging-aspnet-and-ajax-applications.md)|
||Debugging in Zone for XAML Browser Applications (XBAP).|[WPF Host (PresentationHost.exe)](https://msdn.microsoft.com/library/3215bfa1-722c-4ac8-a7c5-bdd02d30afbd)|
||Using the emulator to debug cloud service projects for Microsoft Azure.|[Debugging a Cloud Service in Visual Studio](https://go.microsoft.com/fwlink/?LinkId=266725)|
||Configuring a firewall for remote debugging.|[Set Up the Remote Tools on the Device](https://msdn.microsoft.com/library/90f45630-0d26-4698-8c1f-63f85a12db9c)|
|Performance tools|Profiling an application.|[Beginners Guide to Performance Profiling](../profiling/beginners-guide-to-performance-profiling.md)|
|Deployment|Deploying a web application to Internet Information Services (IIS) on a local computer.|[Deploying an ASP.NET Web Application to a Hosting Provider using Visual Studio or Visual Web Developer: Deploying to IIS as a Test Environment](https://go.microsoft.com/fwlink/?LinkId=266478)|
|Providing feedback to Microsoft|Changing how you participate in the Visual Studio Customer Experience Program.|[How to: Send Feedback](../misc/how-to-send-feedback-about-visual-studio.md)|

## Running Visual Studio as an Administrator
 You can launch Visual Studio with administrative permissions each time you start the IDE, or you can modify the application shortcut to always run with administrative permissions. For more information, see Windows Help.

#### To run Visual Studio with administrative permissions on [!INCLUDE[win8](../includes/win8-md.md)], [!INCLUDE[win81](../includes/win81-md.md)], [!INCLUDE[winserver8](../includes/winserver8-md.md)], or [!INCLUDE[winblue_server_2](../includes/winblue-server-2-md.md)]

1. On the **Start** screen, type **Visual Studio**. You should see the version or versions of Visual Studio you have installed.

2. Select the version of Visual Studio you want to start, and then bring up the shortcut menu (it appears at the bottom of the screen). Choose **Run as administrator**.

     When Visual Studio starts, **(Administrator)** appears after the product name in the title bar.

#### To run Visual Studio with administrative permissions on [!INCLUDE[win7](../includes/win7-md.md)] or [!INCLUDE[winsvr08_r2](../includes/winsvr08-r2-md.md)]

1. On the **Start** menu, choose **All Programs**.

2. In the **Microsoft Visual Studio** *Version* folder select  **Visual Studio** *Version* open the shortcut menu, and then choose **Run as administrator**.

     When Visual Studio starts, **(Administrator)** appears after the product name in the title bar.

## See Also
 [Porting, Migrating, and Upgrading Visual Studio Projects](../porting/porting-migrating-and-upgrading-visual-studio-projects.md)
 [Installing Visual Studio 2015](../install/install-visual-studio-2015.md)
