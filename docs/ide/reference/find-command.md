---
title: Find Command
description: Learn about the Find command and how it searches files by using a subset of the options available on the Find in Files tab of the Find and Replace window.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- edit.find
helpviewer_keywords:
- Find command
- Edit.Find command
ms.custom: "ide-ref"
author:Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Find Command

Searches files using a subset of the options available on the **Find in Files** tab of the **Find and Replace** window.

## Syntax

```cmd
Edit.Find findwhat [/case] [/doc | /proc | /open | /sel]
[/markall] [/options] [/reset] [/up] [/wild | /regex] [/word]
```

## Arguments
`findwhat`
Required. The text to match.

## Switches
/case or /c\
Optional. Matches occur only if the uppercase and lowercase characters exactly match those specified in the `findwhat` argument.

/doc or /d\
Optional. Searches the current document only. Specify only one of the available search scopes, `/doc`, `/proc`, `/open`, or `/sel`.

/markall or /m\
Optional. Places a graphic on each line that contains a search match within the current document.

/open or /o\
Optional. Searches all open documents as if they were one document. Specify only one of the available search scopes, `/doc`, `/proc`, `/open`, or `/sel`.

/options or /t\
Optional. Displays a list of the current find option settings and does not perform a search.

/proc or /p\
Optional. Searches the current procedure only. Specify only one of the available search scopes, `/doc`, `/proc`, `/open`, or `/sel`.

/reset or /e\
Optional. Returns the find options to their default settings and does not perform a search.

/sel or /s\
Optional. Searches the current selection only. Specify only one of the available search scopes, `/doc`, `/proc`, `/open`, or `/sel`.

/up or /u\
Optional. Searches from the current location in the file toward the beginning of the file. By default, searches begin at the current location in the file and searches towards the end of the file.

/regex or /r\
Optional. Uses pre-defined special characters in the `findwhat` argument as notations that represent patterns of text rather than the literal characters. For a complete list of regular expression characters, see [Regular Expressions](../../ide/using-regular-expressions-in-visual-studio.md).

/wild or /l\
Optional. Uses pre-defined special characters in the `findwhat` argument as notations to represent a character or sequence of characters.

/word or /w\
Optional. Searches only for whole words.

## Example
This example performs a case-sensitive search for the word "somestring" in the currently selected section of code.

```cmd
>Edit.Find somestring /sel /case
```

## See also

- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
