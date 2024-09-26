---
title: Set bookmarks in Visual Studio
description: Learn how to use bookmarks to mark lines in your code so that you can quickly return to a specific location, or jump back and forth between locations.
titleSuffix: ''
ms.date: 09/12/2024
ms.topic: how-to
f1_keywords:
- VS.BookmarkWindow
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Bookmark code in Visual Studio

You can use bookmarks to mark lines in your code so that you can quickly return to a specific location, or jump back and forth between locations. Bookmarks can help you keep track of important parts of your code and remind you of what you might want to work on next, which can improve your productivity.

Bookmark commands and icons are available in two places: 

- The **Text Editor** toolbar, which is the row of buttons under the menu bar in Visual Studio.
  
  ::: moniker range="<=vs-2019"

    :::image type="content" source="media/vs-2019/tutorial-editor-toolbar-bookmarks.png" alt-text="Screenshot of Bookmark commands and icons in the Text Editor toolbar in Visual Studio 2022.":::

  ::: moniker-end

  ::: moniker range=">=vs-2022"

  :::image type="content" source="media/vs-2022/tutorial-editor-toolbar-bookmarks.png" alt-text="Screenshot of Bookmark commands and icons in the Text Editor toolbar in Visual Studio 2022.":::

  ::: moniker-end

- The **Bookmarks** toolbar in the **Bookmarks** window; to open it, select **View** > **Bookmark Window** from the menu bar, or use the **Ctrl**+**K**, **Ctrl**+**W** keyboard shortcut. 
   
    :::image type="content" source="media/vs-2022/view-menu-bookmarks-window.png" alt-text="Screenshot that shows the Bookmarks window option in the View menu.":::
  
  The **Bookmarks** window:

   :::image type="content" source="media/bookmarks-window.png" alt-text="Screenshot that shows the Bookmarks window and the Bookmarks toolbar.":::

  The following table includes available toolbar commands and their [keyboard shortcuts](default-keyboard-shortcuts-in-visual-studio.md), listed from left to right.

    | Icon                              | Action   | Keyboard shortcut |
    |-----------------------------------|----------|-------------------|
    | **Toggle a bookmark**             |  Create a new bookmark on the current line, or toggle between existing bookmarks line by line | **Ctrl**+**K**, **Ctrl**+**K** |
    | **New Folder**                    |  Create a new folder                       | **Ctrl**+**K**, **Ctrl**+**F** | 
    | **Previous bookmark**             |  Move the caret to the previous bookmark   | **Ctrl**+**K**, **Ctrl** **P** |
    | **Next bookmark**                 |  Move the caret to the next bookmark       | **Ctrl**+**K**, **Ctrl** **N** |
    | **Previous bookmark in a folder** |  Move the caret to the previous bookmark in the current folder | **Ctrl**+**Shift**+**K**, **Ctrl**+**Shift**+**P** | 
    | **Next bookmark in a folder**     |  Move the caret to the next bookmark in the current folder     | **Ctrl**+**Shift**+**K**, **Ctrl**+**Shift**+**N** | 
    | **Disable/Enable All Bookmarks**  |  Disable or enable all bookmarks           |  --- | 
    | **Delete**                        |  Delete (bookmark, folder)                 |  --- | 

## Add bookmarks

Here's how to add a bookmark:

1. Place the cursor on the line of code you want to bookmark. 
1. Select **Toggle a bookmark**.
1. Notice that Visual Studio adds a bookmark icon next to the line you selected, and a corresponding entry to the **Bookmarks** window. 

  ![Screenshot of the Bookmarks window in Visual Studio that has bookmarks added.](media/bookmarks-window-visual-studio.png)

If you select **Toggle a bookmark** again, the bookmark is removed.

## Rename bookmarks

Here's how to rename a bookmark:

1. If the **Bookmarks** window isn't open, select **View** > **Bookmark Window** from the menu bar. Or, enter **Ctrl**+**K**, **Ctrl**+**K**.
1. Right-click the bookmark to open the context menu, and then select **Rename**.

   :::image type="content" source="media/bookmarks-window-rename.png" alt-text="Screenshot of the Rename function in the right-click context menu in the Bookmarks window.":::

## Disable or delete bookmarks

You can delete bookmarks by selecting the **Delete** button in the bookmark window.

You can turn off bookmarks (without removing them) by selecting the **Disable All Bookmarks** button in the bookmark window. You can re-enable them by selecting the same button, which is now labeled **Enable All Bookmarks**.

## Navigate and organize bookmarks

You can navigate between bookmarks by using the **Next bookmark** and **Previous bookmark** buttons in the bookmark window.

You can organize bookmarks into virtual folders by selecting **New Folder** in the bookmark window and then dragging selected bookmarks into the new folder. And, you can rename the folders by using the right-click context menu, too.

## Related content

- Explore more [features of the code editor](../ide/writing-code-in-the-code-and-text-editor.md).
- Learn about other productivity features in the [Productivity guide for Visual Studio](productivity-features.md).
