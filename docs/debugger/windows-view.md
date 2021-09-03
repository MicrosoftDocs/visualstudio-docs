---
title: "Windows View | Microsoft Docs"
description: Windows View shows a tree of all windows and controls. Use it as a starting point to obtain information about windows of interest.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.externaltools.spyplus.windowsview"
helpviewer_keywords:
  - "Windows view"
ms.assetid: 154786ce-c803-4bfb-8198-f7962a900363
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Windows View
When you first open Spy++, Windows view displays a tree of all windows and controls in the system. The window handle and class name are shown. The current desktop window is at the top of the tree. All other windows are children of the desktop, and are listed according to the standard window hierarchy. Sibling windows appear in expansible lists indented below their parents.

 The figure below shows a typical Spy++ Windows view with the top node expanded.

 ![Spy&#43;&#43; Windows View](../debugger/media/spy--_windowsview.png "Spy++_WindowsView")
Spy++ Windows View

 The current desktop window is at the top of the tree. All other windows are children of the desktop, and are listed according to the standard window hierarchy, with sibling windows ordered by Z-order. You can expand or collapse any parent node of the tree by clicking the + or - symbol next to the node.

 When Windows view has the focus, you can use the Finder tool in the [Window Search Dialog Box](../debugger/window-search-dialog-box.md) to display information from any window open on your system.

## In This Section
 [How to: Use the Finder Tool](../debugger/how-to-use-the-finder-tool.md)
 Shows how this tool scans windows for properties or messages.

 [How to: Search for a Window in Windows View](../debugger/how-to-search-for-a-window-in-windows-view.md)
 Explains how to find a specific window in Windows view.

 [How to: Display Window Properties](../debugger/how-to-display-window-properties.md) m
 Procedures for opening the Window Properties dialog box.

## Related Sections
 [Spy++ Views](../debugger/spy-increment-views.md)
 Explains the Spy++ tree views of windows, messages, processes, and threads.

 [Using Spy++](../debugger/using-spy-increment.md)
 Introduces the Spy++ tool and explains how it can be used.

 [Find Window Dialog Box](../debugger/find-window-dialog-box.md)
 Used to view the properties or messages from a specific window.

 [Window Search Dialog Box](../debugger/window-search-dialog-box.md)
 Used to find the node for a specific window in Windows view.

 [Window Properties Dialog Box](../debugger/window-properties-dialog-box.md)
 Used to display the properties of a window selected in Windows view.

 [Spy++ Reference](../debugger/spy-increment-reference.md)
 Includes sections describing each Spy++ menu and dialog box.