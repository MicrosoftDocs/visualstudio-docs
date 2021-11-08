---
title: Zoom in on load test result graphs
description: Learn how to examine data generated during a load test run in finer detail by using zoom bars to zoom in and scroll to a region of the graph.
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: how-to
f1_keywords: 
  - vs.test.load.monitor.graphzoom
helpviewer_keywords: 
  - graphs, analyzing load tests
  - load tests, zooming with graphs
ms.assetid: 729b4c30-4bc3-4698-91b3-17a676897443
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# How to: Zoom in on a region of the graph in load test results

After a load test has finished, you can use zoom bars to zoom in and scroll to a region of the graph. By zooming in, you can examine the data that was generated during a load test run in finer detail.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

Zoom in is available only when you are analyzing the result of a completed load test, not while you are observing the results of a running test.

The zoom control is visible only in the **Load Test Analyzer** when you view a load test result in zooming mode. Zooming mode is established in the Graph view when either a load test has completed or a load test that has previously run is loaded. You can show or hide the zoom controls on the graphs by using **Show Zoom Controls** on the toolbar.

The **horizontal x-axis zoom** can be adjusted to analyze specific time periods during the load test. The **vertical y-axis zoom** can be adjusted to analyze specific value ranges for the counters that are included in the graph.

Both the **horizontal timeline** and the **vertical value range** zoom controls can be adjusted by using the mouse. The **horizontal timeline control** can also be adjusted by using the left and right arrow keys. By using the arrow keys to adjust the zoom control, you can adjust the windows range by 1 sampling interval at a time. Using the **Shift** and arrow keys makes adjustments of 10 sampling intervals.

To adjust the zoom control by using the arrow key, first set the focus on the zoom control by using the **Tab** key. When the left slider has the focus, the arrow keys will move the starting boundary of the zoom window by 1 interval left or right. When the focus is on the center slider, you can use the arrow keys to scroll the zoom window left or right 1 sampling interval without changing the size of the zoom window. And finally, the right side slider moves, extending or reducing the range of the end of the zoom window by 1 sampling interval.

To return the horizontal and vertical zoom controls to show the full timeline and value ranges, you can use the **Zoom Out Horizontal** option, the **Zoom Out Vertical** option, or the **Zoom Out Both** option in the pop-up menu on the graph.

> [!TIP]
> You can use **Synchronize Horizontal Zoom Controls** in the toolbar to switch on or off automatic horizontal zoom synchronization. With synchronization on, any zooming you apply to a graph will also be applied to any other graphs on the Graphs view.

![Graph view zoom control](../test/media/ltest_zoomcontrol.png)

In the previous illustration, the **System under Test** graph has been zoomed in to investigate threshold issues. The threshold violations have been enabled by using **Show Threshold Violations On Graph** from the **Graph Options** drop-down in the toolbar.

For more information, see [Analyze load test results in the Graphs view](../test/analyze-load-test-results-in-the-graphs-view.md).

## Display graphs

Before you change the display of a graph by zooming in or out or by scrolling, follow this procedure to display graphs.

To display graphs:

1. Run a load test until it is completed.

2. At the end of the load test run, choose **Yes** in the dialog box that asks about viewing results from the load test results store.

     \- or -

     View the details of a previously run load test. For more information, see [How to: Access load test results for analysis](../test/how-to-access-load-test-results-for-analysis.md).

3. Choose **Graphs** if your graphs are not displayed.

4. If zoom bars are not displayed, choose **Show Zoom Controls**.

     Two zoom bars are available for each graph. The zoom bar that controls vertical scale appears to the left of the graph. The zoom bar that controls horizontal scale appears under the graph.

     Each zoom bar has two handles. A handle is a rectangular area at each end of the zoom bar.

## Zoom and scroll

When you have multiple graphs displayed, you can keep them synchronized so that they display the same portion of the load test run.

### To synchronize zooming and scrolling

1. On the **Load Test Analyzer**, choose **Synchronize Horizontal Zoom Controls**.

     When the **Synchronize Horizontal Zoom Controls** button is selected, zooming and scrolling the time scale of an individual graph also zooms and scrolls the time scale of the other graphs.

2. Again, choose **Synchronize Horizontal Zoom Controls**.

     When the **Synchronize Horizontal Zoom Controls** button is not selected, zooming and scrolling the time scale of an individual graph affects that graph only.

### To zoom and scroll to a region of the graph

1. On the zoom bar under a graph, drag the left-side handle to the right.

     This zooms in on the latter part of the test run. Similarly, dragging the right-side handle to the left zooms in on earlier parts of the test run.

2. To zoom in on a particular area, slide both handles toward the center of a graph.

     The closer the two handles are to each other, the more you zoom in to display shorter, finer segments of the load test.

     Choose the center section of the zoom bar and then drag it to scroll to a particular point in the load test.

### To zoom to a region of the graph by choosing and dragging

1. Choose a graph at one end of the zoom area.

2. Drag the mouse pointer to the other end of the zoom area.

3. Release the mouse button.

    This magnifies the area that you defined by choosing and dragging.

   The following procedure describes how to quickly zoom out without having to adjust the ends of the zoom bar.

### To zoom out

1. Right-click a zoomed-in graph.

2. On the shortcut menu, select **Zoom Out Horizontal**.

     This zooms out to show the entire duration of the load test run.

## See also

- [Analyze load test results in the Graphs view](../test/analyze-load-test-results-in-the-graphs-view.md)
- [Analyze load test results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)
- [How to: Add and delete counters on graphs](../test/how-to-add-and-delete-counters-on-graphs-in-load-test-results.md)
