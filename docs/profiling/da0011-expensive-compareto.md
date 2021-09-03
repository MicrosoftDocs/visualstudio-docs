---
title: DA0011 - Expensive CompareTo | Microsoft Docs
description: "The CompareTo method of the type is expensive or allocates memory."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - vs.performance.DA0011
  - vs.performance.rules.DAExpensiveCompareTo
  - vs.performance.11
  - vs.performance.rules.DA0011
ms.assetid: 239a381d-0d97-4367-8668-746c93f5af2c
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# DA0011: Expensive CompareTo

|Item|Value|
|-|-|
|Rule Id|DA0011|
|Category|.NET Framework Usage|
|Profiling methods|Sampling<br /><br /> .NET Memory|
|Message|CompareTo functions should be cheap and not allocate any memory. Reduce complexity of CompareTo function if possible.|
|Rule type|Warning|

## Cause
 The CompareTo method of the type is expensive or allocates memory.

## Rule description
 CompareTo methods should be efficient and should not allocate memory.

## How to fix violations
 Reduce the complexity of the CompareTo method.
