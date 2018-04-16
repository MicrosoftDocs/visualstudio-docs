---
title: "Verify your Xamarin environment | Microsoft Docs"
ms.custom: ""
ms.date: "03/30/2018"
ms.topic: "conceptual"
ms.assetid: fd39882e-06d1-4b39-80d2-4d07b6e4f8f5
ms.technology: vs-ide-mobile
author: charlespetzold
ms.author: chape
manager: crdun
ms.workload: 
  - "xamarin"
---

# Verify your Xamarin environment

Once the installers have completed (see [Setup and install](../cross-platform/setup-and-install.md)), spend a few minutes to verify that everything is ready to experience Xamarin development.  
  
 Once you have finished verifying the installation, try either or both of the following walkthroughs:  
  
-   [Learn app-building basics with Xamarin.Forms in Visual Studio](../cross-platform/learn-app-building-basics-with-xamarin-forms-in-visual-studio.md) to build a Xamarin.Forms application.
  
-   [Build apps with native UI using Xamarin in Visual Studio](../cross-platform/build-apps-with-native-ui-using-xamarin-in-visual-studio.md) to use the native user interfaces on each platform but share some code in a .NET Standard library.
  
## All platforms 
 
In Visual Studio, first select **Tools > Extensions and Updates** and check if any of the Xamarin components require updates.  
  
Then, create a new Xamarin.Forms solution in Visual Studio using **File > New Project**. In the dialog, expand **Visual C# > Cross-Platform**, select **Mobile App (Xamarin.Forms)**, and click OK. In the dialog that follows, select **Blank App**. Under **Code Sharing Strategy**, select **.NET Standard**. Click OK.

These actions create a solution with four projects: a shared .NET Standard 2.0 library project and application projects for Android, iOS, and the Universal Windows Platform (UWP):  
  
![Results of creating a new project from the Blank App Xamarin.Forms template](../cross-platform/media/crossplat-xamarin-verify-1.png "CrossPlat Xamarin Verify 1")  
   
## Android  
  
1. Check that you have the latest Android SDK tools installed by going to **Tools > Android > Android SDK Manager**. Install the newest versions of the Android SDK Tools, Android SDK Platform tools, and Android SDK Build tools. It is not necessary to always install the latest Android API level. The API level you need depends on the platform level you want to target. In general, installing the Xamarin platform will install the Android platform level it requires.  
  
2.  Validate building and debugging on a device or emulator:  
  
    -   Right-click the Android project in Solution Explorer and select **Set as Startup Project**.  
  
    -   In the toolbar, you should see a drop-down containing a list of available Android devices and emulators. 
    
    Android devices must be enabled for USB debugging in the Developer options of the device's Settings page. The device is then attached to the computer by USB cable. 
    
    Also listed are emulators. Select one of the devices or Visual Studio emulators:

  ![Selecting the Visual Studio Emulator for Android as a debug target](../cross-platform/media/crossplat-xamarin-verify-3.png "CrossPlat Xamarin Verify 3")  
  
  For more detailed information, see [Introducing Visual Studio's Emulator for Android](http://blogs.msdn.com/b/visualstudioalm/archive/2014/11/12/introducing-visual-studio-s-emulator-for-android.aspx) (Visual Studio ALM blog). If you encounter problems getting the emulator to work, see [Troubleshooting the Visual Studio Emulator for Android](../cross-platform/troubleshooting-the-visual-studio-emulator-for-android.md). You can also create new device profiles for the emulator by selecting **Tools > Android > Android Emulator Manager**.  
  
3. Press F5 to compile and deploy the program to the Android device or emulator.
  
## Windows 
  
1.  Right-click the Universal Windows project in Solution Explorer and select **Set as Startup Project**.  

2.  In the **Solution Platforms** drop-down, select **x86** or **x64**. Select **Local Machine**.

3.  Press F5 to deploy the program to the desktop.
  
## iOS  
  
1.  Make sure your Mac is available on the network and paired with Visual Studio as described on [Connecting to the Mac](/xamarin/ios/get-started/installation/windows/connecting-to-mac/).  
  
2.  Right-click the iOS project in Solution Explorer and select **Set as Startup Project**.  
  
3.  Select the **iPhoneSimulator** target from Visual Studio's build drop-down as shown below, or the **iPhone** target if you have a device tethered to the Mac.   
  
 ![Selecting the iPhoneSimulator build target](../cross-platform/media/crossplat-xamarin-verify-5.png "CrossPlat Xamarin Verify 5") 

 If no simulators are listed, launch Xcode on your Mac, select **Xcode > Preferences**, and click **Download**. Under the **Components** heading you should see the simulator versions that are available to download. Additional instructions for debugging can be found on the [iOS Debugging](/xamarin/ios/deploy-test/debugging-in-xamarin-ios/?tabs=vsmac#Debugging_on_the_Simulator) page.
  
4.  Select an emulator device target from the Visual Studio drop-down:

 ![Selecting an iPhone debug target](../cross-platform/media/crossplat-xamarin-verify-6.png "CrossPlat Xamarin Verify 6")

5. Start the debugger by pressing F5. The simulator is launched on the Mac where you'll interact with the app, while debugging happens in Visual Studio. If you have a physical iPhone or iPad connected to the Mac, it will appear on the list and you can select it instead. If you do not see any devices or simulators listed, check the connection to the Mac. Review the article linked in step 1 above, or go to **Tools > iOS > Pair to Mac**  
  
6.  If you encounter problems connecting to the Mac, read [Connection Troubleshooting](/xamarin/ios/get-started/installation/windows/connecting-to-mac/troubleshooting/).  
  
7.  If you see an error saying "No installed provisioning profiles match the installed iOS signing keys," try the following suggestions:  
  
  - Check that your Apple Id account is added in Xcode on your Mac as described on [Adding Your Account to Xcode](https://developer.apple.com/library/content/documentation/IDEs/Conceptual/AppStoreDistributionTutorial/AddingYourAccounttoXcode/AddingYourAccounttoXcode.html#//apple_ref/doc/uid/TP40013839-CH40-SW1) (apple.com).  After adding your account, be sure to restart both Visual Studio and Xcode.  
    
  - Verify that in your iOS project properties in the iOS bundle signing tab, that the Custom entitlement field is empty for the   active debug configuration.  Note: you should only try removing this setting if you've encountered the above error message.  
  
  ![CrossPlat Xamarin Verify 8](../cross-platform/media/crossplat-xamarin-verify-8.png "CrossPlat Xamarin Verify 8")  
