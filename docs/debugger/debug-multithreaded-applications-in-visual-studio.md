---
title: "Debug Multithreaded Applications in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "09/05/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
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
ms.assetid: 9d175bc2-1d95-4c47-9bc3-9755af968a9c
caps.latest.revision: 25
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Debug Multithreaded Applications in Visual Studio
A thread is a sequence of instructions to which the operating system allocates processor time. Every process that is running in the operating system consists of at least one thread. Processes that have more than one thread are called multithreaded.  
  
Computers with multiple processors, multi-core processors, or hyperthreading processes can run multiple threads at the same time. Parallel processing of multiple threads can greatly improve program performance, but it can also make debugging more difficult because it introduces the need to keep track of multiple threads.  
  
In addition, multithreading introduces some new types of potential bugs. Often, for example, two or more threads have to access the same resource, but only one thread can safely access the resource at a time. Some form of mutual exclusion is necessary to make sure that only one thread is accessing the resource at a time. If mutual exclusion is performed incorrectly, it can create a *deadlock* condition where no thread can execute. Deadlocks can be a particularly hard problem to debug.

Visual Studio provides different tools for use in debugging multithreaded apps.

- For threads, the primary tools for debugging threads are the **Threads** window, thread markers in source windows, **Parallel Stacks** window, **Parallel Watch** window, and the **Debug Location** toolbar. To learn about the **Threads** window and **Debug Location** toolbar, see [Walkthrough: Debug using the Threads Window](../debugger/how-to-use-the-threads-window.md). To learn how to use the **Parallel Stacks** and **Parallel Watch** windows, see [Get started debugging a multithreaded application](../debugger/get-started-debugging-multithreaded-apps.md). Both topics show how to use thread markers.
  
- For code that uses the [Task Parallel Library (TPL)](/dotnet/standard/parallel-programming/task-parallel-library-tpl) or the [Concurrency Runtime](/cpp/parallel/concrt/concurrency-runtime/), the primary tools for debugging are the **Parallel Stacks** window, the **Parallel Watch** window, and the **Tasks** window (the **Tasks** window also supports JavaScript). To get started, see [Walkthrough: Debugging a Parallel Application](../debugger/walkthrough-debugging-a-parallel-application.md) and [Walkthrough: Debugging a C++ AMP Application](/cpp/parallel/amp/walkthrough-debugging-a-cpp-amp-application). 

- For debugging threads on the GPU, the primary tool is the **GPU Threads** window. See [How to: Use the GPU Threads window](../debugger/how-to-use-the-gpu-threads-window.md).  

- For processes, the primary tools are the **Attach to Process** dialog box, the **Processes** window, and the **Debug Location** toolbar.  
  
Visual Studio also provides powerful breakpoints and tracepoints, which can be very useful when you debug multithreaded applications. You can use breakpoint conditions and filters to place breakpoints on individual threads. See [Using Breakpoints](../debugger/using-breakpoints.md). 
  
Debugging a multithreaded application that has a user interface can be especially difficult. In that case, you might consider running the application on a second computer and using remote debugging. For information, see [Remote Debugging](../debugger/remote-debugging.md).  
  
## In This Section
 [Get started debugging a multithreaded application](../debugger/get-started-debugging-multithreaded-apps.md).  
 A guided tour of thread debugging features, with emphasis on features in the **Parallel Stacks** window and **Parallel Watch** window.

 [Tools for Debugging Threads and Processes](../debugger/debug-threads-and-processes.md)  
 Lists the features of the tools for debugging threads and processes.  
  
 [Debug Multiple Processes](../debugger/debug-multiple-processes.md)  
 Explains how to debug multiple processes.

 [Walkthrough: Debug using the Threads Window](../debugger/how-to-use-the-threads-window.md).  
 Walkthrough that shows how to use the **Threads** window and the **Debug Location** toolbar. 

 [Walkthrough: Debug a Parallel Application](../debugger/walkthrough-debugging-a-parallel-application.md)  
 Walkthrough that shows how to use the **Parallel Stacks** and **Tasks** windows.  
  
 [How to: Switch to Another Thread While Debugging](../debugger/how-to-switch-to-another-thread-while-debugging.md)  
 Three ways to switch the debugging context to another thread.  
  
 [How to: Flag and Unflag Threads](../debugger/how-to-flag-and-unflag-threads.md)  
 Mark or flag threads that you want to give special attention to while debugging.    
  
 [How to: Debug On a High-Performance Cluster](../debugger/how-to-debug-on-a-high-performance-cluster.md)  
 Techniques for debugging an application that runs on a high-performance cluster.  

 [Tips for Debugging Threads in Native Code](../debugger/tips-for-debugging-threads-in-native-code.md)  
 Simple techniques that can be useful for debugging native threads. 

 [How to: Set a Thread Name in Native Code](../debugger/how-to-set-a-thread-name-in-native-code.md)  
 Give your thread a name that you view in the **Threads** window.  
  
 [How to: Set a Thread Name in Managed Code](../debugger/how-to-set-a-thread-name-in-managed-code.md)  
 Give your thread a name that you view in the **Threads** window. 
  
## Related Sections  
 [Using Breakpoints](../debugger/using-breakpoints.md)

 - Use breakpoint conditions or filters when you want to debug an individual thread.  
  
 - Tracepoints enable you to trace execution of your program without breaking. This can be useful for studying problems such as deadlocks.  
  
 [Threading](/dotnet/standard/threading/index)  
 Threading concepts in [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] programming, including example code.  
  
 [Multithreading in Components](http://msdn.microsoft.com/Library/2fc31e68-fb71-4544-b654-0ce720478779)  
 How to use multithreading in [!INCLUDE[dnprdnshort](../code-quality/includes/dnprdnshort_md.md)] components.  
  
 [Multithreading Support for Older Code (Visual C++)](/cpp/parallel/multithreading/multithreading-support-for-older-code-visual-cpp)  
 Threading concepts and example code for C++ programmers using MFC.  
  
## See Also  
 [Debug Threads and Processes](../debugger/debug-threads-and-processes.md)   
 [Remote Debugging](../debugger/remote-debugging.md)