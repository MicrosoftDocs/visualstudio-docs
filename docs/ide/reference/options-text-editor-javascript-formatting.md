---
title: Options, Text Editor, JavaScript, Formatting
description: Learn how to use the Formatting page of the Options dialog box to set options for formatting code in the Code Editor. 
ms.date: 10/29/2018
ms.subservice: javascript-typescript
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.JavaScript.Formatting.Spacing"
  - "VS.ToolsOptionsPages.Text_Editor.JavaScript.Formatting.General"
  - "VS.ToolsOptionsPages.Text_Editor.JavaScript.Formatting.New_Lines"
  - "VS.ToolsOptionsPages.Text_Editor.TypeScript.Formatting.Spacing"
  - "VS.ToolsOptionsPages.Text_Editor.TypeScript.Formatting.General"
  - "VS.ToolsOptionsPages.Text_Editor.TypeScript.Formatting.New_Lines"
ms.custom: "ide-ref"
author:mikejo5000
ms.author: mikejo
manager: mijacobs
---
# Options dialog box: Text Editor \> JavaScript \> Formatting

Use the **Formatting** page of the **Options** dialog box to set options for formatting code in the Code Editor. To access this page, on the menu bar, choose **Tools** > **Options**, and then expand **Text Editor** > **JavaScript/TypeScript** > **Formatting**.

[!INCLUDE[note_settings_general](../../data-tools/includes/note_settings_general_md.md)]

## Automatic Formatting

These options determine when formatting occurs in **Source** view.

### UIElement List

|Option|Description|
|------------|-----------------|
|**Format completed line on Enter**|When this option is selected, the Code Editor automatically formats the line when you choose the Enter key.|
|**Format completed statement on ;**|When this option is selected, the Code Editor automatically formats the line when you choose the semicolon key.|
|**Format opened block on {**|When this option is selected, the Code Editor automatically formats the line when you choose the opening brace key.|
|**Format completed block on }**|When this option is selected, the Code Editor automatically formats the line when you choose the closing brace key.|
|**Format on paste**|When this option is selected, the Code Editor reformats code when you paste it into the editor. The editor uses the currently defined formatting rules. If this option is not selected, the editor uses the original formatting of the pasted-in code.|

## New Lines

These options determine whether the Code Editor puts an open brace for functions and control blocks on a new line.

### UIElement list

|Option|Description|
|------------|-----------------|
|**Place open brace on new line for functions**|When this option is selected, the Code Editor moves the open brace associated with a function to a new line.|
|**Place open brace on new line for control blocks**|When this option is selected, the Code Editor moves the open brace associated with a control block (for example, `if` and `while` control blocks) to a new line.|

## Spacing

These options determine how spaces are inserted in **Source** view.

### UIElement list

|Option|Description|
|------------|-----------------|
|**Insert space after comma delimiter**|When this option is selected, the Code Editor adds a space after comma delimiters.|
|**Insert space after semicolon in 'for' statements**|When this option is selected, the Code Editor adds a space after each semicolon in the first line of a `for` loop.|
|**Insert space before and after binary operators**|When this option is selected, the Code Editor adds a space before and after binary operators (for example, +, -, &&, &#124;&#124;).|
|**Insert space after keywords in control flow statements**|When this option is selected, the Code Editor adds a space after JavaScript keywords in control flow statements.|
|**Insert space after function keyword for anonymous functions**|When this option is selected, the Code Editor adds a space after the `function` keyword for anonymous functions.|
|**Insert space after opening and before closing non-empty parenthesis**|When this option is selected, the Code Editor adds a space after the opening parenthesis and before the closing parenthesis if non-empty characters are present within the parentheses.|

## See also

- [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)