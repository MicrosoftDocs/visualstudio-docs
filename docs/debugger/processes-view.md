---
title: "Processes View | Microsoft Docs"
description: Processes view displays a tree of all active processes on your system. Learn about its contents and uses, and follow the links to additional information. 
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.externaltools.spyplus.processesview"
helpviewer_keywords:
  - "Processes view"
ms.assetid: e144e70e-eef2-45a7-a562-a177f177d9a1
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Processes View
The Processes view displays a tree of all active processes on your system. The process ID and module name are shown. Use the Processes view if you want to examine a particular system process, which usually corresponds to an executing program. Processes are identified by module names, or they are designated "system processes."

 Microsoft Windows supports multiple processes. Each process can have one or more threads, and each thread can have one or more associated top-level windows. Each top-level window can own a series of windows. A + symbol indicates that a level is collapsed. The collapsed view consists of one line per process. Click the + symbol to expand the level.

 Use the Processes view if you want to examine a particular system process, which usually corresponds to an executing program. Processes are identified by module names, or they are designated "system processes." To find a process, collapse the tree and search the list.

## Procedures

#### To open the Processes view

1. From the **Spy** menu, choose **Processes**.

   ![Spy&#43;&#43; Processes View](../debugger/media/spy--_processes.png "Spy++_Processes")
   Spy++ Processes View

   The figure above shows the Processes view with process and thread nodes expanded.

### In This Section
 [Searching for a Process in Processes View](../debugger/how-to-search-for-a-process-in-processes-view.md)
 Explains how to find a specific process in Processes view.

 [Displaying Process Properties](../debugger/how-to-display-process-properties.md)
 Explains how to show more information about a message.

### Related Sections
 [Spy++ Views](../debugger/spy-increment-views.md)
 Explains the Spy++ tree views of windows, messages, processes, and threads.

 [Using Spy++](../debugger/using-spy-increment.md)
 Introduces the Spy++ tool and explains how it can be used.

 [Process Search Dialog Box](../debugger/process-search-dialog-box.md)
 Used to find the node for a specific process in Processes view.

 [Process Properties Dialog Box](../debugger/process-properties-dialog-box.md)
 Displays the properties of a process selected in Processes View.

 [Spy++ Reference](../debugger/spy-increment-reference.md)
 Includes sections describing each Spy++ menu and dialog box.