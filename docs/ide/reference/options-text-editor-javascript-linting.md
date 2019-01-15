---
title: Options, Text Editor, JavaScript, Linting
ms.date: 1/15/2019
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.JavaScript.Linting.General"
  - "VS.ToolsOptionsPages.Text_Editor.JavaScript.Linting"
  - "VS.ToolsOptionsPages.Text_Editor.TypeScript.Linting.General"
  - "VS.ToolsOptionsPages.Text_Editor.TypeScript.Linting"
ms.assetid: a952ed54-3b46-45cb-9f9c-561aa63f55c1
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Options, Text Editor, JavaScript, Linting
Use the **Linting** page of the **Options** dialog box to set options for analyzing code in the Code Editor. To access this page, on the menu bar, choose **Tools** > **Options**, and then expand **Text Editor** > **JavaScript** > **Linting**.

[!INCLUDE[note_settings_general](../../data-tools/includes/note_settings_general_md.md)]

## ESLint Settings
 These options let you enable static JavaScript code analysis and choose which files are analyzed. For more information about ESLint, see [ESLint.org](https://eslint.org/).

### UIElement List

|Option|Description|
|------------|-----------------|
|**Enable ESLint**|When this option is selected, the Code Editor allows for static analysis on the code.|
|**Lint all files included in project, even closed files**|When this option is selected, closed files are analyzed, unless diagnostics are only reported for open files.|

## Global ESLint Config Options
 This option lets you copy the location of the global ESLint configuration file. Also, if you previously changed the location, you can reset the file to its default location.

## See Also

- [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)