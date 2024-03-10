---
title: Perf insights for String(Char[])
description: Learn how to improve performance for String(Char[]).
ms.date: 07/05/2023
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Slow String(Char[]) initialization

This article describes performance insights for <xref:System.String.%23ctor(System.Char[])>.

## Cause

`String(Char[])` is resulting in slow initialization.

## Performance insight description

This constructor creates a new string from the specified character array. If you need to use lots of calls to the `String(Char[])` constructor, please consider in-place modification of strings by unsafe code instead, or use char[] directly.

## How to investigate a warning

In the CPU Usage tool, click **View source code** to go to the [call tree](../profiling/cpu-usage.md#BKMK_Call_tree_structure) and source line highlighting view, which shows where the most amount of time is spent in `String(Char[])`. From this point, trace back to where the method is used and check whether you can use an in-place modification of strings by unsafe code or you can use char[] directly.

## See also

[Identify hot paths with Flame Graph](../profiling/flame-graph.md)
