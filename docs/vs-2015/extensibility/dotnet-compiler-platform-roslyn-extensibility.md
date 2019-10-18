---
title: ".NET Compiler Platform (&quot;Roslyn&quot;) Extensibility | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
ms.assetid: 564201b3-1e18-4b88-b615-42c2f57f3fe8
caps.latest.revision: 5
ms.author: gregvanl
manager: jillfra
---
# .NET Compiler Platform (&quot;Roslyn&quot;) Extensibility
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The core mission of the .NET Compiler Platform (“Roslyn”) is opening up the C# and Visual Basic compilers and allowing tools and developers to share in the rich information compilers have about programs. Code analysis tools improve code quality, and code generators aid in application construction. As tools get smarter, they need access to more and more of the deep code knowledge that only compilers possess. Instead of being opaque translators (source code in and object code out), the Roslyn compilers offer APIs that you can use for code-related tasks in your tools and applications.  
  
 The best part is that the Roslyn compilers, their APIs, samples and walkthroughs, and the real tools built on top of these APIs are all fully open source at [github.com/dotnet/roslyn](https://github.com/dotnet/Roslyn). Please go to the OSS site to learn more and get started with Roslyn. You will find links to get the latest C# and VB features that you can use as an end user, as well as links to get started as a tool builder leveraging the Roslyn APIs.  
  
## See also  
 [Getting Started with Roslyn Analyzers](../extensibility/getting-started-with-roslyn-analyzers.md)
