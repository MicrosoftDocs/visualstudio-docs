---
title: Use Replace in Files to Search Code and Make Changes
description: Use the Replace in Files feature to search the code of a specified set of files for a string or expression and change some or all of the matches found.
ms.date: 04/07/2025
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

# customer intent: As a developer, I want to learn about the Replace in Files feature so that I can search code and make changes. 
---

# Replace in Files

**Replace in Files** enables you to search the code of a specified set of files for a string or expression, and change some or all of the matches found.

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/find-replace-files.png" alt-text="Screenshot of the Find and Replace dialog in Visual Studio. The Replace in Files tab is open.":::

::: moniker-end

::: moniker range="vs-2019"

:::image type="content" source="media/vs-2019/find-replace-files.png" alt-text="Screenshot of the Find and Replace dialog box in Visual Studio 2019. The Replace in Files tab is open.":::

> [!IMPORTANT]
> If you use Visual Studio 2019 [version 16.6](/visualstudio/releases/2019/release-notes-v16.6/) or earlier, the **Find and Replace** dialog box might not look as it appears here. Switch to the [Visual Studio 2017](find-in-files.md?view=vs-2017&preserve-view=true) version of this page to get descriptions that match what you see on your screen.

::: moniker-end

You can use any of the following methods to display **Replace in Files** in the **Find and Replace** window. You can also use **Ctrl**+**Shift**+**H**.

## To display Replace in Files

- Press **Ctrl**+**Q** and enter **replace** in the search box at the top of the screen. Double-click **Replace in files** in the list of results.

   — or —

- On the **Edit** menu, select **Find and Replace** and then select **Replace in Files**.

   — or —

-  If the **Find and Replace** window is already open, select the **Replace in Files** tab.

> [!NOTE]
> The **Find and Replace** tool doesn't search folders that have the `Hidden` or `System` attribute.

The **Replace in Files** options are almost identical to the options in the **[Find in Files](find-in-files.md)** dialog. Depending on the version of Visual Studio that you use, there might be more replace options available in the dialog, as described in the following sections.

## Replace box

To replace instances of the string in the **Find** box with another string, enter the replacement string in the **Replace** box. To delete instances of the string in the **Find** box, leave the **Replace** box blank. Select the dropdown arrow in the **Find** box to display the strings that you most recently searched for. Select the **User regular expressions** checkbox and then select the adjacent **Replace Expression Builder** button if you want to use one or more regular expressions in your replacement string. For more information, see [Use regular expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md).

## Preserve case

When you perform a replace operation, you can preserve the original casing of each match in your code. You can turn case preservation on and off by using the **Preserve case** option (**Alt**+**V**). This option is available in Visual Studio 2022 version 17.8 or later.

To preserve Pascal case or camel case, your replace string must also be in Pascal case or camel case. Case is also preserved in text that contains hyphens or underscores.

Here are some examples:

- Replacing "begin" with "end" will turn "Begin" into "End" and "BEGIN" into "END".

- Replacing "onetwothree" with "fourFiveSix" will turn "onetwothree" into "fourfivesix", "oneTwoThree" into "fourFiveSix", and "OneTwoThree" into "FourFiveSix".

::: moniker range="vs-2019"

## Keep modified files open after Replace All

When you select **Keep modified files open after Replace All**, all files in which replacements have been made are left open, so you can undo or save the changes. Memory constraints might limit the number of files that can remain open after a replace operation.

> [!CAUTION]
> You can use **Undo** only on files that remain open for editing. If **Keep modified files open after Replace All** isn't selected, files that weren't already open for editing will remain closed, and no **Undo** option will be available in those files.

::: moniker-end

::: moniker range=">=vs-2022"

> [!NOTE]
> Starting with Visual Studio 2022, to optimize search performance, partial results, such as results from pre-indexed files, are shown before final results are available. However, when you perform replace operations, this performance benefit doesn't apply because replace operations are started only after full search results are returned.

::: moniker-end

## Related content

- [Find and replace text](../ide/finding-and-replacing-text.md)
- [Find in files](../ide/find-in-files.md)
- [Visual Studio commands](../ide/reference/visual-studio-commands.md)
