---
title: "Analyze load test Errors Using the Counters Panel in Visual Studio"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "Load Test Analyzer, counters panel"
ms.assetid: 981b4f1e-505a-4078-a06d-58ae17d996b4
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# How to: Analyze Errors Using the Counters Panel

The Counters panel is visible in the Graphs view and the Tables view in the Load Test Analyzer while a load test is running, or when you are analyzing a load test result. For more information, see [Analyze Load Test Results in the Graphs View](../test/analyze-load-test-results-in-the-graphs-view.md), [Analyze Load Test Results and Errors in the Tables View](../test/analyze-load-test-results-and-errors-in-the-tables-view.md) and [How to: Access Load Test Results for Analysis](../test/how-to-access-load-test-results-for-analysis.md).

 The **Errors** node in the Counters panel contains all the errors that were detected during the load test. The Errors node contains several sub-category error nodes that are specific to different kinds of errors. For example, **Exceptions** and **HTTP Errors**.

 ![Counter panel's error node](../test/media/ltest_errornode.png "LTest_ErrorNode")

## To analyze errors in the Counters panel

1.  After a load test completes, or after you load a test result, in the Load Test Analyzer's toolbar, choose either **Graphs** or **Tables**.

     The **Counters** panel displays in either the Graphs view or the Tables view.

2.  If the Counters panel is not visible, choose **Show Counters Panel** on the toolbar.

3.  Expand the **Errors** and select either an error category, or an error sub-category that you want to analyze.

4.  Right-click the error and select one of the following options:

    -   **Show Counter on Graph**: In the Graphs view, the error is added and highlighted on the selected graph. For more information, see [How to: Add and Delete Counters on Graphs](../test/how-to-add-and-delete-counters-on-graphs-in-load-test-results.md).

    -   **Show Counter on Legend**: The error is added and selected in the Legend. For more information, see [Using the Graphs View Legend to Analyze Load Tests](../test/use-the-graphs-view-legend-to-analyze-load-tests.md).

    -   **Add Graph**:

    1.  The **Enter Graph Name** dialog box is displayed.

    2.  In the **Graph name** text box, type a name for the new graph and then choose **OK**.

    3.  (Optional) Right-click the error again and select **Show Counter on Graph**.

         For more information, see [How to: Create Custom Graphs](../test/how-to-create-custom-graphs-in-load-test-results.md).

5.  (Optional) If you are analyzing an error in a completed load test result, consider using the zoom features while in the Graphs. For more information, see [How to: Zoom in on a Region of the Graph](../test/how-to-zoom-in-on-a-region-of-the-graph-in-load-test-results.md).

    > [!TIP]
    > If any errors were detected during the load test run, a link titled errors including the number found will be present in the Load Test Analyzer status bar. You can choose the link to display all the errors in the **Errors** table of the Tables view.

## See also

- [Using the Counters Panel in Graphs View and Tables View](../test/counters-panel-in-load-test-analyzer.md)
- [Analyze Load Test Results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)