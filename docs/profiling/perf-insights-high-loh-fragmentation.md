---
title: Perf insights for high LOH fragmentation
description: Learn how to improve performance for high large object heap (LOH) fragmentation
ms.date: 9/15/2022
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# High LOH Fragmentation

This article describes performance insights for high large object heap (LOH) allocations.

## Cause

The [large object heap (LOH)](/dotnet/standard/garbage-collection/large-object-heap) is not compacted and the fragmentation is used to satisfy LOH allocation requests. Consider reducing temporary large object allocations through reuse or pooling to avoid triggering frequent Gen2 GCs.

## Rule description

The [.NET Garbage Collector (GC)](/dotnet/standard/garbage-collection/) puts large objects in a specific region of memory known as the [large object heap (LOH)](/dotnet/standard/garbage-collection/large-object-heap). Because the LOH is not compacted, sometimes the LOH can be the source of fragmentation.

## How to investigate a warning

Click the **Investigate** link to go to the [Allocation](../profiling/dotnet-alloc-tool.md#allocation) view showing allocations grouped by heap type. Objects under the Large Object Heap node are contributing to the frequent GCs. Consider reducing these allocations through reuse or pooling techniques.
