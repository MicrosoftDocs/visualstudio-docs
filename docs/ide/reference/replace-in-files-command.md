---
title: Replace In Files Command
description: Learn about the Replace in Files command and how it replaces text in files by using some of the options available on the Replace in Files tab of the Find and Replace window.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- edit.replaceinfiles
helpviewer_keywords:
- Edit.ReplaceInFiles command
- Replace In Files command
- ReplaceInFiles command
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Replace In Files Command

Replaces text in files using a subset of the options available on the **Replace in Files** tab of the **Find and Replace** window.

## Syntax

```
Edit.ReplaceinFiles findwhat replacewith [/all] [/append] [/case]
[/ext:extensions] [/lookin:searchpath] [/options] [/preserveCase]
[/regex] [/reset] [/stop] [/sub] [/word]
```

## Arguments
`findwhat`

Required. The text to match.

`replacewith`

Required. The text to substitute for the matched text.

## Switches
/all or /a

Optional. Replaces all occurrences of the search text with the replacement text.

/append (new in Visual Studio 2022)

Optional. Directs the results from the current search to be appended to previous search results.

/case or /c

Optional. Matches occur only if when the uppercase and lowercase characters exactly match those specified in the `findwhat` argument.

/ext: `extensions`

Optional. Specifies the file extensions for the files to be searched.

/keep or /k  (not supported in Visual Studio 2022)

Optional. Specifies that all modified files are left open.

/lookin: `searchpath`

Optional. Directory to search. If the path contains spaces, enclose the entire path in quotation marks.

/options or /t

Optional. Displays a list of the current find option settings and does not perform a search.

/preserveCase (new in Visual Studio 2022)

Optional. Preserves the original casing of each match in your code.

/regex or /r

Optional. Uses pre-defined special characters in the `findwhat` argument as notations that represent patterns of text rather than the literal characters. For a complete list of regular expression characters, see [Regular Expressions](../../ide/using-regular-expressions-in-visual-studio.md).

/reset or /e

Optional. Returns the find options to their default settings and does not perform a search.

/stop

Optional. Halts the current search operation if one is in progress. Replace ignores all other arguments when `/stop` has been specified. For example, to stop the current replacement you would enter the following:

```
>Edit.ReplaceinFiles /stop
```

/sub or /s

Optional. Searches the subfolders within the directory specified in the /lookin:`searchpath` argument.

/text2 or /2  (not supported in Visual Studio 2022)

Optional. Displays the results of the replacement in the **Find Results 2** window.

/wild or /l  (not supported in Visual Studio 2022)

Optional. Uses pre-defined special characters in the `findwhat` argument as notations to represent a character or sequence of characters.

/word or /w

Optional. Searches for only whole words.

## Example
This example searches for `btnCancel` and replaces it with `btnReset` in all .cls files located in the folder "my visual studio projects" and displays the replacement information in the **Find Results 2** window.

```
>Edit.ReplaceinFiles btnCancel btnReset /lookin:"c:/my visual studio projects" /ext:.cls /text2
```

## See also

- [Finding and Replacing Text](../../ide/finding-and-replacing-text.md)
- [Replace in Files](../../ide/replace-in-files.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
