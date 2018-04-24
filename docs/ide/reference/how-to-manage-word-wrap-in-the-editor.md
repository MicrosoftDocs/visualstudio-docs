---
title: "How to: Manage Word Wrap in the Editor"
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: conceptual
helpviewer_keywords:
  - "word wrap"
  - "editors, text viewing"
  - "Code Editor, word wrap"
ms.assetid: 442f33ef-9f52-4515-b55f-fb816d664645
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# How to: Manage Word Wrap in the Editor

You can set and clear the **Word wrap** option. When this option is set, the portion of a long line that extends beyond the current width of the Code Editor window is displayed on the next line. When this option is cleared, for example, to facilitate the use of line numbering, you can scroll to the right to see the ends of long lines.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in **Help** depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md).

## Procedure

### To set word wrap preferences

1.  On the **Tools** menu, select **Options**.

2.  In the **Text Editor** folder, choose the **General** options in the **All Languages** subfolder to set this option globally.

     — or —

     Choose the **General** options in the subfolder for the language in which you are programming.

3.  Under **Settings**, select or clear the **Word wrap** option.

     When the **Word wrap** option is selected, the **Show visual glyphs for word wrap** option is enabled.

4.  Select the **Show visual glyphs for Word Wrap** option if you prefer to display a return-arrow indicator where a long line wraps onto a second line. Clear this option if you prefer not to display indicator arrows.

    > [!NOTE]
    >  These reminder arrows are not added to your code: they are for display purposes only.

## See also

- [Customizing the Editor](../../ide/customizing-the-editor.md)
- [Text Editor Options Dialog Box](../../ide/reference/text-editor-options-dialog-box.md)
- [Writing Code](../../ide/writing-code-in-the-code-and-text-editor.md)