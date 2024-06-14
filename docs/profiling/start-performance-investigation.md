---
title: "Start a performance investigation"
description: "Learn how to use .NET Counters and the Instrumentation tools to identify, isolate, and resolve performance issues."
ms.date: 06/14/2024
ms.topic: conceptual
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "isolate performance issues, profiling tools"
  - "profiling tools, .NET Counters"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
monikerRange: '>= vs-2022'
---

# Start a performance investigation (C#, Visual Basic, F#)

In this article, we show how you can use profiling tools start to investigate performance issues and isolate problem areas. 

Rather than providing step-by-step instructions, the intent here is to show you how to use the profiling tools effectively and how to interpret the data. Like the CPU Usage tool, the .NET Counters tool is also a good starting point for a performance investigation. Once you identify interesting data, you can use other profiling tools to investigate more deeply. To compare tools, see [Which tool should I choose?](../profiling/choose-performance-tool.md)

## Start an investigation

- Start your investigation by watching .NET counter metrics while collecting performance data.
- Next, for additional insights to help isolate issues, consider collecting a trace using one of the other profiling tools. For example:
  - If CPU Usage is high, try the CPU Usage tool.
  - If CPU Usage is low, try the Instrumentation tool. Since Instrumentation provides exact call counts and wall clock time, it can be helpful to identify performance issues when CPU Usage is low.

## Data collection example

The example screenshots shown in this article are based on an ASP.NET app that runs queries against a simulated database. The example is based on the [Diagnostics Sample](/dotnet/core/diagnostics/debug-threadpool-starvation).

Data collection requires the following steps (not shown here):

- Set your app to a Release build.
- Select the .NET Counters tool from the Performance Profiler (**Alt+F2**). (Later steps involve the Instrumentation tool.)
- From the Performance Profiler, start the app.

## Check performance counters

While running the app, view the counters in the .NET Counters tool. For initial investigations, a few key metrics to keep an eye on include:

- CPU Usage. Watch this counter to see whether a performance issue occurs with high or low CPU usage. This can be a clue to specific types of performance issues. For example:
  - With high CPU usage, use the CPU Usage tool to identify areas where you may be able to optimize code. For a tutorial on this, see [Beginner's guide to optimizing code](../profiling/optimize-code-using-profiling-tools.md).
  - With low CPU usage, use the Instrumentation tool to identify call counts and average function time based on wall clock time. This may help you to identify issues such as contention or thread pool starvation.
- GC Heap Size. Watch this counter to see if memory usage is growing continually and potentially leaking. If this seems high, you can use one of the memory usage tools.
- Threadpool Thread Count. For multi-threaded apps, watch this counter to see if the thread count is rises continuously.

Here's an example showing how the `CPU Usage` is low, while the `ThreadPool Thread Count` is relatively high.

:::image type="content" source="./media/vs-2022/instrumentation-threadpool-starvation-counters.png" alt-text="Screenshot of counters showing in the .NET Counters tool.":::

A rising thread count with a low CPU usage can be an indicator of thread pool starvation. Thread pool starvation occurs when the pool has no available threads to process new work items and it often causes applications to respond slowly. 

In some cases of thread pool starvation, the `ThreadPool Queue Length` may show high values and the `ThreadPool Completed Work Item Count` may show low values, indicating that a lot of work is not getting completed quickly.

:::image type="content" source="./media/vs-2022/instrumentation-threadpool-starvation-counters-queue-length.png" alt-text="Screenshot of thread pool queue length and completed work in the .NET Counters tool.":::

Based on the low CPU usage and the relatively high thread count, and working on the theory of a possible case of thread pool starvation, switch to using the Instrumentation tool.

## Investigate call counts and timing data

Let's take a look at a trace from the Instrumentation tool to see if we can try to find out more about what is happening with the threads.

In the collected trace, use the **Open details** link in the report and then select **Flame Graph**.

:::image type="content" source="./media/vs-2022/instrumentation-threadpool-starvation-flame-graph.png" alt-text="Screenshot of Flame Graph in the Instrumentation tool.":::

The Flame Graph visualization shows us that the `QueryCustomerDB` function is responsible for a significant portion of the app's running time.

Right-click the `QueryCustomerDB` funcion and choose **View in Call Tree**.

:::image type="content" source="./media/vs-2022/instrumentation-threadpool-starvation-call-tree.png" alt-text="Screenshot of Call Tree in the Instrumentation tool.":::

In the Call Tree view, we see the Hot Path (flame icon) includes the `QueryCustomerDB` function, which points to a potential performance issue.

Relative to time spent in other functions, the **Self** and **Avg Self** values are very high. Unlike **Total** and **Avg Total**, the **Self** values exclude time spent in other functions, so we know this is a good place to look for the performance bottleneck.

Double-click the `QueryCustomerDB` function to show the source code for the function. With a little research, we can see that it's calling an async API without using await. This is the [sync-over-async](https://devblogs.microsoft.com/pfxteam/should-i-expose-synchronous-wrappers-for-asynchronous-methods/) code pattern, which is a common cause of threadpool starvation, and may block threads.

```csharp
public ActionResult<string> QueryCustomerDB()
{

    Task dbTask = QueryCustomerFromDbAsync("Dana");
    return "success:tasksleepwait";
}
```

To resolve, use await.

```csharp
public async Task<ActionResult<string>> TaskAsyncWait()
{
    Customer c = await PretendQueryCustomerFromDbAsync("Dana");
    return "success:taskasyncwait";
}
```

## Next steps

The following articles and blog posts provide more information to help you learn to use the Visual Studio performance tools effectively.

- [Beginner's guide to optimizing code](../profiling/optimize-code-using-profiling-tools.md)
- [Improving Visual Studio performance with the new Instrumentation Tool](https://devblogs.microsoft.com/visualstudio/improving-visual-studio-performance-with-the-new-instrumentation-tool/)
- [Case Study: Double performance in under 30 minutes](https://devblogs.microsoft.com/visualstudio/case-study-double-performance-in-under-30-minutes/)

## Related content

- [First look at profiling](../profiling/choose-performance-tool.md)
- [Which tool should I use?](../profiling/choose-performance-tool.md)
