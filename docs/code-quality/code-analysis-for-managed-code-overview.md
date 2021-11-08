---
title: Code analysis for managed code
ms.date: 08/27/2020
description: Learn about .NET Compiler Platform-based code analyzers in Visual Studio. Understand why these analyzers replace FxCop static analysis of managed assemblies.
ms.custom: SEO-VS-2020
ms.topic: conceptual
helpviewer_keywords:
- code analysis, managed code
- managed code, code analysis
author: mikadumont
ms.author: midumont
manager: jmartens
ms.technology: vs-ide-code-analysis
ms.workload:
- dotnet
---

# Overview of code analysis for .NET in Visual Studio

Visual Studio can perform code analysis of managed code in two ways: with [legacy analysis](../code-quality/walkthrough-analyzing-managed-code-for-code-defects.md), also known as FxCop static analysis of managed assemblies, and with the more modern [.NET Compiler Platform-based code analyzers](../code-quality/roslyn-analyzers-overview.md). .NET Compiler Platform-based code analyzers, which analyze your code live as you type, replace legacy FxCop static code analysis, which only analyzes compiled code.
