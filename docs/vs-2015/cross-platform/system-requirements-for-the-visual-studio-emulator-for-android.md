---
title: "System Requirements for the Emulator for Android | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "tgt-pltfrm-cross-plat"
ms.topic: conceptual
ms.assetid: 35e766ad-269f-41e4-ba23-74a556c315f3
caps.latest.revision: 7
ms.author: crdun
manager: "crdun"
---
# System Requirements for the Visual Studio Emulator for Android
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Visual Studio Emulator for Android runs as a virtual machine on Hyper-V, the virtualization technology for Windows 8 and later versions. To run the emulator, your computer must meet the requirements to run Hyper-V as described in this topic.

 The setup program tries to configure these prerequisites for you silently when you install the emulator. When setup successfully configures the prerequisites, the emulator simply works as expected. Otherwise you may have to enable these prerequisites manually. If you have to configure the prerequisites manually, the steps and tools are the same steps described [here](https://msdn.microsoft.com/library/windows/apps/jj863509\(v=vs.105\).aspx) for the Windows Phone Emulator.

> [!IMPORTANT]
> The setup program for the emulator checks the prerequisites for running Visual Studio Emulator for Android. It displays warnings if the prerequisites are not present, but it does not require them.

 This topic contains the following sections.

- [Quick Checklist](#Checklist)

- [System requirements](#System)

- [Network requirements](#Network)

- [Hyper-V requirements](#HyperV)

- [Running the emulator from a bootable VHD is not supported](#BootableVHD)

- [Hyper-V requires uncompressed and unencrypted files](#Files)

## <a name="Checklist"></a> Quick Checklist
 Here is a quick checklist of the requirements for running the Visual Studio Emulator for Android. For more detailed info, see the subsequent sections in this topic.

 System requirements

- Hyper-V support (see Hyper-V requirements below)

- 6 GB or more of RAM.

- 64-bit version of the Pro edition of Windows 8, Windows 8.1, Windows10 or higher

- A processor that supports SSSE3 or later.

  Network requirements

- DHCP

- Automatically configured DNS and gateway settings

  Hyper-V requirements

- In the BIOS, the following features must be supported:

  - Hardware-assisted virtualization

  - Second Level Address Translation (SLAT)

  - Hardware-based Data Execution Prevention (DEP)

- In Windows, Hyper-V must be enabled and running.

- You have to be a member of the local Hyper-V Administrators group.

## <a name="System"></a> System requirements
 Your computer must meet the following requirements:

- Hyper-V support (see [Hyper-V requirements](#HyperV))

- 6 GB or more of RAM.

- 64-bit version of the Pro edition of Windows 8, Windows 8.1, Windows10 or higher.

  To check requirements for RAM and Windows, in Control Panel, choose System and Security, and then choose System.

  ![Verify the system requirements](../cross-platform/media/android-emu-system-requirements.png "Android_Emu_System_Requirements")

## <a name="Network"></a> Network requirements
 Your network must meet the following requirements:

- DHCP

   The emulator requires DHCP because it configures itself as a separate device on the network with its own IP address.

- Automatically configured DNS and gateway settings

   It’s not possible to configure DNS and gateway settings manually for the emulator.

  To troubleshoot networking issues in the emulator, see the following topics:

- [Troubleshooting the Visual Studio Emulator for Android](../cross-platform/troubleshooting-the-visual-studio-emulator-for-android.md)

## <a name="HyperV"></a> Hyper-V requirements
 Hyper-V requirements in the BIOS

 Your computer’s BIOS must support the following requirements, and they must be enabled:

- Hardware-assisted virtualization

- Second Level Address Translation (SLAT)

- Hardware-based Data Execution Prevention (DEP)

  Hyper-V requirements in Windows

  When your computer and BIOS settings are already configured to support Hyper-V, the setup program enables and starts Hyper-V. Otherwise you may have to enable these requirements manually.

|Requirement|How to check and enable this requirement|
|-----------------|----------------------------------------------|
|Hyper-V must be installed|Follow the same instructions used to [enable Hyper-V for the Windows Phone emulator](https://msdn.microsoft.com/library/windows/apps/jj863509\(v=vs.105\).aspx).<br /><br /> Check the status of the **Hyper-V Virtual Machine Management** service in the Services snap-in.|
|Hyper-V must be running.|For more info about managing services, see the following topics:<br /><br /> -   [Start, stop, pause, resume, or restart a service](https://technet.microsoft.com/library/cc736564\(v=WS.10\).aspx)<br />-   [Configure how a service is started](https://technet.microsoft.com/%20library/cc739213\(v=ws.10\))|

 You have to be a member of the local Hyper-V Administrators group.

 To run the Visual Studio Emulator for Android without a recurring prompt to elevate your rights, you have to be a member of the local Hyper-V Administrators group. If you are already a local administrator on the computer when you install the SDK, the setup program for the SDK adds you to the Hyper-V Administrators group. Otherwise you may have to enable this requirement manually.

 When you run the emulator, if you are not already a member of the Hyper-V Administrators group, you are prompted to join the group (the dialog box refers to the Windows Phone emulator). Joining the group requires administrator rights.

> [!IMPORTANT]
> After you join the group, log off or reboot to make the change take effect.

 ![Joining the Hyper&#45;V Administrators security group](../cross-platform/media/android-emu-hyperv-admin.png "Android_Emu_HyperV_Admin")

 To add yourself to a group manually, open the Local Users and Groups snap-in.

## <a name="BootableVHD"></a> Running the emulator from a bootable VHD is not supported
 If you try to run an app on the Visual Studio Emulator for Android while you are running Windows from a bootable VHD, the emulator typically takes several minutes to start or fails to start. When the emulator fails to start, you see the following message: App deployment failed. Please try again.

 This configuration is not supported. For information about related issues, see [Troubleshooting the Visual Studio Emulator for Android](../cross-platform/troubleshooting-the-visual-studio-emulator-for-android.md).

## <a name="Files"></a> Hyper-V requires uncompressed and unencrypted files
 On a hard drive configured with the NTFS file system, the virtual hard disk files used by Hyper-V must be uncompressed and unencrypted. Make sure that the following directories are not compressed or encrypted:

- %localappdata%\Microsoft\XDE

- C:\Program Files (x86)\Microsoft Emulator Manager

- C:\Program Files (x86)\Microsoft Visual Studio Emulator for Android

- %localappdata%\Microsoft\VisualStudioEmulator

  On the ReFS file system, the virtual hard disk files must not have the integrity bit set.

## Hardware Graphics Forwarding (OpenGL ES support) Requirements
 In order for the emulator to emulate calls to the GPU, such as those used by OpenGL ES, your machine must have a DirectX compatible GPU with appropriate DirectX drivers installed.

## See Also
 [Troubleshooting the Visual Studio Emulator for Android](../cross-platform/troubleshooting-the-visual-studio-emulator-for-android.md)
