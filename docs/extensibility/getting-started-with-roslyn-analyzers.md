---
title: "Getting Started with Roslyn Analyzers | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 367c2ec8-3059-46a5-9d1c-57bead0419e7
caps.latest.revision: 6
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Getting Started with Roslyn Analyzers
With live, project-based code analyzers in Visual Studio, API authors can ship domain-specific code analysis as part of their NuGet packages.  Because these analyzers are powered by the .NET Compiler Platform (code-named “Roslyn”), they can produce warnings in your code as you type even before you’ve finished the line (no more waiting to build your code to discover issues).  Analyzers can also surface an automatic code fix through the Visual Studio light bulb prompt to let you clean up your code immediately  
  
## Getting Started  
 [Roslyn Live Code Analyzers Introduction and Walkthrough](https://msdn.microsoft.com/en-us/magazine/dn879356.aspx)  
  
 [Adding Code Fixes Walkthrough: Provide Users Fixes for Analyzer Issues](https://msdn.microsoft.com/en-us/magazine/dn904670.aspx)  
  
 [Introduction and Walkthrough of Real World Analyzer Talk](http://channel9.msdn.com/events/Build/2015/3-725)  
  
 [Real World Roslyn Analyzer](../extensibility/roslyn-analyzers-and-code-aware-library-for-immutablearrays.md) that you can also watch as a [talk](http://channel9.msdn.com/events/Build/2015/3-725)  
  
 [Several examples on github, grouped into three kinds of analyzers](https://github.com/dotnet/roslyn/blob/master/docs/analyzers/Analyzer%20Samples.md)  
  
 [Introduction and Tour of a Few Analyzers Talk](http://channel9.msdn.com/Events/dotnetConf/2015/NET-Compiler-Platform-Roslyn-Analyzers-and-the-Rise-of-Code-Aware-Libraries)  
  
## Other Resources  
 [More docs on the github OSS site](https://github.com/dotnet/roslyn/tree/master/docs/analyzers)  
  
 [FxCop rules implemented with Roslyn analyzers on github](https://github.com/dotnet/roslyn/tree/master/src/Diagnostics/FxCop)