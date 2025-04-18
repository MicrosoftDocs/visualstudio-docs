---
title: Options, Text Editor, C/C++, View
description: Learn how to use the View page in the C/C++ section to change the default behavior of Code Squiggles, Inactive Code, Outlining, and more within Visual Studio.
ms.date: 10/08/2021
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.C/C++.View"
  - "VS.ToolsOptionsPages.Text_Editor.C%2FC%2B%2B.View"
  - "VS.ToolsOptionsPages.Text_Editor.C\\C++.View"
ms.custom: "ide-ref"
author: tylermsft
ms.author: twhitney
manager: markl
---
# Options, Text Editor, C/C++, View

Use these property pages to change the default behavior of the code editor when you are programming in C or C++.

To access this property page, choose **Tools** > **Options** and expand **Text Editor**, then **C/C++**, and then choose **View**.

## Code Squiggles

You can enable or disable the following settings to manage the way in which text editor handles code squiggles for C and C++:

- **Macros in Skipped Browsing Regions** - Defines how to highlight macros that are inside skipped regions by the browsing database, such as macros whose definitions include braces.

- **Macros Convertible to constexpr** - Defines how to highlight macro definitions that can be converted to `constexpr` definitions.

## Inactive Code

- **Show Inactive Blocks** - Preprocessor inactive blocks are colorized differently.

- **Disable Inactive Code Opacity** - A solid color, instead of opacity, is used for inactive code blocks.

- **Inactive Code Opacity Percent** - The percentage of opacity for inactive code blocks.

## IntelliSense Error Fix Suggestions

- **Enable IntelliSense Error Fix Suggestions** - Enable suggested fixes for IntelliSense errors.

- **Max IntelliSense Error Fix Suggestions Threads** - The maximum number of concurrent threads to use for looking up IntelliSense error fix suggestions.

- **Max IntelliSense Error Fix Errors** - The maximum number of IntelliSense errors to lookup fixes for.

## Miscellaneous

- **Enumerate Comment Tasks** - Scan open source files for VS tokens and report them in the Task List window.

- **Highlight Matching Tokens** - Highlight enclosing braces or syntax that match where the cursor is positioned.

- **Color Scheme** - Various default color schemes for the C/C++ specific customizable colors.

## Outlining

- **Enable Outlining** - Enter outlining mode when a file opens.

- **Outline Pragma Regions** - Automatically outline `#pragma` region blocks.

- **Outline Statement Blocks** - Automatically outline statement blocks.

## See also

- [Setting Language-Specific Editor Options](../../ide/reference/setting-language-specific-editor-options.md)
- [Refactoring in C++ (VC Blog)](https://devblogs.microsoft.com/cppblog/all-about-c-refactoring-in-visual-studio-2015-preview/)
