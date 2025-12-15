---
title: Configure IntelliSense options for C#
description: Learn how to configure the IntelliSense page in the C# section to customize completion lists, snippets behavior, and Enter key behavior for C#.
ms.date: 12/01/2025
ms.topic: how-to
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.CSharp.Intellisense
helpviewer_keywords:
- underlines, wavy
- IntelliSense [C#], options
- IntelliSense [C#], wavy underlines
- wavy underlines
- Text Editor Options dialog box, IntelliSense
ms.custom: "ide-ref"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide

#customer intent: As a C# developer, I want to configure IntelliSense options so that I can customize code completion behavior to match my coding preferences.
---
# Configure IntelliSense options for C#

This article shows you how to configure IntelliSense settings for C# to customize completion lists, snippets behavior, and Enter key behavior. These settings help you control how IntelliSense suggests and completes code as you type.

## Access the IntelliSense options page

To configure IntelliSense options for C#:

1. In Visual Studio, select **Tools** > **Options**.
1. Expand **Text Editor**.
1. Expand **C#**.
1. Select **IntelliSense**.

## Configure completion lists

Use these options to control when and how IntelliSense displays completion lists.

### Show completion list after a character is typed

When this option is selected, IntelliSense automatically displays the completion list when you begin typing. When this option is not selected, IntelliSense completion is still available from the **IntelliSense** menu or by pressing **Ctrl**+**Space**.

### Show completion list after a character is deleted

When selected, displays the completion list after you delete a character while typing.

### Automatically show completion list in argument lists

When selected, automatically displays the completion list when you type in method argument lists.

### Highlight matching portions of completion list items

When selected, highlights the parts of completion list items that match what you've typed.

### Show completion item filters

When selected, displays filter buttons at the top of the completion list to help you narrow down suggestions by type (such as methods, properties, or classes).

### Automatically complete statement on semicolon

When selected, automatically completes the current statement when you type a semicolon.

## Configure snippets behavior

Use these options to control how IntelliSense handles code snippets in completion lists.

### Never include snippets

When this option is selected, IntelliSense never adds aliases for C# code snippets to the completion list.

### Always include snippets

When this option is selected, IntelliSense adds aliases for C# code snippets to the completion list. In the case where the code snippet alias is the same as a keyword, for example, [class](/dotnet/csharp/language-reference/keywords/class), the keyword is replaced by the shortcut. For more information, see [C# Code Snippets](visual-csharp-code-snippets.md).

### Include snippets when ?-Tab is typed after an identifier

When this option is selected, IntelliSense adds aliases for C# code snippets to the completion list when **?**+**Tab** is pressed after an identifier.

## Configure Enter key behavior

Use these options to control what happens when you press Enter after selecting a completion list item.

### Never add new line on enter

Specifies that a new line is never added automatically after selecting an item in the completion list and pressing **Enter**.

### Only add new line on enter after end of fully typed word

Specifies that if you type all the characters for an entry in the completion list and then press **Enter**, a new line is added automatically and the cursor moves to the new line.

For example, if you type `else` and then press **Enter**, the following appears in the editor:

`else`

`|` (cursor location)

However, if you type only `el` and then press **Enter**, the following appears in the editor:

`else|` (cursor location)

### Always add new line on enter

Specifies that if you type *any* of the characters for an entry in the completion list and then press **Enter**, a new line is added automatically and the cursor moves to the new line.

## Configure additional IntelliSense options

Use these options to enable advanced IntelliSense features.

### Show name suggestions

Performs automatic object name completion for the members that you have recently selected.

### Show items from unimported namespaces

Performs completion for types and extension methods that you haven't imported yet with a `using` directive.

### Tab twice to insert arguments

Automatically inserts arguments when writing a method call. To use this feature, start writing a method call and press **Tab** twice.

## Related content

- [Configure environment options](reference/general-environment-options-dialog-box.md)
- [Use IntelliSense](using-intellisense.md)