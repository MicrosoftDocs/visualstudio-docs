---
title: Perf insights for String.StartsWith
description: Learn how to improve performance for String.StartsWith.
ms.date: 06/19/2023
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Slow String.StartsWith performance

This article describes performance insights for <xref:System.String.StartsWith%2A?displayProperty=nameWithType>.

## Cause

`System.String.StartsWith` is resulting in slow performance.

## Performance insight description

Avoid using `string.StartsWith(string-of-len-1)` or `string.EndsWith(string-of-len-1)` inside a performance-sensitive context because it involves a culture-sensitive comparison, which leads to more CPU/memory overhead. Instead, use overrides that specify the needed comparison, leveraging `StringComparison.Ordinal` or `StringComparison.OrdinalIgnoreCase` if possible.

## How to investigate a warning

In the CPU Usage tool, click **View source code** to go to the [call tree](../profiling/cpu-usage.md#BKMK_Call_tree_structure) and source line highlighting view, which shows where the most amount of time is spent in `System.String.StartsWith`. From this point, trace back to where the method is used and check whether you can avoid using these methods with strings of length == 1.

## See also

[Identify hot paths with Flame Graph](../profiling/flame-graph.md)
