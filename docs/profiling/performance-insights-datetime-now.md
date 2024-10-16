---
title: Perf insights for DateTime.Now
description: Learn how to improve performance for DateTime.get_Now.
ms.date: 06/19/2023
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Slow System.DateTime.Now performance

This article describes performance insights for <xref:System.DateTime.Now%2A?displayProperty=nameWithType>.

## Cause

`System.DateTime.Now` is resulting in slow performance.

## Performance insight description

`DateTime.Now` is costly because it determines daylight savings time (DST) using `TimeZoneInfo.GetIsDaylightSavingsFromUtc()`. Consider using `DateTime.UtcNow` instead of `DateTime.Now`.

Frequent calls to this method can be expensive if DateTime is used to calculate time deltas, such as measuring the duration of certain activities. In this scenario, check whether using `DateTime.UtcNow` can be used instead.

## How to investigate a warning

In the CPU Usage tool, click **View source code** to go to the [call tree](../profiling/cpu-usage.md#BKMK_Call_tree_structure) and source line highlighting view, which shows where the most amount of time is spent in `System.DateTime.Now`. From this point, trace back to where the method is used and check whether you can use `DateTime.UtcNow` instead.

## See also

[Identify hot paths with Flame Graph](../profiling/flame-graph.md)
