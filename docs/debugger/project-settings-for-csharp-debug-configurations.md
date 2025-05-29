---
title: "Project Settings for a C# debug config"
description: Understand how to change the project settings for a C# debug configuration in Visual Studio, using the Debug tab and Build tab of the project property pages.
ms.date: "01/13/2022"
ms.topic: "ui-reference"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debug configurations, C#"
  - "project settings [Visual Studio], debug configurations"
  - "debug builds, project settings"
  - "projects [Visual Studio], debug configurations"
  - "project configurations, debug"
  - "debugging [C#], debugger settings"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Project settings for C# debug configurations

You can change C# project debug settings in the [Debug tab](#debug-tab) and [Build tab](#build-tab) of the project property pages.

To open the property pages, select the project in **Solution Explorer** and then select the **Properties** icon, or right-click the project and select **Properties**.

For more information, see [Debug and release configurations](how-to-set-debug-and-release-configurations.md).

::: moniker range=">=vs-2022"
>[!IMPORTANT]
>These settings don't apply to .NET Core, ASP.NET, or UWP apps. To configure debug settings for .NET 5+ and .NET Core, see [Project settings for C# debug configurations (.NET 5+, .NET Core)](../debugger/project-settings-for-csharp-debug-configurations-dotnetcore.md).
::: moniker-end
::: moniker range="<=vs-2019"
>[!IMPORTANT]
>These settings don't apply to .NET Core, ASP.NET, or UWP apps. To configure debug settings for UWP apps, see [Start a debugging session for a UWP app](/windows/uwp/debug-test-perf/deploying-and-debugging-uwp-apps).
::: moniker-end

## Debug tab

|Setting|Description|
|-------------------------------------| - |
| **Configuration** | Sets mode for building the app. Select **Active (Debug)**, **Debug**, **Release**, or **All Configurations** from the dropdown. |
| **Start action** | Specifies the action when you select **Start** in a Debug configuration.<br />- **Start project** is the default, and launches the startup project for debugging. For more information, see [Choose the startup project](/previous-versions/visualstudio/visual-studio-2010/0s590bew(v=vs.100)).<br />- **Start external program** starts and attaches to an app that is not part of a Visual Studio project. For more information, see [Attach to running processes with the debugger](attach-to-running-processes-with-the-visual-studio-debugger.md).<br />- **Start browser with URL** lets you debug a web app. |
| **Start options** > **Command-line arguments** | Specifies command-line arguments for the app being debugged. The command name is the app name specified in **Start external program**. |
| **Start options** > **Working directory** | Specifies the working directory of the app being debugged. In C#, the working directory is *\bin\debug* by default.
| **Start options** > **Use remote machine**|For remote debugging, select this option and enter the name of the remote debugging target, or an [Msvsmon server name](../debugger/remote-debugging.md). <br />The location of an app on the remote machine is specified by the **Output Path** property on the **Build** tab. The location must be a shareable directory on the remote machine.
| **Debugger engine** > **Enable unmanaged code debugging** | Debugs calls to native (unmanaged) Win32 code from the managed app. |
| **Debugger engine** > **Enable SQL Server debugging** | Debugs SQL Server database objects. |

## Build tab

|Setting|Description|
|-------------|-----------------|
|**General** > **Conditional compilation symbols**|Define the DEBUG and TRACE constants if selected.<br /><br /> These constants enable conditional compilation of the [Debug class](/dotnet/api/system.diagnostics.debug) and [Trace class](/dotnet/api/system.diagnostics.trace). With these constants defined, Debug and Trace class methods generate output to the [Output window](../ide/reference/output-window.md). Without these constants, Debug and Trace class methods are not compiled, and no output is generated.<br /><br />Usually, DEBUG is defined in the Debug version of a build and undefined in the Release version. TRACE is defined in both the Debug and Release versions.|
|**General** > **Optimize code**|Unless a bug appears only in optimized code, leave this setting deselected for Debug builds. Optimized code is harder to debug, because instructions do not correspond directly to statements in the source code.|
|**Output** > **Output path**|Typically set to *bin\Debug* for debugging.|
|**Advanced** button|For information on advanced debugging options, see [Advanced build settings dialog box (C#)](../ide/reference/advanced-build-settings-dialog-box-csharp.md). The portable format for symbol (*.pdb*) files is a recent cross-platform format for .NET Core apps.

## See also
- [Debugger settings and preparation](../debugger/debugger-settings-and-preparation.md)