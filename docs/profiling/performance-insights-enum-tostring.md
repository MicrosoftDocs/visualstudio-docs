---
title: Perf insights for Enum.ToString
description: Learn how to improve performance for Enum.ToString.
ms.date: 06/19/2023
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Slow Enum.ToString performance

This article describes performance insights for <xref:System.Enum.ToString%2A?displayProperty=nameWithType>.

## Cause

`Enum.ToString` method is resulting in slow performance.

## Performance insight description

`Enum.ToString` method is expensive because it uses reflection to check if the enum is a flag. Reflection is a mechanism that allows you to inspect and manipulate the metadata of types, objects, properties, and methods at runtime. Reflection can be costly, especially when used excessively or in performance-critical scenarios.

If the app is repeatedly accessing the same value, try a caching implementation instead of `Enum.ToString` to avoid the issue.

## How to investigate a warning

In the CPU Usage tool, click **View source code** to go to the [call tree](../profiling/cpu-usage.md#BKMK_Call_tree_structure) and source line highlighting view, which shows where the most amount of time is spent in `Enum.ToString`. From this point, trace back to where the method is used and check whether a caching implementation can be used instead.

## See also

[Identify hot paths with Flame Graph](../profiling/flame-graph.md)
