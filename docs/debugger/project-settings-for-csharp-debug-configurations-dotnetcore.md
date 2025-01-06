---
title: "Project Settings for a .NET C# debug config"
description: Understand how to change the project settings for a C# .NET 5+ or .NET Core debug configuration in Visual Studio, using the Debug tab and Build tab of the project property pages.
ms.date: "07/15/2022"
ms.topic: "ui-reference"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debug configurations, C# .NET Core"
  - "project settings [Visual Studio], debug configurations"
  - "debug builds, project settings"
  - "projects [Visual Studio], debug configurations"
  - "project configurations, debug"
  - "debugging [C#], debugger settings"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
monikerRange: '>= vs-2022'
---
# Project settings for C# debug configurations (.NET Core, .NET 5+, and ASP.NET Core)

You can change C# project debug settings in the [Debug tab](#debug-tab) and [Build tab](#build-tab) of the project property pages.

To open the property pages, select the project in **Solution Explorer** and then select the **Properties** icon, or right-click the project and select **Properties**.

For more information, see [Debug and release configurations](how-to-set-debug-and-release-configurations.md).

>[!IMPORTANT]
>These settings don't apply to .NET Framework or UWP apps. To configure debug settings for .NET Framework, see [Project settings for C# debug configurations](../debugger/project-settings-for-csharp-debug-configurations.md).

## Debug tab

Starting in Visual Studio 2022, choose **Open debug launch profiles UI** in the Debug tab to open the launch profiles UI and change debug settings.

## Launch profile (.NET Core, .NET 5+)

|Setting|Description|
|-------------------------------------| - |
|**Command-line arguments** | Specifies command-line arguments for the app being debugged. The command name is the app name specified in **Start external program**. |
|**Working directory** | Specifies the working directory of the app being debugged. In C#, the working directory is *\bin\debug* by default. |
|**Use remote machine**|For remote debugging, select this option and enter the name of the remote debugging target, or an [Msvsmon server name](../debugger/remote-debugging.md). <br />The location of an app on the remote machine is specified by the **Output Path** property on the **Build** tab. The location must be a shareable directory on the remote machine. |
|**Environment variables**|Sets environment variables prior to running the application process. For ASP.NET Core, see [Environments](/aspnet/core/fundamentals/environments#environments-1).|
|**Enable unmanaged code debugging** | Debugs calls to native (unmanaged) Win32 code from the managed app. |
|**Enable SQL Server debugging** | Debugs SQL Server database objects. |
|**Enable WebView2 debugging**| Debugs JavaScript with Microsoft Edge (Chromium) based debugger.|

## Launch profile (ASP.NET Core)

In addition to the properties for .NET 5+, ASP.NET Core launch profiles include several additional properties for the different ASP.NET Core profiles. These settings provide a simple UI for the project's `launchSettings.json` file. For more information on this file, see the Development and `launchSettings.json` section in [Use multiple environments in ASP.NET Core](/aspnet/core/fundamentals/environments).

The settings provided in the launch profiles UI include the following.

|Setting|Description|
|-------------------------------------| - |
|**Launch browser**|Select whether to launch the default browser when you start debugging, using the URL you set in the **Url** setting.|
|**Url**|Specifies the location of host URL for .NET or .NET Core. For a profile named after the project (that is, the commandName property in `launchSettings.json` is *Project*), the Kestrel server listens to the port specified. For an IIS profile, this is typically the same value as the **App URL**. For more information, see the IIS launch profile section under [Configure the project](/aspnet/core/host-and-deploy/iis/development-time-iis-support#configure-the-project).|
|**App URL**|Specifies the application URL(s). For a profile named after the project, this property specifies the Kestrel server URLs, typically `https://localhost:5001` and `http://localhost:5000`. |

Visual Studio provides an IIS Express profile by default, and you can create additional profiles such as an IIS profile. These settings also correspond to settings in *launchSettings.json*. These two profile types provide several settings, such as the Hosting model.

|Setting|Description|
|-------------------------------------| - |
|**Hosting model**|Specify In Process (default) or Out of Process. For more information, see [Hosting models](/aspnet/core/host-and-deploy/aspnet-core-module#hosting-models) in the ASP.NET Core docs.|
|**App SSL URL**|For IIS Express, the **App SSL URL** is typically `http://localhost:44334.`|

## Build tab

The following table shows build settings that are useful for debugging. For a complete explanation of build settings, see [Build Page, Project Designer](../ide/reference/build-page-project-designer-csharp.md).

|Setting|Description|
|-------------|-----------------|
|**General** > **Conditional compilation symbols**|Define the DEBUG and TRACE constants if selected.<br /><br /> These constants enable conditional compilation of the [Debug class](/dotnet/api/system.diagnostics.debug) and [Trace class](/dotnet/api/system.diagnostics.trace). With these constants defined, Debug and Trace class methods generate output to the [Output window](../ide/reference/output-window.md). Without these constants, Debug and Trace class methods are not compiled, and no output is generated.<br /><br />Usually, DEBUG is defined in the Debug version of a build and undefined in the Release version. TRACE is defined in both the Debug and Release versions.|
|**General** > **Optimize code**|Unless a bug appears only in optimized code, leave this setting deselected for Debug builds. Optimized code is harder to debug, because instructions do not correspond directly to statements in the source code.|
|**Debug symbols**|Specifies the type of debugging information generated by the compiler. See [Debug symbols](#debug-symbols). For information on how to configure the debug performance of an application, see [Making an Image Easier to Debug](/dotnet/framework/debug-trace-profile/making-an-image-easier-to-debug).|
|**Output** > **Base output path**|Specifies base folder for intermediate output. Output typically goes to *bin\Debug* for a Debug build.|
|**Output** > **Base intermediate output path**|Specifies base folder for intermediate output. Output typically goes to *obj\Debug* for a Debug build.|

## Debug symbols

You can choose the following options for debug symbols.

- **No symbols are emitted**

   Specifies that no debugging information will be generated.

- **PDB file, current platform**

   Produces a .PDB file, a platform-specific symbol file that provides other tools, especially debuggers, information about what is in the main executable file and how it was produced.

- **PDB file, portable**

   Produces a .PDB file, a non-platform-specific, portable symbol file that provides other tools, especially debuggers, information about what is in the main executable file and how it was produced. See [Portable PDB](https://github.com/dotnet/designs/blob/main/accepted/2020/diagnostics/portable-pdb.md) for more information.

- **Embedded in DLL/EXE, portable across platforms**

   Embeds portable symbol information into the assembly. No external .PDB file is produced.

For more information, see [/debug (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/debug-compiler-option).

## See also

- [Debugger settings and preparation](../debugger/debugger-settings-and-preparation.md)
