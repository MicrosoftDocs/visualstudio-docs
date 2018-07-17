---
title: Determine which nuget analyzer package to install
ms.date: 07/18/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-code-analysis
ms.topic: reference
helpviewer_keywords:
  - "analyzer package versions"
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "dotnet"
---
# Recommended versions of analyzer packages

Use the following guidelines to determine the version of analyzer packages to install for a given version of Visual Studio.

|Visual Studio version|Analyzer package version|
|-|-|
|Visual Studio 2017 version 15.5 and later|2.6.1, for example https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/2.6.1|
|Visual Studio 2017 version 15.3 to 15.4|2.3.0-beta1, for example https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/2.3.0-beta1|
|Visual Studio 2017 version 15.0 to 15.2|2.0.0-beta2, for example https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/2.0.0-beta2|
|Visual Studio 2015 update 2 and 3|Version 1.2.0-beta2, for example https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/1.2.0-beta2|
|Visual Studio 2015 Update 1|Version 1.1.0, for example https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/1.1.|
|Visual Studio 2015 RTW|Version 1.0.1, for example https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/1.0.1|

On Visual Studio 2017 version 15.5 and later, you can also install a custom [Microsoft code analysis VSIX extension](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.MicrosoftCodeAnalysis2017) that contains all of the analyzers for managed projects.

## See also

[Install .NET Compiler Platform analyzers](install-roslyn-analyzers.md)