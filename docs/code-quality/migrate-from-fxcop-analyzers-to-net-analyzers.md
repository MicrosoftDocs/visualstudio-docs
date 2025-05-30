---
title: Migrate from FxCop analyzers to .NET analyzers
description: Migrate your analysis process from binary analysis with FxCop code analysis to .NET analyzers (Roslyn analyzers) for source analysis.
ms.date: 03/06/2020
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

# Migrate from NuGet FxCop analyzers to .NET analyzers

Source analysis by .NET Compiler Platform ("Roslyn") analyzers replaces [legacy analysis](/previous-versions/visualstudio/visual-studio-2019/code-quality/code-analysis-for-managed-code-overview) for managed code. Many of the legacy analysis (FxCop) rules have already been rewritten as source analyzers.

Prior to Visual Studio 2019 16.8 and .NET 5.0, these analyzers shipped as `Microsoft.CodeAnalysis.FxCopAnalyzers` [NuGet package](https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers).

Starting in Visual Studio 2019 16.8 and .NET 5.0, these analyzers are [included with the .NET SDK](/dotnet/fundamentals/code-analysis/overview). If you don't want to move to the .NET 5+ SDK or if you prefer a NuGet package-based model, the analyzers are also available in the `Microsoft.CodeAnalysis.NetAnalyzers` [NuGet package](https://www.nuget.org/packages/Microsoft.CodeAnalysis.NetAnalyzers). You might prefer a package-based model for on-demand version updates.

> [!NOTE]
> The first-party .NET analyzers are target-platform agnostic. That is, your project does not need to target a specific .NET platform. The analyzers work for projects that target `net5.0` as well as earlier .NET versions, such as `netcoreapp`, `netstandard`, and `net472`.

## Migration steps

Starting with version `3.3.2`, `Microsoft.CodeAnalysis.FxCopAnalyzers` NuGet package has been deprecated. Please follow the below steps to migrate your project or solution from `Microsoft.CodeAnalysis.FxCopAnalyzers` to the .NET analyzers:

1. Uninstall `Microsoft.CodeAnalysis.FxCopAnalyzers` NuGet package

2. [Enable or install .NET analyzers](install-net-analyzers.md). Note that you do not need to change your project's target platform.

3. Enable additional rules: `Microsoft.CodeAnalysis.NetAnalyzers` is much more conservative compared to `Microsoft.CodeAnalysis.FxCopAnalyzers`. Unlike FxCopAnalyzers package, it only has a few correctness rules which are [enabled by default as build warnings](/dotnet/fundamentals/code-analysis/overview#enabled-rules). You can [enable additional rules](/dotnet/fundamentals/code-analysis/overview#enable-additional-rules) by customizing the [AnalysisMode](/dotnet/core/project-sdk/msbuild-props#analysismode) MSBuild property. For example, setting the property to `AllEnabledByDefault` will enable all the applicable CA rules as build warnings by default.

   ```xml
   <PropertyGroup>
     <AnalysisMode>AllEnabledByDefault</AnalysisMode>
   </PropertyGroup>
   ```

## Related content

- [Source code analysis versus legacy analysis](net-analyzers-faq.yml#what-s-the-difference-between-legacy-fxcop-and--net-analyzers-)
- [Migrate from legacy analysis to .NET analyzers](migrate-from-legacy-analysis-to-net-analyzers.md)
- [Enable or install .NET analyzers](install-net-analyzers.md)
- [FAQ about .NET analyzers](net-analyzers-faq.yml)
- [Configure .NET analyzers](/dotnet/fundamentals/code-analysis/code-quality-rule-options)
