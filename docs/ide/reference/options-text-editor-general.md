---
title: Options, Text Editor, General
description: Learn how to use the General page to change global settings for the Visual Studio code and text editor.
ms.date: 12/14/2023
ms.topic: reference
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
# Options dialog box: Text Editor \> General

This dialog box lets you change global settings for the Visual Studio code and text editor. To display this dialog box, select **Options** on the **Tools** menu, expand the **Text Editor** folder, and then select **General**.

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/tools-options-text-editor-general.png" alt-text="Screenshot of the text editor's general settings in the Options dialog box.":::

::: moniker-end

::: moniker range="vs-2019"

:::image type="content" source="media/vs-2019/tools-options-text-editor-general.png" alt-text="Screenshot of the text editor's general settings in the Options dialog box.":::

::: moniker-end

## Settings

The Settings section of **Tools** > **Options** > **Text Editor** > **General** includes the following options.

### Drag and drop text editing

When selected, this setting enables you to move text by selecting and then dragging it with the mouse to another location within the current document or any other open document.

::: moniker range=">=vs-2022"

### Select subword on double click

When you select this setting, a double-click selects only a subword instead of a whole word. (This can be helpful when you're using medial capitals, as an example.)

### Cut or Copy the current line without selection

When you select this setting, you can cut or copy the current line where your cursor is positioned without having to first select the text or code on that line.

::: moniker-end

### Automatic delimiter highlighting

When selected, delimiter characters that separate parameters or item-value pairs, as well as matching braces, are highlighted.

### Track changes

When the code editor is selected, a vertical yellow line appears in the selection margin to mark code that has changed since the file was most recently saved. When you save the changes, the vertical lines become green.

### Auto-detect UTF-8 encoding without signature

By default, the editor detects encoding by searching for byte order marks or charset tags. If neither is found in the current document, the code editor tries to autodetect UTF-8 encoding by scanning byte sequences. To disable the autodetection of encoding, clear this option.

### Follow project coding conventions

When selected, any project specific [code style settings specified in an *EditorConfig* file added to the project](../create-portable-custom-editor-options.md#code-consistency) override any local code style settings specified in the **Options** dialog box by selecting **Text Editor** > **Language, for example, C#** > **Code Style** > **General**.

> [!TIP]
> To learn more about coding conventions and how they are applied, see the [Create portable, custom editor settings with EditorConfig](../create-portable-custom-editor-options.md) page.

::: moniker range=">=vs-2022"

### Enable audio cues

When selected, Visual Studio plays an audio cue when the caret in the editor arrives on a line with an error, breakpoint, or warning. When you view a file in the Diff view, Visual Studio also plays a cue when the caret arrives on a line that's been added or removed.

> [!NOTE]
> You can also individually enable or modify these audio cues by using the Sound Control Panel in Windows.

::: moniker-end

### Enable mouse click to perform Go to Definition

When selected, you can press **Ctrl** and hover over an element while clicking the mouse. Doing so takes you to the definition of the selected element. You can also choose either **Alt** or **Ctrl** + **Alt** from the **Use modifier key** drop-down.

#### Open definition in peek view

Select this checkbox to display the element's definition in a window without navigating away from your current location in the code editor. For more information, see [How to: View and edit code by using Peek Definition](../how-to-view-and-edit-code-by-using-peek-definition-alt-plus-f12.md).

::: moniker range=">=vs-2022"

## Sticky scroll

The Sticky scroll section of **Tools** > **Options** > **Text Editor** > **General** includes the following options.

### Group the current scopes within a scrollable region of the editor window

Select this checkbox to enable [Sticky Scroll](../editor-sticky-scroll.md) to *stick* scopes to the top of the editor so that they're always in view while you *scroll* through your code. Scopes include namespaces, classes, methods, loop initialization statements, and conditionals. First introduced in Visual Studio 2022 [version 17.5](/visualstudio/releases/2022/release-notes-v17.5), supported programming languages and code formats for Sticky Scroll include C#, C++, XAML, and JSON. 

### Maximum sticky lines

Set to a default of **5**, you can increase or decrease the number of lines that you want to see in the Sticky Scroll header area.

### When number of scopes exceeds the maximum

The default is **Prefer outer scopes**, which shows higher-level scopes. You can change it to **Prefer inner scopes**, which pushes out higher-level scopes as you scroll through deeply nested code. For more information, see the "[Inner and outer scopes](../editor-sticky-scroll.md#inner-and-outer-scopes)" section of the [What is Sticky Scroll for Visual Studio](../editor-sticky-scroll.md) page.

::: moniker-end

## Display

The Display section of **Tools** > **Options** > **Text Editor** > **General** includes the following options.

### View whitespace

When selected, you can visualize spaces and tabs.

::: moniker range=">=vs-2022"

### View bidirectional text control characters

::: moniker-end

::: moniker range="=vs-2019"

### Show bidirectional text control characters

::: moniker-end

When selected, all bidirectional text control characters are rendered as placeholders in the code editor.

> [!CAUTION]
> This option is selected by default to prevent a potentially malicious exploit that allows code to be misrepresented.

See the following code snippet for an example of bidirectional control characters:

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

::: moniker range=">=vs-2022"

### View zero-width characters

When selected, zero-width characters are rendered in the code editor.

See the following code snippet for an example of zero-width characters:

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

### Enable brace pair colorization

When selected, braces are color-matched so that you can visually distinguish each set of opening and closing braces in your code. Brace colorization makes it easier to see your code's scope or find any missing braces. Released in Visual Studio 2022 [version 17.6](/visualstudio/releases/2022/release-notes-v17.6), brace pair colorization is supported for C#, C++, TypeScript, JavaScript, Visual Basic, and Razor.

:::image type="content" source="media/vs-2022/brace-pair-colorization.png" alt-text="Screenshot of an example of brace pair colorization in Visual Studio.":::

::: moniker-end

### Selection margin

When selected, displays a vertical margin along the left edge of the editor's text area. You can click this margin to select an entire line of text, or click and drag to select consecutive lines of text.

|Selection Margin on|Selection Margin off|
| - | - |
|![HTMLpageSelectionMarginOn screenshot](../../ide/reference/media/vxselmaron.gif)|![HTMLpageSelectionMarginOff screenshot](../../ide/reference/media/vxselmaroff.gif)|

### Indicator margin

When selected, displays a vertical margin outside the left edge of the editor's text area. When you click in this margin, an icon and ToolTip that are related to the text appear. For example, breakpoint or task list shortcuts appear in the indicator margin. Indicator Margin information doesn't print.

### Highlight current line

When selected, displays a gray box around the line of code in which the cursor is located.

### Show structure guide lines

When selected, vertical lines appear in the editor that line up with structured code blocks, which lets you easily identify the individual blocks of code.

### Show error squiggles

When selected, different-colored wavy underlines, known as squiggles, appear in your code. (Red squiggles denote syntax errors, blue denotes compiler errors, green denotes warnings, and purple denotes other types of errors.)

::: moniker range=">=vs-2022"

### Show selection matches

When selected, Visual Studio automatically highlights matching strings after you select text in the editor. Specifically, anytime a single line of text of 100 characters or less is selected, any matches are highlighted.

::: moniker-end

### Show file health indicator

When selected, a file health indicator status (errors, warnings) bar, with code cleanup options, is displayed in the lower-left corner of the editor.

### Line spacing

Use this control to change the default line spacing of 1.0 to the increment you want, to include 1.15, 1.5, 2.0, 2.5, and 3.0.

### Show editing context in the editor

Use this control to toggle the editing context settings altogether, or personalize to your preference by selecting from the following settings:

- Line/Col
- Selections
- Insert/Overwrite
- Tab/Space
- Line endings

## See also

- [Options, Text Editor, All Languages](../../ide/reference/options-text-editor-all-languages.md)
- [Options, Text Editor, All Languages, Tabs](../../ide/reference/options-text-editor-all-languages-tabs.md)
- [Options, Text Editor, File Extension](/previous-versions/visualstudio/visual-studio-2017/ide/reference/options-text-editor-file-extension)
- [Identifying and Customizing Keyboard Shortcuts](../../ide/identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md)
- [Customizing the Editor](../how-to-change-text-case-in-the-editor.md)
- [Using IntelliSense](../../ide/using-intellisense.md)
