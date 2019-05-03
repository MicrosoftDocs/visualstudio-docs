---
title: "Razor"
description: "Information on the razor support in asp.net core apps in Visual Studio for Mac"
author: conceptdev
ms.author: crdun
ms.date: 05/03/2018
ms.topic: article
ms.technology: vs-ide-general
ms.assetid: F898CB6E-05ED-44CD-8DB6-427B2592CCC6
---

# Razor

Visual Studio for Mac provides support for Razor editing, including IntelliSense and syntax highlighting in *.cshtml* files.

![Razor editing in Visual Studio for Mac](media/razor-editor.png)

This guide provides an introduction to creating your first Razor web app. For a more in-depth guide please refer to the [Razor Pages in .NET Core documentation](/aspnet/core/razor-pages/index).

## Creating a new Razor project

* From the welcome screen, select **New** to create a new project:

![Visual Studio for Mac new project](media/razor-new.png)

* In the New Project dialogue, navigate to **.NET Core** > **App** > **Web Application** and select the **Next** button:

![Razor project template](media/razor-new-project1.png)

* Select your .NET Core Target Framework required (recommended 2.2 or above) and select **Next**.  Choose a name for your project, and add git support if required. Select **Create** to create the project.

![Razor project name](media/razor-new-project2.png)

Visual Studio for Mac will open your project in the Code layout.

* Run the project without debugging using **Cmd-Opt-F5**

Visual Studio will start [Kestral](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel) and launch a browser to `https://localhost:5001` and display your first Razor web app:

![Razor web app in Safari](media/razor-webapp.png)

## Project anatomy

Razor web apps consist of the following components:

### Pages folder

The Pages folder within the project is where the web pages can be found, along with the code-behind for each:
*    A **.cshtml* file for the HTML markup and Razor syntax.
*    A **.cshtml.cs* file for your C# code-behind for handling page events.

Supporting files have names that begin with an underscore. For example, the _Layout.cshtml file configures UI elements common to all pages. This file sets up the navigation menu at the top of the page and the copyright notice at the bottom of the page. For more information, see [Layout in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/layout).

### Launch settings

The *launchSettings.json* file contains the IIS settings, application URL and other related settings.

### App settings

The *appSettings,json* file contains configuration data such as connection strings.

For more information about configuration see the [Configuration in ASP.NET guide](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/index).

### wwwroot folder

Contains static files, such as HTML files, JavaScript files, and CSS files. For more information, see [Static files in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/static-files).

### Program.cs

Contains the entry point for the program. For more information, see [ASP.NET Core Web Host](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/web-host).

### Startup.cs

Contains code that configures app behavior, such as whether it requires consent for cookies. For more information, see [App startup in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/startup).

## See aso

For a more comprehensive guide on creating Razor web apps see [Introduction to Razor Pages in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/index).

<!--
## Getting Started with Razor in Visual Studio for Mac

There are two options to consider when getting started with Razor in Visual Studio for Mac: Razor Pages in ASP.NET Core and ASP.NET Core MVC. For tutorials and more information on both options, visit one of the guides below:

- [Get started with Razor Pages in ASP.NET Core on macOS with Visual Studio for Mac](/aspnet/core/tutorials/razor-pages-mac/razor-pages-start?view=aspnetcore-2.1)
- [Get started with ASP.NET Core MVC and Visual Studio for Mac](/aspnet/core/tutorials/first-mvc-app-mac/start-mvc?view=aspnetcore-2.1)

## See also

- [Get started with C# and ASP.NET Core in Visual Studio (on Windows)](/visualstudio/ide/tutorial-csharp-aspnet-core)
- -->