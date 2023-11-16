---
title: Migrate from FxCop to source analysis (.NET analyzers)
description: "Learn how to analyze code for the first time or how to migrate from binary analysis (FxCop) to the new way of analyzing managed code using source analysis (.NET analyzers)."
ms.date: 09/17/2021
ms.topic: conceptual
f1_keywords:
 - "vs.projectpropertypages.codeanalysis"
helpviewer_keywords:
- FxCop, migration
- legacy analysis, migration
- source code analysis, migration
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-code-analysis
---
# Migrate from legacy analysis (FxCop) to source analysis (.NET analyzers)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

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

## Related content

- [Migrate from FxCop analyzers to .NET analyzers](migrate-from-fxcop-analyzers-to-net-analyzers.md)
