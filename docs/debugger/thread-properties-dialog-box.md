---
title: "Thread Properties dialog box in Spy++"
description: Learn about the Thread Properties dialog box in the Spy++ debugging tool. Use this dialog box to find out more about a specific thread.
ms.custom: SEO-VS-2020
ms.date: "06/06/2022"
ms.topic: "ui-reference"
helpviewer_keywords:
  - "Spy++, thread properties"
  - "thread properties, Spy++"
ms.assetid: 5352d11a-debb-4c20-b9a0-d37d94900b1c
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Thread Properties dialog box

[!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Use this dialog box find out more about a specific thread. To display this dialog box, move the focus to a [Threads View](threads-view.md) window, or open [Messages View](messages-view.md) and expand a message. Select any thread node in the tree, then choose **Properties** from the **View** menu.

## General tab, Thread Properties

Use this dialog box to find out more about a specific thread. The **Thread Properties** dialog box contains one pane, the **General** tab. The following settings are available:

|Entry|Description|
|-----------|-----------------|
|**Module Name**|The name of the module.|
|**Thread ID**|The unique ID of this thread. Note that thread ID numbers are reused; they identify a thread only for the lifetime of that thread.|
|**Process ID**|The unique ID of this process. Process ID numbers are reused, so they identify a process only for the lifetime of that process. The Process object type is created when a program is run. All the threads in a process share the same address space and have access to the same data. Choose this value to view the properties of the process ID.|
|**Thread State**|The current state of the thread. A Running thread is using a processor; a Standby thread is about to use one. A Ready Thread is waiting to use a processor because one is not free. A thread in Transition is waiting for a resource to execute, such as waiting for its execution stack to be paged in from disk. A Waiting thread does not need the processor because it is waiting for a peripheral operation to complete or a resource to become free.|
|**Wait Reason**|This is applicable only when the thread is in the Wait state. Event Pairs are used to communicate with protected subsystems.|
|**CPU Time**|Total CPU time spent on this process and its threads. Equal to User Time + Privileged Time.|
|**User Time**|The total elapsed time that this thread has spent executing code in User Mode. Applications execute in User Mode, as do subsystems like the window manager and the graphics engine.|
|**Privileged Time**|The total elapsed time that this thread has spent executing code in Privileged Mode. When a Windows system service is called, the service will often run in Privileged Mode to gain access to system-private data. Such data is protected from access by threads executing in User Mode. Calls to the system may be explicit, or they may be implicit, such as when a page fault or an interrupt occurs.|
|**Elapsed Time**|The total elapsed time (in seconds) this thread has been running.|
|**Current Priority**|The current dynamic priority of this thread. Threads within a process can raise and lower their own base priority relative to the base priority of the process.|
|**Base Priority**|The current base priority of this thread.|
|**Start Address**|Starting virtual address for this thread.|
|**User PC**|The user program counter for the thread.|
|**Context Switches**|The number of switches from one thread to another. Thread switches can occur either inside a single process or across processes. A thread switch may be caused by one thread asking another for information, or by a thread being preempted when a higher priority thread becomes ready to run.|

## Related sections

- [Thread Search dialog box](thread-search-dialog-box.md): Used to find the node for a specific thread in Threads view.
- [Spy++ reference](spy-increment-reference.md): Includes sections describing each Spy++ menu and dialog box.
- [Searching for a thread in Threads View](how-to-search-for-a-thread-in-threads-view.md): Explains how to find a specific thread in Threads view.
- [Threads View](threads-view.md): Displays a tree view of active threads.
- [Spy++ Views](spy-increment-views.md): Explains the Spy++ tree views of windows, messages, processes, and threads.
- [Using Spy++](using-spy-increment.md): Introduces the Spy++ tool and explains how it can be used.