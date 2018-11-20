---
title: "Debug Multiple Processes | Microsoft Docs"
ms.custom: ""
ms.date: "11/20/2018"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
f1_keywords: 
  - "vs.debug.programs"
  - "vs.debug.processes.attaching"
  - "vs.debug.activeprogram"
  - "vs.debug.attaching"
  - "vs.debug.attachedprocesses"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
ms.assetid: bde37134-66af-4273-b02e-05b3370c31ab
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# Debug multiple processes

When you debug a Visual Studio solution that has multiple processes, you can start and switch between processes, break, continue, and step through source, stop debugging, and terminate or detach from individual processes.  
  
<a name="BKMK_Start_multiple_processes_in_a_VS_solution__attach_to_a_process__automatically_start_a_process_in_the_debugger"></a>
##  Start debugging with multiple processes 

###  <a name="BKMK_Start_debugging_multiple_processes_in_a_Visual_Studio_solution"></a> Start debugging multiple processes in a Visual Studio solution  

When more than one project in a Visual Studio solution can run independently, you can select which project the debugger starts. The current startup project appears in bold in **Solution Explorer**. 
<a name="BKMK_Change_the_startup_project"></a
To change the startup project from **Solution Explorer**, right-click a different project and select **Set as StartUp Project**.
<a name="BKMK_Start_a_specific_project_in_a_solution"></a>
To start debugging a project from **Solution Explorer** without making it the startup project, right-click the project and select **Debug** > **Start new instance** or **Step into new instance**. 
<a name="BKMK_Start_multiple_projects_in_a_solution"></a>
**To set the startup project or multiple projects from the solution Properties page:**

1. Select the solution in **Solution Explorer** and then select the **Properties** icon in the toolbar, or right-click the solution and select **Properties**.  
   
1. On the **Properties** page, select **Common Properties** > **Startup Project**.
   
   ![Changing the startup type for a project](../debugger/media/dbg_execution_startmultipleprojects.png "DBG_Execution_StartMultipleProjects")  
   
1. You can select **Current selection**, *Single startup project** and then any of the project files from the dropdown, or **Multiple startup projects**. 

   If you select **Multiple startup projects**, you can change the startup order and action to take for each project: **Start**, **Start without debugging**, or **None**.  
   
1. Select **Apply**, or **OK** to apply and close the dialog. 

###  <a name="BKMK_Attach_to_a_process"></a> Attach to a process  

The debugger can also *attach* to apps running in processes outside of Visual Studio, including on remote devices. After you attach to an app, you can use the Visual Studio debugger. Debugging features might be limited, depending on whether the app was built with debug information, whether you have access to the app's source code, and whether the JIT compiler is tracking debug information.  
  
For more information, see [Attach to running processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md).  
  
**To attach to a process running on your local machine:**  
  
1. With the app running, select **Debug** > **Attach to Process**. 

   ![Attach to Process dialog box](../debugger/media/dbg_attachtoprocessdlg.png "Attach to Process dialog box")  
  
1. In the **Attach to Process** dialog box, select the process from the **Available Processes** list, and then select **Attach**.  
  
>[!NOTE]
>The debugger does not automatically attach to a child process that is started by a debugged process, even if the child project is in the same solution. To debug a child process, either attach to the child process after it starts, or configure the Windows Registry Editor to start the child process in a new debugger instance.  
  
###  <a name="BKMK_Automatically_start_an_process_in_the_debugger"></a> Use the Registry Editor to automatically start a process in the debugger  

Sometimes, you might need to debug the startup code for an app that is launched by another process. Examples include services and custom setup actions. You can have the debugger launch and automatically attach to the app. 

1. Start the Windows Registry Editor by running *regedit.exe*.  
   
1. In Registry Editor, navigate to **HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\Image File Execution Options**.  
  
1. Select the folder of the app that you want to start in the debugger.  
   
   If the app is not listed as a child folder, select **Image File Execution Options**, and then select **New** > **Key**. Select the new key, select **Rename** on the shortcut menu, and then enter the name of the app.  
   
1. On the context menu of the app folder, choose **New** > **String Value**.  
   
1. Change the name of the new value from **New Value** to `debugger`.  
   
1. On the context menu of the **debugger** entry, select **Modify**.  
   
1. In the **Edit String** dialog box, type `vsjitdebugger.exe` in the **Value data** box.  
  
   ![Edit String dialog box](../debugger/media/dbg_execution_automaticstart_editstringdlg.png "Edit String dialog box")  
   
   ![Automatic debugger start entry in regedit.exe](../debugger/media/dbg_execution_automaticstart_result.png "Automatic debugger start entry in regedit.exe")  
   
##  <a name="BKMK_Switch_processes__break_and_continue_execution__step_through_source"></a> Debug with multiple processes 
<a name="BKMK_Configure_the_execution_behavior_of_multiple_processes"></a> 

When debugging an app with multiple processes, the breaking, stepping, and stopping debugger commands affect all the processes by default. For example, when a process is suspended at a breakpoint, the execution of all other processes is also suspended. You can change this default behavior to gain more control over the targets of execution commands.  

Under **Tools** (or **Debug**) > **Options** > **Debugging** > General** page, select or clear the **Break all processes when one process breaks** check box.  
  
###  <a name="BKMK_Break__step__and_continue_commands"></a> Break, step, and continue commands  
  
The following table describes the behaviors of debugging commands when the **Break all processes when one process breaks** check box is selected or deselected:

|**Command**|Break all processes when one process breaks selected|Break all processes when one process breaks deselected|  
|-|-|-|  
|**Debug**  > **Break All**|All processes break.|All processes break.|  
|**Debug** > **Continue**|All processes resume.|All suspended processes resume.|  
|**Debug** > **Step Into**, **Step Over**, or **Step Out**|All processes run while current process steps. <br />Then all processes break.|Current process steps. <br />Suspended processes resume. <br />Running processes continue.|  
|**Debug** > **Step Into Current Process**, **Step Over Current Process**, or **Step Out Current Process**|N/A|Current process steps.<br />Other processes maintain their existing state (suspended or running).|  
|Source window **Breakpoint**|All processes break.|Only source window process breaks.|  
|Source window **Run to cursor**<br />The source window must be in the current process.|All processes run while source window process runs to cursor and then breaks.<br />Then all other processes break.|Source window process runs to cursor.<br />Other processes maintain their existing state (suspended or running).|  
|**Processes** window > **Break Process**|N/A|Selected process breaks.<br />Other processes maintain their existing state (suspended or running).|  
|**Processes** window > **Continue Process**|N/A|Selected process resumes.<br />Other processes maintain their existing state (suspended or running).|  

###  <a name="BKMK_Find_the_source_and_symbol___pdb__files"></a> Find the source and symbol (.pdb) files  
To navigate the source code of a process, the debugger needs access to its source files and symbol files. For more information, see [Specify symbol (.pdb) and source files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md).  
  
If you can't access the files for a process, you can navigate by using the **Disassembly** window. For more information, see [How to: Use the Disassembly window](../debugger/how-to-use-the-disassembly-window.md).  

###  <a name="BKMK_Switch_between_processes"></a> Switch between processes  

You can attach to multiple processes when you are debugging, but only one process is active in the debugger at any given time. You can set the active or *current* process in the **Debug Location** toolbar or in the **Processes** window. To switch between processes, both processes must be in break mode.  
  
**To set the current process from the Debug Location toolbar:**  
  
1. To open the **Debug Location** toolbar, select **View** > **Toolbars** > **Debug Location**.  
   
1. On the **Debug Location** toolbar, select the process you want to set as the current process from the **Process** dropdown.  
  
   ![Switch between processes](../debugger/media/dbg_execution_switchbetweenmodules.png "DBG_Execution_SwitchBetweenModules")  
  
**To set the current process from the Processes window:**  
  
1. To open the **Processes** window, while debugging, select **Debug** > **Windows** > **Processes**. 

1. In the **Processes** window, the current process is marked by a yellow arrow. Double-click the process you want to set as the current process.  
  
   ![Processes window](../debugger/media/dbg_processeswindow.png "DBG_ProcessesWindow")  

Switching to a process sets it as the current process for debugging purposes. Debugger windows show the state for the current process, and stepping commands affect only the current process.  
  
##  <a name="BKMK_Stop_debugging__terminate_or_detach_from_processes"></a> Stop debugging with multiple processes  
  
By default, when you select **Debug** > **Stop Debugging**, the debugger terminates or detaches from all processes. 
  
- If the current process was launched in the debugger, the process is terminated.  
  
- If you attached the debugger to the current process, the debugger detaches from the process and leaves the process running.  
  
If you start debugging a process from a Visual Studio solution, attach to another process that is already running, and then choose **Stop Debugging**, the debugging session ends. The process that was started in Visual Studio terminates, while the process you attached to keeps running. 

>[!NOTE]
>The **Break all processes when one process breaks** debugger option does not affect stopping debugging, or terminating and detaching from processes.  
  
To control the way that **Stop Debugging** affects an individual process, in the **Processes** window, right-click a process, and then select or clear the **Detach when debugging stopped** check box.  
  
###  <a name="BKMK_Stop__terminate__and_detach_commands"></a> Stop, terminate, and detach commands  
  
The following table describes the behaviors of the debugger stop, terminate, and detach commands with multiple processes: 

|**Command**|**Description**|  
|-|-| 
|**Debug** > **Stop Debugging**|Unless the behavior is changed in the **Processes** window, processes started by the debugger are terminated, and attached processes are detached.|  
|**Debug** > **Terminate All**|All processes are terminated.|  
|**Debug** > **Detach All**|The debugger detaches from all processes.|  
|**Processes** window > **Detach Process**|The debugger detaches from the selected process.<br />Other processes maintain their existing state (suspended or running).|  
|**Processes** window > **Terminate Process**|The selected process is terminated.<br />Other processes maintain their existing state (suspended or running).|  
|**Processes** window > **Detach when debugging stops**|If selected, **Debug** > **Stop Debugging** detaches from the selected process. <br />If not selected, **Debug** > **Stop Debugging** terminates the selected process. |  
## See also  
 [Specify aymbol (.pdb) and aource files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)   
 [Attach to running processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md)   
 [Navigating through code with the debugger](../debugger/navigating-through-code-with-the-debugger.md)   
 [Just-In-Time debugging](../debugger/just-in-time-debugging-in-visual-studio.md)   
 [Debug multithreaded applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)