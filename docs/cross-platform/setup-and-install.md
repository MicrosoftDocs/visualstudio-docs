---
title: "Install Xamarin for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "03/30/2018"
ms.topic: "conceptual"
ms.assetid: 2cfcad00-352c-4161-814c-f5ae32d8ada8
ms.technology: vs-ide-mobile
author: charlespetzold
ms.author: chape
manager: crdun
ms.workload:
  - "xamarin"
---

# Setup and install

To build native iOS, Android, and Windows apps from a common C#/.NET code base using Xamarin, you need the following hardware and software:

-   For working with Windows and Android apps: a Windows development computer (not a virtual machine) with Visual Studio 2017 (including Xamarin development features) installed.  

-   For working with iOS apps: a Mac with macOS Sierra 10.12 or above, with Xcode installed, and Visual Studio for Mac installed.

No separate licenses are required to use the Xamarin platform.
 
You can set up the Windows and Mac computers at the same time, and while those installers are running you can go through [Learn about mobile development with Xamarin](../cross-platform/learn-about-mobile-development-with-xamarin.md) to read and watch the necessary background material.

If you have issues using the Xamarin platform after doing this setup and install, post your question on [forums.xamarin.com](http://forums.xamarin.com/).

<a name="prereq" /> 

## Pre-requisites

###  For targeting Windows and Android

See [Visual Studio 2017 Product Family System Requirements](https://www.visualstudio.com/productinfo/vs2017-system-requirements-vs) for detailed pre-requisites for installing Visual Studio 2017.

Install Visual 2017 on a physical Windows computer (not a virtual machine) running Windows 10 with all updates installed. 

### For targeting iOS

To target iOS emulators and devices from your Windows computer, you'll also need a networked Mac or Mac mini running macOS 10.12 or later, and Xcode 8.3. See [Setup and Install Visual Studio for Mac](/visualstudio/mac/installation.md) for more detailed requirements.

<a name="windows" /> 

##  Windows setup (Visual Studio and Xamarin)

If you haven't yet installed Visual Studio 2017, do the following steps:

1.  [Download and launch the installer for any edition of Visual Studio 2017](https://www.visualstudio.com/downloads/) (Community, Professional, or Enterprise). Visual Studio 2017 Community is the free edition. The Professional and Enterprise editions are available on a trial basis for 30 days after which a license is necessary.

2.  When the **Installing** dialog appears, check the following boxes:    

    - **Mobile & Gaming > Mobile Development with .NET**. This option will also automatically select various Android tools and Software Development Kits. 

        ![Select the Mobile Development option under Gaming and Mobile Development](../cross-platform/media/cross-plat-xamarin-setup-2a.png "Cross-Plat Xamarin Setup 2")

    - (Optional) **Windows > Universal Windows Platform development**. 

If you already have Visual Studio 2017 installed but haven't yet installed the Xamarin platform, do the following steps:

1. Run the **Visual Studio Installer** from the **Start** menu.

2.  Within the installer, click the **More** button, and then choose **Modify**:

    ![Choosing the Modify option in Visual Studio installation](../cross-platform/media/cross-plat-xamarin-setup-1a.png "Cross-Plat Xamarin Setup 1")

3.  When the **Installing** dialog appears, check **Mobile & Gaming > Mobile Development with .NET** and (optionally) **Windows > Universal Windows Platform development**. The **Mobile Development with .NET** option should also update any existing Xamarin installation.

While the installation is running, you can continue with the Mac setup instructions and go through [Learn about mobile development with Xamarin](../cross-platform/learn-about-mobile-development-with-xamarin.md).

5.  Once installation is complete, launch Visual Studio and sign in with your Microsoft account if prompted. This account is the same account you use with Windows.

6.  For testing Android apps, use the [Android SDK Emulator](/xamarin/android/get-started/installation/android-emulator/) if you don't have a physical Android device. 

<a name="mac" />

##  Mac setup (Apple ID, Xcode, and Xamarin)

1.  Create a free Apple ID at [https://appleid.apple.com](https://appleid.apple.com/) if you don't have one already. This Apple ID is necessary for installing and signing into Xcode.

2.  Download and install Xcode from [https://developer.apple.com/xcode/](https://developer.apple.com/xcode/), and add your Apple ID as described on [Adding Your Account to Xcode](https://developer.apple.com/library/content/documentation/IDEs/Conceptual/AppStoreDistributionTutorial/AddingYourAccounttoXcode/AddingYourAccounttoXcode.html#//apple_ref/doc/uid/TP40013839-CH40-SW1) (apple.com).

3.  Download and install Visual Studio for Mac by following the instructions on [Setup and Install Visual Studio for Mac](/visualstudio/mac/installation.md).

4.  Once you've completed installing Xamarin on both the Windows and Mac computers, follow the instructions on [Connecting to the Mac](/xamarin/ios/get-started/installation/windows/connecting-to-mac/) so that you can work with iOS and the Mac from Visual Studio on the Windows computer.

Both computers must be on the same local network.