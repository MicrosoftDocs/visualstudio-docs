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

Starting in Visual Studio 2022, the Hot Reload experience in Visual Studio works for both managed .NET and native C++ apps. Regardless of the type of app you’re working on, our goal with Hot Reload is to save you as many app restarts between edits as possible, making you more productive by reducing the time you spend waiting for apps to rebuild, restart, re-navigate to the previous location where you were in the app itself, etc.

We accomplish this by making it possible for you to edit your applications code files and apply those code changes immediately to the running application, also known as *Hot Reload*. Once those changes are applied, simply re-execute your code again by taking an action in the app itself (or through some sort of timer, etc.) and see the changes immediately, no pausing of the app through breakpoints required!

## Update running code with Hot Reload

1. Open a project based on a supported application type. For more information on .NET, see [.NET application support](#net-application-support).

1. Make sure that **Enable native code debugging** is disabled in the debugger settings or the debug launch profile.

1. Start the app with the debugger attached using either **F5** or, if [supported for your application](#net-application-support), **Ctrl+F5**.

1. Open a C#, C++, or Visual Basic code file with some code that can be re-executed through the running apps user interface (for example, code-behind for a button or a ViewModel’s command) or something that is being triggered at an interval through a timer and change the code.

1. Apply the code changes using the **Hot Reload** button, or press **ALT+F10**. 

   ![Screenshot of the Hot Reload button.](../debugger/media/vs-2022/dotnet-hot-reload.gif)

## Requirements

Visual Studio 2022 and .NET 6 provide the best experience for Hot Reload. Starting in Visual Studio 2019 version 16.11, some application types support Hot Reload with the debugger attached.

For .NET, supported runtimes include CoreCLR, .NET Framework 4.6 and later versions, and Mono if targeting .NET 6 (for Blazor WASM or .NET MAUI).

- For F5 scenarios (debugger attached), supported frameworks include .NET Core, .NET 5 and later versions, and .NET Framework 4.6 and later versions.

- For Ctrl+F5 scenarios (no debugger attached), .NET 6 is a minimum requirement.

## .NET application support

The following table shows which application types support .NET Hot Reload with the debugger attached (F5) and without the debugger attached (Ctrl+F5), and whether .NET 6 is required for minimum support (that is, F5). .NET 6 is always required for Ctrl+F5 support. Also shown is the minimum version of Visual Studio that supports the feature.

|Application type|.NET 6 required (F5)|F5|Ctrl+F5|
|-|-|-|-|
|ASP.NET code behind|No|16.11|17.0 Preview 2|
|ASP.NET Razor (Blazor Server and ASP.NET Core|Yes|17.0 Preview 4|17.0 Preview 2|
|ASP.NET Razor (Blazor WASM)|Yes|No|17.0 Preview 3|
|XAML WPF|No|16.11|17.0 Preview 2|
|XAML WinUI3|No|16.11|No|
|WinForms|No|16,11|17.0 Preview 2|
|Console|No|16.11|17.0 Preview 2|
|XAML .NET MAUI WinUI|Yes|16.11|No|
|XAML .NET MAUI Android|Yes|TBD|No|
|XAML .NET MAUI iOS|Yes|TBD|No|
|XAML + Blazor .NET MAUI WinUI|Yes|TBD|No|
|XAML + Blazor .NET MAUI Android|Yes|TBD|No|
|XAML + Blazor .NET MAUI iOS|Yes|TBD|No|

The types of edits you can make with hot reload are determined by the runtime, not by the method you used to start the application (F5 or Ctrl+F5).

#### Support for C++ apps

When using Visual Studio 2022 and starting your app with the debugger, it is now possible to Hot Reload a native C++ application when running under the debugger (F5) using the ‘Hot Reload’ button. Hot Reload is also supported for apps built using CMake and OpenFolder projects.

This experience is powered by native Edit and Continue, for supported edits see our [documentation](../debugger/edit-and-continue-visual-cpp.md).

#### Supported .NET App Frameworks & Scenarios

Since we announced Hot Reload back in May 2021 a very common question from .NET developers has been “will Hot Reload work with my .NET apps framework/version combination?”. We’ve made huge progress to make the answer YES in most situations, here are the highlights.

* **When using Visual Studio 2022 and starting your app with the debugger** the basic Hot Reload experience works with most types of .NET apps and framework versions, this includes .NET Framework, .NET Core and .NET 5+ (for both C# and VB.NET as applicable). The type of apps that are supported include web (code-behind changes), desktop, mobile, cloud and other project types. The key rule here is if you’re using the debugger assume Hot Reload is available to you and give it a try!
* **When using Visual Studio 2022 but not using the debugger** (for example using CTRL-F5 to start the app) Hot Reload is now available even without the debugger when targeting most types of .NET 6 apps. This means that apps not targeting .NET 6 (.NET 5 or below) will not support the “no debugger” scenario and must use the debugger to get Hot Reload support.
* **When using Visual Studio 2022 with a .NET 6 app, the most type of scenarios are supported.** This is not limited to the new “no debugger” feature mention above. It also includes other new capabilities such as support for Hot Reloading Blazor projects and more generally editing Razor files in any ASP.NET Core apps and CSS Hot Reload. Using both Visual Studio 2022 and apps that target .NET 6 together will definitively give you the most powerful Hot Reload experience and we hope you will give it a try.

Below we’ll expand on the above summary and dive into more details.

#### Visual Studio 2022 with a .NET app when using the debugger

When using Visual Studio 2022 and starting the app with the debugger, Hot Reload works with most app frameworks, including typical app types such as Console, Windows Forms (WinForms), WPF, UWP, WinUI 3* and most types of ASP.NET web projects (for code-behind edits) including ASP.NET MVC, Web API and even older Web Forms projects. This list is also just an example. The real answer is anywhere you have .NET and you’re using the Visual Studio managed debugger, you should get basic Hot Reload support.

This means that even projects such as Azure Functions will work great in this scenario. We encourage you to try your combination and let us know if you find any problems.

*WinUI 3 by default uses mixed mode debugging which does not support Hot Reload. You can modify this in project settings by enabling the Managed Debugger which will enable Hot Reload to work properly.

#### When using Visual Studio 2022 with a .NET app, but not using the debugger

Hot Reload is now available without the debugger when targeting most types of .NET 6 apps, including project types such as Console, WPF, Windows Forms (WinForms), ASP.NET Core MVC, Web API and Blazor. We know some developers have good reason or preference to start their apps without the debugger and we hope this extra feature will give them value for little to no impact on startup time.

This feature is exclusive to .NET 6+ and those apps not targeting .NET 6 (.NET 5 or below) will not support the “no debugger” scenario and must use the debugger to get access to Hot Reload functionality.

Also be aware that not all project types will be supported for the “no debugger” scenario in our first release. Specifically:

* UWP apps are not supported for Hot Reload without the debugger, this is by design and there are no current plans to improve this.
* Xamarin.Forms apps targeting iOS & Android don’t support .NET Hot Reload (regardless of if you are starting your app with or without the debugger), but will continue to support XAML Hot Reload
* .NET MAUI apps in the immediate future will not support the no debugger scenario, but will support .NET Hot Reload through the debugger

#### When using Visual Studio 2022 with a .NET 6 app, the most type of scenarios are supported

Developers who are able to use both Visual Studio 2022 and work on apps that target .NET 6 will get the benefits of the most polished and capable Hot Reload experience.

Highlights of what is supported:

* Blazor apps (Server and WebAssembly*)
* Razor file editing in both Blazor and regular ASP.NET Core websites
* CSS Hot Reload
* Ability to get Hot Reload support when running apps without the debugger (as described above in more detail)

Developers targeting .NET 6 will continue to get more improvements in future Visual Studio 2022 updates and .NET feature band and major releases. We’re just getting started!

*In Visual Studio 2022 GA release Hot Reload support for Blazor WebAssembly when using the Visual Studio debugger isn’t enabled yet. You can still get Hot Reload If you start your app through Visual Studio without the debugger, and we are working to resolve this in a future Visual Studio update.

#### Supported ASP.NET Core Scenarios

The basic Hot Reload experience is now broadly supported for many ASP.NET scenarios. The most widely available feature is the ability to change code-behind and other .NET class files for most types of web applications. This feature works while using the Visual Studio debugger and is present anywhere Edit and Continue was previously available. 

For those ASP.NET Core developers who are targeting .NET 6 there are additional capabilities not available for lower versions of .NET, this includes improvements such as:

* **CSHTML:** Editing a Razor CSHTML file now supports many types of edits.
* **Browser Refresh:** Editing a razor file will now automatically refresh the changes in your web browser when debugging. This was previously only available when starting the app without the debugger.
* **CSS Hot Reload:** It is now possible to change CSS files while the app is running, and changes will be applied immediately to the running app as you type.
* **No Debugger:** You will now get Hot Reload support when using Visual Studio to start your web app without the debugger (CTRL-F5).

Note: When working on a Blazor Wasm app and using Visual Studio 2022 (17.0), Hot Reload for razor pages only works when launching apps without the debugger. We will be adding debugger support in a future update.

#### Supported .NET Edits

The .NET Hot Reload experience is powered by the Edit and Continue mechanism and we’ve made improvements to support additional types of edits that go beyond what was originally possible in previous versions. Improvements include:

* Adding, updating or deleting Custom Attributes
* Adding or updating Record structs
* Adding or updating #line directives
* Editing Switch expressions
* Editing files with #line directives, including changes to the directive itself
* Editing top-level statements
* Editing code that uses any of the new C# 10 features, such as global using directives, file scoped namespaces, improved lambdas and parameter-less struct constructors
* Renaming Lambda parameters
* Renaming parameters of existing methods

The above improvements are available to both Hot Reload and the Edit and Continue experiences.

#### Additional Updates

* **Hot Reload and Edit and Continue with multiple processes:** It is now possible to reliably use both the Hot Reload and Edit and Continue experiences when attached to multiple processes. Previously this capability was not fully supported and did not always work properly, this has now been corrected.
* **Updated error/warning messages:** We’ve updated many error/warning messages to be clearer when the messages applies to both EnC and Hot Reload. We did this by making the messages more generic so that edit and continue terminology is not used during Hot Reload operations
* **Faster Unit Testing of .NET apps:** Hot Reload technology can now be used as an experimental feature to speed up unit testing when targeting .NET 6. For more information see the testing section of these release notes

#### Unsupported .NET Scenarios

Even in the final release there will still be some unsupported scenarios that you should be aware of:

* Xamarin.Forms apps won’t support .NET Hot Reload in iOS and Android scenarios. You will get some Hot Reload when targeting a UWP app. This is by design, and we don’t expect to make any further improvements. (Note: XAML Hot Reload will continues to be available and supported for Xamarin.Forms customers on the latest SDK)
* .NET MAUI apps are not supported in this release, for working with .NET MAUI and Hot Reload please see Visual Studio 2022 Update 1 Preview 1 release notes for details.
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

If you select the **Always rebuild" option in the dialog box, you won't see the dialog box again in the current Visual Studio session, and Visual Studio will automatically rebuild and reload instead of showing the dialog box.

## See also

* [Edit and Continue (Visual C#)](../debugger/edit-and-continue-visual-csharp.md)
