---
title: "Application Timeline | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: df7d854b-0a28-45a9-8a64-c015a4327701
caps.latest.revision: 15
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Application Timeline
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Use the **Application Timeline** profiler to find and fix application-interaction related performance issues in XAML applications. This tool helps improve the performance of XAML applications by providing a detailed view of the applications’ resource consumption. You can analyze the time spent by your application preparing UI frames (layout and render), servicing network and disk requests, and in scenarios like Application Startup, Page Load and Windows resize.  
  
 **Application Timeline** is one of the tools you can start with the **Debug / Performance Profiler...** command.  
  
 This tool replaces the **XAML UI Responsiveness** tool that was part of the diagnostic toolset for Visual Studio 2013.  
  
 You can use this tool on the following platforms:  
  
1. Universal Windows apps (on Windows 10)  
  
2. Windows Store 8.1  
  
3. Windows Phone 8.1 (Common XAML Platform)  
  
4. Windows Presentation Foundation (.Net 4.0 and above)  
  
5. Windows 7  
  
> [!NOTE]
> You can collect and analyze CPU usage data and energy consumption data along with the **ApplicationTimeline** data. See [Run profiling tools without debugging](https://msdn.microsoft.com/library/e97ce1a4-62d6-4b8e-a2f7-61576437ff01)  
  
## <a name="BKMK_Collect_Timeline_data_for_your_app"></a> Collect Application Timeline data  
 You can profile the responsiveness of your app on your local machine, connected device, Visual Studio simulator or emulators, or a remote device. See [Run profiling tools without debugging](https://msdn.microsoft.com/library/e97ce1a4-62d6-4b8e-a2f7-61576437ff01).  
  
> [!TIP]
> If possible, run the app directly on the device. The application performance observed on the simulator or through a remote desktop connection might not be the same as the actual performance on the device. On the other hand, collecting the data by using the Visual Studio Remote Tools does not affect the performance data.  
  
 Here are the basic steps:  
  
1. Open your XAML app.  
  
2. Click **Debug / Performance Profiler...**. You should see a list of profiling tools in the .diagsession window.  
  
3. Select **Application Timeline** and then click **Start** at the bottom of the window.  
  
    > [!NOTE]
    > You might see a User Account Control window requesting your permission to run VsEtwCollector.exe. Click **Yes**.  
  
4. Run the scenario you are interested in profiling in your app to collect performance data.  
  
5. To stop profiling, switch back to the .diagsession window and click **Stop** at the top of the window.  
  
     Visual Studio analyzes the collected data and displays the results.  
  
     ![Timeline profiler report](../profiling/media/timeline-base.png "TIMELINE_Base")  
  
## <a name="BKMK_Analyze_Timeline_profiling_data"></a> Analyze Timeline profiling data  
 After you have collected the profiling data, you can use these steps to start your analysis:  
  
1. Examine the information in the **UI thread utilization** and **Visual throughput (FPS)** graphs and then use the timeline navigation bars to select a time range that you want to analyze.  
  
2. Using the information in the **UI thread utilization** or **Visual throughput (FPS)** graphs, examine the details in the **Timeline details** view to discover possible causes for any apparent lack of responsiveness.  
  
### <a name="BKMK_Report_scenarios_categories_and_events"></a> Report scenarios, categories, and events  
 The **Application Timeline** tool displays timing data for scenarios, categories, and events that are related to XAML performance.  
  
### <a name="BKMK_Diagnostic_session_timeline"></a> Diagnostic session timeline  
 ![Performance and Diagnostics timeline](../profiling/media/diaghub-timelinewithusermarks.png "DIAGHUB_TimelineWithUserMarks")  
  
 The ruler at the top of the page shows the timeline for profiled information. This timeline applies to both the **UI thread utilization** graph and the **Visual throughput** graph. You can narrow the scope of the report by dragging the navigation bars on the timeline to select a segment of the timeline.  
  
 The timeline also displays any user marks that you have inserted, and the app's activation lifecycle events.  
  
### <a name="BKMK_UI_thread_utilization_graph"></a> UI thread utilization graph  
 ![CPU Utilization Graph](../profiling/media/timeline-cpuutilization.png "TIMELINE_CpuUtilization")  
  
 The **UI thread utilization (%)** graph is a bar chart that displays the relative amount of time spent in a category for during a collection span.  
  
### <a name="BKMK_Visual_throughput_FPS_graph"></a> Visual throughput (FPS) graph  
 ![Visual throughput graph](../profiling/media/timeline-visualthroughput.png "TIMELINE_VisualThroughput")  
  
 The **Visual throughput (FPS)** line graph shows the frames per second (FPS) on the UI and composition thread for the app.  
  
### <a name="BKMK_Timeline_details_"></a> Timeline details  
 The details view is where you will be spending most of your time analyzing the report. It shows a detailed view of CPU utilization of your application categorized by the UI Framework subsystem or the system component that consumed the CPU.  
  
 The following events are supported:  
  
|||  
|-|-|  
|**Parsing**|Time spent parsing XAML files and creating objects.<br /><br /> Expanding a **Parsing** node in **Timeline details** displays the dependency chain of all the XAML files that were parsed as a result of the root event. This will enable you to identify unnecessary file parsing and object creation in performance sensitive scenarios and optimize them out.|  
|**Layout**|In large applications, thousands of elements may be shown on the screen at the same time. This might result in a low UI frame rate and correspondingly poor application responsiveness. The Layout event accurately determines the cost of laying out each element (i.e. the time spent in Arrange, Measure, ApplyTemplate, ArrangeOverride, and ArrangeOverride) and builds the visual trees that took part in a Layout pass. You can use this visualization to determine which of your logical trees needs pruning, or to evaluate other deferral mechanisms to optimize your layout pass.|  
|**Render**|Time spent drawing XAML elements to the screen.|  
|**I/0**|Time spent retrieving data from the local disk or from network resources that are accessed through the [Microsoft Windows Internet (WinINet) API](https://msdn.microsoft.com/library/windows/desktop/aa385331.aspx).|  
|**App Code**|Time spent executing application (user) code that is not related to parsing or layout.|  
|**Xaml Other**|Time spent executing XAML runtime code.|  
  
> [!TIP]
> Choose the **CPU Usage** tool along with the **Application Timeline** tool when you start profiling to view app methods that execute on the UI thread. Moving long-running app code to a background thread can improve UI responsiveness.  
  
#### <a name="BKMK_Customizing_Timeline_details_"></a> Customizing Timeline details  
 Use the **Timeline details** toolbar to sort, filter, and specify the annotations of **Timeline details** view entries.  
  
|||  
|-|-|  
|**Sort by**|Sort by start time or the length of events.|  
|![Group events by frame](../profiling/media/timeline-groupbyframes.png "TIMELINE_GroupByFrames")|Adds or removes a top-level **Frame** category that groups events by frame.|  
|![Filter Timeline details list](../profiling/media/timeline-filter.png "TIMELINE_Filter")|Filters the list by selected categories and the length of events.|  
|![Customize Timeline details information](../profiling/media/timeline-viewsettings.png "TIMELINE_ViewSettings")|Lets you specify the annotations to events.|  
  
## See Also  
 [WPF Team Blog: New UI Performance Analysis Tool for WPF Applications](https://devblogs.microsoft.com/wpf/new-ui-performance-analysis-tool-for-wpf-applications/)   
 [Performance best practices for Windows Store apps using C++, C#, and Visual Basic](https://msdn.microsoft.com/567bcefa-5da5-4e42-a4b8-1358c71adfa2)   
 [Optimizing WPF Application Performance](https://msdn.microsoft.com/library/ac8c6aa3-3c68-4a24-9827-3b6c829c1ebf)
