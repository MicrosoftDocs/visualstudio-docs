---
title: Perf insights for string concatenations
description: Learn how to improve performance for string concatenations.
ms.date: 8/03/2022
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Use StringBuilder for concatenations

This article describes performance insights for string concatenations.

## Cause

Calls to System.String.Concat are a significant proportion of the profiling data. Consider using the <xref:System.Text.StringBuilder> class to construct strings from multiple segments.

## Performance insight description

A <xref:System.String> object is immutable. Therefore, any modification to the string creates a new string object and the garbage collection of the original. This behavior is the same whether you call String.Concat explicitly or use the string concatenation operators such as + or +=. Program performance can decrease if these methods are frequently called, such as when characters are added to a string in a tight loop.

The StringBuilder class is a mutable object, and, unlike System.String, most of the methods on StringBuilder that modify an instance of this class return a reference to that same instance. You can insert characters or append text to a StringBuilder instance, and remove or replace characters in the instance without the need for allocating a new instance and deleting the original instance.

## How to investigate a warning

In the CPU Usage tool, click **View source code** to go to the [call tree](../profiling/cpu-usage.md#BKMK_Call_tree_structure) and source line highlighting view showing where the most amount of time is spent in string concatenations. If the problem is occurring in multiple locations within the application, navigate to the caller/callee view to see each call location.

## See also
- [Identify hot paths with Flame Graph](../profiling/flame-graph.md)
- [Diagnose high latency with CPU Insights](../profiling/cpu-insights.md)