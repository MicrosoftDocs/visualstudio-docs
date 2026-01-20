---
title: Customize general text editor options
description: Learn how to use the General page to change global settings for the Visual Studio Code editor.
ms.date: 12/16/2025
ms.topic: how-to
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor
- VS.ToolsOptionsPages.Text_Editor.Advanced
- VS.ToolsOptionsPages.Text_Editor.CSharp.Formatting
- VS.ToolsOptionsPages.Text_Editor.CSharp.Outlining
- VS.ToolsOptionsPages.Text_Editor.General
- VS.ToolsOptionsPages.Text_Editor.PL/SQL
- VS.ToolsOptionsPages.Text_Editor.PL/SQL.General
- VS.ToolsOptionsPages.Text_Editor.Python
- VS.ToolsOptionsPages.Text_Editor.R
- VS.ToolsOptionsPages.Text_Editor.RDL_Expression.General
- VS.ToolsOptionsPages.Text_Editor.SQL
- VS.ToolsOptionsPages.Text_Editor.SQL.General
- VS.ToolsOptionsPages.Text_Editor.SQL_Script
- VS.ToolsOptionsPages.Text_Editor.SQL_Script.General
- VS.ToolsOptionsPages.Text_Editor.T-SQL
- VS.ToolsOptionsPages.Text_Editor.T-SQL.General
- VS.ToolsOptionsPages.Text_Editor.T-SQL7.General
- VS.ToolsOptionsPages.Text_Editor.T-SQL80
- VS.ToolsOptionsPages.Text_Editor.T-SQL80.General
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
---

# Customize general text editor options

::: moniker range="visualstudio"

This section of the **Options** pane lets you change global settings for the Visual Studio Code editor. You can access the settings by selecting **Tools** > **Options** from the Visual Studio menu bar and expanding the **All Settings** > **Text Editor** > **General** section. The settings are distributed across three categories: **General**, **Display**, and **Sticky scroll**. The following image shows the settings in the **General** section:

:::image type="content" source="media/visualstudio/tools-options-text-editor-general.png" alt-text="Screenshot of the General settings for the Text Editor in the Tools Options pane.":::

::: moniker-end
::: moniker range="vs-2022"

This section of the **Options** dialog lets you change global settings for the Visual Studio Code editor. You can access the settings by selecting **Tools** > **Options** from the Visual Studio menu bar and expanding the **Text Editor** > **General** section. The settings are presented in two categories: General options (which includes Sticky scroll) and Display options. The following image shows the settings in the General category:

:::image type="content" source="media/vs-2022/tools-options-text-editor-general.png" alt-text="Screenshot of the Text Editor General settings in the Tools Options dialog.":::

::: moniker-end

## General settings

::: moniker range="visualstudio"

The following **General** options are available for the **Text Editor**.

::: moniker-end
::: moniker range="vs-2022"

The following **General** options are available for the **Text Editor**, including settings for **Sticky Scroll**.

::: moniker-end

### Drag and drop text editing

When this setting is selected, you can move text by selecting and then dragging it with the mouse to another location within the current document or any other open document.

### Select subword on double click

When you enable this setting, double-click selects a term as a _subword_ within a word and not the complete word. This action can be helpful for API names with medial capital styling, such as `MainCallbackRoutine`. Depending on the cursor location when you double-click the word, you can select the term `Main`, `Callback`, or `Routine`, rather than the complete API name.

### Cut or Copy the current line without selection

When you select this setting, you can cut or copy the current line where your cursor is positioned without having to first select the text or code on that line.

### Automatic delimiter highlighting

When this setting is selected, delimiter characters that separate parameters or item-value pairs, as well as matching braces, are highlighted.

### Track changes

When the code editor is selected, a vertical yellow line appears in the selection margin to mark code changed since the file was most recently saved. When you save the changes, the vertical lines become green.

#### Tracking mode

When you enable **Track changes**, you can set the **Tracking mode** option to the type of changes to track: **Git changes** or **File changes**.

### Auto-detect UTF-8 encoding without signature

By default, the editor detects encoding by searching for byte order marks or charset tags. If neither is found in the current document, the code editor tries to autodetect UTF-8 encoding by scanning byte sequences. To disable the autodetection of encoding, clear this option.

### Follow project coding conventions

::: moniker range="visualstudio"

When this setting is selected, any project-specific [code style settings specified in an *EditorConfig* file added to the project](../create-portable-custom-editor-options.md#code-consistency) override any local code style settings. The local settings are specified in the **Options** pane under **All Settings** > **Languages** > _\<Language, such as C#>_ > **Code Style** > **General**.

::: moniker-end
::: moniker range="vs-2022"

When this setting is selected, any project-specific [code style settings specified in an *EditorConfig* file added to the project](../create-portable-custom-editor-options.md#code-consistency) override any local code style settings. The local settings are specified in the **Options** dialog under **Text Editor** > _\<Language, such as C#>_ > **Code Style** > **General**.

::: moniker-end

> [!TIP]
> To learn more about coding conventions and how they're applied, see the [Create portable, custom editor settings with EditorConfig](create-portable-custom-editor-options.md) page.

### Enable image hover preview

When this setting is selected, if you hover on an image in the editor, a popup displays showing a preview of the image.

### Enable audio cues

When you select this setting, Visual Studio plays an audio cue when the caret in the editor arrives on a line with an error, breakpoint, or warning. When you view a file in the Diff view, Visual Studio also plays a cue when the caret arrives on an added or removed line.

> [!NOTE]
> You can also individually enable or modify these audio cues by using the Sound Control Panel in Windows.

### Enable mouse click to perform Go to Definition

When this setting is selected, you can press **Ctrl** and hover over an element while clicking the mouse. This action moves you to the location of the definition of the selected element.

#### Modifier key

You can set the **Modifier key** for the Go to Definition action to **Alt**, **Ctrl**, or **Ctrl** + **Alt**.

#### Open definition in peek view

Select this checkbox to display the element definition in a window without navigating away from your current location in the code editor. For more information, see [How to: View and edit code by using Peek Definition](how-to-view-and-edit-code-by-using-peek-definition-alt-plus-f12.md).

## Sticky scroll settings

::: moniker range="visualstudio"

The **Text Editor** > **General** > **Sticky scroll** section includes the following options for configuring scrolling behavior.

:::image type="content" source="media/visualstudio/tools-options-text-editor-scroll.png" alt-text="Screenshot of the Sticky Scroll settings for the Text Editor in the Tools Options pane.":::

::: moniker-end
::: moniker range="vs-2022"

The **Text Editor** > **General** section includes the following options for configuring **Sticky scroll** behavior.

::: moniker-end

### Group the current scopes within a scrollable region of the editor window

Select this checkbox to enable [Sticky scroll](editor-sticky-scroll.md) to *stick* scopes to the top of the editor so they're always in view while you *scroll* through your code. Scopes include namespaces, classes, methods, loop initialization statements, and conditionals. This setting is available in Visual Studio 2022 [version 17.5](/visualstudio/releases/2022/release-notes-v17.5) and later. The supported programming languages and code formats for Sticky scroll include C#, C++, XAML, and JSON. 

### Maximum sticky lines

Set to a default of **5**, you can increase or decrease the number of lines that you want to see in the Sticky Scroll header area.

### When number of scopes exceeds the maximum

The default is **Prefer outer scopes**, which shows higher-level scopes. You can change it to **Prefer inner scopes**, which pushes out higher-level scopes as you scroll through deeply nested code. For more information, see the "[Inner and outer scopes](../editor-sticky-scroll.md#inner-and-outer-scopes)" section of the [What is Sticky Scroll for Visual Studio](editor-sticky-scroll.md) page.

## Display settings

::: moniker range="visualstudio"

The **Text Editor** > **General** > **Display** section includes the following options for configuring display behavior.

:::image type="content" source="media/visualstudio/tools-options-text-editor-display.png" alt-text="Screenshot of the Display setting for the Text Editor in the Tools Options pane.":::

### Show whitespace

::: moniker-end
::: moniker range="vs-2022"

The **Text Editor** > **General** section includes the following options for configuring **Display** behavior.

:::image type="content" source="media/vs-2022/tools-options-text-editor-display.png" alt-text="Screenshot of the Text Editor Display settings in the Tools Options dialog.":::

### View whitespace

::: moniker-end

When this setting is selected, you can see spaces and tabs that make up whitespace within the content.

### Automatically indent when Word Wrap is enabled

Select this option if you want to automatically apply indentation when the Word Wrap feature is enabled.

::: moniker range="visualstudio"

### Show bidirectional text control characters

::: moniker-end
::: moniker range="vs-2022"

### View bidirectional text control characters

::: moniker-end

When this setting is selected, all bidirectional text control characters are rendered as placeholders in the code editor.

> [!CAUTION]
> This option is selected by default to prevent a potentially malicious exploit that allows code to be misrepresented.

The following code snippet shows an example of bidirectional control characters:

```csharp
/// <summary>
/// Bidirectional control characters can invert text direction,
/// which can be exploited to craft malicious code that looks benign.
/// </summary>
/// <example>
/// transferBalance(5678,6776, 4321, "USD");
/// </example>
internal readonly ImmutableArray<char> BiDiControlCharacters = ImmutableArray.CreateRange(new[] {
   '\u061c', // ALM: Arabic letter mark
   '\u200e', // LRM: Left-to-right mark
   '\u200f', // RLM: Right-to-left mark
   '\u202a', // LRE: Left-to-right embedding
   '\u202b', // RLE: Right-to-left embedding
   '\u202c', // PDF: Pop directional formatting
   '\u202d', // LRO: Left-to-right override
   '\u202e', // RLO: Right-to-left override
   '\u2066', // LRI: Left-to-right isolate
   '\u2067', // RLI: Right-to-left isolate
   '\u2068', // FSI: First strong isolate
   '\u2069', // PDI: Pop directional isolate
});
```

::: moniker range="visualstudio"

### Show zero-width characters

::: moniker-end
::: moniker range="vs-2022"

### View zero-width characters

::: moniker-end

When you select this setting, zero-width characters are rendered in the code editor.

The following code snippet shows an example of zero-width characters:

```csharp
/// <summary>
/// Zero-width characters can be exploited to craft identifiers
/// that look like other identifiers, but are in fact distinct.
/// </summary>
/// <example>
/// ab‌c‍d⁠e⁯fg
/// </example>
internal readonly ImmutableArray<char> ZeroWidthCharacters = ImmutableArray.CreateRange(new[] {
  '\u200b', // ZWSP: Zero width space
  '\u200c', // ZWNJ: Zero width non-joiner
  '\u200d', // ZWJ: Zero width joiner
  '\u2060', // WJ: Word joiner
  '\u206f', // Nominal Digit Shapes
  '\ufeff', // BOM: Zero width no-break space
});
```

::: moniker range="visualstudio"

### Show selection margin

::: moniker-end
::: moniker range="vs-2022"

### Selection margin

::: moniker-end

When this setting is selected, a vertical margin displays along the left edge of the editor's text area. You can click in this margin to select an entire line of text, or click and drag to select consecutive lines of text.

|Selection Margin on|Selection Margin off|
| - | - |
|![HTMLpageSelectionMarginOn screenshot](../../ide/media/vxselmaron.gif)|![HTMLpageSelectionMarginOff screenshot](../../ide/media/vxselmaroff.gif)|

### Enable brace pair colorization

When you use this setting, braces are color-matched so you can visually distinguish each set of opening and closing braces in your code. Brace colorization makes it easier to see your code's scope and find any missing braces. The setting is available in Visual Studio 2022 [version 17.6](/visualstudio/releases/2022/release-notes-v17.6) and later. Brace pair colorization is supported for C#, C++, TypeScript, JavaScript, Visual Basic, and Razor.

:::image type="content" source="media/vs-2022/brace-pair-colorization.png" alt-text="Screenshot of an example of brace pair colorization in Visual Studio.":::

### Automatically surround selections when typing quotes or brackets

This option makes it easy to enclose text in quotes or brackets. When you enter a quote or bracket, Visual Studio automatically adds an ending quote or bracket. As you continue to type, the text within the enclosing character is highlighted.

::: moniker range="visualstudio"

### Show indicator margin

::: moniker-end
::: moniker range="vs-2022"

### Indicator margin

::: moniker-end

When you select this setting, a vertical margin displays outside the left edge of the editor's text area. When you click in this margin, you see an icon and ToolTip related to the text. For example, breakpoint or task list shortcuts appear in the indicator margin. Indicator Margin information doesn't print.

### Highlight current line

When this setting is selected, a gray box displays around the line of code in which the cursor is located.

### Show structure guide lines

When you select this setting, vertical lines appear in the editor that line up with structured code blocks. The lines help you easily identify the individual blocks of code.

### Show error squiggles

When this option is selected, different-colored wavy underlines (_squiggles_) appear in your code. Red squiggles indicate syntax errors, blue denotes represent compiler errors, green denotes show warnings, and purple denotes indicate other types of errors.

### Show selection matches

When you select this setting, Visual Studio automatically highlights matching strings after you select text in the editor. Specifically, anytime a single line of text of 100 characters or less is selected, any matches are highlighted.

### Show file health indicator

When this option is selected, a file health status indicator (errors, warnings) bar displays in the lower-left corner of the editor. The bar status includes code cleanup options.

### Line spacing

Use this control to change the default line spacing of 1.0 to the increment you want. You can choose from 1.0, 1.15, 1.5, 2.0, 2.5, and 3.0.

::: moniker range="visualstudio"

### Outlining margin style

Use this control to change the visibility of margin expanders in the IDE. The following options are available:

- **Show expanders on hover**
- **Show expanders and vertical line on hover**
- **Always show expanders and vertical line**

::: moniker-end

### Show editing context in the editor

Use this control to toggle the editing context settings altogether, or personalize to your preference by selecting from the following settings:

::: moniker range="visualstudio"

- **Line/Col**
- **Selection**
- **Selection State**
- **Insert/Overwrite**
- **Tab/Space**
- **Line endings**
- **Encoding**

::: moniker-end
::: moniker range="vs-2022"

- **Line/Col**
- **Selections**
- **Insert/Overwrite**
- **Tab/Space**
- **Line endings**

::: moniker-end

## Related content

- [Options, Text Editor, All Languages](reference/options-text-editor-all-languages.md)
- [Options, Text Editor, All Languages, Tabs](options-text-editor-all-languages-tabs.md)
- [Options, Text Editor, File Extension](/previous-versions/visualstudio/visual-studio-2017/ide/reference/options-text-editor-file-extension)
- [Identifying and Customizing Keyboard Shortcuts](identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md)
- [Customizing the Editor](how-to-change-text-case-in-the-editor.md)
- [Using IntelliSense](using-intellisense.md)
