---
title: Use Windows view
description: Learn how to use the Finder Tool and how to search for a window using the Spy++ Windows view.
ms.date: 02/05/2024
ms.topic: how-to
helpviewer_keywords: 
  - Window Finder Tool
  - searching in Windows view
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# How to use Windows view

You can search for a specific window in Windows view, or use the Finder Tool to display window properties or messages.

When you first open Spy++, Windows view displays a tree of all windows and controls in the system. The window handle and class name are shown. The current desktop window is at the top of the tree. All other windows are children of the desktop, and are listed according to the standard window hierarchy. Sibling windows appear in expansible lists indented below their parents.

The following image shows a typical Spy++ Windows view with the top node expanded.

:::image type="content" source="media/spy-windows-view.png" alt-text="Screenshot of Windows view with the top node expanded.":::

The current desktop window is at the top of the tree. All other windows are children of the desktop, and are listed according to the standard window hierarchy, with sibling windows ordered by Z-order. You can expand or collapse any parent node of the tree by clicking the + or - symbol next to the node.

When Windows view has the focus, you can use the Finder tool in the [Window Search dialog box](search-tools-for-spy-increment-views.md#window-search) to display information from any window open on your system.

## Use the Finder Tool

The Finder Tool in the **Find Window** dialog box can display window properties or messages. The Finder Tool can also locate disabled child windows, and discern which window to highlight if disabled child windows overlap.

The following image shows the **Find Window** dialog box that appears after step 3.

:::image type="content" source="media/icon-spy-find.png" alt-text="Screenshot of the Find Window dialog box.":::

To display window properties or messages:

1. Arrange your windows so that both Spy++ and the target window are visible.

2. From the **Spy** menu, choose **Find Window**.

    The [Find Window dialog box](search-tools-for-spy-increment-views.md#find-window) opens.

3. Drag the **Finder Tool** over the target window. As you drag the tool, the **Find Window** dialog box displays details on the selected window.

    Or, if you have the handle of the window you want to examine (for example, copied from the debugger), type it into the **Handle** text box.

   > [!TIP]
   > To reduce screen clutter, select the **Hide Spy** option. This option conceals the main Spy++ window, leaving only the **Find Window** dialog box visible on top of your other applications. The Spy++ main window is restored when you click **OK** or **Cancel**, or when you clear the **Hide Spy++** option.

4. Under **Show**, select either **Properties** or **Messages**.

5. Press **OK**.

    If you selected **Properties**, the [Window Properties dialog box](/previous-versions/visualstudio/visual-studio-2017/debugger/window-properties-dialog-box) opens. If you selected **Messages**, a [Messages view](../debugger/how-to-use-messages-view.md) window opens.

## Search for a window in Windows view

You can search for a specific window in Windows view by using its handle, caption, class, or a combination of its caption and class as search criteria. You can also specify the initial direction of the search. The fields in the dialog box show the attributes of the selected window in the window tree.

Start with the tree expanded to the second level (all windows that are children of the desktop), so that you can identify desktop-level windows by their class name and title. Once you have chosen a desktop-level window, you can expand that level to find a specific child window.

To search for a window in Windows view:

1. Arrange your windows so that Spy++, the [Windows view](../debugger/how-to-use-windows-view.md) window, and the target window are visible.

2. From the **Search** menu, choose **Find Window**.

    The [Window Search dialog box](search-tools-for-spy-increment-views.md#window-search) opens.

   > [!TIP]
   > To reduce screen clutter, select the **Hide Spy** option. This option conceals the main Spy++ window and leaves only the **Window Search** dialog box visible on top of your other applications. The Spy++ main window is restored when you click **OK** or **Cancel**, or when you clear the **Hide Spy++** option.

3. Drag the **Finder Tool** over the target window. As you drag the tool, the **Window Search** dialog box displays details on the selected window.

    - Alternatively, if you know the handle of the window you want (for example, from the debugger), you can type it in the **Handle** box.
    - Or, if you know the caption and/or class of the window you want, you can type them in the **Caption** and **Class** text boxes, and clear the **Handle** text box.

4. Choose **Up** or **Down** for the initial direction of the search.

5. Select **OK**.

    If a matching window is found, it's highlighted in the [Windows view](../debugger/how-to-use-windows-view.md) window.

## Related content

- [Using Spy++](using-spy-increment.md)
- [Spy++ reference](spy-increment-reference.md)