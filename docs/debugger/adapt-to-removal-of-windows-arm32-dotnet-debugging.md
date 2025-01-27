---
title: "Adapt to removal of Windows Arm32 .NET debugging"
description: Provides guidance on how to adapt to the removal of Windows Arm32 .NET Debugging support
ms.date: "12/12/2024"
ms.topic: "error-reference"
f1_keywords:
  - "vs.debug.error.arm32_windows_dotnet_debugging"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Adapt to removal of Windows Arm32 .NET debugging

.NET support for Windows on Arm32 has ended. Debugging support for this platform will be removed from Visual Studio 2022 starting with the 17.14 update. This article lists potential options for customers currently debugging .NET Code on  Windows Arm32. 


## Option 1: Run code in an Arm64 process 

If your device runs Arm64 Windows or can be upgraded to it, the easiest way is to migrate the debugged process from Arm32 to Arm64. How to manage the switch to Arm64 depends on the type of project you're using: 

* For Universal Windows Platform (UWP) apps, see [Update app architecture from Arm32 to Arm64](/windows/arm/arm32-to-arm64). 
* For processes that have their own native executable that's self-hosting the .NET Runtime, the native project needs to be configured to target Arm64. 
* If the executable project is a .NET project, then something is likely specifying the `RuntimeIdentifier` MSBuild property. `RuntimeIdentifier` should be updated to target `win-arm64` instead of `win-arm` (or similar runtime IDs). 


## Option 2: Use an older version of Visual Studio 

Visual Studio 17.12 can be used from the Long-Term Servicing Channel (LTSC). For more information, see [Visual Studio Product Lifecycle and Servicing](/visualstudio/productinfo/vs-servicing). 


## Option 3: Start without debugging 

If you have a project that you still want to run but doesn't require debugging, you could launch it without debugging. Since the debugger isn't available, you would need to diagnose any problems by using logging.

If your project is a Universal Windows Platform (UWP) project, and the target device is running an Arm32 version of Windows, then you need to manually deploy the project to run it. To do so, build your project to an .appx file, copy the appx to your device, use the WinAppDeployCmd.exe tool to install the .appx, and then start the application from the start menu. For more information, see [Install apps with the WinAppDeployCmd.exe tool](/windows/uwp/packaging/install-universal-windows-apps-with-the-winappdeploycmd-tool).

For other types of projects, you can still use **Debug->Start without debugging** to run the project. 

> [!NOTE]
> This option isn't recommended since .NET support for Windows on Arm32 has ended.


## Option 4: Target Linux 

The .NET Runtime continues to support Arm32 Linux. For IoT hardware that isn't capable of running Arm64 Windows but is capable of running Arm32 Linux, the only supported path for running .NET Code on that hardware would be to switch to Linux.