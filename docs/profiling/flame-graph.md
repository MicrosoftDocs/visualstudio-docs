---
title: Identify hot paths with the Flame Graph
description: Learn how to find hot paths in your code with a visualized overview
ms.date: 09/30/2022
ms.topic: how-to
ms.assetid: 7501a20d-04a1-480f-a69c-201524aa709d
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# Identify hot paths with a visualized call tree

Flame graphs are a visualization of categorized data, created to visualize stack traces of profiled software so that the most frequent code paths can be identified quickly and accurately.

The **Flame Graph** helps you identify hot paths in your code by visualizing a call tree. This new view is in the CPU tool details tool window, above the source line highlighting view. The graph gives a visual overview of where time is being spent in your application and you can click on specific nodes to dig into them further.

## 

1. In the Visual Studio project, set the solution configuration to **Release** and select **Local Windows Debugger** (or **Local Machine**) as the deployment target.

    ::: moniker range=">=vs-2022"
    ![Select Release and Local Machine](../profiling/media/vs-2022/cpu-use-select-release.png "Select Release")
    ::: moniker-end
    ::: moniker range="<=vs-2019"
    ![Select Release and Local Machine](../profiling/media/cpu-use-select-release-local-machine.png "Select Release and Local Machine")
    ::: moniker-end

1. Select **Debug** > **Performance Profiler**.

1. Under **Available tools**, select **CPU Usage**, and then select **Start**.

    ::: moniker range=">=vs-2022"
    ![Select CPU Usage](../profiling/media/vs-2022/cpu-use-lib-choose-cpu-usage.png "Select CPU Usage")
    ::: moniker-end
    ::: moniker range="<=vs-2019"
    ![Select CPU Usage](../profiling/media/cpu-use-lib-choose-cpu-usage.png "Select CPU Usage")
    ::: moniker-end

1. After the app starts, the diagnostic session begins and displays CPU usage data. When you're finished collecting data, select **Stop Collection**.

    ::: moniker range=">=vs-2022"
    ![Stop CPU Usage data collection](../profiling/media/vs-2022/cpu-use-wt-stop-collection.png "Stop CPU Usage data collection")
    ::: moniker-end
    ::: moniker range="<=vs-2019"
    ![Stop CPU Usage data collection](../profiling/media/cpu-use-wt-stop-collection.png "Stop CPU Usage data collection")
    ::: moniker-end

    The CPU Usage tool analyzes the data and displays the report.

    ::: moniker range=">=vs-2022"
    ![CPU Usage report](../profiling/media/vs-2022/cpu-use-wt-report.png "CPU Usage report")
    ::: moniker-end
    ::: moniker range="<=vs-2019"
   ![CPU Usage report](../profiling/media/cpu-use-wt-report.png "CPU Usage report")
    ::: moniker-end

## Analyze the CPU Usage report

The diagnostic report is sorted by **Total CPU**, from highest to lowest. Change the sort order or sort column by selecting the column headers. Use the **Filter** dropdown to select or deselect threads to display, and use the **Search** box to search for a specific thread or node.

Starting in Visual Studio 2019, you can click the **Expand Hot Path** and **Show Hot Path** buttons to see the function calls that use the highest percentage of the CPU in the call tree view.

### <a name="BKMK_Call_tree_data_columns"></a> CPU Usage data columns

|Name|Description|
|-|-|
|**Total CPU [unit, %]**|![Total % data equation](../profiling/media/cpu_use_wt_totalpercentequation.png "CPU_USE_WT_TotalPercentEquation")<br /><br /> The milliseconds and CPU percentage used by calls to the function, and functions called by the function, in the selected time range. This is different from the **CPU Utilization** timeline graph, which compares the total CPU activity in a time range to the total available CPU.|
|**Self CPU [unit, %]**|![Self % equation](../profiling/media/cpu_use_wt_selflpercentequation.png "CPU_USE_WT_SelflPercentEquation")<br /><br /> The milliseconds and CPU percentage used by calls to the function in the selected time range, excluding functions called by the function.|
|**Module**|The name of the module containing the function.

### <a name="BKMK_The_CPU_Usage_call_tree"></a> The CPU Usage call tree

To view the call tree, select the parent node in the report. The **CPU Usage** page opens to the **Caller/Callee** view. In the **Current View** dropdown, select **Call Tree**.

#### <a name="BKMK_Call_tree_structure"></a> Call tree structure

::: moniker range=">=vs-2022"
![Call tree structure](../profiling/media/vs-2022/cpu-use-wt-call-tree-annotated.png "Call tree structure")
::: moniker-end
::: moniker range="vs-2019"
![Call tree structure](../profiling/media/vs-2019/cpu-use-wt-getmaxnumber-call-tree-annotated.png "Call tree structure")
::: moniker-end

|Image|Description|
|-|-|
|![Step 1](../profiling/media/procguid_1.png "ProcGuid_1")|The top-level node in CPU Usage call trees is a pseudo-node.|
|![Step 2](../profiling/media/procguid_2.png "ProcGuid_2")|In most apps, when the **Show External Code** option is disabled, the second-level node is an **[External Code]** node. The node contains the system and framework code that starts and stops the app, draws the UI, controls thread scheduling, and provides other low-level services to the app.|
|![Step 3](../profiling/media/procguid_3.png "ProcGuid_3")|The children of the second-level node are the user-code methods and asynchronous routines that are called or created by the second-level system and framework code.|
|![Step 4](../profiling/media/procguid_4.png "ProcGuid_4")|Child nodes of a method have data only for the calls of the parent method. When **Show External Code** is disabled, app methods can also contain an **[External Code]** node.|

#### <a name="BKMK_External_Code"></a> External code

System and framework functions that are executed by your code are called *external code*. External code functions start and stop the app, draw the UI, control threading, and provide other low-level services to the app. In most cases, you aren't interested in external code, so the CPU Usage call tree gathers the external functions of a user method into one **[External Code]** node.

::: moniker range=">=vs-2022"
To view the call paths of external code, switch the current view to the **Call Tree** view or right-click and select **View in Call Tree**.

![Show Call Tree](../profiling/media/vs-2022/cpu-use-wt-call-tree-view.png "Show Call Tree")
::: moniker-end
::: moniker range="<=vs-2019"
To view the call paths of external code, on the main diagnostic report page (right pane), select **Show External Code** from the **Filter** dropdown, and then select **Apply**. The **Call Tree** view of the **CPU Usage** page then expands the external code calls. (The **Filter** dropdown is available on the main diagnostic page, not the detailed views.)