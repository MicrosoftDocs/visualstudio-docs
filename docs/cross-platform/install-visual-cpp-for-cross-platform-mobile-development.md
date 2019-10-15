---
title: "Install Visual C++ for Cross-Platform Mobile Development | Microsoft Docs"
ms.custom: ""
ms.date: "05/21/2018"
ms.technology: vs-ide-mobile
ms.topic: "conceptual"
dev_langs:
  - "C++"
ms.assetid: aaea6b8d-55eb-4427-8185-c050f855c257
author: "corob-msft"
ms.author: "corob"
manager: jillfra
ms.workload:
  - "xplat-cplusplus"
---
# Install cross-platform Mobile development with C++

You can use C++ in Visual Studio to build Windows Desktop apps, Universal Windows Platform (UWP) apps, Linux apps, and now, apps for Android and iOS. The **Mobile development with C++** workload is an installable set of components in Visual Studio that includes cross-platform iOS, Android, and UWP Visual Studio templates. It installs the cross-platform tools and SDKs you need to get started quickly, without having to locate, download, and configure them yourself. You can use these tools in Visual Studio to easily create, edit, debug, and test your cross-platform projects. This topic describes how to install the tools and third-party software required to develop cross-platform apps in C++ using Visual Studio. For an overview, see [Visual C++ cross-platform mobile](https://visualstudio.microsoft.com/vs/features/cplusplus-mdd/)

## Requirements

- For installation requirements, see [Visual Studio product family system requirements](/visualstudio/productinfo/vs2017-system-requirements-vs).

   > [!IMPORTANT]
   > If you are using Windows 7 or Windows Server 2008 R2, you can develop code for Windows Desktop applications, Android Native Activity apps and libraries, and apps and code libraries for iOS, but not Windows Phone or UWP apps.

To build apps for specific device platforms, there are some additional requirements:

- Windows Phone emulators and the Microsoft Visual Studio Emulator for Android require a computer that can run Hyper-V. The Hyper-V feature in Windows must be enabled before you can install and run the emulators. For more information, see the emulator's [system requirements](system-requirements-for-the-visual-studio-emulator-for-android.md).

- The x86 Android emulators that come with the Android SDK work best on computers that can run the Intel HAXM driver. This driver requires an Intel x64 processor with VT-x and Execute Disable Bit support. For more information, see [Intel® Hardware Accelerated Execution Manager (Intel® HAXM)](https://go.microsoft.com/fwlink/p/?LinkId=536385).

- Building code for iOS requires an Apple ID, an iOS Developer Program account, and a Mac computer that can run [Xcode](https://go.microsoft.com/fwlink/p/?LinkId=536387) version 6 or later on OS X Mavericks (version 10.9) or later versions. For a link to installation steps, see [Install tools for iOS](#install-tools-for-ios).

## Get the tools

Mobile development with C++ is available in Visual Studio Community, Professional, and Enterprise editions. To get Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/) page. The cross-platform mobile development tools are available starting in Visual Studio 2015.

## Install the tools

The Visual Studio Installer for Visual Studio 2017 includes a **Mobile development with C++** workload that installs the C++ language tools, templates, and components required for Android and iOS development in Visual Studio. It installs the GCC and Clang tool sets needed for Android builds and debugging, and components to communicate with a Mac for iOS development. It also installs all the third-party tools and software development kits that are required to support iOS and Android app development. Most of these third-party tools are open-source software required for Android platform support.

- Android Native Development Kit (NDK) is required to build C++ code that targets the Android platform.

- Android SDK, Apache Ant, and Java SE Development Kit are required for the Android build process.

- The Google Android Emulator and Intel Hardware Accelerated Execution Manager are optional, but recommended, components. You can develop and debug directly on an Android device, but it's often easier to use an emulator on your desktop for debugging. Microsoft also provides a Visual Studio Emulator for Android that can be installed separately.

### Install the Mobile development with C++ workload

1. Run the **Visual Studio Installer** from the **Start** menu.

1. If you've already installed Visual Studio, choose the **Modify** button for the installed version of Visual Studio you'd like to modify. Otherwise, choose **Install** to install Visual Studio.

1. With the **Workloads** tab selected, scroll down and select the **Mobile development with C++** workload in the Visual Studio Installer. When this workload is selected, other required components for C++ development are also selected. You can also choose other workloads and individual components to install at the same time. To build cross-platform code that also targets UWP, select the **Universal Windows Platform development** workload.

1. In the **Installation details** pane, expand **Mobile development with C++**. In the **Optional** section, you can choose additional versions of the NDK, the Google Android Emulator, the Intel Hardware Accelerated Execution Manager, and the IncrediBuild build acceleration tool.

1. By default, one or more Android SDK setup components are included by the workload. Additional versions of the Android SDK are available. To add one to your installation, choose the **Individual components** tab, then scroll down to the **SDKs, libraries, and frameworks** section to make your selection.

1. Choose the **Modify** or **Install** button to install the **Mobile development with C++** workload and your other selected workloads and optional components.

   When installation is complete, close the installer and then restart your computer. Some setup actions for the third-party components do not take effect until the computer is restarted.

   > [!IMPORTANT]
   > You must restart to make sure everything is installed correctly.

1. Open Visual Studio.

> [!NOTE]
> If you're using Visual Studio 2015, see [Install Visual C++ for Cross-Platform Mobile Development (Visual Studio 2015)](install-visual-cpp-for-cross-platform-mobile-development.md?view=vs-2015)

## Install tools for iOS

You can use Visual C++ for Cross-Platform Mobile Development to edit, debug, and deploy iOS code to the iOS Simulator or to an iOS device, but because of licensing restrictions, the code must be built remotely on a Mac. To build and run iOS apps using Visual Studio, you must set up and configure the remote agent on your Mac. For detailed installation instructions, prerequisites and configuration options, see [Install and configure tools to build using iOS](../cross-platform/install-and-configure-tools-to-build-using-ios.md). If you're not building for iOS, you can skip this step.

## Install or update dependencies manually

If you decide not to install one or more third-party dependencies using the Visual Studio installer when you install the **Mobile development with C++** workload (or in Visual Studio 2015, the Visual C++ Mobile Development option), you can install them later by using the steps in [Install the tools](#install-the-tools). The Visual Studio Installer is updated regularly to install the latest third-party components. You can use it to install updated SDKs and NDKs. You can also install or update them independently of Visual Studio.

> [!CAUTION]
> You can install the dependencies in any order, except for Java. You must install and configure the JDK before you install the Android SDK.

Read the following information and use these links to install dependencies manually.

- [Java SE Development Kit](https://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html)

   By default, the installer puts the Java tools in *C:\Program Files (x86)\Java*.

- [Android SDK](https://developer.android.com/sdk/index.html#command-tools)

   During the installation, update the APIs as recommended. Make sure that at least the SDK for Android 5.0 Lollipop (API level 21) is installed. By default, the installer puts the Android SDK in *C:\Program Files (x86)\Android\android-sdk*.

   You can run the SDK Manager app in the Android SDK directory again to update the SDK and install optional tools and additional API levels. Updates may fail to install unless you use **Run as administrator** to run the SDK Manager app. If you have problems building an Android app, check the SDK Manager for updates to your installed SDKs.

   To use some of the Android emulators that come with the Android SDK, you must install the optional Intel HAXM drivers. You may have to remove the Hyper-V feature from Windows to install the Intel HAXM drivers successfully. You must restore the Hyper-V feature to use the Windows Phone emulators and the Microsoft Visual Studio Emulator for Android. For more information, see [Android Emulator hardware acceleration](https://docs.microsoft.com/xamarin/android/get-started/installation/android-emulator/hardware-acceleration?tabs=vswin).

- [Android NDK](https://developer.android.com/tools/sdk/ndk/index.html)

   By default, the installer puts the Android NDK in *C:\ProgramData\Microsoft\AndroidNDK*. You can download and install the Android NDK again to update the NDK installation.

- [Apache Ant](https://ant.apache.org/bindownload.cgi)

   By default, the installer puts Apache Ant in *C:\Program Files (x86)\Microsoft Visual Studio 14.0\Apps*.

- [Microsoft Visual Studio Emulator for Android](https://aka.ms/vscomemudownload)

   Microsoft Visual Studio Emulator for Android is an optional emulator useful for testing and debugging your code. After the release of Visual Studio Emulator for Android, Google updated their Android emulator to use hardware acceleration through Intel’s HAXM. We recommend you use Google’s accelerated emulator when you can, as it offers access to the latest Android OS images and Google Play services.

In most cases, Visual Studio can detect the configurations for the third-party software you've installed, and maintains the installation paths in internal environment variables. You can override the default paths of these cross-platform development tools in the Visual Studio IDE.

#### To set the paths for third-party tools

1. On the Visual Studio menu bar, select **Tools** > **Options**.

1. In the **Options** dialog box, select **Cross Platform** > **C++** > **Android**.

   ![Android tool path options](../cross-platform/media/cppmdd_options_android.PNG "CPPMDD_Options_Android")

1. To change the path used by a tool, check the checkbox next to the path, and edit the folder path in the textbox. You can also use the browse button (**...**) to open a **Select location** dialog to choose the folder.

1. Choose **OK** to save the custom tool folder locations.

## See also

- [Install and configure tools to build using iOS](install-and-configure-tools-to-build-using-ios.md)
- [Visual C++ cross-platform mobile](https://go.microsoft.com/fwlink/p/?LinkId=536383)
