---
title: "How to: Use Graphics Diagnostics with an ARM Device | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 346fd3c0-9e92-4ab8-bb3b-1aa9000a2483
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Use Graphics Diagnostics with an ARM Device
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Graphics Diagnostics supports remote debugging of Direct3D apps on ARM-based devices that run Windows RT 8.1 or Windows Phone 8.1. You can capture graphics information from your Direct3D app while it runs on the device, or use the device as the playback machine for previously captured graphics information.  
  
## Using Graphics Diagnostics with an ARM-Based Device  
 Because Visual Studio doesn't run on ARM-based devices, you have to use the remote debugger to analyze an app that runs on them. The remote debugger supports graphics capture and playback so that you can diagnose rendering errors and evaluate graphics performance on these devices just as easily as you can debug your app on them.  
  
 To use graphics diagnostics features, first enable remote debugging on your device.  
  
#### To enable remote debugging on your ARM-based device  
  
1. Install the [ARM Kits Policy](https://msdn.microsoft.com/windows/desktop/dn469188) on your ARM-based device.  
  
2. Install the [Remote Debugging Tools](https://my.visualstudio.com/Downloads?q=remote%20tools%20visual%20studio%202015) on your ARM-based device.  
  
> [!IMPORTANT]
> For Windows Phone 8.1 devices, you might have to register your phone for development. To do so, you must be a registered developer. For more information, see [How to deploy and run an app for Windows Phone 8](https://msdn.microsoft.com/library/windowsphone/develop/ff402565.aspx).  
  
 After you've enabled remote debugging on your device, make it your debug target and start Graphics Diagnostics.  
  
#### To configure and start Graphics Diagnostics on your device  
  
1. On the **Solution Platforms** drop-down list, select **ARM** so that your ARM-based device will be available as a remote debugging target.  
  
2. On the **Debug Target** drop-down list, select your ARM device.  
  
3. On the menu, choose **Debug**, **Graphics**, **Start Diagnostics**. (Keyboard: Alt+F5)  
  
## See Also  
 [Run Windows Store apps on a remote machine](../debugger/run-windows-store-apps-on-a-remote-machine.md)   
 [How to: Change the Graphics Diagnostics Playback Machine](../debugger/how-to-change-the-graphics-diagnostics-playback-machine.md)
