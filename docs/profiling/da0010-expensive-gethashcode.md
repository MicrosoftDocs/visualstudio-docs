---
title: "DA0010: Expensive GetHashCode | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.rules.DAExpensiveGetHashCode"
  - "vs.performance.DA0010"
  - "vs.performance.rules.DA0010"
  - "vs.performance.10"
ms.assetid: 3987e21a-5b4f-45e4-8a33-6b3f0a472c08
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# DA0010: Expensive GetHashCode

|||
|-|-|
|Rule Id|DA0010|
|Category|.NET Framework Usage|
|Profiling methods|Sampling<br /><br /> .NET Memory|
|Message|GetHashCode functions should be cheap and not allocate any memory. Reduce complexity of hash code function if possible.|
|Message type|Warning|

## Cause
 Calls to the GetHashCode method of the type are a significant proportion of the profiling data or the method allocates memory.

## Rule description
 Hashing is a technique for rapidly locating a particular item in a large collection. Because hash tables can be large and have to support very high rates of access, hash tables should be efficient. An implication of this requirement is that GetHashCode methods in the .NET Framework should not allocate memory. Allocating memory increases the load on the garbage collector and exposes the method to potential delays if it becomes necessary to run garbage collection as a result of the allocation request.

## How to fix violations
 Reduce the complexity of the method.
