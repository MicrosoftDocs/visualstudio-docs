---
title: "Configure the Windows firewall for remote debugging | Microsoft Docs"
ms.custom: ""
ms.date: "05/18/2018"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
ms.assetid: 66e3230a-d195-4473-bbce-8ca198516014
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# Configure the Windows firewall for remote debugging

To debug on a remote computer from Visual Studio on a network protected by Windows firewall, you may need to configure the Windows firewall on the Visual Studio computer, the remote computer, or both. Visual Studio and the remote debugging tools try to open the correct ports during installation or startup, but you may need to open ports and allow apps manually. 

This topic describes how to configure the firewall to enable remote debugging on Windows 10, 8/8.1, and 7; and Windows Server 2012 R2, 2012, and 2008 R2. The Visual Studio and remote computers do not have to run the same operating system. For example, the Visual Studio computer can run Windows 10, and the remote computer can run Windows Server 2012 R2.      
  
>[!NOTE]
>The instructions for configuring the Windows firewall differ slightly on different operating systems, and for older versions of Windows. Windows 8/8.1, Windows 10, and Windows Server 2012 settings use the word *app*, while Windows 7 and Windows Server 2008 use the word **program**.  

## Configure ports for remote debugging  

For remote debugging, the following ports must be open on both the Visual Studio host computer and the remote computer:

|**Ports**|**Incoming/Outgoing**|**Protocol**|**Description**|   
|-|-|-|-|
|4022|Incoming|TCP|For VS 2017. The port number is incremented by 2 for each Visual Studio version. For more information, see [Visual Studio remote debugger port assignments](../debugger/remote-debugger-port-assignments.md).|  
|4023|Incoming|TCP|For VS 2017. The port number is incremented by 2 for each Visual Studio version. This port is only used to remote debug a 32-bit process from a 64-bit version of the remote debugger. For more information, see  [Visual Studio remote debugger port assignments](../debugger/remote-debugger-port-assignments.md).| 
|3702|Outgoing|UDP|(Optional) Required for remote debugger discovery.|    
  
Debugger compatibility mode (**Tools** > **Options** > **Debugging** > **General** > **Use Managed Compatibility Mode**) enables a legacy, Visual Studio 2010 version of the debugger that uses different ports. If your domain policy requires network communication to be performed through IPSec, you must open additional ports on both computers. To debug on a remote web server, you must open an additional port on the remote computer. For IIS, port 80 must be open. 

|**Ports**|**Incoming/Outgoing**|**Protocol**|**Description**|  
|-|-|-|-|  
|135, 139, 445|Outgoing|TCP|Required.|  
|137, 138|Outgoing|UDP|Required.|  
|500, 4500|Outgoing|UDP|Required if your domain policy requires network communication to be performed through IPSec.|  
|80|Outgoing|TCP|Required for web server debugging.|

To verify which ports are open, and allow specific apps through the firewall, see [Configure remote debugging through Windows firewall](#troubleshooting). 

### Open ports in Windows Firewall with Advanced Security  

Visual Studio and the remote debugger try to open the correct ports during installation or startup. However, in some scenarios, such as using a third-party firewall, you may need to open ports manually. 

**To open a port:**
  
1. In Windows **Start** menu, search for and open **Windows Defender Firewall with Advanced Security**.
   
1. For incoming rules, select **Inbound Rules** > **New Rule** > **Port**, and then select **Next**. (For outgoing rules, select **Outbound Rules** instead.)
   
1. Select either **TCP** or **UDP**, depending on the port number in the preceding table.
   
1. Under **Specific local ports**, enter the port number, and select **Next**.
   
1. Select **Allow the Connection**, and then select **Next**.
   
1. Select one or more network types to enable for the port, which must include the network type for the remote computer, and then select **Next**.
   
1. Add a name for the rule (for example, **msvsmon**, **IIS**, or **Web Deploy**), and then select **Finish**.

   You should see the new rule selected in the **Inbound Rules** or **Outbound Rules** list.

## <a name="troubleshooting"></a>Configure remote debugging through Windows firewall

The remote debugging tools can be installed on the remote computer or run from a shared directory. The remote computer firewall must be configured in either case. The remote debugging tools are located in:  
  
*\<Visual Studio installation directory>\Common7\IDE\Remote Debugger* 
  
### Verify that ports are open in the Windows Firewall 
  
If you are having trouble attaching to your app with the remote debugger, verify that the correct ports are open. On both the Visual Studio and remote computers:

1. In Windows **Start** menu, search for and open **Windows Defender Firewall**.

1.  Click **Allow an app or feature through Windows Firewall**.  
  
1.  In the **Allowed apps and features** list:
    - On the Visual Studio computer, make sure **Visual Studio Remote Debugger Discovery** is listed and selected.
    - On the remote computer, make sure **Visual Studio Remote Debugger Discovery** is listed and selected.
    Make sure that the correct network type for your app (**Domain**, **Home/Work (Private)**, or **Public**) is also selected.  
  
### Allow remote debugger tools through the Windows Firewall 
  
1.  If **Visual Studio Remote Debugger** or **Visual Studio Remote Debugger Discovery** are not listed under **Allowed apps and features**, select **Allow another app**. 

1.  If you still don't see the app listed in the **Add an app** window, click **Browse**, and navigate to *\<Visual Studio installation directory>\Common7\IDE\Remote Debugger*. Find the appropriate folder for your app (*x86*, *x64*, or *Appx*), select *msvsmon.exe*, and then select **Add**.  
    
1.  In the **Allowed apps and features** list, select **Visual Studio Remote Debugger**. Check one or more network types (**Domain**, **Home/Work (Private)**, **Public**) that you want the remote debugging monitor to communicate with. The selected types must include the network type the computers are connected to. 

## See also  
 [Remote debugging](../debugger/remote-debugging.md)