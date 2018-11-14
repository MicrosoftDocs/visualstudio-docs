---
title: "Analyze CPU usage in Visual Studio | Microsoft Docs"
ms.custom: "H1Hack27Feb2017"
ms.date: "11/04/2018"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
ms.assetid: 7501a20d-04a1-480f-a69c-201524aa709d
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# Analyze CPU usage 

A good way to start investigating performance issues in your app is to understand its CPU usage. The **CPU Usage** performance tool shows where the CPU is spending time executing Visual C++, Visual C#/Visual Basic, and JavaScript code. While debugging, you can turn CPU profiling on and off, and see a per-function breakdown of CPU usage. You can view CPU usage results when execution is paused, for example at a breakpoint.  
  
The **CPU Usage** tool can run on an open Visual Studio project, attached to a running app or process, or on an installed app from the Microsoft Store. You can run the tool on local or remote machines, or on a simulator or emulator. For more information, see [Run profiling tools with or without the debugger](../profiling/running-profiling-tools-with-or-without-the-debugger.md). 

The following instructions show how to run the **CPU Usage** tool and analyze data from the Visual Studio **Performance Profiler**. The example uses a Release build on a local machine. Release builds provide the best view of actual app performance. To analyze CPU usage with Debug builds, see [Beginner's guide to performance profiling](../profiling/beginners-guide-to-performance-profiling.md).

The local machine usually best replicates installed app execution. For Windows Phone apps, collecting data directly from the device provides the most accurate data. To collect data from a remote device, run the app directly on the device, not by using a Remote Desktop Connection. 

>[!NOTE]
>Windows 7 or later is required to use the [Performance Profiler](../profiling/profiling-feature-tour.md).
  
##  Collect CPU usage data  
  
1. In the Visual Studio project, set the solution configuration to **Release** and select **Local Machine** as the deployment target.  
  
    ![Select Release and Local Machine](../profiling/media/cpuuse_selectreleaselocalmachine.png "CPUUSE_SelectReleaseLocalMachine")  
  
1. Select **Debug** > **Performance Profiler**.  
  
1. Under **Available tools**, select **CPU Usage**, and then select **Start**.  
  
    ![Choose CPU Usage](../profiling/media/cpuuse_lib_choosecpuusage.png "CPUUSE_LIB_ChooseCpuUsage")  
  
4. After the app starts, the diagnostic session begins and displays CPU usage data. When you are finished collecting data, select **Stop Collection**.  
  
   ![Stop CpuUsage data collection](../profiling/media/cpu_use_wt_stopcollection.png "CPU_USE_WT_StopCollection")  
  
   The CPU Usage tool analyzes the data and displays the report.  
  
   ![CpuUsage report](../profiling/media/cpu_use_wt_report.png "CPU_USE_WT_Report")  
  

## Analyze the CPU usage report  
  
The diagnostic report is sorted by **Total CPU**, from highest to lowest. Change the sort order or sort column by selecting the column headers. Use the **Filter** dropdown to select or deselect threads to display, and use the search box to search for a specific thread or node. 

###  <a name="BKMK_Call_tree_data_columns"></a> CPU Usage data columns  

|||  
|-|-|  
|**Total CPU [unit, %]**|![Total % data equation](../profiling/media/cpu_use_wt_totalpercentequation.png "CPU_USE_WT_TotalPercentEquation")<br /><br /> The number of milliseconds and percentage of the app's CPU activity used by calls to the function, and the functions called by the function, in the selected time range. Note that this is different from the **CPU Utilization** timeline graph, which compares the total activity of the app in a time range to the total available CPU capacity.|  
|**Self CPU [unit, %]|![Self % equation](../profiling/media/cpu_use_wt_selflpercentequation.png "CPU_USE_WT_SelflPercentEquation")<br /><br /> The number of milliseconds and percentage of the app's CPU activity used by calls to the function in the selected time range, excluding functions called by the function.|  
|**Module**|The name of the module containing the function. For **[External Code]** nodes, this is **Multiple modules**.|  
  
###  <a name="BKMK_The_CPU_Usage_call_tree"></a> The CPU Usage call tree 

To view the call tree, select the parent node in the report. The **CPU Usage** page opens to the **Caller/Callee** view. In the **Current View** dropdown, select **Call Tree**.  
  
####  <a name="BKMK_Call_tree_structure"></a> Call tree structure  

 ![GetMaxNumberButton&#95;Click call tree](../profiling/media/cpu_use_wt_getmaxnumbercalltree_annotated.png "CPU_USE_WT_GetMaxNumberCallTree_annotated")  
  
|||  
|-|-|  
|![Step 1](../profiling/media/procguid_1.png "ProcGuid_1")|The top-level node in CPU Usage call trees is a pseudo-node|  
|![Step 2](../profiling/media/procguid_2.png "ProcGuid_2")|In most apps, when the **Show External Code** option is disabled, the second-level node is an **[External Code]** node that contains the system and framework code that starts and stops the app, draws the UI, controls thread scheduling, and provides other low-level services to the app.|  
|![Step 3](../profiling/media/procguid_3.png "ProcGuid_3")|The children of the second-level node are the user-code methods and asynchronous routines that are called or created by the second-level system and framework code.|  
|![Step 4](../profiling/media/procguid_4.png "ProcGuid_4")|Child nodes of a method contain data only for the calls of the parent method. When **Show External Code** is disabled, app methods can also contain an **[External Code]** node.|  
  
####  <a name="BKMK_External_Code"></a> External code  

 System and framework functions that are executed by your code are called *external code*. External code functions start and stop the app, draw the UI, control threading, and provide other low-level services to the app. In most cases, you aren't interested in external code, so the CPU Usage call tree gathers the external functions of a user method into one **[External Code]** node.  
  
 To view the call paths of external code, on the main diagnostic report page, select **Show External Code** from the **Filter** dropdown, and then select **Apply**. The **Call Tree** view of the **CPU Usage** page then expands the external code calls.  
  
 ![Show External Code](../profiling/media/cpu_use_wt_filterview.png "Show External Code")  
  
 Many external code call chains are deeply nested, so the width of the chain can exceed the display width of the **Function Name** column. When this happens, function names appear as **...**.  
  
 ![Nested external code in the call tree](../profiling/media/cpu_use_wt_showexternalcodetoowide.png "CPU_USE_WT_ShowExternalCodeTooWide")  
  
 To find a function name you are looking for, use the search box, then hover over over the line or use the horizontal scroll bar to view the data.  
  
 ![Search for nested external code](../profiling/media/cpu_use_wt_showexternalcodetoowide_found.png "CPU_USE_WT_ShowExternalCodeTooWide_Found")  
  
###  <a name="BKMK_Asynchronous_functions_in_the_CPU_Usage_call_tree"></a> Asynchronous functions in the CPU usage call tree  

 When the compiler encounters an asynchronous method, it creates a hidden class to control the method's execution. Conceptually, the class is a state machine. The class includes the compiler-generated functions that call operations of the original method asynchronously, and the callbacks, scheduler, and iterators required to execute them correctly. When the original method is called by a parent method, the runtime removes the method from the execution context of the parent. The compiler runs the methods of the hidden class in the context of the system and framework code that control the app's execution. The asynchronous methods are often, but not always, executed on one or more different threads. This code is shown in the **CPU Usage** call tree as children of the **[External Code]** node immediately below the top node of the tree.  
  
