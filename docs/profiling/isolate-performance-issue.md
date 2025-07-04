---
title: "Isolate a performance issue"
description: "Learn how to use .NET Counters and the Instrumentation tools to identify, isolate, and resolve performance issues."
ms.date: 7/3/2025
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
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
---

# Case study: Isolate a performance issue (C#, Visual Basic, F#)

This case study demonstrates how to use Visual Studio profiling tools to identify and resolve performance issues in a sample ASP.NET application. For a comparison of profiling tools, see [Which tool should I choose?](../profiling/choose-performance-tool.md)

You'll learn:

- How to use Visual Studio profiling tools to analyze application performance.
- How to interpret profiling data to find bottlenecks.
- Practical strategies for optimizing code using .NET Counters, call counts, and timing data.

Apply these techniques to improve your own applications.

## Isolate a performance issue case study

The sample ASP.NET app runs queries against a simulated database and is based on the [Diagnostics Sample](/dotnet/core/diagnostics/debug-threadpool-starvation).

Key performance symptoms:

- **Low CPU Usage**: The CPU is not the bottleneck.
- **High ThreadPool Thread Count**: Thread count rises steadily, indicating thread pool starvation.
- **Slow Application Response**: The app responds slowly due to a lack of available threads.

This case study uses Visual Studio profiling tools to pinpoint and address these issues, helping you make your code faster and more efficient.

## Challenge

Fixing these issues involves several challenges:

- **Diagnosing Bottlenecks**: Low CPU usage with slow performance can have multiple causes. Effective use of profiling tools and interpreting their output is essential.
- **Knowledge and Resource Constraints**: Profiling and optimization require specific skills and experience, which may not always be available.

A strategic approach combining profiling tools, technical knowledge, and careful testing is key to overcoming these challenges.

## Strategy

Here is a high-level view of the approach in this case study:

- Start by monitoring .NET counter metrics while collecting performance data. Visual Studio's [.NET Counters](../profiling/dotnet-counters-tool.md) tool is a good starting point.
- For deeper insights, collect traces with additional profiling tools, such as the [Instrumentation](../profiling/instrumentation.md) tool for call counts and timing data.

Data collection requires the following tasks:

- Set the app to Release build.
- Select the .NET Counters tool in Performance Profiler (**Alt+F2**).
- Start the app and collect a trace.

## Check performance counters

While running the app, we observe the counters in the .NET Counters tool. For initial investigations, a few key metrics to keep an eye on include:

- `CPU Usage`. Watch this counter to see whether a performance issue occurs with high or low CPU usage. This can be a clue to specific types of performance issues. For example:
  - With high CPU usage, use the CPU Usage tool to identify areas where we may be able to optimize code. For a tutorial on this, see [Case study: Beginner's guide to optimizing code](../profiling/optimize-code-using-profiling-tools.md).
  - With low CPU usage, use the Instrumentation tool to identify call counts and average function time based on wall clock time. This may help identify issues such as contention or thread pool starvation.
- `Allocation Rate`. For a web app serving requests, the rate should be fairly steady.
- `GC Heap Size`. Watch this counter to see if memory usage is growing continually and potentially leaking. If it seems high, use one of the memory usage tools.
- `Threadpool Thread Count`. For a web app serving requests, watch this counter to see if the thread count is holding steady or rising at a steady rate.

Here's an example showing how the `CPU Usage` is low, while the `ThreadPool Thread Count` is relatively high.

:::image type="content" source="./media/vs-2022/instrumentation-threadpool-starvation-counters.png" alt-text="Screenshot of counters showing in the .NET Counters tool.":::

A steadily rising thread count with a low CPU usage can be an indicator of thread pool starvation. The thread pool is forced to keep spinning new threads. Thread pool starvation occurs when the pool has no available threads to process new work items and it often causes applications to respond slowly. 

Based on the low CPU usage and the relatively high thread count, and working on the theory of a possible case of thread pool starvation, switch to using the Instrumentation tool.

## Investigate call counts and timing data

Let's take a look at a trace from the Instrumentation tool to see if we can try to find out more about what is happening with the threads.

After collecting a trace with the Instrumentation tool and loading it into Visual Studio, we first check the initial *.diagsession* report page that shows summarized data. In the collected trace, we use the **Open details** link in the report and then select **Flame Graph**.

:::image type="content" source="./media/vs-2022/instrumentation-threadpool-starvation-flame-graph.png" alt-text="Screenshot of Flame Graph in the Instrumentation tool.":::

The Flame Graph visualization shows us that the `QueryCustomerDB` function (shown in yellow) is responsible for a significant portion of the app's running time.

Right-click the `QueryCustomerDB` function and choose **View in Call Tree**.

:::image type="content" source="./media/vs-2022/instrumentation-threadpool-starvation-call-tree.png" alt-text="Screenshot of Call Tree in the Instrumentation tool." lightbox="media/vs-2022/instrumentation-threadpool-starvation-call-tree.png":::

The code path with highest CPU usage in the app is called the *hot path*. The hot path flame icon (![Screenshot that shows Hot Path icon.](../profiling/media/optimize-code-hot-path-icon.png)) can help to quickly identify performance issues that might be improved.

In the **Call Tree** view, you can see that the hot path includes the `QueryCustomerDB` function, which points to a potential performance issue.

Relative to time spent in other functions, the **Self** and **Avg Self** values for the `QueryCustomerDB` function are very high. Unlike **Total** and **Avg Total**, the **Self** values exclude time spent in other functions, so this is a good place to look for the performance bottleneck.

> [!TIP]
> If the **Self** values were relatively low instead of high, you would probably want to look at the actual queries called by the `QueryCustomerDB` function.

Double-click the `QueryCustomerDB` function to show the source code for the function. 

```csharp
public ActionResult<string> QueryCustomerDB()
{
    Customer c = QueryCustomerFromDbAsync("Dana").Result;
    return "success:taskwait";
}
```

We do a little research. Alternatively, we can save time and let [Copilot](../ide/visual-studio-github-copilot-extension.md) do the research for us.

If we're using [Copilot](../ide/visual-studio-github-copilot-extension.md), select **Ask Copilot** from the context menu and type the following question:

```cmd
Can you identify a performance issue in the QueryCustomerDB method?
```

> [!TIP]
> You can use slash commands such as [/optimize](../ide/copilot-chat-context.md#slash-commands) to help form good questions for Copilot.

Copilot tells us that this code is calling an async API without using await. This is the [sync-over-async](https://devblogs.microsoft.com/pfxteam/should-i-expose-synchronous-wrappers-for-asynchronous-methods/) code pattern, which is a common cause of threadpool starvation, and may block threads.

To resolve, use await. In this example, Copilot gives the following code suggestion along with the explanation.

```csharp
public async Task<ActionResult<string>> QueryCustomerDB()
{
    Customer c = await QueryCustomerFromDbAsync("Dana");
    return "success:taskwait";
}
```

If you see performance issues related to database queries, you can use the [Database tool](../profiling/analyze-database.md) to investigate whether certain calls are slower. This data might indicate an opportunity to optimize queries. For a tutorial that shows how to use the Database tool to investigate a performance issue, see [Case study: Beginner's guide to optimizing code](../profiling/optimize-code-using-profiling-tools.md). The Database tool supports .NET Core with either ADO.NET or Entity Framework Core.

To get visualizations in Visual Studio for individual thread behavior, you can use the [Parallel Stacks](../debugger/get-started-debugging-multithreaded-apps.md#ParallelStacks) window while debugging. This window shows individual threads along with information about threads that are waiting, threads they're waiting on, and [deadlocks](../debugger/using-the-parallel-stacks-window.md#stack-frame-icons).

For additional information on thread pool starvation, see [Detecting threadpool starvation](/dotnet/core/diagnostics/debug-threadpool-starvation#detecting-threadpool-starvation).

## Next steps

The following articles and blog posts provide more information to help you learn to use the Visual Studio performance tools effectively.

- [Case study: Beginner's guide to optimizing code](../profiling/optimize-code-using-profiling-tools.md)
- [Case Study: Double performance in under 30 minutes](https://devblogs.microsoft.com/visualstudio/case-study-double-performance-in-under-30-minutes/)
- [Improving Visual Studio performance with the new Instrumentation Tool](https://devblogs.microsoft.com/visualstudio/improving-visual-studio-performance-with-the-new-instrumentation-tool/)

## Related content

- [Which tool should I use?](../profiling/choose-performance-tool.md)
- [Analyze CPU usage in the Performance Profiler](../profiling/cpu-usage.md)
- [Instrument your .NET application](../profiling/instrumentation.md)
- [Analyze database performance](../profiling/analyze-database.md)
- [First look at profiling](../profiling/choose-performance-tool.md)