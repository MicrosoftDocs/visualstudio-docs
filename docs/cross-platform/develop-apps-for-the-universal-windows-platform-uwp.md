---
title: "Develop apps for the Universal Windows Platform (UWP) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "tgt-pltfrm-cross-plat"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: eac59cb6-f12e-4a77-9953-6d62b164a643
caps.latest.revision: 48
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
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
# Develop apps for the Universal Windows Platform (UWP)
With the Universal Windows Platform and our one Windows core, you can run the same app on any Windows 10 device from phones to desktops. Create these Universal Windows apps with Visual Studio 2015 and the Universal Windows App Development tools.  
  
 ![Universal Windows Platform](../cross-platform/media/uwp_coreextensions.png "UWP_CoreExtensions")  
  
 Run your app on a Windows 10 phone, a Windows 10 desktop, or an Xbox. It's the same app package! With the introduction of the Windows 10 single, unified core, one app package can run across all platforms. Several platforms have Extension SDKs that you can add to your app to take advantage of platform specific behaviors. For example, an extension SDK for mobile handles the back button being pressed on a Windows phone. If you reference an Extension SDK in your project, then just add runtime checks to test if that SDK is available on that platform. That's how you can have the same app package for each platform!  
  
 **What is the Windows Core?**  
  
 For the first time, Windows has been refactored to have a common core across all Windows 10 platforms. There is one common source, one common Windows kernel, one file I/O stack, and one app model. For the UI, there is just one XAML UI framework and one HTML UI framework. So you can concentrate on creating a great app, because we've made it easy to have your app run on different Windows 10 devices.  
  
 **What exactly is the Universal Windows Platform?**  
  
 It's simply a collection of contracts and versions. These allow you to target where your app can run. You no longer target an operating system. Now you target your app to one or more device families. Learn more details from this [platform guide](https://docs.microsoft.com/windows/uwp/get-started/universal-application-platform-guide).  
  
## Requirements  
 The Universal Windows App Development tools come with emulators that you can use to see how your app looks on different devices. If you want to use these emulators, you need to install this software on a physical machine. The physical machine must run Windows 8.1 (x64) Professional edition or higher, and have a processor that supports Client Hyper-V and Second Level Address Translation (SLAT). The emulators cannot be used when Visual Studio is installed on a virtual machine.  
  
 Here is the list of software that you need:  
  
-   [Windows 10](http://windows.microsoft.com/windows/downloads). Visual Studio 2017 supports UWP development only on Windows 10. For more details, see Visual Studio [Platform Targeting](https://www.visualstudio.com/productinfo/vs2017-compatibility-vs) and [System Requirements](https://www.visualstudio.com/en-us/productinfo/vs2017-system-requirements-vs).   
  
-   [Visual Studio 2017](https://www.visualstudio.com/downloads/). Make sure that the Universal Windows App Development Tools are selected from the optional features list. Without these tools, you won't be able to create your universal apps.  
  
 After installing this software, you need to [enable your Windows 10 device](https://docs.microsoft.com/windows/uwp/get-started/enable-your-device-for-development) for development. (You no longer need a developer license for each Windows 10 device.)  
    
## Universal Windows apps  
 Choose your preferred development language from C#, Visual Basic, C++ or JavaScript to [create a Universal Windows app for Windows 10 devices](https://docs.microsoft.com/windows/uwp/get-started/your-first-app). Or, watch [this getting started video](http://channel9.msdn.com/Series/ConnectOn-Demand/229).  
  
 If you have existing Windows Store 8.1 apps, Windows Phone 8.1 apps, or Universal Windows apps created with Visual Studio 2015, [port these existing apps](https://docs.microsoft.com/windows/uwp/porting/index) to use the latest Universal Windows Platform.  
  
 After you create your Universal Windows app, you must [package your app](https://docs.microsoft.com/windows/uwp/packaging/index) to install it on a Windows 10 device or submit it to the Windows Store.
