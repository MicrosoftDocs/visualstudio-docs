---
title: "Adapting To Removal of Windows Arm32 .NET Debugging"
description: Provides guidance on how to adapt to the removal of Windows Arm32 .NET Debugging support
ms.date: "12/12/2024"
ms.topic: "error-reference"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Adapting To Removal of Windows Arm32 .NET Debugging

.NET support for Windows on Arm32 has ended. Debugging support for this platform will be removed from Visual Studio 2022 starting with the 17.14 update. This article lists potential options for customers currently debugging .NET Code on  Windows Arm32. 


## Option 1: Run code in an Arm64 process 

If your device runs Arm64 Windows or can be upgraded to it, the easiest way is to migrate the debugged process from Arm32 to Arm64. How to do switch to Arm64 depends on the type of project being used: 

* For Universal Windows Platform (UWP) apps, see [Update app architecture from Arm32 to Arm64](/windows/arm/arm32-to-arm64). 
* For processes that have their own native executable which is self-hosting the .NET Runtime, the native project needs to be configured to target Arm64. 
* If the executable project is a .NET project, then something is likely specifying the `RuntimeIdentifier` MSBuild property. `RuntimeIdentifier` should be updated to target `win-arm64` instead of `win-arm` (or similar runtime IDs). 


## Option 2: Use an older version of Visual Studio 

Visual Studio 17.12 can be used from the Long-Term Servicing Channel (LTSC). For more information, see [Visual Studio Product Lifecycle and Servicing](/visualstudio/productinfo/vs-servicing). 


## Option 3: Start without debugging 

> [!NOTE]
> This option is not recommended since .NET support for Windows on Arm32 has ended.

If you have a project that you still want to run but doesn't require debugging, 'Debug->Start without debugging' can be used to run the project. Since the debugger isn't available, any problem would need to be diagnosed using logging. 


## Option 4: Target Linux 

The .NET Runtime continues to support Arm32 Linux. For IoT hardware which isn't capable of running Arm64 Windows but is capable of running Arm32 Linux, the only supported path for running .NET Code on that hardware would be to switch to Linux.