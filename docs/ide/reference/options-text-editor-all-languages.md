---
title: Options, Text Editor, All Languages
description: Learn how to use the General page in the All Languages section to change the default behavior of the Code Editor within Visual Studio.
ms.date: 09/01/2022
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.JavaScript.General
- VS.ToolsOptionsPages.Text_Editor.ResJSON.General
- VS.ToolsOptionsPages.Text_Editor.All_Languages.General
- VS.ToolsOptionsPages.Text_Editor.Basic.General
- VS.ToolsOptionsPages.Text_Editor.CSharp.General
- VS.ToolsOptionsPages.Text_Editor.C/C++.General
- VS.ToolsOptionsPages.Text_Editor.CoffeeScript.General
- VS.ToolsOptionsPages.Text_Editor.CSS.General
- VS.ToolsOptionsPages.Text_Editor.Dockerfile.General
- VS.ToolsOptionsPages.Text_Editor.F#.General
- VS.ToolsOptionsPages.Text_Editor.Fsharp.General
- VS.ToolsOptionsPages.Text_Editor.HQL.General
- VS.ToolsOptionsPages.Text_Editor.HTML.General
- VS.ToolsOptionsPages.Text_Editor.HTML_(Web_Forms).General
- VS.ToolsOptionsPages.Text_Editor.JavaScript.General
- VS.ToolsOptionsPages.Text_Editor.JSON.General
- VS.ToolsOptionsPages.Text_Editor.LESS.General
- VS.ToolsOptionsPages.Text_Editor.Plain_Text.General
- VS.ToolsOptionsPages.Text_Editor.SCSS.General
- VS.TOOLSOPTIONSPAGES.TEXT_EDITOR.SQL_SERVER_TOOLS.GENERAL
- VS.ToolsOptionsPages.Text_Editor.StreamAnalytics.General
- VS.ToolsOptionsPages.Text_Editor.T-SQL90.General
- VS.ToolsOptionsPages.Text_Editor.U-SQL.General
- VS.ToolsOptionsPages.Text_Editor.XAML.General
- VS.ToolsOptionsPages.Text_Editor.XML.General
helpviewer_keywords:
- Text Editor Options dialog box
- statement completion
- word wrap
- General dialog box
- line numbers
- virtual space
ms.custom: "ide-ref"
author:anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Options dialog box: Text Editor \> All Languages

This dialog box allows you to change the default behavior of the Code Editor. These settings also apply to other editors based upon the Code Editor, such as the HTML Designer's Source view. To open this dialog box, select **Options** from the **Tools** menu. Within the **Text Editor** folder, expand the **All Languages** subfolder and then choose **General**.

> [!CAUTION]
> This page sets default options for all development languages. Remember that resetting an option in this dialog will reset the General options in all languages to whatever choices are selected here. To change Text Editor options for just one language, expand the subfolder for that language and select its option pages.

A grayed checkmark is displayed when an option has been selected on the General options pages for some programming languages, but not for others.

:::image type="content" source="media/tools-options-text-editor-all-languages-general.png" alt-text="Screenshot of the Options dialog box that shows the General settings for all programming languages in the text editor.":::

## Statement Completion

**Auto list members**

When selected, pop-up lists of available members, properties, values, or methods are displayed by IntelliSense as you type in the editor. Choose any item from the pop-up list to insert the item into your code. Selecting this option enables the **Hide advanced members** option.

**Hide advanced members**

When selected, shortens pop-up statement completion lists by displaying only those items most commonly used. Other items are filtered from the list.

**Parameter information**

When selected, the complete syntax for the current declaration or procedure is displayed under the insertion point in the editor, with all of its available parameters. The next parameter you can assign is displayed in bold.

## Settings

**Enable virtual space**

When this option is selected and **Word wrap** is cleared, you can click anywhere beyond the end of a line in the Code Editor and type. This feature can be used to position comments at a consistent point next to your code.

**Word wrap**

When selected, any portion of a line that extends horizontally beyond the viewable editor area is automatically displayed on the next line. Selecting this option enables the **Show visual glyphs for word wrap** option.

> [!NOTE]
> The **Virtual Space** feature is turned off while **Word Wrap** is on.

**Show visual glyphs for word wrap**

When selected, a return-arrow indicator is displayed where a long line wraps onto a second line.

![LineBreakSymbol screenshot](../../ide/reference/media/linebreak.gif)

Clear this option if you prefer not to display these indicators.

> [!NOTE]
> These reminder arrows are not added to your code, and do not print. They are for reference only.

**Line numbers**

When selected, a line number appears next to each line of code.

> [!NOTE]
> These line numbers are not added to your code, and do not print. They are for reference only.

**Enable single-click URL navigation**

When selected, the mouse cursor changes to a pointing hand as it passes over a URL in the editor. You can click the URL to display the indicated page in your web browser.

**Navigation bar**

When selected, displays the **Navigation bar** at the top of the code editor. Its dropdown **Objects** and **Members** lists allow you to choose a particular object in your code, select from its members, and navigates to the declaration of the selected member in the Code Editor.

**Automatic brace completion**

When selected, Visual Studio provides a closing parenthesis when an open parenthesis is typed.

**Apply Cut or Copy commands to blank lines when there is no selection**

This option sets the behavior of the editor when you place the insertion point on a blank line, select nothing, and then Copy or Cut.

- When this option is selected, the blank line is copied or cut. If you then Paste, a new, blank line is inserted.

- When this option is cleared, the Cut command removes blank lines. However, the data on the Clipboard is preserved. Therefore, if you then use the Paste command, the content most recently copied onto the Clipboard is pasted. If nothing has been copied previously, nothing is pasted.

This setting has no effect on Copy or Cut when a line isn't blank. If nothing is selected, the entire line is copied or cut. If you then Paste, the text of the entire line and its endline character are pasted.

> [!TIP]
> To display indicators for spaces, tabs, and line ends, and thus distinguish indented lines from lines that are entirely blank, select **Advanced** from the **Edit** menu and choose **View White Space**.

## See also

- [Options, Text Editor, All Languages, Tabs](../../ide/reference/options-text-editor-all-languages-tabs.md)
- [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)
- [Using IntelliSense](../../ide/using-intellisense.md)
