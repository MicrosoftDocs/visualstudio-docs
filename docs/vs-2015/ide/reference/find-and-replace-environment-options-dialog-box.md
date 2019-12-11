---
title: "Find and Replace, Environment, Options Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Environment.FindReplace"
  - "VS.ToolsOptionsPages.Environment.FindandReplace"
helpviewer_keywords:
  - "Find and Replace, Options dialog box"
  - "Find and Replace, customizing"
ms.assetid: f804d6d5-6309-46e4-8294-b83e880b5ec9
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: jillfra
---
# Find and Replace, Environment, Options Dialog Box
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Use this page of the **Options** dialog box to control message boxes and other aspects of a find and replace operation. You can access this dialog box from the **Tools** menu by clicking **Options**, expanding **Environment**, and then clicking **Find and Replace**. If this page does not appear in the list, select **Show all setting** in the **Options** dialog box.

> [!NOTE]
> The options available in dialog boxes, and the names and locations of menu commands you see, might differ from what is described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).

## UIElement List
 **Display informational messages**
 Select this option to display all Find and Replace informational messages that have the **Always show this message** option. For example, if you chose not to display the message "Find reached the starting point of the search.", selecting this option would cause this informational message to appear again when you use Find and Replace.

 If you do not want to see any informational messages for Find and Replace, clear this option.

 When you have cleared the **Always show this message** option on some, but not all, **Find and Replace** informational messages, the **Display informational messages** check box appears to be filled but not selected. To restore all optional **Find and Replace** messages, clear this option and then select it again.

> [!NOTE]
> This option does not affect any **Find and Replace** informational messages that do not display the **Always show this message** option.

 **Display warning messages**
 Select this option to display all cautionary Find and Replace messages that have the **Always show this message** option. For example, if you chose not to display the **Replace All** warning message that appears when you attempt to make replacements in files not currently opened for editing, selecting this option would cause this warning message to appear again when you attempt to Replace All.

 If you do not want to see any cautionary messages for Find and Replace, clear this option.

 When you have cleared the **Always show this message** option on some, but not all, **Find and Replace** warning messages, the **Display warning messages** check box appears to be filled but not selected. To restore all optional **Find and Replace** messages, clear this option and then select it again.

> [!NOTE]
> This option does not affect any **Find and Replace** warning messages that do not display the **Always show this message** option.

 **Automatically populate Find What with text from the editor**
 Select this option to paste the text on either side of the current editor's insertion point into the **Find what** field when you select any view of the **Find and Replace** window from the **Edit** menu. Clear this option to use the last search pattern from the previous search as the **Find what** string.

## See Also
 [Finding and Replacing Text](../../ide/finding-and-replacing-text.md)
