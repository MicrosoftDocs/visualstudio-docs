---
title: "Write and debug code by using Hot Reload"
description: "Hot Reload, similar to edit and continue, allows you to make changes to your code while running apps"
ms.date: 11/22/2022
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
# Write and debug running code with Hot Reload in Visual Studio (C#, Visual Basic, C++)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Starting in Visual Studio 2022, the Hot Reload experience in Visual Studio works for both managed .NET and native C++ apps. Regardless of the type of app you’re working on, the intention of Hot Reload is to save you as many app restarts between edits as possible, making you more productive by reducing the time you spend waiting for apps to rebuild, restart, re-navigate to the previous location where you were in the app itself, et al.

We accomplish this by making it possible for you to edit your application's code files and apply the code changes immediately to the running application, also known as *Hot Reload*. Once your changes are applied, re-execute your code again by taking an action in the app itself (or through some sort of timer, etc.) and see the changes immediately; no pausing of the app through breakpoints is required!

## Update running code with Hot Reload

1. Open a project based on a supported application type. For more information on .NET, see [.NET application support](#supported-net-app-frameworks-and-scenarios).

1. Make sure that **Enable native code debugging** is disabled in the debugger settings or the debug launch profile.

1. Start the app with the debugger attached using either **F5** or, if [supported for your application](#supported-net-app-frameworks-and-scenarios), **Ctrl+F5**.

1. Open a C#, C++, or Visual Basic code file with some code that can be re-executed through the running apps user interface (for example, code-behind for a button or a viewmodel’s command) or something that is being triggered at an interval through a timer and change the code.

1. Apply the code changes using the **Hot Reload** button, or press **ALT+F10**.

   ![Screenshot of the Hot Reload button.](../debugger/media/vs-2022/dotnet-hot-reload.gif)

## Supported .NET app frameworks and scenarios

* **When using Visual Studio 2022 and starting your app with the debugger**, the basic Hot Reload experience works with most types of .NET apps and framework versions. This support includes .NET Framework, .NET Core and .NET 5+ (for both C# and Visual Basic as applicable). The type of apps that are supported include web (code-behind changes), desktop, mobile, cloud, and other project types. The expectation in this scenario is that if you’re using the debugger, assume Hot Reload is available to you and give it a try!
* **When using Visual Studio 2022 but not using the debugger** (for example using CTRL-F5 to start the app), Hot Reload is available even when targeting most types of .NET 6 apps. This means that apps not targeting .NET 6 (.NET 5 or below) will not support the "no debugger" scenario and must use the debugger to get Hot Reload support.
* **When using Visual Studio 2022 with a .NET 6 app, the most scenarios are supported.** This is not limited to the new "no debugger" feature mentioned above. It also includes other new capabilities, such as support for hot reloading Blazor projects and, more generally, editing Razor files in any ASP.NET Core apps, and CSS Hot Reload. Using both Visual Studio 2022 and apps that target .NET 6 together will give you the most powerful Hot Reload experience.

The following table shows which application types support .NET Hot Reload with the debugger attached (F5) and without the debugger attached (Ctrl+F5), and whether .NET 6 is required for minimum support (that is, F5). .NET 6 is always required for Ctrl+F5 support. Also shown is the minimum version of Visual Studio that supports the feature.

|Application type|.NET 6 required|F5|Ctrl+F5|
|-|-|-|-|
|ASP.NET code-behind|No|16.11|17.0|
|ASP.NET Razor (Blazor Server and ASP.NET Core)|Yes|17.0|17.0|
|ASP.NET Razor (Blazor WASM)|Yes|17.1|17.0|
|WPF|No|16.11|17.0|
|WinUI3|No|16.11|--|
|WinForms|No|16.11|17.0|
|Console|No|16.11|17.0|
|.NET MAUI (WinUI 3)|Yes|17.1|--|
|.NET MAUI (Android)|Yes|17.1|--|
|.NET MAUI (iOS)|Yes|17.1|--|
|.NET MAUI Blazor Hybrid (WinUI 3)|Yes|17.1|--|
|.NET MAUI Blazor Hybrid (Android)|Yes|17.1|--|
|.NET MAUI Blazor Hybrid (iOS)|Yes|17.1|--|

The types of edits you can make with Hot Reload are determined by the runtime, not by the method you used to start the application (F5 or Ctrl+F5).

In the following sections, we’ll expand on the above summary and dive into more details.

## Support for C++ apps

When using Visual Studio 2022 and starting your app with the debugger, you can hot reload a native C++ application when running under the debugger (F5) using the **Hot Reload** button. Hot Reload is also supported for apps built using CMake and OpenFolder projects.

This experience is powered by native Edit and Continue. For supported edits, see [Edit and Continue](../debugger/edit-and-continue-visual-cpp.md).

## Visual Studio 2022 with a .NET app, when using the debugger

When using Visual Studio 2022 and starting the app with the debugger, Hot Reload works with most app frameworks, including typical app types such as Console, Windows Forms (WinForms), WPF, UWP, WinUI 3 (see note), and most types of ASP.NET web projects (for code-behind edits) including ASP.NET MVC, Web API, and even older Web Forms projects. These are examples. Anywhere you have .NET and you’re using the Visual Studio managed debugger, you should get basic Hot Reload support. This fact means that even projects such as Azure Functions work great in this scenario.

> [!NOTE]
> WinUI 3 by default uses mixed mode debugging, which does not support Hot Reload. You can modify this in project settings by enabling the Managed Debugger, which enables Hot Reload to work properly. To enable this in your project, modify launchSettings.json and add `"nativeDebugging": false` after the `commandName` property.

.NET MAUI apps are supported starting in Visual Studio 2022 version 17.1 Preview 1.

## Visual Studio 2022 with a .NET app, but not using the debugger

Hot Reload is available without the debugger when targeting most types of .NET 6 apps, including project types such as Console, WPF, Windows Forms (WinForms), ASP.NET Core MVC, Web API, and Blazor.

This feature is exclusive to .NET 6+. Those apps not targeting .NET 6 (.NET 5 or below) will not support the "no debugger" scenario and must use the debugger to get access to Hot Reload functionality.

Also, be aware that not all project types currently support the "no debugger" scenario. Specifically:

* UWP apps are not supported for Hot Reload without the debugger. This is by design, and there are no current plans to improve this.
* Xamarin.Forms apps targeting iOS and Android don’t support .NET Hot Reload (regardless of whether you are starting your app with or without the debugger), but will continue to support XAML Hot Reload.
* .NET MAUI apps are supported only with the debugger.

## Visual Studio 2022 with a .NET 6 app

If you use both Visual Studio 2022 and work on apps that target .NET 6, you get the benefits of the most polished and capable Hot Reload experience.

Supported in this scenario:

* Blazor apps (Server and WebAssembly (see note))
* Editing Razor files in both Blazor and regular ASP.NET Core websites
* CSS Hot Reload
* Hot Reload support when running apps without the debugger (as described previously in more detail)

If you target .NET 6, you continue to get improvements in upcoming Visual Studio 2022 updates and .NET feature band and major releases.

> [!NOTE]
> In the first release of Visual Studio 2022 (version 17.0), Hot Reload support for Blazor WebAssembly when using the Visual Studio debugger isn’t currently enabled, but is available starting in 17.1. You can still get Hot Reload if you start your app through Visual Studio without the debugger or by updating to 17.1 release.

## Supported ASP.NET Core Scenarios

The basic Hot Reload experience is supported for many ASP.NET scenarios. The most widely available feature is the ability to change code-behind and other .NET class files for most types of web applications. This feature works while using the Visual Studio debugger and is present anywhere Edit and Continue was previously available. For more specific guidance, see [.NET Hot Reload support for ASP.NET Core](/aspnet/core/test/hot-reload).

For ASP.NET Core developers who are targeting .NET 6, there are additional capabilities not available for lower versions of .NET. These capabilities include:

* **CSHTML:** Editing a Razor CSHTML file supports many types of edits.
* **Browser Refresh:** Editing a razor file automatically refreshes the changes in your web browser when debugging. This feature was previously only available when starting the app without the debugger.
* **CSS Hot Reload:** You can change CSS files while the app is running, and changes are applied immediately to the running app as you type.
* **No Debugger:** You get Hot Reload support when using Visual Studio to start your web app without the debugger (CTRL-F5).

## Supported .NET Edits

The .NET Hot Reload experience is powered by the [Edit and Continue](../debugger/edit-and-continue-visual-csharp.md) mechanism. Improvements include support for additional types of edits that go beyond what was originally possible in older versions of Visual Studio. Improvements include:

[!INCLUDE [dotnet-hot-reload-and-edit-continue](../debugger/includes/dotnet-hot-reload-and-edit-continue.md)]

The preceding improvements are available to both Hot Reload and the Edit and Continue experiences.

## Unsupported .NET scenarios

Unsupported scenarios:

* Xamarin.Forms apps won’t support .NET Hot Reload in iOS and Android scenarios. You get partial support for Hot Reload when targeting a UWP app. This is by design, and we don’t expect to make any further improvements. (Note: XAML Hot Reload will continue to be available and supported for Xamarin.Forms customers on the latest SDK.)
* .NET MAUI apps are not supported prior to Visual Studio 2022 version 17.1 Preview 1. Starting in 17.1 Preview 1, .NET MAUI is supported, but only with the debugger attached.
* Apps built using F# or those targeting .NET Native do not support Hot Reload.

If you’re using Visual Studio without the debugger. NET Hot Reload only works for apps targeting .NET 6.

In addition, Hot Reload is not available in some project configurations:

* If you’re using the Visual Studio debugger to run your app, but you’ve disabled `Edit and Continue` in settings, Hot Reload is not supported.
* Release or custom build configurations are not supported. Your project must use the Debug build configuration.
* Some startup or compile optimizations are not supported in .NET Hot Reload. For example, if your project's debug profile is configured in the following ways, .NET Hot Reload is not supported:
  * [Trimming](/dotnet/core/deploying/trimming/trimming-options) is enabled for your project. For example, it's not supported if `PublishTrimmed` is set to True in your project file for the debug profile.
  * [ReadyToRun](/dotnet/core/deploying/ready-to-run) is enabled for your project. For example, it's not supported if `PublishReadyToRun` is set to True in your project file for the debug profile.
* For WinUI 3 apps, native code debugging is enabled by default (even if the setting is absent from *LaunchSettings.json*), and .NET Hot Reload is not supported when doing mixed mode debugging in this way. For this reason, you must add the explicit setting `nativeDebugging: false` to *LaunchSettings.json* in order to get .NET Hot Reload to work correctly.

## Configure Hot Reload

You can configure Hot Reload by selecting **Settings** from the **Hot Reload** drop-down button.

![Screenshot of configuring Hot Reload](../debugger/media/vs-2022/dotnet-hot-reload-configure.png)

Or, open **Tools** > **Options** > **Debugging** > **.NET/C++ Hot Reload**.

The settings for Hot Reload include:

* **Enable Hot Reload and Edit and Continue when debugging**. Enables Hot Reload when starting with the debugger attached (F5).

* **Enable Hot Reload when starting without debugging**. Enables Hot Reload when starting without the debugger attached (Ctrl+F5).

* **Apply Hot Reload on File Save**. Applies code changes when you save the file.

![Screenshot of settings for .NET Hot Reload](../debugger/media/vs-2022/dotnet-hot-reload-settings.png)

You also can control whether .NET Hot Reload is available at the project level by modifying your .NET 6 projects launchSetting.json and setting `hotReloadEnabled` to `false`.

Example:

```xaml
{
  "profiles": {
    "Console": {
      "commandName": "Project",
      "hotReloadEnabled": false
    }
  }
}
```

## Warning message

If you see the following dialog box, Hot Reload is unable to apply the current edits without restarting. You can choose either to rebuild the app and apply changes (restart) or to continue editing. If you rebuild, all application state is lost. If you continue editing, it is possible that additional changes or corrections may cause Hot Reload to work again.

![Screenshot of the apply changes dialog box](../debugger/media/vs-2022/dotnet-hot-reload-apply-changes.png)

If you select the **Always rebuild** option in the dialog box, you won't see the dialog box again in the current Visual Studio session, and Visual Studio will automatically rebuild and reload instead of showing the dialog box.

> [!NOTE]
> In the first release of Visual Studio (version 17.0) the standard Edit and Continue dialog is still shown when using Hot Reload with the debugger. This was a bug and has been resolved starting with 17.1 Preview 2 release.

## Troubleshooting

For ASP.NET Core, if you're using response compression, see the information on [response compression](/dotnet/core/tools/dotnet-watch#description) in `dotnet watch`.

## See also

[Edit and Continue (Visual C#)](../debugger/edit-and-continue-visual-csharp.md)
[Edit and Continue (C++)](../debugger/edit-and-continue-visual-cpp.md)
