---
title: Perf insights for zero-length array allocations
description: Learn how to improve performance for zero-length array allocations.
ms.date: 3/7/2025
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Zero-length array allocations

This article describes performance insights for zero-length array allocations.

## Cause

Allocating zero-length arrays in .NET can lead to unnecessary memory allocations. These allocations, although small, can accumulate and cause performance issues, especially in high-performance or memory-constrained applications.

## Performance insight description

When a zero-length array is allocated, it results in a memory allocation that's often unnecessary. Instead of creating a new array, it's more efficient to use the statically allocated empty array instance provided by the `Array.Empty<T>()` method. This method returns a cached, empty array of the specified type, avoiding the overhead of a new allocation.

## How to investigate a warning

Click the **Investigate** link to go to the [Allocation](../profiling/dotnet-alloc-tool.md#allocation) view showing the allocated zero length array. Double clicking on the allocation will show you the code paths where the allocations are occurring. Consider reducing these allocations using the statically-allocated empty array instance provided by `Array.Empty<T>()`.

Here is an example of an empty array allocation and its resolution:

Violation:

```csharp
class Example
{
    public void Method()
    {
        var array = new int[0];
    }
}
```

Resolution:

```csharp
class Example
{
    public void Method()
    {
        var array = Array.Empty<int>();
    }
}
```

## Additional resources

For more information on avoiding zero-length array allocations and other performance best practices, refer to the following resources:

[CA1825: Avoid zero-length array allocations (code analysis)](/dotnet/fundamentals/code-analysis/quality-rules/ca1825)
 
By following these guidelines, you can ensure that your application is optimized for performance and avoids unnecessary memory overhead.
