---
title: "Learn about mobile development with Xamarin | Microsoft Docs"
ms.custom: ""
ms.date: "03/30/2018"
ms.topic: "conceptual"
ms.assetid: e970d936-1df4-4c0c-96e3-ef6191295882
ms.prod: xamarin
ms.technology: xamarin-tools
author: conceptdev
ms.author: crdun
manager: crdun
ms.workload:
  - "xamarin"
---

# Learn about mobile development with Xamarin

This article lists several overviews that can help you understand developing cross-platform mobile apps with Xamarin. If you have not yet installed Visual Studio and Xamarin, start the [Setup and install](../cross-platform/setup-and-install.md) process first, then return here to work through these resources while the installers are running.  
  
> [!NOTE]
> Unless otherwise noted, initially you might want to read only those pages linked directly from here, and not subsidiary pages. If the installation process is still running after completing this list, feel free to go back and explore additional topics.  
>   
> Also feel free to review the topics marked "Essentials" and come back to the "Deeper Dive" topics later.  
  
## Essentials: Introduction to Xamarin  

*10-20 minutes*  
  
1.  [Mobile Apps in Visual Studio with Xamarin](https://www.visualstudio.com/xamarin/) (visualstudio.com) provides a short rundown of the primary characteristics of Xamarin.  
  
2.  [Building Cross-Platform Mobile Apps using C# and Visual Studio](https://channel9.msdn.com/Events/Visual-Studio/Visual-Studio-2015-Final-Release-Event/Building-cross-platform-mobile-apps-using-C-and-Visual-Studio-2015) (Channel9, 15m16s) with Xamarin evangelist, James Montemagno. The first three minutes are a Xamarin overview, followed by code demonstrations.  
  
## Essentials: Overview of the Visual Studio and Xamarin Environment  

*5-15 minutes*  
  
-   You'll do most of your work on the Windows computer installed with Visual Studio and Xamarin. On this computer, you directly build Windows and Android apps and run and debug them on the desktop, devices, or emulators. You can also remotely build, run, and debug iOS apps via the Mac. Visual Studio on the Windows computer can also connect to the iOS storyboard designer and the iOS simulator.  
  
-   The Mac with Xcode and Visual Studio for Mac installed serves as the build host, signing host, and runtime environment for iOS apps. The Windows computer delegates iOS builds to this Mac. The application runs on an iOS simulator on the Mac, or directly on a tethered device connected to the Mac. You can interact with the app on the Mac, but conduct the debugging experience in Visual Studio.
  
These relationships are illustrated below.  
  
![The relationship between Windows and Mac dev computers in a Xamarin environment](../cross-platform/media/crossplat-xamarin-learn-1.png "CrossPlat Xamarin Learn 1")  

> [!NOTE]
> The Windows Phone is shown in this diagram for purposes of completeness. When using the Xamarin platform, the recommended code-sharing option is a .NET Standard 2.0 library, which is incompatible with Windows Phone or Windows 10 Mobile devices. 

You can read more about working with iOS apps on [Introduction to Xamarin.iOS for Visual Studio](/xamarin/ios/get-started/installation/windows/introduction-to-xamarin-ios-for-visual-studio/).
  
## Essentials: How projects are structured  

*10-30 minutes*  
  
1.  [Sharing Code Options](/xamarin/cross-platform/app-fundamentals/code-sharing/). For new applications, you should use a .NET Standard library to share code. Most business logic code will reside in the .NET Standard library, including access to databases, calls to REST APIs, and calls to portable Xamarin components. (See [Deeper Dive: Xamarin Components](#components) at the end of this article). Common UI code written with Xamarin.Forms also resides in a .NET Standard library.  
  
2.  (Optional) [Case Study: Tasky](/xamarin/cross-platform/app-fundamentals/building-cross-platform-applications/case-study-tasky/)  describes some best practices for design and structure of a full-featured app, such as structuring the project with shared code that separates data, data access, and business layers.  
  
## Essentials: native and Xamarin.Forms UI layers  

*10-40 minutes*  
  
Xamarin provides two ways to build great apps: Xamarin Native and Xamarin.Forms.  
  
With Xamarin Native, you write separate UI code for each target platform: iOS, Android, and Windows.  With this approach, you have direct access to platform-specific APIs to design a customized UI experience per platform.  You also have full access to the native designer and controls for each platform to help with building the respective UI.  
  
Xamarin.Forms provides a generalized set of APIs that lets you write a shared UI layer for all platforms in a .NET Standard library.  Xamarin.Forms renders to native controls on each target platform to provide a native look and feel.  Rather than using a designer, you build your UI using C# and XAML.  

Most developers use Xamarin.Forms. This is the recommended route for developers new to Xamarin. The Xamarin Native approach is more difficult and requires more detailed knowledge of the target platforms.
  
You don't need to decide which approach to take up front; apps can be implemented using a combination of both Xamarin Native and Xamarin.Forms:  
  
-   Use Xamarin.Forms to build general-purpose screens. These provide similar user interfaces and capabilities across platforms, such as logins, contact forms, and search results.  
  
-   Use a variety of customization capabilities in Xamarin.Forms to adjust the UI on a per-platform basis. The simplest customization option involves the `OnPlatform` API. You can also create custom views, extend existing renderers, and create custom renderers.  
  
-   If necessary, use Xamarin Native to build screens that use unique UI features of each platform. One example is a screen that uses native camera capture and image manipulation.  
  
You should generally start with a Xamarin.Forms solution to set up UI code sharing across platforms. Use the customization capabilities to then make platform-specific adjustments. If and when you need wholly platform-specific screens, you can add those individually using Xamarin Native.  
  
To learn more:  
  
1.  [Xamarin.Forms](/xamarin/xamarin-forms/) provides a brief overview and the pros and cons of Xamarin.Forms vs. native UI layers (that is, Xamarin.iOS and Xamarin.Android).  
  
2.  The first three minutes of James Montemagno's video [Xamarin.Forms: Native iOS, Android & Windows apps with C# & XAML](https://channel9.msdn.com/events/Visual-Studio/Connect-event-2015/704) (Channel9, 13m3s) gives another overview, and you can continue watching for demos.  
  
3.  (Optional) [An Introduction to Xamarin.Forms](/xamarin/xamarin-forms/get-started/introduction-to-xamarin-forms/)  
  
4.  (Optional) See examples of using `OnPlatform` for customization in the [Device Class](/xamarin/xamarin-forms/platform/device/) documentation
  
5.  (Optional) [Cross-Platform - Share UI Code Across Mobile Platforms with Xamarin.Forms](https://msdn.microsoft.com/magazine/dn904669.aspx) by Jason Smith (MSDN Magazine) outlines the different customization options within Xamarin.Forms, for which the details are covered on [Custom Renderers](/xamarin/xamarin-forms/app-fundamentals/custom-renderer/).  
  
## Deeper Dive: Debugging with Emulators  

*10-15 minutes*  
  
To debug your cross-platform apps without having to use a physical device, you will need to use emulators discussed here:  
  
### Microsoft's Android emulator 

It is recommended that you use Microsoft's [Visual Studio Emulator for Android](visual-studio-emulator-for-android.md), which is installed with Visual Studio.  The [Visual Studio Emulator for Android](https://channel9.msdn.com/events/Visual-Studio/Connect-event-2015/711) video (Channel9, 5m55s) gives an overview and demonstration.  
  
### Apple's iOS Simulator

To learn more, read [Getting Started with the iOS Simulator](https://developer.apple.com/library/prerelease/content/documentation/IDEs/Conceptual/iOS_Simulator_Guide/GettingStartedwithiOSSimulator/GettingStartedwithiOSSimulator.html#//apple_ref/doc/uid/TP40012848-CH5-SW1) (apple.com).  
  
### Microsoft's Windows Phone Emulator.

To learn more, read [Test with the Microsoft Emulator for Windows 10 Mobile](/windows-uwp/windows-apps-src/debug-test-perf/test-with-the-emulator/).  
  
<a name="components" /> 

## Deeper Dive: Xamarin Components  

*10 minutes*  
  
Many extended capabilities are available to Xamarin apps through Xamarin components. You can find the full catalog available for download on [http://components.xamarin.com/](http://components.xamarin.com/), which includes components for additional UI controls, authentication, a variety of cloud services such as Microsoft Azure, and much more.