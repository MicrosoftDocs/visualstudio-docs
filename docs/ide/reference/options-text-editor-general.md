---
title: Options, Text Editor, General
ms.date: 01/18/2019
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor"
  - "vs.toolsoptionspages.text_editor"
  - "VS.ToolsOptionsPages.Text_Editor.CSharp.Formatting"
  - "VS.ToolsOptionsPages.Text_Editor.CSharp.Outlining"
  - "VS.ToolsOptionsPages.Text_Editor.General"
  - "VS.ToolsOptionsPages.Text_Editor.PL/SQL"
  - "VS.ToolsOptionsPages.Text_Editor.PL/SQL.General"
  - "VS.ToolsOptionsPages.Text_Editor.Python"
  - "VS.ToolsOptionsPages.Text_Editor.R"
  - "VS.ToolsOptionsPages.Text_Editor.RDL_Expression.General"
  - "VS.ToolsOptionsPages.Text_Editor.SQL"
  - "VS.ToolsOptionsPages.Text_Editor.SQL.General"
  - "VS.ToolsOptionsPages.Text_Editor.SQL_Script"
  - "VS.ToolsOptionsPages.Text_Editor.SQL_Script.General"
  - "VS.ToolsOptionsPages.Text_Editor.T-SQL"
  - "VS.ToolsOptionsPages.Text_Editor.T-SQL.General"
  - "VS.ToolsOptionsPages.Text_Editor.T-SQL7.General"
  - "VS.ToolsOptionsPages.Text_Editor.T-SQL80"
  - "VS.ToolsOptionsPages.Text_Editor.T-SQL80.General"
helpviewer_keywords:
  - "Text Editor Options dialog box"
  - "Code Editor"
  - "Text Editor [Visual Studio]"
  - "editors, global settings"
ms.assetid: 4ac21e48-3243-4141-9058-7eaf12b3cde7
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Options dialog box: Text Editor \> General

This dialog box lets you change global settings for the Visual Studio code and text editor. To display this dialog box, select **Options** on the **Tools** menu, expand the **Text Editor** folder, and then select **General**.

## Settings

### Drag and drop text editing

When selected, enables you to move text by selecting it and dragging it with the mouse to another location within the current document or any other open document.

### Automatic delimiter highlighting

When selected, delimiter characters that separate parameters or item-value pairs, as well as matching braces, are highlighted.

### Track changes

When the code editor is selected, a vertical yellow line appears in the selection margin to mark code that has changed since the file was most recently saved. When you save the changes, the vertical lines become green.

### Auto-detect UTF-8 encoding without signature

By default, the editor detects encoding by searching for byte order marks or charset tags. If neither is found in the current document, the code editor tries to autodetect UTF-8 encoding by scanning byte sequences. To disable the autodetection of encoding, clear this option.

### Follow project coding conventions

When selected, the project's specified coding conventions override any coding conventions you use on your personal projects.

### Enable mouse-click to perform Go to Definition

When selected, you can press **Ctrl** and hover over an element while clicking the mouse. Doing so takes you to the definition of the selected element. You can also choose either **Alt** or **Ctrl** + **Alt** from the **Use modifier key** drop-down.

Select the **Open definition in peek view** check box to display the element's definition in a window without navigating away from your current location in the code editor.

## Display

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

## See also

- [Options, Text Editor, All Languages](../../ide/reference/options-text-editor-all-languages.md)
- [Options, Text Editor, All Languages, Tabs](../../ide/reference/options-text-editor-all-languages-tabs.md)
- [Options, Text Editor, File Extension](../../ide/reference/options-text-editor-file-extension.md)
- [Identifying and Customizing Keyboard Shortcuts](../../ide/identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md)
- [Customizing the Editor](../how-to-change-text-case-in-the-editor.md)
- [Using IntelliSense](../../ide/using-intellisense.md)