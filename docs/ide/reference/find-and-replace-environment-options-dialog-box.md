---
title: Find and Replace, Environment, Options Dialog Box
description: Learn how to use the Find and Replace page in the Environment section to control message boxes and other aspects of a find and replace operation.
ms.date: 12/11/2025
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

:::moniker range="visualstudio"

Use this section of the **Options** pane to control message boxes and other aspects of a find and replace operation. You can access these options by selecting **Tools** > **Options**, expanding the **All Settings** > **Environment** > **Search** section, and selecting the appropriate subsection.

## Find and Replace options

The **Find and Replace** section provides the following options, including controlling the visibility of informational messages.

**Display No Results Found message**

Select this option to display an informational message when the search returns no matching results for Find and Replace. If you don't want to see this informational message, clear this option.

**Display No More Results message**

Select this option to display an informational message when you reach the end of the search results in the Find and Replace list. If you don't want to see this informational message, clear this option.

**Display message when all occurrences replaced**

Select this option to display an informational message after Find and Replace replaces all occurrences. If you don't want to see this informational message, clear this option.

**Automatically populate Find What with text from the editor**

Select this option to paste the text on either side of the current editor's insertion point into the **Find what** field when you select any view of the **Find and Replace** window from the **Edit** menu. Clear this option to use the last search pattern from the previous search as the **Find what** string.

## Quick Find options

The **Find and Replace** > **Quick Find** section provides the following option.

**Automatically limit search to selection**

Select this option when you want to set the search scope for Find and Replace to only the highlighted code. If you don't want to limit the search scope to only the highlighted code, clear this option.

## Find in Files options

The **Find and Replace** > **Find in Files** section provides the following options.

**Display malformed regular expression warning message**

Select this option to display a cautionary message when Find and Replace encounters a malformed regular expression. If you don't want to see this cautionary message for Find and Replace, clear this option.

**Keep search results by default**

Select this option when you prefer to keep all your search results by default rather than selecting **Keep Results** after each search. For more information about this functionality, see the "Keep results" section of the [Find in Files](../find-in-files.md#keep-results) page.

## Find All References options

The **Search** > **Find All References** section provides the following option for Find and Replace.

**Use editor background in the Find All References tool window**

Select this option when you want the **Find All References** tool window to use the same background color as the editor. This method is helpful if you use the dark theme or a custom theme with a dark background color. For more information about themes, see the [Change fonts, colors, and themes in Visual Studio](../how-to-change-fonts-and-colors-in-visual-studio.md) page.

:::moniker-end
:::moniker range="<=vs-2022"

Use this page of the **Options** dialog box to control message boxes and other aspects of a find and replace operation. You can access these options by selecting **Tools** > **Options** and expanding the **Environment** > **Find and Replace** section.

## Find and Replace options

The **Find and Replace** section provides the following options.

**Display informational messages**

Select this option to display all Find and Replace informational messages that have the **Always show this message** option. For example, if you chose not to display the message "Find reached the starting point of the search.", selecting this option causes this informational message to appear again when you use Find and Replace.

If you don't want to see any informational messages for Find and Replace, clear this option.

When the **Always show this message** option is cleared on some (not all) **Find and Replace** informational messages, the **Display informational messages** check box appears filled but not selected. To restore all optional **Find and Replace** messages, clear this option and then select it again.

> [!NOTE]
> This option doesn't affect any **Find and Replace** informational messages that don't display the **Always show this message** option.

**Display warning messages**

Select this option to display all cautionary Find and Replace messages that have the **Always show this message** option. For example, if you chose not to display the **Replace All** warning message that appears when you attempt to make replacements in files not currently opened for editing, selecting this option causes this warning message to appear again when you attempt to Replace All.

If you don't want to see any cautionary messages for Find and Replace, clear this option.

When the **Always show this message** option is cleared on some (not all) **Find and Replace** warning messages, the **Display warning messages** check box appears filled but not selected. To restore all optional **Find and Replace** messages, clear this option and then select it again.

> [!NOTE]
> This option doesn't affect any **Find and Replace** warning messages that don't display the **Always show this message** option.

**Automatically populate Find What with text from the editor**

Select this option to paste the text on either side of the current editor's insertion point into the **Find what** field when you select any view of the **Find and Replace** window from the **Edit** menu. Clear this option to use the last search pattern from the previous search as the **Find what** string.

**Automatically limit search to selection**

Select this option when you want to set the search scope to only the highlighted code.

If you don't want to limit the search to only the highlighted code, clear this option.

**Use the editor background in the Find All References tool window**

Select this option when you want the **Find All References** tool window to use the same background color as the editor. This method is helpful if you use the dark theme or a custom theme with a dark background color. For more information about themes, see the [Change fonts, colors, and themes in Visual Studio](../how-to-change-fonts-and-colors-in-visual-studio.md) page.

**Keep search results by default**

Select this option when you prefer to keep all your search results by default rather than selecting the **Keep Results** button after each search. For more information about this functionality, see the "Keep results" section of the [Find in Files](../find-in-files.md#keep-results) page.

:::moniker-end

## Related content

- [Find and Replace text](../finding-and-replacing-text.md)
- [Find in Files](../find-in-files.md)
