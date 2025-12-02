---
title: Customize language options in the Text Editor
description: Learn how to configure the General page in the All Languages section to customize the default behavior of the Code Editor in Visual Studio.
ms.date: 12/01/2025
ms.topic: how-to
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
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide

#customer intent: As a Visual Studio user, I want to configure Text Editor options for all languages so that I can customize code editing behavior consistently across all programming languages.
---
# Customize language options in the Text Editor

This article shows you how to configure the default behavior of the Code Editor for all programming languages in Visual Studio. These settings apply to the Code Editor and other editors based on it, such as the HTML Designer's Source view. You can customize statement completion, word wrap, line numbers, and other editor behaviors.

> [!CAUTION]
> This page sets default options for all development languages. Changes you make here will reset the General options in all languages. To change Text Editor options for just one language, expand the subfolder for that language and select its option pages.

:::image type="content" source="media/tools-options-text-editor-all-languages-general.png" alt-text="Screenshot of the Options dialog box that shows the General settings for all programming languages in the text editor.":::

## Access the Text Editor options

To configure Text Editor options for all languages:

1. In Visual Studio, select **Tools** > **Options**.
1. Expand **Text Editor**.
1. Expand **All Languages**.
1. Select **General**.

> [!NOTE]
> A grayed checkmark indicates that an option has been selected for some programming languages, but not for others.

## Configure statement completion

Use these options to control how IntelliSense and statement completion behave in the editor.

### Auto list members

When selected, pop-up lists of available members, properties, values, or methods are displayed by IntelliSense as you type in the editor. Choose any item from the pop-up list to insert the item into your code. Selecting this option enables the **Hide advanced members** option.

### Hide advanced members

When selected, shortens pop-up statement completion lists by displaying only those items most commonly used. Other items are filtered from the list.

### Parameter information

When selected, the complete syntax for the current declaration or procedure is displayed under the insertion point in the editor, with all of its available parameters. The next parameter you can assign is displayed in bold.

## Configure editor display options

Use these options to control how the editor displays text and formatting.

### Enable virtual space

When this option is selected and **Word wrap** is cleared, you can click anywhere beyond the end of a line in the Code Editor and type. This feature can be used to position comments at a consistent point next to your code.

### Word wrap

When selected, any portion of a line that extends horizontally beyond the viewable editor area is automatically displayed on the next line. Selecting this option enables the **Show visual glyphs for word wrap** option.

> [!NOTE]
> The **Virtual Space** feature is turned off while **Word Wrap** is on.

### Show visual glyphs for word wrap

When selected, a return-arrow indicator is displayed where a long line wraps onto a second line.

![LineBreakSymbol screenshot](../ide/media/linebreak.gif)

Clear this option if you prefer not to display these indicators.

> [!NOTE]
> These reminder arrows are not added to your code, and do not print. They are for reference only.

### Line numbers

When selected, a line number appears next to each line of code.

> [!NOTE]
> These line numbers are not added to your code, and do not print. They are for reference only.

## Configure navigation and interaction options

Use these options to control how you navigate and interact with code in the editor.

### Enable single-click URL navigation

When selected, the mouse cursor changes to a pointing hand as it passes over a URL in the editor. You can click the URL to display the indicated page in your web browser.

### Navigation bar

When selected, displays the **Navigation bar** at the top of the code editor. Its dropdown **Objects** and **Members** lists allow you to choose a particular object in your code, select from its members, and navigates to the declaration of the selected member in the Code Editor.

## Configure editing behavior options

Use these options to control additional editing behaviors.

### Automatic brace completion

When selected, Visual Studio provides a closing parenthesis when an open parenthesis is typed.

### Apply Cut or Copy commands to blank lines when there is no selection

This option sets the behavior of the editor when you place the insertion point on a blank line, select nothing, and then Copy or Cut.

- When this option is selected, the blank line is copied or cut. If you then Paste, a new, blank line is inserted.

- When this option is cleared, the Cut command removes blank lines. However, the data on the Clipboard is preserved. Therefore, if you then use the Paste command, the content most recently copied onto the Clipboard is pasted. If nothing has been copied previously, nothing is pasted.

This setting has no effect on Copy or Cut when a line isn't blank. If nothing is selected, the entire line is copied or cut. If you then Paste, the text of the entire line and its endline character are pasted.

> [!TIP]
> To display indicators for spaces, tabs, and line ends, and thus distinguish indented lines from lines that are entirely blank, select **Advanced** from the **Edit** menu and choose **View White Space**.

## Related content

- [Configure Text Editor tab options for all languages](options-text-editor-all-languages-tabs.md)
- [Configure environment options](reference/general-environment-options-dialog-box.md)
- [Use IntelliSense](using-intellisense.md)