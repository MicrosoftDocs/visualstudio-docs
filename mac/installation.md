---
title: "Install Visual Studio 2019 for Mac"
description: "Instructions on how to install Visual Studio 2019 for Mac and additional components required for cross-platform development."
author: heiligerdankgesang
ms.author: dominicn
ms.date: 03/04/2021
ms.technology: vs-ide-install
ms.assetid: 22B1F2CD-32AE-464D-80AC-C8AB4786B015
ms.custom: video
ms.topic: how-to
---
# Install Visual Studio 2019 for Mac

To start developing native, cross-platform .NET apps on macOS, install Visual Studio 2019 for Mac following the steps below.

 > [!div class="button"]
 > [Download Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)

## Requirements

- A Mac with macOS High Sierra 10.13 or above.

To build Xamarin apps for iOS or macOS, you'll also need:

- A Mac that is compatible with the latest version of Xcode. See Apple's [minimum requirements documentation](https://developer.apple.com/support/xcode/)
- The latest version of [Xcode](https://developer.apple.com/xcode). It may be possible to [use an older version of Xcode](https://docs.microsoft.com/xamarin/ios/troubleshooting/questions/old-version-xcode) if your Mac is not compatible with the latest version of Xcode.
- An Apple ID. If you don't have an Apple ID already you can create a new one at https://appleid.apple.com. It's necessary to have an Apple ID for installing and signing into Xcode.

## Installation instructions

1. Download the installer from the [Visual Studio for Mac download page](https://visualstudio.microsoft.com/vs/mac/).
2. Once the download is complete, click the **VisualStudioforMacInstaller.dmg** to mount the installer, then run it by double-clicking the arrow logo:

    [![Click the large arrow to begin installation](media/install-installer-sml.png)](media/install-installer.png#lightbox)

3. You may be presented with a warning about the application being downloaded from the Internet. Click **Open**.
4. Wait while the installer checks your system:

    [![The installer checks your system for installed components](media/install-checking-sml.png)](media/install-checking.png#lightbox)

5. An alert will appear asking you to acknowledge the privacy and license terms. Follow the links to read them, then press **Continue** if you agree:

    [![Follow the links to the privacy and terms, then continue if you agree](media/install-privacy.png)](media/install-privacy.png#lightbox)

6. The list of available workloads is displayed. Select the components you wish to use:

    [![Screenshot of the "What would you like to install?" screen in the Visual Studio Mac Installer, showing a list of components available for installation.](media/install-selection.png)](media/install-selection.png#lightbox)

   If you do not wish to install all platforms, use the guide below to help you decide which platforms to install:

   |Type of App  |Target  |Selection  |Notes  |
   |---------|---------|---------|---------|
   |**Apps Using Xamarin**| Xamarin.Forms|Select **Android** and **iOS** platforms |You will need to install [**Xcode**](https://developer.apple.com/xcode/) |
   ||iOS only|Select **iOS** platform|You will need to install [**Xcode**](https://developer.apple.com/xcode/)|
   ||Android only|Select **Android** platform|Note that you should also select the relevant dependencies|
   ||Mac only|Select **macOS (Cocoa)** platform|You will need to install [**Xcode**](https://developer.apple.com/xcode/)|
   |**.NET Core applications**|         |Select **.NET Core** platform.|         |
   |**ASP.NET Core Web Applications**|         |Select **.NET Core** platform.|         |
   |**Azure Functions**|         |Select **.NET Core** platform.|         |
   |**Cross-platform Unity Game Development**|         |No additional platforms need to be installed beyond Visual Studio for Mac.| Refer to the [Unity setup guide](./setup-vsmac-tools-unity.md) for more information on installing the Unity extension.|

7. After you have made your selections, press the **Install** button.
8. The installer will display progress as it downloads and installs Visual Studio for Mac and the selected workloads. You will be prompted to enter your password to grant the privileges necessary for installation.:

    [![Screenshot from the Visual Studio Mac Installer showing an installation progress screen for The .NET developer toolkit for Mac.](media/installation-progress.png)](media/installation-progress.png#lightbox)

9. Once installed, Visual Studio for Mac will prompt you to personalize your installation by signing in and selecting the key bindings that you'd like to use:

    [![Sign in to the IDE](media/ide-tour-2019-start-signin.png)](media/ide-tour-2019-start-signin.png#lightbox)

    [![Choose which keyboard shortcuts you would like to use](media/ide-tour-2019-keyboard-shortcut.png)](media/ide-tour-2019-keyboard-shortcut.png#lightbox)

If you have network trouble while installing in a corporate environment, review the [installing behind a firewall or proxy](#install-visual-studio-for-mac-behind-a-firewall-or-proxy-server) instructions.

Learn more about the changes in the [release notes](/visualstudio/releasenotes/vs2019-mac-relnotes).

> [!NOTE]
> If you chose not to install a platform or tool during the original installation (by unselecting it in step #6), you must run the installer again if you wish to add the components later.

## Install Visual Studio for Mac behind a firewall or proxy server

To install Visual Studio for Mac behind a firewall, certain endpoints must be made accessible in order to allow downloads of the required tools and updates for your software.

Configure your network to allow access to the following locations:

- [Visual Studio endpoints](./install-behind-a-firewall-or-proxy-server.md)

## Next steps

Installing Visual Studio for Mac allows you to start writing code for your apps. The following guides are provided to guide you through the next steps of writing and deploying your projects.

### iOS

1. [Hello, iOS](https://docs.microsoft.com//xamarin/ios/get-started/hello-ios/)
2. [Device Provisioning](https://docs.microsoft.com/xamarin/ios/get-started/installation/device-provisioning/)(To run your application on device).

### Android

1. [Hello, Android](https://docs.microsoft.com/xamarin/android/get-started/hello-android/)
2. [Using the Xamarin Android SDK Manager](https://docs.microsoft.com/xamarin/android/get-started/installation/android-sdk?tabs=macos)
3. [Android SDK Emulator](https://docs.microsoft.com/xamarin/android/get-started/installation/android-emulator/)
4. [Set Up Device for Development](https://docs.microsoft.com/xamarin/android/get-started/installation/set-up-device-for-development)

### Xamarin.Forms

Build native cross-platform applications with Xamarin.Forms:

1. [Xamarin.Forms Quickstarts](https://docs.microsoft.com/xamarin/get-started/quickstarts/)

### .NET Core apps, ASP.NET Core web apps, Unity game development

For other Workloads, refer to the [Workloads](workloads.md) page.

## Related Video

> [!Video https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/Visual-Studio-for-Mac-Acquisition/player]

## See also

- [Install Visual Studio (on Windows)](/visualstudio/install/install-visual-studio)
