---
title: Getting Started with Roslyn Analyzers
description: Get started with Roslyn analyzers in Visual Studio with tutorials and examples about writing analyzers, adding code fixes, and developing real-world analyzers.
ms.date: 04/02/2018
ms.topic: conceptual
author: maiak
ms.author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---
# Get started with Roslyn analyzers

With live, project-based code analyzers in Visual Studio, API authors can ship domain-specific code analysis as part of their NuGet packages. Because these analyzers are powered by the .NET Compiler Platform (code-named "Roslyn"), they can produce warnings in your code as you type even before you've finished the line (no more waiting to build your code to discover issues). Analyzers can also surface an automatic code fix through the Visual Studio light bulb prompt to let you clean up your code immediately.

## Get started

[Roslyn analyzers overview](../code-quality/roslyn-analyzers-overview.md)

[Tutorial: Write your first analyzer and code fix](/dotnet/csharp/roslyn-sdk/tutorials/how-to-write-csharp-analyzer-code-fix)

[Add code fixes Walkthrough: Provide users fixes for analyzer issues](/archive/msdn-magazine/2015/february/csharp-adding-a-code-fix-to-your-roslyn-analyzer)

[Real world Roslyn analyzer](../extensibility/roslyn-analyzers-and-code-aware-library-for-immutablearrays.md)

[Several examples on GitHub, grouped into three kinds of analyzers](https://github.com/dotnet/roslyn/blob/main/docs/analyzers/Analyzer%20Samples.md)

## Related content

- [.NET compiler platform package version reference](roslyn-version-support.md)
- [More docs on the GitHub OSS site](https://github.com/dotnet/roslyn/tree/main/docs/analyzers)
- [FxCop rules implemented with Roslyn analyzers](../code-quality/fxcop-rule-port-status.md)
