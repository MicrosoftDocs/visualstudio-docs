---
title: "Summary View"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 98a1eb71-bbf5-4ce7-8559-cdc29f082c4b
caps.latest.revision: 37
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Summary View
The Summary view displays information about the most performance-expensive functions or objects in a profiling run. This view provides a timeline graph and two or more lists of the most expensive functions or objects based on the performance metrics of the profiling method. The data in this view depends on the profiling method that was used (sampling, instrumentation, or concurrency) and whether .NET memory allocation was collected.  
  
 For all Summary views except the Summary view of concurrency data, the timeline graph in the Summary view shows the processor (CPU) utilization of the profiled application over the time that the profiling occurred.  
  
-   If you specify a segment of time on the graph, you can reanalyze the data for that segment or zoom the timeline display to the segment that you specified. For more information, see [How to: Filter Report Views from the Summary Timeline](../VS_IDE/How-to--Filter-Report-Views-from-the-Summary-Timeline.md)  
  
-   You can click a function in a Summary view list to open the Function Details view for the function. You also can right-click the function for other view options.  
  
-   To modify the number of items that appear in Summary view lists, open the **Tools** menu, point to **Options**, and then click **Performance Tools**. Under **General settings**, modify the **Number of functions in Summary view** setting.  
  
## Notifications Links  
 You can click links in the Notification list to set display options for the report. The list is to the right of the timeline graph.  
  
|||  
|-|-|  
|**Show Non-User Code**<br /><br /> **Show Just My Code**|Not available for native code or for profiling data that was collected by using the instrumentation method. Toggles between displaying only data from user code (**Show Just My Code**) and displaying data from all code, including system code (**Show Non-User Code**). By default, data is limited to user code. To change the setting, see [How to: Filter Profiling Tools Report Views to Display Just My Code](../VS_IDE/How-to--Filter-Profiling-Tools-Report-Views-to-Display-Just-My-Code.md).|  
|**View Guidance**|Displays performance rule warnings in the **Error List** window. For more information, see [Using Performance Rules to Analyze Data](../VS_IDE/Using-Performance-Rules-to-Analyze-Data.md)|  
  
## Report  
 You can click links in the Report list to open different views and to compare, save, or filter the report. The list is to the right of the timeline graph.  
  
|||  
|-|-|  
|**Show Trimmed Call Tree**|Displays the most expensive execution paths in the Call Tree View. For more information, see [Call Tree View](../VS_IDE/Call-Tree-View.md).|  
|**Show Hot Lines**|Not available for profiling data that was collected by using the instrumentation method. Displays the most expensive source code lines in Lines View. For more information, see [Lines View](../VS_IDE/Lines-View.md).|  
|**Compare Reports**|Displays the **Select analysis files for comparison** dialog box where you can specify another profiling data file to compare to the current file. For more information, see [Comparing Performance Data Files](../VS_IDE/Comparing-Performance-Data-Files.md).|  
|**Export Report Data**|Displays the **Export Report** dialog box where you can specify one or more report views to save as comma-separated value (.csv) or .xml files. For more information, see [How to: Export Profiling Tools Reports](assetId:///174b5bd3-df9b-4fd4-88d4-76032ab90451).|  
|**Save Analyzed Report**|Saves the current profiling data file as a .vsps file, which opens more quickly in the interface for Visual Studio. For more information, see [How to: Save Analyzed Profiling Data Files](assetId:///0340ddde-caf4-48ac-8af3-d15dcdade556).|  
|**Filter Report Data**|Displays the profiling report filter pane where you can specify criteria to restrict the data in the report view. For more information, see [Performance Report View Filter](../VS_IDE/Performance-Report-View-Filter.md)|  
|**Toggle Full Screen**|Toggles full-screen mode for the report view.|  
  
## See Also  
 [Summary View](../VS_IDE/Summary-View---Sampling-Data.md)   
 [Summary View](../VS_IDE/Summary-View---Instrumentation-Data.md)   
 [Summary View](../VS_IDE/Summary-View---.NET-Memory-Data.md)