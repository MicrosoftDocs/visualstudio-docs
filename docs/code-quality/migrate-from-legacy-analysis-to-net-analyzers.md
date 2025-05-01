---
title: Migrate from FxCop to source analysis (.NET)
description: Analyze code for the first time or migrate your process from binary analysis (FxCop code analysis) to .NET analyzers for source analysis.
ms.date: 04/30/2025
ms.topic: conceptual
f1_keywords:
 - "vs.projectpropertypages.codeanalysis"
helpviewer_keywords:
- FxCop, migration
- legacy analysis, migration
- source code analysis, migration
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: code-analysis
---

# Migrate from legacy analysis (FxCop) to source analysis (.NET analyzers)

Source analysis by .NET Compiler Platform ("Roslyn") analyzers replaces [legacy analysis](../code-quality/code-analysis-for-managed-code-overview.md) for managed code. For newer project templates such as .NET Core and .NET Standard projects, legacy analysis is not available.

Many of the legacy analysis (FxCop) rules have already been rewritten for .NET analyzers, a set of Roslyn code analyzers. Roslyn analyzers run source-code based analysis during compiler execution. Analyzer results are reported along with compiler results.

For more information on the differences between legacy analysis and source analysis, see the following:

- [Source code analysis versus legacy analysis](../code-quality/net-analyzers-faq.yml#what-s-the-difference-between-legacy-fxcop-and--net-analyzers-)

- [FAQ about .NET analyzers](../code-quality/net-analyzers-faq.yml)

## Migration

To migrate to source analysis:

1. [Enable or install the .NET analyzers](install-net-analyzers.md). Like legacy analysis rule violations, source code analysis violations appear in the Error List window in Visual Studio. In addition, source code analysis violations also show up in the code editor as *squiggles* under the offending code. The color of the squiggle depends on the [severity setting](../code-quality/use-roslyn-analyzers.md#configure-severity-levels) of the rule. To see the status of rules ported to the new .NET analyzers, see [Ported and unported rules](../code-quality/fxcop-rule-port-status.md).

   > [!NOTE]
   > Prior to Visual Studio 2019 16.8 and .NET 5.0, these analyzers shipped as `Microsoft.CodeAnalysis.FxCopAnalyzers` [NuGet package](https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers). Starting in Visual Studio 2019 16.8 and .NET 5.0, these analyzers are [included with the .NET SDK](/dotnet/fundamentals/code-analysis/overview). They are also available as `Microsoft.CodeAnalysis.NetAnalyzers` [NuGet package](https://www.nuget.org/packages/Microsoft.CodeAnalysis.NetAnalyzers). For more information, see [Migrate from FxCop analyzers to .NET analyzers](migrate-from-fxcop-analyzers-to-net-analyzers.md).

1. To resolve CA0507, make sure that legacy code analysis is disabled for the project. In the project file, set the `RunCodeAnalysis` property to false:

   `<RunCodeAnalysis>false</RunCodeAnalysis>`

   Or, open **Project Properties** > **Code Analysis** and disable the **Run on build** setting.

## Configuration

To learn more about how to configure the .NET analyzers:

- To configure .NET analyzers, see [Configure .NET analyzers](/dotnet/fundamentals/code-analysis/code-quality-rule-options).

- To find out about configuring analyzers using predefined rules with EditorConfig or a rule set file, see [Enable a category of rules](/dotnet/fundamentals/code-analysis/code-quality-rule-options).

- To migrate from rule set files to EditorConfig, see [Convert an existing rule set file to an EditorConfig file](../code-quality/use-roslyn-analyzers.md#convert-an-existing-rule-set-file-to-an-editorconfig-file).

## Related content

- [Migrate from FxCop analyzers to .NET analyzers](migrate-from-fxcop-analyzers-to-net-analyzers.md)
