---
title: Toggle word wrap to see long code or line numbers
description: Enable word wrapping in Visual Studio to display code on multiple lines, or turn the feature off to see line numbers.
ms.date: 05/31/2024
ms.topic: how-to
helpviewer_keywords:
- word wrap
- editors, text viewing
- Code Editor, word wrap
ms.custom: "ide-ref"
author:anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
#customer intent: As a developer, I want to turn word wrap on or off to improve usability of Visual Studio in writing code in different situations.
---
# Manage word wrap in the editor

You can set and clear the **Word wrap** option. When this option is set, the portion of a long line that extends beyond the current width of the Code Editor window is displayed on the next line. When this option is cleared, you can scroll to the right to see the ends of long lines. You might turn this option off to facilitate the use of line numbering.

## To set word wrap preferences

1. On the Visual Studio menu bar, select **Tools** > **Options**.

   :::image type="content" source="media/vs-2022/tools-options-menu-bar.png" alt-text="Screenshot of the menu bar in Visual Studio with Tools and Options selected." lightbox="media/vs-2022/tools-options-menu-bar.png":::

1. Select **Text Editor** > **All Languages** > **General** to set this option globally.

   — or —

   Select **Text Editor**, select the folder that matches the programming language that you're using. Then select the **General** folder. For example, select **Text Editor** > **C#** > **General**.

1. Under **Settings**, select or clear the **Word wrap** option.

   When you select the **Word wrap** option, the **Show visual glyphs for word wrap** option is enabled.

   > [!NOTE]
   > The **Show visual glyphs for Word Wrap** option displays a return-arrow indicator where a long line wraps onto a second line. These reminder arrows are not added to your code. They are for display purposes only.

## Known issues

If you're familiar with word wrap in Notepad++, Sublime Text, or Visual Studio Code (VS Code), be aware of the following issues where Visual Studio behaves differently to other editors:

* [Unexpected and sporadic indents](https://developercommunity.visualstudio.com/t/Unexpected-and-sporadic-indents-when-usi/10635809)
* [Pressing Home key twice should move cursor to very beginning of line](https://developercommunity.visualstudio.com/t/Pressing-Home-key-twice-should-move-curs/10635835)

## Related content

[Features of the code editor](../writing-code-in-the-code-and-text-editor.md)
