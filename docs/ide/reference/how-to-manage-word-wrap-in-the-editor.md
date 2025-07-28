---
title: Toggle word wrap to see long code or line numbers
description: Enable word wrapping to display code on multiple lines, or turn the feature off to see line numbers.
ms.date: 07/28/2025
ms.topic: how-to
helpviewer_keywords:
- word wrap
- editors, text viewing
- Code Editor, word wrap
ms.custom: "ide-ref"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
#customer intent: As a developer, I want to turn word wrap on or off to improve usability of Visual Studio in writing code in different situations.
---
# Manage word wrap in the editor

You can turn the **Word wrap** option on or off. When enabled, long lines that extend beyond the current width of the Code Editor window continue onto the next line. When disabled, you can scroll horizontally to view the rest of long lines. You can turn this option off to use line numbering.

## To set word wrap preferences

1. Select **Tools** > **Options**.
1. Select **Text Editor** > **All Languages** > **General** to set this option globally.

   — or —

   Select **Text Editor** > Programming language that you're using, for example, **C#** > **General**.
1. Under **Settings**, select or clear the **Word wrap** option.

   When you select the **Word wrap** option, the **Show visual glyphs for word wrap** option is enabled.

   :::image type="content" source="media/vs-2022/word-wrap-setting.png" alt-text="Screenshot of the word wrap option in Text Editor Settings." lightbox="media/vs-2022/word-wrap-setting.png":::

   > [!NOTE]
   > The **Show visual glyphs for Word Wrap** option displays a return-arrow indicator where a long line wraps onto a second line. These reminder arrows are not added to your code. They are for display purposes only.

## To indent word wrap

Starting with Visual Studio 17.13, you can choose whether wrapped lines in the editor should be indented.

To change word wrap indentation:

1. Go to **Tools > Options > Text Editor > General**.
1. Under **Display**, select or clear the **Automatically indent when word wrap is enabled** option.

By default, word wrap indentation is enabled. If you prefer your wrapped lines not be indented, simply uncheck this option.
Use this setting to help improve readability and maintain the desired formatting of your code.

## Known issues

If you're familiar with word wrap in Notepad++, Sublime Text, or Visual Studio Code (VS Code), be aware of the following issues where Visual Studio behaves differently to other editors:

* [Unexpected and sporadic indents](https://developercommunity.visualstudio.com/t/Unexpected-and-sporadic-indents-when-usi/10635809)
* [Pressing Home key twice should move cursor to very beginning of line](https://developercommunity.visualstudio.com/t/Pressing-Home-key-twice-should-move-curs/10635835)

## Related content

[Features of the code editor](../writing-code-in-the-code-and-text-editor.md)
