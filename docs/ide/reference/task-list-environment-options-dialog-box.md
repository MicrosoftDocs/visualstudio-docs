---
title: Task List, Environment, Options Dialog Box
description: Learn how to use the Task List page in the Environment section to add, delete, and change the comment tokens that generate Task List reminders.
ms.date: 03/28/2019
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.Environment.Task_List
- VS.ToolsOptionsPages.Environment.TaskList
- VS.Environment.Task List
helpviewer_keywords:
- Token List
- tokens
- icons, in Task List
- Task List, customizing environment
- Options dialog box, Task List environment
- exclamation points
- comments, comment tasks in Task List
- tokens, and the Task List
- Task List, comment tasks
ms.custom: "ide-ref"
author:anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Options dialog box: Environment \> Task List

This Options page allows you to add, delete, and change the comment tokens that generate **Task List** reminders. To display these settings, select **Options** from the **Tools** menu, expand the **Environment** folder, and choose **Task List**.

## Task List Tokens

When you insert a comment into your code whose text begins with a token from the **Token list**, **Task List** displays your comment as new entry whenever the file is opened for editing. Click a **Task List** entry to jump directly to the comment line in your code. For more information, see [Using the Task List](../../ide/using-the-task-list.md).

Token List\
Displays a list of tokens, and allows you to add or remove custom tokens. Comment tokens are case sensitive in C# and C++, but not in Visual Basic.

> [!NOTE]
> If you don't type the desired token exactly as it appears in the token list, a comment task will not be displayed in **Task List**.

Priority\
Sets the priority of tasks that use the selected token (low, normal, or high). Task comments that begin with this token are automatically assigned the designated priority in **Task List**.

Name\
Enter the token string here and then click **Add** to add the string to the token list.

Add\
Enabled when you enter a new **Name**. Click to add a new token string using the values entered in the **Name** and **Priority** fields.

Delete\
Click to delete the selected token from the token list. You cannot delete the default comment token.

Change\
Click to make changes to an existing token using the values entered in the **Name** and **Priority** fields.

> [!NOTE]
> You can't rename or delete the default comment token, but you can change its priority level.

## See also

- [Use the Task List](../../ide/using-the-task-list.md)
- [Set Bookmarks in Code](../../ide/setting-bookmarks-in-code.md)
