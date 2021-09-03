---
title: "Tools to debug threads and processes | Microsoft Docs"
description: Review tools to debug threads and processes in Visual Studio. Threads and processes represent sequences of instructions that must execute in a specific order.
ms.custom: SEO-VS-2020
ms.date: "04/21/2018"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "multiprocess debugging"
  - "threading [Visual Studio], debugging"
  - "processes, debugging"
  - "debugging threads"
  - "debugging [Visual Studio], threads"
ms.assetid: 9f0c8505-b6b2-452b-adfd-076db14d8115
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Tools to debug threads and processes in Visual Studio
*Threads* and *processes* are related concepts in computer science. Both represent sequences of instructions that must execute in a specific order. Instructions in separate threads or processes, however, can execute in parallel.

 Processes exist in the operating system and correspond to what users see as programs or applications. A thread, on the other hand, exists within a process. For this reason, threads are sometimes referred to as *light-weight processes*. Each process consists of one or more threads.

 The existence of multiple processes enables a computer to perform more than one task at a time. The existence of multiple threads enables a process to separate work to be performed in parallel. On a computer with multiprocessors, processes or threads can run on different processors. This enables true parallel processing.

 Perfect parallel processing is not always possible. Threads sometimes must be synchronized. One thread may have to wait for a result from another thread, or one thread may need exclusive access to a resource that another thread is using. Synchronization problems are a common cause of bugs in multithreaded applications. Sometimes threads may end up waiting for a resource that never becomes available. This results in a condition called *deadlock*.

 The [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] debugger provides powerful but easy-to-use tools for debugging threads and processes.

## Tools and features
The tools you need to use in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] depend on what type of code you are trying to debug:

- For processes, the primary tools are the **Attach to Process** dialog box, the **Processes** window, and the **Debug Location** toolbar.

- For threads, the primary tools for debugging threads are the **Threads** window, thread markers in source windows, **Parallel Stacks** window, **Parallel Watch** window, and the **Debug Location** toolbar.

- For code that uses the <xref:System.Threading.Tasks.Task> in the [Task Parallel Library (TPL)](/dotnet/standard/parallel-programming/task-parallel-library-tpl), the [Concurrency Runtime](/cpp/parallel/concrt/concurrency-runtime/) (native code), the primary tools for debugging multithreaded applications are the **Parallel Stacks** window, the **Parallel Watch** window, and the **Tasks** window (the **Tasks** window also supports the JavaScript promise object).

- For debugging threads on the GPU, the primary tool is the **GPU Threads** windows.

  The following table shows the information available and the actions you can perform in each of these places:

|User Interface|Information Available|Actions You Can Perform|
|--------------------|---------------------------|-----------------------------|
|**Attach to Process** dialog box|Available Processes you can attach to:<br /><br /> -   Process name (.exe)<br />-   Process ID number<br />-   Menubar Title<br />-   Type (Managed v4.0; Managed v2.0, v1.1, v1.0; x86; x64; IA64)<br />-   User Name (account name)<br />-   Session number|Select a process to attach to<br /><br /> Select a remote computer<br /><br /> Change transport type for connecting to remote computers|
|**Processes** window|Attached Processes:<br /><br /> -   Process Name<br />-   Process ID number<br />-   Path to process .exe<br />-   Menubar Title<br />-   State (Break. Running)<br />-   Debugging (Native, Managed, and so on.)<br />-   Transport type (default, native with no authentication)<br />-   Transport Qualifier (remote computer)|Tools:<br /><br /> -   Attach<br />-   Detach<br />-   Terminate<br /><br /> Shortcut menu:<br /><br /> -   Attach<br />-   Detach<br />-   Detach when debugging stopped<br />-   Terminate|
|**Threads** window|Threads in current process:<br /><br /> -   Thread ID<br />-   Managed ID<br />-   Category (main thread, interface thread, remote procedure call handler, or worker thread)<br />-   Thread Name<br />-   Location where thread is created<br />-   Priority<br />-   Affinity Mask<br />-   Suspended Count<br />-   Process Name<br />-   Flag Indicator<br />-   Suspended indicator|Tools:<br /><br /> -   Search<br />-   Search Call Stack<br />-   Flag Just My Code<br />-   Flag Custom Module Selection<br />-   Group by<br />-   Columns<br />-   Expand/Collapse callstacks<br />-   Expand/Collapse groups<br />-   Freeze/Thaw Threads<br /><br /> Shortcut menu:<br /><br /> -   Show threads in source<br />-   Switch to a thread<br />-   Freeze a running thread<br />-   Thaw a frozen thread<br />-   Flag a thread for additional study<br />-   Unflag a thread<br />-   Rename a thread<br />-   Show and hide threads<br /><br /> Other actions:<br /><br /> -   View the call stack for a thread in a DataTip|
|Source window|Thread indicators in left gutter indicate single or multiple threads (off by default, turned on by using shortcut menu in **Threads** window)|Shortcut menu:<br /><br /> -   Switch to a thread<br />-   Flag a thread for additional study<br />-   Unflag a thread|
|**Debug Location** toolbar|-   Current process<br />-   Suspend the application<br />-   Resume the application<br />-   Suspend and shut down the application<br />-   Current thread<br />-   Toggle current thread flag state<br />-   Show only flagged threads<br />-   Show only current process<br />-   Current stack frame|-   Switch to another process<br />-   Suspend, resume, or shut down the application<br />-   Switch to another thread in current process<br />-   Switch to another stack frame in current thread<br />-   Flag or unflag current threads<br />-   Show only flagged threads<br />-   Show only the current process|
|**Parallel Stacks** window|-   Call stacks for multiple threads in one window.<br />-   Active stack frame for each thread.<br />-   Callers and callees for any method.|-   Filter out specified threads<br />-   Switch to Tasks view<br />-   Flag or unflag a thread<br />-   Zoom|
|**Parallel Watch** window|-   The flag column, in which you can mark a thread that you want to pay special attention to.<br />-   The frame column, in which an arrow indicates the selected frame.<br />-   A configurable column that can display the machine, process, tile, task, and thread.|-   Flag or unflag a thread<br />-   Display only flagged threads<br />-   Switch frames<br />-   Sort a column<br />-   Group threads<br />-   Freeze or thaw threads<br />-   export the data in the Parallel Watch window|
|**Tasks** window|-   View information about <xref:System.Threading.Tasks.Task> objects including task ID, task status (scheduled, running, waiting, deadlocked), and which thread is assigned to the task.<br />-   Current location in call stack.<br />-   Delegate passed to the task at creation time|-   Switch to current task<br />-   Flag or unflag a task<br />-   Freeze or thaw a task|
|**GPU Threads** window|-   The flag column, in which you can mark a thread that you want to pay special attention to.<br />-   The current thread column, in which a yellow arrow indicates the current thread.<br />-   The **Thread Count** column, which displays the number of threads at the same location.<br />-   The **Line** column, which displays the line of code where each group of threads is located.<br />-   The **Address** column, which displays the instruction address where each group of threads is located.<br />-   The **Location** column, which is the location in the code of the address.<br />-   The **Status** column, which shows whether the thread is active or blocked.<br />-   The **Tile** column, which shows the tile index for the threads in the row.|-   Change to a different thread<br />-   Display a particular tile and thread<br />-   Display or hide a column<br />-   Sort by a column<br />-   Group threads<br />-   Freeze or thaw threads<br />-   Flag or unflag a thread<br />-   Display only flagged threads|

## See also

- [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md)
- [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)
- [Debugging GPU Code](../debugger/debugging-gpu-code.md)