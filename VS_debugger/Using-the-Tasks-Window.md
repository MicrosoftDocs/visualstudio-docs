---
title: "Using the Tasks Window"
ms.custom: na
ms.date: 10/10/2016
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
ms.assetid: bd5e0612-a0dc-41cf-a7af-1e87d0d5c35f
caps.latest.revision: 20
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
# Using the Tasks Window
The **Tasks** window resembles the **Threads** window, except that it shows information about <xref:System.Threading.Tasks.Task?qualifyHint=True>, [task_handle](../Topic/task_group%20Class.md), or [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx) objects instead of each thread. Like threads, tasks represent asynchronous operations that can run concurrently; however, multiple tasks may run on the same thread. See [Asynchronous programming in JavaScript (Windows Store apps)](http://msdn.microsoft.com/library/windows/apps/hh700330.aspx) for more information.  
  
 In managed code, you can use the **Tasks** window when you work with <xref:System.Threading.Tasks.Task?qualifyHint=True> objects or with the **await** and **async** keywords (**Await** and **Async** in VisualBasic). For more information about tasks in managed code, see  [Parallel Programming](../Topic/Parallel%20Programming%20in%20the%20.NET%20Framework.md).  
  
 In native code, you can use the **Tasks** window when you work with [task groups](../Topic/Task%20Parallelism%20\(Concurrency%20Runtime\).md), [parallel algorithms](../Topic/Parallel%20Algorithms.md), [asynchronous agents](../Topic/Asynchronous%20Agents.md), and [lightweight tasks](../Topic/Task%20Scheduler%20\(Concurrency%20Runtime\).md). For more information about tasks in native code, see [Concurrency Runtime](../Topic/Concurrency%20Runtime.md).  
  
 In JavaScript, you can use the Tasks window when you are working with promise .then code.  
  
 You can use the **Tasks** window whenever you break into the debugger. You can access it on the **Debug** menu by clicking **Windows** and then clicking **Tasks**. The following illustration shows the **Tasks** window in its default mode.  
  
 ![Parallel Tasks window](../VS_debugger/media/Parallel_Tasks_Window.png "Parallel_Tasks_Window")  
  
> [!NOTE]
>  In managed code, a <xref:System.Threading.Tasks.Task?qualifyHint=False> that has a status of <xref:System.Threading.Tasks.TaskStatus?qualifyHint=False>, <xref:System.Threading.Tasks.TaskStatus?qualifyHint=False>, or <xref:System.Threading.Tasks.TaskStatus?qualifyHint=False> might not be displayed in the Tasks window when managed threads are in a sleep or join state.  
  
## Tasks Column Information  
 The columns in the **Tasks** window show the following information.  
  
|Column Name|Description|  
|-----------------|-----------------|  
|**Flags**|Shows which tasks are flagged and lets you flag or unflag a task.|  
|**Icons**|A yellow arrow indicates the current task. The current task is the top-most task on the current thread.<br /><br /> A white arrow indicates the breaking task, that is, the one that was current when the debugger was invoked.<br /><br /> The pause icon indicates a task that has been frozen by the user. You can freeze and unfreeze a task by right-clicking it in the list.|  
|**ID**|A system-provided number for the task. In native code, this is the address of the task.|  
|**Status**|The current state (scheduled, active, deadlocked, waiting, or completed) of the task. A scheduled task is one that has not yet been run and, therefore, does not yet have a call stack, assigned thread, or related information.<br /><br /> A active task is one that was executing code before breaking in the debugger.<br /><br /> A waiting task is one that is blocked because it is waiting on an event to be signaled, a lock to be released, or another task to finish.<br /><br /> A deadlocked task is a waiting task whose thread is deadlocked with another thread.<br /><br /> Hover over the **Status** cell for a deadlocked or waiting task to see more information about the block. **Warning:**  The **Tasks** window reports deadlock only for a blocked task that uses a synchronization primitive that is supported by Wait Chain Traversal (WCT). For example, for a deadlocked <xref:System.Threading.Tasks.Task?qualifyHint=False> object, which uses WCT, the debugger reports **Waiting-deadlocked**. For a deadlocked task that is managed by the Concurrency Runtime, which does not use WCT, the debugger reports **Waiting**. For more information about WCT, see [Wait Chain Traversal](http://msdn.microsoft.com/library/ms681622\(VS.85\).aspx).|  
|**Start Time**|The time at which the task became active.|  
|**Duration**|The number of seconds that the task has been active.|  
|**Completion Time**|The time at which the task completed.|  
|**Location**|The current location in the call stack of the task. Hover over this cell to see the entire call stack for the task. Scheduled tasks do not have a value in this column.|  
|**Task**|The initial method and any arguments that were passed to the task when it was created.|  
|**Parent**|The ID of the task that created this task. If this is blank, the task has no parent. This is only applicable for managed programs.|  
|**Thread Assignment**|The ID and name of the thread on which the task is running.|  
|**Return Status**|The status of the task when it completed. The return status values are **Success**, **Cancelled**, and **Error**.|  
|**AppDomain**|For managed code, the application domain in which the task is executing.|  
|**task_group**|For native code, the address of the [task_group](../Topic/task_group%20Class.md) object that scheduled the task. For asynchronous agents and lightweight tasks, this column is set to 0.|  
|Process|The ID of the process that the task is running on.|  
|Async State|For managed code, the task status. By default, this column is hidden. To display this column, open the context menu for one of the column headers. Choose **Columns**, **AsyncState**.|  
  
 You can add columns to the view by right-clicking a column heading and then selecting the columns you want. (Remove columns by clearing the selections.) You can also reorder columns by dragging them left or right. The column shortcut menu is shown in the following illustration.  
  
 ![Shortcut view menu in Parallel Tasks window](../VS_debugger/media/Parallel_Tasks_ContextMenu.png "Parallel_Tasks_ContextMenu")  
  
## Sorting Tasks  
 To sort tasks by column criteria, click the column header. For example, by clicking the **ID** column header, you can sort the tasks by task ID: 1,2,3,4,5 and so on. To reverse the sort order, click the column header again. The current sort column and sort order is indicated by an arrow on the column.  
  
## Grouping Tasks  
 You can group tasks based on any column in the list view. For example, by right-clicking the **Status** column header and then clicking **Group by Status**, you can group all tasks that have the same status. For example, you could quickly see waiting tasks so that you could focus on why they are blocked. You can also collapse a group that is not of interest during the debug session. In the same manner, you can group by the other columns. A group can be (un)flagged just by clicking the button next to the group header. The following illustration shows the **Tasks** window in grouped mode.  
  
 ![Grouped mode in Parallel Tasks window](../VS_debugger/media/Parallel_Tasks_GroupedMode.png "Parallel_Tasks_GroupedMode")  
  
## Parent Child View  
 (This view is available for managed code only.) By right-clicking a column heading and then clicking **Parent Child View**, you can change the list of tasks to a hierarchical view, in which every child task is a sub-node that can be displayed or hidden under its parent. The following illustration shows the tasks in parent-child view.  
  
 ![Parent&#45;child view in Parallel Tasks window](../VS_debugger/media/Parallel_Tasks_ParentChildView.png "Parallel_Tasks_ParentChildView")  
  
## Flagging Tasks  
 You can flag the thread the task on which a task is running by selecting the task list item and then choosing **Flag** from the context menu, or by clicking the flag icon in the first column. If you flag several tasks, you can then sort on the flag column to bring all the flagged tasks to the top so that you can focus just on them. You can also use the **Parallel Stacks** window to view only flagged tasks. This lets you filter out tasks that you are not interested in for debugging. Flags are not persisted between debugging sessions.  
  
## Freezing and Thawing Tasks  
 You can freeze the thread on which a task is running by right-clicking the task list item and then clicking **Freeze Assigned Thread**. (If a task is already frozen, the command is **Thaw Assigned Thread**.) When you freeze a thread, that thread will not execute when you step through code after the current breakpoint. The **Freeze All Threads But This** command freezes all threads except the one that is executing the task list item.  
  
 The following illustration shows the other menu items for each task.  
  
 ![Shortcut thread menu in Parallel Tasks window](../VS_debugger/media/Parallel_Tasks_ContextMenu2.png "Parallel_Tasks_ContextMenu2")  
  
## See Also  
 [Debugger Basics](../VS_debugger/Debugger-Basics.md)   
 [Debugging Managed Code](../VS_debugger/Debugging-Managed-Code.md)   
 [Parallel Programming](../Topic/Parallel%20Programming%20in%20the%20.NET%20Framework.md)   
 [Concurrency Runtime](../Topic/Concurrency%20Runtime.md)   
 [Using the Parallel Stacks Window](../VS_debugger/Using-the-Parallel-Stacks-Window.md)   
 [Walkthrough: Debugging a Parallel Application](../VS_debugger/Walkthrough--Debugging-a-Parallel-Application.md)