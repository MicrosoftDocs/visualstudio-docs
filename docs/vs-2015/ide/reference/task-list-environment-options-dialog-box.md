---
title: "Task List, Environment, Options Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Environment.Task_List"
  - "VS.ToolsOptionsPag.Environment.Task_List"
  - "VS.ToolsOptionsPages.Environment.TaskList"
  - "VS.Environment.Task List"
helpviewer_keywords:
  - "Token List"
  - "tokens"
  - "icons, in Task List"
  - "Task List, customizing environment"
  - "Options dialog box, Task List environment"
  - "exclamation points"
  - "comments, comment tasks in Task List"
  - "tokens, and the Task List"
  - "Task List, comment tasks"
ms.assetid: 88327e04-fa3e-48db-995b-ad89e0dc4ed2
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: jillfra
---
# Task List, Environment, Options Dialog Box
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

This Options page allows you to add, delete, and change the comment tokens that generate **Task List** reminders. To display these settings, select **Options** from the **Tools** menu, expand the **Environment** folder, and choose **Task List**.

## Task List options
 Confirm deletion of tasks
 When selected, a message box is displayed whenever a User Task is deleted from the **Task List**, allowing you to confirm the deletion. This option is selected by default.

> [!NOTE]
> To delete a Task Comment, use the link to find the comment, and then remove it from your code.

 Show file names only
 When selected, the **File** column of the **Task List** displays only the names of files to be edited, not their full paths.

## Tokens
 When you insert a comment into your code whose text begins with a token from the **Token List**, the **Task List** displays your comment as new entry whenever the file is opened for editing. You can click this **Task List** entry to jump directly to the comment line in your code. For more information, see [Using the Task List](../../ide/using-the-task-list.md).

 Token List
 Displays a list of tokens, and allows you to add or remove custom tokens. Comment tokens are case sensitive in Visual C# and Visual C++, but not in Visual Basic.

> [!NOTE]
> If you do not type the desired token exactly as it appears in the **Token List**, a comment task will not be displayed in the **Task List**.

 Priority
 Sets the priority of tasks that use the selected token. Task comments that begin with this token are automatically assigned the designated priority in the **Task List**.

 Name
 Enter the token string. This enables the **Add** button. On **Add**, this string is included in the **Token List**, and comments that begin with this name will be displayed in the **Task List**.

 Add
 Enabled when you enter a new **Name**. Click to add a new token string using the values entered in the **Name** and **Priority** fields.

 Delete
 Click to delete the selected token from the **Token List**. You cannot delete the default comment token.

 Change
 Click to make changes to an existing token using the values entered in the **Name** and **Priority** fields.

> [!NOTE]
> You cannot rename or delete the default comment token, but you can change its priority level.

## See Also
 [Using the Task List](../../ide/using-the-task-list.md)
 [Setting Bookmarks in Code](../../ide/setting-bookmarks-in-code.md)
 [Environment Options Dialog Box](../../ide/reference/environment-options-dialog-box.md)
