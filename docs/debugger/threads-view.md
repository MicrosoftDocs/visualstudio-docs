---
title: "Threads View | Microsoft Docs"
description: Understand the Threads view in the Spy++ debugging tool. The Threads view is a flat listing of all threads associated with windows on your system.
ms.date: "12/21/2022"
ms.topic: "conceptual"
f1_keywords:
  - "vs.externaltools.spyplus.threadsview"
helpviewer_keywords:
  - "Threads view"
ms.assetid: abfb4e9e-1622-47c9-afda-b6b71a9d88e4
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Threads View

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
The Threads view is a flat listing of all threads associated with windows on your system. The Thread ID and module name for each thread are shown. Processes are not included, but you can easily find the process that owns a selected thread.

## Procedures

### To open the Threads view

1. From the **Spy** menu, choose **Threads**.

   ![Spy&#43;&#43; Threads View](../debugger/media/spy--_threads.png "Spy++_Threads")
   Spy++ Threads View

   The figure above shows the Threads view.

### To open properties for a thread

To find out more about a thread listed in Threads view, use the [Thread Properties Dialog Box](../debugger/thread-properties-dialog-box.md).

1. Select a thread from the tree displayed in Threads view.

2. From the **View** menu, choose **Properties**.

   Properties dialog boxes are not modal, so you can click on another item in a view window and the dialog box will show information on the selected item.

## In This Section

 [Searching for a Thread in Threads View](../debugger/how-to-search-for-a-thread-in-threads-view.md)
 Explains how to find a specific thread in Threads view.

## Related Sections

 [Spy++ Views](../debugger/spy-increment-views.md)
 Explains the Spy++ tree views of windows, messages, processes, and threads.

 [Using Spy++](../debugger/using-spy-increment.md)
 Introduces the Spy++ tool and explains how it can be used.

 [Thread Search Dialog Box](../debugger/thread-search-dialog-box.md)
 Used to find the node for a specific thread in Threads view.

 [Thread Properties Dialog Box](../debugger/message-properties-dialog-box.md)
 Displays the properties of a thread selected in Threads view or Messages view.

 [Spy++ Reference](../debugger/spy-increment-reference.md)
 Includes sections describing each Spy++ menu and dialog box.