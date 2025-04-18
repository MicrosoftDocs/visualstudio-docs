---
title: Replace Command
description: Learn about the Replace command and how it replaces text in files by using a subset of the options available on the Replace in Files tab of the Find and Replace window.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- edit.replace
helpviewer_keywords:
- Edit.Replace command
- Replace command
author:Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Replace Command

Replaces text in files using a subset of the options available on the **Replace in Files** tab of the **Find and Replace** window.

## Syntax

```
Edit.Replace findwhat replacewith [/all] [/case]
[/doc|/proc|/open|/sel] [/hidden] [/options] [/reset] [/up]
[/wild|/regex] [/word]
```

## Arguments
`findwhat`

Required. The text to match.

`replacewith`

Required. The text to substitute for the matched text.

## Switches
/all or /a

Optional. Replaces all occurrences of the search text with the replacement text.

/case or /c

Optional. Matches occur only if when the uppercase and lowercase characters exactly match those specified in the `findwhat` argument.

/doc or /d

Optional. Searches the current document only. Specify only one of the available search scopes, `/doc`, `/proc`, `/open`, or `/sel`.

/hidden or /h

Optional. Searches concealed and collapsed text, such as the metadata of a design-time control, a hidden region of an outlined document, or a collapsed class or method.

/open or /o

Optional. Searches all open documents as if they were one document. Specify only one of the available search scopes, `/doc`, `/proc`, `/open`, or `/sel`.

/options or /t

Optional. Displays a list of the current find option settings and does not perform a search.

/proc or /p

Optional. Searches the current procedure only. Specify only one of the available search scopes, `/doc`, `/proc`, `/open`, or `/sel`.

/regex or /r

Optional. Uses pre-defined special characters in the `findwhat` argument as notations that represent patterns of text rather than the literal characters. For a complete list of regular expression characters, see [Regular Expressions](../../ide/using-regular-expressions-in-visual-studio.md).

/reset or /e

Optional. Returns the find options to their default settings and does not perform a search.

/sel or /s

Optional. Searches the current selection only. Specify only one of the available search scopes, `/doc`, `/proc`, `/open`, or `/sel`.

/up or /u

Optional. Searches from the current location in the file toward the top of the file. By default, searches begin at the current location in the file and advance toward the bottom of the file.

/wild or /l

Optional. Uses pre-defined special characters in the `findwhat` argument as notations to represent a character or sequence of characters.

/word or /w

Optional. Searches only for whole words.

## Example
This example replaces `btnSend` with `btnSubmit` in all open documents.

```
>Edit.Replace btnSend btnSubmit /open
```

## See also

- [Finding and Replacing Text](../../ide/finding-and-replacing-text.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
