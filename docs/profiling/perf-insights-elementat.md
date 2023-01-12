---
title: Perf insights for Enumerable.ElementAt
description: Learn how to improve performance for Enumerable.ElementAt.
ms.date: 01/11/2023
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---

# Slow Enumerable.ElementAt lookup

This article describes performance insights for <xref:System.Linq.Enumerable.ElementAt%2A?displayProperty=nameWithType>.

## Cause

When using the `Enumerable.ElementAt` extension method, the method attempts to leverage the underlying container's fast lookup mechanism if available, such as <xref:System.Collections.Generic.List%601.Item*?displayProperty=nameWithType>, which has O(1) access. If unavailable, the method evaluates the enumerable starting at the beginning of the collection and enumerates to the desired element resulting in O(n) access.

## Performance insight description

The `Enumerable.ElementAt` extension method is designed to try and use the fastest access available to access the specified element. For underlying collections such as <xref:System.Collections.Generic.List%601>, it can use `List.Item[]` direct access, which has O(1) access time. If the underlying collection doesn't support direct access such as <xref:System.Collections.Generic.LinkedList%601> or <xref:System.Collections.Generic.IEnumerable%601> from a [yield statement](/dotnet/csharp/language-reference/statements/yield), it must start at the beginning of the collection and iterate through to the desired index, resulting in O(n) lookup time. If this warning fires, utilizing a better collection can result in better performance.

## How to investigate a warning

In the CPU Usage tool, click **View source code** to go to the [call tree](../profiling/cpu-usage.md#BKMK_Call_tree_structure) and source line highlighting view that shows where the most amount of time is being spent in `Enumerable.ElementAt`. From this point, trace back to where the underlying enumerable collection is created and investigate whether a more appropriate data structure such as `List` can be used instead.

## See also

[Identify hot paths with Flame Graph](../profiling/flame-graph.md)
