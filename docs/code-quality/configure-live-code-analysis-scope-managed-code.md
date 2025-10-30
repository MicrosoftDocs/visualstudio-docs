---
title: Configure live code analysis scope for .NET
description: Learn about background live code analysis in Visual Studio. See how to set the analysis scope to the active document, all open documents, or all files and projects.
author: mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: code-analysis
ms.topic: how-to
helpviewer_keywords:
  - "live code analysis"
  - "background analysis"
  - "analysis scope"
  - "full solution analysis"
ms.date: 03/26/2024
---

# Configure live code analysis for .NET

Visual Studio analyzes code in several ways while you're editing source files in the editor. This analysis is referred to as *background analysis*. These analyses can be categorized as follows, based on functionality:

- **Background computation of diagnostics:** This type of analysis computes errors, warnings, and suggestions in source files. These diagnostics appear as entries in the **Error List** window and are marked with squiggle lines in the code editor. They can be classified into the following categories:
  - C# and Visual Basic compiler diagnostics
  - Roslyn analyzer diagnostics, which includes:
    - Built-in IDE analyzers for code-style suggestions
    - Built-in CA analyzers for code-quality suggestions
    - [External analyzer packages](./install-roslyn-analyzers.md) that are installed for projects in the current solution

- **Other background analyses:** This type of analysis improves the responsiveness and Visual Studio interaction for IDE features. Example analyses include:
  - Background parsing of open files
  - Background compilation of projects with open files to realize symbols for improved responsiveness of IDE features
  - Building syntax and symbol caches
  - Detecting designer association for source files, such as forms and controls

## Default analysis scope

By default, compiler diagnostics run on all open documents. In Visual Studio 2022 and later, Roslyn analyzer diagnostics run on the currently active document only. The *other background analyses* execute for all projects that have at least one open file. Some background analyses execute for the entire solution.

## Custom analysis scope

The default scope of each background analysis is tuned for the optimal user experience, functionality, and performance for most customer scenarios and solutions. However, there are cases where customers might want to customize this scope to decrease or increase the background analysis. For example:

- Power save mode

   If you're running on laptop battery, you might want to minimize the power consumption for longer battery life. In this scenario, you want to minimize the background analysis.

- On-demand code analysis

   If you prefer to turn off live analyzer execution and run code analysis manually when required, you need to minimize background analysis. For more information, see [Run code analysis manually for .NET](./how-to-run-code-analysis-manually-for-managed-code.md).

- Full solution analysis

   If you want to see all diagnostics in all files in the solution, regardless of whether they're open in the editor, you can maximize the background analysis scope to the entire solution.

Starting in Visual Studio 2019, you can explicitly customize the scope of all live code analysis, including diagnostics computation, for C# and Visual Basic projects. The available analysis scopes are:

::: moniker range=">=vs-2022"

| Scope | Description |
| - | - |
| **None** | All analyzers and corresponding code fixes are disabled.<br/><br/>Compiler diagnostics and corresponding code fixes are enabled on *all open* documents. |
| **Current document** (default) | All analyzers run on the currently active document only.<br/><br/>Compiler diagnostics are enabled on *all open* documents. |
| **Open documents** | All analyzers and compiler diagnostics are enabled on *all open* documents. |
| **Entire solution** | All analyzers and compiler diagnostics are enabled on *all* documents in the solution, whether open or closed. |

::: moniker-end

::: moniker range="<=vs-2019"

- **Current document:** Minimizes the live code analysis scope to execute only for the current or visible file in the editor.
- **Open documents:** The live code analysis scope includes all open documents. This setting is the default.
- **Entire solution:** Maximizes the live code analysis scope to execute for all files and projects in the entire solution.

::: moniker-end

You can choose one of the custom analysis scopes in **Options** by following these steps:

1. To open the **Options** dialog box, on the menu bar in Visual Studio choose **Tools** > **Options**.

1. In the **Options** dialog box, choose **Text Editor** > **C#** (or **Visual Basic**) > **Advanced**.

::: moniker range=">=vs-2022"

1. Select the background analysis scope from the **Run background code analysis for:** dropdown list to customize the analysis scope. Choose **OK** when you're done.

   :::image type="content" source="media/background-analysis-scope.png" alt-text="Screenshot that shows the background code analysis scope options in Visual Studio.":::

::: moniker-end

::: moniker range="<=vs-2019"

1. Select the background analysis scope under **Background analysis scope:**. Choose **OK** when you're done.

   :::image type="content" source="media/vs-2019/background-analysis-scope.png" alt-text="Screenshot that shows the background code analysis scope options in Visual Studio.":::

::: moniker-end

> [!NOTE]
> Prior to Visual Studio 2019, you customize the analysis scope for diagnostics computation to the entire solution by using the **Enable full solution analysis** checkbox from **Tools** > **Options** > **Text Editor** > **C#** (or **Visual Basic**) > **Advanced** tab. There is no support to minimize the background analysis scope in prior Visual Studio versions.

## Automatically minimize live code analysis scope

If Visual Studio detects that 200 MB or less of system memory is available, it automatically minimizes the live code analysis scope to **Current Document**. When this situation occurs, an alert appears informing you that Visual Studio is disabling some features. For more information, see [Automatic feature suspension](automatic-feature-suspension.md).

![Screenshot that shows the alert warning that Visual Studio is minimizing analysis scope.](./media/fsa_alert.png)

## Related content

- [Automatic feature suspension](./automatic-feature-suspension.md)
- [Power save mode feature request](https://github.com/dotnet/roslyn/issues/38429)
