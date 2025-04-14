---
title: Enable or install first-party .NET analyzers
ms.date: 04/14/2025
description: Enable first-party .NET analyzers by using the .NET SDK in Visual Studio or install a first-party analyzer as a NuGet package.
ms.topic: how-to
helpviewer_keywords:
  - .NET analyzers
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: code-analysis
---

# Enable or install first-party .NET analyzers

.NET compiler platform (Roslyn) analyzers inspect your C# or Visual Basic code for code quality and code style issues. The first-party .NET analyzers are **target-platform agnostic**. That is, your project doesn't need to target a specific .NET platform. The analyzers work for projects that target `net5.0`, later versions, as well as earlier .NET versions, such as `netcoreapp`, `netstandard`, and `net472`.

You can enable or install the first-party .NET analyzers in one of the following ways:

- **Enable from the .NET SDK:** Starting in Visual Studio 2019 16.8 and .NET 5.0, these analyzers are [included with the .NET SDK](/dotnet/fundamentals/code-analysis/overview), which is included with Visual Studio. Analysis is enabled, by default, for projects that target .NET 5.0 or later. You can enable code analysis on projects that target earlier .NET versions by setting the MSBUILD [EnableNETAnalyzers](/dotnet/core/project-sdk/msbuild-props#enablenetanalyzers) property to `true`. You can also disable code analysis for your project by setting `EnableNETAnalyzers` to `false`.

- **Install as a NuGet package:** If you don't want to move to the .NET 5+ SDK or if you prefer a NuGet package-based model, the analyzers are also available in the `Microsoft.CodeAnalysis.NetAnalyzers` [NuGet package](https://www.nuget.org/packages/Microsoft.CodeAnalysis.NetAnalyzers) on Visual Studio 2019 and Visual Studio 2022. You might prefer a package-based model for on-demand version updates. If you're on Visual Studio 2017, install the latest `2.9.x` version of the `Microsoft.CodeAnalysis.FxCopAnalyzers` [NuGet package](https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/) instead.

> [!NOTE]
> It is recommended that you enable the analyzers from the .NET SDK instead of installing the `Microsoft.CodeAnalysis.NetAnalyzers` [NuGet package](https://www.nuget.org/packages/Microsoft.CodeAnalysis.NetAnalyzers), when possible. Enabling the analyzers from the .NET SDK ensures that you automatically get the analyzer bug fixes and new analyzers as soon as you update the SDK. In the NuGet model, you need to update the NuGet package each time you want the latest bug fixes. The NuGet package is updated more frequently.

## Migrate to .NET analyzers

If you are using legacy FxCop analyzers or FxCop analyzers and want to use the .NET analyzers, follow instructions in the following articles:

- [Migrate from legacy analysis to .NET analyzers](migrate-from-legacy-analysis-to-net-analyzers.md)
- [Migrate from FxCop analyzers to .NET analyzers](migrate-from-fxcop-analyzers-to-net-analyzers.md)

## Related content

- [Overview of code analyzers in Visual Studio](roslyn-analyzers-overview.md)
- [Use code analyzers in Visual Studio](use-roslyn-analyzers.md)
