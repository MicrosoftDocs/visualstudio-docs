---
title: Perf insights for Enumerable.Contains
description: Learn how to improve performance for Enumerable.Contains.
ms.date: 01/11/2023
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---

# Slow Enumerable.Contains lookup

This article describes performance insights for <xref:System.Linq.Enumerable.Contains%2A?displayProperty=nameWithType>.

## Cause

When using the `Enumerable.Contains` extension method, the method attempts to leverage the underlying container's fast lookup mechanism, if available, such as <xref:System.Collections.Generic.HashSet%601.Contains*?displayProperty=nameWithType>, which has O(1) access. If unavailable, the method evaluates the enumerable starting at the beginning of the collection and enumerates until the element is found or not, resulting in O(n) access.

## Performance insight description

The `Enumerable.Contains` extension method is designed to try and use the fastest access available to see if the element is contained in the specified collection. For underlying collections like <xref:System.Collections.Generic.HashSet%601>, it can use <xref:System.Collections.Generic.HashSet%601.Contains*?displayProperty=nameWithType> to check if the specified element is in the collection with O(1) access time. If the underlying collection doesn't support direct checking such as <xref:System.Collections.Generic.List%601> or <xref:System.Collections.Generic.IEnumerable%601> from a [yield statement](/dotnet/csharp/language-reference/statements/yield), it must start at the beginning of the collection and iterate through until the desired element is found or not, resulting in O(n) lookup time. If this warning fires, utilizing a better collection can result in better performance.

## How to investigate a warning

In the CPU Usage tool, click **View source code** to go to the [call tree](../profiling/cpu-usage.md#BKMK_Call_tree_structure) and source line highlighting view, which shows where the the most amount of time is spent in `Enumerable.Contains`. From this point, trace back to where the underlying enumerable collection is created and check whether a more appropriate data structure such as `HashSet` can be used instead.

## See also

[Identify hot paths with Flame Graph](../profiling/flame-graph.md)
