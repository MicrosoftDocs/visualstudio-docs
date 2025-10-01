---
title: Perf insights for List<T>.Find usage
description: Learn how to improve performance by replacing List<T>.Find with Dictionary<TKey, TValue>.
ms.date: 10/1/2025
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Inefficient List<T>.Find usage

This article describes performance insights when using <xref:System.Collections.Generic.List%601.Find*?displayProperty=nameWithType>.

## Cause

`List<T>.Find` method is resulting in slow performance.

## Performance insight description

The `List<T>.Find` method performs a linear search through the list, resulting in O(n) time complexity for each lookup. This can be inefficient when searching for items frequently or in large lists.

If possible, consider using <xref:System.Collections.Generic.Dictionary%602> or a <xref:System.Collections.Generic.HashSet%601>. If you can assign a key or unique property to the value, <xref:System.Collections.Generic.Dictionary%602> can be used. If you are storing unique values, <xref:System.Collections.Generic.HashSet%601> can be used. Both of these alternative data structures have an O(1) time complexity for each lookup compared to O(n) in `List<T>.Find`.

## How to investigate a warning

In the CPU Usage tool, click **View source code** to find where `List<T>.Find` is used. If possible, refactor code to use an alternative data structure with faster lookups.

## See also

[Dictionaries in .NET](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary-2)
