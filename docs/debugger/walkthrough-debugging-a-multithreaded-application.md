---
title: "View Threads in the Debugger | Microsoft Docs"
ms.custom: ""
ms.date: "10/24/2018"
ms.technology: "vs-ide-debug"
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
manager: douge
ms.workload: 
  - "multiple"
---
# View threads in the Visual Studio debugger by using the Threads window
In the **Threads** window, you can examine and work with threads in the application that you're debugging. For step-by-step guidance on how to use the **Threads** window, see [Walkthrough: Debug using the Threads Window](../debugger/how-to-use-the-threads-window.md).
  
 The **Threads** window contains a table where each row describes a thread in your application. By default, the table lists all the threads in your application, but you can filter the list to show only the threads that interest you. Each column contains a different type of information. You can also hide some columns. If you display all the columns, the following information appears, from left to right:  
  
-   The flag column, where you can mark a thread to which you want to pay special attention. For information about how to flag a thread, see [How to: Flag and unflag threads](../debugger/how-to-flag-and-unflag-threads.md).  
  
-   The current thread column, in which a yellow arrow indicates the current thread (an arrow outline indicates the current debugger context for a non-current thread).
  
-   The **ID** column, which contains the identification number for each thread.  
  
-   The **Managed ID** column, which contains the managed identification numbers for managed threads.  
  
-   The **Category** column, which categorizes threads as user interface threads, remote procedure call handlers, or worker threads. A special category identifies the main thread of the application.  
  
-   The **Name** column, which identifies each thread by name, if it has one, or as \<No Name>.  
  
-   The **Location** column, which shows where the thread is running. You can expand this location to show the full call stack for the thread.  
  
-   The **Priority** column, which contains the priority or precedence that the system has assigned to each thread.  
  
-   The **Affinity Mask** column, which is an advanced column (usually hidden). This column shows the processor affinity mask for each thread. In a multiprocessor system, the affinity mask determines which processors on which a thread can run.  
  
-   The **Suspended Count** column (usually hidden), which contains the suspended count and is usually hidden. This count determines whether a thread can run. For an explanation of suspended count, see [Freeze and thaw threads](#freeze-and-thaw-threads).  
  
-   The **Process Name** column (usually hidden), which contains the process to which each thread belongs. This column can be useful when you're debugging many processes.  
  
### To display the Threads window in break mode or run mode  
  
-   While debugging, select the **Debug** menu, point to **Windows**, and then select **Threads**.  
  
### To display or hide a column  
  
-   In the toolbar at the top of the **Threads** window, select **Columns**. Then, select or clear the name of the column that you want to display or hide.  

## Display flagged threads  
 You can flag a thread that you want to give special attention by marking it with an icon in the **Threads** window. For more information, see [How to: Flag and Unflag Threads](../debugger/how-to-flag-and-unflag-threads.md). In the **Threads** window, you can choose to display all the threads or only the flagged threads.  
  
#### To display only flagged threads  
  
-   Choose the **Show Flagged Threads Only** button at the top of the **Threads** window. (If it's dimmed, you need to flag some threads first.) 

## Freeze and thaw threads  
 When you freeze a thread, the system won't start execution of the thread even if resources are available.  
  
 In native code, you can suspend or resume threads by calling the Windows functions `SuspendThread` and `ResumeThread`, or the MFC functions [CWinThread::SuspendThread](/cpp/mfc/reference/CWinThread-class#suspendthread) and [CWinThread::ResumeThread](/cpp/mfc/reference/CWinThread-class#resumethread). If you call `SuspendThread` or `ResumeThread`, the suspended count shown in the **Threads** window will be changed. The suspended count doesn't change if you freeze or thaw a native thread. In native code, a thread can't execute unless it's thawed and has a suspended count of zero.  
  
 In managed code, freezing or thawing a thread does change the suspended count. A frozen thread in managed code has a suspended count of 1. A frozen thread in native code has a suspended count of 0 unless the thread has been suspended by a `SuspendThread` call.  
  
> [!NOTE]
>  When you debug a call from native code to managed code, the managed code runs in the same physical thread as the native code that called it. Suspending or freezing the native thread freezes the managed code also.  
  
#### To freeze or thaw execution of a thread  
  
-   In the toolbar at the top of the **Threads** window, select **Freeze Threads** or **Thaw Threads**.  
  
     This action affects only threads that are selected in the **Threads** window. 

### Switch to another thread 

A yellow arrow indicates the current thread (and the location of the execution pointer). A green arrow with a curly tail indicates a non-current thread has the current debugger context.

#### To switch to another thread  
  
-   Follow either of the following steps:  
  
    -   Double-click any thread.  
  
    -   Right-click a thread and select **Switch to Thread**.

## Group and sort threads  
 When you group threads, a heading appears in the table for each group. The heading contains a group description, such as **Worker Thread** or **Unflagged Threads**, and a tree control. The member threads of each group appear under the group heading. If you want to hide the member threads for a group, use the tree control to collapse the group.  
  
 Because grouping takes precedence over sorting, you can group threads by category, for example, and then sort them by ID within each category.  
  
#### To sort threads  
  
1.  In the toolbar at the top of the **Threads** window, select the button at the top of any column.  
  
     The threads are now sorted by the values in that column.  
  
2.  If you want to reverse the sort order, select the same button again.  
  
     Threads that appeared at the top of the list now appear on the bottom.  
  
#### To group threads  
  
-   In the **Threads** window toolbar, select the **Group by** list, then select the criteria that you want to group threads by.  
  
#### To sort threads within groups  
  
1.  In the toolbar at the top of the **Threads** window, select the **Group by** list, then select the criteria that you want to group threads by.  
  
2.  In the **Threads** window, select the button at the top of any column.  
  
     The threads are now sorted by the values in that column.  
  
#### To expand or collapse all groups  
  
-   In the toolbar at the top of the **Threads** window, select **Expand Groups** or **Collapse Groups**.  
  
## Search for specific threads  
 In [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)], you can search for threads that match a specified string. When you search for threads in the **Threads** window, the window displays all the threads that match the search string in any column. This information includes the thread location that appears at the top of the call stack in the **Location** column. By default, the full call stack isn't searched.  
  
#### To search for specific threads  
  
-   In the toolbar at the top of the **Threads** window, go to the **Search** box and either:  
  
    -   Type a search string and then press **Enter**.  
  
         \- or -  
  
    -   Select the drop-down list next to the **Search** box and select a search string from a previous search.  
  
-   (Optional) To include the full call stack in your search, select **Search Call Stack**.   
  
## Display thread call stacks and switch between frames  
In a multithreaded program, each thread has its own call stack. The **Threads** window provides a convenient way to view these stacks.

> [!TIP]
> For a visual representation of the call stack for each thread, use the [Parallel Stacks](../debugger/get-started-debugging-multithreaded-apps.md) window.
  
#### To view the call stack of a thread  
  
-   In the **Location** column, select the inverted triangle next to the thread location.  
  
     The location expands to show the call stack for the thread.  
  
#### To view or collapse the call stacks of all threads  
  
-   In the toolbar at the top of the **Threads** window, select **Expand Call Stacks** or **Collapse Call Stacks**.  
  
## See also  
 [Debug multithreaded applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)   
 [Get started debugging a multithreaded application](../debugger/get-started-debugging-multithreaded-apps.md)