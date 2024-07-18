---
title: "Instrument your .NET application"
description: Explore how to use the dynamic Instrumentation tool for your .NET applications (C#, C++, Visual Basic, F#) in Visual Studio and analyze the report.
ms.date: "07/18/2024"
ms.topic: "conceptual"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
monikerRange: '>= vs-2022'
---

# Instrument your .NET application in Visual Studio (C#, C++, Visual Basic, F#)

With the release of Visual Studio 2022 version 17.5, you can use the new dynamic Instrumentation tool. This tool shows the exact number of times your functions are called and is faster than the previous version of the Instrumentation tool. This tool supports .NET Core instrumentation without needing PDBs.
Starting in Visual Studio 2022 version 17.6 Preview 2, the tool also supports C/C++.

The tool is similar to the CPU Usage tool except it's based on wall clock time instead of CPU utilization. For additional information on learning to use the Instrumentation tool effectively, see [Instrumentation Overview](../profiling/instrumentation-overview.md) and [Improving Visual Studio performance with the new Instrumentation Tool](https://devblogs.microsoft.com/visualstudio/improving-visual-studio-performance-with-the-new-instrumentation-tool/).

## Instrument your application

1. Select **Alt+F2** (or **Debug > Performance Profiler**) to open the performance profiler in Visual Studio.

1. Select the **Instrumentation** check box.

   ![Screenshot showing Instrumentation tool selected.](./media/vs-2022/instrumentation-tool-launch.png "Instrumentation tool selected")

    If you enable the **Start with collection paused** option before starting the profiler, data won't be collected until you select the **Record** button in the diagnostic session view.

   > [!NOTE]
   > If the tool isn't available for selection, clear every other tool's check box because some tools need to run alone. To learn more about running tools together, see [Using multiple profiler tools simultaneously](../profiling/use-multiple-profiler-tools-simultaneously.md).
   >
   > If the tool still isn't available, check that your project meets the preceding requirements. Make sure your project is in Release mode to capture the most accurate data.

1. Select the **Start** button to run the tool.

1. Select the items in your program to instrument.

   ![Screenshot showing Select items to instrument dialog.](./media/vs-2022/instrumentation-select-items-to-instrument.png "Screenshot showing Select items to instrument dialog.")

   Starting in Visual Studio 2022 version 17.11 Preview 1, the profiler persists the selected items for the next profiling run.

1. Select **OK**.

1. After the tool starts running, go through the scenario you want to profile in your app. Then select **Stop collection** or close the app to see your data.

## Analyze the Instrumentation report

Your profiling data appears in Visual Studio.

![Screenshot showing .NET Instrumentation data.](./media/vs-2022/instrumentation-data.png "Instrumentation data")

The Instrumentation data view shows you a list of functions ordered by longest running, with the longest running function at the top under **Top Functions**. The **Hot Path** section shows you the call stack for the functions that are using the most time. These lists can help guide you to functions where performance bottlenecks are happening.

Click on a function that you're interested in, and you see a more detailed view.

The information available is similar to the CPU Usage tool, except that it's based on wall clock time and call counts instead of CPU utilization. This means blocked time such as time spent waiting for locks will show up in the instrumentation trace, unlike the CPU Usage tool. For detailed information on the views, see [Analyze performance by using CPU profiling](../profiling/cpu-usage.md).

## Related content

- [Instrumentation](../profiling/instrumentation.md)
- [First look at profiling tools](../profiling/profiling-feature-tour.md)
