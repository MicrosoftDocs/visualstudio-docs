---
title: "Options, Text Editor, General | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "VS.TOOLSOPTIONSPAGES.TEXT_EDITOR.SQL_SERVER_TOOLS.GENERAL"
  - "VS.ToolsOptionsPages.Text_Editor.All_Languages.General"
  - "VS.ToolsOptionsPages.Text_Editor.RDL_Expression.General"
  - "VS.ToolsOptionsPages.Text_Editor.SQL.General"
  - "vs.toolsoptionspages.text_editor"
  - "VS.ToolsOptionsPages.Text_Editor.XML.General"
  - "VS.ToolsOptionsPages.Text_Editor.T-SQL80.General"
  - "VS.ToolsOptionsPages.Text_Editor.CSS"
  - "VS.ToolsOptionsPages.Text_Editor.Plain_Text.General"
  - "VS.ToolsOptionsPages.Text_Editor.Visual_JSharp.General"
  - "VS.ToolsOptionsPages.Text_Editor.SQL_Script.General"
  - "VS.ToolsOptionsPages.Text_Editor.CSharp.General"
  - "VS.ToolsOptionsPages.Text_Editor.All_Languages"
  - "VS.ToolsOptionsPages.Text_Editor.T-SQL7.General"
  - "VS.ToolsOptionsPages.Text_Editor.Basic.General"
  - "VS.ToolsOptionsPages.Text_Editor.T-SQL.General"
  - "vs.toolsoptionspages.text_editor.visual_jsharp"
  - "VS.ToolsOptionsPages.Text_Editor.F#.Tabs"
  - "VS.ToolsOptionsPages.Text_Editor.F#"
  - "VS.ToolsOptionsPages.Text_Editor.PL/SQL.General"
  - "VS.ToolsOptionsPages.Text_Editor.C/C++.General"
  - "VS.ToolsOptionsPages.Text_Editor.Plain_Text"
  - "VS.ToolsOptionsPages.Text_Editor.HTML"
  - "VS.ToolsOptionsPages.Text_Editor.XAML.General"
  - "VS.ToolsOptionsPages.Text_Editor"
  - "VS.ToolsOptionsPages.Text_Editor.F#.General"
  - "VS.ToolsOptionsPages.Text_Editor.XOML.General"
  - "VS.ToolsOptionsPages.Text_Editor.SQL"
  - "vs.toolsoptionspages.text_editor.c/c++"
  - "VS.ToolsOptionsPages.Text_Editor.SQL_Script"
  - "VS.ToolsOptionsPages.Text_Editor.T-SQL90.General"
  - "VS.ToolsOptionsPages.Text_Editor.General"
  - "VS.ToolsOptionsPages.Text_Editor.CSharp"
helpviewer_keywords:
  - "Text Editor Options dialog box"
  - "Code Editor"
  - "Text Editor [Visual Studio]"
  - "editors, global settings"
ms.assetid: 4ac21e48-3243-4141-9058-7eaf12b3cde7
caps.latest.revision: 34
author: jillre
ms.author: jillfra
manager: jillfra
---
# Options, Text Editor, General
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

This dialog box lets you change global settings for the [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] Code and Text Editor. To display this dialog box, click **Options** on the **Tools** menu, expand the **Text Editor** folder, and then click **General**.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).

## Settings
 Drag and drop text editing
 When selected, enables you to move text by selecting it and dragging it with the mouse to another location within the current document or any other open document.

 Automatic delimiter highlighting
 When selected, delimiter characters that separate parameters or item-value pairs, as well as matching braces, are highlighted.

 Track changes
 When the code editor is selected, a vertical yellow line appears in the selection margin to mark code that has changed since the file was most recently saved. When you save the changes, the vertical lines become green.

 Auto-detect UTF-8 encoding without signature
 By default, the editor detects encoding by searching for byte order marks or charset tags. If neither is found in the current document, the code editor attempts to auto-detect UTF-8 encoding by scanning byte sequences. To disable the auto-detection of encoding, clear this option.

## Display
 Selection margin
 When selected, displays a vertical margin along the left edge of the editor's text area. You can click this margin to select an entire line of text, or click and drag to select consecutive lines of text.

|Selection Margin on|Selection Margin off|
|-------------------------|--------------------------|
|![HTMLpageSelectionMarginOn screenshot](../../ide/reference/media/vxselmaron.gif "vxSelmaron")|![HTMLpageSelectionMarginOff screenshot](../../ide/reference/media/vxselmaroff.gif "vxSelmaroff")|

 Indicator margin
 When selected, displays a vertical margin outside the left edge of the editor's text area. When you click in this margin, an icon and ToolTip that are related to the text appear. For example, breakpoint or task list shortcuts appear in the indicator margin. Indicator Margin information does not print.

 Vertical scroll bar
 When selected, displays a vertical scrollbar which allows you to scroll up and down to view elements that fall outside the viewing area of the Editor. If vertical scrollbars are not available, you can use the Page Up, Page Down and cursor keys to scroll.

 Horizontal scroll bar
 When selected, displays a horizontal scrollbar which allows you to scroll from side-to-side to view elements that fall outside the viewing area of the Editor. If horizontal scrollbars are unavailable, you can use the cursor keys to scroll.

 Highlight current line
 When selected, displays a gray box around the line of code in which the cursor is located.

## See Also
 [Options, Text Editor, All Languages](../../ide/reference/options-text-editor-all-languages.md)
 [Options, Text Editor, All Languages, Tabs](../../ide/reference/options-text-editor-all-languages-tabs.md)
 [Options, Text Editor, File Extension](../../ide/reference/options-text-editor-file-extension.md)
 [Identifying and Customizing Keyboard Shortcuts](../../ide/identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md)
 [Customizing the Editor](../../ide/customizing-the-editor.md)
 [Using IntelliSense](../../ide/using-intellisense.md)
