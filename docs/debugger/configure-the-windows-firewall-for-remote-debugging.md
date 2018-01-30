---
title: "Configure the Windows Firewall for Remote Debugging | Microsoft Docs"
ms.custom: ""
ms.date: "05/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 66e3230a-d195-4473-bbce-8ca198516014
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Configure the Windows Firewall for Remote Debugging
This topic describes how to configure the firewall to enable remote debugging on computers that run the following operating systems:  
  
-   Windows 10  
  
-   Windows 8/8.1  
  
-   Windows 7   
  
-   Windows Server 2012 R2  

-   Windows Server 2012
  
-   Windows Server 2008 R2 
  
 If the network on which you are debugging is not protected by a firewall, this configuration is unnecessary. Otherwise, both the computer that hosts Visual Studio and the remote computer that is to be debugged require changes to the firewall configuration.  
  
 **IPSec** If your network requires that communication be performed using IPSec, you must open additional ports on both the Visual Studio host computer and the remote computer.  
  
 **Web Server** If you are debugging a remote Web server, you must open an additional port on the remote computer. (For IIS, port 80 must be open.)  
  
 Note that both computers do not have to run the same operating system. For example, the Visual Studio computer can run Windows 10 and the remote computer can run Windows Server 2012 R2.      
  
## Ports on the remote computer that enable remote debugging  
  
|||||  
|-|-|-|-|  
|**Ports**|**Incoming/Outgoing**|**Protocol**|**Description**|   
|4022|Incoming|TCP|For VS 2017. The port number is incremented by 2 for each Visual Studio version. For more information, see [Visual Studio Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md).|  
|4023|Incoming|TCP|For VS 2017. The port number is incremented by 2 for each Visual Studio version. (Only used to remote debug a 32-bit process from the 64-bit version of the remote debugger.) For more information, see  [Visual Studio Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md).| 
|3702|Outgoing|UDP|(Optional) Required for remote debugger discovery.|    
  
## How to Configure Ports in Windows Firewall  

When you install Visual Studio or the remote debugger, the software will try to open the correct ports. However, in some scenarios (such as using a third party firewall), you may need to open a port manually. If you need to verify that ports are open, see [Troubleshooting](#troubleshooting). Some instructions for opening a port may be different on older versions of Windows.

To open a port:
  
1. Open the **Start** menu, search for **Windows Firewall with Advanced Security**.

2. Then choose **Inbound Rules > New Rule > Port**, and then click **Next**. (For Outgoing rules, choose **Outbound Rules** instead.)

3. Choose either **TCP** or **UDP**, depending on the port number.

4. Under **Specific local ports**, enter the port number, click **Next**.

5. Click **Allow the Connection** and then click **Next**.

6. Select one or more network types to enable for the port and click **Next**.

    The type you select must include the network to which the remote computer is connected.
7. Add the name (for example, **msvsmon**, **IIS**, or **Web Deploy**) for the rule and click **Finish**.

    You should see your new rule in the Inbound Rules or Outbound Rules list.

## <a name="troubleshooting"></a>Troubleshooting

If you are having trouble attaching to your app with the remote debugger, you may need to verify that the correct ports are open.

### Verify that ports are open in the Windows Firewall on the Visual Studio Computer  
 The instructions for configuring the Windows firewall differ slightly on different operating systems. On Windows 8/8.1, Windows 10, and Windows Server 2012, the word **app** is used; on Windows 7 or Windows Server 2008, the word **program** is used;  In the following steps we will use the word **app**.  
  
1.  Open the Windows Firewall page. (In the **Start** menu search box, type **Windows Firewall**).  
  
2.  Click **Allow an app or feature through Windows Firewall**.  
  
3.  In the **Allowed apps and features** list, look for **Visual Studio Remote Debugger Discovery**. If it is listed, make sure that it is selected, and that one or more network types are also selected.  
  
4.  If **Visual Studio Remote Debugger Discovery** is not listed, click **Allow another app**. If you still don't see it in the **Add an app** window, click **Browse** and navigate to **\<Visual Studio installation directory>\Common7\IDE\Remote Debugger**. Find the appropriate folder for the application (x86, x64, Appx) and then select **msvsmon.exe**. Then click **Add**.  
  
5.  In the **Allowed apps and features** list, select **Visual Studio Remote Debugger**. Check one or more network types (**Domain, Home/Work (Private), Public**) that you want the remote debugging monitor to communicate with. The types must include the network to which the Visual Studio computer is connected. 

### Verify that ports are open in the Windows Firewall on the remote computer  
 The remote debugging components can be installed on the remote computer or run from a shared directory. The firewall of the remote computer must be configured in both cases. The remote debugging components are located in:  
  
 **\<Visual Studio installation directory>\Common7\IDE\Remote Debugger**  
  
 The instructions for configuring the Windows firewall differ slightly on different operating systems. On Windows 8/8.1, Windows 10, and Windows Server 2012, the word **app** is used; on Windows 7 or Windows Server 2008, the word **program** is used;  In the following steps we will use the word **app**.  
  
1.  Open the Windows Firewall page. (On the **Start** menu search box, type **Windows Firewall**.)  
  
2.  Click **Allow an app or feature through Windows Firewall**.  
  
3.  In the **Allowed apps and features** list, look for **Visual Studio Remote Debugger**. If it is listed, make sure that it is selected, and that one or more network types are also selected.  
  
4.  If **Visual Studio Remote Debugger** is not listed, click **Allow another app**. If you still don't see it in the **Add an app window**, click **Browse** and navigate to **\<Visual Studio installation directory>\Common7\IDE\Remote Debugger**. Find the appropriate folder for the application (x86, x64, Appx) and then select **msvsmon.exe**. Then click **Add**.  
  
5.  In the **Allowed apps** list, select **Visual Studio Remote Debugger**. Check one or more network types (**Domain, Home/Work (Private), Public**) that you want the remote debugging monitor to communicate with. The types must include the network to which the Visual Studio computer is connected. 

### (Managed or native compatibility mode) Open additional ports on the remote computer

If you are using compatibility mode for the debugger (**Tools > Options > Debugging**), additional ports will need to be opened. Compatibility mode enables a legacy version of the debugger and different ports are required.

> [!NOTE]
> The legacy version of the debugger is the Visual Studio 2010 debugger.
  
|||||  
|-|-|-|-|  
|**Ports**|**Incoming/Outgoing**|**Protocol**|**Description**|  
|135, 139, 445|Outgoing|TCP|Required.|  
|137, 138|Outgoing|UDP|Required.|  
|500, 4500|Outgoing|UDP|Required if your domain policy requires network communication to be performed through IPSec.|  
|80|Outgoing|TCP|Required for Web Server debugging.|
  
## See Also  
 [Remote Debugging](../debugger/remote-debugging.md)