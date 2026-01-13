---
title: Configure Text Editor Options for C and C++
description: Configure text editor language settings for C and C++ in the Tools Options pane. Change options for Inactive code, Brace completion, Outlining, and more.
ms.date: 01/13/2026
ms.topic: how-to
helpviewer_keywords:
  - "Languages Options, Text editor"
ms.custom: "ide-ref"
author: GitHubber17
ms.author: twhitney
manager: coxford
monikerRange: 'visualstudio'
---
# Configure Languages > C/C++ > Text editor options

This article describes how to modify text editor settings for C and C++. You can access the settings by selecting **Tools** > **Options** from the Visual Studio menu bar and expanding the **All Settings** > **Languages** > **C/C++** > **Text editor** section.

These options let you configure settings for inactive code, brace completion, outlining, and more for programming C and C++.

## General options

The following general options are available for the text editor.

- **Show comment tasks in the task list**: When selected (default), Visual Studio scans source files for tokens like `TODO`, `HACK`, and so on, and shows them in the **Task List** window. You can customize the list of scanned tokens in the **All Settings** > **Environment** > **Task List** section.

- **Highlight enclosing braces or syntax when the cursor touches one of the set**: When selected (default), Visual Studio highlights enclosing braces, parenthesis, and so on, and paired constructs like `#if` / `#endif`.

- **Color scheme for the C/C++ specific customizable colors**: Use this option to select the scheme to apply for C and C++ specific customizable colors. Choose from **Enhanced** (default), **Visual Studio 2017**, or **Enhanced (Globals vs. Members)**.

- **Automatically surround selections when typing quotes or brackets**: Use this setting to control whether Visual Studio should automatically surround (enclose) your selections as you work in the editor. You can surround selections enclosed in brackets (`[]`) and quotes (`""` or `''`).

   For example, if you type an open quote or bracket, Visual Studio can automatically add the closing quote or bracket to enclose (surround) your selection. Choose from **Quotes only**, **Brackets Only**, **All** (default), or **Never**.

- **Perform code formatting after surrounding the selection**: When selected (default), Visual Studio formats the code syntax within the enclosed section after it surrounds the selection.

- **When surrounding the selection with a scope, expand to whole lines**: When enabled, if you surround a selection that appears within a brace scope `{ ... }`, the surround expands to the whole line. The default is **True**.

   If your selection doesn't start and end on complete lines, Visual Studio automatically expands the selection to whole lines before inserting `{ ... }`. This approach avoids wrapping partial lines within the braces.

## Inactive code

The following options are available in the **C/C++** > **Text editor** > **Inactive code** section.

- **Colorize inactive preprocessor blocks differently**: When selected (default), Visual Studio colorizes inactive preprocessor blocks differently than active blocks. <!-- VS 22 = Show Inactive Blocks -->

- **Use opacity percentage for inactive code blocks**: When selected (default), Visual Studio uses a shaded color for inactive code blocks based on the **Inactive code opacity percent** value. When the **Colorize inactive preprocessor blocks differently** is cleared, this option isn't available. <!-- VS 22 = Disable Inactive Code Opacity -->

- **Inactive code opacity percent**: Use this option to set the percentage of opacity for inactive code blocks. Specify a value between 1 and 100. The default is 55.

- **Colorize the matching start and end preprocessor tokens**: When selected (default), Visual Studio also colorizes the matching start and end preprocessor tokens. 

   To use this feature, the **Enable brace pair colorization** option must be enabled under the **All Settings** > **Text Editor** > **General** > **Display** section.

## Outlining

The outlining feature collapses and expands blocks of code so you can hide details and focus on structure. Visual Studio automatically detects code blocks (functions, classes, namespaces, loops, regions) and lets you collapse them into a single line by selecting the **+** / **–** icon.

The following options are available in the **C/C++** > **Text editor** > **Outlining** section.

- **Enable Outlining**: When selected (default), Visual Studio automatically enters outlining mode when a file opens.

- **Enable automatic outlining of #pragma region blocks**: When selected (default), Visual Studio automatically outlines `#pragma` region blocks.

- **Enable automatic outlining of statement blocks**: When selected (default), Visual Studio automatically outlines statement blocks.

## Brace completion

The following options are available in the **C/C++** > **Text editor** > **Brace completion** section. 

- **Insert a semicolon after completing braces for types**: When selected (default), Visual Studio automatically inserts a semicolon (`;`) after the closing brace for a type definition.

- **Complete parentheses in raw string literals**: When selected (default), if you type an open parenthesis `(` in a raw string literal, Visual Studio automatically adds the closing parenthesis `)`.

   For example, if you type `auto json = R"json("`, the editor automatically adds the closing parenthesis `)`. Notice the editor doesn't add the delimiter sequence to the end of the closing parenthesis. That is, if you type `auto json = R"json(...`, the editor adds `)` to the end but not `)json`. You have to type the delimiter sequence yourself at the end.

- **Complete multiline comments**: When selected (default), Visual Studio automatically adds the closing syntax `*/` for multiline comments (comments that start with `/*`).

## Related content

- [Setting language-specific editor options](/previous-versions/visualstudio/visual-studio-2017/ide/reference/setting-language-specific-editor-options)
