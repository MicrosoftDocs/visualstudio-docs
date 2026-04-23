---
title: Configure code analysis and error list options for C and C++
description: Configure advanced language settings for C and C++ in the Tools Options pane. Change behavior for the text editor and error lists, and configure settings for code analysis.
ms.date: 01/15/2026
ms.topic: how-to
helpviewer_keywords:
  - "Languages Options, advanced"
ms.custom: "ide-ref"
author: GitHubber17
ms.author: twhitney
manager: coxford
monikerRange: 'visualstudio'
---
# Configure C/C++ code analysis and error list options

This article describes how to configure several advanced language settings for C and C++. You can access the settings by selecting **Tools** > **Options** from the Visual Studio menu bar and expanding the **All Settings** > **Languages** > **C/C++** section.

These options let you define the behavior for code analysis, error lists, and programming C and C++ in the text editor.

## Code analysis

Options to support C and C++ code analysis are available in the **C/C++** > **Code analysis** section.

> [!NOTE]
> Earlier versions of Visual Studio provide **Code Analysis** options under the **Text Editor** > **C/C++** > **Advanced** section.

- **Run C++ code analysis in the background when files are opened or saved**: When selected (default), Visual Studio runs C++ code analysis in the background when you open or save a file.

- **Show code analysis warnings in the editor**: When selected (default), Visual Studio shows squiggles for C++ code analysis warnings in the editor. Changing this setting affects new windows, not windows that are currently open.

- **Enable diagnostic logging for C++ background code analysis**: When selected, Visual Studio provides diagnostic logging during C++ background code analysis. By default, this option isn't selected.

## Error list

The following option supports the visibility of problem details. It's available in the **C/C++** > **Error list** section.

- **Show the problem details window, if available, when navigating from the error list**: When selected (default), if you select (typically via double-click) an Error List item with structured diagnostic information, Visual Studio opens the **Problem Details** window. The window opens automatically as you navigate to the location of the error in the file. For more information, see [Structured diagnostics in the new Problem Details window](https://devblogs.microsoft.com/cppblog/structured-diagnostics-in-the-new-problem-details-window/).

## Related content

- [Setting language-specific editor options](/previous-versions/visualstudio/visual-studio-2017/ide/reference/setting-language-specific-editor-options)
