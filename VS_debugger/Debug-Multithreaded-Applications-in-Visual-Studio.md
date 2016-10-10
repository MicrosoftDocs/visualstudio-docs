---
title: "Debug Multithreaded Applications in Visual Studio"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9d175bc2-1d95-4c47-9bc3-9755af968a9c
caps.latest.revision: 25
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Debug Multithreaded Applications in Visual Studio
A thread is a sequence of instructions to which the operating system allocates processor time. Every process that is running in the operating system consists of at least one thread. Processes that have more than one thread are called multithreaded.  
  
 Computers with multiple processors, multi-core processors, or hyperthreading processes can run multiple threads at the same time. Parallel processing of multiple threads can greatly improve program performance, but it can also make debugging more difficult because it introduces the need to keep track of multiple threads.  
  
 In addition, multithreading introduces some new types of potential bugs. Often, for example, two or more threads have to access the same resource, but only one thread can safely access the resource at a time. Some form of mutual exclusion is necessary to make sure that only one thread is accessing the resource at a time. If mutual exclusion is performed incorrectly, it can create a *deadlock* condition where no thread can execute. Deadlocks can be a particularly hard problem to debug.  
  
 Visual Studio provides a **Threads** window, a GPU Threads window, a Parallel Watch window, and other features that make multithreaded debugging easier. The best way to learn about the threading features is by doing the walkthroughs. See [Walkthrough: Debugging a Multithreaded Application](../VS_debugger/Walkthrough--Debugging-a-Multithreaded-Application.md) and [Walkthrough: Debugging a C++ AMP Application](../Topic/Walkthrough:%20Debugging%20a%20C++%20AMP%20Application.md).  
  
 Visual Studio also provides powerful breakpoints and tracepoints, which can be very useful when you debug multithreaded applications. You can use breakpoint filters to place breakpoints on individual threads. See [Using Breakpoints](../VS_debugger/Using-Breakpoints.md)  
  
 Debugging a multithreaded application that has a user interface can be especially difficult. In that case, you might consider running the application on a second computer and using remote debugging. For information, see [Remote Debugging](../VS_debugger/Remote-Debugging.md).  
  
## In This Section  
 [Debug Threads and Processes](../VS_debugger/Debug-Threads-and-Processes.md)  
 Explains the basics of debugging threads and processes.  
  
 [Debug Multiple Processes](../VS_debugger/Debug-Multiple-Processes.md)  
 Explains how to debug multiple processes.  
  
 [How to: Use the Threads Window](../VS_debugger/How-to--Use-the-Threads-Window.md)  
 Useful procedures for debugging threads with the **Threads** window.  
  
 [How to: Switch to Another Thread While Debugging](../VS_debugger/How-to--Switch-to-Another-Thread-While-Debugging.md)  
 Three ways to switch the debugging context to another thread.  
  
 [How to: Flag and Unflag Threads](../VS_debugger/How-to--Flag-and-Unflag-Threads.md)  
 Mark or flag threads that you want to give special attention to while debugging.  
  
 [How to: Set a Thread Name in Native Code](../VS_debugger/How-to--Set-a-Thread-Name-in-Native-Code.md)  
 Give your thread a name that you view in the **Threads** window.  
  
 [How to: Set a Thread Name in Managed Code](../VS_debugger/How-to--Set-a-Thread-Name-in-Managed-Code.md)  
 Give your thread a name that you view in the **Threads** window.  
  
 [Walkthrough: Debugging a Multithreaded Application](../VS_debugger/Walkthrough--Debugging-a-Multithreaded-Application.md).  
 A guided tour of thread debugging features, with emphasis on features how to Visual Studio 2008.  
  
 [How to: Debug On a High-Performance Cluster](../VS_debugger/How-to--Debug-On-a-High-Performance-Cluster.md)  
 Techniques for debugging an application that runs on a high-performance cluster.  
  
 [Tips for Debugging Threads in Native Code](../VS_debugger/Tips-for-Debugging-Threads-in-Native-Code.md)  
 Simple techniques that can be useful for debugging native threads.  
  
 [Using the Tasks Window](../VS_debugger/Using-the-Tasks-Window.md)  
 Shows a list of all the managed or native task objects including their status and other useful info.  
  
 [Using the Parallel Stacks Window](../VS_debugger/Using-the-Parallel-Stacks-Window.md)  
 Shows call stacks of multiple threads (or tasks) in a single view and it also coalesces stack segments that are common amongst the threads (or tasks).  
  
 [Walkthrough: Debugging a Parallel Application](../VS_debugger/Walkthrough--Debugging-a-Parallel-Application.md)  
 Walkthrough that shows how to use the Parallel Tasks and Parallel Stacks windows.  
  
 [How to: Use the Parallel Watch Window](../VS_debugger/How-to--Use-the-Parallel-Watch-Window.md)  
 Inspect values and expressions across multiple threads.  
  
 [How to: Use the GPU Threads Window](../VS_debugger/How-to--Use-the-GPU-Threads-Window.md)  
 Examine and work with threads that are running on the GPU during debugging.  
  
## Related Sections  
 [Using Breakpoints](../VS_debugger/Using-Breakpoints.md)  
 -   Use breakpoint filters when you want to place a breakpoint on an individual thread.  
  
-   Tracepoints enable you to trace execution of your program without breaking. This can be useful for studying problems such as deadlocks.  
  
 [Threading](../Topic/Managed%20Threading.md)  
 Threading concepts in .NET Framework programming, including example code.  
  
 [Multithreading in Components](../Topic/Multithreading%20in%20Components.md)  
 How to use multithreading in .NET Framework components.  
  
 [Multithreading Support for Older Code (Visual C++)](../Topic/Multithreading%20Support%20for%20Older%20Code%20\(Visual%20C++\).md)  
 Threading concepts and example code for C++ programmers using MFC.  
  
## See Also  
 [Debug Threads and Processes](../VS_debugger/Debug-Threads-and-Processes.md)   
 [Remote Debugging](../VS_debugger/Remote-Debugging.md)