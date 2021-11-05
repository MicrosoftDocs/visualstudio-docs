---
title: "Write and debug code by using Hot Reload"
description: "Hot Reload, similar to edit and continue, allows you to make changes to your code while running apps"
ms.date: 11/05/2021
ms.topic: conceptual
helpviewer_keywords:
  - "Hot reload"
  - ".NET Hot Reload"
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: '>= vs-2022'
ms.workload:
  - "multiple"
---

# Write and debug running code with Hot Reload in Visual Studio (C#, C++, Visual Basic)

Starting in Visual Studio 2022, the Hot Reload experience in Visual Studio works for both managed .NET and native C++ apps. Regardless of the type of app you’re working on, our goal with Hot Reload is to save you as many app restarts between edits as possible, making you more productive by reducing the time you spend waiting for apps to rebuild, restart, renavigate to the previous location where you were in the app itself, etc.

We accomplish this by making it possible for you to edit your application's code files and apply the code changes immediately to the running application, also known as *Hot Reload*. Once those changes are applied, re-execute your code again by taking an action in the app itself (or through some sort of timer, etc.) and see the changes immediately, no pausing of the app through breakpoints required!

## Update running code with Hot Reload

1. Open a project based on a supported application type. For more information on .NET, see [.NET application support](#supported-net-app-frameworks-and-scenarios).

1. Make sure that **Enable native code debugging** is disabled in the debugger settings or the debug launch profile.

1. Start the app with the debugger attached using either **F5** or, if [supported for your application](#supported-net-app-frameworks-and-scenarios), **Ctrl+F5**.

1. Open a C#, C++, or Visual Basic code file with some code that can be re-executed through the running apps user interface (for example, code-behind for a button or a ViewModel’s command) or something that is being triggered at an interval through a timer and change the code.

1. Apply the code changes using the **Hot Reload** button, or press **ALT+F10**.

   ![Screenshot of the Hot Reload button.](../debugger/media/vs-2022/dotnet-hot-reload.gif)

## Supported .NET app frameworks and scenarios

* **When using Visual Studio 2022 and starting your app with the debugger** the basic Hot Reload experience works with most types of .NET apps and framework versions, this includes .NET Framework, .NET Core and .NET 5+ (for both C# and VB.NET as applicable). The type of apps that are supported include web (code-behind changes), desktop, mobile, cloud, and other project types. The key rule here is if you’re using the debugger assume Hot Reload is available to you and give it a try!
* **When using Visual Studio 2022 but not using the debugger** (for example using CTRL-F5 to start the app) Hot Reload is now available even without the debugger when targeting most types of .NET 6 apps. This means that apps not targeting .NET 6 (.NET 5 or below) will not support the “no debugger” scenario and must use the debugger to get Hot Reload support.
* **When using Visual Studio 2022 with a .NET 6 app, the most type of scenarios are supported.** This is not limited to the new “no debugger” feature mention above. It also includes other new capabilities such as support for Hot Reloading Blazor projects and more generally editing Razor files in any ASP.NET Core apps and CSS Hot Reload. Using both Visual Studio 2022 and apps that target .NET 6 together will definitively give you the most powerful Hot Reload experience and we hope you will give it a try.

The following table shows which application types support .NET Hot Reload with the debugger attached (F5) and without the debugger attached (Ctrl+F5), and whether .NET 6 is required for minimum support (that is, F5). .NET 6 is always required for Ctrl+F5 support. Also shown is the minimum version of Visual Studio that supports the feature.

|Application type|.NET 6 required (F5)|F5|Ctrl+F5|
|-|-|-|-|
|ASP.NET code behind|No|16.11|17.0|
|ASP.NET Razor (Blazor Server and ASP.NET Core|Yes|17.0|17.0|
|ASP.NET Razor (Blazor WASM)|Yes|No|17.0|
|XAML WPF|No|16.11|17.0|
|XAML WinUI3|No|16.11|No|
|WinForms|No|16,11|17.0|
|Console|No|16.11|17.0|
|XAML .NET MAUI WinUI|Yes|17.1 Preview 1|No|
|XAML .NET MAUI Android|Yes|17.1 Preview 1|No|
|XAML .NET MAUI iOS|Yes|17.1 Preview 1|No|
|XAML + Blazor .NET MAUI WinUI|Yes|17.1 Preview 1|No|
|XAML + Blazor .NET MAUI Android|Yes|17.1 Preview 1|No|
|XAML + Blazor .NET MAUI iOS|Yes|17.1 Preview 1|No|

The types of edits you can make with hot reload are determined by the runtime, not by the method you used to start the application (F5 or Ctrl+F5).

In the following sections, we’ll expand on the above summary and dive into more details.

## Support for C++ apps

When using Visual Studio 2022 and starting your app with the debugger, you can hot reload a native C++ application when running under the debugger (F5) using the **Hot Reload** button. Hot Reload is also supported for apps built using CMake and OpenFolder projects.

This experience is powered by native Edit and Continue. For supported edits, see [Edit and Continue](../debugger/edit-and-continue-visual-cpp.md).

## Visual Studio 2022 with a .NET app, when using the debugger

When using Visual Studio 2022 and starting the app with the debugger, Hot Reload works with most app frameworks, including typical app types such as Console, Windows Forms (WinForms), WPF, UWP, WinUI 3 (see note), and most types of ASP.NET web projects (for code-behind edits) including ASP.NET MVC, Web API and even older Web Forms projects. This list is also just an example. The real answer is anywhere you have .NET and you’re using the Visual Studio managed debugger, you should get basic Hot Reload support.

This means that even projects such as Azure Functions will work great in this scenario. We encourage you to try your combination and let us know if you find any problems.

> [!NOTE]
> WinUI 3 by default uses mixed mode debugging which does not support Hot Reload. You can modify this in project settings by enabling the Managed Debugger which will enable Hot Reload to work properly.

.NET MAUI apps are supported starting in Visual Studio 2022 version 17.1 Preview 1.

## Visual Studio 2022 with a .NET app, but not using the debugger

Hot Reload is now available without the debugger when targeting most types of .NET 6 apps, including project types such as Console, WPF, Windows Forms (WinForms), ASP.NET Core MVC, Web API and Blazor. We know some developers have good reason or preference to start their apps without the debugger and we hope this extra feature will give them value for little to no impact on startup time.

This feature is exclusive to .NET 6+ and those apps not targeting .NET 6 (.NET 5 or below) will not support the “no debugger” scenario and must use the debugger to get access to Hot Reload functionality.

Also be aware that not all project types will be supported for the “no debugger” scenario in our first release. Specifically:

- UWP apps are not supported for Hot Reload without the debugger, this is by design and there are no current plans to improve this.
- Xamarin.Forms apps targeting iOS & Android don’t support .NET Hot Reload (regardless of if you are starting your app with or without the debugger), but will continue to support XAML Hot Reload
- .NET MAUI apps are not supported.

## Visual Studio 2022 with a .NET 6 app

Developers who are able to use both Visual Studio 2022 and work on apps that target .NET 6 will get the benefits of the most polished and capable Hot Reload experience.

Highlights of what is supported:

* Blazor apps (Server and WebAssembly (see note))
* Razor file editing in both Blazor and regular ASP.NET Core websites
* CSS Hot Reload
* Ability to get Hot Reload support when running apps without the debugger (as described above in more detail)

Developers targeting .NET 6 will continue to get more improvements in future Visual Studio 2022 updates and .NET feature band and major releases. We’re just getting started!

> [!NOTE]
> In Visual Studio 2022 GA, Hot Reload support for Blazor WebAssembly when using the Visual Studio debugger isn’t enabled yet. You can still get Hot Reload If you start your app through Visual Studio without the debugger, and we are working to resolve this in a future Visual Studio update.

## Supported ASP.NET Core Scenarios

The basic Hot Reload experience is supported for many ASP.NET scenarios. The most widely available feature is the ability to change code-behind and other .NET class files for most types of web applications. This feature works while using the Visual Studio debugger and is present anywhere Edit and Continue was previously available.

For ASP.NET Core developers who are targeting .NET 6, there are additional capabilities not available for lower versions of .NET. These capabilities include:

* **CSHTML:** Editing a Razor CSHTML file supports many types of edits.
* **Browser Refresh:** Editing a razor file automatically refreshes the changes in your web browser when debugging. This feature was previously only available when starting the app without the debugger.
* **CSS Hot Reload:** You can change CSS files while the app is running, and changes will be applied immediately to the running app as you type.
* **No Debugger:** You get Hot Reload support when using Visual Studio to start your web app without the debugger (CTRL-F5).

> [!NOTE]
> When working on a Blazor Wasm app and using Visual Studio 2022 (17.0), Hot Reload for razor pages only works when launching apps without the debugger. We will be adding debugger support in a future update.

## Supported .NET Edits

The .NET Hot Reload experience is powered by the [Edit and Continue](../debugger/edit-and-continue-visual-csharp.md) mechanism and we’ve made improvements to support additional types of edits that go beyond what was originally possible in previous versions. Improvements include:

* Adding, updating, or deleting Custom Attributes
* Adding or updating Record structs
* Adding or updating #line directives
* Editing Switch expressions
* Editing files with #line directives, including changes to the directive itself
* Editing top-level statements
* Editing code that uses any of the new C# 10 features, such as global using directives, file scoped namespaces, improved lambdas, and parameter-less struct constructors
* Renaming Lambda parameters
* Renaming parameters of existing methods

The above improvements are available to both Hot Reload and the Edit and Continue experiences.

## Unsupported .NET Scenarios

Unsupported scenarios:

* Xamarin.Forms apps won’t support .NET Hot Reload in iOS and Android scenarios. You will get some Hot Reload when targeting a UWP app. This is by design, and we don’t expect to make any further improvements. (Note: XAML Hot Reload will continues to be available and supported for Xamarin.Forms customers on the latest SDK)
* .NET MAUI apps are not supported prior to Visual Studio 2022 version 17.1 Preview 1. Starting in 17.1 Preview 1, .NET MAUI is supported, but only with the debugger attached.
* Apps built using F# or those targeting .NET Native will not support Hot Reload.

## Configure .NET Hot Reload

You can configure .NET Hot Reload by selecting **Settings** from the **Hot Reload** drop-down button.

![Screenshot of configuring .NET Hot Reload](../debugger/media/vs-2022/dotnet-hot-reload-configure.png)

Or, open **Tools** > **Options** > **Debugging** > **.NET/C++ Hot Reload**.

The settings for hot reload include:

- **Enable Hot Reload and Edit and Continue when debugging**. Enables hot reload when starting with the debugger attached (F5).

- **Enable Hot Reload when starting without debugging**. Enables hot reload when starting without the debugger attached (Ctrl+F5).

- **Apply Hot Reload on File Save**. Applies code changes when you save the file.

![Screenshot of settings for .NET Hot Reload](../debugger/media/vs-2022/dotnet-hot-reload-settings.png)

## Warning message

If you see the following dialog box, hot reload is unable to apply the current edits without restarting. You can choose either to rebuild the app and apply changes (restart) or to continue editing. If you rebuild, all application state is lost. If you continue editing, it is possible that additional changes or corrections may cause hot reload to work again.

![Screenshot of the apply changes dialog box](../debugger/media/vs-2022/dotnet-hot-reload-apply-changes.png)

If you select the **Always rebuild** option in the dialog box, you won't see the dialog box again in the current Visual Studio session, and Visual Studio will automatically rebuild and reload instead of showing the dialog box.

## See also

[Edit and Continue (Visual C#)](../debugger/edit-and-continue-visual-csharp.md)
[Edit and Continue (C++)](../debugger/edit-and-continue-visual-cpp.md)
