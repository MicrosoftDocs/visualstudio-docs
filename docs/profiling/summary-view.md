---
title: "Summary View | Microsoft Docs"
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
  - "vs.performance.view.summary"
helpviewer_keywords: 
  - "performance reports, summary view"
  - "profiling tools reports, Summary view"
  - "profiling tools, Summary view"
  - "Summary view"
ms.assetid: 98a1eb71-bbf5-4ce7-8559-cdc29f082c4b
caps.latest.revision: 37
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
# Summary View
The Summary view displays information about the most performance-expensive functions or objects in a profiling run. This view provides a timeline graph and two or more lists of the most expensive functions or objects based on the performance metrics of the profiling method. The data in this view depends on the profiling method that was used (sampling, instrumentation, or concurrency) and whether .NET memory allocation was collected.  
  
 For all Summary views except the Summary view of concurrency data, the timeline graph in the Summary view shows the processor (CPU) utilization of the profiled application over the time that the profiling occurred.  
  
-   If you specify a segment of time on the graph, you can reanalyze the data for that segment or zoom the timeline display to the segment that you specified. For more information, see [How to: Filter Report Views from the Summary Timeline](../profiling/how-to-filter-report-views-from-the-summary-timeline.md)  
  
-   You can click a function in a Summary view list to open the Function Details view for the function. You also can right-click the function for other view options.  
  
-   To modify the number of items that appear in Summary view lists, open the **Tools** menu, point to **Options**, and then click **Performance Tools**. Under **General settings**, modify the **Number of functions in Summary view** setting.  
  
## Notifications Links  
 You can click links in the Notification list to set display options for the report. The list is to the right of the timeline graph.  
  
|||  
|-|-|  
|**Show Non-User Code**<br /><br /> **Show Just My Code**|Not available for native code or for profiling data that was collected by using the instrumentation method. Toggles between displaying only data from user code (**Show Just My Code**) and displaying data from all code, including system code (**Show Non-User Code**). By default, data is limited to user code. To change the setting, see [How to: Filter Profiling Tools Report Views to Display Just My Code](../profiling/how-to-filter-profiling-tools-report-views-to-display-just-my-code.md).|  
|**View Guidance**|Displays performance rule warnings in the **Error List** window. For more information, see [Using Performance Rules to Analyze Data](../profiling/using-performance-rules-to-analyze-data.md)|  
  
## Report  
 You can click links in the Report list to open different views and to compare, save, or filter the report. The list is to the right of the timeline graph.  
  
|||  
|-|-|  
|**Show Trimmed Call Tree**|Displays the most expensive execution paths in the Call Tree View. For more information, see [Call Tree View](../profiling/call-tree-view.md).|  
|**Show Hot Lines**|Not available for profiling data that was collected by using the instrumentation method. Displays the most expensive source code lines in Lines View. For more information, see [Lines View](../profiling/lines-view.md).|  
|**Compare Reports**|Displays the **Select analysis files for comparison** dialog box where you can specify another profiling data file to compare to the current file. For more information, see [Comparing Performance Data Files](../profiling/comparing-performance-data-files.md).|  
|**Export Report Data**|Displays the **Export Report** dialog box where you can specify one or more report views to save as comma-separated value (.csv) or .xml files. For more information, see [How to: Export Profiling Tools Reports](http://msdn.microsoft.com/en-us/174b5bd3-df9b-4fd4-88d4-76032ab90451).|  
|**Save Analyzed Report**|Saves the current profiling data file as a .vsps file, which opens more quickly in the interface for [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. For more information, see [How to: Save Analyzed Profiling Data Files](http://msdn.microsoft.com/en-us/0340ddde-caf4-48ac-8af3-d15dcdade556).|  
|**Filter Report Data**|Displays the profiling report filter pane where you can specify criteria to restrict the data in the report view. For more information, see [Performance Report View Filter](../profiling/performance-report-view-filter.md)|  
|**Toggle Full Screen**|Toggles full-screen mode for the report view.|  
  
## See Also  
 [Summary View](../profiling/summary-view-sampling-data.md)   
 [Summary View](../profiling/summary-view-instrumentation-data.md)   
 [Summary View](../profiling/summary-view-dotnet-memory-data.md)