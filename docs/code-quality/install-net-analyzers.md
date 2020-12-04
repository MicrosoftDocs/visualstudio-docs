---
title: Enable or install first-party .NET analyzers
ms.date: 08/03/2018
description: Learn how to enable first-party .NET analyzers from the .NET SDK or install these analyzers as a NuGet package.
ms.custom: SEO-VS-2020
ms.topic: how-to
helpviewer_keywords:
  - .NET analyzers
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - dotnet
---
# Enable or install first-party .NET analyzers

## Overview

.NET compiler platform (Roslyn) analyzers inspect your C# or Visual Basic code for code quality and code style issues. You can enable or install the first-party .NET analyzers in one of the following ways:

- **Enable from the .NET SDK**: Starting in Visual Studio 2019 16.8 and .NET 5.0, these analyzers are [included with the .NET SDK](/dotnet/fundamentals/code-analysis/overview). Analysis is enabled, by default, for projects that target .NET 5.0 or later. You can enable code analysis on projects that target earlier .NET versions by setting the `EnableNETAnalyzers` property to `true`. You can also disable code analysis for your project by setting `EnableNETAnalyzers` to `false`.

- **Install as a NuGet package**: Alternatively, you can install these analyzers by installing the `Microsoft.CodeAnalysis.NetAnalyzers` [NuGet package](https://www.nuget.org/packages/Microsoft.CodeAnalysis.NetAnalyzers) on Visual Studio 2019. If you are on Visual Studio 2017, install the latest `2.9.x` version of the `Microsoft.CodeAnalysis.FxCopAnalyzers` [NuGet package](https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/).

> [!NOTE]
> It is recommended that you enable the analyzers from the .NET SDK instead of installing the `Microsoft.CodeAnalysis.NetAnalyzers` [NuGet package](https://www.nuget.org/packages/Microsoft.CodeAnalysis.NetAnalyzers), when possible. Enabling the analyzers from the .NET SDK ensures that you automatically get the analyzer bug fixes and new analyzers as soon as you update the SDK.

## See also

- [Overview of code analyzers in Visual Studio](roslyn-analyzers-overview.md)
- [Use code analyzers in Visual Studio](use-roslyn-analyzers.md)
- [Migrate from legacy analysis to .NET analyzers](migrate-from-legacy-analysis-to-net-analyzers.md)
- [Migrate from FxCop analyzers to .NET analyzers](migrate-from-fxcop-analyzers-to-net-analyzers.md)
