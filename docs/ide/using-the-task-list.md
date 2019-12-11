---
title: Use the Task List
ms.date: 11/04/2016
ms.topic: conceptual
f1_keywords:
  - "TaskListWindow"
  - "VS.TaskList"
  - "tasklist"
helpviewer_keywords:
  - "task list"
  - "Visual Studio, task list"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Use the Task List

Use **Task List** to track code comments that use tokens such as `TODO` and `HACK`, or custom tokens, and to manage shortcuts that take you directly to a predefined location in code. Click on the item in the list to go to its location in the source code.

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Task comments (Visual Studio for Mac)](/visualstudio/mac/task-comments).

## The Task List window

When **Task List** is open, it appears at the bottom of the application window.

To open **Task List**, select **View** > **Task List**, or from the keyboard press **Ctrl**+**\\**,**T**.

![Task List window](../ide/media/vs2015_task_list.png)

To change the sort order of the list, select the header of any column. To further refine your search results, press **Shift** and click a second column header. Alternatively, on the shortcut menu, choose **Sort by**, and then choose a header. To further refine your search results, press **Shift** and choose a second header.

To show or hide columns, on the shortcut menu, choose **Show Columns**. Select the columns that you want to show or hide.

To change the order of the columns, drag any column header to the location that you want.

## User tasks

The user task feature was removed in Visual Studio 2015. When you open a solution that has user task data from Visual Studio 2013 and earlier, the user task data in your *.suo* file is not affected, but the user tasks are not displayed in the task list.

If you wish to continue to access and update your user task data, open the project in Visual Studio 2013 and copy the content of any user tasks into your preferred project management tool (such as Team Foundation Server).

## Tokens and comments

A comment in your code preceded by a comment marker and a predefined token also appears in **Task List**. For example, the following C# comment has three distinct parts:

- The comment marker (`//`)

- The token, for example (`TODO`)

- The comment (the rest of the text)

```csharp
// TODO: Load state from previously suspended application
```

Because `TODO` is a predefined token, this comment appears as a `TODO` task in the list.

> [!NOTE]
> Default tokens are only available for the C/C++, C#, and VB languages. For other languages, see the **Custom tokens** section.

### Custom tokens

By default, Visual Studio includes the following tokens: `HACK`, `TODO`, `UNDONE`, and `UnresolvedMergeConflict`. They are not case-sensitive. You can also create your own custom tokens.

To create a custom token:

1. On the **Tools** menu, choose **Options**.

2. Open the **Environment** folder and then choose **Task List**.

   The [Task List options page](../ide/reference/task-list-environment-options-dialog-box.md) is displayed.

   ![Visual Studio Task List](../ide/media/vs2015_task_list_options.png)

3. In the **Name** text box, enter your token name, for example **BUG**.

4. In the **Priority** drop-down list, choose a default priority for the new token.

5. Choose **Add**.

> [!TIP]
> The **Add** button becomes enabled after you enter a name. You must enter a name before clicking **Add**.

### C++ TODO comments

By default, C++ TODO comments are displayed in **Task List**.

To turn off C++ TODO comments, on the **Tools** menu, choose **Options** > **Text Editor** > **C/C++** > **View** > **Enumerate Comment Tasks**, and set the value to **false**.

## Shortcuts

A *shortcut* is a bookmark in the code that is tracked in **Task List**. It has a different icon than a regular bookmark. Double-click the shortcut in **Task List** to go to the corresponding location in the code.

![Visual Studio Task List Shortcut Icon](../ide/media/vs2015_task_list_bookmark.png)

### Create a shortcut

To create a shortcut, insert the pointer into the code where you want to place a shortcut. Choose **Edit** > **Bookmarks** > **Add Task List Shortcut** or press **Ctrl**+**K**, **Ctrl**+**H**.

To navigate through the shortcuts in the code, choose a shortcut in the list, and then choose **Next Task** or **Previous Task** from the shortcut menu.

## See also

- [Task List, Environment, Options dialog box](../ide/reference/task-list-environment-options-dialog-box.md)
- [Task comments (Visual Studio for Mac)](/visualstudio/mac/task-comments)
