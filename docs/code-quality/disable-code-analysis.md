---
title: Turn code analysis off
ms.date: 10/03/2019
ms.topic: conceptual
helpviewer_keywords:
  - "code analysis, disable"
  - "disable code analysis"
author: gewarren
ms.author: gewarren
manager: jillfra
---
# How to disable code analysis in Visual Studio

::: moniker range=">=vs-2019"

This page helps you disable code analysis in Visual Studio. The procedure for turning code analysis off completely differs depending on a few factors:

- Project type (.NET Core/Standard versus .NET Framework)

  .NET Core and .NET Standard projects have options on their Code Analysis properties page that let you turn off source code analysis for NuGet packages. For more information, see [.NET Core and .NET Standard projects](#net-core-and-net-standard-projects). To turn off source code analysis for .NET Framework projects, see [.NET Framework projects](#net-framework-projects).

- NuGet analyzer package versus VSIX or built-in analyzers

  You cannot disable live code analysis for the built-in analyzers, for example, rule ID IDE0067. Similarly, you cannot disable live code analysis for analyzers that were installed as part of a Visual Studio extension (VSIX). You can disable live and built-time analysis for analyzers installed as part of a NuGet package.

- Source analysis versus legacy analysis

  This topic applies to source code analysis and not to legacy (binary) analysis. For information about disabling legacy analysis, see [How to: Enable and disable legacy code analysis](how-to-enable-and-disable-automatic-code-analysis-for-managed-code.md).

## .NET Core and .NET Standard projects

Starting in Visual Studio 2019 version 16.3, there are two checkboxes available in the Code Analysis properties page that let you control whether NuGet-based analzyers run at build time and design time. These options are project specific.

![Enable or disable live code analysis or on build in Visual Studio](media/run-on-build-run-live-analysis.png)

To open this page, right-click on the project node in **Solution Explorer** and select **Properties**. Select the **Code Analysis** tab.

- To disable source analysis at build time, uncheck the **Run on build** option.
- To disable live source analysis, uncheck the **Run on live analysis** option.

> [!NOTE]
> Built-in and VSIX-based analyzers will continue to provide live analysis of your code, even if **Run on live analysis** is unchecked. If you want to suppress errors and warnings from these analyzers, choose **Analyze** > **Build and Suppress Active Issues** on the menu bar.

## .NET Framework projects

To turn off source code analysis for analyzers installed as part of a NuGet package, add one or more of the following MSBuild properties to the [project file](../ide/solutions-and-projects-in-visual-studio.md#project-file).

| MSBuild property | Description | Default value | Example |
| - | - | - | - |
| RunAnalyzersDuringBuild | Controls whether NuGet-based analyzers run at build time. | `true` | `<RunAnalyzersDuringBuild>false</RunAnalyzersDuringBuild>` |
| RunAnalyzersDuringLiveAnalysis | Controls whether NuGet-based analyzers analyze code live at design time. | `true` | `<RunAnalyzersDuringLiveAnalysis>false</RunAnalyzersDuringLiveAnalysis>` |
| RunAnalyzers | Setting it to `false` overrides the other two properties, and disables analyzers during both build and live analysis. | `true` | `<RunAnalyzers>false</RunAnalyzers>`|

::: moniker-end

::: moniker range="vs-2017"

- You cannot turn [source analysis](roslyn-analyzers-overview.md) off in Visual Studio 2017. If you want to clear analyzer errors from the Error List, you can suppress all the current violations by choosing **Analyze** > **Run Code Analysis and Suppress Active Issues** on the menu bar. For more information, see [Suppress violations](use-roslyn-analyzers.md#suppress-violations).

  Starting in Visual Studio 2019 version 16.3, you can turn NuGet-based source code analysis off. Consider upgrading to Visual Studio 2019.

- You can disable legacy analysis on the **Code Analysis** properties page. For more information, see [How to: Enable and disable legacy code analysis](how-to-enable-and-disable-automatic-code-analysis-for-managed-code.md).

::: moniker-end

## See also

- [Suppress violations](use-roslyn-analyzers.md#suppress-violations)
- [How to: Enable and disable legacy code analysis](how-to-enable-and-disable-automatic-code-analysis-for-managed-code.md)
