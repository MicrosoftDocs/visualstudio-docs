---
title: "Develop apps for the Universal Windows Platform (UWP) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "tgt-pltfrm-cross-plat"
ms.topic: conceptual
ms.assetid: eac59cb6-f12e-4a77-9953-6d62b164a643
caps.latest.revision: 50
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# Develop apps for the Universal Windows Platform (UWP)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

With the Universal Windows Platform and our one Windows core, you can run the same app on any Windows 10 device from phones to desktops. Create these Universal Windows apps with Visual Studio 2015 and the Universal Windows App Development tools.

 ![Universal Windows Platform](../cross-platform/media/uwp-coreextensions.png "UWP_CoreExtensions")

 Run your app on a Windows 10 phone, a Windows 10 desktop, or an Xbox. It’s the same app package! With the introduction of the Windows 10 single, unified core, one app package can run across all platforms. Several platforms have Extension SDKs that you can add to your app to take advantage of platform specific behaviors. For example, an extension SDK for mobile handles the back button being pressed on a Windows phone. If you reference an Extension SDK in your project, then just add runtime checks to test if that SDK is available on that platform. That’s how you can have the same app package for each platform!

 **What is the Windows Core?**

 For the first time, Windows has been refactored to have a common core across all Windows 10 platforms. There is one common source, one common Windows kernel, one file I/O stack, and one app model. For the UI, there is just one XAML UI framework and one HTML UI framework. So you can concentrate on creating a great app, because we’ve made it easy to have your app run on different Windows 10 devices.

 **What exactly is the Universal Windows Platform?**

 It’s simply a collection of contracts and versions. These allow you to target where your app can run. You no longer target an operating system. Now you target your app to one or more device families. Learn more details from this [platform guide](https://msdn.microsoft.com/library/windows/apps/dn894631.aspx).

## Requirements
 The Universal Windows App Development tools come with emulators that you can use to see how your app looks on different devices. If you want to use these emulators, you need to install this software on a physical machine. The physical machine must run Windows 8.1 (x64) Professional edition or higher, and have a processor that supports Client Hyper-V and Second Level Address Translation (SLAT). The emulators cannot be used when Visual Studio is installed on a virtual machine.

 Here is the list of software that you need:

- [Windows 10](https://windows.microsoft.com/windows/downloads)

- [Visual Studio 2015](https://go.microsoft.com/fwlink/p/?LinkId=526725). Make sure that the Universal Windows App Development Tools are selected from the optional features list. Without these tools, you won't be able to create your universal apps.

  After installing this software, you need to [enable your Windows 10 device](https://msdn.microsoft.com/library/windows/apps/xaml/dn706236.aspx) for development. (You no longer need a developer license for each Windows 10 device.)

  **Windows 8.1 and Windows 7 support**

  If you choose to develop Universal Windows apps with Visual Studio 2015 on a platform other than Windows 10, these are the restrictions:

- Windows 8.1: You can’t run the app locally (only on a remote Windows 10 device). You can use the emulators in Visual Studio, but not the simulator.

- Windows 7: You can’t run the app locally (only on a remote Windows 10 device). You can’t use the emulators or the simulator in Visual Studio either.

  You can only use the XAML designer if your development platform is Windows 10.

## Universal Windows apps
 Choose your preferred development language from C#, Visual Basic, C++ or JavaScript to [create a Universal Windows app for Windows 10 devices](https://msdn.microsoft.com/library/windows/apps/xaml/dn609832.aspx#target_win10). Or, watch [this getting started video](https://channel9.msdn.com/Series/ConnectOn-Demand/229).

 If you have existing Windows Store 8.1 apps, Windows Phone 8.1 apps, or Universal Windows apps created with Visual Studio 2015 RC, [port these existing apps](https://msdn.microsoft.com/library/windows/apps/xaml/mt238321.aspx) to use the latest Universal Windows Platform.

 After you create your Universal Windows app, you must [package your app](https://msdn.microsoft.com/library/windows/apps/hh454036.aspx) to install it on a Windows 10 device or submit it to the Windows Store.
