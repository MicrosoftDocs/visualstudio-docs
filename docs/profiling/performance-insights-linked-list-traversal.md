---
title: Perf insights for excessive LinkedList traversal
description: Learn how to improve performance for excessive traversal of LinkedList collections.
ms.date: 09/18/2025
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---


# Inefficient LinkedList traversal

This article describes performance insights when traversing <xref:System.Collections.Generic.LinkedList%601> collections.

## Cause
Traversing a `LinkedList<T>` to find elements results in slow performance.

## Performance insight description

`LinkedList<T>` does not provide O(1) access to elements by index. Each traversal through the list, especially in loops or nested loops, results in O(n) time complexity. This can cause significant performance degradation when searching for items frequently or in large linked lists.

If possible, consider using <xref:System.Collections.Generic.List%601> or <xref:System.Collections.Generic.Dictionary%602>. `List<T>` provides O(1) access by index, and `Dictionary<TKey, TValue>` provides O(1) lookups by key. These alternatives are often more efficient for most access patterns compared to traversing a linked list.

## How to investigate a warning

In the CPU Usage tool, click **View source code** to find where `LinkedList<T>` traversal is used. If possible, refactor to use a different collection type that provides faster access for your scenario.

## See also

[Collections and data structures](https://learn.microsoft.com/dotnet/standard/collections/)
