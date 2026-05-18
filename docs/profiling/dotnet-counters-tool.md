---
title: "Visualize dotnet counters"
description: Use the .NET Counters tool in the Visual Studio Performance Profiler to visualize dotnet counters over time and better understand your data.
ms.date: 05/15/2026
ms.topic: how-to
helpviewer_keywords:
  - "dotnet, counters, profiling"
author: MikeJo5000
ms.author: mikejo
ms.manager:  AndSter
ms.subservice: debug-diagnostics
---
# Visualize dotnet counters from the Visual Studio profiler

The .NET Counters tool allows you to visualize [dotnet counters](/dotnet/core/diagnostics/dotnet-counters) over time right from within the Visual Studio profiler.

> [!NOTE]
> The .NET Counters tool requires Visual Studio 2019 version 16.7 or later and targets .NET Core 3.0+ and .NET 5+.

For additional information on learning to use the .NET Counters tool effectively, see [Case study: Isolate a performance issue](../profiling/isolate-performance-issue.md).

## Setup

1. In the Visual Studio project, set the solution configuration to **Release** and select the deployment target.

   ::: moniker range=">=vs-2022"
   The deployment target typically matches the project name, indicating a local deployment.
   ::: moniker-end


1. Open the Performance Profiler (**Alt + F2** or **Debug -> Performance Profiler**) in Visual Studio.

1. Select the **.NET Counters** check box.

   ::: moniker range="visualstudio"

   :::image type="content" source="media/visualstudio/dotnet-counters-tool-selected.png" alt-text="Screenshot of the Counters tool in Visual Studio selected.":::

   ::: moniker-end

   ::: moniker range="vs-2022"

   :::image type="content" source="media/dotnet-counters-tool-selected.png" alt-text="Screenshot of the Counters tool selected.":::

   ::: moniker-end

1. Click the **Start** button to run the tool.

For more information on how to optimize tool performance, see [Optimizing Profiler settings](../profiling/optimize-profiler-settings.md).

## Understand your data

While the tool is initially collecting data, you can see the live values of [dotnet counters](/dotnet/core/diagnostics/dotnet-counters).

::: moniker range="visualstudio"

:::image type="content" source="media/visualstudio/dotnet-counters-tool-collecting.png" alt-text="Screenshot of the live values collected by the dotnet Counter tool in Visual Studio.":::

::: moniker-end

::: moniker range="vs-2022"

:::image type="content" source="media/dotnet-counters-tool-collecting.png" alt-text="Screenshot of the dotnet Counter tool collecting data.":::

::: moniker-end

You can also view graphs of the counters by selecting the checkbox next to the counter names. You can display the graphs of multiple counters at a time.

Once you are done exercising your app and collecting data, you can stop collection for an even more detailed report. To do this, press the **Stop Collection** button.

Once the report loads, you should see a finalized report similar to the one shown below.

::: moniker range="visualstudio"

:::image type="content" source="media/visualstudio/dotnet-counters-tool-report.png" alt-text="Screenshot of the Counter tool final report in Visual Studio.":::

::: moniker-end

::: moniker range="vs-2022"

:::image type="content" source="media/dotnet-counters-tool-report.png" alt-text="Screenshot of the Counter tool final report.":::

::: moniker-end

The report shows you the following values:

- Min - The minimum value for that counter in the selected time range.
- Max - The maximum value for that counter in the selected time range.
- Average - The average value for that counter in the selected time range.

You can filter or add columns in the table by right clicking the column headings and selecting a heading.

::: moniker range="visualstudio"

:::image type="content" source="media/visualstudio/dotnet-counters-tool-columns.png" alt-text="Screenshot of the Counter tool columns in Visual Studio.":::

::: moniker-end

::: moniker range="vs-2022"

:::image type="content" source="media/dotnet-counters-tool-columns.png" alt-text="Screenshot of the Counter tool columns.":::

::: moniker-end

You can also view graphs in the detailed report by selecting the checkboxes next to counters. The data in the tables represents the values of the entire duration of your collected trace by default. To filter down the data to a specific time range, click and drag on the graphs.

::: moniker range="visualstudio"

:::image type="content" source="media/visualstudio/dotnet-counters-tool-time-filtering.png" alt-text="Screenshot of the Counter tool time filtering in Visual Studio.":::

::: moniker-end

::: moniker range="vs-2022"

:::image type="content" source="media/dotnet-counters-tool-time-filtering.png" alt-text="Screenshot of the Counter tool time filtering.":::

::: moniker-end

The table updates to relevant values for the time selected in the graphs. Use the **Clear Selection** button to reset the selected time range to the entire trace.

::: moniker range=">=vs-2022"
## View .NET Meter counter data

Starting in Visual Studio 2022 version 17.8, .NET Counters tool supports integration with the .NET <xref:System.Diagnostics.Metrics.Meter> API, adding support for instrument options such as `Counter` and `ObservableCounter`.

The `Counter` keeps track of a value changing over time, with the caller reporting updates using `Counter.Add`. In contrast, `ObservableCounter` is similar to `Counter`, but the caller takes care of keeping track of the total value. The .NET Counters tool reports the rate of change in the total.

For more information, see [Creating Metrics](/dotnet/core/diagnostics/metrics-instrumentation).

## View .NET Meter histogram data

Starting in Visual Studio 2022 version 17.12 Preview 2, .NET Counters tool supports .NET <xref:System.Diagnostics.Metrics.Meter> Histogram integration.

The .NET Meter Histogram allows you to identify and analyze histogram data generated by .NET histogram instruments, recorded using `CreateHistogram`. When recording data using the histogram instrument, results are visualized, providing a clear representation of data distribution.

Live histogram data is shown with the rest of the counters, under the name of the Meter instance.

To open the histogram graph, select the instrument name for the Meter instance, as shown here.

:::image type="content" source="../profiling/media/vs-2022/dotnet-counters-meter-histogram.gif" alt-text=".NET Counters meter histogram data.":::

In the preceding example, the tool shows data for the 50th, 90th, and 95th percentiles of the recorded measurements.
::: moniker-end

## Related content

- [Optimizing Profiler settings](../profiling/optimize-profiler-settings.md)
- [dotnet counters](/dotnet/core/diagnostics/dotnet-counters)
- [Identify hot paths with Flame Graph](../profiling/flame-graph.md)
- [Analyze performance by using CPU profiling](../profiling/cpu-usage.md)
