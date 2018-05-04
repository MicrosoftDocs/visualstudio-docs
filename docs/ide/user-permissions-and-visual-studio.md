---
title: User permissions and Visual Studio
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: conceptual
helpviewer_keywords:
  - "Visual Studio, user permissions"
  - "user permissions"
  - "administrative privileges"
  - "permissions"
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# User permissions and Visual Studio

For reasons of security you should run Visual Studio as a normal user whenever possible.

> [!WARNING]
> You should also make sure not to compile, launch, or debug any Visual Studio solution that does not come from a trusted person or a trusted location.

You can do nearly everything in the Visual Studio IDE as a normal user, but, you need administrator permissions to complete the following tasks:

|Area|Task|For more information|
|----------|----------|--------------------------|
|Installation|Install Visual Studio.|[Install Visual Studio](../install/install-visual-studio.md)|
||Installing, updating, or removing local Help content.|[Install and manage local content](../ide/install-and-manage-local-content.md)|
|Application types|Developing solutions for SharePoint.|[Requirements for developing SharePoint solutions](../sharepoint/requirements-for-developing-sharepoint-solutions.md)|  
||Acquiring a developer license for [!INCLUDE[win8_appstore_long](../debugger/includes/win8_appstore_long_md.md)].|[Get a developer license](http://go.microsoft.com/fwlink/?LinkID=241313)|
|Toolbox|Adding classic COM controls to **Toolbox**.|[Toolbox](../ide/reference/toolbox.md)|
|Add-ins|Installing and using add-ins that were written by using classic COM in the IDE.|[Create add-ins and wizards](http://msdn.microsoft.com/Library/c5a47c21-6668-4de3-898d-afa969317e73)|
|Building|Using post-build events that register a component.|[Understand custom build steps and build events](/cpp/ide/understanding-custom-build-steps-and-build-events)|
||Including a registration step when you build C++ projects.|[Understand custom build steps and build events](/cpp/ide/understanding-custom-build-steps-and-build-events)|
|Debugging|Debugging applications that run with elevated permissions.|[Debugger settings and preparation](../debugger/debugger-settings-and-preparation.md)|
||Debugging applications that a run under a different user account, such as ASP.NET websites.|[Debug ASP.NET and AJAX applications](../debugger/debugging-aspnet-and-ajax-applications.md)|
||Debugging in Zone for XAML Browser Applications (XBAP).|[WPF Host (PresentationHost.exe)](/dotnet/framework/wpf/app-development/wpf-host-presentationhost-exe)|
||Using the emulator to debug cloud service projects for Microsoft Azure.|[Debug a cloud service in Visual Studio](http://go.microsoft.com/fwlink/?LinkId=266725)|
||Configuring a firewall for remote debugging.|[Remote debugging](../debugger/remote-debugging.md)|
|Performance tools|Profiling an application.|[Beginners guide to performance profiling](../profiling/beginners-guide-to-performance-profiling.md)|
|Deployment|Deploying a web application to Internet Information Services (IIS) on a local computer.|[Deploy an ASP.NET Web Application to a hosting provider using Visual Studio or Visual Web Developer: Deploy to IIS as a test environment](http://go.microsoft.com/fwlink/?LinkId=266478)|
>>>>>>> 346075117af3d2bd1fddd9c3aca24516a39fa6a3

## Run Visual Studio as an administrator

You can launch Visual Studio with administrative permissions each time you start the IDE, or you can modify the application shortcut to always run with administrative permissions. For more information, see Windows Help.

### Run Visual Studio with administrative permissions

These instructions are for Windows 10. They are similar for other versions of Windows.

1. Open the **Start** menu, and scroll to Visual Studio 2017.

1. From the right-click or context menu of **Visual Studio 2017**, select **More** > **Run as administrator**.

     When Visual Studio starts, **(Administrator)** appears after the product name in the title bar.

## See also

- [Port, migrate, and upgrade Visual Studio projects](../porting/port-migrate-and-upgrade-visual-studio-projects.md)
- [Install Visual Studio](../install/install-visual-studio.md)