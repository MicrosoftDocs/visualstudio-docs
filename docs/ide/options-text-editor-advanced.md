---
title: Configure advanced Text Editor options
description: Learn how to configure the Advanced page to customize global settings for the Visual Studio text editor, including completion mode, scrolling, and text rendering.
ms.date: 12/11/2025
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

This article shows you how to configure advanced settings for the Visual Studio Code and text editor. You can customize difference display modes, code completion behavior, scrolling sensitivity, and text formatting. The advanced editor features allow you to improve your editing experience and performance.

::: moniker range="visualstudio"

:::image type="content" source="media/visualstudio/tools-options-text-editor-advanced.png" alt-text="Screenshot of the All Settings, Text Editor, Advanced options in Visual Studio.":::

::: moniker-end
::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/tools-options-text-editor-advanced.png" alt-text="Screenshot of the Advanced settings for the text editor in the Options dialog box.":::

::: moniker-end
::: moniker range="vs-2019"

:::image type="content" source="media/vs-2019/tools-options-text-editor-advanced.png" alt-text="Screenshot of the text editor's advanced settings in the Options dialog box.":::

::: moniker-end

## Access the advanced Text Editor options

::: moniker range="visualstudio"

In Visual Studio, select **Tools** > **Options**. In the **Options** pane, expand the **All Settings** > **Text Editor** > **Advanced** section, and configure the desired settings. Related settings are available in the **All Settings** > **Text Editor** > **[Touchpad and mouse wheel scrolling sensitivity](#touchpad-and-mouse-wheel-scrolling-sensitivity)** section.

### Editor horizontal scrollbar location

Use this setting to configure the behavior of the horizontal scroll bar in the Visual Studio IDE. Select from the following options:

- **Adjust according to available space**: Dynamically adjust the size of the scrollbar based on the available space in the current view.
- **Always show in the editor tray**: Display the scrollbar within the bounds of the editor tray that shows other available actions.
- **Always show above the editor tray**: Display the scrollbar above the editor tray within its own space.

The following sections describe the other available settings.

::: moniker-end
::: moniker range="<=vs-2022"

In Visual Studio, select **Tools** > **Options**. In the **Options** dialog, expand the **Text Editor** > **Advanced** section, and configure the desired settings.

::: moniker-end

## Configure Difference display options

Use these options to control how the Difference viewer displays changes when you add, remove, or modify lines of text.

### Difference display mode

The **Whole line** option is enabled by default. You can choose from the following options to customize highlighting and outlining:

- **Whole line**: Line differences are displayed to take up the entire width of the viewport.
- **Code contour**: Line differences are displayed only to the last character on each line.
- **Block outline**: Line and word differences are shown as outlined rectangles.
- **Mixed outline**: Line differences are shown as outlined rectangles and word differences are shown as colored rectangles.

::: moniker range="visualstudio"

### Difference overview margin

::: moniker-end
::: moniker range="<=vs-2022"

### Show the difference overview margin

::: moniker-end

::: moniker range=">=vs-2022"

When this setting is enabled (default), Visual Studio adds a margin next to the scrollbar so you can view the difference between Git commits. Red text in the margin indicates a deletion and green indicates an addition. 

### Click to peek in margin

The **Single click** setting is selected by default. You can customize how Peek Definition works when viewing differences between Git commits:

- **Single click** (default): Opens Peek Difference with a single click.
- **Double click**: Requires a double click to open Peek Difference.
- **None** (or **Off**): Turns off the [Peek Difference UI](../version-control/git-line-staging.md#view-staged-changes-with-peek-difference).

::: moniker-end

## Configure code completion options

Use these options to control IntelliSense and code completion behavior.

### Responsive code completion

When this setting is enabled (default), the editor suggests possible completions for your code based on its context and language semantics. Clear this option to turn off autocomplete mode.

### Default IntelliSense completion mode

Choose from one of the following completion mode settings:

- **Automatic** (default): Completes on punctuation and special characters.
- **Tab-only**: Completes only on tab.
- **Last used**: Preserves the last setting you used with **Ctrl**+**Alt**+**Space**.

### Word Based Suggestions in files handled by TextMate grammars

When this setting is enabled, Visual Studio provides autocomplete functionality based on words typed rather than code for files by using [TextMate grammars](https://macromates.com/manual/en/language_grammars). Clear this option to turn off word-based suggestions.

### TextMate parser line limit

Use this setting to increase or decrease the maximum parser line limit. The default value is **10000**. If you change the value, you need to restart the application.

> [!TIP]
> For more information about TextMate grammars, see [Add Visual Studio editor support for other languages](adding-visual-studio-editor-support-for-other-languages.md).

## Configure editor display and behavior options

Use these options to customize how the editor displays and interacts with your code.

### Allow CodeLens to displace the caret line

By default, [CodeLens](find-code-changes-and-other-history-with-codelens.md) information appears over a code line. When you enable this setting, the CodeLens information displays directly in your code line at your current caret position.

### Show file level CodeLens indicator

When this setting is enabled, Visual Studio shows the CodeLens indicator at the file level.

::: moniker range="visualstudio"

### Box selection

::: moniker-end
::: moniker range="vs-2022"

### Use box selection

::: moniker-end

::: moniker range=">=vs-2022"

Enable this setting to disable the new [multi-caret selection](finding-and-replacing-text.md?view=vs-2022&preserve-view=true#multi-caret-selection) behavior in Visual Studio 2022 or later, which provides the following functionality:

- Adapts "block selection" similarly as does the multi-caret functionality in [Visual Studio Code](https://code.visualstudio.com/docs/editor/codebasics#_multiple-selections-multicursor).
- Supports copying and pasting a different section of text with each caret, instead of just a single block-shaped section of text.
- Moves each caret when you press the arrow keys, and doesn't dismiss the block selection.

> [!NOTE]
> When this setting is enabled, the option applies the box selection behavior available in Visual Studio 2019 and earlier versions. Specifically, the option enables you to select a rectangular section of items when you select **Alt** and then drag your mouse to highlight text (or select **Shift**+**Alt**+**Left**/**Up**/**Right**/**Down** to highlight text). This option is limited when you press an arrow key. Visual Studio dismisses the box selection and returns to a single caret.

::: moniker-end

::: moniker range="visualstudio"

### Adaptive formatting

When this setting is enabled (default), Visual Studio recognizes whether you prefer to use tabs or spaces to indent code based on your most recently updated file. When the setting is cleared, Visual Studio uses the **Tools** > **Options** settings under **All Settings** > **Languages** > **Defaults** > **[Tabs](options-text-editor-all-languages-tabs.md)** instead.

::: moniker-end
::: moniker range="vs-2022"

### Use adaptive formatting

When this setting is enabled (default), Visual Studio recognizes whether you prefer to use tabs or spaces to indent code based on your most recently updated file. When the setting is cleared, Visual Studio uses the **Tools** > **Options** settings under **Text Editor** > **All Languages** > **[Tabs](options-text-editor-all-languages-tabs.md)** instead.

::: moniker-end

> [!TIP]
> You can also change how Visual Studio manages your preferred indent style by using an *.editorconfig* file. For more information, see [Create portable, custom editor settings with EditorConfig](create-portable-custom-editor-options.md).

::: moniker range="visualstudio"

### Compress blank lines

Use this setting to force compression of blank lines in the current view. This action can help to reduce empty space in the view. The setting is disabled by default.

### Compress lines that don't have any alphanumeric characters

Use this setting to force compression of any lines in the current view that don't contain alphanumeric characters. This action can help to remove unnecessary content in the view. The setting is disabled by default.

### Indexing with Find in Files

::: moniker-end
::: moniker range="vs-2022"

### Use indexing with Find in Files

When this setting is enabled, Visual Studio uses indexing when you run the Find in Files action. Clear this option if you don't what the action to include indexing.

### Fallback support for C#, C++, Java, and TypeScript GoTo symbol navigation

Select this option to disable TextMate fallback support for symbol search, which can help improve system performance. (Available in Visual Studio 2022 version 17.0 through 17.3 only.)

::: moniker-end

## Configure copy and paste options

Use these options to control how Visual Studio handles copy and paste operations.

### Copy rich text on copy/cut

When this setting is enabled (default), Visual Studio copies text that includes colors and ligatures. Clear this option to copy flat text instead.

> [!TIP]
> Unselecting this option improves the responsiveness and performance of Visual Studio during a copy/paste operation. Rich copy can cause UI delays and temporary hangs.

### Max length

Use this setting to increase or decrease the maximum character count of rich text you can copy or cut from your code. The default value is **10240**. Beyond this limit, text is still copied, but as plain text rather than rich text.

::: moniker range="vs-2022"

### Use accurate classification

Select this option to allow for semantic colorization. A "wait" dialog might appear after a few seconds. Syntactic colorization is fast to copy, while semantic colorization is slower. Semantic information allows for richer and more accurate colorization. (Available in Visual Studio 2022 through version 17.8.)

::: moniker-end

## Configure background task options

Use these options to control how Visual Studio manages background tasks while you're typing.

### Auto cancel long running auxiliary operations on typing

When this setting is enabled (default), Visual Studio stops background tasks when you're typing in the text editor. This option controls how aggressive Visual Studio is about canceling work that might temporarily freeze the UI while you type.

::: moniker range="visualstudio"

### Load editor components asynchronously

When this setting is enabled, Visual Studio loads the editor components asynchronously as they're available, rather than loading all components at the same time. This approach might result in a slight visual delay as the components are prepared. This setting was previously available as the Preview feature **Initialize editor parts asynchronously during solution load**. (Some extensions might not support this option.)

::: moniker-end
::: moniker range="<=vs-2022"

### Automatically adjust maximum allowed typing latency

When this setting is enabled (default), Visual Studio adjusts the maximum typing latency a feature or extension can cause before it cancels the action.

### Maximum allowed typing latency in milliseconds

Select this option if you prefer to set a specific maximum latency that Visual Studio applies while you're typing in the text editor.

## Configure the horizontal scrollbar

Use the **Editor horizontal scrollbar location** setting to configure the behavior of the horizontal scroll bar in the Visual Studio IDE. Select from the following options:

- **Adjust according to available space**: Dynamically adjust the size of the scrollbar based on the available space in the current view.
- **Always show in the editor tray**: Display the scrollbar within the bounds of the editor tray that shows other available actions.
- **Always show above the editor tray**: Display the scrollbar above the editor tray within its own space.

::: moniker-end

## Configure text formatting and rendering options

Use these options to fine-tune how Visual Studio formats and renders text based on your hardware.

### Text formatting method

This setting lets you configure how text is formatted. The default value is **Automatic**. You can choose from two other options:

- **Ideal**: Use the highest quality text formatting.
- **Display**: Optimize the formatting based on display performance.

Choose the option that best allows you to fine-tune text formatting in the editor based on your specific hardware.

For more information, see [TextFormattingMode](/dotnet/api/system.windows.media.textformattingmode?view=windowsdesktop-6.0&preserve-view=true).

### Text rendering method

This setting lets you configure how text is rendered. The default value is **Automatic**. You can choose from three other options:

- **ClearType**: Use ClearType rendering for smoother text.
- **Greyscale**: Use greyscale anti-aliasing.
- **Aliased**: Use aliased rendering without anti-aliasing.

Choose the option that best allows you to fine-tune text rendering in the editor based on your specific hardware.

For more information, see [TextRenderingMode](/dotnet/api/system.windows.media.textrenderingmode?view=windowsdesktop-6.0&preserve-view=true).

::: moniker range="visualstudio"

## Touchpad and mouse wheel scrolling sensitivity

Use these options to improve scrolling performance in Visual Studio.

::: moniker-end
::: moniker range="<=vs-2022"

## Configure scrolling options

Use the **Touchpad and mouse wheel scrolling sensitivity** options to improve scrolling performance in Visual Studio.

::: moniker-end

### Vertical scrolling sensitivity (lines per scroll)

Use this setting to adjust how many vertical lines you want to scroll in each user-interface action. The default value is **3**.

### Horizontal scrolling sensitivity (characters per scroll)

Use this setting to adjust how many characters you want to scroll in each user-interface action. The default value is **1**.

::: moniker range="visualstudio"

### Fast scroll multiplier

This setting increases the scrolling speed when you use the **Alt** keyboard shortcut with the mouse or keyboard arrow keys. The default multiplication factor is **5**, which scrolls five times faster than normal.

### Middle click to scroll

When this setting is enabled, you can use the middle button on the mouse to scroll in the editor window.

::: moniker-end

## Related content

- [Configure general Text Editor options](reference/options-text-editor-general.md)