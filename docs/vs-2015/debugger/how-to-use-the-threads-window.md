---
title: "How to: Use the Threads Window | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.threads"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "threading [Visual Studio], debugging"
  - "Thread.Name property"
  - "debugger, Threads window"
  - "SetThreadName function"
  - "Threads window"
  - "@TIB"
  - "debugging [Visual Studio], threads"
ms.assetid: adfbe002-3d7b-42a9-b42a-5ac0903dfc25
caps.latest.revision: 48
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Use the Threads Window
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In the **Threads** window, you can examine and work with threads in the application that you are debugging.  
  
 The **Threads** window contains a table where each row represents a thread in your application. By default, the table lists all threads in your application, but you can filter the list to show only the threads that interest you. Each column contains a different type of information. You can also hide some columns. If you display all columns, the following information appears, from left to right:  
  
- The flag column, where you can mark a thread to which you want to pay special attention. For information about how to flag a thread, see [How to: Flag and Unflag Threads](../debugger/how-to-flag-and-unflag-threads.md).  
  
- The active thread column, where a yellow arrow indicates an active thread. An outline of an arrow indicates the thread where execution broke into the debugger.  
  
- The **ID** column, which contains the identification number for each thread.  
  
- The **Managed ID** column, which contains the managed identification numbers for managed threads.  
  
- The **Category** column, which categorizes threads as user interface threads, remote procedure call handlers, or worker threads. A special category identifies the main thread of the application.  
  
- The **Name** column, which identify each thread by name, if it has one, or as \<No Name>.  
  
- The **Location** column, which shows where the thread is running. You can expand this location to show the full call stack for the thread.  
  
- The **Priority** column, which contains the priority or precedence that the system has assigned to each thread.  
  
- The **Affinity Mask** column, which is an advanced column that is usually hidden. This column shows the processor affinity mask for each thread. In a multiprocessor system, the affinity mask determines which processors on which a thread can run.  
  
- The **Suspended Count** column, which contains the suspended count. This count determines whether a thread can run. For an explanation of suspended count, see "Freezing and Thawing Threads" later in this topic.  
  
- The **Process Name** column, which contains the process to which each thread belongs. This column can be useful when you are debugging multiple processes, but it is usually hidden.  
  
### To display the Threads window in break mode or run mode  
  
- On the **Debug** menu, point to **Windows**, and then click **Threads**.  
  
### To display or hide a column  
  
- In the toolbar at the top of the **Threads** window, click **Columns**, then select or clear the name of the column that you want to display or hide.  
  
### To switch the active thread  
  
- Perform either of the following steps:  
  
  - Double-click any thread.  

  - Right-click a thread and click **Switch to Thread**.  

    The yellow arrow appears next to the new active thread. The gray outline of an arrow identifies the thread where execution broke into the debugger.  
  
## Grouping and Sorting Threads  
 When you group threads, a heading appears in the table for each group. The heading contains a group description, such as "Worker Thread" or "Unflagged Threads," and a tree control. The member threads of each group appear under the group heading. If you want to hide the member threads for a group, you can use the tree control to collapse the group.  
  
 Because grouping takes precedence over sorting, you can group threads by category, for example, and then sort them by ID within each category.  
  
#### To sort threads  
  
1. In the toolbar at the top of the **Threads** window, click the button at the top of any column.  
  
     The threads are now sorted by the values in that column.  
  
2. If you want to reverse the sort order, click the same button again.  
  
     Threads that appeared at the top of the list now appear on the bottom.  
  
#### To group threads  
  
- In the **Threads** window toolbar, click the **Group by** list, then click the criteria that you want to group threads by.  
  
#### To sort threads within groups  
  
1. In the toolbar at the top of the **Threads** window, click the **Group by** list, then click the criteria that you want to group threads by.  
  
2. In the **Threads** window, click the button at the top of any column.  
  
     The threads are now sorted by the values in that column.  
  
#### To expand or collapse all groups  
  
- In the toolbar at the top of the **Threads** window, click **Expand Groups** or **Collapse Groups**.  
  
## Searching for Specific Threads  
 In [!INCLUDE[vs_dev11_long](../includes/vs-dev11-long-md.md)], you can search for threads that match a specified string. When you search for threads in the **Threads** window, the window displays all threads that match the search string in any column. That information includes the thread location that appears at the top of the call stack in the **Location** column. By default, however, the full call stack is not searched.  
  
#### To search for specific threads  
  
- In the toolbar at the top of the **Threads** window, go to the **Search** box and either:  
  
  - Type a search string and then press ENTER.  

    \- or -  

  - Click the drop-down list next to the **Search** box and select a search string from a previous search.  
  
- (Optional) To include the full call stack in your search, select **Search Call Stack**.  
  
## Freezing and Thawing Threads  
 When you freeze a thread, the system will not start execution of the thread even if resources are available.  
  
 In native code, you can suspend or resume threads by calling the Windows functions `SuspendThread` and `ResumeThread` or the MFC functions [CWinThread::SuspendThread](https://msdn.microsoft.com/library/57189c7e-fd71-42e5-bc4b-3de7cd373d28) and [CWinThread::ResumeThread](https://msdn.microsoft.com/library/d6f97a2f-5c9f-4ee1-b978-d74938784db5). If you call `SuspendThread` or `ResumeThread`, you change the *suspended count*, which appears in the **Threads** window. However, if you freeze or thaw a native thread, you do not change the suspended count. In native code, a thread cannot execute unless it is thawed and has a suspended count of zero.  
  
 In managed code, freezing or thawing a thread does change the suspended count. In managed code, a frozen thread has a suspended count of 1. In native code, a frozen thread has a suspended count of 0 unless the thread has been suspended by a `SuspendThread` call.  
  
> [!NOTE]
> When you debug a call from native code to managed code, the managed code runs in the same physical thread as the native code that called it. Suspending or freezing the native thread freezes the managed code also.  
  
#### To freeze or thaw execution of a thread  
  
- In the toolbar at the top of the **Threads** window, click **Freeze Threads** or **Thaw Threads**.  
  
     This action affects only threads that are selected in the **Threads** window.  
  
## Displaying Flagged Threads  
 You can flag a thread that you want to give special attention by marking it with an icon in the **Threads** window. For more information, see [How to: Flag and Unflag Threads](../debugger/how-to-flag-and-unflag-threads.md). In the Threads window you can choose to display all the threads or only the flagged threads.  
  
#### To display only flagged threads  
  
- Choose the flag button in the upper-left corner of the **Threads** window.  
  
## Displaying Thread Call Stacks and Switching Between Frames  
 In a multithreaded program, each thread has its own call stack. The **Threads** window provides a convenient way to view these stacks.  
  
#### To view the call stack of a thread  
  
- In the **Location** column, click the inverted triangle next to the thread location.  
  
     The location expands to show the call stack for the thread.  
  
#### To view or collapse the call stacks of all threads  
  
- In the toolbar at the top of the **Threads** window, click **Expand Call Stacks** or **Collapse Call Stacks**.  
  
## See Also  
 [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)   
 [Walkthrough: Debugging a Multithreaded Application](../debugger/walkthrough-debugging-a-multithreaded-application.md)
