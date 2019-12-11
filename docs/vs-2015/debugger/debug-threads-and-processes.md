---
title: "Debug Threads and Processes | Microsoft Docs"
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
  - "multiprocess debugging"
  - "threading [Visual Studio], debugging"
  - "processes, debugging"
  - "debugging threads"
  - "debugging [Visual Studio], threads"
ms.assetid: 9f0c8505-b6b2-452b-adfd-076db14d8115
caps.latest.revision: 18
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Debug Threads and Processes
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Threads* and *processes* are related concepts in computer science. Both represent sequences of instructions that must execute in a specific order. Instructions in separate threads or processes, however, can execute in parallel.  
  
 Processes exist in the operating system and correspond to what users see as programs or applications. A thread, on the other hand, exists within a process. For this reason, threads are sometimes referred to as *light-weight processes*. Each process consists of one or more threads.  
  
 The existence of multiple processes enables a computer to perform more than one task at a time. The existence of multiple threads enables a process to separate work to be performed in parallel. On a computer with multiprocessors, processes or threads can run on different processors. This enables true parallel processing.  
  
 Perfect parallel processing is not always possible. Threads sometimes must be synchronized. One thread may have to wait for a result from another thread, or one thread may need exclusive access to a resource that another thread is using. Synchronization problems are a common cause of bugs in multithreaded applications. Sometimes threads may end up waiting for a resource that never becomes available. This results in a condition called *deadlock*.  
  
 The [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] debugger provides powerful but easy-to-use tools for debugging threads and processes.  
  
## Tools for Debugging Threads and Processes in Visual Studio  
 The primary tools for working with processes in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] are the **Attach to Process** dialog box, the **Processes** window, and the **Debug Location** toolbar. The primary tools for debugging threads are the **Threads** window, thread markers in source windows, and the **Debug Location** toolbar.  
  
 The primary tools for debugging multithreaded applications are the **Parallel Stacks** and **Parallel Tasks**, **Parallel Watch**, and **GPU Threads** windows.  
  
 The following table shows the information available and the actions you can perform in each of these places:  
  
|User Interface|Information Available|Actions You Can Perform|  
|--------------------|---------------------------|-----------------------------|  
|**Attach to Process** dialog box|Available Processes you can attach to:<br /><br /> -   Process name (.exe)<br />-   Process ID number<br />-   Menubar Title<br />-   Type (Managed v4.0; Managed v2.0, v1.1, v1.0; x86; x64; IA64)<br />-   User Name (account name)<br />-   Session number|Select a process to attach to<br /><br /> Select a remote computer<br /><br /> Change transport type for connecting to remote computers|  
|**Processes** window|Attached Processes:<br /><br /> -   Process Name<br />-   Process ID number<br />-   Path to process .exe<br />-   Menubar Title<br />-   State (Break. Running)<br />-   Debugging (Native, Managed, and so on.)<br />-   Transport type (default, native with no authentication)<br />-   Transport Qualifier (remote computer)|Tools:<br /><br /> -   Attach<br />-   Detach<br />-   Terminate<br /><br /> Shortcut menu:<br /><br /> -   Attach<br />-   Detach<br />-   Detach when debugging stopped<br />-   Terminate|  
|**Threads** window|Threads in current process:<br /><br /> -   Thread ID<br />-   Managed ID<br />-   Category (main thread, interface thread, remote procedure call handler, or worker thread)<br />-   Thread Name<br />-   Location where thread is created<br />-   Priority<br />-   Affinity Mask<br />-   Suspended Count<br />-   Process Name<br />-   Flag Indicator<br />-   Suspended indicator|Tools:<br /><br /> -   Search<br />-   Search Call Stack<br />-   Flag Just My Code<br />-   Flag Custom Module Selection<br />-   Group by<br />-   Columns<br />-   Expand/Collapse callstacks<br />-   Expand/Collapse groups<br />-   Freeze/Thaw Threads<br /><br /> Shortcut menu:<br /><br /> -   Show threads in source<br />-   Switch to a thread<br />-   Freeze a running thread<br />-   Thaw a frozen thread<br />-   Flag a thread for additional study<br />-   Unflag a thread<br />-   Rename a thread<br />-   Show and hide threads<br /><br /> Other actions:<br /><br /> -   View the call stack for a thread in a DataTip|  
|Source window|Thread indicators in left gutter indicate single or multiple threads (off by default, turned on by using shortcut menu in **Threads** window)|Shortcut menu:<br /><br /> -   Switch to a thread<br />-   Flag a thread for additional study<br />-   Unflag a thread|  
|**Debug Location** toolbar|-   Current process<br />-   Suspend the application<br />-   Resume the application<br />-   Suspend and shut down the application<br />-   Current thread<br />-   Toggle current thread flag state<br />-   Show only flagged threads<br />-   Show only current process<br />-   Current stack frame|-   Switch to another process<br />-   Suspend, resume, or shut down the application<br />-   Switch to another thread in current process<br />-   Switch to another stack frame in current thread<br />-   Flag or unflag current threads<br />-   Show only flagged threads<br />-   Show only the current process|  
|**Parallel Stacks** window|-   Call stacks for multiple threads in one window.<br />-   Active stack frame for each thread.<br />-   Callers and callees for any method.|-   Filter out specified threads<br />-   Switch to Parallel Tasks view<br />-   Flag or unflag a thread<br />-   Zoom|  
|**Parallel Tasks** window|-   View information about <xref:System.Threading.Tasks.Task> objects including task ID, task status (scheduled, running, waiting, deadlocked), and which thread is assigned to the task.<br />-   Current location in call stack.<br />-   Delegate passed to the task at creation time|-   Switch to current task<br />-   Flag or unflag a task<br />-   Freeze or thaw a task|  
|**Parallel Watch** window|-   The flag column, in which you can mark a thread that you want to pay special attention to.<br />-   The frame column, in which an arrow indicates the selected frame.<br />-   A configurable column that can display the machine, process, tile, task, and thread.|-   Flag or unflag a thread<br />-   Display only flagged threads<br />-   Switch frames<br />-   Sort a column<br />-   Group threads<br />-   Freeze or thaw threads<br />-   export the data in the Parallel Watch window|  
|**GPU Threads** window|-   The flag column, in which you can mark a thread that you want to pay special attention to.<br />-   The active thread column, in which a yellow arrow indicates an active thread. An arrow indicates a thread where execution broke into the debugger.<br />-   The **Thread Count** column, which displays the number of threads at the same location.<br />-   The **Line** column, which displays the line of code where each group of threads is located.<br />-   The **Address** column, which displays the instruction address where each group of threads is located.<br />-   The **Location** column, which is the location in the code of the address.<br />-   The **Status** column, which shows whether the thread is active or blocked.<br />-   The **Tile** column, which shows the tile index for the threads in the row.|-   Change to a different active thread<br />-   Display a particular tile and thread<br />-   Display or hide a column<br />-   Sort by a column<br />-   Group threads<br />-   Freeze or thaw threads<br />-   Flag or unflag a thread<br />-   Display only flagged threads|  
  
## See Also  
 [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md)   
 [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)   
 [Debugging GPU Code](../debugger/debugging-gpu-code.md)
