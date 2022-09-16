---
title: Perf insights for LOH allocations
description: Learn how to improve performance for excessive LOH allocations.
ms.date: 8/3/2022
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---

# Excessive LOH allocations triggering Gen2 GCs

This article describes performance insights for large object heap (LOH) allocations.

## Cause

Frequent temporary LOH object allocations force unproductive full generation 2 (Gen2) garbage collections (GC). Consider reducing temporary large object allocations through reuse or pooling to avoid triggering frequent Gen2 GCs.

## Performance insight description

The [.NET Garbage Collector (GC)](/dotnet/standard/garbage-collection/) puts large objects in a specific region of memory known as the [large object heap (LOH)](/dotnet/standard/garbage-collection/large-object-heap). These allocations are assumed to survive longer due to their allocation cost and are therefore only collected during full [Gen2 GCs](/dotnet/standard/garbage-collection/fundamentals#generations).

When this assumption is not true and an application frequently allocates temporary large objects, the LOH space is quickly used up. This causes many Gen2 GCs to regain space which can impact performance and responsiveness of an application.

## How to investigate a warning

Clicking on the "investigate" link will take you to the [Allocation](../profiling/dotnet-alloc-tool.md#allocation) view showing allocations grouped by heap type. Objects under the Large Object Heap node are contributing to the frequent GCs, consider reducing these allocations through reuse or pooling techniques.
