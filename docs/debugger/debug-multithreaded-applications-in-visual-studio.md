---
title: "Debug multithreaded applications"
description: Debug multithreaded applications in Visual Studio and review tools and other articles about debugging multithreaded apps.
ms.date: "8/5/2025"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.gputthreads"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "threading [Visual Studio], debugging"
  - "debugging [Visual Studio], high-performance computing"
  - "debugging [Visual Studio], multithreaded"
  - "multithreaded debugging"
  - "high-performance debugging"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Debug multithreaded applications in Visual Studio

A thread is a sequence of instructions to which the operating system grants processor time. Every process that is running in the operating system consists of at least one thread. Processes that have more than one thread are called multithreaded.

Computers with multiple processors, multi-core processors, or hyperthreading processes can run several simultaneous threads. Parallel processing using many threads can greatly improve program performance, but it may also make debugging more difficult because you're tracking many threads.

Perfect parallel processing is not always possible. Threads sometimes must be synchronized. One thread may have to wait for a result from another thread, or one thread may need exclusive access to a resource that another thread is using. Synchronization problems are a common cause of bugs in multithreaded applications. Sometimes threads may end up waiting for a resource that never becomes available. This results in a condition called *deadlock*.

## Threads and processes

*Threads* and *processes* are related concepts in computer science. Both represent sequences of instructions that must execute in a specific order. Instructions in separate threads or processes, however, can execute in parallel.

Processes exist in the operating system and correspond to what users see as programs or applications. A thread, on the other hand, exists within a process. For this reason, threads are sometimes referred to as *light-weight processes*. Each process consists of one or more threads.

The existence of multiple processes enables a computer to perform more than one task at a time. The existence of multiple threads enables a process to separate work to be performed in parallel. On a computer with multiprocessors, processes or threads can run on different processors. This enables true parallel processing.

## Tools for debugging multithreaded apps

Visual Studio provides different tools for use in debugging multithreaded apps.

::: moniker range=">= vs-2022"
- For threads, the primary tools for debugging threads are the **Parallel Stacks** window, the **Parallel Watch** window, thread markers in source windows, the **Threads** window, and the **Debug Location** toolbar. To learn about the **Threads** view in **Parallel Stacks**, see [Debug a deadlock using Threads view](../debugger/how-to-use-the-threads-window.md). To learn how to use the **Parallel Stacks** and **Parallel Watch** windows, see [Get started debugging a multithreaded application](../debugger/get-started-debugging-multithreaded-apps.md). The get started article shows how to use thread markers. Also, see [Walkthrough: Debugging a C++ AMP application](/cpp/parallel/amp/walkthrough-debugging-a-cpp-amp-application).

- For .NET code that uses async, the primary tools for debugging are **Tasks** view in the **Parallel Stacks** window. To get started, see [Debug an async application (.NET)](../debugger/walkthrough-debugging-a-parallel-application.md).
::: moniker-end

::: moniker range="vs-2019"
- For threads, the primary tools for debugging threads are the **Parallel Stacks** window, the **Parallel Watch** window, thread markers in source windows, the **Threads** window, and the **Debug Location** toolbar. To learn about the **Threads** view in **Parallel Stacks**, see [View threads and tasks in the Parallel Stacks window](../debugger/using-the-parallel-stacks-window.md). To learn how to use the **Parallel Stacks** and **Parallel Watch** windows, see [Get started debugging a multithreaded application](../debugger/get-started-debugging-multithreaded-apps.md). The get started article shows how to use thread markers. Also, see [Walkthrough: Debugging a C++ AMP application](/cpp/parallel/amp/walkthrough-debugging-a-cpp-amp-application).

- For .NET code that uses async, the primary tools for debugging are **Tasks** view in the **Parallel Stacks** window. For more information, see [View threads and tasks in the Parallel Stacks window](../debugger/using-the-parallel-stacks-window.md).
::: moniker-end

- For debugging threads on the GPU, the primary tool is the **GPU Threads** window. See [How to: Use the GPU Threads window](../debugger/how-to-use-the-gpu-threads-window.md).

- For processes, the primary tools are the **Attach to Process** dialog box, the **Processes** window, and the **Debug Location** toolbar.

Visual Studio also provides powerful breakpoints and tracepoints, which can be useful when you debug multithreaded applications. Use breakpoint conditions and filters to place breakpoints on individual threads. Tracepoints enable you to trace execution of your program without breaking, to study problems such as deadlocks. For more information, see [Breakpoint actions and tracepoints](../debugger/using-breakpoints.md#BKMK_Print_to_the_Output_window_with_tracepoints).

Debugging a multithreaded application that has a user interface can be especially difficult. You might consider running the application on a second computer and using remote debugging. For more information, see [Remote debugging](../debugger/remote-debugging.md).

  The following table shows the information available and the actions you can perform in each of these places:

|User Interface|Information Available|Actions You Can Perform|
|--------------------|---------------------------|-----------------------------|
|**Attach to Process** dialog box|Available Processes you can attach to:<br /><br /> -   Process name (.exe)<br />-   Process ID number<br />-   Menubar Title<br />-   Type (Managed v4.0; Managed v2.0, v1.1, v1.0; x86; x64; IA64)<br />-   User Name (account name)<br />-   Session number|Select a process to attach to<br /><br /> Select a remote computer<br /><br /> Change transport type for connecting to remote computers|
|**Processes** window|Attached Processes:<br /><br /> -   Process Name<br />-   Process ID number<br />-   Path to process .exe<br />-   Menubar Title<br />-   State (Break. Running)<br />-   Debugging (Native, Managed, and so on.)<br />-   Transport type (default, native with no authentication)<br />-   Transport Qualifier (remote computer)|Tools:<br /><br /> -   Attach<br />-   Detach<br />-   Terminate<br /><br /> Shortcut menu:<br /><br /> -   Attach<br />-   Detach<br />-   Detach when debugging stopped<br />-   Terminate|
|**Debug Location** toolbar|-   Current process<br />-   Suspend the application<br />-   Resume the application<br />-   Suspend and shut down the application<br />-   Current thread<br />-   Toggle current thread flag state<br />-   Show only flagged threads<br />-   Show only current process<br />-   Current stack frame|-   Switch to another process<br />-   Suspend, resume, or shut down the application<br />-   Switch to another thread in current process<br />-   Switch to another stack frame in current thread<br />-   Flag or unflag current threads<br />-   Show only flagged threads<br />-   Show only the current process|
|**Parallel Stacks** window|-   Call stacks for multiple threads in one window.<br />-   Active stack frame for each thread.<br />-   Callers and callees for any method. <br/>- Deadlock Detection <br />|-   Filter out specified threads <br />-   Filter out external code stacks<br />-   Switch to Tasks view<br />-   Flag or unflag a thread<br />-   Zoom <br />-   Copy Stack Frames <br />- Save/Export  all stacks as image |
|**Parallel Watch** window|-   The flag column, in which you can mark a thread that you want to pay special attention to.<br />-   The frame column, in which an arrow indicates the selected frame.<br />-   A configurable column that can display the machine, process, tile, task, and thread.|-   Flag or unflag a thread<br />-   Display only flagged threads<br />-   Switch frames<br />-   Sort a column<br />-   Group threads<br />-   Freeze or thaw threads<br />-   export the data in the Parallel Watch window|
|**Threads** window|Threads in current process:<br /><br /> -   Thread ID<br />-   Managed ID<br />-   Category (main thread, interface thread, remote procedure call handler, or worker thread)<br />-   Thread Name<br />-   Location where thread is created<br />-   Priority<br />-   Affinity Mask<br />-   Suspended Count<br />-   Process Name<br />-   Flag Indicator<br />-   Suspended indicator|Tools:<br /><br /> -   Search<br />-   Search Call Stack<br />-   Flag Just My Code<br />-   Flag Custom Module Selection<br />-   Group by<br />-   Columns<br />-   Expand/Collapse callstacks<br />-   Expand/Collapse groups<br />-   Freeze/Thaw Threads<br /><br /> Shortcut menu:<br /><br /> -   Show threads in source<br />-   Switch to a thread<br />-   Freeze a running thread<br />-   Thaw a frozen thread<br />-   Flag a thread for additional study<br />-   Unflag a thread<br />-   Rename a thread<br />-   Show and hide threads<br /><br /> Other actions:<br /><br /> -   View the call stack for a thread in a DataTip|
|Source window|Thread indicators in left gutter indicate single or multiple threads (off by default, turned on by using shortcut menu in **Threads** window)|Shortcut menu:<br /><br /> -   Switch to a thread<br />-   Flag a thread for additional study<br />-   Unflag a thread|
|**Tasks** window|-   View information about <xref:System.Threading.Tasks.Task> objects including task ID, task status (scheduled, running, waiting, deadlocked), and which thread is assigned to the task.<br />-   Current location in call stack.<br />-   Delegate passed to the task at creation time|-   Switch to current task<br />-   Flag or unflag a task<br />-   Freeze or thaw a task|
|**GPU Threads** window|-   The flag column, in which you can mark a thread that you want to pay special attention to.<br />-   The current thread column, in which a yellow arrow indicates the current thread.<br />-   The **Thread Count** column, which displays the number of threads at the same location.<br />-   The **Line** column, which displays the line of code where each group of threads is located.<br />-   The **Address** column, which displays the instruction address where each group of threads is located.<br />-   The **Location** column, which is the location in the code of the address.<br />-   The **Status** column, which shows whether the thread is active or blocked.<br />-   The **Tile** column, which shows the tile index for the threads in the row.|-   Change to a different thread<br />-   Display a particular tile and thread<br />-   Display or hide a column<br />-   Sort by a column<br />-   Group threads<br />-   Freeze or thaw threads<br />-   Flag or unflag a thread<br />-   Display only flagged threads|

## Related content

- [Use breakpoints](../debugger/using-breakpoints.md)
- [Threading](/dotnet/standard/threading/index)
- [Multithreading in components](/previous-versions/3es4b6yy(v=vs.140))
- [Multithreading support for older code](/cpp/parallel/multithreading-support-for-older-code-visual-cpp)
- [Debug multithreaded applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)
- [Remote debugging](../debugger/remote-debugging.md)