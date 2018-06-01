---
title: "Threshold Violations for load tests in Visual Studio"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, threshold violations"
ms.assetid: 0126d7b7-0538-4ea9-9046-6556654b3b9d
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# How to: Analyze Threshold Violations Using the Counters Panel in Load Test Analyzer

The Counters panel is visible in the Graphs view and the Tables view in the Load Test Analyzer while a load test is running, or when you are analyzing a load test result. See [Analyze Load Test Results in the Graphs View](../test/analyze-load-test-results-in-the-graphs-view.md), [Analyze Load Test Results and Errors in the Tables View](../test/analyze-load-test-results-and-errors-in-the-tables-view.md) and [How to: Access Load Test Results for Analysis](../test/how-to-access-load-test-results-for-analysis.md).

 Threshold violations are associated with specific performance counters, and indicate that the performance counter either exceeded or fell below a set threshold value. Icons in the counters panel communicate threshold violations.

 ![Counter panel's computer node](../test/media/ltest_compnode.png "LTest_CompNode")

 The icon for a threshold violation is propagated from the tree node where the failed counter resides to the root. The icon alerts the user to a violation on a counter that might not be visible in the tree because the tree has not been expanded. An example of the icon can be seen in the **Computers Node** in Counters Panel in the previous illustration.

 The icon will be one of the following:

 ![No threshold violation](../test/media/icon_ltest_1.gif "Icon_LTest_1") No threshold violation.

 ![A critical threshold violation on last interval](../test/media/icon_ltest_2.gif "Icon_LTest_2") A critical threshold violation occurred on the last interval.

 ![A critical threshold violation on a prior interval](../test/media/icon_ltest_3.gif "Icon_LTest_3") A critical threshold violation occurred on a prior interval.

 ![A warning threshold violation on the last interval](../test/media/icon_ltest_4.gif "Icon_LTest_4") A warning threshold violation occurred on the last interval.

 ![A warning threshold violation on a prior interval](../test/media/icon_ltest_5.gif "Icon_LTest_5") A warning threshold violation occurred on a prior interval.

## To analyze threshold violations in the Counters panel

1.  After a load test completes, or after you load a test result, in the Load Test Analyzer's toolbar, choose either **Graphs** or **Tables**.

     The Counters panel displays in either the Graphs view or the Tables view.

2.  If the Counters panel is not visible, choose **Show Counters Panel** on the toolbar.

     Any nodes that contain threshold violations will include one of the icons listed above.

3.  Expand the node that contains a threshold icon, such as the **Computers** node, as shown in the previous illustration titled "Computers Node in Counters Panel with threshold violation." Continue to expand the node until you reach the performance counter with the threshold violation. For example, the illustration shows the failed instance of the **Microsoft Virtual Machine Failed Bus Network Adapter**.

4.  (Optional) Right-click the performance counter with the threshold violation and select one of the following options:

    -   **Show Counter on Graph**: In the Graphs view, the performance counter is added and highlighted on the selected graph. For more information, see [How to: Add and Delete Counters on Graphs](../test/how-to-add-and-delete-counters-on-graphs-in-load-test-results.md).

        > [!NOTE]
        > Threshold violation icons can also be shown on the graph in the Graphs view. The threshold icon appears on the graph next to the data point where the threshold violation occurred. To do this, choose **Show Legend** drop-down on the toolbar and select **Show Threshold Violations on Graph**.

    -   **Show Counter on Legend**: In the legend, the performance counter is added and selected. For more information, see [Using the Graphs View Legend to Analyze Load Tests](../test/use-the-graphs-view-legend-to-analyze-load-tests.md).

    -   **Add Graph**:

    1.  The **Enter Graph Name** dialog box is displayed.

    2.  In the **Graph name** text box, type a name for the new graph and then choose **OK**.

    3.  (Optional) Right-click the performance counter again and select **Show Counter on Graph**.

         For more information, see [How to: Create Custom Graphs](../test/how-to-create-custom-graphs-in-load-test-results.md).

5.  (Optional) If you are analyzing the threshold violation in a completed load test result, consider using the zoom features in the Graphs view. For more information, see [How to: Zoom in on a Region of the Graph](../test/how-to-zoom-in-on-a-region-of-the-graph-in-load-test-results.md).

    > [!TIP]
    > If any threshold violations were detected during the load test run, a link titled "threshold violations," including the number of violations, will be present in the Load Test Analyzer status bar. You can choose the link to display all the threshold violations in the **Thresholds** table of the Tables view.

## See also

- [Using the Counters Panel in Graphs View and Tables View](../test/counters-panel-in-load-test-analyzer.md)
- [Analyze Load Test Results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)