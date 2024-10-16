---
title: Perf insights for Enum.HasFlag
description: Learn how to improve performance for Enum.HasFlag.
ms.date: 06/19/2023
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Slow Enum.HasFlag performance

This article describes performance insights for <xref:System.Enum.HasFlag%2A?displayProperty=nameWithType>.

## Cause

`Enum.HasFlag` is resulting in slow performance.

## Performance insight description

Using `Enum.HasFlag` in a performance sensitive context can lead to unnecessary memory allocations, such as expensive boxings and type checks.

.NET has [optimized](https://devblogs.microsoft.com/dotnet/performance-improvements-in-net-core-2-1/) this method in .NET 5.0+. If you are building against these frameworks, then using `Enum.HasFlag` is typically fine. However, be aware that there are [caveats](https://github.com/dotnet/runtime/issues/55455) that you should investigate. If performance issues remain, use bitwise operations instead.

## How to investigate a warning

In the CPU Usage tool, click **View source code** to go to the [call tree](../profiling/cpu-usage.md#BKMK_Call_tree_structure) and source line highlighting view, which shows where the most amount of time is spent in `Enum.HasFlag`. From this point, trace back to where the method is used and check whether a bitwise operation should be used instead. You can also use the context menu to navigate from the `Enum.HasFlag` row in the call tree to the caller callee view to see every source location where `Enum.HasFlag` was found.

## See also

[Identify hot paths with Flame Graph](../profiling/flame-graph.md)
