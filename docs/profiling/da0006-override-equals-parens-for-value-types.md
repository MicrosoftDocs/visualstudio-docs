---
title: DA0006 - Override Equals() for value types | Microsoft Docs
description: "Calls to the Equals method or the equality operators of a public value type are a significant proportion of the profiling data."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - vs.performance.rules.DAOverrideEquals
  - vs.performance.6
  - vs.performance.DA0006
  - vs.performance.rules.DA0006
ms.assetid: 4d85bdd6-b571-47e0-afd6-ba3764e4eed5
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# DA0006: Override Equals() for value types

|Item|Value|
|-|-|
|Rule Id|DA0006|
|Category|.NET Framework Usage|
|Profiiling methods|Sampling|
|Message|Override Equals and equality operator on value types.|
|Messge type|Warning|

## Cause
 Calls to the Equals method or the equality operators of a public value type are a significant proportion of the profiling data. Consider implementing a more efficient method.

## Rule description
 For value types, the inherited implementation of Equals uses the <xref:System.Reflection> library and compares the contents of all fields in the type. Reflection is computationally expensive, and comparing every field for equality might be unnecessary. If you expect users to compare or sort instances or to use them as hash table keys, your value type should implement Equals. If your programming language supports operator overloading, you should also provide an implementation of the equality and inequality operators.

 For more information about how to override Equals and the equality operators, see [Guidelines for Implementing Equals and the Equality Operator (==)](/dotnet/standard/design-guidelines/equality-operators).

## How to investigate a warning
 For an example of implementing the Equals and equality operators, see the code analysis rule [CA1815: Override equals and operator equals on value types](/dotnet/fundamentals/code-analysis/quality-rules/ca1815)
