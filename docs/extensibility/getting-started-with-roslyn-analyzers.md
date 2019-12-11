---
title: "Getting Started with Roslyn Analyzers | Microsoft Docs"
ms.date: 04/02/2018
ms.topic: "conceptual"
ms.assetid: 367c2ec8-3059-46a5-9d1c-57bead0419e7
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Get started with Roslyn analyzers

With live, project-based code analyzers in Visual Studio, API authors can ship domain-specific code analysis as part of their NuGet packages. Because these analyzers are powered by the .NET Compiler Platform (code-named "Roslyn"), they can produce warnings in your code as you type even before you've finished the line (no more waiting to build your code to discover issues). Analyzers can also surface an automatic code fix through the Visual Studio light bulb prompt to let you clean up your code immediately.

## Get started

[Roslyn analyzers overview](../code-quality/roslyn-analyzers-overview.md)

[Tutorial: Write your first analyzer and code fix](/dotnet/csharp/roslyn-sdk/tutorials/how-to-write-csharp-analyzer-code-fix)

[Add code fixes Walkthrough: Provide users fixes for analyzer issues](https://msdn.microsoft.com/magazine/dn904670.aspx)

[Real world Roslyn analyzer](../extensibility/roslyn-analyzers-and-code-aware-library-for-immutablearrays.md) that you can also watch as a [talk](https://channel9.msdn.com/events/Build/2015/3-725)

[Several examples on GitHub, grouped into three kinds of analyzers](https://github.com/dotnet/roslyn/blob/master/docs/analyzers/Analyzer%20Samples.md)

## See also

- [.NET compiler platform package version reference](roslyn-version-support.md)
- [More docs on the GitHub OSS site](https://github.com/dotnet/roslyn/tree/master/docs/analyzers)
- [FxCop rules implemented with Roslyn analyzers](../code-quality/fxcop-rule-port-status.md)
