---
title: Word wrap
ms.date: 11/07/2018
ms.topic: conceptual
helpviewer_keywords:
  - "word wrap"
  - "editors, text viewing"
  - "Code Editor, word wrap"
ms.assetid: 442f33ef-9f52-4515-b55f-fb816d664645
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Manage word wrap in the editor

You can set and clear the **Word wrap** option. When this option is set, the portion of a long line that extends beyond the current width of the Code Editor window is displayed on the next line. When this option is cleared, for example, to facilitate the use of line numbering, you can scroll to the right to see the ends of long lines.

> [!NOTE]
> This topic applies only to Visual Studio on Windows. Visual Studio for Mac does not currently support word wrap.

## To set word wrap preferences

1. On the **Tools** menu, select **Options**.

2. In the **Text Editor** folder, choose the **General** options in the **All Languages** subfolder to set this option globally.

     — or —

     Choose the **General** options in the subfolder for the language in which you are programming.

3. Under **Settings**, select or clear the **Word wrap** option.

     When the **Word wrap** option is selected, the **Show visual glyphs for word wrap** option is enabled.

4. Select the **Show visual glyphs for Word Wrap** option if you prefer to display a return-arrow indicator where a long line wraps onto a second line. Clear this option if you prefer not to display indicator arrows.

    > [!NOTE]
    > These reminder arrows are not added to your code; they are for display purposes only.

## Known issues

If you're familiar with word wrap in Notepad++, Sublime Text, or Visual Studio Code, be aware of the following issues where Visual Studio behaves differently to other editors:

* [Triple click doesn't select whole line](https://developercommunity.visualstudio.com/content/problem/268989/triple-click-doesnt-select-whole-line-when-word-wr.html)
* [Cut command doesn't delete whole line](https://developercommunity.visualstudio.com/content/problem/138259/cut-command-should-delete-logical-line.html)
* [Pressing End key twice does not move cursor to end of line](https://developercommunity.visualstudio.com/content/problem/138274/pressing-end-key-twice-should-move-cursor-to-end-o.html)

## See also

- [Features of the code editor](../../ide/writing-code-in-the-code-and-text-editor.md)
