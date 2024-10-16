---
title: Use Task List to track and use code comments
description: Explore the Task List tool in Visual Studio and discover how to efficiently use code comments, including tracking code tokens and managing code shortcuts.
ms.date: 08/19/2024
ms.topic: how-to
f1_keywords:
- TaskListWindow
- VS.TaskList
- tasklist
helpviewer_keywords:
- task list
- Visual Studio, task list
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide

#customer intent: As a developer, I want to use the Task List tool in Visual Studio, so I can track tokens in code comments and set up code shortcuts.
---

# Use Task List with code comments and shortcuts

The **Task List** tool in Visual Studio lets you track code comments that use tokens like `TODO` and `HACK` or custom tokens. You can also use this feature to manage task shortcuts that take you directly to a predefined location in code. By default, **Task List** opens at the bottom of the application window in the Visual Studio Interactive Development Environment (IDE):

:::image type="content" source="media/task-list-window.png" border="false" alt-text="Screenshot of the Task List window at the bottom of the application window in Visual Studio." lightbox="media/task-list-window.png":::

If you don't see the **Task List** window, select **View** > **Task List**, or use the keyboard shortcut **Ctrl**+**\\**,**T**. Like other feature windows in the Visual Studio IDE, you can move the **Task List** window to any location on the IDE surface.

## Use predefined tokens

Visual Studio prepares **Task List** content by scanning your code for comment markers and tokens. Several predefined tokens are available for C/C++, C#, and Visual Basic programs: `HACK`, `TODO`, `UNDONE`, and `UnresolvedMergeConflict`. These token labels are case insensitive.

Visual Studio recognizes a comment when it consists of three components:

- The comment marker, such as `//`, `#`, `<!--`

- The comment token prefix, such as `TODO`, `hack`, `MoveToHeader`

- The comment text that follows the token

Here's an example of a code comment in C#:

```csharp
// TODO: Load state from previously suspended application
```

When Visual Studio recognizes a predefined token, it displays the comment text as a task in **Task List**.

## Create custom tokens

You can create custom tokens for any programming language by following these steps:

1. On the Visual Studio **Tools** menu, select **Options**.

1. Expand the **Environment** section, and select the **Task List** tab. The [Task List options page](reference/task-list-environment-options-dialog-box.md) opens:

   :::image type="content" source="media/tools-options-environment-task-list.png" border="false" alt-text="Screenshot that shows how to add tokens for the Task List in Visual Studio, including predefined and custom tokens.":::

1. In the **Name** text box, enter the name for the custom token, such as **Optimize**.

1. Expand the **Priority** dropdown list and select a default priority for the custom token.

1. To add the custom token to the list of tokens, select **Add**.

1. To apply your changes, select **OK**.

When Visual Studio recognizes a custom token, it displays the comment text as a task in **Task List**.

## Add code task shortcuts

A code task *shortcut* is a bookmark you add in your code that Visual Studio tracks in **Task List**. This type of shortcut has a different icon than a regular bookmark.

1. To create a code task shortcut, insert the pointer into the code where you want to place a shortcut.

1. Select **Edit** > **Bookmarks** > **Add Task List Shortcut**, or use the keyboard shortcut **Ctrl**+**K**, **Ctrl**+**H**.

   :::image type="content" source="media/task-list-bookmark-shortcut.png" border="false" alt-text="Screenshot that shows how to add a bookmark to create a code task shortcut in Task List." lightbox="media/task-list-bookmark-shortcut.png":::

## Use tasks and shortcuts to access code

After Visual Studio updates **Task List** with your code comment token instances and code task shortcuts, you can use these items to quickly go to the linked locations in your code:

1. To go to the location in your code for any task, double-click the task item in **Task List**.

1. To jump to the code location for the previous or next task in the list, right-click the current task in the list, and select **Next Task** or **Previous Task**. These actions are also available on the Visual Studio **View** menu.

## Sort list items

You can change the sort order for the list items:

1. To change the primary sort order for the list, select a column header. Visual Studio sorts the list contents according to the items in the selected column.

1. To apply a secondary sort order, select **Shift** and a different column header. Visual Studio sorts the list contents by the first selected column followed by the second selected column.

You can continue this approach and apply more refined sorting by selecting **Shift** and another column header.

## Show, hide, and order columns

You can also work with specific columns in the list:

1. To show a column, right-click anywhere on the list and select **Show Columns**. On the flyout menu, select the columns to show. The following columns are available: **Priority**, **Description**, **Project**, **Project Rank**, **Path**, **File**, **Line**, and **Column**.

   - On the flyout menu, Visual Studio displays a checkmark next to a visible column.

   - To hide a column, unselect the column name on the flyout menu. Visual Studio removes the checkmark.

1. To change the order of the columns in the list, drag the column headers into the desired position.

> [!TIP]
> The **Project Rank** column represents project dependencies. Projects with a rank of 1 don't depend on any other projects. Projects with a rank of 2 depend on one or more projects with a rank of 1, and so on. For more information, see [Standard Table Column Definitions: Project Rank field](/dotnet/api/microsoft.visualstudio.shell.tablecontrol.standardtablecolumndefinitions.projectrank).

## Related content

- Review the reference for the [Task List, Environment, and Options dialog](../ide/reference/task-list-environment-options-dialog-box.md)
