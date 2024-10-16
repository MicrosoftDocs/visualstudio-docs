---
title: "Threads view"
description: Learn how to use the Threads view in the Spy++ debugging tool. The Threads view is a flat listing of all threads associated with windows on your system.
ms.date: 02/05/2024
ms.topic: "conceptual"
f1_keywords:
  - "vs.externaltools.spyplus.threadsview"
helpviewer_keywords:
  - "Threads view"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Threads view

The Threads view is a flat listing of all threads associated with windows on your system. The Thread ID and module name for each thread are shown. Processes aren't included, but you can easily find the process that owns a selected thread.

## Procedures

### To open the Threads view

1. From the **Spy** menu, choose **Threads**.

   The following image shows the Threads view.

    :::image type="content" source="media/spy-threads.png" alt-text="Screenshot showing the Threads view.":::

### To open properties for a thread

To find out more about a thread listed in Threads view, use the [Thread Properties dialog box](thread-properties-dialog-box.md).

1. Select a thread from the tree displayed in Threads view.

2. From the **View** menu, choose **Properties**.

   Properties dialog boxes aren't modal, so you can select another item in a view window and the dialog box shows information on the selected item.

## Related sections

- [Using Spy++](using-spy-increment.md): Introduces the Spy++ tool and explains how it can be used.
- [Thread Search dialog box](search-tools-for-spy-increment-views.md#thread-search): Used to find the node for a specific thread in Threads view.
- [Thread Properties dialog box](thread-properties-dialog-box.md): Displays the properties of a thread selected in Threads view or Messages view.
- [Spy++ reference](spy-increment-reference.md): Includes sections describing each Spy++ menu and dialog box.