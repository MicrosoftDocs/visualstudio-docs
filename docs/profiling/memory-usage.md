---
title: "Measure memory usage in your apps"
description: Find memory leaks and inefficient memory while you're debugging with the debugger-integrated diagnostic tool, Memory Usage.
ms.date: 02/06/2024
ms.topic: tutorial
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Measure memory usage in Visual Studio (C#, Visual Basic, C++, F#)

Find memory leaks and inefficient memory while you're debugging with the debugger-integrated **Memory Usage** diagnostic tool. The Memory Usage tool lets you take one or more *snapshots* of the managed and native memory heap to help understand the memory usage impact of object types. You can also analyze memory usage without a debugger attached or by targeting a running app. For more information, see [Run profiling tools on release or debug builds](../profiling/running-profiling-tools-with-or-without-the-debugger.md). For information on choosing the best memory analysis tool for your needs, see [Choose a memory analysis tool](../profiling/analyze-memory-usage.md).

Although you can collect memory snapshots at any time in the **Memory Usage** tool, you can use the Visual Studio debugger to control how your application executes while investigating performance issues. Setting breakpoints, stepping, Break All, and other debugger actions can help you focus your performance investigations on the code paths that are most relevant. Performing those actions while your app is running can eliminate the noise from the code that doesn't interest you and can significantly reduce the amount of time it takes you to diagnose an issue.

> [!Important]
> The debugger-integrated Diagnostics Tools are supported for .NET development in Visual Studio, including ASP.NET, ASP.NET Core, native/C++ development, and mixed mode (.NET and native) apps.

In this tutorial, you will:

> [!div class="checklist"]
> * Take snapshots of memory
> * Analyze memory usage data

If **Memory Usage** does not give you the data that you need, other profiling tools in the [Performance Profiler](../profiling/profiling-feature-tour.md#post_mortem) provide different kinds of information that might be helpful to you. In many cases, the performance bottleneck of your application may be caused by something other than your memory, such as CPU, rendering UI, or network request time.

> [!NOTE]
> **Custom Allocator Support** The native memory profiler works by collecting allocation [ETW](/windows-hardware/drivers/devtest/event-tracing-for-windows--etw-) event data emitted during run time.  Allocators in the CRT and Windows SDK have been annotated at the source level so that their allocation data can be captured. If you are writing your own allocators, then any functions that return a pointer to newly allocated heap memory can be decorated with [__declspec](/cpp/cpp/declspec)(allocator), as seen in this example for myMalloc:
>
> `__declspec(allocator) void* myMalloc(size_t size)`

## Collect memory usage data

1. Open the project you want to debug in Visual Studio and set a breakpoint in your app at the point where you want to begin examining memory usage.

    If you have an area where you suspect a memory issue, set the first breakpoint before the memory issue occurs.

    > [!TIP]
    > Because it can be challenging to capture the memory profile of an operation that interests you when your app frequently allocates and de-allocates memory, set breakpoints at the start and end of the operation (or step through the operation) to find the exact point that memory changed.

2. Set a second breakpoint at the end of the function or region of code that you want to analyze (or after a suspected memory issue occurs).

3. The **Diagnostic Tools** window appears automatically unless you have turned it off. To bring up the window again, click **Debug** > **Windows** > **Show Diagnostic Tools**.

4. Choose **Memory Usage** with the **Select Tools** setting on the toolbar.

     ::: moniker range="<=vs-2019"

     ![Screenshot of Diagnostics Tools.](../profiling/media/vs-2019/diag-tools-select-tool-2.png)

     ::: moniker-end

     ::: moniker range=">=vs-2022"

     ![Screenshot of Diagnostics Tools.](../profiling/media/vs-2022/diag-tools-select-tool-2.png)

     ::: moniker-end

5. Click **Debug / Start Debugging** (or **Start** on the toolbar, or **F5**).

     When the app finishes loading, the Summary view of the Diagnostics Tools appears.

     ::: moniker range="<=vs-2019"

     ![Screenshot of Diagnostics Tools Summary Tab.](../profiling/media/vs-2019/diag-tools-summary-tab-2.png)

     > [!NOTE]
     > Because collecting memory data can affect the debugging performance of your native or mixed-mode apps, memory snapshots are disabled by default. To enable snapshots in native or mixed-mode apps, start a debugging session (Shortcut key: **F5**). When the **Diagnostic Tools** window appears, choose the **Memory Usage** tab, and then choose **Heap Profiling**.
     >
     >  ![Screenshot of Enable snapshots.](../profiling/media/vs-2019/dbgdiag-mem-mixed-toolbar-enable-snapshot.png)
     >
     >  Stop (Shortcut key: **Shift**+**F5**) and restart debugging.

     ::: moniker-end

     ::: moniker range=">=vs-2022"

     ![Screenshot of Diagnostics Tools Summary Tab.](../profiling/media/vs-2022/diag-tools-summary-tab-2.png)

     > [!NOTE]
     > Because collecting memory data can affect the debugging performance of your native or mixed-mode apps, memory snapshots are disabled by default. To enable snapshots in native or mixed-mode apps, start a debugging session (Shortcut key: **F5**). When the **Diagnostic Tools** window appears, choose the **Memory Usage** tab, and then choose **Heap Profiling**.
     >
     >  ![Screenshot of Enable snapshots.](../profiling/media/vs-2022/dbgdiag-mem-mixed-toolbar-enable-snapshot.png)
     >
     >  Stop (Shortcut key: **Shift**+**F5**) and restart debugging.

     ::: moniker-end

6. To take a snapshot at the start of your debugging session, choose **Take snapshot** on the **Memory Usage** summary toolbar. (It may help to set a breakpoint here as well.)

     ::: moniker range="<=vs-2019"
     
     ![Screenshot of Take Snapshot button.](../profiling/media/vs-2019/dbgdiag-mem-mixed-toolbar-take-snapshot.png)

     ::: moniker-end

     ::: moniker range=">=vs-2022"

     ![Screenshot of Take Snapshot button.](../profiling/media/vs-2022/dbgdiag-mem-mixed-toolbar-take-snapshot.png)

     ::: moniker-end

     > [!TIP]
     > To create a baseline for memory comparisons, consider taking a snapshot at the start of your debugging session.

6. Run the scenario that will cause your first breakpoint to be hit.

7. While the debugger is paused at the first breakpoint, choose **Take snapshot** on the **Memory Usage** summary toolbar.

8. Press **F5** to run the app to your second breakpoint.

9. Now, take another snapshot.

   At this point, you can begin to analyze the data.

   If you have trouble collecting or displaying data, see [Troubleshoot profiling errors and fix issues](../profiling/troubleshoot-profiler-errors.md).

## Analyze memory usage data

The rows of the Memory Usage summary table list the snapshots that you have taken during the debugging session and provides links to more detailed views.

::: moniker range="<=vs-2019"
     
![Screenshot of Memory Usage table.](../profiling/media/vs-2019/dbgdiag-mem-summary-table.png)

::: moniker-end

::: moniker range=">=vs-2022"

![Screenshot of Memory Usage table.](../profiling/media/vs-2022/dbgdiag-mem-summary-table.png)

::: moniker-end

 The name of the column depends on the debugging mode you choose in the project properties: .NET, native, or mixed (both .NET and native).

- The **Objects (Diff)** (.NET) or **Allocations (Diff)** (C++) column display the number of objects in .NET or native memory when the snapshot was taken.

- The **Heap Size (Diff)** column displays the number of bytes in the .NET and native heaps

When you have taken multiple snapshots, the cells of the summary table include the change in the value between the row snapshot and the previous snapshot.

To analyze memory usage, click one of the links that opens up a detailed report of memory usage:

- To view details of the difference between the current snapshot and the previous snapshot, choose the change link to the left of the arrow (![Memory Usage Increase](../profiling/media/prof-tour-mem-usage-up-arrow.png "Memory Usage Increase")). A red arrow indicates an increase in memory usage, and a green arrow indicates a decrease.

> [!TIP]
> To help identify memory issues more quickly, the diff reports are sorted by object types that increased the most in overall number (click the change link in **Objects (Diff)** column) or that increased the most in overall heap size (click the change link in **Heap Size (Diff)** column).

- To view details of only the selected snapshot, click the non-change link.

   The report appears in a separate window.

### Managed types reports

[!INCLUDE [managed-types-report](../profiling/includes/managed-types-report.md)]

To display the instances of a selected type in the upper pane, click the **View Instances** icon next to the object type.

::: moniker range=">=vs-2022"

[![Screenshot of the Instances view in the Memory Usage tool.](../profiling/media/vs-2022/dbgdiag-mem-managed-types-report-instances.png "Instances view in the Memory Usage tool")](../profiling/media/vs-2022/dbgdiag-mem-managed-types-report-instances.png#lightbox)

The **Instances** view displays the instances of the selected object in the snapshot in the upper pane. The **Paths to Root** and **Referenced Objects** pane displays the objects that reference the selected instance and the types that the selected instance references. When the debugger is stopped at the point where the snapshot was taken, you can hover over the **Value** cell to display the values of the object in a tool tip.

::: moniker-end

::: moniker range="vs-2019"

![Screenshot of the Instances view in the Memory Usage tool.](../profiling/media/vs-2019/dbgdiag-mem-managed-types-report-instances.png)

The **Instances** view displays the instances of the selected object in the snapshot in the upper pane. The **Paths to Root** and **Referenced Objects** pane displays the objects that reference the selected instance and the types that the selected instance references. When the debugger is stopped at the point where the snapshot was taken, you can hover over the **Value** cell to display the values of the object in a tool tip.

::: moniker-end

### Native types reports

[!INCLUDE [native-types-report](../profiling/includes/native-types-report.md)]

::: moniker range=">=vs-2022"
### Memory Usage Insights

[!INCLUDE [memory-usage-insights](../profiling/includes/memory-usage-insights.md)]
::: moniker-end

### Change (Diff) reports

- Choose the change link in a cell of the summary table of the **Memory Usage** tab on the **Diagnostic Tools** window.

   ::: moniker range="<=vs-2019"

   ![Screenshot of Choose a change link in a cell.](../profiling/media/vs-2019/dbgdiag-mem-choose-diff-report.png)

   ::: moniker-end

   ::: moniker range=">=vs-2022"

   ![Screenshot of Choose a change link in a cell.](../profiling/media/vs-2022/dbgdiag-mem-choose-diff-report.png)

   ::: moniker-end

- Choose a snapshot in the **Compare To** list of a managed or native report.

   ::: moniker range="<=vs-2019"

   ![Screenshot of Choose a snapshot from the Compare To list.](../profiling/media/vs-2019/dbgdiag-mem-choose-compare-to.png)

   ::: moniker-end

   ::: moniker range=">=vs-2022"

   ![Screenshot of Choose a snapshot from the Compare with list.](../profiling/media/vs-2022/dbgdiag-mem-choose-compare-to.png)

   ::: moniker-end

[!INCLUDE [change-diff-report](../profiling/includes/change-diff-report.md)]

## Blogs and videos

[Analyze CPU and Memory While Debugging](https://devblogs.microsoft.com/visualstudio/analyze-cpu-memory-while-debugging/)

[Visual C++ Blog: Memory Profiling in Visual C++ 2015](https://devblogs.microsoft.com/cppblog/memory-profiling-in-visual-c-2015/)

## Next steps

In this tutorial, you've learned how to collect and analyze memory usage data. If you already completed the [tour of the profiler](../profiling/profiling-feature-tour.md), you may want to read about a general approach to optimizing code using the profiling tools.

> [!div class="nextstepaction"]
> [Case study: Beginner's guide to optimizing code](../profiling/optimize-code-using-profiling-tools.md)

In this tutorial, you've learned how to collect and analyze memory usage data while debugging. You may want to find out more about analyzing memory usage in release builds using the Performance Profiler.

> [!div class="nextstepaction"]
> [Analyze memory usage in the Performance Profiler](../profiling/memory-usage-without-debugging2.md)
