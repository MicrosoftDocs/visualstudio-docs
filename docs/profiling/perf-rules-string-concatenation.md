---
title: Performance tips for string concatenations
description: Learn how to improve performance for string concatenations.
ms.date: 7/20/2022
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---

# Use StringBuilder for concatenations

## Cause

Calls to System.String.Concat are a significant proportion of the profiling data. Consider using the <xref:System.Text.StringBuilder> class to construct strings from multiple segments.

## Rule description

A <xref:System.String> object is immutable. Therefore, any modification to the string creates a new string object and the garbage collection of the original. This behavior is the same whether you call String.Concat explicitly or use the string concatenation operators such as + or +=.. Program performance can decrease if the these methods are frequently called, such as when characters are added to a string in a tight loop.

The StringBuilder class is a mutable object, and, unlike System.String, most of the methods on StringBuilder that modify an instance of this class return a reference to that same instance. You can insert characters or append text to a StringBuilder instance, and remove or replace characters in the instance without the need for allocating a new instance and deleting the original instance.

## How to investigate a warning

Clicking "View source code" will take you to the [call tree](../profiling/cpu-usage#BKMK_Call_tree_structure) and source line highlighting view showing where the most amount of time is being spent in string concatenations. If the problem is occurring in multiple locations within the application navigating to the caller/callee view will show each call location.