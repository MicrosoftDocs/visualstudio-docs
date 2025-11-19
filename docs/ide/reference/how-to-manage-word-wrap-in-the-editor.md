---
title: Toggle word wrap to see long code or line numbers
description: Enable word wrapping to display code on multiple lines, or turn the feature off to see line numbers.
ms.date: 11/19/2025
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

:::moniker range="visualstudio"

1. Open the **Tools** > **Options** pane, and expand the **All Settings** > **Languages** section.

1. Expand the language section you're using (such as **C#** or **Visual Basic**) and then expand the **General** section.

1. Select or clear the **Word wrap** checkbox.

   :::image type="content" source="media/visualstudio/word-wrap-setting.png" border="false" alt-text="Screenshot that shows how to set the Word wrap option for a specific language.":::

You can also configure word wrap for all supported programming languages. Expand the **All Settings** > **Languages** > **Defaults** > **General** section and select or clear the **Word wrap** option.

:::moniker-end
:::moniker range="<=vs-2022"

1. On the Visual Studio menu bar, select **Tools** > **Options**.

1. In the **Options** dialog, expand the **Text Editor** section.

1. Expand the language section you're using (such as **C#** or **Visual Basic**) and then expand the **General** section.

1. Select or clear the **Word wrap** checkbox, and then select **OK**.

   :::image type="content" source="media/vs-2022/word-wrap-setting.png" border="false" alt-text="Screenshot of the word wrap option in Text Editor Settings.":::

:::moniker-end

   When you select the **Word wrap** option, the **Show visual glyphs for word wrap** option is automatically enabled.

   > [!NOTE]
   > The **Show visual glyphs for Word Wrap** option displays a return-arrow indicator where a long line wraps onto a second line. These reminder arrows aren't added to your code. They're for display purposes only.

:::moniker range="visualstudio"

You can also configure word wrap for all supported programming languages. Expand the **All Settings** > **Languages** > **Defaults** > **General** section and select or clear the **Word wrap** option.

:::moniker-end
:::moniker range="<=vs-2022"

You can also configure word wrap for all supported programming languages. Expand the **Text Editor** > **All Languages** > **General** section and select the **Word wrap** option.

:::moniker-end

## To indent word wrap

Starting with Visual Studio 17.13, you can choose whether to indent wrapped lines in the editor.

To change word wrap indentation:

:::moniker range="visualstudio"

1. In the **Tools** > **Options** pane, expand the **All Settings** > **Text Editor** > **General** section.

1. In the **Display** group, select or clear the **Automatically indent when word wrap is enabled** checkbox.

:::moniker-end
:::moniker range="<=vs-2022"

1. In the **Tools** > **Options** dialog, expand the **Text Editor** > **General** section.

1. In the **Display** group, select or clear the **Automatically indent when word wrap is enabled** checkbox, and then select *OK**.

:::moniker-end

By default, word wrap indentation is enabled. If you prefer no indentation for wrapped lines, clear this option.
Use this setting to help improve readability and maintain the desired formatting of your code.

## Known issues

If you're familiar with word wrap in Notepad++, Sublime Text, or Visual Studio Code (VS Code), be aware of the following issues where Visual Studio behaves differently to other editors:

* [Unexpected and sporadic indents](https://developercommunity.visualstudio.com/t/Unexpected-and-sporadic-indents-when-usi/10635809)
* [Pressing Home key twice should move cursor to very beginning of line](https://developercommunity.visualstudio.com/t/Pressing-Home-key-twice-should-move-curs/10635835)

## Related content

[Features of the code editor](../writing-code-in-the-code-and-text-editor.md)
