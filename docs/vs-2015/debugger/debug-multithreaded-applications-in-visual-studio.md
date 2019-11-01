---
title: "Debug Multithreaded Applications"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords:
  - "vs.debug.gputthreads"
dev_langs:
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "threading [Visual Studio], debugging"
  - "debugging [Visual Studio], high-performance computing"
  - "debugging [Visual Studio], multithreaded"
  - "multithreaded debugging"
  - "high-performance debugging"
ms.assetid: 9d175bc2-1d95-4c47-9bc3-9755af968a9c
caps.latest.revision: 28
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Debug Multithreaded Applications in Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A thread is a sequence of instructions to which the operating system allocates processor time. Every process that is running in the operating system consists of at least one thread. Processes that have more than one thread are called multithreaded.

 Computers with multiple processors, multi-core processors, or hyperthreading processes can run multiple threads at the same time. Parallel processing of multiple threads can greatly improve program performance, but it can also make debugging more difficult because it introduces the need to keep track of multiple threads.

 In addition, multithreading introduces some new types of potential bugs. Often, for example, two or more threads have to access the same resource, but only one thread can safely access the resource at a time. Some form of mutual exclusion is necessary to make sure that only one thread is accessing the resource at a time. If mutual exclusion is performed incorrectly, it can create a *deadlock* condition where no thread can execute. Deadlocks can be a particularly hard problem to debug.

 Visual Studio provides a **Threads** window, a GPU Threads window, a Parallel Watch window, and other features that make multithreaded debugging easier. The best way to learn about the threading features is by doing the walkthroughs. See [Walkthrough: Debugging a Multithreaded Application](../debugger/walkthrough-debugging-a-multithreaded-application.md) and [Walkthrough: Debugging a C++ AMP Application](https://msdn.microsoft.com/library/40e92ecc-f6ba-411c-960c-b3047b854fb5).

 Visual Studio also provides powerful breakpoints and tracepoints, which can be very useful when you debug multithreaded applications. You can use breakpoint filters to place breakpoints on individual threads. See [Using Breakpoints](../debugger/using-breakpoints.md)

 Debugging a multithreaded application that has a user interface can be especially difficult. In that case, you might consider running the application on a second computer and using remote debugging. For information, see [Remote Debugging](../debugger/remote-debugging.md).

## In This Section
 [Debug Threads and Processes](../debugger/debug-threads-and-processes.md)
 Explains the basics of debugging threads and processes.

 [Debug Multiple Processes](../debugger/debug-multiple-processes.md)
 Explains how to debug multiple processes.

 [How to: Use the Threads Window](../debugger/how-to-use-the-threads-window.md)
 Useful procedures for debugging threads with the **Threads** window.

 [How to: Switch to Another Thread While Debugging](../debugger/how-to-switch-to-another-thread-while-debugging.md)
 Three ways to switch the debugging context to another thread.

 [How to: Flag and Unflag Threads](../debugger/how-to-flag-and-unflag-threads.md)
 Mark or flag threads that you want to give special attention to while debugging.

 [How to: Set a Thread Name in Native Code](../debugger/how-to-set-a-thread-name-in-native-code.md)
 Give your thread a name that you view in the **Threads** window.

 [How to: Set a Thread Name in Managed Code](../debugger/how-to-set-a-thread-name-in-managed-code.md)
 Give your thread a name that you view in the **Threads** window.

 [Walkthrough: Debugging a Multithreaded Application](../debugger/walkthrough-debugging-a-multithreaded-application.md).
 A guided tour of thread debugging features, with emphasis on features how to [!INCLUDE[vs_orcas_long](../includes/vs-orcas-long-md.md)].

 [How to: Debug On a High-Performance Cluster](../debugger/how-to-debug-on-a-high-performance-cluster.md)
 Techniques for debugging an application that runs on a high-performance cluster.

 [Tips for Debugging Threads in Native Code](../debugger/tips-for-debugging-threads-in-native-code.md)
 Simple techniques that can be useful for debugging native threads.

 [Using the Tasks Window](../debugger/using-the-tasks-window.md)
 Shows a list of all the managed or native task objects including their status and other useful info.

 [Using the Parallel Stacks Window](../debugger/using-the-parallel-stacks-window.md)
 Shows call stacks of multiple threads (or tasks) in a single view and it also coalesces stack segments that are common amongst the threads (or tasks).

 [Walkthrough: Debugging a Parallel Application](../debugger/walkthrough-debugging-a-parallel-application.md)
 Walkthrough that shows how to use the Parallel Tasks and Parallel Stacks windows.

 [How to: Use the Parallel Watch Window](../debugger/how-to-use-the-parallel-watch-window.md)
 Inspect values and expressions across multiple threads.

 [How to: Use the GPU Threads Window](../debugger/how-to-use-the-gpu-threads-window.md)
 Examine and work with threads that are running on the GPU during debugging.

## Related Sections

[Using Breakpoints](../debugger/using-breakpoints.md)
- Use breakpoint filters when you want to place a breakpoint on an individual thread.

- Tracepoints enable you to trace execution of your program without breaking. This can be useful for studying problems such as deadlocks.

  [Threading](https://msdn.microsoft.com/library/7b46a7d9-c6f1-46d1-a947-ae97471bba87)
  Threading concepts in [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] programming, including example code.

  [Multithreading in Components](https://msdn.microsoft.com/library/2fc31e68-fb71-4544-b654-0ce720478779)
  How to use multithreading in [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] components.

  [Multithreading Support for Older Code (Visual C++)](https://msdn.microsoft.com/library/24425b1f-5031-4c6b-aac7-017115a40e7c)
  Threading concepts and example code for C++ programmers using MFC.

## See Also
 [Debug Threads and Processes](../debugger/debug-threads-and-processes.md)
 [Remote Debugging](../debugger/remote-debugging.md)
