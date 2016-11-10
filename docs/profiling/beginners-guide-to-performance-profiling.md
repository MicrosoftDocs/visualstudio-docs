---
title: "Beginners Guide to Performance Profiling | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.performance.wizard.intropage"
helpviewer_keywords: 
  - "Profiling Tools, quick start"
  - "Diagnostics Tools, CPU Usage"
  - "CPU Usage"
  - "Diagnostics Tools"
ms.assetid: da2fbf8a-2d41-4654-a509-dd238532d25a
caps.latest.revision: 45
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Beginners Guide to Performance Profiling
You can use Visual Studio Profiling Tools to analyze performance issues in your application. This procedure shows how to use **CPU Usage** tab of the Diagnostics Tools to obtain performance data for your app. 
  
When the debugger pauses, the **CPU Usage** tool collects information about the functions that are executing in your application. The tool lists the functions that were performing work, and provides a timeline graph you can use to focus on specific segments of the sampling session.

The Diagnostic hub offers you a lot of other options to run and manage your diagnostics session. If **CPU Usage** does not give you the data that you need, other profiling tools provide different kinds of information that might be helpful to you. For more information about these other methods, see [Profiling Tools](../Topic/Profiling%20Tools.md). You can also analyze CPU usage by attaching to a running app, or start an app that is installed from the Windows Store. For more information, see [Run profiling tools without debugging](../Topic/Run%20profiling%20tools%20without%20debugging.md).
  
##  <a name="BKMK_Quick_start__Collect_diagnostic_data"></a> Step 1: Collect profiling data 
  
1.  Open the project you want to debug in Visual Studio and set a breakpoint in your app at the point where you want to examine CPU usage.
  
2.  The **Diagnostic Tools** window appears automatically unless you have turned it off. To bring up the window again, click **Debug / Windows / Show Diagnostic Tools**.

3.  You can choose whether to see **CPU Usage**, [Memory Usage](../Topic/Memory%20Usage.md), or both, with the **Select Tools** setting on the toolbar. If you are running Visual Studio Enterprise,  you can also enable or disable IntelliTrace in **Tools / Options / IntelliTrace**.

     ![Show Diagnostics Tools](../profiling/media/DiagToolsSelectTool.png "DiagToolsSelectTool")

     We will mainly be looking at CPU utilization, so choose **CPU Usage**.

4.  Click **Debug / Start Debugging** (or **Start** on the toolbar, or **F5**).

     When the app finishes loading, the Summary view of the Diagnostics Tools appears.

     ![Diagnostics Tools Summary Tab](../profiling/media/DiagToolsSummaryTab.png "DiagToolsSummaryTab")

     For more information on the events, see [Searching and filtering the Events tab of the Diagnostic Tools window](http://blogs.msdn.com/b/visualstudioalm/archive/2015/11/12/searching-and-filtering-the-events-tab-of-the-diagnostic-tools-window.aspx)

5.  Enable the collection of the CPU Usage data and then open the **CPU Usage** tab.

     ![Diagnostics Tools Enable CPU Profiling](../profiling/media/DiagToolsEnableCPUProfiling.png "DiagToolsEnableCPUProfiling")
  
6.  Run the scenario that will cause your breakpoint to be hit.

     The profiler begins preparing thread data. Wait for it to finish.

     ![Diagnostics Tools Preparing Threads](../profiling/media/DiagToolsPreparingThreads.png "DiagToolsPreparingThreads")
  
     The CPU Usage tool displays the report in the **CPU Usage** tab.
  
     ![Diagnostics Tools CPU Usage Tab](../profiling/media/DiagToolsCPUUsageTab.png "DiagToolsCPUUsageTab")

     Now, you can begin to analyze the data.

     At any time, you can advance the debugger using F5, F11, and other options, and then the CPU usage data is recalculated based on the new app state.

7. If you want to limit CPU usage data to a particular period when your app was running, select the region you're interested in analyzing in the CPU timeline.

    ![Diagnostics Tools Selecting a Time Segment](../profiling/media/DiagToolsSelectTimeSegment.png "DiagToolsSelectTimeSegment")

    The CPU usage data in the function list is immediately updated.

## <a name="Step2"></a> Step 2: Analyze CPU usage data

We recommend that you begin analyzing your data by examining the list of functions under CPU Usage, identifying the functions that are doing the most work, and then taking a closer look at each one.

1. In the function list, examine the functions that are doing the most work.

    ![Diagnostics Tools CPU Usage Function List](../profiling/media/DiagToolsCPUUsageFunctionList.png "DiagToolsCPUUsageFunctionList")

    > [!TIP] Functions are listed in order starting with those doing the most work (they're not in call order). This helps you quickly identify the longest running functions.

2. In the function list, select one of your app functions that is doing a lot of work.

    When you select a function, the **Caller/Callee** view opens in the left pane. 

    ![Diagnostics Tools Caller Callee View](../profiling/media/DiagToolsCallerCallee.png "DiagToolsCallerCallee")

    In this view, the selected function shows up in the heading and in the **Current Function** box (GetNumber, in this example). The function that called the current function is shown on the left under **Calling Function**, and any functions called by the current function are shown in **Called Functions** box on the right. (You can select either box to change the current function.)

    This view shows you the total time (ms) and the percentage of the overall app running time that the function has taken to complete.

    **Function Body** also shows you the total amount of time (and the percentage of time) spent in the function body excluding time spent in calling and called functions. (In this example, 3713 out of 3729 ms were spent in the function body, and the remaining 16 ms were spent in external code called by this function).

    > [!TIP] High values in **Function Body** may indicate a performance bottleneck within the function itself.

3. If you want to see a higher-level view showing the order in which the functions are called, select **Call Tree** from the drop-down list at the top of the pane.
 
    Each numbered area in the figure relates to a step in the procedure.
  
    ![Diagnostics Tools Call Tree](../profiling/media/DiagToolsCallTree.png "DiagToolsCallTree")
  
|||
|-|-|
|![Step 1](../profiling/media/ProcGuid_1.png "ProcGuid_1")|The top-level node in CPU Usage call trees is a pseudo-node|  
|![Step 2](../profiling/media/ProcGuid_2.png "ProcGuid_2")|In most apps, when the [Show External Code](#BKMK_External_Code) option is disabled, the second-level node is an **[External Code]** node that contains the system and framework code that starts and stops the app, draws the UI, controls thread scheduling, and provides other low-level services to the app.|  
|![Step 3](../profiling/media/ProcGuid_3.png "ProcGuid_3")|The children of the second-level node are the user-code methods and asynchronous routines that are called or created by the second-level system and framework code.|
|![Step 4](../profiling/media/ProcGuid_4.png "ProcGuid_4")|Child nodes of a method contain data only for the calls of the parent method. When **Show External Code** is disabled, app methods can also contain an **[External Code]** node.|

Here is more information on the column values:

- **Total CPU** indicates how much work was done by the function and any functions called by it. High total CPU values point to the functions that are most expensive overall.
  
- **Self CPU** indicates how much work was done by the code in the function body, excluding the work done by functions that were called by it. High **Self CPU** values may indicate a performance bottleneck within the function itself.

- **Modules** The name of the module containing the function, or the number of modules containing the functions in an [External Code] node.

## <a name="BKMK_External_Code"></a>View external code

External code are functions in system and framework components that executed by the code you write. External code include functions that start and stop the app, draw the UI, control threading, and provide other low-level services to the app. In most cases, you won’t be interested in external code, and so the CPU Usage tool gathers the external functions of a user method into one **[External Code]** node.  
  
If you want to view the call paths of external code, choose **Show External Code** from the **Filter view** list and then choose **Apply**.  
  
![Choose Filter View, then Show External Code](../profiling/media/DiagToolsShowExternalCode.png "DiagToolsShowExternalCode")  
  
Be aware that many external code call chains are deeply nested, so that the width of the Function Name column can exceed the display width of all but the largest of computer monitors. When this happens, function names are shown as **[…]**.
  
Use the search box to find a node that you are looking for, then use the horizontal scroll bar to bring the data into view.

> [!TIP]
>  If you profile external code that calls Windows functions, you should make sure that you have the most current .pdb files. Without these files, your report views will list Windows function names that are cryptic and difficult to understand. For more information about how to make sure that you have the files you need, see [How to: Reference Windows Symbol Information](../Topic/How%20to:%20Reference%20Windows%20Symbol%20Information.md).

## View Asynchronous functions

When the compiler encounters an asynchronous method, it creates a hidden class to control the method’s execution. Conceptually, the class is a state machine that includes a list of compiler-generated functions that call operations of the original method asynchronously, and the callbacks, scheduler, and iterators required to them correctly. When the original method is called by a parent method, the runtime removes the method from the execution context of the parent, and runs the methods of the hidden class in the context of the system and framework code that control the app’s execution. The asynchronous methods are often, but not always, executed on one or more different threads. This code is shown in the CPU Usage call tree as children of the **[External Code]** node immediately below the top node of the tree.

![Diagnostic Tools Asynchronous Functions](../profiling/media/DiagToolsAsyncFunctions.png "DiagToolsAsyncFunctions")

The first node under **[External Code]** is a compiler-generated method of the state machine class. 
  
## See Also  
 [Performance Explorer](../Topic/Performance%20Explorer.md)   
 [Getting Started](../Topic/Getting%20Started%20with%20Performance%20Tools.md)   
 [Overviews](../Topic/Overviews%20\(Performance%20Tools\).md)