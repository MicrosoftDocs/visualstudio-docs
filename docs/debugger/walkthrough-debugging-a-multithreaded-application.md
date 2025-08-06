---
title: View threads in the debugger
description: Explore the Threads window in the Visual Studio debugger. Group, sort, flag, freeze, thaw, and search for threads. Display call stacks in C#, Visual Basic, and C++.
ms.date: 8/5/2025
ms.topic: concept-article
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
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics

#customer intent: As a developer, I want to use the Threads window in the Visual Studio debugger, so I can examine and control threads in my C#, Visual Basic, or C++ code.
---

# View threads in the Visual Studio debugger (C#, Visual Basic, C++)

The **Threads** window in the Visual Studio debugger lets you examine and work with threads in the application you're debugging. The window provides features to group, sort, flag, freeze, thaw, and search for threads in your code, and display call stacks. 

The **Threads** window is available only while the Visual Studio debugger is running. During a debugging session, you can open the window by selecting **Debug** > **Windows** > **Threads**.

::: moniker range=">= vs-2022"
This article describes how to work with the **Threads** window for your C#, Visual Basic, or C++ programs. However, the **Threads** view in the Parallel Stacks window is often more helpful for debugging. For more information, see [Debug a deadlock using the Threads view](./how-to-use-the-threads-window.md) and [View threads and tasks in the Parallel Stacks window](../debugger/using-the-parallel-stacks-window.md).
::: moniker-end

::: moniker range="vs-2019"
This article describes how to work with the **Threads** window for your C#, Visual Basic, or C++ programs. However, the **Threads** view in the Parallel Stacks window is often more helpful for debugging. For more information, see [View threads and tasks in the Parallel Stacks window](../debugger/using-the-parallel-stacks-window.md).
::: moniker-end

## Explore the Threads window table

The **Threads** window presents a table where each row corresponds to a separate thread in your application. In the default view, the table shows all threads in your application. You can configure the table settings to show only the threads that interest you. The table provides multiple columns to describe the threads in detail. You can adjust the column placement and hide unnecessary columns.

The following table describes all available columns for the **Threads** window table and indicates whether the column is visible or hidden in the default view. The columns are listed according to their default table position from left to right.

| Column | Default | Description |
| --- | --- | --- |
| **Flag** | Visible, unlabeled | Red flags in this column indicate threads marked for special attention. Select the flag (icon color changes to red) to mark or unmark (icon changes to flag outline) a thread. The colored flag icon helps to distinguish a marked thread from other threads in the table. For more information, see [Flag and unflag threads](./how-to-flag-and-unflag-threads.md). |
| **Current thread** | Visible, unlabeled | The yellow arrow icon in this column indicates the current thread in the application running in the debugger. An arrow outline icon in this column indicates the current debugger context for a noncurrent thread. |
| **ID** | Visible | Provides the identification number for each thread. |
| **Managed ID** | Visible | Displays the managed identification numbers for managed threads. |
| **Category** | Visible | Indicates the category of threads as either user interface threads, remote procedure call handlers, or worker threads. A special category identifies the main thread of the application. |
| **Name** | Visible | Identifies each thread by its name, or \<No Name> if the thread has no specified name. When a thread no longer exists, the thread has the label [Thread Destroyed]. |
| **Location** | Visible | Shows where the thread is running within the application call stack. Select the dropdown arrow to see the full call stack for the thread. When a thread no longer exists, the location is labeled as \<not available>. |
| **Priority** | Hidden | Displays the priority or precedence assigned by the system to each thread. |
| **Affinity Mask** | Hidden | Shows the processor affinity mask for each thread. In a multiprocessor system, the affinity mask determines the processors on which a thread can run. |
| **Suspended Count** | Hidden | Provides the suspended count. This count determines whether a thread can run. For more information, see [Freeze and thaw threads](#freeze-and-thaw-threads). |
| **Process Name** | Hidden | Displays the process to which each thread belongs. The data in this column can be useful when you're debugging many processes. |
| **Process ID** | Hidden | Shows the process ID to which each thread belongs. |
| **Transport Qualifier** | Hidden | Uniquely identifies the machine to which the debugger is connected. |

### Show and hide table columns

In the **Threads** window toolbar, the **Columns** dropdown shows the list of available columns. Expand the dropdown list and select a column name to toggle its visibility in the table. Visible columns are indicated with a checkmark in the list.

## Flag threads for special attention

Use the flag icon to mark threads for special attention. Marked threads are indicated by a red flag icon in the **Threads** window table. For more information, see [Flag and Unflag threads](./how-to-flag-and-unflag-threads.md). 

### Show only flagged threads

You can filter the **Threads** window to show only flagged threads. In the **Threads** window toolbar, select **Show Only Flagged Threads** (double flag icon). You can also use the **Ctrl** + **9** keyboard shortcut. This action is available only when there are flagged threads.

## Freeze and thaw threads

When you freeze a thread, the system doesn't start execution of the thread, even if resources are available.

In native code, you can suspend or resume threads by calling the Windows functions `SuspendThread` and `ResumeThread`. You can also call the MFC functions [CWinThread::SuspendThread](/cpp/mfc/reference/cwinthread-class#suspendthread) and [CWinThread::ResumeThread](/cpp/mfc/reference/cwinthread-class#resumethread). If you call the `SuspendThread` or `ResumeThread` function, the *suspended count* shown in the **Threads** window changes. The suspended count doesn't change if you freeze or thaw a native thread. A thread can't execute in native code unless the thread is thawed and has a suspended count of zero.

In managed code, the suspended count changes when you freeze or thaw a thread. If you freeze a thread in managed code, its suspended count is 1. When you freeze a thread in native code, its suspended count is 0, unless you use the `SuspendThread` call.

> [!NOTE]
> When you debug a call from native code to managed code, the managed code runs in the same physical thread as the calling native code. Suspending or freezing the native thread also freezes the managed code.

### Change execution for selected threads

You can freeze or thaw execution of one or more threads. In the **Threads** window, select the threads for which you want to update the execution state. In the **Threads** window toolbar, select **Freeze Threads** (pause play icon) or **Thaw Threads** (green play icon). The action applies only to the currently selected threads. The freeze and thaw actions are also available on the right-click context menu for each thread.

## Change the current thread

::: moniker range=">= vs-2022"

A yellow arrow icon in the **Threads** window table indicates the current thread (and the location of the execution pointer). The original current thread marker also remains (shown with an arrow outline icon).

::: moniker-end
::: moniker range="vs-2019"

A yellow arrow icon in the **Threads** window table indicates the current thread (and the location of the execution pointer). A green arrow icon with a curly tail indicates a noncurrent thread has the current debugger context.

::: moniker-end

### Switch to another thread

There are two ways you can switch the current thread in the debugger. Double-click any thread in the **Threads** window table to make it the current thread. You can also right-click a thread and select **Switch To Thread**.

## Apply grouping and sorting to threads

You can group threads in the **Threads** window table by using the same criteria as the available columns. All criteria are always available for grouping, regardless of whether the corresponding column is visible in the current view. You can select only one grouping for the table.

When you group threads, a heading appears in the table for each group. The heading includes a group description along with the number of members in the group. If you group by **Name**, you might see groupings with headings like **Worker Thread** or **Unflagged Threads**. An expand/collapse arrow icon appears next to each group heading.

After you apply a grouping criteria, the view for the **Threads** window table updates to show the member threads for each group under their heading. Use the expand/collapse arrow icon for a group to show or hide the members in the current view. 

You can also apply a single sorting criteria to the threads in the **Threads** window table. Grouping takes precedence over sorting. For example, you can group threads by **Category** and then sort them by **ID** within each **Category**.

### Group threads in the table

In the **Threads** window toolbar, expand the **Group by** dropdown list, and select the criteria for grouping the threads. You can also remove the applied grouping by selecting **None** in the **Group by** dropdown list.

### Sort threads in the table

You apply sorting to threads in the **Threads** window table by selecting the column headers at the top of the table, such as **Name** or **ID**.

When you select a column header, the view for the **Threads** window table updates to show the threads sorted by the values in the selected column. The selected column also shows an up/down arrow icon. The up arrow icon indicates sorting by the selected column in ascending order. The down arrow icon indicates sorting by the selected column in descending order. Select the column header to change the sort order.

### Sort threads within groups

To sort threads within groups in the **Threads** window, first use the **Group by** dropdown list to apply the grouping criteria. Then, select the column header to sort the grouped threads by the values in the selected column.

### Expand or collapse all groups

There's a quick way to show or hide all groupings in the current view. In the **Threads** window toolbar, select **Expand groups** (double box icon with plus symbol) or **Collapse groups** (double box icon with minus symbol).

## Search for threads

You can search the threads in the **Threads** window table and look for specific content in any of the visible table columns. When you do the search, Visual Studio displays the thread rows that have column data that matches the search string. The search also scans the thread location that appears at the top of the call stack in the **Location** column.

### Search for specific content in threads

There are several ways you can search threads for specific content. In the **Threads** window toolbar, enter the string to look for in the **Search** box and select **Enter**. You can specify letters, numbers, and special characters like `<` in your search string. When the search completes, the **Threads** window updates the table to show threads with matching results. Visual Studio highlights the specific instances that match your search string. To return to the regular thread view, select the X icon next to the **Search** box. 

You can also search for a string you previously looked for. Use the **Search** dropdown box and select a previous search string.

### Search the full call stack

By default, the full call stack isn't searched. Visual Studio searches for a match only in the threads visible in the **Threads** window table.

You can include the full call stack by selecting **Include call stacks in search** (list item icon) in the **Threads** window toolbar. When the option is enabled, the list item icon has a border.

## Display call stacks and switch between frames

In a multithreaded program, each thread has its own call stack. The **Threads** window provides a convenient way to view these stacks.

> [!TIP]
> For a visual representation of the call stack for each thread, use the [Parallel Stacks](./get-started-debugging-multithreaded-apps.md) window.

### View call stack for thread

In the **Threads** window table, locate the thread for which you want to examine the full call stack. In the **Location** column, select the expand/collapse arrow to the left of the thread location. The location expands to show the complete call stack for the thread. Select the arrow again to show only the location.

### View or collapse all call stacks

You can control whether the **Threads** window always shows the full call stacks for all threads in the table. In the **Threads** window toolbar, select **Expand call stacks** (box icon with plus symbol) or **Collapse call stacks** (box icon with minus symbol).

## Related content

- [Debug multithreaded applications](./debug-multithreaded-applications-in-visual-studio.md)
- [Get started debugging multithreaded applications](./get-started-debugging-multithreaded-apps.md)
