---
title: Performance insights for boxed boolean allocations
description: Learn how to improve performance for boxed boolean allocations.
ms.date: 12/04/2025
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
monikerRange: '>= visualstudio'
---

# Boxed boolean allocations

This article describes performance insights for boxed boolean allocations.

## Cause

Boxing boolean values in .NET creates heap allocations each time a `bool` is converted to an `object` or interface type. These allocations, although small, can accumulate rapidly in performance-critical code paths and cause unnecessary garbage collection pressure, especially when the same boolean values are boxed repeatedly.

## Performance insight description

When a boolean value is boxed, the runtime allocates a new object on the heap to wrap the value type. Since there are only two possible boolean values (`true` and `false`), repeatedly boxing these values is wasteful. Instead of allowing implicit boxing, it's more efficient to cache the boxed instances and reuse them. You can create static readonly fields for the boxed `true` and `false` values and return the appropriate cached instance when boxing is necessary.

## How to investigate a warning

Click the **Investigate** link to go to the [Allocation](../profiling/dotnet-alloc-tool.md#allocation) view showing the allocated boxed boolean objects. Double clicking on the allocation shows you the code paths where the allocations are occurring. Consider reducing these allocations by caching the boxed boolean values and returning the cached instances instead of allowing repeated boxing operations.

If Copilot is enabled, you see the **Ask Copilot** ![Screenshot of Ask Copilot button.](../debugger/media/vs-2022/debug-with-copilot-ask-copilot-button.png) button. Select the button, and Copilot provides a detailed analysis of the allocation patterns and suggests code fixes to optimize your memory usage.

Here is an example of a boxed boolean allocation and its resolution:

Violation:

```csharp
class Example
{
    public object GetResult(bool condition)
    {
        return condition; // Implicit boxing occurs here
    }
}
```

Resolution:

```csharp
class Example
{
    private static readonly object BoxedTrue = true;
    private static readonly object BoxedFalse = false;

    public object GetResult(bool condition)
    {
        return condition ? BoxedTrue : BoxedFalse;
    }
}
```

## Additional resources

For more information on avoiding boxing allocations and other performance best practices, see the following resources:

[Boxing and Unboxing (C# Programming Guide)](/dotnet/csharp/programming-guide/types/boxing-and-unboxing)

[CA1841: Prefer Dictionary.Contains methods (code analysis)](/dotnet/fundamentals/code-analysis/quality-rules/ca1841)
 
By following these guidelines, you can ensure that your application is optimized for performance and avoids unnecessary boxing overhead.
