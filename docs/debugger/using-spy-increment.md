---
title: Use Spy++ to view threads, windows, and messages
description: Learn how to use Spy++ to get a graphical view of the system's processes, threads, windows, and window messages.
ms.date: 02/05/2024
ms.topic: "conceptual"
helpviewer_keywords:
  - Using Spy++
  - viewing code, refreshing views, fonts
  - expanding and collapsing Spy++ trees
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Using Spy++

You can use Spy++ to perform the following tasks.

To install required components for Spy++, see [Start Spy++](../debugger/how-to-start-spy-increment.md).

## Spy++ views

When Spy++ starts, it opens in [Windows view](../debugger/how-to-use-windows-view.md), a tree view of all windows and controls available on your machine. This root window is captioned **Windows 1**. There are also three other Spy++ views available:

- Messages view
- Processes view
- Threads view

You can display the desired view from the **Spy** menu.

### Messages view

You can choose the windows and message types shown in a Messages view window.

For more information on using Messages view, see [Using Messages view](../debugger/how-to-use-messages-view.md)

### Processes view

The Processes view displays a tree of all active processes on your system. The process ID and module name are shown. Use the Processes view if you want to examine a particular system process, which usually corresponds to an executing program. Processes are identified by module names, or they're designated *system processes*.

Microsoft Windows supports multiple processes. Each process can have one or more threads, and each thread can have one or more associated top-level windows. Each top-level window can own a series of windows. A **+** symbol indicates that a level is collapsed. The collapsed view consists of one line per process. Select the **+** symbol to expand the level.

Use the Processes view if you want to examine a particular system process, which usually corresponds to an executing program. Processes are identified by module names, or they're designated *system processes*. To find a process, collapse the tree and search the list.

For information on searching for a process, see [Search for a process in Processes view](../debugger/how-to-search-for-a-process-in-processes-view.md).

### Threads view

The Threads view is a flat listing of all threads associated with windows on your system. The Thread ID and module name for each thread are shown. Processes aren't included, but you can easily find the process that owns a selected thread.

For information on searching for a thread, see [Search for a thread in Threads view](../debugger/how-to-search-for-a-thread-in-threads-view.md).

## Refresh the view

Spy++ takes a *snapshot* of the system tables and refreshes a view based on this information. It's important that you periodically refresh your system views. If you have a Spy++ view open and haven't refreshed the view, you don't see those processes, threads, and windows that are later created. Also, you might see items that no longer exist. The **Refresh** command is available for all views except the Messages view.

To refresh the currently active view:

- Select **Refresh** from the **Window** menu, or choose the **Refresh** button in the toolbar.

## Change fonts

You can change the font, font style, and font size for Spy++ windows.

To change font options:

1. From the **View** menu, select **Font**.

2. Choose a font, font style, and font size.

3. Select **OK**.

   Selecting **Save Font As Default** causes all future Spy++ windows to use this font.

## Expand and collapse Spy++ trees

You can expand and collapse the windows, processes, and threads views by using two methods: by selecting the icons in the window or by using the **Tree** menu. The **+** and **-** icons in the tree act as they do in the C++ project window.

The **Tree** menu contains four commands:

|Menu command|Description|
|------------------|-----------------|
|**Expand one level**|Expands the currently selected item to the next level.|
|**Expand branch**|Fully expands the currently selected item.|
|**Expand all**|Fully expands all items in the window.|
|**Collapse**|Fully collapses the currently selected item.|

> [!TIP]
> If you expand a process, you see all the threads the process owns. If you expand a thread, you see a list of all the windows it owns.

To expand or collapse Spy++ trees:

1. Highlight one of the items in the windows, processes, or threads view.

2. From the **Tree** menu, choose one of the expand or collapse commands.

## Related sections

- [Spy++ reference](spy-increment-reference.md)
