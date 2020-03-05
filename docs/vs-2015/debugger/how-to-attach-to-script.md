---
title: "How to: Attach to Script | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "script debugging, attaching to script"
  - "script, attaching to"
  - "processes, attaching to script"
  - "remote debugging, attaching to script"
ms.assetid: 82013e9a-ef53-4fd2-b451-a6891cdc6307
caps.latest.revision: 26
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Attach to Script
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic explains how to manually attach the Visual Studio debugger to a script file for debugging.  
  
### To attach to a running process  
  
1. On the **Debug** menu, choose **Attach to Process**. (If no project is open, choose **Attach to Process** on the **Tools** menu.)  
  
2. In the **Attach to Process** dialog box, look at the **Available Processes** list and find the script process you want to attach to. You can identify script processes by looking at the **Type** column.  
  
   1. If the process you want to debug is running on another computer, you must first select the remote computer. For more information, see [How to: Select a Remote Computer](https://msdn.microsoft.com/4332ba8e-2f0b-4f62-b96a-e762b9f3c3ba).  
  
   2. If the process is running under a different user account, select the **Show processes from all users** check box.  
  
   3. If you are connected through **Remote Desktop Connection**, select the **Show processes in all sessions** check box.  
  
3. Click the process you want to attach to.  
  
4. In the **Attach to** box, you should see **Script code** or **Automatic: Script code**. If you see anything else, follow these steps:  
  
   1. Click **Select**.  
  
   2. In the **Select Code Type** dialog box, click **Debug these code types** and select **Script**.  
  
   3. Click **OK**.  
  
5. Click **Attach**.  
  
    At this point, you might see a warning telling you that script debugging is disabled in Internet Explorer. If that occurs, see [Warning: Script Debugging Disabled](../debugger/warning-script-debugging-disabled.md).  
  
   The **Available Processes** list is displayed automatically when you open the **Processes** dialog box. Processes can start and stop in the background while the dialog box is open. Therefore, the contents might not always be current. You can refresh the list at any time to see the current list of processes by pressing the **Refresh** button.  
  
   You can be attached to multiple programs when you are debugging, but only one program is active in the debugger at any time. You can set the active program in the Debug Location toolbar. For more information, see [How to: Set the Current Process](https://msdn.microsoft.com/7e1d7fa5-0e40-44cf-8c41-d3dba31c969e).  
  
   All **Debug** menu execution commands affect the active program. You can break any debugged program from the Processes dialog box.See [Using Breakpoints](../debugger/using-breakpoints.md).  
  
> [!NOTE]
> If you try to attach to a process that is owned by an untrusted user account, a security warning dialog confirmation will appear. For more information, see [Security Warning: Attaching to a process owned by an untrusted user can be dangerous. If the following information looks suspicious or you are unsure, do not attach to this process](/visualstudio/debugger/security-warning-attaching-to-a-process-owned-by-an-untrusted-user?view=vs-2015).  
  
 In some cases, when you are debugging in a Terminal Services (Remote Desktop) session, the Available Processes list will not display all available processes. On [!INCLUDE[WinXPSvr](../includes/winxpsvr-md.md)] or later versions, if you are running Visual Studio as a limited user, the Available Processes list will not show processes running in Session 0, which is used for services and other server processes, including w3wp.exe. You can solve the problem by running Visual Studio under an administrator account or by running Visual Studio from the server console rather than a Terminal Services session. If neither of those workarounds is possible, a third option is to attach to the process by typing vsjitdebugger.exe -p ProcessId at the Windows command line. You can determine the process id by using tlist.exe. To obtain tlist.exe, download and install Debugging Tools for Windows, available at [Windows Hardware Developer Central](https://developer.microsoft.com/windows/hardware).  
  
## See Also  
 [Client-Side Script Debugging](../debugger/client-side-script-debugging.md)   
 [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md)   
 [Security Warning: Attaching to a process owned by an untrusted user can be dangerous. If the following information looks suspicious or you are unsure, do not attach to this process](/visualstudio/debugger/security-warning-attaching-to-a-process-owned-by-an-untrusted-user?view=vs-2015)   
 [Debugger Security](../debugger/debugger-security.md)
