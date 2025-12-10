---
title: Configure advanced Text Editor options
description: Learn how to configure the Advanced page to customize global settings for the Visual Studio text editor, including completion mode, scrolling, and text rendering.
ms.date: 12/01/2025
ms.topic: how-to
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.Advanced
helpviewer_keywords:
- Text Editor Options dialog box
- Code Editor
- Text Editor [Visual Studio]
- editors, global settings
ms.custom: "ide-ref"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
monikerRange: ">=vs-2019"

#customer intent: As a Visual Studio user, I want to configure advanced Text Editor options so that I can customize editor behavior, performance, and display settings to match my preferences.
---
# Configure advanced Text Editor options

This article shows you how to configure advanced settings for the Visual Studio code and text editor. You can customize difference display modes, code completion behavior, scrolling sensitivity, text formatting, and other advanced editor features to improve your editing experience and performance.

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/tools-options-text-editor-advanced.png" alt-text="Screenshot of the Advanced settings for the text editor in the Options dialog box.":::

::: moniker-end

::: moniker range="vs-2019"

:::image type="content" source="media/vs-2019/tools-options-text-editor-advanced.png" alt-text="Screenshot of the text editor's advanced settings in the Options dialog box.":::

::: moniker-end

## Access the advanced Text Editor options

To configure advanced Text Editor options:

1. In Visual Studio, select **Tools** > **Options**.
1. Expand **Text Editor**.
1. Select **Advanced**.

## Configure difference display options

Use these options to control how the Difference viewer displays changes when you add, remove, or modify lines of text.

### Difference display mode

The **Whole line** option is selected by default. You can choose from the following options to customize highlighting and outlining:

- **Whole line**: Line differences are displayed to take up the entire width of the viewport.
- **Code contour**: Line differences are displayed only to the last character on each line.
- **Block outline**: Line and word differences are shown as outlined rectangles.
- **Mixed outline**: Line differences are shown as outlined rectangles and word differences are shown as colored rectangles.

### Show the difference overview margin

When selected (default), adds a margin view next to the scrollbar that shows the difference between Git commits. The color red indicates a deletion, and the color green indicates an addition.

::: moniker range=">=vs-2022"

### Click to peek in margin

The **Single click** setting is selected by default. You can customize how Peek Definition works when viewing differences between Git commits:

- **Single click** (default): Opens Peek Difference with a single click.
- **Double click**: Requires a double-click to open Peek Difference.
- **None**: Turns off the [Peek Difference UI](../version-control/git-line-staging.md#view-staged-changes-with-peek-difference).

::: moniker-end

## Configure code completion options

Use these options to control IntelliSense and code completion behavior.

### Responsive code completion

When selected (default), the editor suggests possible completions for your code based on its context and language semantics. Clear this option to turn off auto-complete mode.

### Default IntelliSense completion mode

Choose from one of the following completion mode settings:

- **Automatic** (default): Completes on punctuation and special characters.
- **Tab-only**: Completes only on tab.
- **Last used**: Preserves the last setting you used with **Ctrl**+**Alt**+**Space**.

### Word Based Suggestions in files handled by TextMate grammars

When enabled, Visual Studio provides auto-complete functionality based on words typed rather than code for files using [TextMate grammars](https://macromates.com/manual/en/language_grammars). Clear this option to turn off word-based suggestions.

> [!TIP]
> For more information about TextMate grammars, see [Add Visual Studio editor support for other languages](adding-visual-studio-editor-support-for-other-languages.md).

## Configure editor display and behavior options

Use these options to customize how the editor displays and interacts with your code.

### Allow CodeLens to displace the caret line

By default, [CodeLens](find-code-changes-and-other-history-with-codelens.md) information appears over a code line. Select this option to show CodeLens information directly in your code line at your current caret position.

::: moniker range=">=vs-2022"

### Use box selection

Select this option to disable the new [multi-caret selection](finding-and-replacing-text.md?view=vs-2022&preserve-view=true#multi-caret-selection) behavior in Visual Studio 2022 or later, which includes the following:

- Adapts "block selection" similarly as does the multi-caret functionality in [VS Code](https://code.visualstudio.com/docs/editor/codebasics#_multiple-selections-multicursor).
- Supports copying and pasting a different section of text with each caret, instead of just a single block-shaped section of text.
- Moves each caret when you press the arrow keys, and doesn't dismiss the block selection.

> [!NOTE]
> When selected, the option applies the box selection behavior that was available in Visual Studio 2019 and earlier versions. Specifically, the option enables you to select a rectangular section of items when you press **Alt** and then drag your mouse to select text (or press the **Shift**+**Alt**+**Left**/**Up**/**Right**/**Down** to select text). This option is limited in that when you press an arrow key, Visual Studio dismisses the box selection and returns to a single caret.

::: moniker-end

### Use adaptive formatting

When selected (default), Visual Studio recognizes whether you prefer to use tabs or spaces to indent code based on your most recently updated file. When cleared, Visual Studio uses the settings in **Tools** > **Options** > **Text Editor** > **All Languages** > **[Tabs](options-text-editor-all-languages-tabs.md)** instead.

> [!TIP]
> You can also change how Visual Studio manages your preferred indent style by using an .*editorconfig* file. For more information, see [Create portable, custom editor settings with EditorConfig](create-portable-custom-editor-options.md).

::: moniker range=">=vs-2022"

### Fallback support for C#, C++, Java, and TypeScript GoTo symbol navigation

Select this option to disable TextMate fallback support for symbol search, which can help improve system performance. (Available in Visual Studio 2022 version 17.0 through 17.3 only.)

::: moniker-end

## Configure copy and paste options

Use these options to control how Visual Studio handles copy and paste operations.

### Copy rich text on copy/cut

When selected (default), Visual Studio copies text that includes colors and ligatures. Clear this option to copy flat text instead.

> [!TIP]
> Unselecting this option improves the responsiveness and performance of Visual Studio during a copy/paste operation. Rich copy can cause UI delays and temporary hangs.

### Max length

Use this option to increase or decrease the maximum character count of rich text you can copy or cut from your code. The default is set to **10240**. Beyond this limit, text is still copied, but as plain text rather than rich text.

### Use accurate classification

Select this option to allow for semantic colorization. A "wait" dialog might appear after a few seconds. (Syntactic colorization is fast to copy, while semantic colorization is slower. Semantic information allows for richer and more accurate colorization.)

## Configure background task options

Use these options to control how Visual Studio manages background tasks while you're typing.

### Auto cancel long running auxiliary operations on typing

When selected (default), Visual Studio stops background tasks when you're typing in the text editor. This option controls how aggressive Visual Studio is about canceling work that might temporarily freeze the UI while you type.

### Automatically adjust maximum allowed typing latency

When selected (default), Visual Studio adjusts the maximum typing latency a feature or extension can cause before it's canceled.

### Maximum allowed typing latency in milliseconds

Select this option if you prefer to set a specific maximum latency that Visual Studio applies while you're typing in the text editor.

## Configure scrolling options

Use these options to improve scrolling performance in Visual Studio.

### Vertical scrolling sensitivity (lines per scroll)

Use this option to adjust how many vertical lines you want to scroll in each user-interface action. The default is set to **3**.

### Horizontal scrolling sensitivity (characters per scroll)

Use this option to adjust how many characters you want to scroll in each user-interface action. The default is set to **1**.

## Configure text formatting and rendering options

Use these options to fine-tune how Visual Studio formats and renders text based on your hardware.

### Text formatting method

The default is **Automatic**. You can choose from two additional options:

- **Ideal**: Provides the highest quality text formatting.
- **Display**: Optimizes for display performance.

Choose the option that best allows you to fine-tune text formatting in the editor based on your specific hardware.

For more information, see [TextFormattingMode](/dotnet/api/system.windows.media.textformattingmode?view=windowsdesktop-6.0&preserve-view=true).

### Text rendering method

The default is **Automatic**. You can choose from three additional options:

- **ClearType**: Uses ClearType rendering for smoother text.
- **Greyscale**: Uses greyscale anti-aliasing.
- **Aliased**: Uses aliased rendering without anti-aliasing.

Choose the option that best allows you to fine-tune text rendering in the editor based on your specific hardware.

For more information, see [TextRenderingMode](/dotnet/api/system.windows.media.textrenderingmode?view=windowsdesktop-6.0&preserve-view=true).

## Related content

- [Configure general Text Editor options](reference/options-text-editor-general.md)