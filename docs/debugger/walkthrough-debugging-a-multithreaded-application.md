---
title: "View threads in the debugger | Microsoft Docs"
ms.date: "10/29/2018"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.threads"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "threading [Visual Studio], debugging"
  - "Thread.Name property"
  - "debugger, Threads window"
  - "SetThreadName function"
  - "Threads window"
  - "@TIB"
  - "debugging [Visual Studio], threads"
ms.assetid: 590ffd57-0556-43d8-8962-ee27e5b2b7d7
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# View threads in the Visual Studio debugger by using the Threads window (C#, Visual Basic, C++)
In the **Threads** window, you can examine and work with threads in the application that you're debugging. For step-by-step guidance on how to use the **Threads** window, see [Walkthrough: Debug by using the Threads window](../debugger/how-to-use-the-threads-window.md).

## Use the Threads window
 The **Threads** window contains a table where each row describes a separate thread in your application. By default, the table lists all the threads in your application, but you can filter the list to show only the threads that interest you. Each column describes a different type of information. You can also hide some columns. If you display all the columns, the following columns appear, from left to right:

- **Flag**: In this unlabeled column, you can mark a thread to which you want to pay special attention. For information about how to flag a thread, see [How to: Flag and unflag threads](../debugger/how-to-flag-and-unflag-threads.md).

- **Current thread**: In this unlabeled column, a yellow arrow indicates the current thread. An arrow outline indicates the current debugger context for a non-current thread.

- **ID**: Displays the identification number for each thread.

- **Managed ID**: Displays the managed identification numbers for managed threads.

- **Category**: Displays the category of threads as either user interface threads, remote procedure call handlers, or worker threads. A special category identifies the main thread of the application.

- **Name**: Identifies each thread by name, if it has one, or as \<No Name>.

- **Location**: Shows where the thread is running. You can expand this location to show the full call stack for the thread.

- **Priority**: An advanced column (hidden by default) that displays the priority or precedence that the system has assigned to each thread.

- **Affinity Mask**: An advanced column (hidden by default) that shows the processor affinity mask for each thread. In a multiprocessor system, the affinity mask determines which processors on which a thread can run.

- **Suspended Count**: An advanced column (hidden by default) that displays the suspended count. This count determines whether a thread can run. For more information about suspended counts, see [Freeze and thaw threads](#freeze-and-thaw-threads).

- **Process Name**: An advanced column (hidden by default) that displays the process to which each thread belongs. The data in this column can be useful when you're debugging many processes.

- **Process ID**: An advanced column (hidden by default) that displays the process ID to which each thread belongs.

- **Transport Qualifier**: An advanced column (hidden by default) that uniquely identifies the machine to which the debugger is connected.

### To display the Threads window in break mode or run mode

- While Visual Studio is in debug mode, select the **Debug** menu, point to **Windows**, and then select **Threads**.

### To display or hide a column

- In the toolbar at the top of the **Threads** window, select **Columns**. Then, select or clear the name of the column that you want to display or hide.

## Display flagged threads
 You can flag a thread that you want to give special attention by marking it with an icon in the **Threads** window. For more information, see [How to: Flag and Unflag threads](../debugger/how-to-flag-and-unflag-threads.md). In the **Threads** window, you can choose to display all the threads or only the flagged threads.

### To display only flagged threads

- Choose **Show Flagged Threads Only** in the toolbar at the top of the **Threads** window. (If it's dimmed, you'll need to flag some threads first.)

## Freeze and thaw threads
 When you freeze a thread, the system won't start execution of the thread even if resources are available.

 In native code, you can suspend or resume threads by calling the Windows functions `SuspendThread` and `ResumeThread`. Or, call the MFC functions [CWinThread::SuspendThread](/cpp/mfc/reference/CWinThread-class#suspendthread) and [CWinThread::ResumeThread](/cpp/mfc/reference/CWinThread-class#resumethread). If you call `SuspendThread` or `ResumeThread`, the *suspended count* shown in the **Threads** window will be changed. The suspended count doesn't change if you freeze or thaw a native thread. A thread can't execute in native code unless it's thawed and has a suspended count of zero.

 In managed code, the suspended count changes when you freeze or thaw a thread. If you freeze a thread in managed code, its suspended count is 1. When you freeze a thread in native code, its suspended count is 0, unless you used the `SuspendThread` call.

> [!NOTE]
> When you debug a call from native code to managed code, the managed code runs in the same physical thread as the native code that called it. Suspending or freezing the native thread freezes the managed code also.

### To freeze or thaw execution of a thread

- In the toolbar at the top of the **Threads** window, select **Freeze Threads** or **Thaw Threads**.

     This action affects only threads that are selected in the **Threads** window.

### Switch to another thread

A yellow arrow indicates the current thread (and the location of the execution pointer). A green arrow with a curly tail indicates a non-current thread has the current debugger context.

#### To switch to another thread

- Follow either of the following steps:

  - Double-click any thread.

  - Right-click a thread and select **Switch To Thread**.

## Group and sort threads
 When you group threads, a heading appears in the table for each group. The heading contains a group description, such as **Worker Thread** or **Unflagged Threads**, and a tree control. The member threads of each group appear under the group heading. If you want to hide the member threads for a group, use the tree control to collapse the group.

 Because grouping takes precedence over sorting, you can group threads by category, for example, and then sort them by ID within each category.

### To sort threads

1. In the toolbar at the top of the **Threads** window, select the button at the top of any column.

     The threads are now sorted by the values in that column.

2. If you want to reverse the sort order, select the same button again.

     Threads that appeared at the top of the list now appear on the bottom.

### To group threads

- In the **Threads** window toolbar, select the **Group by** list, then select the criteria that you want to group threads by.

### To sort threads within groups

1. In the toolbar at the top of the **Threads** window, select the **Group by** list, then select the criteria that you want to group threads by.

2. In the **Threads** window, select the button at the top of any column.

     The threads are now sorted by the values in that column.

### To expand or collapse all groups

- In the toolbar at the top of the **Threads** window, select **Expand groups** or **Collapse groups**.

## Search for specific threads
 You can search for threads that match a specified string in the **Threads** window. When you search for threads, the window displays all the threads matching the search string in any column. This information includes the thread location that appears at the top of the call stack in the **Location** column. By default, the full call stack isn't searched.

### To search for specific threads

1. In the toolbar at the top of the **Threads** window, go to the **Search** box and either:

     - Enter a search string and then press **Enter**.

     \- or -

     - Select the drop-down list next to the **Search** box and select a search string from a previous search.

2. (Optional) To include the full call stack in your search, select **Search Call Stack**.

## Display thread call stacks and switch between frames
In a multithreaded program, each thread has its own call stack. The **Threads** window provides a convenient way to view these stacks.

> [!TIP]
> For a visual representation of the call stack for each thread, use the [Parallel Stacks](../debugger/get-started-debugging-multithreaded-apps.md) window.

### To view the call stack of a thread

- In the **Location** column, select the inverted triangle next to the thread location.

     The location expands to show the call stack for the thread.

### To view or collapse the call stacks of all threads

- In the toolbar at the top of the **Threads** window, select **Expand Call Stacks** or **Collapse Call Stacks**.

## See also
- [Debug multithreaded applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)
- [Get started debugging multithreaded applications](../debugger/get-started-debugging-multithreaded-apps.md)
