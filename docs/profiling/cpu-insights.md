---
title: Diagnose high latency with CPU Insights
description: Use CPU Insights to diagnose and optimize your code's performance
ms.date: 01/27/2025
ms.update-cycle: 180-days
ms.topic: how-to
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
---

# Diagnose high latency with CPU Insights

CPU insights is a sub-feature of the CPU Usage tool that shows common potential latency issues like concatenating strings inefficiently.

## View Auto Insights

The **Top Insights** section in the CPU Usage tool shows quick CPU details, insights, and suggestions in the description so that you can continue diagnosing the issue. The **Learn more** link shows you in-depth documentation that explains your issue. If you need more information, **View source code** shows more details. Once selected, you can see the call tree view, showing the process, functions, and which callers use the most CPU.

![Screenshot showing Auto Insights selected.](./media/vs-2022/top-insights.png)

## View top functions

On the summary page under **Top Functions**, you can find the top functions called with the time spent in descending order. **Total CPU** time is the amount of time spent inside a function, including any functions it calls, whereas **Self CPU** is time spent exclusively in the function.

![Screenshot showing Top Functions selected.](./media/vs-2022/top-functions.png)

## View the hot path

**Hot Path** shows where most of the CPU time was being spent in your application and helps focus investigation on the area that would have the most impact. Analyzing this code path by using other tools in the Performance Profiler can help identify ways to improve the code as well. For example, it may help identify how to minimize allocations on the hot path to reduce GC frequency and time spent in GC.

![Screenshot showing Hot Path selected.](./media/vs-2022/hot-path.png "Hot Path selected")

::: moniker range=">= vs-2022"
## Get AI assistance

If you have [Copilot](../ide/visual-studio-github-copilot-extension.md), you can get AI assistance while you're looking at CPU Auto Insights. Copilot provides information and insights related to a set of specific performance insights. With Copilot, you can also ask questions about functions on the identified hot paths in your code, which can help you produce more efficient or cost-effective code.

The **Ask Copilot** button [Screenshot of Ask Copilot button.](../debugger/media/vs-2022/debug-with-copilot-ask-copilot-button.png) appears even if no specific performance insights are identified. Select **Ask Copilot** to learn from Copilot and start asking questions. 

[ ![Animation of using Copilot with CPU Usage.](../debugger/media/vs-2022/debug-with-copilot-top-insights.gif) ](../debugger/media/vs-2022/debug-with-copilot-top-insights.gif#lightbox)
::: moniker-end

## Related content

- [Analyze performance by using CPU profiling](../profiling/cpu-usage.md)
- [Identify hot paths with Flame Graph](../profiling/flame-graph.md)
- [Troubleshoot Profiler errors](../profiling/troubleshoot-profiler-errors.md)