---
title: "Run profiling tools on release or debug builds"
description: Explore the differences between running profiling tools for your applications in Visual Studio on release or debug builds.
ms.date: "01/07/2025"
ms.topic: "conceptual"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Run profiling tools on release or debug builds (C#, Visual Basic, C++, F#)

Visual Studio offers a choice of performance measurement and profiling tools. Some tools, like CPU Usage and Memory Usage, can run either on release builds or while debugging your app (debug build). Tools that appear in the [Diagnostics Tools window](../profiling/profiling-feature-tour.md#measure-performance-while-debugging) run only during a debugging session. Tools that appear in the [Performance Profiler](../profiling/profiling-feature-tour.md#post_mortem) run without the debugger, typically on release builds, and you analyze the results after you choose to stop and collect data (for post-mortem analysis).

The Performance Profiler and the debugger-integrated Diagnostic Tools provide different information and experiences. While using the Diagnostic Tools, the debugger shows you variable values and lets you use breakpoints.

Release build performance numbers in the Performance Profiler are the most precise and accurate. These tools give you results closer to the end-user experience. Typically, this is the preferred method for using the profiling tools. However, there may be scenarios where using the debugger in a debug build may help to narrow down the performance problem, especially if you want to use debugger features such as breakpoints and code stepping.

To help you decide between using the profiling tools in release or debug builds, consider the following:

  - Release builds provide optimizations like inlining function calls and constants, pruning unused code paths, and storing variables in ways that can't be used by the debugger. Performance numbers in debug builds are less accurate, because debug builds lack these optimizations.
  - In addition to differences between release builds and debug builds, the debugger itself changes performance times, as it does necessary debugger operations like intercepting exception and module load events.
  - For performance problems caused by CPU-intensive calls, there might be considerable performance differences between release and debug builds. Check to see whether the CPU performance issue exists in release builds.
  - External performance problems, like file I/O or network responsiveness issues, won't look much different in a release build or a debug build.
  - If the problem occurs only with debug builds, you probably don't need to run the tools with release builds.
  - Some tools, such as the .NET Object Allocation tool, are only available in the Performance Profiler (non-debugger scenarios).

## Collect profiling data on release builds

To collect performance data on release builds, run the Performance Profiler tools.

1. With a project open in Visual Studio, set the solution configuration to **Release**, and select **Local Windows Debugger** (or **Local Machine**) as the deployment target.

1. Select **Debug** > **Performance Profiler**, or press **Alt**+**F2**.

1. On the diagnostic tools launch page, select one or more tools to run. Only the tools that are applicable to the project type, operating system, and programming language are shown. Select **Show all tools** to also see tools that are disabled for this diagnostic session.

   ::: moniker range="visualstudio"
   ![Screenshot of Performance Profiler.](../profiling/media/vs/prof-tour-performance-profiler.png "Performance Profiler")
   ::: moniker-end
   ::: moniker range=">=vs-2022"
   ![Screenshot of diagnostic tools.](../profiling/media/vs-2022/performance-profiler-summary-page.png "DIAG_SelectTool")
   ::: moniker-end
   ::: moniker range="<=vs-2019"
   ![Screenshot of diagnostic tools.](../profiling/media/diaghubsummarypage.png "DIAG_SelectTool")
   ::: moniker-end

1. To start the diagnostic session, select **Start**.

   While the session is running, some tools show graphs of real-time data on the diagnostic tools page, and might show options to pause and resume data collection.

   ::: moniker range=">=vs-2022"
   ![Screenshot of data collection on the Performance Profiler.](../profiling/media/vs-2022/performance-profiler-collect-data.png "Diag collect data")
   ::: moniker-end
   ::: moniker range="<=vs-2019"
   ![Screenshot of data collection on the Performance Profiler.](../profiling/media/diaghubcollectdata.png "Hub collect data")
   ::: moniker-end

1. To end the diagnostic session, select **Stop Collection**.

   The analyzed data appears on the **Report** page.

   For more information about the tools available for use in release builds and how to analyze the reports, see:

   - [Analyze performance by using CPU profiling](../profiling/cpu-usage.md)
   - [Analyze memory usage](../profiling/memory-usage-without-debugging2.md)
   - [Analyze memory usage for .NET code](../profiling/dotnet-alloc-tool.md)
   - [Analyze instrumentation data](../profiling/instrumentation.md)
   - [Analyze .NET Counters](../profiling/dotnet-counters-tool.md)
   - [Analyze performance of .NET asynchronous code](../profiling/analyze-async.md)
   - [Analyze database performance](../profiling/analyze-database.md)
   - [View events](../profiling/events-viewer.md)
   - [Analyze GPU usage](../profiling/gpu-usage.md)

   >[!NOTE]
   > Use relaunch to skip the launch page and automatically run with your previous settings with **Alt+F2** or by clicking **Debug > Performance Profiler**.

1. (Optional) Save the report, and then you can open it later from the **Recently Opened Sessions** list on the Diagnostic Tools launch page.

   ::: moniker range=">=vs-2022"
   ![Screenshot of Diagnostic Tools Recently Opened Sessions list.](../profiling/media/vs-2022/performance-profiler-open-existing-diagnostics-session.png "PDHUB_OpenExistingDiagSession")
   ::: moniker-end
   ::: moniker range="<=vs-2019"
   ![Screenshot of Diagnostic Tools Recently Opened Sessions list.](../profiling/media/diaghubopenexistingdiagsession.png "PDHUB_OpenExistingDiagSession")
   ::: moniker-end

## <a name="BKMK_Quick_start__Collect_diagnostic_data"></a> Collect profiling data while debugging

::: moniker range=">=vs-2022"
When you start debugging in Visual Studio by selecting **Debug** > **Start Debugging**, or pressing **F5**, the **Diagnostic Tools** window appears by default. To open it manually, select **Debug** > **Windows** > **Show Diagnostic Tools**. The **Diagnostic Tools** window shows information about events, process memory, CPU usage, and .NET Counters.

![Screenshot of the Diagnostic Tools window.](../profiling/media/vs-2022/diagnostic-tools-window.png "Diagnostic Tools Window")

- Use the **Settings** icon in the toolbar to select whether to view **CPU Usage**, **Memory Usage**, or **.NET Counters**.
::: moniker-end
::: moniker range="<=vs-2019"
When you start debugging in Visual Studio by selecting **Debug** > **Start Debugging**, or pressing **F5**, the **Diagnostic Tools** window appears by default. To open it manually, select **Debug** > **Windows** > **Show Diagnostic Tools**. The **Diagnostic Tools** window shows information about events, process memory, and CPU usage.

![Screenshot of the Diagnostic Tools window](../profiling/media/diagnostictoolswindow.png "Diagnostic Tools Window")

- Use the **Settings** icon in the toolbar to select whether to view **CPU Usage**, **Memory Usage**, or **UI Analysis**.
::: moniker-end

- Select **Settings** in the **Settings** drop-down list to open the **Diagnostic Tools Property Pages** with more options.

- If you're running Visual Studio Enterprise, you can enable or disable IntelliTrace by going to **Tools** > **Options** > **IntelliTrace**.

The diagnostic session ends when you stop debugging.

For more information about the tools available while debugging, see:

- [Measure application performance by analyzing CPU usage](../profiling/beginners-guide-to-performance-profiling.md)
- [Measure memory usage in Visual Studio](../profiling/memory-usage.md)
- [Analyze .NET Counters](../profiling/dotnet-counters-tool.md)

### Events tab

During a debugging session, the Events tab of the Diagnostic Tools window lists the diagnostic events that occur. The category prefixes *Breakpoint*, *File*, and others, let you quickly scan the list for a category, or skip the categories you don't care about.

Use the **Filter** drop-down list to filter events in and out of view, by selecting or clearing specific categories of events.

::: moniker range=">=vs-2022"
![Screenshot of Diagnostic Event filter.](../profiling/media/vs-2022/diagnostic-event-filter.png "Diagnostic Event Filter")
::: moniker-end
::: moniker range="<=vs-2019"
![Screenshot of Diagnostic Event filter](../profiling/media/diagnosticeventfilter.png "Diagnostic Event Filter")
::: moniker-end

::: moniker range=">=vs-2022"
Use the search box to find a specific string in the event list. Here are the results of a search for the file name *model* that matched three events:

![Screenshot of Diagnostic Event search.](../profiling/media/vs-2022/diagnostics-event-search.png "Diagnostic Event Search")
::: moniker-end
::: moniker range="<=vs-2019"
Use the search box to find a specific string in the event list. Here are the results of a search for the string *name* that matched four events:

![Screenshot of Diagnostic Event search](../profiling/media/diagnosticseventsearch.png "Diagnostic Event Search")
::: moniker-end

For more information, see [Searching and filtering the Events tab of the Diagnostic Tools window](https://devblogs.microsoft.com/devops/searching-and-filtering-the-events-tab-of-the-diagnostic-tools-window/).

## Collect profiling data from the command line

To measure performance data from the command line, you can use VSDiagnostics.exe, which is included with either Visual Studio or the Remote Tools. This is useful for capturing performance traces on systems where Visual Studio isn't installed, or for scripting the collection of performance traces. For detailed instructions, see [Measure application performance from the command line](../profiling/profile-apps-from-command-line.md).