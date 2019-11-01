---
title: "Configure the Windows Firewall for Remote Debugging | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 66e3230a-d195-4473-bbce-8ca198516014
caps.latest.revision: 6
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Configure the Windows Firewall for Remote Debugging
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic describes how to configure the firewall to enable remote debugging on computers that run the following operating systems:  
  
- Windows 7  
  
- Windows 8/8.1  
  
- Windows 10  
  
- Windows Server 2008 (R2)  
  
- Windows Server 2012  
  
- Windows Server 2012 R2  
  
  If the network on which you are debugging is not protected by a firewall, this configuration is unnecessary. Otherwise, both the computer that hosts Visual Studio and the remote computer that is to be debugged require changes to the firewall configuration.  
  
  **IPSec** If your network requires that communication be performed using IPSec, you must open additional ports on both the Visual Studio host computer and the remote computer.  
  
  **Web Server** If you are debugging a remote Web server, you must open an additional port on the remote computer.  
  
  Note that both computers do not have to run the same operating system. For example, the Visual Studio computer can run Windows 10 and the remote computer can run Windows Server 2012 R2.  
  
## To Configure Windows Firewall on the Visual Studio Computer  
 The instructions for configuring the Windows firewall differ slightly on different operating systems. On Windows 7 or Windows Server 2008, the word **program** is used; on Windows 8/8.1, Windows 10, and Windows Server 2012, the word **app** is used.  In the following steps we will use the word **app**.  
  
1. Open the Windows Firewall page. (In the **Start** menu search box, type **Windows Firewall**).  
  
2. Click **Allow an app or feature through Windows Firewall**.  
  
3. In the **Allowed apps and features** list, look for **Visual Studio Remote Debugger Discovery**. If it is listed, make sure that it is selected, and that one or more network types are also selected.  
  
4. If **Visual Studio Remote Debugger Discovery** is not listed, click **Allow another app**. If you still don’t see it in the **Add an app** window, click **Browse** and navigate to **\<Visual Studio installation directory>\Common7\IDE\Remote Debugger**. Find the appropriate folder for the application (x86, x64, Appx) and then select **msvsmon.exe**. Then click **Add**.  
  
5. In the **Allowed apps and features** list, select **Visual Studio Remote Debugging Monitor**. Check one or more network types (**Domain, Home/Work (Private), Public**) that you want the remote debugging monitor to communicate with. The types must include the network to which the Visual Studio computer is connected.  
  
## To open a port on the Visual Studio computer to enable discovery  
 You must allow UDP port 3702 incoming to allow discovery of the computer(s) running the remote debugger. To add it, see How to Configure Ports in a Firewall.  
  
## To configure the Windows firewall of the remote computer for remote debugging  
 The remote debugging components can be installed on the remote computer or run from a shared directory. The firewall of the remote computer must be configured in both cases. The remote debugging components are located in:  
  
 **\<Visual Studio installation directory>\Common7\IDE\Remote Debugger**  
  
 The instructions for configuring the Windows firewall differ slightly on different operating systems. On Windows 7 or Windows Server 2008, the word **program** is used; on Windows 8/8.1, Windows 10, and Windows Server 2012, the word **app** is used.  In the following steps we will use the word **app**.  
  
1. Open the Windows Firewall page. (On the **Start** menu search box, type **Windows Firewall**.)  
  
2. Click **Allow an app or feature through Windows Firewall**.  
  
3. In the **Allowed apps and features** list, look for **Visual Studio Remote Debugging Monitor**. If it is listed, make sure that it is selected, and that one or more network types are also selected.  
  
4. If **Visual Studio Remote Debugging Monitor** is not listed, click **Allow another app**. If you still don’t see it in the **Add an app window**, click **Browse** and navigate to **\<Visual Studio installation directory>\Common7\IDE\Remote Debugger**. Find the appropriate folder for the application (x86, x64, Appx) and then select **msvsmon.exe**. Then click **Add**.  
  
5. In the **Allowed apps** list, select **Visual Studio Remote Debugging Monitor**. Check one or more network types (**Domain, Home/Work (Private), Public**) that you want the remote debugging monitor to communicate with. The types must include the network to which the Visual Studio computer is connected.  
  
## Ports on the remote computer that enable remote debugging  
  
|||||  
|-|-|-|-|  
|**Ports**|**Incoming/Outgoing**|**Protocol**|**Description**|  
|3702|Outgoing|UDP|Required for remote debugger discovery.|  
|4020||TCP|For VS 2015. The port number is incremented by 2 for each Visual Studio version. For more information, see  Visual Studio Remote Debugger Port Assignments.|  
|4021||TCP|For VS 2015. The port number is incremented by 2 for each Visual Studio version. For more information, see  Visual Studio Remote Debugger Port Assignments.|  
  
## Ports on the remote computer that enable remote debugging with managed or native compatibility mode  
  
|||||  
|-|-|-|-|  
|**Ports**|**Incoming/Outgoing**|**Protocol**|**Description**|  
|135, 139, 445|Outgoing|TCP|Required.|  
|137, 138|Outgoing|UDP|Required.|  
|500, 4500|Outgoing|UDP|Required if your domain policy requires network communication to be performed through IPSec.|  
|80|Outgoing|TCP|Required for Web Server debugging.|  
  
## How to Configure Ports in Windows Firewall  
  
1. On the **Start** menu, search for **Windows Firewall with Advanced Security**.  
  
2. Click **Inbound Rules** or **Outbound Rules** and then click **New Rule** in the **Actions** list.  
  
3. On the **Rule Type** page, select **Port** and then click **Next**.  
  
4. On the **Protocol and Ports** page, select the port protocol (TCP or UDP). Select **Specific local ports** and enter one or more port numbers that you want to enable for the protocol. Separate numbers with commas. Then click **Next**.  
  
5. On the **Action** page, select **Allow the connection** and then click **Next**.  
  
6. On the **Profile** page, select one or more network types to enable for the port. The type you select must include the network to which the remote computer is connected. Then click **Next**.  
  
7. On the **Name** page, type a name for the rule, and then click **Finish**.  
  
8. You should see your new rule in the **Inbound Rules** or **Outbound Rules** list.  
  
## See Also  
 [Remote Debugging](../debugger/remote-debugging.md)
