---
title: "Debug multithreaded applications | Microsoft Docs"
ms.custom: "seodec18"
ms.date: "11/06/2018"
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
ms.assetid: 9d175bc2-1d95-4c47-9bc3-9755af968a9c
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Debug multithreaded applications in Visual Studio
A thread is a sequence of instructions to which the operating system grants processor time. Every process that is running in the operating system consists of at least one thread. Processes that have more than one thread are called multithreaded.

Computers with multiple processors, multi-core processors, or hyperthreading processes can run several simultaneous threads. Parallel processing using many threads can greatly improve program performance, but it may also make debugging more difficult because you're tracking many threads.

Multithreading can introduce new types of potential bugs. For example, two or more threads may need to access the same resource, but only one thread at a time can safely access the resource. Some form of mutual exclusion is necessary to make sure that only one thread is accessing the resource at any time. If mutual exclusion is implemented incorrectly, it can create a *deadlock* condition where no thread will execute. Deadlocks are often a hard problem to debug.

## Tools for debugging multithreaded apps

Visual Studio provides different tools for use in debugging multithreaded apps.

- For threads, the primary tools for debugging threads are the **Threads** window, thread markers in source windows, the **Parallel Stacks** window, the **Parallel Watch** window, and the **Debug Location** toolbar. To learn about the **Threads** window and **Debug Location** toolbar, see [Walkthrough: Debug using the Threads window](../debugger/how-to-use-the-threads-window.md). To learn how to use the **Parallel Stacks** and **Parallel Watch** windows, see [Get started debugging a multithreaded application](../debugger/get-started-debugging-multithreaded-apps.md). Both topics show how to use thread markers.

- For code that uses the [Task Parallel Library (TPL)](/dotnet/standard/parallel-programming/task-parallel-library-tpl) or the [Concurrency Runtime](/cpp/parallel/concrt/concurrency-runtime/), the primary tools for debugging are the **Parallel Stacks** window, the **Parallel Watch** window, and the **Tasks** window, which also supports JavaScript. To get started, see [Walkthrough: Debugging a parallel application](../debugger/walkthrough-debugging-a-parallel-application.md) and [Walkthrough: Debugging a C++ AMP application](/cpp/parallel/amp/walkthrough-debugging-a-cpp-amp-application).

- For debugging threads on the GPU, the primary tool is the **GPU Threads** window. See [How to: Use the GPU Threads window](../debugger/how-to-use-the-gpu-threads-window.md).

- For processes, the primary tools are the **Attach to Process** dialog box, the **Processes** window, and the **Debug Location** toolbar.

Visual Studio also provides powerful breakpoints and tracepoints, which can be useful when you debug multithreaded applications. Use breakpoint conditions and filters to place breakpoints on individual threads. Tracepoints enable you to trace execution of your program without breaking, to study problems such as deadlocks. For more information, see [Breakpoint actions and tracepoints](../debugger/using-breakpoints.md#BKMK_Print_to_the_Output_window_with_tracepoints).

Debugging a multithreaded application that has a user interface can be especially difficult. You might consider running the application on a second computer and using remote debugging. For more information, see [Remote debugging](../debugger/remote-debugging.md).

## Articles about debugging multithreaded apps

 [Get started debugging a multithreaded application](../debugger/get-started-debugging-multithreaded-apps.md)

A tour of thread debugging features, emphasizing features in the **Parallel Stacks** window and the **Parallel Watch** window.

 [Tools for debugging threads and processes](../debugger/debug-threads-and-processes.md)

Lists the features of the tools for debugging threads and processes.

 [Debug multiple processes](../debugger/debug-multiple-processes.md)

Explains how to debug multiple processes.

 [Walkthrough: Debug using the Threads window](../debugger/how-to-use-the-threads-window.md).

Walkthrough that shows how to use the **Threads** window and the **Debug Location** toolbar.

 [Walkthrough: Debug a parallel application](../debugger/walkthrough-debugging-a-parallel-application.md)

Walkthrough that shows how to use the **Parallel Stacks** and **Tasks** windows.

 [How to: Switch to another thread while debugging](../debugger/how-to-switch-to-another-thread-while-debugging.md)

Several ways to switch the debugging context to another thread.

 [How to: Flag and unflag threads](../debugger/how-to-flag-and-unflag-threads.md)

Mark or flag threads that you want to give special attention to while debugging.

 [How to: Debug on a high-performance cluster](../debugger/how-to-debug-on-a-high-performance-cluster.md)

Techniques for debugging an application that runs on a high-performance cluster.

 [Tips for debugging threads in native code](../debugger/tips-for-debugging-threads-in-native-code.md)

Simple techniques that can be useful for debugging native threads.

 [How to: Set a thread name in native code](../debugger/how-to-set-a-thread-name-in-native-code.md)

Give your thread a name that you view in the **Threads** window.

 [How to: Set a thread name in managed code](../debugger/how-to-set-a-thread-name-in-managed-code.md)

Give your thread a name that you view in the **Threads** window.

## See also

- [Use breakpoints](../debugger/using-breakpoints.md)
- [Threading](/dotnet/standard/threading/index)
- [Multithreading in components](https://msdn.microsoft.com/Library/2fc31e68-fb71-4544-b654-0ce720478779)
- [Multithreading support for older code](/cpp/parallel/multithreading-support-for-older-code-visual-cpp)
- [Debug threads and processes](../debugger/debug-threads-and-processes.md)
- [Remote debugging](../debugger/remote-debugging.md)