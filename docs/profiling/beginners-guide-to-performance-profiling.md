---
title: "Measure CPU usage in your apps"
description: "Analyze CPU performance issues in your application using the debugger-integrated diagnostics tools."
ms.custom: "seodec18"
ms.date: 04/03/2019
ms.topic: tutorial
f1_keywords:
  - "vs.performance.wizard.intropage"
helpviewer_keywords:
  - "Profiling Tools, quick start"
  - "Diagnostics Tools, CPU Usage"
  - "CPU Usage"
  - "Diagnostics Tools"
ms.assetid: da2fbf8a-2d41-4654-a509-dd238532d25a
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Measure application performance by analyzing CPU usage

You can use Visual Studio profiling tools to analyze performance issues in your application. This procedure shows how to use **CPU Usage** tab of the Diagnostics Tools to obtain performance data for your app.

When the debugger pauses, the **CPU Usage** tool collects information about the functions that are executing in your application. The tool lists the functions that were performing work, and provides a timeline graph you can use to focus on specific segments of the sampling session.

The Diagnostic hub offers you a lot of other options to run and manage your diagnostics session. If **CPU Usage** does not give you the data that you need, the [other profiling tools](../profiling/profiling-feature-tour.md) provide different kinds of information that might be helpful to you. In many cases, the performance bottleneck of your application may be caused by something other than your CPU, such as memory, rendering UI, or network request time. The Diagnostics hub offers you a lot of other options to record and analyze this kind of data.

> [!Important]
> The Diagnostics Tools are supported for .NET development in Visual Studio, including ASP.NET, and for native/C++ development.

In this article, we'll discuss analyzing CPU usage in your normal debugging workflow. You can also analyze CPU usage without a debugger attached or by targeting a running app - for more information see [Collect profiling data without debugging](../profiling/running-profiling-tools-with-or-without-the-debugger.md#collect-profiling-data-without-debugging) in [Run profiling tools with or without the debugger](../profiling/running-profiling-tools-with-or-without-the-debugger.md).

You can use the profiling tools without the debugger with Windows 7 and later. Windows 8 and later is required to run profiling tools with the debugger (**Diagnostic Tools** window).

In this tutorial, you will:

> [!div class="checklist"]
> * Collect CPU usage data
> * Analyze CPU usage data

## Step 1: Collect profiling data

1. Open the project you want to debug in Visual Studio and set a breakpoint in your app at the point where you want to examine CPU usage.

2. Set a second breakpoint at the end of the function or region of code that you want to analyze.

    > [!TIP]
    > By setting two breakpoints, you can limit data collection to the parts of code that you want to analyze.

3. The **Diagnostic Tools** window appears automatically unless you have turned it off. To bring up the window again, click **Debug** > **Windows** > **Show Diagnostic Tools**.

4. You can choose whether to see **CPU Usage**, [Memory Usage](../profiling/Memory-Usage.md), or both, with the **Select Tools** setting on the toolbar. If you are running Visual Studio Enterprise,  you can also enable or disable IntelliTrace in **Tools** > **Options** > **IntelliTrace**.

     ![Show Diagnostics Tools](../profiling/media/diag-tools-select-tool.png "DiagToolsSelectTool")

     We will mainly be looking at CPU utilization, so make sure that **CPU Usage** is enabled (it is enabled by default).

5. Click **Debug** > **Start Debugging** (or **Start** on the toolbar, or **F5**).

     When the app finishes loading, the Summary view of the Diagnostics Tools appears. If you need to open the window, click **Debug** > **Windows** > **Show Diagnostic Tools**.

     ![Diagnostics Tools Summary Tab](../profiling/media/diag-tools-summary-tab.png "DiagToolsSummaryTab")

     For more information on the events, see [Searching and filtering the Events tab of the Diagnostic Tools window](https://devblogs.microsoft.com/devops/searching-and-filtering-the-events-tab-of-the-diagnostic-tools-window/).

6. Run the scenario that will cause your first breakpoint to be hit.

7. While the debugger is paused, enable the collection of the CPU Usage data and then open the **CPU Usage** tab.

     ![Diagnostics Tools enable CPU profiling](../profiling/media/diag-tools-enable-cpu-profiling.png "DiagToolsEnableCPUProfiling")

     When you choose **Record CPU Profile**, Visual Studio will begin recording your functions and how much time they take to execute. You can only view this collected data when your application is halted at a breakpoint.

8. Hit F5 to run the app to your second breakpoint.

     Now, you now have performance data for your application specifically for the region of code that runs between the two breakpoints.

     The profiler begins preparing thread data. Wait for it to finish.

     ![Diagnostics Tools Preparing Threads](../profiling/media/diag-tools-preparing-data.png "DiagToolsPreparingThreads")

     The CPU Usage tool displays the report in the **CPU Usage** tab.

     ![Diagnostics Tools CPU Usage Tab](../profiling/media/diag-tools-cpu-usage-tab.png "DiagToolsCPUUsageTab")

9. If you want to select a more specific region of code to analyze, select a region in the CPU timeline (it must be a region that shows profiling data).

     ![Diagnostics Tools Selecting a Time Segment](../profiling/media/diag-tools-select-time-segment.png "DiagToolsSelectTimeSegment")

     At this point, you can begin to analyze the data.

## Step 2: Analyze CPU usage data

We recommend that you begin analyzing your data by examining the list of functions under CPU Usage, identifying the functions that are doing the most work, and then taking a closer look at each one.

1. In the function list, examine the functions that are doing the most work.

    ![Diagnostics Tools CPU Usage Function List](../profiling/media/diag-tools-cpu-usage-function-list.png "DiagToolsCPUUsageFunctionList")

    > [!TIP]
    > Functions are listed in order starting with those doing the most work (they're not in call order). This helps you quickly identify the longest running functions.

2. In the function list, double-click one of your app functions that is doing a lot of work.

    When you double-click a function, the **Caller/Callee** view opens in the left pane.

    ![Diagnostics Tools Caller Callee View](../profiling/media/diag-tools-caller-callee.png "DiagToolsCallerCallee")

    In this view, the selected function shows up in the heading and in the **Current Function** box (GetNumber, in this example). The function that called the current function is shown on the left under **Calling Functions**, and any functions called by the current function are shown in **Called Functions** box on the right. (You can select either box to change the current function.)

    This view shows you the total time (ms) and the percentage of the overall app running time that the function has taken to complete.
    **Function Body** also shows you the total amount of time (and the percentage of time) spent in the function body excluding time spent in calling and called functions. (In this example, 2367 out of 2389 ms were spent in the function body, and the remaining 22 ms were spent in external code called by this function).

    > [!TIP]
    > High values in **Function Body** may indicate a performance bottleneck within the function itself.

3. To see a higher-level view showing the order in which the functions are called, select **Call Tree** from the drop-down list at the top of the pane.

    Each numbered area in the figure relates to a step in the procedure.

    ::: moniker range=">=vs-2019"
    ![Diagnostics Tools Call Tree](../profiling/media/vs-2019/diag-tools-call-tree.png "DiagToolsCallTree")
    ::: moniker-end
    ::: moniker range="vs-2017"
    ![Diagnostics Tools Call Tree](../profiling/media/diag-tools-call-tree.png "DiagToolsCallTree")
    ::: moniker-end

    |||
    |-|-|
    |![Step 1](../profiling/media/ProcGuid_1.png "ProcGuid_1")|The top-level node in CPU Usage call trees is a pseudo-node|
    |![Step 2](../profiling/media/ProcGuid_2.png "ProcGuid_2")|In most apps, when the [Show External Code](#view-external-code) option is disabled, the second-level node is an **[External Code]** node that contains the system and framework code that starts and stops the app, draws the UI, controls thread scheduling, and provides other low-level services to the app.|
    |![Step 3](../profiling/media/ProcGuid_3.png "ProcGuid_3")|The children of the second-level node are the user-code methods and asynchronous routines that are called or created by the second-level system and framework code.|
    |![Step 4](../profiling/media/ProcGuid_4.png "ProcGuid_4")|Child nodes of a method contain data only for the calls of the parent method. When **Show External Code** is disabled, app methods can also contain an **[External Code]** node.|

    Here is more information on the column values:

    - **Total CPU** indicates how much work was done by the function and any functions called by it. High total CPU values point to the functions that are most expensive overall.

    - **Self CPU** indicates how much work was done by the code in the function body, excluding the work done by functions that were called by it. High **Self CPU** values may indicate a performance bottleneck within the function itself.

    - **Modules** The name of the module containing the function, or the number of modules containing the functions in an [External Code] node.

    ::: moniker range=">=vs-2019"
    To see the function calls that use the highest percentage of the CPU in the call tree view, click **Expand Hot Path**.

    ![Diagnostics Tools Hot Path](../profiling/media/vs-2019/diag-tools-hot-path.png "DiagToolsHotPath")
    ::: moniker-end

    > [!NOTE]
    > If you see code in the call tree marked as "broken" code or "unwalkable stack", this indicates that Event Tracing for Windows (ETW) events were likely dropped. Try collecting the same trace a second time to resolve the issue.

## View external code

External code are functions in system and framework components that are executed by the code you write. External code include functions that start and stop the app, draw the UI, control threading, and provide other low-level services to the app. In most cases, you won't be interested in external code, and so the CPU Usage tool gathers the external functions of a user method into one **[External Code]** node.

If you want to view the call paths of external code, choose **Show External Code** from the **Filter view** list and then choose **Apply**.

![Choose Filter View, then Show External Code](../profiling/media/diag-tools-show-external-code.png "DiagToolsShowExternalCode")

Be aware that many external code call chains are deeply nested, so that the width of the Function Name column can exceed the display width of all but the largest of computer monitors. When this happens, function names are shown as **[...]**.

Use the search box to find a node that you are looking for, then use the horizontal scroll bar to bring the data into view.

> [!TIP]
> If you profile external code that calls Windows functions, you should make sure that you have the most current .*pdb* files. Without these files, your report views will list Windows function names that are cryptic and difficult to understand. For more information about how to make sure that you have the files you need, see [Specify symbol (.pdb) and source files in the debugger](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md).

## Next steps

In this tutorial, you've learned how to collect and analyze CPU usage data. If you already completed the [First look at profiling tools](../profiling/profiling-feature-tour.md), you may want to get a quick look at how to analyze memory usage in your apps.

> [!div class="nextstepaction"]
> [Profile memory usage in Visual Studio](../profiling/memory-usage.md)
