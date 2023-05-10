---
title: "Reduce compute costs using profiling tools"
description: "Learn how to optimize code using profiling tools such as the CPU Usage tool, Database tool, and the .NET Object Allocation tool."
ms.date: 05/09/2023
ms.topic: conceptual
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "optimize code, profiling tools"
  - "profiling tools, optimize code"
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Reduce compute costs by using profiling tools to optimize code (C#, Visual Basic, C++, F#)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Reducing your compute time means reducing costs, so reducing time by optimizing your code can save money. The CPU Usage tool can help you capture and visualize where compute resources are used in your application. The CPU Usage views such as the call tree and flame chart provide a nice graphical visualization of where time is spent in your app. In addition, auto insights may show simple optimizations that can have a large impact. Additional tools may be used to give a different view of what's happening with your app's performance.

## Start an investigation

Start investigating where to focus your efforts by taking a CPU usage trace. The CPU Usage tool is often helpful to begin performance investigations and to optimize code to reduce cost.

If the problem occurs along with high CPU usage in the CPU timeline graph, investigate using CPU usage tool, looking at top insights, hot path, and views such as the call tree and flame graph.
- If necessary, you may be able to isolate the issue further using the Memory or .NET Object allocation tool for corresponding data on object allocations, memory use, and garbage collection.
- For precise timing and call counts, use the Instrumentation tool.
- If the problem area is file I/O, use the File I/O tool to investigate further. Etc.

If the problem occurs with low CPU usage and other symptoms such as a UI freeze, you may have a blocked thread or an instance of thread pool starvation.
- Check thread start events with the Event Viewer.
- Use the multi-threaded debugger features such as the Threads View to identify a blocked thread.

## Example

## Inspect areas of high CPU usage

:::image type="content" source="./media/optimize-code-cpu-usage-call-tree.png" alt-text="Alt text that describes the content of the image.":::

:::image type="content" source="./media/optimize-code-cpu-usage-flame-graph.png" alt-text="Alt text that describes the content of the image.":::

:::image type="content" source="./media/optimize-code-database.png" alt-text="Alt text that describes the content of the image.":::

## Inspect areas of high memory usage

:::image type="content" source="./media/optimize-code-dotnet-object-allocations.png" alt-text="Alt text that describes the content of the image.":::

:::image type="content" source="./media/optimize-code-memory-usage.png" alt-text="Alt text that describes the content of the image.":::

## Optimize code

## Check the results

:::image type="content" source="./media/optimize-code-cpu-usage-call-tree-fixed.png" alt-text="Alt text that describes the content of the image.":::

:::image type="content" source="./media/optimize-code-database-fixed.png" alt-text="Alt text that describes the content of the image.":::

:::image type="content" source="./media/optimize-code-dotnet-object-allocations-fixed.png" alt-text="Alt text that describes the content of the image.":::

## Iterate