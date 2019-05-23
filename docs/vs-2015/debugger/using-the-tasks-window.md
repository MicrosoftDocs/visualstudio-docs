---
title: "Using the Tasks Window | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.paralleltasks"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugger, parallel tasks window"
ms.assetid: bd5e0612-a0dc-41cf-a7af-1e87d0d5c35f
caps.latest.revision: 23
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Using the Tasks Window
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The **Tasks** window resembles the **Threads** window, except that it shows information about <xref:System.Threading.Tasks.Task?displayProperty=fullName>, [task_handle](https://msdn.microsoft.com/library/b4af5b28-227d-4488-8194-0a0d039173b7), or [WinJS.Promise](https://msdn.microsoft.com/library/windows/apps/br211867.aspx) objects instead of each thread. Like threads, tasks represent asynchronous operations that can run concurrently; however, multiple tasks may run on the same thread. See [Asynchronous programming in JavaScript (Windows Store apps)](https://msdn.microsoft.com/library/windows/apps/hh700330.aspx) for more information.  
  
 In managed code, you can use the **Tasks** window when you work with <xref:System.Threading.Tasks.Task?displayProperty=fullName> objects or with the **await** and **async** keywords (**Await** and **Async** in VisualBasic). For more information about tasks in managed code, see  [Parallel Programming](https://msdn.microsoft.com/library/4d83c690-ad2d-489e-a2e0-b85b898a672d).  
  
 In native code, you can use the **Tasks** window when you work with [task groups](https://msdn.microsoft.com/library/42f05ac3-2098-494a-ba84-737fcdcad077), [parallel algorithms](https://msdn.microsoft.com/library/045dca7b-4d73-4558-a44c-383b88a28473), [asynchronous agents](https://msdn.microsoft.com/library/6cf6ccc6-87f1-4e14-af15-ea8ba58fef1a), and [lightweight tasks](https://msdn.microsoft.com/library/9aba278c-e0c9-4ede-b7c6-fedf7a365d90). For more information about tasks in native code, see [Concurrency Runtime](https://msdn.microsoft.com/library/874bc58f-8dce-483e-a3a1-4dcc9e52ed2c).  
  
 In JavaScript, you can use the Tasks window when you are working with promise .then code.  
  
 You can use the **Tasks** window whenever you break into the debugger. You can access it on the **Debug** menu by clicking **Windows** and then clicking **Tasks**. The following illustration shows the **Tasks** window in its default mode.  
  
 ![Parallel Tasks window](../debugger/media/parallel-tasks-window.png "Parallel_Tasks_Window")  
  
> [!NOTE]
> In managed code, a <xref:System.Threading.Tasks.Task> that has a status of <xref:System.Threading.Tasks.TaskStatus>, <xref:System.Threading.Tasks.TaskStatus>, or <xref:System.Threading.Tasks.TaskStatus> might not be displayed in the Tasks window when managed threads are in a sleep or join state.  
  
## Tasks Column Information  
 The columns in the **Tasks** window show the following information.  
  
|Column Name|Description|  
|-----------------|-----------------|  
|**Flags**|Shows which tasks are flagged and lets you flag or unflag a task.|  
|**Icons**|A yellow arrow indicates the current task. The current task is the top-most task on the current thread.<br /><br /> A white arrow indicates the breaking task, that is, the one that was current when the debugger was invoked.<br /><br /> The pause icon indicates a task that has been frozen by the user. You can freeze and unfreeze a task by right-clicking it in the list.|  
|**ID**|A system-provided number for the task. In native code, this is the address of the task.|  
|**Status**|The current state (scheduled, active, deadlocked, waiting, or completed) of the task. A scheduled task is one that has not yet been run and, therefore, does not yet have a call stack, assigned thread, or related information.<br /><br /> A active task is one that was executing code before breaking in the debugger.<br /><br /> A waiting task is one that is blocked because it is waiting on an event to be signaled, a lock to be released, or another task to finish.<br /><br /> A deadlocked task is a waiting task whose thread is deadlocked with another thread.<br /><br /> Hover over the **Status** cell for a deadlocked or waiting task to see more information about the block. **Warning:**  The **Tasks** window reports deadlock only for a blocked task that uses a synchronization primitive that is supported by Wait Chain Traversal (WCT). For example, for a deadlocked <xref:System.Threading.Tasks.Task> object, which uses WCT, the debugger reports **Waiting-deadlocked**. For a deadlocked task that is managed by the Concurrency Runtime, which does not use WCT, the debugger reports **Waiting**. For more information about WCT, see [Wait Chain Traversal](https://msdn.microsoft.com/library/ms681622\(VS.85\).aspx).|  
|**Start Time**|The time at which the task became active.|  
|**Duration**|The number of seconds that the task has been active.|  
|**Completion Time**|The time at which the task completed.|  
|**Location**|The current location in the call stack of the task. Hover over this cell to see the entire call stack for the task. Scheduled tasks do not have a value in this column.|  
|**Task**|The initial method and any arguments that were passed to the task when it was created.|  
|**Parent**|The ID of the task that created this task. If this is blank, the task has no parent. This is only applicable for managed programs.|  
|**Thread Assignment**|The ID and name of the thread on which the task is running.|  
|**Return Status**|The status of the task when it completed. The return status values are **Success**, **Cancelled**, and **Error**.|  
|**AppDomain**|For managed code, the application domain in which the task is executing.|  
|**task_group**|For native code, the address of the [task_group](https://msdn.microsoft.com/library/b4af5b28-227d-4488-8194-0a0d039173b7) object that scheduled the task. For asynchronous agents and lightweight tasks, this column is set to 0.|  
|Process|The ID of the process that the task is running on.|  
|Async State|For managed code, the task status. By default, this column is hidden. To display this column, open the context menu for one of the column headers. Choose **Columns**, **AsyncState**.|  
  
 You can add columns to the view by right-clicking a column heading and then selecting the columns you want. (Remove columns by clearing the selections.) You can also reorder columns by dragging them left or right. The column shortcut menu is shown in the following illustration.  
  
 ![Shortcut view menu in Parallel Tasks window](../debugger/media/parallel-tasks-contextmenu.png "Parallel_Tasks_ContextMenu")  
  
## Sorting Tasks  
 To sort tasks by column criteria, click the column header. For example, by clicking the **ID** column header, you can sort the tasks by task ID: 1,2,3,4,5 and so on. To reverse the sort order, click the column header again. The current sort column and sort order is indicated by an arrow on the column.  
  
## Grouping Tasks  
 You can group tasks based on any column in the list view. For example, by right-clicking the **Status** column header and then clicking **Group by Status**, you can group all tasks that have the same status. For example, you could quickly see waiting tasks so that you could focus on why they are blocked. You can also collapse a group that is not of interest during the debug session. In the same manner, you can group by the other columns. A group can be (un)flagged just by clicking the button next to the group header. The following illustration shows the **Tasks** window in grouped mode.  
  
 ![Grouped mode in Parallel Tasks window](../debugger/media/parallel-tasks-groupedmode.png "Parallel_Tasks_GroupedMode")  
  
## Parent Child View  
 (This view is available for managed code only.) By right-clicking a column heading and then clicking **Parent Child View**, you can change the list of tasks to a hierarchical view, in which every child task is a sub-node that can be displayed or hidden under its parent. The following illustration shows the tasks in parent-child view.  
  
 ![Parent&#45;child view in Parallel Tasks window](../debugger/media/parallel-tasks-parentchildview.png "Parallel_Tasks_ParentChildView")  
  
## Flagging Tasks  
 You can flag the thread the task on which a task is running by selecting the task list item and then choosing **Flag** from the context menu, or by clicking the flag icon in the first column. If you flag several tasks, you can then sort on the flag column to bring all the flagged tasks to the top so that you can focus just on them. You can also use the **Parallel Stacks** window to view only flagged tasks. This lets you filter out tasks that you are not interested in for debugging. Flags are not persisted between debugging sessions.  
  
## Freezing and Thawing Tasks  
 You can freeze the thread on which a task is running by right-clicking the task list item and then clicking **Freeze Assigned Thread**. (If a task is already frozen, the command is **Thaw Assigned Thread**.) When you freeze a thread, that thread will not execute when you step through code after the current breakpoint. The **Freeze All Threads But This** command freezes all threads except the one that is executing the task list item.  
  
 The following illustration shows the other menu items for each task.  
  
 ![Shortcut thread menu in Parallel Tasks window](../debugger/media/parallel-tasks-contextmenu2.png "Parallel_Tasks_ContextMenu2")  
  
## See Also  
 [Debugger Basics](../debugger/debugger-basics.md)   
 [Debugging Managed Code](../debugger/debugging-managed-code.md)   
 [Parallel Programming](https://msdn.microsoft.com/library/4d83c690-ad2d-489e-a2e0-b85b898a672d)   
 [Concurrency Runtime](https://msdn.microsoft.com/library/874bc58f-8dce-483e-a3a1-4dcc9e52ed2c)   
 [Using the Parallel Stacks Window](../debugger/using-the-parallel-stacks-window.md)   
 [Walkthrough: Debugging a Parallel Application](../debugger/walkthrough-debugging-a-parallel-application.md)
