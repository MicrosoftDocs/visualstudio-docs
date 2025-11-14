---
title: Configure indent and tab settings
description: Learn how to use the Tabs page in the All Languages section to change the default behavior of the code editor tabs within Visual Studio.
ms.date: 11/14/2025
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
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Configure indent and tab settings in Visual Studio

Learn how to change the default tab and indentation behavior for the Code Editor in Visual Studio by using the text editor configuration options.

## Access options for indents and tabs

:::moniker range="visualstudio"

In Visual Studio, open the **Tools** > **Options** pane, and expand the **All Settings** > **Languages** > **Defaults** > **Tabs** section.

:::moniker-end
:::moniker range="<=vs-2022"

In Visual Studio, open the **Tools** > **Options** dialog, and expand the **Text Editor** > **All Languages** > **Tabs** section.

:::moniker-end

> [!CAUTION]
> Changes made here apply to all development languages. Resetting options in this dialog overrides individual language settings. To configure options for a specific language, select its subfolder under **Text Editor**.

## Resolve conflicting settings

If you select different tab or indent settings for individual languages, Visual Studio displays a warning message:
- "The indentation settings for individual text formats conflict with each other," for differing **Indenting** options.
- "The tab settings for individual text formats conflict with each other," for differing **Tab** options.

For example, if **Smart indenting** is set for Visual Basic and **Block indenting** for Visual C++, you receive a reminder about the conflict.

## Configure indenting options

For the **Indenting** option, choose one of the following indenting styles:

- **None**: New lines aren't indented; the cursor starts at the first column.
- **Block**: New lines are automatically indented to match the previous line.
- **Smart**: New lines are indented based on code context and IntelliSense conventions. Not available for all languages.

For example, lines between braces `{ }` might be indented an extra tab stop.

## Configure tab options

Configure the following tab options:

- **Tab size**: Sets the number of spaces per tab stop (default: 4).

- **Indent size**: Sets the number of spaces for each indentation (default: 4). Tabs, spaces, or both are used to fill the size.

:::moniker range="visualstudio"

- **Tab character**: Select the type of tab character to apply:

   - **Insert spaces**: Indent operations insert only space characters.
   - **Keep tabs**: Indent operations insert as many tab characters as possible; spaces fill any remainder.

:::moniker-end
:::moniker range="<=vs-2022"

- **Insert spaces**: Indent operations insert only space characters.

- **Keep tabs**: Indent operations insert as many tab characters as possible; spaces fill any remainder.

:::moniker-end

## Troubleshooting

> [!TIP]
> Adaptive formatting might override your custom tab settings. To disable adaptive formatting, go to **Text Editor** > **Advanced** and toggle **Use adaptive formatting**. You can also use an [.editorconfig](../ide/create-portable-custom-editor-options.md) file to manage indent styles.

## Next steps

- [Options, Text Editor, All Languages](../ide/reference/options-text-editor-all-languages.md)
- [General, Environment, Options Dialog Box](../ide/reference/general-environment-options-dialog-box.md)