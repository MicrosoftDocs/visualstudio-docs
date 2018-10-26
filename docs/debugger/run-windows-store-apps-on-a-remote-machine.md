---
title: "Debug UWP apps on remote machines | Microsoft Docs"
ms.custom: ""
ms.date: "10/05/2018"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
ms.assetid: 0f6814d6-cd0d-49f3-b501-dea8c094b8ef
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "uwp"
---
# Debug UWP apps on remote machines from Visual Studio
  
You can use Visual Studio to run, debug, profile, and test a Universal Windows Platform (UWP) app on another computer or device. Running the UWP app on a remote machine is especially helpful when the Visual Studio computer does not support UWP-specific functionality like touch, geo-location, or physical orientation. 

##  <a name="BKMK_Prerequisites"></a> Prerequisites  

To debug a UWP app on a remote device from Visual Studio:  
  
- The remote machine and the Visual Studio computer must be connected over a network, or connected directly through a USB or Ethernet cable. Debugging over the internet is not supported.  
- You must [enable developer mode](/windows/uwp/get-started/enable-your-device-for-development) on both the Visual Studio computer and the remote machine. 
- The remote computer must be running the Remote Tools for Visual Studio. 
  - Windows 10 PCs running Creator's Update (version 1703) and later, and Windows 10 Xbox, IoT, and HoloLens devices, install and start the remote tools automatically. 
  - On pre-Creator's Update Windows 10 PCs, you must [install and start the remote tools manually](#BKMK_download) before you start debugging. 
  - Windows Mobile 10 devices do not require or support the remote tools.   

##  <a name="BKMK_ConnectVS"></a> Configure a Visual Studio project for remote debugging

You use the project **Properties** to specify the remote device to connect to. The settings differ depending on the programming language. 

> [!SECURITY WARNING]
> By default, the property page sets **Universal (Unencrypted Protocol)** as the **Authentication Type** for Windows 10 remote connections. **Universal (Unencrypted Protocol)** or **No Authentication** protocols have no network security, so data passed between the development and remote machines is vulnerable. Choose these authentication types only for trusted networks that you are sure are not at risk from malicious or hostile traffic. 
>
>If you choose **Windows Authentication** for the **Authentication Type**, you will need to sign in to the remote machine when debugging, and the remote tools on the remote machine must be running under the same user account as Visual Studio on the local machine.

##  <a name="BKMK_Choosing_the_remote_device_for_C__and_Visual_Basic_projects"></a> Configure a C# or Visual Basic project for remote debugging  

1. Select the C# or Visual Basic project in Visual Studio **Solution Explorer** and click the **Properties** icon, press **Alt**+**Enter**, or right-click and choose **Properties**.
  
1.  Select the **Debug** tab.  
  
1.  Under **Target device**, select **Remote Machine**.  
  
1.  Enter the network name or IP address of the remote device in the **Remote machine** field, or select **Find** to search for the device in the [Remote Connections** dialog box](#remote-connections). 

    ![Managed project properties for remote debugging](../debugger/media/vsrun_managed_projprop_remote.png "Managed Debug project properties")  
  
  > [!TIP]
  >  If you can't connect to a remote device by name, try using its IP address. To determine the IP address, on the device, type **ipconfig** in a command window. The IP address is listed as **IPv4 Address**.  
  
1. Use **File** > **Save Selected Items** or **Ctrl**+**S** to save changes.

###  <a name="BKMK_Choosing_the_remote_device_for_JavaScript_and_C___projects"></a> Configure a JavaScript or C++ project for remote debugging   
  
1. Select the C++ or JavaScript project in Visual Studio **Solution Explorer** and click the **Properties** icon, press **Alt**+**Enter**, or right-click and choose **Properties**.
  
1.  Select the **Debugging** tab.  
  
3.  Under **Debugger to launch**, select **Remote Machine**.  
  
1.  Under **Machine Name**, enter or select the network name or IP address of the remote device, or drop down and select **Locate** to search for the device in the [Remote Connections dialog box](#remote-connections). 

    ![C++ project properties for remote debugging](../debugger/media/vsrun_cpp_projprop_remote.png "C++ Debugging project properties")
  
  > [!TIP]
  >  If you can't connect to a remote device by name, try using its IP address. To determine the IP address, on the device, type **ipconfig** in a command window. The IP address is listed as **IPv4 Address**.  
  
1. Use **File** > **Save Selected Items** or **Ctrl**+**S** to save changes.

### <a name="remote-connections"></a> Use the Remote Connections dialog box

In the **Remote Connections** dialog box, you can search for a specific remote computer name or IP address, or auto-detect connections by selecting the rounded-arrow refresh icon. The dialog searches only devices on the local subnet of the Visual Studio computer that are currently running the remote debugger.  

 ![Remote Connection dialog box](../debugger/media/vsrun_selectremotedebuggerdlg.png "Remote Connections dialog")  

###  <a name="BKMK_DirectConnect"></a> Configure remote debugging on Windows Mobile 10 devices

To configure remote debugging on Windows Mobile 10 devices:

- Physically connect the Windows Mobile 10 device to the computer with a USB cable.
- Enable [developer mode](/windows/uwp/get-started/enable-your-device-for-development) on the Windows Mobile 10 device and the Visual Studio computer.
- Configure your Visual Studio project for remote debugging, selecting **Device** instead of **Remote Machine** as the target debugger on the properties page.

## <a name="BKMK_download"></a> Download and install the Remote Tools for Visual Studio

To use Visual Studio to debug UWP apps on a remote computer, the remote computer must be running the Remote Tools for Visual Studio. 

Windows 10 PCs running Creator's Update (version 1703) and later, and Windows 10 Xbox, IoT, and HoloLens devices, install and start the remote tools automatically when you start debugging in Visual Studio. 

Windows Mobile 10 devices do not require or support the remote tools. 

On pre-Creator's Update Windows 10 PCs, you must download, install, and be running the remote tools on the remote computer before you start debugging.

[!INCLUDE [remote-debugger-download](../debugger/includes/remote-debugger-download.md)]
  
### <a name="BKMK_setup"></a> Configure the remote tools

[!INCLUDE [remote-debugger-configuration](../debugger/includes/remote-debugger-configuration.md)]  
  
##  <a name="BKMK_RunRemoteDebug"></a> Debug UWP apps remotely 

Remote debugging works the same as local debugging. 

1. On pre-Creator's Update versions of Windows 10, make sure the Remote Debugging Monitor (*msvsmon.exe*) is running on the remote device. Creator's Update and later runs remote tools automatically, and Windows 10 Mobile does not require or support remote tools. 
   
1. On the Visual Studio computer, make sure the correct debugging target (**Remote Machine** or **Device**) appears next to the green arrow on the toolbar. 
   
1. Start debugging by selecting **Debug** > **Start Debugging**, pressing **F5**, or selecting the green arrow on the toolbar. 
   
   The project recompiles, then deploys and starts on the remote device. The debugger suspends execution at breakpoints, and you can step into, over, and out of code. 
   
1. If necessary, select **Debug** > **Stop Debugging** or press **Shift**+**F5** to stop debugging and close the remote app.
  
## See also  
 [Advanced remote deployment options](/windows/uwp/debug-test-perf/deploying-and-debugging-uwp-apps#advanced-remote-deployment-options)  
 [Testing UWP apps with Visual Studio](../test/testing-store-apps-with-visual-studio.md)   
 [Debug UWP apps in Visual Studio](debugging-windows-store-and-windows-universal-apps.md)
