---
title: Perf insights for excessive immutable collection modifications
description: Learn how to improve performance for excessive modifications to immutable collections.
ms.date: 10/01/2025
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Inefficient immutable collection modifications

This article describes performance insights when modifying immutable collections such as <xref:System.Collections.Immutable.ImmutableList%601>.

## Cause

Modifying an immutable collection (such as `Add`, `Remove`, or `Insert`) results in slow performance.

## Performance insight description

Each modification to an immutable collection creates a new copy of the collection, resulting in excessive memory allocations and CPU usage. This is especially inefficient when modifications are performed frequently, in loops, or in performance-critical code paths.

If possible, use a mutable collection (such as `List<T>`) during construction or in hot paths, and convert to an immutable collection only when necessary. Mutable collections allow for efficient in-place modifications, while immutable collections are best used for thread safety and scenarios where modifications are infrequent.

## How to investigate a warning

In the CPU Usage tool, click **View source code** to find where immutable collections are being modified. If possible, refactor to use a mutable collection in performance-sensitive code, and convert to an immutable collection only when needed.

## See also

[Immutable collections documentation](https://learn.microsoft.com/dotnet/api/system.collections.immutable)
