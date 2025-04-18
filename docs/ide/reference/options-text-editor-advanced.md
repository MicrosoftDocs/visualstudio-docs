---
title: Options, Text Editor, Advanced
description: Learn how to use the Advanced dialog box to change global settings for the Visual Studio text editor.
ms.date: 06/15/2023
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.Advanced
helpviewer_keywords:
- Text Editor Options dialog box
- Code Editor
- Text Editor [Visual Studio]
- editors, global settings
ms.custom: "ide-ref"
author:anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
monikerRange: ">=vs-2019"
---
# Options dialog box: Text Editor \> Advanced

You can use the Advanced dialog box to change global settings for the Visual Studio code and text editor. To display the dialog box, select **Tools** from the menu bar, and then select **Options** > **Text Editor** > **Advanced**.

::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/tools-options-text-editor-advanced.png" alt-text="Screenshot of the Advanced settings for the text editor in the Options dialog box.":::

::: moniker-end

::: moniker range="vs-2019"

:::image type="content" source="media/vs-2019/tools-options-text-editor-advanced.png" alt-text="Screenshot of the text editor's advanced settings in the Options dialog box.":::

::: moniker-end

## Difference display mode

The **Whole line** option is selected by default. The options you can choose from allow you to customize the highlighting and outlining that's displayed in the Difference viewer when you add, remove, or modify lines of text. Specifically, the options provide the following viewing experiences:

- **Whole line**: Line differences should be displayed so that they take up the entire width of the viewport.
- **Code contour**: Line differences should be displayed only to the last character on each line.
- **Block outline**: Line and word differences are shown as outlined rectangles.
- **Mixed outline**: Line differences are shown as outlined rectangles and word differences are shown as colored rectangles.

## Show the difference overview margin

Selected by default, this option adds a margin view next to the scrollbar that shows the difference between Git commits. The color red indicates a deletion, and the color green indicates an addition.

## Responsive code completion

Selected by default, this option enables the editor to suggest possible completions for your code based on its context and language semantics. Toggle to turn off auto-complete mode. 

::: moniker range="vs-2022"

## Click to peek in margin

The **Single click** setting is selected by default. The settings you choose from allow you to customize how Peek Definition works when you use it to display the differences between Git commits. You can change the default **Single click** setting to **Double click**, or you can select **None** to turn off the [Peek Difference UI](../../version-control/git-line-staging.md#view-staged-changes-with-peek-difference).

::: moniker-end

## Word Based Suggestions in files handled by TextMate grammars

Visual Studio provides alternate programming language support and colorization in the editor by using [TextMate grammars](https://macromates.com/manual/en/language_grammars). When enabled, the Visual Studio auto-complete functionality is based on words typed rather than code. Toggle to turn off.

> [!TIP]
> For more information about TextMate grammars, see [Add Visual Studio editor support for other languages](../adding-visual-studio-editor-support-for-other-languages.md).

## Default IntelliSense completion mode

Choose from one of the following completion mode settings:

- **Automatic**, the default setting, which completes on punctuation and special characters.
- **Tab-only**, which completes only on tab.
- **Last used**, which preserves the last setting you used with **Ctrl**+**Alt**+**Space**.

## Allow CodeLens to displace the caret line

By default, [CodeLens](../find-code-changes-and-other-history-with-codelens.md) information appears over a code line. Toggle to show CodeLens information directly in your code line at your current caret position, instead.

::: moniker range="vs-2022"

## Use box selection

Select this option to disable the new [multi-caret selection](../finding-and-replacing-text.md?view=vs-2022&preserve-view=true#multi-caret-selection) behavior in Visual Studio 2022, which includes the following:

- Adapts "block selection" similarly as does the multi-caret functionality in [VS Code](https://code.visualstudio.com/docs/editor/codebasics#_multiple-selections-multicursor).
- Supports copying and pasting a different section of text with each caret, instead of just a single block-shaped section of text.
- Moves each caret when you press the arrow keys, and doesn't dismiss the block selection.

> [!NOTE]
> When selected, the option applies the box selection behavior that was available in Visual Studio 2019 and earlier versions. Specifically, the option enables you to select a rectangular section of items when you press **Alt** and then drag your mouse to select text (or press the **Shift**+**Alt**+**Left**/**Up**/**Right**/**Down** to select text). This option is limited in that when you press an arrow key, Visual Studio dismisses the box selection and returns to a single caret.

## Use adaptive formatting

Based on your most recently updated file, Visual Studio recognizes whether you prefer to use tabs or spaces to indent code. The adaptive formatting option is selected by default. When unselected, Visual Studio uses the settings in **Tools** > **Options** > **Text Editor** > **All Languages** > **[Tabs](options-text-editor-all-languages-tabs.md)** instead.

> [!TIP]
> You can also change how Visual Studio manages your preferred indent style by using an .*editorconfig* file. For more information, see [Create portable, custom editor settings with EditorConfig](../create-portable-custom-editor-options.md).

## Fallback support for C#, C++, Java, and TypeScript GoTo symbol navigation

Select this option to disable TextMate fallback support for symbol search, which can help improve system performance. (Available in Visual Studio 2022 version 17.0 through 17.3 only.)

::: moniker-end

## Copy rich text on copy/cut

Selected by default, the option copies text that includes colors and ligatures. Toggle to copy flat text instead.

> [!TIP]
> Unselecting this option improves the responsiveness and performance of Visual Studio during a copy/paste operation. Rich copy can cause UI delays and temporary hangs.

### Max length

Use this option to increase or decrease the maximum character count of rich text you can copy or cut from your code. The default is set to **10240**. (Beyond this limit, text is still copied, but as plain text rather than rich text.)

### Use accurate classification

Toggle this checkbox to allow for semantic colorization. A "wait" dialog might appear after a few seconds. (There's syntactic colorization, which is fast to copy, and semantic colorization, which is slower to copy. Semantic information allows for richer and more accurate colorization.)

## Auto cancel long running auxiliary operations on typing

Selected by default, this option allows Visual Studio to stop background tasks when you're typing in the text editor. In other words, it controls how aggressive Visual Studio is about canceling work that might temporarily freeze the UI while you type.

### Automatically adjust maximum allowed typing latency

Selected by default, this option adjusts the maximum typing latency a feature or extension can cause to typing before it's canceled by Visual Studio.

### Maximum allowed typing latency in milliseconds

Select this option if you prefer to set the maximum latency that Visual Studio applies while you're typing in the text editor.

::: moniker range="vs-2019"

## Use adaptive formatting

Based on your most recently updated file, Visual Studio recognizes whether you prefer to use tabs or spaces for code indentation. The adaptive formatting option is selected by default. When unselected, Visual Studio uses the settings in **Tools** > **Options** > **Text Editor** > **All Languages** > **[Tabs](options-text-editor-all-languages-tabs.md)** instead.

::: moniker-end

## Scrolling sensitivity

Use this option to improve the scrolling performance in Visual Studio.

### Vertical scrolling sensitivity (lines per scroll)

Use this option to adjust how many vertical lines you want to scroll in each user-interface action. The default is set to **3**.

### Horizontal scrolling sensitivity (characters per scroll)

Use this option to adjust how many characters you want to scroll in each user-interface action. The default is set to **1**.

## Text formatting method

The default is **Automatic**. You can choose one of two more options, either **Ideal** or **Display**. Choose the option that best allows you to fine-tune text formatting in the editor, based on your specific hardware.

For more information, see [TextFormattingMode](/dotnet/api/system.windows.media.textformattingmode?view=windowsdesktop-6.0&preserve-view=true).

## Text rendering method

The default is **Automatic**. You can choose one of three more options, **ClearType**, **Greyscale**, or **Aliased**. Choose the option that best allows you to fine-tune text rendering in the editor, based on your specific hardware.

For more information, see [TextRenderingMode](/dotnet/api/system.windows.media.textrenderingmode?view=windowsdesktop-6.0&preserve-view=true).

## See also

[Options dialog box: Text Editor > General](options-text-editor-general.md)