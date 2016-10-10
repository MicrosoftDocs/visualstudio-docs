---
title: "Analyzing Load Test Results in the Graphs View of the Load Test Analyzer"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4a919cd8-541c-40ee-be3b-352fabc56140
caps.latest.revision: 40
manager: douge
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
# Analyzing Load Test Results in the Graphs View of the Load Test Analyzer
The results of a load test are displayed as data in several different panes.  
  
 To display test results as graphs, choose **Graphs** on the load test toolbar. Each individual graph is displayed in a panel with the graph name displayed at the top in a drop-down list. To display a different graph in the panel, choose a different graph name from the list.  
  
 Up to four graph panels can be displayed at a time. You can switch between different panel layouts by using the panel layout toolbar button.  
  
 Several built-in graphs are provided. You can use the built-in graphs as is or you can customize them. Additionally, you can create your own graphs. For more information, see [How to: Add and Delete Counters on Graphs](../dv_TeamTestALM/How-to--Add-and-Delete-Counters-on-Graphs-in-Load-Test-Results.md) and [How to: Create Custom Graphs](../dv_TeamTestALM/How-to--Create-Custom-Graphs-in-Load-Test-Results.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
## Built-in Graphs  
 The following table lists the built-in graphs that are available to analyze load test results.  
  
|Graph Name|Description|  
|----------------|-----------------|  
|Key Indicators|Counters that describe basic aspects of test performance such as user load, throughput, and response time.|  
|Test Response Time|Data about the amount of time tests take to run.|  
|Page Response Time|The average response time for Web pages that are accessed during the load test.|  
|System under Test|Information about the computers on which the application being tested runs. This includes data about memory use, the processor, the physical disk, processes.<br /><br /> By default, Only the Available Mbytes and Processor Time counters are collected.|  
|Controller and Agents|Information about the computers on which the load tests run. This includes data about memory use, the processor, the physical disk, processes.<br /><br /> By default Only the Available Mbytes and Processor Time counters are collected.|  
|Transaction Response Time|The average response time for transactions that occur during the load test.|  
  
 You can display different counters on the graph both at run time and after a test has run.  
  
> [!NOTE]
>  Only response time performance counters can be added to an automatically generated response time graph.  
  
 The counter information displays both in the graph and in the legend underneath the graphs. You can also zoom in on a section of the graph. For more information, see [How to: Zoom in on a Region of the Graph](../dv_TeamTestALM/How-to--Zoom-in-on-a-Region-of-the-Graph-in-Load-Test-Results.md).  
  
## Counters Displayed in Graphs  
 Graphs display *counters*. Counters refer to the data gathered during a load test, such as tests per second or average test time. For more information about counters, see [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../dv_TeamTestALM/Specifying-the-Counter-Sets-and-Threshold-Rules-for-Computers-in-a-Load-Test.md).  
  
 The legend for the counters that are displayed in the graphs shows several columns of useful data about the load test run. To turn off the display of any data in the graph, clear the check box in the row in the legend.  
  
 The legend contains the following columns:  
  
|Counter|The name of the counter|  
|-------------|-----------------------------|  
|Instance|The name of the counter instance.|  
|Category|The name of the counter category.|  
|Computer|The name of the computer to which the counter is collected.|  
|Color|The color of the line in the graph.|  
|Range|Indicates the number that is represented by 100 on the graph for that counter. For example, for a range whose upper value is 10,000, the 100 label at the top of the graph represents 10,000.|  
|Min|Indicates the minimum value for the counter in milliseconds.|  
|Max|Indicates the maximum value for the counter in milliseconds.|  
|Avg|Indicates the average value for the counter in milliseconds.|  
|Last|Shows the value of the counter during the most recent sampling interval in milliseconds.|  
  
## Tasks  
  
|Tasks|Associated topics|  
|-----------|-----------------------|  
|**Customize the graphs by using the legend:** The Graphs view legend displays information for each performance counter that is associated with a graph. You can use the legend to remove performance counters, highlight performance counters in the graph, and customize the plotting options.|-   [Using the Graphs View Legend to Analyze Load Tests](../dv_TeamTestALM/Using-the-Graphs-View-Legend-to-Analyze-Load-Tests.md)|  
|**Display counters on graphs:** You can add different kinds of data to a load test results graph by placing counters on the graph.|-   [How to: Add and Delete Counters on Graphs](../dv_TeamTestALM/How-to--Add-and-Delete-Counters-on-Graphs-in-Load-Test-Results.md)|  
|**Zoom in on graphs:** After a load test has finished, you can use zoom bars to zoom in and scroll to a region of the graph. By zooming in, you can examine the data that was generated during a load test run in finer detail.|-   [How to: Zoom in on a Region of the Graph](../dv_TeamTestALM/How-to--Zoom-in-on-a-Region-of-the-Graph-in-Load-Test-Results.md)|  
|**Tile graphs:** You can arrange load test results graphs in any of several patterns. You can tile up to four graphs.|-   [How to: Tile Graphs](../dv_TeamTestALM/How-to--Tile-Graphs-in-Load-Test-Results.md)|  
|**Modify the appearance of performance counter plots in the graphs:** You can change the plotting lines options for performance counters in the graphs. This includes color and line style. Additionally, you can specify whether you want to automatically or manually specify the range that you want to use for plotting the performance counter.|-   [How to: Specify Plot Options for Graphing Counters](../dv_TeamTestALM/How-to--Specify-Plot-Options-for-Graphing-Counters.md)|  
|**Create custom graphs:** You can design graphs that display specific information about load test results. You design a custom graph by specifying the load test counters that the graph will display.|-   [How to: Create Custom Graphs](../dv_TeamTestALM/How-to--Create-Custom-Graphs-in-Load-Test-Results.md)|  
|**Export the performance counters data in the graph:** You can export the graph data to Microsoft Excel by using the Export Graph Data to Excel button on the Load Test Analyzer toolbar while you are in the Graphs view.|-   [How to: Export Graph View Data to Microsoft Excel](../dv_TeamTestALM/How-to--Export-Graph-View-Data-to-Microsoft-Excel.md)|  
  
## Related Tasks  
 [Analyzing Load Test Results and Errors in the Tables View](../dv_TeamTestALM/Analyzing-Load-Test-Results-and-Errors-in-the-Tables-View-of-the-Load-Test-Analyzer.md)  
  
 [Load Test Analyzer Overview](../dv_TeamTestALM/Load-Test-Analyzer-Overview.md)  
  
 [How to: Access Load Test Results for Analysis](../dv_TeamTestALM/How-to--Access-Load-Test-Results-for-Analysis.md)  
  
 [Analyzing Load Test Results](../dv_TeamTestALM/Analyzing-Load-Test-Results-Using-the-Load-Test-Analyzer.md)  
  
## See Also  
 [Running Load Tests](../Topic/Running%20Load%20Tests.md)   
 [How to: Tile Graphs](../dv_TeamTestALM/How-to--Tile-Graphs-in-Load-Test-Results.md)   
 [How to: Add and Delete Counters on Graphs](../dv_TeamTestALM/How-to--Add-and-Delete-Counters-on-Graphs-in-Load-Test-Results.md)   
 [How to: Create Custom Graphs](../dv_TeamTestALM/How-to--Create-Custom-Graphs-in-Load-Test-Results.md)   
 [How to: Zoom in on a Region of the Graph](../dv_TeamTestALM/How-to--Zoom-in-on-a-Region-of-the-Graph-in-Load-Test-Results.md)