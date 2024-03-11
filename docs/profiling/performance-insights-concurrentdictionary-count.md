---
title: Perf insights for ConcurrentDictionary.Count
description: Learn how to improve performance for ConcurrentDictionary.Count.
ms.date: 06/19/2023
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Slow ConcurrentDictionary.Count lookup

This article describes performance insights for <xref:System.Collections.Concurrent.ConcurrentDictionary%602.Count%2A?displayProperty=nameWithType>.

## Cause

`System.Collections.Concurrent.ConcurrentDictionary.Count` is resulting in a slow lookup.

## Performance insight description

Some `ConcurrentDictionary` methods, such as `ConcurrentDictionary.Count`, are not concurrent and actually take a lock. Avoid calling this method frequently. If you need to use it, you might use a separate count in your code (for example, using `Interlocked.Increment`), or you might use an approximate count.

If you need to use lots of `ConcurrentDictionary.Count` method calls, for example, one per request, do not use the default constructor, and instead use a constructor that allows you to specify the concurrency value. The default constructor uses concurrency level equal to the number of cores on the box. Use a smaller number as the concurrency level instead, and then check the overall memory usage.

If you don't need to consider thread-safety, `ConcurrentDictionary` can be more costly than `Dictionary`. So check whether you need to use `ConcurrentDictionary`.

## How to investigate a warning

In the CPU Usage tool, click **View source code** to go to the [call tree](../profiling/cpu-usage.md#BKMK_Call_tree_structure) and source line highlighting view, which shows where the most amount of time is spent in `ConcurrentDictionary.Count`. From this point, trace back to where the method is used and check whether you can use an alternative method.

## See also

[Identify hot paths with Flame Graph](../profiling/flame-graph.md)
