---
title: DA0001 - Use StringBuilder for concatenations | Microsoft Docs
description: "Calls to System.String.Concat are a significant proportion of the profiling data. Consider using the System.Text.StringBuilder class to construct strings from multiple segments."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - vs.performance.DA0001
  - vs.performance.rules.DAUseStringBuilder
  - vs.performance.1
  - vs.performance.rules.DA0001
ms.assetid: a7cc7613-ad5f-48c8-bd2b-56372cc12dfc
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# DA0001: Use StringBuilder for concatenations

|Item|Value|
|-|-|
|Rule Id|DA0001|
|Category|.NET Framework Usage|
|Profiling methods|Sampling<br /><br /> Instrumentation|
|Message|Consider using StringBuilder for string concatenations|
|Message type|Warning|

## Cause
 Calls to System.String.Concat are a significant proportion of the profiling data. Consider using the <xref:System.Text.StringBuilder> class to construct strings from multiple segments.

## Rule description
 A <xref:System.String> object is immutable. Therefore, any modification to the string creates a new string object and the garbage collection of the original. This behavior is the same whether you call String.Concat explicitly or use the string concatenation operators such as + or +=.. Program performance can decrease if the these methods are frequently called, such as when characters are added to a string in a tight loop.

 The StringBuilder class is a mutable object, and, unlike System.String, most of the methods on StringBuilder that modify an instance of this class return a reference to that same instance. You can insert characters or append text to a StringBuilder instance, and remove or replace characters in the instance without the need for allocating a new instance and deleting the original instance.

## How to investigate a warning
 Double-click the message in the **Error List** window to navigate to the [Function Details View](../profiling/function-details-view.md) of the sampling profile data. Find the sections of the program that make the most frequent use of string concatenation. Use the StringBuilder class for complex string manipulations, including frequent string concatenation operations.

 For more information about how to work with strings, the [String Operations](/previous-versions/msp-n-p/ff647790(v=pandp.10)#string-operations) section of [Chapter 5 - Improving Managed Code Performance](/previous-versions/msp-n-p/ff647790(v=pandp.10)) in the Microsoft Patterns and Practices library.
