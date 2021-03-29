---
title: .NET Compiler Platform (&quot;Roslyn&quot;) Extensibility | Microsoft Docs
description: Learn about the .NET Compiler Platform, which allows tools and developers to share in the rich information compilers have about programs.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: 564201b3-1e18-4b88-b615-42c2f57f3fe8
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# .NET Compiler Platform (&quot;Roslyn&quot;) extensibility
The core mission of the .NET Compiler Platform ("Roslyn") is opening up the C# and Visual Basic compilers and allowing tools and developers to share in the rich information compilers have about programs. Code analysis tools improve code quality, and code generators aid in application construction. As tools get smarter, they need access to more and more of the deep code knowledge that only compilers possess. Instead of being opaque translators (source code in and object code out), the Roslyn compilers offer APIs that you can use for code-related tasks in your tools and applications.

 The best part is that the Roslyn compilers, their APIs, samples and walkthroughs, and the real tools built on top of these APIs are all fully open source at [github.com/dotnet/roslyn](https://github.com/dotnet/Roslyn). Please go to the OSS site to learn more and get started with Roslyn. You will find links to get the latest C# and Visual Basic features that you can use as an end user, as well as links to get started as a tool builder leveraging the Roslyn APIs.

## See also
- [Get started with Roslyn analyzers](../extensibility/getting-started-with-roslyn-analyzers.md)
