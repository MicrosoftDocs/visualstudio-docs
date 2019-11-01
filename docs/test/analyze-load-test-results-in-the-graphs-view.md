---
title: "Analyze load test results in Graphs view of Load Test Analyzer"
ms.date: 10/19/2016
ms.topic: conceptual
f1_keywords:
  - "vs.test.load.monitor.graph.view"
helpviewer_keywords:
  - "graphs, analyzing load tests"
  - "load tests, graphs in Load Test Viewer"
  - "Load Test Viewer, graphs"
  - "load tests, results graphs"
  - "load tests, using graphs"
  - "load test results, graphs"
ms.assetid: 4a919cd8-541c-40ee-be3b-352fabc56140
author: jillre
ms.author: jillfra
manager: jillfra
---
# Analyze load test results in the Graphs view of the Load Test Analyzer

The results of a load test are displayed as data in several different panes.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

To display test results as graphs, choose **Graphs** on the **load test** toolbar. Each individual graph is displayed in a panel with the graph name displayed at the top in a drop-down list. To display a different graph in the panel, choose a different graph name from the list.

Up to four graph panels can be displayed at a time. You can switch between different panel layouts by using the **panel layout** toolbar button.

Several built-in graphs are provided. You can use the built-in graphs as is or you can customize them. Additionally, you can create your own graphs. For more information, see [How to: Add and delete counters on graphs](../test/how-to-add-and-delete-counters-on-graphs-in-load-test-results.md) and [How to: Create custom graphs](../test/how-to-create-custom-graphs-in-load-test-results.md).

## Built-in graphs

The following table lists the built-in graphs that are available to analyze load test results.

|Graph Name|Description|
|-|-|
|Key Indicators|Counters that describe basic aspects of test performance such as user load, throughput, and response time.|
|Test Response Time|Data about the amount of time tests take to run.|
|Page Response Time|The average response time for web pages that are accessed during the load test.|
|System under Test|Information about the computers on which the application being tested runs. This includes data about memory use, the processor, the physical disk, processes.<br /><br /> By default, Only the Available Mbytes and Processor Time counters are collected.|
|Controller and Agents|Information about the computers on which the load tests run. This includes data about memory use, the processor, the physical disk, processes.<br /><br /> By default Only the Available Mbytes and Processor Time counters are collected.|
|Transaction Response Time|The average response time for transactions that occur during the load test.|

You can display different counters on the graph both at run time and after a test has run.

> [!NOTE]
> Only response time performance counters can be added to an automatically generated response time graph.

The counter information displays both in the graph and in the legend underneath the graphs. You can also zoom in on a section of the graph. For more information, see [How to: Zoom in on a region of the graph](../test/how-to-zoom-in-on-a-region-of-the-graph-in-load-test-results.md).

## Counters displayed in graphs

Graphs display *counters*. Counters refer to the data gathered during a load test, such as tests per second or average test time. For more information about counters, see [Specifying the counter sets and threshold rules for computers in a load test](../test/specify-counter-sets-and-threshold-rules-for-load-testing.md).

The legend for the counters that are displayed in the graphs shows several columns of useful data about the load test run. To turn off the display of any data in the graph, clear the check box in the row in the legend.

The legend contains the following columns:

|Counter|The name of the counter|
|-|-|
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
|-|-|
|**Customize the graphs by using the legend:** The Graphs view legend displays information for each performance counter that is associated with a graph. You can use the legend to remove performance counters, highlight performance counters in the graph, and customize the plotting options.|-   [Using the Graphs view legend to analyze load tests](../test/use-the-graphs-view-legend-to-analyze-load-tests.md)|
|**Display counters on graphs:** You can add different kinds of data to a load test results graph by placing counters on the graph.|-   [How to: Add and delete counters on graphs](../test/how-to-add-and-delete-counters-on-graphs-in-load-test-results.md)|
|**Zoom in on graphs:** After a load test has finished, you can use zoom bars to zoom in and scroll to a region of the graph. By zooming in, you can examine the data that was generated during a load test run in finer detail.|-   [How to: Zoom in on a region of the graph](../test/how-to-zoom-in-on-a-region-of-the-graph-in-load-test-results.md)|
|**Tile graphs:** You can arrange load test results graphs in any of several patterns. You can tile up to four graphs.||
|**Create custom graphs:** You can design graphs that display specific information about load test results. You design a custom graph by specifying the load test counters that the graph will display.|-   [How to: Create custom graphs](../test/how-to-create-custom-graphs-in-load-test-results.md)|
|**Export the performance counters data in the graph:** You can export the graph data to Microsoft Excel by using the **Export Graph Data to Excel** button on the **Load Test Analyzer** toolbar while you are in the **Graphs** view.||

## Related tasks

[Analyze load test results and errors in the tables view](../test/analyze-load-test-results-and-errors-in-the-tables-view.md)

[How to: Access load test results for analysis](../test/how-to-access-load-test-results-for-analysis.md)

[Analyze load test results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)

## See also

- [How to: Add and delete counters on graphs](../test/how-to-add-and-delete-counters-on-graphs-in-load-test-results.md)
- [How to: Create custom graphs](../test/how-to-create-custom-graphs-in-load-test-results.md)
- [How to: Zoom in on a region of the graph](../test/how-to-zoom-in-on-a-region-of-the-graph-in-load-test-results.md)