---
title: Perf insights for ConcurrentDictionary.Count
description: Learn how to improve performance for ConcurrentDictionary.Count.
ms.date: 06/19/2023
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---

# Slow ConcurrentDictionary.Count lookup

This article describes performance insights for <xref:System.Collections.Concurrent.ConcurrentDictionary.Count%2A?displayProperty=nameWithType>.

## Cause

`System.Collections.Concurrent.ConcurrentDictionary.Count` is resulting in a slow lookup.

## Performance insight description

Some `ConcurrentDictionary` methods, such as `ConcurrentDictionary.Count`, are not concurrent and actually take a lock.

## How to investigate a warning

In the CPU Usage tool, click **View source code** to go to the [call tree](../profiling/cpu-usage.md#BKMK_Call_tree_structure) and source line highlighting view, which shows where the most amount of time is spent in `ConcurrentDictionary.Count`. From this point, trace back to where the method is used and check whether you can use another method instead.

## See also

[Identify hot paths with Flame Graph](../profiling/flame-graph.md)
