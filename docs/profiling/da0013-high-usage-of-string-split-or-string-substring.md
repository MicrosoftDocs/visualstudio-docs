---
title: DA0013 - High usage of String.Split or String.Substring | Microsoft Docs
description: "Calls to the System.String.Split or System.String.Substring methods are a significant portion of the profiling data."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - vs.performance.13
  - vs.performance.rules.DAAvoidStringSubstr
  - vs.performance.DA0013
  - vs.performance.rules.DA0013
helpviewer_keywords: 
  - vs.performance.13
  - vs.performance.rules.DA0013
ms.assetid: f501f423-bef9-4e08-bf96-c9ac9957e5a2
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# DA0013: High usage of String.Split or String.Substring

|Item|Value|
|-|-|
|Rule Id|DA0013|
|Category|.NET Framework Usage Guidance|
|Profiling methods|Sampling|
|Message|Consider reducing use of String.Split and String.Substring functions.|
|Rule type|Warning|

## Cause
 Calls to the System.String.Split or System.String.Substring methods are a significant portion of the profiling data. Consider using System.String.IndexOf or System.String.IndexOfAny if you're testing for the existence of a substring in a string.

## Rule description
 The Split method operates on a String object and returns a new array of Strings that holds the substrings of the original. The function allocates memory for the returned array object and allocates a new String object for each array element it finds. Similarly, the Substr method operates on a String object and returns a new String that is equivalent to the requested substring.

 If managing memory allocations is critical in your application, consider using alternatives to the String.Split and String.Substr methods. For example, you can use the IndexOf or IndexOfAny method to locate a specific substring within a character String without creating a new instance of the String class.

## How to investigate a warning
 Double-click the message in the **Error List** window to navigate to the [Function Details View](../profiling/function-details-view.md) of the sampling profile data. Examine the calling functions to find the sections of the program that make the most frequent use of the System.String.Split or System.String.Substr methods. If possible, use the IndexOf or IndexOfAny method to locate a specific substring within a character String without creating a new instance of the String class.
