---
title: Find and Replace, Environment, Options Dialog Box
description: Learn how to use the Find and Replace page in the Environment section to control message boxes and other aspects of a find and replace operation.
ms.date: 12/16/2021
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.Environment.FindReplace
- VS.ToolsOptionsPages.Environment.FindandReplace
helpviewer_keywords:
- Find and Replace, Options dialog box
- Find and Replace, customizing
ms.custom: "ide-ref"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Find and Replace, Environment, Options Dialog Box

Use this page of the **Options** dialog box to control message boxes and other aspects of a find and replace operation. You can access this dialog box from the **Tools** menu by selecting **Options**, expanding **Environment**, and then selecting **Find and Replace**.

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

**Automatically limit search to selection**

Select this option when you want to set the search scope to just code that you've selected.

If you don't want to search only the code that you've selected, clear this option.

**Use the editor background in the Find All References tool window**

Select this option when you want the **Find All References** tool window to use the same background color as the editor. This is helpful if you use the dark theme or a custom theme with a dark background color. For more information about themes, see the [Change fonts, colors, and themes in Visual Studio](../how-to-change-fonts-and-colors-in-visual-studio.md) page.

**Keep search results by default**

Select this option when you prefer to keep all your search results by default rather than selecting the **Keep Results** button after each search. For more information about this functionality, see the "Keep results" section of the [Find in Files](../find-in-files.md#keep-results) page.

## See also

- [Find and Replace text](../finding-and-replacing-text.md)
- [Find in Files](../find-in-files.md)
