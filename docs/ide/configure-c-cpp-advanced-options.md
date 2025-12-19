---
title: Configure Advanced Language Options for C/C++
description: Configure advanced language settings for C/C++ in the Tools Options pane. Change behavior for the text editor and error lists, and configure settings for code analysis.
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

These options let you define the behavior for code analysis, error lists, and programming C/C++ in the text editor.

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

## Related content

- [Setting language-specific editor options](/previous-versions/visualstudio/visual-studio-2017/ide/reference/setting-language-specific-editor-options)
