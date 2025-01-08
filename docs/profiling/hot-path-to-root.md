---
title: "Hot paths to root in the Memory Usage tool"
description: Learn what a hot path to root means in the Memory Usage tool.
ms.date: "01/07/2024"
ms.topic: "conceptual"
author: "asundheim"
ms.author: "asundheim"
ms.subservice: debug-diagnostics
monikerRange: '>= vs-2022'
---
# Analyze hot path to root in the Memory Usage tool

When profiling .NET code in the [Memory Usage](../profiling/memory-usage-without-debugging2.md) profiling tool in Visual Studio, the *hot path to root* may help you to identify objects retained on the heap that are causing memory usage issues. In the context of memory usage, the *hot path* is a reference chain identified by the profiler that points to a root object that is a potential source of memory issues.

When calculating the inclusive size of an object (the total amount of memory retained on the heap by keeping the object alive), it's often helpful to reduce the strongly connected heap graph into a tree. Unlike a graph, a node in a tree has arbitrarily many children but only a single parent. Rather than consider every possible path to root for an object, choosing the most likely path to root using various heuristics is typically sufficient to find the reference chain that, if removed, will make the object eligible for garbage collection. Some of these heuristics include prioritizing the shortest path to root, certain root types, and user code paths. For various reasons, this strategy doesn't always find the most interesting or longest-living retention chain, but it often provides a useful starting point in a memory usage investigation.

In the **Paths to Root** tree of the Memory Usage tool, the path with the flame icon (![Screenshot that shows Hot Path icon.](../profiling/media/optimize-code-hot-path-icon.png)) is called the hot path to root.

## Example

Use the **Show hot paths only** option to filter the view in the **Paths to Root** pane.

In this example, there's a WPF control (`AttachToProcess.Dialog`) being leaked through a binding that is ultimately rooted by an `AutomationPeer`. In the filtered view, the retention path is obvious; only the direct path to the root is visible.

[ ![Screenshot of the Paths to Root reference graph. Show hot paths only is checked, highlighting a linear chain of references.](../profiling/media/hot-path-to-root-example-1.png) ](../profiling/media/hot-path-to-root-example-1.png#lightbox)

With the option disabled, it becomes clear that there are hundreds of bindings, and most expansion paths lead to dead ends that cycle. Without the visual indicator, it's tedious to sort through thousands of potential retention paths to find a candidate reason for the leak.
[ ![Screenshot of the same Paths to Root reference graph, but Show hot paths only is unchecked with many possible dead ends visible.](../profiling/media/hot-path-to-root-example-2.png) ](../profiling/media/hot-path-to-root-example-2.png#lightbox)

## See also

For more information about the Visual Studio Memory Usage tool, see
- [Analyze memory usage with the debugger](../profiling/memory-usage.md)
- [Analyze memory usage without the debugger](../profiling/memory-usage-without-debugging2.md)