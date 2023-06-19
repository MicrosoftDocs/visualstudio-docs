---
title: Perf insights for Enum.ToString
description: Learn how to improve performance for Enum.ToString.
ms.date: 06/19/2023
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---

# Slow Enum.ToString lookup

This article describes performance insights for <xref:System.Enum.ToString%2A?displayProperty=nameWithType>.

## Cause

`Enum.ToString` method is resulting in slow performance.

## Performance insight description

`Enum.ToString` method is expensive because it uses reflection to check if the enum is a flag. Try a caching implementation instead of `Enum.ToString` to avoid the issue.

## How to investigate a warning

In the CPU Usage tool, click **View source code** to go to the [call tree](../profiling/cpu-usage.md#BKMK_Call_tree_structure) and source line highlighting view, which shows where the most amount of time is spent in `Enum.ToString`. From this point, trace back to where the method is used and check whether a caching implementation can be used instead.

## See also

[Identify hot paths with Flame Graph](../profiling/flame-graph.md)
