---
title: "Measure memory usage in your apps"
description: "Find memory leaks and inefficient memory while you're debugging with the debugger-integrated diagnostic tool."
ms.custom: "seodec18"
ms.date: 04/25/2018
ms.topic: tutorial
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Measure memory usage in Visual Studio

Find memory leaks and inefficient memory while you're debugging with the debugger-integrated **Memory Usage** diagnostic tool. The Memory Usage tool lets you take one or more *snapshots* of the managed and native memory heap to help understand the memory usage impact of object types. You can collect snapshots of .NET, native, or mixed mode (.NET and native) apps.

The following graphic shows the **Diagnostic Tools** window (available in Visual Studio 2015 Update 1 and later versions):

![DiagnosticTools&#45;Update1](../profiling/media/diagnostictools-update1.png "DiagnosticTools-Update1")

Although you can collect memory snapshots at any time in the **Memory Usage** tool, you can use the Visual Studio debugger to control how your application executes while investigating performance issues. Setting breakpoints, stepping, Break All, and other debugger actions can help you focus your performance investigations on the code paths that are most relevant. Performing those actions while your app is running can eliminate the noise from the code that doesn't interest you and can significantly reduce the amount of time it takes you to diagnose an issue.

You can also use the memory tool outside of the debugger. See [Memory Usage without debugging](../profiling/memory-usage-without-debugging2.md). You can use the profiling tools with no debugger attached with Windows 7 and later. Windows 8 and later is required to run profiling tools with the debugger (**Diagnostic Tools** window).

> [!NOTE]
> **Custom Allocator Support** The native memory profiler works by collecting allocation [ETW](/windows-hardware/drivers/devtest/event-tracing-for-windows--etw-) event data emitted during run time.  Allocators in the CRT and Windows SDK have been annotated at the source level so that their allocation data can be captured. If you are writing your own allocators, then any functions that return a pointer to newly allocated heap memory can be decorated with [__declspec](/cpp/cpp/declspec)(allocator), as seen in this example for myMalloc:
>
> `__declspec(allocator) void* myMalloc(size_t size)`

In this tutorial, you will:

> [!div class="checklist"]
> * Take snapshots of memory
> * Analyze memory usage data

## Collect memory usage data

1. Open the project you want to debug in Visual Studio and set a breakpoint in your app at the point where you want to begin examining memory usage.

    If you have an area where you suspect a memory issue, set the first breakpoint before the memory issue occurs.

    > [!TIP]
    > Because it can be challenging to capture the memory profile of an operation that interests you when your app frequently allocates and de-allocates memory, set breakpoints at the start and end of the operation (or step through the operation) to find the exact point that memory changed.

2. Set a second breakpoint at the end of the function or region of code that you want to analyze (or after a suspected memory issue occurs).

3. The **Diagnostic Tools** window appears automatically unless you have turned it off. To bring up the window again, click **Debug** > **Windows** > **Show Diagnostic Tools**.

4. Choose **Memory Usage** with the **Select Tools** setting on the toolbar.

     ![Show Diagnostics Tools](../profiling/media/diag-tools-select-tool-2.png "DiagToolsSelectTool")

5. Click **Debug / Start Debugging** (or **Start** on the toolbar, or **F5**).

     When the app finishes loading, the Summary view of the Diagnostics Tools appears.

     ![Diagnostics Tools Summary Tab](../profiling/media/diag-tools-summary-tab-2.png "DiagToolsSummaryTab")

     > [!NOTE]
     > Because collecting memory data can affect the debugging performance of your native or mixed-mode apps, memory snapshots are disabled by default. To enable snapshots in native or mixed-mode apps, start a debugging session (Shortcut key: **F5**). When the **Diagnostic Tools** window appears, choose the **Memory Usage** tab, and then choose **Heap Profiling**.
     >
     >  ![Enable snapshots](../profiling/media/dbgdiag_mem_mixedtoolbar_enablesnapshot.png "DBGDIAG_MEM_MixedToolbar_EnableSnapshot")
     >
     >  Stop (Shortcut key: **Shift**+**F5**) and restart debugging.

6. To take a snapshot at the start of your debugging session, choose **Take snapshot** on the **Memory Usage** summary toolbar. (It may help to set a breakpoint here as well.)

    ![Take snapshot](../profiling/media/dbgdiag_mem_mixedtoolbar_takesnapshot.png "DBGDIAG_MEM_MixedToolbar_TakeSnapshot")

     > [!TIP]
     > To create a baseline for memory comparisons, consider taking a snapshot at the start of your debugging session.

6. Run the scenario that will cause your first breakpoint to be hit.

7. While the debugger is paused at the first breakpoint, choose **Take snapshot** on the **Memory Usage** summary toolbar.

8. Press **F5** to run the app to your second breakpoint.

9. Now, take another snapshot.

     At this point, you can begin to analyze the data.

## Analyze memory usage data
The rows of Memory Usage summary table lists the snapshots that you have taken during the debugging session and provides links to more detailed views.

![Memory summary table](../profiling/media/dbgdiag_mem_summarytable.png "DBGDIAG_MEM_SummaryTable")

 The name of the columns depend on the debugging mode you choose in the project properties: .NET, native, or mixed (both .NET and native).

- The **Objects (Diff)** and **Allocations (Diff)** columns display the number of objects in .NET and native memory when the snapshot was taken.

- The **Heap Size (Diff)** column displays the number of bytes in the .NET and native heaps

When you have taken multiple snapshots, the cells of the summary table include the change in the value between the row snapshot and the previous snapshot.

To analyze memory usage, click one of the links that opens up a detailed report of memory usage:

- To view details of the difference between the current snapshot and the previous snapshot, choose the change link to the left of the arrow (![Memory Usage Increase](../profiling/media/prof-tour-mem-usage-up-arrow.png "Memory Usage Increase")). A red arrow indicates an increase in memory usage, and a green arrow to indicates a decrease.

> [!TIP]
> To help identify memory issues more quickly, the diff reports are sorted by object types that increased the most in overall number (click the change link in **Objects (Diff)** column) or that increased the most in overall heap size (click the change link in **Heap Size (Diff)** column).

- To view details of only the selected snapshot, click the non-change link.

   The report appears in a separate window.

### Managed types reports
 Choose the current link of a **Objects (Diff)** or **Allocations (Diff)** cell in the Memory Usage summary table.

 ![Debugger managed type report &#45; Paths to Root](../profiling/media/dbgdiag_mem_managedtypesreport_pathstoroot.png "DBGDIAG_MEM_ManagedTypesReport_PathsToRoot")

 The top pane shows the count and size of the types in the snapshot, including the size of all objects that are referenced by the type (**Inclusive Size**).

 The **Paths to Root** tree in the bottom pane displays the objects that reference the type selected in the upper pane. The .NET Framework garbage collector cleans up the memory for an object only when the last type that references it has been released.

 The **Referenced Types** tree displays the references that are held by the type selected in the upper pane.

 ![Managed referenced types report view](../profiling/media/dbgdiag_mem_managedtypesreport_referencedtypes.png "DBGDIAG_MEM_ManagedTypesReport_ReferencedTypes")

 To display the instances of a selected type in the upper pane, choose the ![Instance icon](../profiling/media/dbgdiag_mem_instanceicon.png "DBGDIAG_MEM_InstanceIcon") icon.

 ![Instances view](../profiling/media/dbgdiag_mem_managedtypesreport_instances.png "DBGDIAG_MEM_ManagedTypesReport_Instances")

 The **Instances** view displays the instances of the selected object in the snapshot in the upper pane. The **Paths to Root** and **Referenced Objects** pane displays the objects that reference the selected instance and the types that the selected instance references. When the debugger is stopped at the point where the snapshot was taken, you can hover over the **Value** cell to display the values of the object in a tool tip.

### Native type reports
 Choose the current link of a **Allocations (Diff)** or **Heap Size (Diff)** cell in the Memory Usage summary table of the **Diagnostic Tools** window.

 ![Native Type View](../profiling/media/dbgdiag_mem_native_typesview.png "DBGDIAG_MEM_Native_TypesView")

 The **Types View** displays the number and size of the types in the snapshot.

- Choose the instances icon (![The instance icon in the Object Type column](../profiling/media/dbg_mma_instancesicon.png "DBG_MMA_InstancesIcon")) of a selected type to display information about the objects of the selected type in the snapshot.

     The **Instances** view displays each instance of the selected type. Selecting an instance displays the call stack that resulted in the creation of the instance in the **Allocation Call Stack** pane.

     ![Instances view](../profiling/media/dbgdiag_mem_native_instances.png "DBGDIAG_MEM_Native_Instances")

- Choose **Stacks View** in the **View Mode** list to see the allocation stack for the selected type.

     ![Stacks View](../profiling/media/dbgdiag_mem_native_stacksview.png "DBGDIAG_MEM_Native_StacksView")

### Change (Diff) reports

- Choose the change link in a cell of the summary table of the **Memory Usage** tab on the **Diagnostic Tools** window.

   ![Choose a change &#40;diff&#41; report](../profiling/media/dbgdiag_mem_choosediffreport.png "DBGDIAG_MEM_ChooseDiffReport")

- Choose a snapshot in the **Compare To** list of a managed or native report.

   ![Choose a snapshot from the Compare To list](../profiling/media/dbgdiag_mem_choosecompareto.png "DBGDIAG_MEM_ChooseCompareTo")

The change report adds columns (marked with **(Diff)**) to the base report that show the difference between the base snapshot value and the comparison snapshot. Here's how a Native Type View diff report might look:

![Native Types Diff View](../profiling/media/dbgdiag_mem_native_typesviewdiff.png "DBGDIAG_MEM_Native_TypesViewDiff")

## Blogs and videos

[Analyze CPU and Memory While Debugging](https://devblogs.microsoft.com/visualstudio/analyze-cpu-memory-while-debugging/)

[Visual C++ Blog: Memory Profiling in Visual C++ 2015](https://devblogs.microsoft.com/cppblog/memory-profiling-in-visual-c-2015/)

## Next steps

In this tutorial, you've learned how to collect and analyze memory usage data. If you already completed the [tour of the profiler](../profiling/profiling-feature-tour.md), you may want to get a quick look at how to analyze CPU usage in your apps.

> [!div class="nextstepaction"]
> [Analyze CPU usage](../profiling/beginners-guide-to-performance-profiling.md)
