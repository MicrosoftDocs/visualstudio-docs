---
title: "Windows view"
description: Windows view shows a tree of all windows and controls. Use it as a starting point to obtain information about windows of interest.
ms.date: 02/05/2024
ms.topic: "conceptual"
f1_keywords:
  - "vs.externaltools.spyplus.windowsview"
helpviewer_keywords:
  - "Windows view"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Windows view

When you first open Spy++, Windows view displays a tree of all windows and controls in the system. The window handle and class name are shown. The current desktop window is at the top of the tree. All other windows are children of the desktop, and are listed according to the standard window hierarchy. Sibling windows appear in expansible lists indented below their parents.

The following image shows a typical Spy++ Windows view with the top node expanded.

:::image type="content" source="media/spy-windows-view.png" alt-text="Screenshot of Windows view with the top node expanded.":::

The current desktop window is at the top of the tree. All other windows are children of the desktop, and are listed according to the standard window hierarchy, with sibling windows ordered by Z-order. You can expand or collapse any parent node of the tree by clicking the + or - symbol next to the node.

When Windows view has the focus, you can use the Finder tool in the [Window Search dialog box](search-tools-for-spy-increment-views.md#window-search) to display information from any window open on your system.

## Open properties for a window

To find out more about a window listed in Windows view, use the [Window Properties dialog box](window-properties-dialog-box.md).

* Select the item, then choose **Properties** from the **View** menu.

   Properties dialog boxes aren't modal. As you select from item to item in a view window, the dialog box is automatically refreshed with information on each item selected.

## Related sections

- [Using Spy++](using-spy-increment.md): Introduces the Spy++ tool and explains how it can be used.
- [Window Search dialog box](search-tools-for-spy-increment-views.md#window-search): Used to find the node for a specific window in Windows view.
- [Window Properties dialog box](window-properties-dialog-box.md): Used to display the properties of a window selected in Windows view.
- [Spy++ reference](spy-increment-reference.md): Includes sections describing each Spy++ menu and dialog box.