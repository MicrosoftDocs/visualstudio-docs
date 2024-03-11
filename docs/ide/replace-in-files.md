---
title: Use Replace in Files to search code & make changes
description: Explore the Replace in Files feature to search the code of a specified set of files for a string or expression and change some or all of the matches found.
ms.date: 02/07/2023
ms.topic: conceptual
f1_keywords:
- vs.findreplace.replaceinfiles
- vs.replaceinfiles
helpviewer_keywords:
- text searches, replacing text
- find and replace
- replace in files
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Replace in Files

**Replace in Files** allows you to search the code of a specified set of files for a string or expression, and change some or all of the matches found. The matches found and actions taken are listed in the **Find Results** window selected in **Result options**.

::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/find-replace-files.png" alt-text="Screenshot of the Find and Replace dialog box in Visual Studio 2022, with the Replace in Files tab open.":::

::: moniker-end

::: moniker range="vs-2019"

:::image type="content" source="media/vs-2019/find-replace-files.png" alt-text="Screenshot of the Find and Replace dialog box in Visual Studio 2019, with the Replace in Files tab open.":::

> [!IMPORTANT]
> If you are using **Visual Studio 2019** [**version 16.6**](/visualstudio/releases/2019/release-notes-v16.6/) or earlier, the **Find and Replace** dialog box might not look like it appears here. Switch to the [Visual Studio 2017](find-in-files.md?view=vs-2017&preserve-view=true) version of this page for descriptions that'll match what you see on your screen.

::: moniker-end

You can use any of the following methods to display **Replace in Files** in the **Find and Replace** window, or use **Ctrl**+**Shift**+**H**.

## To display Replace in Files

1. Press **Ctrl**+**Q** and enter "replace" in the search box at the top of the screen.

1. Choose **Replace in files** from the list of results.

   — or —

1. On the **Edit** menu, expand **Find and Replace**.

1. Choose **Replace in Files**.

   — or —

   If the **Find and Replace** window is already open, on the toolbar, choose **Replace in Files**.

> [!NOTE]
> The **Find and Replace** tool does not search directories with the `Hidden` or `System` attribute.

The **Replace in Files** options are almost identical to the options in the **[Find in Files](find-in-files.md)** dialog. There are, however, extra replace action buttons at the bottom of the dialog. And, depending on the version of Visual Studio you're using, there are more replace options available in the dialog, as follows.

## Replace textbox

To replace instances of the string in the **Find** textbox with another string, enter the replacement string in the **Replace** textbox. To delete instances of the string in the **Find** textbox, leave this field blank. Open the list to display the strings you most recently searched for. Choose the adjacent **Expression Builder** button if you want to use one or more regular expressions in your replacement string. For more information, see [Use regular expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md).

## Preserve case

When you do a Replace, you can preserve the original casing of each match in your code. Toggle case preservation with the Preserve case option (**Alt**+**V**). This option is available in Visual Studio 2022 version 17.8 or later.

To get Pascal case and Camel case, your Replace string must also be in Pascal case or Camel case. Case is also preserved in text that contains hyphens or underscores.

Examples:

– Replacing "begin" with "end" will turn "Begin" into "End" and "BEGIN" into "END".

– Replacing "onetwothree" with "fourFiveSix" will turn "onetwothree" into "fourfivesix", "oneTwoThree" into "fourFiveSix", and "OneTwoThree" into "FourFiveSix".

::: moniker range="vs-2019"

## Keep modified files open after Replace All

When selected, this option leaves open all files in which replacements have been made, so you can undo or save the changes. Memory constraints might limit the number of files that can remain open after a replace operation.

> [!CAUTION]
> You can use **Undo** only on files that remain open for editing. If this option is not selected, files that were not already open for editing will remain closed, and no **Undo** option will be available in those files.

::: moniker-end

::: moniker range="vs-2022"

> [!NOTE]
> Starting with Visual Studio 2022, search performance is optimized by showing partial results, such as from pre-indexed files, before final results are available. However, when you perform replace operations, this performance benefit doesn't apply, since replace operations are only started after full search results are returned.

::: moniker-end

## Related content

- [Find and replace text](../ide/finding-and-replacing-text.md)
- [Find in files](../ide/find-in-files.md)
- [Visual Studio commands](../ide/reference/visual-studio-commands.md)
