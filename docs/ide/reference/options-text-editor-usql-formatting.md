---
title: U-SQL editor formatting options
description: Learn how to use the Formatting options page and its subpages to set options for formatting code in the code editor when you are programming in U-SQL.
ms.date: 01/17/2019
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.U-SQL.Formatting.Spacing
- VS.ToolsOptionsPages.Text_Editor.U-SQL.Formatting.NewLines
- VS.ToolsOptionsPages.Text_Editor.U-SQL.Formatting.Indentation
- VS.ToolsOptionsPages.Text_Editor.U-SQL.Formatting
- VS.ToolsOptionsPages.Text_Editor.U-SQL.Formatting.General
ms.custom: "ide-ref"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
monikerRange: vs-2019
---
# Options, Text Editor, U-SQL, Formatting

Use the **Formatting** options page to set options for formatting code in the code editor. To access this options page, choose **Tools** > **Options**. In the **Options** dialog box, choose **Text Editor** > **U-SQL** > **Formatting**.

## General page

### General settings

These settings affect *when* the code editor applies formatting options to code.

- **Automatically format completed statement on entering semicolon**

   When selected, formats statements when you choose the semicolon key according to the formatting options selected for the editor.

- **Automatically format on paste**

   When selected, formats text that is pasted into the editor to fit the formatting options selected for the editor.

## Preview windows

The **Indentation**, **New Lines**, and **Spacing** subpages each display a preview window at the bottom. The preview window shows the effect of each option. To use the preview window, select a formatting option. The preview window shows an example of the selected option. When you change a setting by selecting a check box, the preview window updates to show the effect of the new setting.

### Indentation remarks

Indentation options on the **Tabs** pages for each language only determine where the code editor places the cursor when you press **Enter** at the end of a line. Indentation options under **Formatting** apply when code is formatted automatically, for example:

- When you paste code into the file while **Automatically format on paste** is selected
- When the block being formatted is typed manually

## See also

- [General, Environment, Options dialog box](../../ide/reference/general-environment-options-dialog-box.md)
