---
title: "Processes view"
description: Processes view displays a tree of all active processes on your system. Learn about its contents and uses, and follow the links to additional information. 
ms.date: 02/05/2024
ms.topic: "conceptual"
f1_keywords:
  - "vs.externaltools.spyplus.processesview"
helpviewer_keywords:
  - "Processes view"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Processes view

The Processes view displays a tree of all active processes on your system. The process ID and module name are shown. Use the Processes view if you want to examine a particular system process, which usually corresponds to an executing program. Processes are identified by module names, or they're designated *system processes*.

Microsoft Windows supports multiple processes. Each process can have one or more threads, and each thread can have one or more associated top-level windows. Each top-level window can own a series of windows. A **+** symbol indicates that a level is collapsed. The collapsed view consists of one line per process. Select the **+** symbol to expand the level.

Use the Processes view if you want to examine a particular system process, which usually corresponds to an executing program. Processes are identified by module names, or they're designated *system processes*. To find a process, collapse the tree and search the list.

## Procedures

### To open the Processes view

1. From the **Spy** menu, choose **Processes**.

    The following image shows the Processes view with process and thread nodes expanded.

    :::image type="content" source="media/spy-processes.png" alt-text="Screenshot of the Processes view with process and thread nodes expanded.":::

### To open properties for a thread

To find out more about a process listed in Processes view, use the [Process Properties dialog box](process-properties-dialog-box.md).

1. Select a process from the tree displayed in **Processes view**.

2. From the **View** menu, choose **Properties**.

   Properties dialog boxes aren't modal, so you can select another item in a view window and the dialog box shows information on the selected item.

## Related sections

- [Using Spy++](using-spy-increment.md): Introduces the Spy++ tool and explains how it can be used.
- [Process Search dialog box](search-tools-for-spy-increment-views.md#process-search): Used to find the node for a specific process in Processes view.
- [Process Properties dialog box](process-properties-dialog-box.md): Displays the properties of a process selected in Processes View.
- [Spy++ reference](spy-increment-reference.md): Includes sections describing each Spy++ menu and dialog box.