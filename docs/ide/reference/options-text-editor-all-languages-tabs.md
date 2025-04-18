---
title: Options, Text Editor, All Languages, Tabs
description: Learn how to use the Tabs page in the All Languages section to change the default behavior of the code editor tabs within Visual Studio.
ms.date: 09/29/2022
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.All_Languages.Tabs
- VS.ToolsOptionsPages.Text_Editor.Basic.Tabs
- VS.ToolsOptionsPages.Text_Editor.CSharp.Tabs
- VS.ToolsOptionsPages.Text_Editor.C%2FC%2B%2B.Tabs
- VS.ToolsOptionsPages.Text_Editor.CoffeeScript.Tabs
- VS.ToolsOptionsPages.Text_Editor.CSS.Tabs
- VS.ToolsOptionsPages.Text_Editor.Dockerfile.Tabs
- VS.ToolsOptionsPages.Text_Editor.F%2523.Tabs
- VS.ToolsOptionsPages.Text_Editor.HQL.Tabs
- VS.ToolsOptionsPages.Text_Editor.HTML.Tabs
- VS.ToolsOptionsPages.Text_Editor.HTMLX.Tabs
- VS.ToolsOptionsPages.Text_Editor.JavaScript.Tabs
- VS.ToolsOptionsPages.Text_Editor.TypeScript.Tabs
- VS.ToolsOptionsPages.Text_Editor.JSON.Tabs
- VS.ToolsOptionsPages.Text_Editor.LESS.Tabs
- VS.ToolsOptionsPages.Text_Editor.Plain_Text.Tabs
- VS.ToolsOptionsPages.Text_Editor.ResJSON.Tabs
- VS.ToolsOptionsPages.Text_Editor.SCSS.Tabs
- VS.ToolsOptionsPages.Text_Editor.SQL_Server_Tools.Tabs
- VS.ToolsOptionsPages.Text_Editor.StreamAnalytics.Tabs
- VS.ToolsOptionsPages.Text_Editor.T-SQL90.Tabs
- VS.ToolsOptionsPages.Text_Editor.U-SQL.Tabs
- VS.ToolsOptionsPages.Text_Editor.XAML.Tabs
- VS.ToolsOptionsPages.Text_Editor.XML.Tabs
helpviewer_keywords:
- indents, Code Editor
- Code Editor, default behavior
- tabs, setting in Code Editor
- All Languages Text Editor Options dialog box
- editors, Code Editor
- Code Editor, indenting
- Code Editor, tabs
ms.custom: "ide-ref"
author:anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Options, Text Editor, All Languages, Tabs

This dialog box allows you to change the default behavior of the Code Editor. These settings also apply to other editors based upon the Code Editor, such as the HTML Designer's Source view. To display these options, select **Options** from the **Tools** menu. Within the **Text Editor** folder expand the **All Languages** subfolder, and then choose **Tabs**.

> [!CAUTION]
> This page sets default options for all development languages. Remember that resetting an option in this dialog will reset the Tabs options in all languages to whatever choices are selected here. To change Text Editor options for just one language, expand the subfolder for that language and select its option pages.

If different settings are selected on the Tabs options pages for particular programming languages, then the message "The indentation settings for individual text formats conflict with each other," is displayed for differing **Indenting** options; and the message "The tab settings for individual text formats conflict with each other," is displayed for differing **Tab** options. For example, this reminder is displayed if the **Smart indenting** option is selected for Visual Basic, but **Block indenting** is selected for Visual C++.

## Indenting

None

When selected, new lines are not indented. The insertion point is placed in the first column of a new line.

Block

When selected, new lines are automatically indented. The insertion point is placed at the same starting point as the preceding line.

Smart

When selected, new lines are positioned to fit the code context, per other code formatting settings and IntelliSense conventions for your development language. This option is not available for all development languages.

For example, lines enclosed between an opening brace ( { ) and a closing brace ( } ) might automatically be indented an extra tab stop from the position of the aligned braces.

## Tabs

Tab size

Sets the distance in spaces between tab stops. The default is four spaces.

Indent size

Sets the size in spaces of an automatic indentation. The default is four spaces. Tab characters, space characters, or both will be inserted to fill the specified size.

Insert spaces

When selected, indent operations insert only space characters, not TAB characters. If the **Indent size** is set to 5, for example, then five space characters are inserted whenever you press the TAB key or the **Increase Indent** button on the **Formatting** toolbar.

Keep tabs

When selected, indent operations insert as many TAB characters as possible. Each TAB character fills the number of spaces specified in **Tab size**. If the **Indent size** is not an even multiple of the **Tab size**, space characters are added to fill in the difference.

> [!TIP]
> Adaptive formatting might override your custom tabs settings. You can turn off adaptive formatting by toggling the **[Use adaptive formatting](options-text-editor-advanced.md#use-adaptive-formatting)** option in **Text Editor** > **[Advanced](options-text-editor-advanced.md)**. You can also change how Visual Studio manages your preferred indent style by using an .*[editorconfig](../create-portable-custom-editor-options.md)* file.

## See also

- [Options, Text Editor, All Languages](../../ide/reference/options-text-editor-all-languages.md)
- [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)
