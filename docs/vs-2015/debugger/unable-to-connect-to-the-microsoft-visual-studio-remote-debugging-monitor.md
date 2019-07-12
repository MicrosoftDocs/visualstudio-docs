---
title: "Unable to Connect to the Microsoft Visual Studio Remote Debugging Monitor | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.error.remote_debug"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: a1d959fc-3817-491c-831b-e6b768a3877a
caps.latest.revision: 17
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Unable to Connect to the Microsoft Visual Studio Remote Debugging Monitor
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This error message appears when you enter an invalid Visual Studio Remote Debugging Monitor name in the **Attach to Process** dialog box. The Remote Debugging Monitor name is usually the same as the machine you are attempting to connect to for remote debugging. This message may occur because the remote machine does not exist on the network, the remote debugging monitor is not properly set up on the remote machine, or the remote machine is inaccessible due to network problems or the presence of a firewall.  
  
> [!IMPORTANT]
> If you believe you have received this message because of a product bug, please report this issue to Visual Studio [Send a Smile](https://msdn.microsoft.com/library/5cc9b67a-54d0-41b0-aa8f-80dff4475a6b). If you need more help, see [Talk to Us](../ide/talk-to-us.md) for ways to contact Microsoft.  
  
## I got this message while I was debugging locally  
 If you are getting this message while you are debugging locally, your anti-virus software or a third-party firewall may be to blame. Visual Studio is a 32-bit application, so it uses the 64-bit version of the remote debugger to debug 64-bit applications. The two processes communicate using the local network within the local computer. No network traffic leaves the computer, but it is possible that third party security software may block the communication.  
  
 The following sections list some other reasons why you might have gotten this message, and what you can do to fix the issue.  
  
## To correct this error  
  
- Make sure the Visual Studio Remote Debugging Monitor is installed and running on the remote machine. For information about the remote debugger and how to install it, see [Remote Debugging](../debugger/remote-debugging.md).  
  
- In Visual Studio, look at the project properties (**Project / Properties / Debugging**). Make sure the **Remote Server Name** is correct.  
  
- Verify that the remote machine is accessible on the network.  
  
## The remote machine is not reachable  
 Try to [ping](https://technet.microsoft.com/library/ee624059\(v=ws.10\).aspx) the remote machine. If it doesn’t reply to the ping, the remote tools won’t be able to connect either. Try rebooting the remote machine and otherwise making sure that it is correctly configured on the network.  
  
## The version of the remote debugger doesn’t match the version of Visual Studio  
 The version of Visual Studio that you are running locally needs to match the version of the remote debugging monitor that is running on the remote machine. To fix this, download and install the matching version of the remote debugging monitor. Go to the [Download Center](http://www.microsoft.com/download) to find the right version of the remote debugger.  
  
## The local and remote machines have different authentication modes  
 The local and remote machines need to use the same authentication mode. To fix this, make sure that both machines are using the same authentication mode. You can change the authentication mode on the remote debugger in the **Tools / Options** dialog.  
  
 For more information about authentication modes, see [Windows Authentication Overview](https://technet.microsoft.com/library/hh831472.aspx).  
  
## The remote debugger is running under a different user account  
 You can solve this in one of the following ways:  
  
- You can stop the remote debugger and restart it with the account you are using on the local computer.  
  
- You can start the remote debugger from the command line with the **/allow \<username>** parameter: `msvsmon /allow <username@computer>`  
  
- You can add the user to the remote debugger's permissions (in the remote debugger window, **Tools / Permissions**).  
  
- If you can't use the methods in the preceding steps, you can allow any user to do remote debugging. In the remote debugger window, go to the **Tools /Options** dialog. When you select   **No Authentication**, you can then check **Allow any user to debug**. However, you should use this option only if you have no choice, or if you are on a private network.  
  
## The firewall on the remote machine doesn’t allow incoming connections to the remote debugger  
 The firewall on the Visual Studio machine and the firewall on the remote machine must be configured to allow communication between Visual Studio and the remote debugger. For information about the ports the remote debugger is using, see [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md). For information about configuring the Windows firewall, see [Configure the Windows Firewall for Remote Debugging](../debugger/configure-the-windows-firewall-for-remote-debugging.md).  
  
## Anti-virus software is blocking the connections  
 Windows anti-virus software allows remote debugger connections, but some third-party anti-virus software may block them. Check the documentation for your anti-virus software to find out how to allow these connections.  
  
## Network security policy is blocking communication between the remote machine and Visual Studio  
 Review your network security to make sure that it is not blocking communication. For more information about Windows network security policy, see [Security Management](https://msdn.microsoft.com/library/windows/desktop/ms721855\(v=vs.85\).aspx).  
  
## The network is too busy to support remote debugging  
 You may need to do remote debugging at a different time, or reschedule work on the network for a different time.  
  
## More help  
 To get more remote debugger help, including command-line switches, open the following in a browser:  
  
 **res://C:\Program%20Files\Microsoft%20Visual%20Studio%2014.0\Common7\IDE\Remote%20Debugger\x64\msvsmon.exe/help.htm**  
  
## See Also  
 [Remote Debugging](../debugger/remote-debugging.md)
