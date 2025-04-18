---
title: Options, Text Editor, C#, IntelliSense
description: Learn how to use the IntelliSense page in the C# section to modify settings that affect the behavior of IntelliSense for C#.
ms.date: 09/26/2024
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.CSharp.Intellisense
helpviewer_keywords:
- underlines, wavy
- IntelliSense [C#], options
- IntelliSense [C#], wavy underlines
- wavy underlines
- Text Editor Options dialog box, IntelliSense
ms.custom: "ide-ref"
author:anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Options, Text Editor, C#, IntelliSense

Use the **IntelliSense** options page to modify settings that affect the behavior of IntelliSense for C#. 

To access this options page, choose **Tools** > **Options** > **Text Editor** > **C#** > **IntelliSense**.

The **IntelliSense** options page contains the following options:

## Completion Lists

- Show completion list after a character is typed*

   When this option is selected, IntelliSense automatically displays the completion list when you begin typing. When this option is not selected, IntelliSense completion is still available from the **IntelliSense** menu or by pressing **Ctrl**+**Space**.

- Show completion list after a character is deleted

- Automatically show completion list in argument lists

- Highlight matching portions of completion list items

- Show completion item filters

- Automatically complete statement on semicolon

## Snippets behavior

- Never include snippets

   When this option is selected, IntelliSense never adds aliases for C# code snippets to the completion list.

- Always include snippets

   When this option is selected, IntelliSense adds aliases for C# code snippets to the completion list. In the case where the code snippet alias is the same as a keyword, for example, [class](/dotnet/csharp/language-reference/keywords/class), the keyword is replaced by the shortcut. For more information, see [C# Code Snippets](../../ide/visual-csharp-code-snippets.md).

- Include snippets when ?-Tab is typed after an identifier

   When this option is selected, IntelliSense adds aliases for C# code snippets to the completion list when **?**+**Tab** is pressed after an identifier

## Enter key behavior

- Never add new line on enter

   Specifies that a new line is never added automatically after selecting an item in the completion list and pressing **Enter**.

- Only add new line on enter after end of fully typed word

   Specifies that if you type all the characters for an entry in the completion list and then press **Enter**, a new line is added automatically and the cursor moves to the new line.

   For example, if you type `else` and then press **Enter**, the following appears in the editor:

   `else`

   `|` (cursor location)

   However, if you type only `el` and then press **Enter**, the following appears in the editor:

   `else|` (cursor location)

- Always add new line on enter

   Specifies that if you type *any* of the characters for an entry in the completion list and then press **Enter**, a new line is added automatically and the cursor moves to the new line.

## Show name suggestions

Performs automatic object name completion for the members that you have recently selected.

## Show items from unimported namespaces

Performs completion for types and extension methods that you haven't imported yet with a `using` directive.

## Tab twice to insert arguments

Automatically inserts arguments when writing a method call. To use this feature, start writing a method call and press tab twice.

## See also

- [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)
- [Using IntelliSense](../../ide/using-intellisense.md)
