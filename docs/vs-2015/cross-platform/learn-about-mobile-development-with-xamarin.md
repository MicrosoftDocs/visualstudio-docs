---
title: "Learn about mobile development with Xamarin | Microsoft Docs"
ms.date: 11/15/2016
ms.topic: conceptual
ms.assetid: e970d936-1df4-4c0c-96e3-ef6191295882
caps.latest.revision: 14
ms.author: crdun
manager: "crdun"
---
# Learn about mobile development with Xamarin
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic directs you to overview material that helps you understand developing cross-platform mobile apps with Xamarin. If you have not yet installed Visual Studio and Xamarin, start the [Setup and install](../cross-platform/setup-and-install.md) process first, then return here to work through these resources while the installers are running.  
  
> [!NOTE]
> Unless otherwise noted, we suggest initially reading only those pages linked to directly here, and not subsidiary pages. If the installation process is still running after completing this list, feel free to go back and explore additional topics.  
>   
> Also feel free to review the topics marked "Essentials" and come back to the "Deeper Dive" topics later.  
  
## Essentials: Introduction to Xamarin  
 *10-20 minutes*  
  
1. [Mobile Apps in Visual Studio with Xamarin](https://www.visualstudio.com/explore/xamarin-vs) (visualstudio.com) provides a very short rundown of the primary characteristics of Xamarin.  
  
2. [Building Cross-Platform Mobile Apps using C# and Visual Studio](https://channel9.msdn.com/Events/Visual-Studio/Visual-Studio-2015-Final-Release-Event/Building-cross-platform-mobile-apps-using-C-and-Visual-Studio-2015) (Channel9, 15m16s) with Xamarin evangelist, James Montemagno. The first three minutes are a Xamarin overview, followed by code demonstrations.  
  
## Essentials: Overview of the Visual Studio and Xamarin Environment  
 *5-15 minutes*  
  
- The Windows computer with Visual Studio and Xamarin is where you’ll do most of your work. On this computer you directly build Windows and Android apps and run and debug them on a device or an emulator. You also remotely build, run, and debug iOS apps via the Mac. Visual Studio on the Windows computer can also connect to the iOS storyboard designer and the iOS simulator.  
  
- The Mac with Xcode and Xamarin serves as the build/signing host and runtime environment for iOS apps. Builds for iOS from Visual Studio on the Windows computer are delegated to this Mac; when debugging an iOS app from Visual Studio, it runs in the iOS simulator on the Mac or directly on a tethered device connected to the Mac. In this case you’ll interact with the app on or near the Mac, and have your debugging experience in Visual Studio.  
  
  These relationships are illustrated below, and you can read more about working with iOS apps on [Introduction to Xamarin.iOS for Visual Studio](https://docs.microsoft.com/xamarin/ios/get-started/installation/windows/introduction-to-xamarin-ios-for-visual-studio) (xamarin.com).  
  
  ![The relationship between Windows and Mac dev computers in a Xamarin environment](../cross-platform/media/crossplat-xamarin-learn-1.png "CrossPlat Xamarin Learn 1")  
  
## Essentials: How projects are structured  
 *10-30 minutes*  
  
1. [Sharing Code Options](https://docs.microsoft.com/xamarin/cross-platform/app-fundamentals/code-sharing) (xamarin.com). We recommend using the portable class libraries option, as it best supports using only those .NET APIs that are supported across all target platforms. Most business logic code will reside in the PCL, including access to databases, calls to REST APIs, and calls to portable Xamarin components (see [Deeper Dive: Xamarin Components](#components) at the end of this topic). Common UI code written with Xamarin.Forms can also reside in a PCL.  
  
2. (Optional) [Case Study: Tasky](https://docs.microsoft.com/xamarin/cross-platform/app-fundamentals/building-cross-platform-applications/case-study-tasky) (xamarin.com), describes some best practices for design and structure of a full-featured app such as structuring the project with a PCL for shared code that separates data, data access, and business layers, .  
  
## Essentials: native and Xamarin.Forms UI layers  
 *10-40 minutes*  
  
 Xamarin provides two ways to build great native apps: Xamarin Native and Xamarin.Forms.  
  
 With Xamarin Native you write separate UI code for each target platform: iOS, Android, and Windows.  With this approach you have direct access to platform-specific APIs allowing a customized UI experience per platform.  You also have full access to the native designer and controls for each platform to help with building the respective UI.  
  
 Xamarin.Forms provides a generalized set of APIs that lets you write a shared UI layer for all platforms in a portable class library.  Xamarin.Forms  renders to native controls on each target platform to give a native look and feel.  Rather than using a designer, with Xamarin.Forms, you build your UI using C# and XAML.  
  
 You don’t need to decide which approach to take up front; apps can be implemented using a combination of both Xamarin Native and Xamarin.Forms:  
  
- Use Xamarin.Forms to build general-purpose screens that provide similar UI and capabilities across platforms, such as logins, contact forms, and search results.  
  
- Use a variety of customization capabilities in Xamarin.Forms to adjust UI on a per-platform basis. These include the OnPlatform API that can be used from both code and XAML, creating a custom view, extending an existing renderer, and creating a custom renderer.  
  
- If necessary, use Xamarin Native to build screens that  use unique UI features of each platform, for example, a screen that uses native camera capture and image manipulation.  
  
  We recommend always starting with a Xamarin.Forms solution to set up UI code sharing across platforms, and using the customization capabilities to make platform-specific adjustments. If and when you need wholly platform-specific screens, you can add those individually using Xamarin Native.  
  
  To learn more:  
  
1. [Xamarin.Forms](https://docs.microsoft.com/xamarin/xamarin-forms/) (xamarin.com) provides a brief overview and the pros and cons of Xamarin.Forms vs. native UI layers (that is, Xamarin.iOS and Xamarin.Android).  
  
2. The first three minutes of James Montemagno’s video [Xamarin.Forms: Native iOS, Android & Windows apps with C# & XAML](https://channel9.msdn.com/events/Visual-Studio/Connect-event-2015/704) (Channel9, 13m3s) gives another overview, and you can continue watching for demos.  
  
3. (Optional) [An Introduction to Xamarin.Forms](https://docs.microsoft.com/xamarin/get-started/quickstarts/deepdive?pivots=windows) (xamarin.com)  
  
4. (Optional) See examples of using OnPlatform for customization in the [Device Class](https://docs.microsoft.com/xamarin/xamarin-forms/platform/device) documentation (xamarin.com)  
  
5. (Optional) [Cross-Platform - Share UI Code Across Mobile Platforms with Xamarin.Forms](https://msdn.microsoft.com/magazine/dn904669.aspx) by Jason Smith (MSDN Magazine) outlines the different customization options within Xamarin.Forms, for which the details are covered on [Customizing Controls on Each Platform](https://docs.microsoft.com/xamarin/xamarin-forms/app-fundamentals/custom-renderer/) (xamarin.com).  
  
## Deeper Dive: Debugging with Emulators  
 *10-15 minutes*  
  
 To debug your cross-platform apps without having to use a physical device, you will need to use the following:  
  
1. **An Android emulator.** Depending on which version of Windows you are using, we recommend either Microsoft’s Visual Studio Emulator for Android or the Xamarin Player, both of which offer fast performance and support a variety of device capabilities:  
  
    - **Windows 8+ machines:** We highly recommend using Microsoft’s [Visual Studio Emulator for Android](https://www.visualstudio.com/features/msft-android-emulator-vs.aspx), which is installed with Visual Studio.  The [Visual Studio Emulator for Android](https://channel9.msdn.com/events/Visual-Studio/Connect-event-2015/711) video (Channel9, 5m55s) gives an overview and demonstration.  
  
    - **Windows 7 or earlier/Windows running on Mac OS X**: use the [Xamarin Android Player](https://docs.microsoft.com/xamarin/android/deploy-test/debugging/debug-on-emulator?tabs=windows) (xamarin.com).  
  
2. **Apple’s iOS Simulator.** To learn more, read [Getting Started with the iOS Simulator](https://developer.apple.com/library/prerelease/content/documentation/IDEs/Conceptual/iOS_Simulator_Guide/GettingStartedwithiOSSimulator/GettingStartedwithiOSSimulator.html#//apple_ref/doc/uid/TP40012848-CH5-SW1) (apple.com).  
  
3. **Microsoft’s Windows Phone Emulator.** To learn more, read [Windows Phone Emulator for Windows Phone 8](https://msdn.microsoft.com/library/dn632391.aspx).  
  
## <a name="components"></a> Deeper Dive: Xamarin Components  
 *10 minutes*  
  
 Many extended capabilities are available to Xamarin apps through Xamarin components. You can find the full catalog available for download on [http://components.xamarin.com/](https://docs.microsoft.com/xamarin/cross-platform/troubleshooting/component-nuget?tabs=windows), which includes components for additional UI controls, authentication, a variety of cloud services such as Microsoft Azure, and much more.
