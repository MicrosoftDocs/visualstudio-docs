---
title: "Debug an Installed App Package | Microsoft Docs"
ms.custom: ""
ms.date: "12/09/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.debug.installedapppackagelauncher"
dev_langs: 
  - "C++"
  - "CSharp"
  - "FSharp"
  - "JScript"
  - "VB"
helpviewer_keywords: 
  - "app package, debug"
ms.assetid: 5a94ad64-100d-43ca-9779-16cb5af86f97
caps.latest.revision: 1
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Debug an Installed App Package

You can debug any installed app package by selecting **Debug**, **Other Debug Targets**, and then **Debug Installed App Package**. This debugging method is available for these app types:

* Windows Universal (UWP)
* OnceCore
* HoloLens
* IoT

## Debug an Installed App Package on a Local Machine or Device

1. Select **Debug**, **Other Debug Targets**, and then **Debug Installed App Package**.

2. Select either **Local Machine** or **Device**.

     If you choose **Device**, your computer must be connected to a device that can run the app.

     ![DebugInstalledAppPackage](../debugger/media/debug-installed-app-pkg.png "DebugInstalledAppPackage")

     Currently running installed app packages show up under the **Running** node. Installed app packages that aren't running show up under **Not Running**.

2. Select the name of the app you want to debug and choose **Start**.

     If you select **Do not launch, but debug my code when it starts**, this will cause the Visual Studio debugger to attach to your app when you launch it at a custom time. This is an effective way to debug control paths from [different launch methods](https://msdn.microsoft.com/en-us/windows/uwp/xbox-apps/automate-launching-uwp-apps), such as protocol activation with custom parameters.

     When you debug an installed app package on a connected device for the first time, Visual Studio installs the correct version of the remote tools for your target device. Your target device must be a Windows 10 computer, OneCore, HoloLens, or IoT device.

> [!NOTE]
> Visual Studio can also attach to any running UWP app process by selecting **Debug**, and then **Attach to Process**. Attaching to a running process doesn’t require the original Visual Studio project, but loading the process's symbols will help significantly when debugging a process that you don't have the original code for.
  
## Debug an Installed App Package on a Remote Computer 

When you debug an installed app package on a remote computer for the first time, Visual Studio installs the correct version of the remote tools for your target device. Your target device must be a Windows 10 computer, OneCore, HoloLens, or IoT device.

1. Select **Debug**, **Other Debug Targets**, and then **Debug Installed App Package**.

2. From the first drop-down list, choose **Remote Machine**.

3. Type in the name of the computer you want to attach to.

     ![ChooseRemoteComputer](../debugger/media/debug-remote-app-pkg.png "ChooseRemoteComputer")

     If you can't attach using computer name (after you choose **Start**), use the IP address instead.

4. Choose how to authenticate by selecting an option in **Authentication Mode**.

5. Select the name of the app you want to debug and choose **Start**.

     If you select **Do not launch, but debug my code when it starts**, this will cause the Visual Studio debugger to attach to your app package when you launch it at a custom time. This is an effective way to debug control paths from [different launch methods](https://msdn.microsoft.com/en-us/windows/uwp/xbox-apps/automate-launching-uwp-apps), such as protocol activation with custom parameters.

> [!NOTE]
> UWP apps can be developed and compiled on Windows 8.1 or later, but require Windows 10 to run. If you are developing a UWP app on a Windows 8.1 PC, you can remotely debug a UWP app running on another Windows 10 device, provided that both the host and target computer are on the same LAN. To do this, download and install the Remote Tools for Visual Studio on both machines. The installed version must match the existing version of Visual Studio that you have installed, and the architecture you select (x86, x64) must also match that of your target app.
  
## See Also  
 [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md)
 [Configure the Windows Firewall for Remote Debugging](../debugger/configure-the-windows-firewall-for-remote-debugging.md)
 [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md)
 [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)