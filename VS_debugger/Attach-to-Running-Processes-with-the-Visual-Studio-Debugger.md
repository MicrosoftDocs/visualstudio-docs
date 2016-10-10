---
title: "Attach to Running Processes with the Visual Studio Debugger"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - C++
  - CSharp
  - FSharp
  - VB
  - c++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 27900e58-090c-4211-a309-b3e1496d5824
caps.latest.revision: 43
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Attach to Running Processes with the Visual Studio Debugger
You can attach the Visual Studio debugger to a running process on a local or remote computer. After the process is running, click **Debug / Attach to Process** (or press **CTRL+ALT+P**) to open the **Attach to Process** dialog box.  
  
 You can use this capability to  debug apps that are running on a local or remote computer, debug multiple processes simultaneously, or debug an application that was not created in Visual Studio.  
  
> [!NOTE]
>  If you want to debug ASP.NET applications that have been deployed to IIS, see [Remote Debugging ASP.NET on a Remote IIS 7.5 Computer](../VS_debugger/Remote-Debugging-ASP.NET-on-a-Remote-IIS-7.5-Computer.md) for IIS 7 or [Publish to IIS](https://docs.asp.net/en/latest/publishing/iis.html) for IIS 8.  
  
> [!WARNING]
>  To attach to a Windows Universal app that is written in JavaScript, you must first enable debugging for the app. See [Attach the debugger](../VS_debugger/Start-a-debugging-session-for-Store-Apps-in-Visual-Studio--JavaScript-.md#BKMK_Attach_the_debugger) in the Windows Dev Center.  
  
> [!NOTE]
>  For the debugger to attach to code written in C++, the code needs to emit `DebuggableAttribute`. You can add this to your code automatically by linking with the [/ASSEMBLYDEBUG](../Topic/-ASSEMBLYDEBUG%20\(Add%20DebuggableAttribute\).md) linker option.  
  
##  <a name="BKMK_Attach_to_a_running_process"></a> Attach to a running process on the local machine  
 In order to attach to a process, you must know the name of the process.  You may be able to find the name of the process in the Task Manager.  
  
1.  In Visual Studio, select **Debug / Attach to Process**.  
  
2.  In the **Attach to Process** dialog box, find the program that you want to attach to from the **Available Processes** list.  
  
     If the process is running under a different user account, select the **Show processes from all users** check box.  
  
3.  In the **Attach to** box, make sure that the type of code you will debug is listed. The default **Automatic** setting tries to determine what type of code you want to debug. To set the type of code manually, do the following  
  
    1.  In the **Attach to** box, click **Select**.  
  
    2.  In the **Select Code Type** dialog box, click **Debug these code types** and select the types to debug.  
  
    3.  Click **OK**.  
  
4.  Click **Attach**.  
  
     The **Available Processes** list is displayed automatically when you open the **Processes** dialog box. Processes can start and stop in the background while the dialog box is open. However, the contents are not always current. You can refresh the list at any time to see the current list of processes by clicking **Refresh**.  
  
     You can be attached to multiple programs when you are debugging, but only one program is active in the debugger at any time. You can set the active program in the **Debug Location** toolbar or the **Processes** window. For more information, see [How to: Set the Current Program](assetId:///7e1d7fa5-0e40-44cf-8c41-d3dba31c969e).  
  
     If you try to attach to a process owned by an untrusted user account, a security warning dialog box confirmation will appear. For more information see [Security Warning: Attaching to a process owned by an untrusted user can be dangerous. If the following information looks suspicious or you are unsure, do not attach to this process](../VS_debugger/Security-Warning--Attaching-to-a-process-owned-by-an-untrusted-user-can-be-dangerous.-If-the-following-information-looks-suspicious-or-you-are-unsure--do-not-attach-to-this-process.md).  
  
     In some cases, when you debug in a Remote Desktop (Terminal Services) session, the **Available Processes** list will not display all available processes. If you are running Visual Studio as a user who has a limited user account, the **Available Processes** list will not show processes that are running in Session 0, which is used for services and other server processes, including w3wp.exe. You can solve the problem by running Visual Studio under an administrator account or by running Visual Studio from the server console instead of a Terminal Services session. If neither of those workarounds is possible, a third option is to attach to the process by running `vsjitdebugger.exe -p` *ProcessId* from the Windows command line. You can determine the process id using tlist.exe. To obtain tlist.exe, download and install Debugging Tools for Windows, available at  [WDK and WinDbg downloads](http://go.microsoft.com/fwlink/?LinkId=168279).  
  
##  <a name="BKMK_Attach_to_a_process_on_a_remote_computer"></a> Attach to a process on a remote computer  
 In order to attach to a process, you must know the name of the process. For ASP.NET apps that have been deployed to IIS, see [Remote Debugging ASP.NET on a Remote IIS 7.5 Computer](../VS_debugger/Remote-Debugging-ASP.NET-on-a-Remote-IIS-7.5-Computer.md) for IIS 7 or [Publish to IIS](https://docs.asp.net/en/latest/publishing/iis.html) for IIS 8. For other apps, you may be able to find the name of the process in the Task Manager.  
  
 When you use the **Attach to Process** dialog box, you can select another computer that has been set up for remote debugging. For more information, see [Set Up the Remote Tools on the Device](../Topic/Set%20Up%20the%20Remote%20Tools%20on%20the%20Device.md). When you have selected a remote computer, you can view a list of available processes running on that computer and attach to one or more of the processes for debugging.  
  
 **To select a remote computer:**  
  
1.  In the **Attach to Process** dialog box, select the appropriate connection type from the **Transport** list. **Default** is the correct setting for most cases.  
  
2.  Use the **Qualifier** list box to choose the remote computer name by one of the following methods:  
  
    1.  Type the name in the **Qualifier** list box.  
  
    2.  Click the drop-down arrow attached to the **Qualifier** list box and select the computer name from the drop-down list.  
  
    3.  Click the **Find** button next to the**Qualifier** list to open the **Select Remote Debugger Connection** dialog box. The **Select Remote Debugger Connection** dialog box lists all the devices that are on your local sub-net, and any device that is directly attached to your computer through an Ethernet cable. Click the computer or device that you want, and then click **Select**.  
  
     The **Transport** setting persists between debugging sessions. The **Qualifier** setting persists between debugging sessions only if a successful debugging connection occurs with that qualifier.  
  
##  <a name="BKMK_Troubleshoot_attach_errors"></a> Troubleshoot attach errors  
 When the debugger attaches to a running process, the process can contain one or more types of code. The code types the debugger can attach to are displayed and selected in the **Select Code Type** dialog box.  
  
 Sometimes, the debugger can successfully attach to one code type, but not to another code type. This might occur if you are trying to attach to a process that is running on a remote computer. The remote computer might have remote debugging components installed for some code types but not for others. It can also occur if you try to attach to two or more processes for direct database debugging. SQL debugging supports attaching to a single process only.  
  
 If the debugger is able to attach to some, but not all, code types, you will see a message identifying which types failed to attach.  
  
 If the debugger successfully attaches to at least one code type, you can proceed to debug the process. You will be able to debug only the code types that were successfully attached. The preceding example message shows that the script code type failed to attach. Therefore, you would not be able to debug script code within the process. The script code in the process would still run, but you would not be able to set breakpoints, view data, or perform other debugging operations in the Script.  
  
 If you want more specific information about why the debugger failed to attach to a code type, you can try to reattach to only that code type.  
  
 **To obtain specific information about why a code type failed to attach**  
  
1.  Detach from the process. On the **Debug** menu, click **Detach All**.  
  
2.  Reattach to the process, selecting only a single code type.  
  
    1.  In the **Attach to Process** dialog box, select the process in the **Available Processes** list.  
  
    2.  Click **Select**.  
  
    3.  In the **Select Code Type** dialog box, select **Debug these code types** and the code type that failed to attach. Clear any other code.  
  
    4.  Click **OK**. The **Select Code Type** dialog box closes.  
  
    5.  In the **Attach to Process** dialog box, click **Attach**.  
  
     This time, the attach will fail completely, and you will get a specific error message.  
  
## See Also  
 [Debug Multiple Processes](../VS_debugger/Debug-Multiple-Processes.md)   
 [Just-In-Time Debugging](../VS_debugger/Just-In-Time-Debugging-in-Visual-Studio.md)   
 [Remote Debugging](../VS_debugger/Remote-Debugging.md)