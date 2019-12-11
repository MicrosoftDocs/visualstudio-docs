---
title: "Visual Studio Emulator for Android | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "tgt-pltfrm-cross-plat"
ms.topic: conceptual
ms.assetid: 80f0104f-a4db-44dd-bd55-37bb67776c62
caps.latest.revision: 7
ms.author: crdun
manager: "crdun"
---
# Visual Studio Emulator for Android
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Visual Studio Emulator for Android is a desktop application that emulates an Android device. It provides a virtualized environment in which you can debug and test Android apps without a physical device. It also provides an isolated environment for your application prototypes.  
  
 The Visual Studio Emulator for Android is designed to provide comparable performance to an actual device. Before you publish your app, however, we recommend that you test your app on a physical device.  
  
 You can test your app on a unique device profile for each of the Android platforms, screen resolutions, and other hardware properties supported by Visual Studio Emulator for Android.  
  
 This topic contains the following sections.  
  
- [Installing and uninstalling](#Installing)  
  
- [System Requirements and backward compatibility](#Requirements)  
  
- [Networking in the Visual Studio Emulator for Android](#Networking)  
  
- [Configure the Visual Studio Emulator for Android](#Configuring)  
  
- [Features that you can test in the emulator](#FeaturesTest)  
  
- [Features that you can’t test in the emulator](#FeaturesNonTest)  
  
- [Support Resources](#Support)  
  
## <a name="Installing"></a> Installing and uninstalling  
 Installing  
  
 Visual Studio Emulator for Android is a component of the cross-platform tools available in Visual Studio and will be installed during a custom Visual Studio setup when you select Cross-Platform Mobile Development, then Common Tools and Software Development Kits, and then Visual Studio Emulator for Android.  
  
 Uninstalling  
  
 You can uninstall the Visual Studio Emulator for Android using Add/Remove Programs in the Control Panel.  
  
> [!NOTE]
> Uninstalling Visual Studio will not uninstall the emulator. You must uninstall the emulator separately.  
  
 When you uninstall the Visual Studio Emulator for Android, the Hyper-V Virtual Ethernet Adapters that were created for the emulator to use are not automatically removed. You can manually remove these virtual adapters (if not in use) by opening Hyper-V Manager, selecting one of the emulator VHD images, choosing the Networking tab, and choosing **Remove** for each of the switches that appears in this tab.  
  
## <a name="Requirements"></a> System Requirements and backward compatibility  
 For important info about the hardware, software, and configuration requirements for Visual Studio Emulator for Android, see the following topic.  
  
- [System Requirements for the Visual Studio Emulator for Android](../cross-platform/system-requirements-for-the-visual-studio-emulator-for-android.md)  
  
  Visual Studio Emulator for Android requires Visual Studio 2015; it is not backward compatible with earlier versions of Visual Studio.  
  
  New versions of the emulator are installed on top of old versions (and may, in some cases, replace the old images, discarding the settings, apps, and files installed on those images).  
  
## <a name="Networking"></a> Networking in the Visual Studio Emulator for Android  
 The networking connection of the Visual Studio Emulator for Android behaves like the connection of a desktop computer with these characteristics:  
  
- The emulator appears on the network as a separate device with its own IP address.  
  
- It does not require any additional networking software that is not already installed with the emulator.  
  
- It is not joined to a Windows domain.  
  
  To understand the capabilities of the emulator's network connection, think of it as similar to a Wi-Fi connection from your Android phone to the same network. If an app running on your phone can access a network resource over its Wi-Fi connection, then an app running on the emulator can also access the same network resource.  
  
  For more info on network requirements, see [System Requirements for the Visual Studio Emulator for Android](../cross-platform/system-requirements-for-the-visual-studio-emulator-for-android.md)  
  
  For info on troubleshooting networking issues, see [Troubleshooting the Visual Studio Emulator for Android](../cross-platform/troubleshooting-the-visual-studio-emulator-for-android.md).  
  
## <a name="Configuring"></a> Configure the Visual Studio Emulator for Android  
 Testing your Android app for compatibility across the staggering variety of Android hardware can be a challenge. Android phones and tablets in the market span a wide range of versions and screen sizes and come in many different hardware configurations (RAM, CPUs, architecture, etc.). The Visual Studio Emulator for Android simplifies this using device profiles. Our set of device profiles represent the most popular hardware in the market, including devices from Samsung, Motorola, Sony, LG, and more.  
  
 In Visual Studio 2015, you can install, uninstall, and start device profiles using the Emulator Manager. Access the Emulator Manager by choosing **Tools**, then **Visual Studio Emulator for Android**.  
  
 ![The Visual Studio Emulator for Android Manager](../cross-platform/media/android-emu-manager.png "Android_Emu_Manager")  
  
 By default, there are four pre-installed device profiles (KitKat and Lollipop phone/5" and tablet/7" configurations), as indicated by the white text and icons. Other profiles in the list will appear grayed out until you choose the **Install Profile** button and the installation completes. You can filter the list by API Level and click the details arrow on the bottom right-hand side of a profile to view its full configuration details.  
  
 Once you've installed the set of profiles that you'd like to target, you can start these new profiles directly from the manager by pressing the green **Play** button. They will also appear in the debug target dropdown menu in any Visual Studio cross-platform mobile project type.  
  
## <a name="FeaturesTest"></a> Features that you can test in the emulator  
 For detailed information on features you can test in the emulator, see this [documentation](https://devblogs.microsoft.com/devops/introducing-visual-studios-emulator-for-android/).  
  
## <a name="FeaturesNonTest"></a> Features that you can’t test in the emulator  
 The following list describes features of the Android platform that you **cannot** test in the emulator. You have to test these features on a physical device.  
  
- Compass  
  
- Gyroscope  
  
- Vibration controller  
  
- Brightness. Changing the brightness level of the emulator will not visually impact the way the device appears on your screen.  
  
## <a name="Support"></a> Support Resources  
 If your host computer meets the system requirements and you encounter an issue not covered in this troubleshooting guide:  
  
- Ask a question on StackOverflow using the [android-emulator](https://stackoverflow.com/questions/tagged/android-emulator) and the visual-studio tag.  
  
- Report an issue using the Send a Smile tool in Visual Studio or in the Emulator Manager.  
  
## See Also  
 [System Requirements for the Visual Studio Emulator for Android](../cross-platform/system-requirements-for-the-visual-studio-emulator-for-android.md)   
 [Troubleshooting the Visual Studio Emulator for Android](../cross-platform/troubleshooting-the-visual-studio-emulator-for-android.md)
