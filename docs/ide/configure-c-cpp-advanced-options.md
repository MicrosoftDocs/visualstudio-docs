---
title: Configure Advanced Language Options for C/C++
description: Configure advanced language settings for C/C++ in the Tools Options pane. Change brace completion and behavior in the text editor, configure settings for code analysis and error lists.
ms.date: 12/19/2025
ms.topic: how-to
f1_keywords:
  - "VS.ToolsOptionsPages.Languages.C\\C++.Advanced"
  - "VS.ToolsOptionsPages.Languages.C%2FC%2B%2B.Advanced"
  - "VS.ToolsOptionsPages.Languages.C/C++.Advanced"
helpviewer_keywords:
  - "Languages Options, advanced"
ms.custom: "ide-ref"
author: GitHubber17
ms.author: twhitney
manager: coxford
monikerRange: 'visualstudio'
---
# Configure Languages > C/C++ (Advanced options)

This article describes how to configure advanced language settings for C/C++. You can access the settings by selecting **Tools** > **Options** from the Visual Studio menu bar and expanding the **All Settings** > **Languages** > **C/C++** section.

These options let you define the behavior for brace completion, code analysis, error lists, and programming C/C++ in the text editor.

## Advanced options

The following options under **Text Editor** > **C/C++** > **Advanced** in earlier versions of Visual Studio are moved to other locations in Visual Studio 2026:

| Visual Studio 2022 | Visual Studio 2026 |
|---|---|
| **Browsing/Navigation** | **All Settings** > **Languages** > **C/C++** > **IntelliSense** > **[Browsing & navigation](configure-languages-c-cpp-intellisense.md#browsing-and-navigation)** |
| **Browsing Database Fallback** | **All Settings** > **Languages** > **C/C++** > **IntelliSense** > **Browsing & navigation** > **[Location](configure-languages-c-cpp-intellisense.md#location-for-the-browsing-database)** |
| **Diagnostic Logging** | **All Settings** > **Languages** > **C/C++** > **IntelliSense** > **[Diagnostic logging](configure-languages-c-cpp-intellisense.md#diagnostic-logging)** |
| **IntelliSense** | **All Settings** > **Languages** > **C/C++** > **[IntelliSense](configure-languages-c-cpp-intellisense.md#general-options)** |
| **IntelliSense and Browsing for Non-Project Files** | **All Settings** > **Languages** > **C/C++** > **IntelliSense** > **[Non-project files](configure-languages-c-cpp-intellisense.md#non-project-files)** |
| **References** | **All Settings** > **Languages** > **C/C++** > **IntelliSense** > **[References](configure-languages-c-cpp-intellisense.md#references)** |

## Brace completion

The **Brace completion** options are available in the **C/C++** > **Text Editor** section. 

> [!NOTE]
> Earlier versions of Visual Studio provide **Brace completion** options under the **Text Editor** > **C/C++** > **Advanced** section.

**Insert a semicolon after completing braces for types** 

When selected (default), Visual Studio automatically inserts a semicolon after the closing brace for a type definition.

**Complete parentheses in raw string literals**

When selected (default), if you type an open parenthesis in a raw string literal, Visual Studio automatically adds the closing parenthesis.

**Complete multiline comments**

When selected (default), Visual Studio automatically adds the completion syntax for multiline comments (comments that start with `/*`).

## Code analysis

Options to support C/C++ code analysis are available in the **C/C++** > **Code analysis** section.

> [!NOTE]
> Earlier versions of Visual Studio provide **Code Analysis** options under the **Text Editor** > **C/C++** > **Advanced** section.

**Run C++ code analysis in the background when files are opened or saved**

When selected (default), Visual Studio runs C++ code analysis in the background when you open or save a file.

**Show code analysis warnings in the editor**

When selected (default), Visual Studio shows squiggles for C++ code analysis warnings in the editor. If you modify the setting on this option and have open windows, the new setting affects only windows you open after the change.

**Enable diagnostic logging for C++ background code analysis**

When selected, Visual Studio supports diagnostic logging for C++ background code analysis. By default, this option isn't selected.

## Error list

The following option supports the visibility of problem details. It's available in the **C/C++** > **Error list** section.

> [!NOTE]
> Earlier versions of Visual Studio provide the **Error List** option under the **Text Editor** > **C/C++** > **Advanced** section.

**Show the problem details window, if available, when navigating from the error list**

When selected (default), Visual Studio displays the **Problem Details** window when you double-click an issue to view associated details. The window is visible as you navigate from the Error List window to the location of the issue in your source code.

## Text editor

The following options are available in the **C/C++** > **Text editor** section. 

> [!NOTE]
> Earlier versions of Visual Studio provide **Text Editor** options under the **Text Editor** > **C/C++** > **Advanced** section.

**Automatically surround selections when typing quotes or brackets**

Use this setting to control whether Visual Studio should automatically surround (enclose) your selections as you work in the editor. You can surround selections enclosed in brackets (square `[]`) or quotes (double `""` or single `''`), or all types.

For example, if you type an open quote or bracket, Visual Studio can automatically add the closing quote or bracket to enclose (surround) your selection. Choose from **Quotes only**, **Brackets Only**, **All** (default), or **Never**.

**Perform code formatting after surrounding the selection**

When selected (default), Visual Studio formats the code syntax within the enclosed section after it surrounds the selection.

**When surrounding the selection with a scope, expand to whole lines**

When selected (default), if you surround a selection within a scope, such as with parenthesis `()` or curly braces `{}`, the surround expands to contain the whole line.

## Related content

- [Setting language-specific editor options](/previous-versions/visualstudio/visual-studio-2017/ide/reference/setting-language-specific-editor-options)
