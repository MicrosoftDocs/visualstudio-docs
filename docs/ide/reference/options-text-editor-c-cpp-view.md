---
title: Options, Text Editor, C/C++, View
description: Learn how to use the View page in the C/C++ section to change the default behavior of Code Squiggles, Inactive Code, Outlining, and more within Visual Studio.
ms.date: 01/09/2026
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.C/C++.View"
  - "VS.ToolsOptionsPages.Text_Editor.C%2FC%2B%2B.View"
  - "VS.ToolsOptionsPages.Text_Editor.C\\C++.View"
ms.custom: "ide-ref"
author: tylermsft
ms.author: twhitney
manager: coxford
monikerRange: '>=vs-2022'
---
# Options, Text Editor, C/C++, View

:::moniker range="<=vs-2022"

Use these property pages to change the default behavior of the code editor when you're programming in C or C++.

You can access the settings by selecting **Tools** > **Options** from the Visual Studio menu bar and expanding the **Text Editor** > **C/C++** > **View** section. To modify a setting, use the dropdown list to select your preference (when available), or enter the preferred value.

:::moniker-end
:::moniker range="visualstudio"

The options under **Text Editor** > **C/C++** > **View** are moved to other locations in Visual Studio 2026:

| Visual Studio 2022 | Visual Studio 2026 |
|---|---|
| **Code Squiggles** | Languages > C/C++ > IntelliSense > Browsing & navigation > **[Choose how to highlight macros - skipped regions](../configure-languages-c-cpp-intellisense.md#highlight-macros-inside-skipped-regions)** and Refactoring > **[Choose how to highlight macros - constexpr definitions](../configure-languages-c-cpp-intellisense.md#highlight-macros-convert-constexpr)** |
| **Inactive Code** | Languages > C/C++ > Text Editor** > **[Inactive Code](../configure-languages-c-cpp-text-editor.md#inactive-code)** |
| **IntelliSense Error Fix Suggestions** | Languages > C/C++ > IntelliSense > **[Errors](../configure-languages-c-cpp-intellisense.md#errors)** |
| **Miscellaneous** | Languages > C/C++ > **[Text editor](../configure-languages-c-cpp-text-editor.md#general-options)** |
| **Outlining** | Languages > C/C++ > Text editor > **[Outlining](../configure-languages-c-cpp-text-editor.md#outlining)** |

:::moniker-end

:::moniker range="<=vs-2022"

## Code Squiggles

You can enable or disable the following settings to manage the way in which text editor handles code squiggles for C and C++:

- **Macros in Skipped Browsing Regions**: Defines how to highlight macros that are inside skipped regions by the browsing database, such as macros whose definitions include braces.

- **Macros Convertible to constexpr**: Defines how to highlight macro definitions that can be converted to `constexpr` definitions.

## Inactive Code

- **Show Inactive Blocks**: Preprocessor inactive blocks are colorized differently.

- **Disable Inactive Code Opacity**: A solid color, instead of opacity, is used for inactive code blocks.

- **Inactive Code Opacity Percent**: The percentage of opacity for inactive code blocks.

## IntelliSense Error Fix Suggestions

- **Enable IntelliSense Error Fix Suggestions**: Enable suggested fixes for IntelliSense errors.

- **Max IntelliSense Error Fix Suggestions Threads**: The maximum number of concurrent threads to use for looking up IntelliSense error fix suggestions.

- **Max IntelliSense Error Fix Errors**: The maximum number of IntelliSense errors to lookup fixes for.

## Miscellaneous

- **Enumerate Comment Tasks**: Scan open source files for Visual Studio tokens and report them in the Task List window.

- **Highlight Matching Tokens**: Highlight enclosing braces or syntax that match where the cursor is positioned.

- **Color Scheme**: Various default color schemes for the C/C++ specific customizable colors.

## Outlining

- **Enable Outlining**: Enter outlining mode when a file opens.

- **Outline Pragma Regions**: Automatically outline `#pragma` region blocks.

- **Outline Statement Blocks**: Automatically outline statement blocks.

## Related content

- [Setting language-specific editor options](/previous-versions/visualstudio/visual-studio-2017/ide/reference/setting-language-specific-editor-options)
- [Refactoring in C++ (Blog)](https://devblogs.microsoft.com/cppblog/all-about-c-refactoring-in-visual-studio-2015-preview/)

:::moniker-end
