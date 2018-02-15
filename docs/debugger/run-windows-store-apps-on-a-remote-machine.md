---
title: "Run UWP apps on a remote machine | Microsoft Docs"
ms.custom: ""
ms.date: "01/05/2018"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
ms.assetid: 0f6814d6-cd0d-49f3-b501-dea8c094b8ef
caps.latest.revision: 43
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "uwp"
---
# Run UWP apps on a remote machine in Visual Studio
  
To run a UWP app on a remote machine, you must attach to it using the Remote Tools for Visual Studio. The remote tools enable you to run, debug, profile, and test a UWP app that is running on one device from a second computer that is running Visual Studio. Running on a remote device can be especially effective when the Visual Studio computer does not support functionality that is specific to UWP apps, such as touch, geo-location, and physical orientation. This topic describes the procedures to configure and start a remote session.

In some scenarios, the remote tools are automatically installed when you deploy to a remote device.

- For Windows 10 PCs running Creators Update and later versions, remote tools will be installed automatically.
- For Windows 10 Xbox, IOT, and HoloLens devices, remote tools will be installed automatically.
- For Windows Mobile 10, you must be physically connected to the phone, you must enable [developer mode](/windows/uwp/get-started/enable-your-device-for-development) and you must select **Device** as the debug target. Remote tools are not required or supported.

For Windows 10 PCs running a pre-Creator's Update version of Windows, you must install the remote tools on the remote machine manually before you can debug. Follow the instructions in this topic. 
  
##  <a name="BKMK_Prerequisites"></a> Prerequisites  
 To debug on a remote device:  
  
- The remote device and the Visual Studio computer must be connected over a network or connected directly through a USB or Ethernet cable. Debugging over the internet is not supported.  

- You must enable [developer mode](/windows/uwp/get-started/enable-your-device-for-development). 
  
- For Windows 10 PCs running a version of Windows 10 earlier than Windows 10 Creator's Update, you must [install and run the remote debugging components](#BKMK_download).
  
##  <a name="BKMK_Security"></a> Security  
By default, **Universal (Unencrypted Protocol)** is used on Windows 10. Ths protocol should only be used on trusted networks. The debugging connection is vulnerable to malicious users who could intercept and change data being passed between the development and remote machine.
  
> [!WARNING]
>  There is no network security when you set the authentication mode to **Universal (Unencrypted Protocol)** or **None**. Choose these modes only if you are sure that the network is not at risk of from malicious or hostile traffic.  
  
##  <a name="BKMK_DirectConnect"></a> How to connect directly using a USB cable 

On Windows 10, you can deploy to a USB-connected device by choosing **Device** instead of **Remote Machine** as the deployment target (you can do this in the **Standard** toolbar or in the debugging properties page).

##  <a name="BKMK_ConnectVS"></a> Configure the Visual Studio project for remote debugging  
 You specify the remote device to connect to in the properties of the project. The procedure differs depending on the programming language. You can type the network name of the remote device or you can select it from the **Remote Connection** dialog box.  
  
 ![Select Remote Debugger Connection dialog box](../debugger/media/vsrun_selectremotedebuggerdlg.png "VSRUN_SelectRemoteDebuggerDlg")  
  
 The dialog box lists only those devices that are on the local subnet of the Visual Studio computer and that are running the remote debugger.  
  
> [!TIP]
>  If you have trouble connecting to a remote device, try entering the IP address of the device. To determine the IP address of a device, open a command window and then type **ipconfig**. The IP address is listed as **IPv4 Address**.  
  
###  <a name="BKMK_Choosing_the_remote_device_for_C__and_Visual_Basic_projects"></a> Choose the remote device for C# and Visual Basic projects  
  
1.  Select the project name in Solution Explorer and then choose **Properties** from the shortcut menu.  
  
2.  Select **Debug**.  
  
3.  Choose **Remote Machine** from the **Target Device** list.  
  
4.  Enter the network name of the remote device in the **Remote Machine** box or choose **Find** to choose the device from the **Select Remote Debugger Connection** dialog box. 

    ![Managed project properties for remote debugging](../debugger/media/vsrun_managed_projprop_remote.png "VSRUN_Managed_ProjProp_Remote")  
  
###  <a name="BKMK_Choosing_the_remote_device_for_JavaScript_and_C___projects"></a> Choose the remote device for JavaScript and C++ projects  
  
1.  Select the project name in Solution Explorer and then choose **Properties** from the shortcut menu.  
  
2.  Expand the **Configuration Properties** node and then select **Debugging**.  
  
3.  Choose **Remote Debugger** from the **Debugger to launch** list.  
  
4.  Enter the network name of the remote device in the **Machine Name** box or choose the down arrow in the box to choose the device from the **Select Remote Debugger Connection** dialog box.  

    ![C&#43;&#43; project properties for remote debugging](../debugger/media/vsrun_cpp_projprop_remote.png "VSRUN_CPP_ProjProp_Remote")
  
## <a name="BKMK_download"></a> Download and Install the remote tools (pre-Creators Update)

If you are using a pre-Creator's Update versions of Windows 10, then follow these instructions. Otherwise, you can skip this section.

[!INCLUDE [remote-debugger-download](../debugger/includes/remote-debugger-download.md)]
  
### <a name="BKMK_setup"></a> Set up the remote debugger

[!INCLUDE [remote-debugger-configuration](../debugger/includes/remote-debugger-configuration.md)]  
  
##  <a name="BKMK_RunRemoteDebug"></a> Start a remote debugging session  
 You start, stop, and navigate a remote debug session the same way you do a local session. On pre-Creator's Update versions of Windows 10, make sure the Remote Debugging Monitor is running on the remote device.  
  
 Then choose **Start Debugging** on the **Debug** menu (Keyboard: F5). The project is recompiled, then deployed to and started on the remote device. The debugger suspends execution at breakpoints, and you can step into, over, and out of your code. Choose **Stop Debugging** to end your debug session and close the remote app.
  
## See Also  
 [Advanced remote deployment options](/windows/uwp/debug-test-perf/deploying-and-debugging-uwp-apps#advanced-remote-deployment-options)  
 [Testing UWP apps with Visual Studio](../test/testing-store-apps-with-visual-studio.md)   
 [Debug apps in Visual Studio](../debugger/debug-store-apps-in-visual-studio.md)