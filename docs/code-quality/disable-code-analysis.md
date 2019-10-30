---
title: Turn off code analysis
ms.date: 10/03/2019
ms.topic: conceptual
helpviewer_keywords:
  - "code analysis, disable"
  - "disable code analysis"
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to disable source code analysis for managed code

::: moniker range=">=vs-2019"

This page helps you disable code analysis in Visual Studio. There are limitations to what you can disable, and the procedure for turning off code analysis differs depending on a few factors:

- Project type (.NET Core/Standard versus .NET Framework)

  .NET Core and .NET Standard projects have options on their Code Analysis properties page that let you turn off code analysis from analyzers installed as a NuGet package. For more information, see [.NET Core and .NET Standard projects](#net-core-and-net-standard-projects). To turn off source code analysis for .NET Framework projects, see [.NET Framework projects](#net-framework-projects).

- NuGet analyzer package versus VSIX or built-in analyzers

  Currently, you cannot disable live code analysis for the built-in analyzers, for example, rule ID IDE0067. Similarly, you cannot disable live code analysis for analyzers that were installed as part of a Visual Studio extension (VSIX). To suppress errors and warnings from built-in and VSIX-based analyzers, choose **Analyze** > **Build and Suppress Active Issues** on the menu bar. You *can* disable live and built-time analysis for analyzers installed as part of a NuGet package.

- Source analysis versus legacy analysis

  This topic applies to source code analysis and not to legacy (binary) analysis. For information about disabling legacy analysis, see [How to: Enable and disable legacy code analysis](how-to-enable-and-disable-automatic-code-analysis-for-managed-code.md).

## .NET Core and .NET Standard projects

Starting in Visual Studio 2019 version 16.3, there are two checkboxes available in the Code Analysis properties page that let you control whether NuGet-based analyzers run at build time and design time. These options are project specific.

![Enable or disable live code analysis or on build in Visual Studio](media/run-on-build-run-live-analysis.png)

To open this page, right-click on the project node in **Solution Explorer** and select **Properties**. Select the **Code Analysis** tab.

- To disable source analysis at build time, uncheck the **Run on build** option.
- To disable live source analysis, uncheck the **Run on live analysis** option.

> [!NOTE]
> Built-in and VSIX-based analyzers will continue to provide live analysis of your code, even if **Run on live analysis** is unchecked. If you want to suppress errors and warnings from these analyzers, choose **Analyze** > **Build and Suppress Active Issues** on the menu bar.

## .NET Framework projects

To turn off source code analysis for analyzers installed as part of a NuGet package, add one or more of the following MSBuild properties to the [project file](../ide/solutions-and-projects-in-visual-studio.md#project-file).

| MSBuild property | Description | Default |
| - | - | - |
| `RunAnalyzersDuringBuild` | Controls whether NuGet-based analyzers run at build time. | `true` |
| `RunAnalyzersDuringLiveAnalysis` | Controls whether NuGet-based analyzers analyze code live at design time. | `true` |
| `RunAnalyzers` | Disables NuGet-based analyzers at both build and design time. This property takes precedence over `RunAnalyzersDuringBuild` and `RunAnalyzersDuringLiveAnalysis`. | `true` |

Examples:

```xml
<RunAnalyzersDuringBuild>false</RunAnalyzersDuringBuild>
<RunAnalyzersDuringLiveAnalysis>false</RunAnalyzersDuringLiveAnalysis>
<RunAnalyzers>false</RunAnalyzers>
```

::: moniker-end

::: moniker range="vs-2017"

## Source analysis

You cannot turn off [source analysis](roslyn-analyzers-overview.md) in Visual Studio 2017. If you want to clear analyzer errors from the Error List, you can suppress all the current violations by choosing **Analyze** > **Run Code Analysis and Suppress Active Issues** on the menu bar. For more information, see [Suppress violations](use-roslyn-analyzers.md#suppress-violations).

Starting in Visual Studio 2019 version 16.3, you can turn off NuGet-based source code analysis. Consider upgrading to Visual Studio 2019.

## Legacy analysis

You can disable legacy, build-time analysis on the **Code Analysis** properties page. For more information, see [How to: Enable and disable legacy code analysis](how-to-enable-and-disable-automatic-code-analysis-for-managed-code.md).

::: moniker-end

## See also

- [Suppress violations](use-roslyn-analyzers.md#suppress-violations)
- [How to: Enable and disable legacy code analysis](how-to-enable-and-disable-automatic-code-analysis-for-managed-code.md)
