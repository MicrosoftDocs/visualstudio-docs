---
title: "How to: Create Custom Graphs in Load Test Results"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load test results graphs, creating"
  - "load test results graphs"
ms.assetid: 17fcafce-76f9-4411-9389-6e5376eab236
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create custom graphs in load test results

You can design graphs that display specific information about load test results. You design a custom graph by specifying the load test counters that the graph will display.

You can perform the following procedure either while a load test is running or after it has finished running.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## To create a custom load test results graph

1. On the **Load Test** toolbar, choose **Add New Graph**.

     \- or -

     On the **Load Test Analyzer**, right-click in the **Counters** panel or in a graph, and then select **Add Graph**.

     The **Enter Graph Name** dialog box is displayed.

2. Under **Graph name**, type a name for the graph, and choose **OK**.

     The new graph appears in the **Load Test Analyzer**. It appears in the currently selected graph panel; it replaces the graph that was displayed in that panel.

3. Customize the new graph by adding counters. For more information, see [How to: Add and delete counters on graphs](../test/how-to-add-and-delete-counters-on-graphs-in-load-test-results.md).

## See also

- [Analyze load test results in the Graphs view](../test/analyze-load-test-results-in-the-graphs-view.md)
- [How to: Add and delete counters on graphs](../test/how-to-add-and-delete-counters-on-graphs-in-load-test-results.md)