---
title: "Page Response Time in a Load Test in Visual Studio"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, response times"
  - "response times in load tests"
  - "load test results, response times"
ms.assetid: e61c49f3-3161-45b1-9220-08b5459065a2
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# How to: View Web Page Response Time in a Load Test Using the Load Test Analyzer

The time it takes for each Web page to load is known as *response time*. When you create a Web performance test, you can set a response time goal for each Web page request in your Web performance test.

If you run your Web performance test under stress in a load test, you will be able to analyze the following information for each page:

-   The average response time for the page.

-   The percent of test iterations that meet the response time goal for the page.

-   You can analyze Web page response times by using the Tables view or the Graphs view in the Load Test Analyzer:

-   Analyzing Web page response times in the tables view

-   Analyzing Web page response times in the graphs view

## View Response Time Data in a Table

### To view response time data in a table

1.  In the Load Test Analyzer, choose **Tables** on the toolbar to make sure that the table grid is displayed.

2.  In the **Table** drop-down list box, select **Pages**.

3.  The data for each page is displayed in the grid. The following columns are ordinarily displayed.

    |||
    |-|-|
    |**Page**|The name of the Web page.|
    |**Scenario**|The name of the scenario. Important if you have more than one scenario in your Web performance test.|
    |**Test**|The name of the Web performance test. Important if you have more than one Web performance test in your load test.|
    |**Network**|The network type.<br /><br /> By default, this data is not collected. To collect this data, in the **Load Test Editor**, under the **Run Settings** node, select the run setting node to change. In the **Properties** window, for the **Timing Details Storage** property, select **AllIndividualDetails**.|
    |**Total**|The total number of requests that were made for the Web page. This is the total for all iterations in the load test.|
    |**Ave**|Average page response time.<br /><br /> By default, this data is not collected. To collect this data, in the **Load Test Editor**, under the **Run Settings** node, select the run setting node to change. In the **Properties** window, for the **Timing Details Storage** property, select **AllIndividualDetails**.|
    |**Min**|The minimum page response time.<br /><br /> By default, this data is not collected. To collect this data, in the **Load Test Editor**, under the **Run Settings** node, select the run setting node to change. In the **Properties** window, for the **Timing Details Storage** property, select **AllIndividualDetails**.|
    |**Median**|The median page response time.<br /><br /> By default, this data is not collected. To collect this data, in the **Load Test Editor**, under the **Run Settings** node, select the run setting node to change. In the **Properties** window, for the **Timing Details Storage** property, select **AllIndividualDetails**.|
    |**90%**|The 90th percentile for the response time. This indicates that 90% of the pages responded faster than this number, and 10% of the pages responded more slowly.<br /><br /> By default, this data is not collected. To collect this data, in the **Load Test Editor**, under the **Run Settings** node, select the run setting node to change. In the **Properties** window, for the **Timing Details Storage** property, select **AllIndividualDetails**.|
    |**95%**|The 95th percentile for the response time. This indicates that 95% of the pages responded faster than this number, and 5% of the pages responded more slowly.|
    |**99%**|The 99th percentile for the response time. This indicates that 99% of the pages responded faster than this number, and 1% of the pages responded more slowly.<br /><br /> By default, this data is not collected. To collect this data, in the **Load Test Editor**, under the **Run Settings** node, select the run setting node to change. In the **Properties** window, for the **Timing Details Storage** property, select **AllIndividualDetails**.|
    |**Max**|The maximum page response time.<br /><br /> By default, this data is not collected. To collect this data, in the **Load Test Editor**, under the **Run Settings** node, select the run setting node to change. In the **Properties** window, for the **Timing Details Storage** property, select **AllIndividualDetails**.|
    |**Std Dev**|By default, the standard deviation data is not collected. To collect this data, in the **Load Test Editor**, under the **Run Settings** node, select the run setting node to change. In the **Properties** window, for the **Timing Details Storage** property, select **AllIndividualDetails**.|
    |**Page Time**|The average response time for all requests that were made for the Web page.|
    |**Goal**|The page time goal. This is a constant value for the page. **Note:**  Page Time Goal is displayed only when the goal has been defined for the request in the Web performance test.|
    |**% Meeting Goal**|The percent of the requests that were made for the Web page that met the response time goal.|

 For more information, see [Analyze Load Test Results and Errors in the Tables View](../test/analyze-load-test-results-and-errors-in-the-tables-view.md).

## View Response Time Data in a Graph

You can also view response time data in a graph to see how it changes over time during your load test. This is especially useful if your load pattern increases as the test runs (for example, if you use the step load pattern). For more information, see [Editing Load Patterns to Model Virtual User Activities](../test/edit-load-patterns-to-model-virtual-user-activities.md).

### To view response time data in a graph

1.  In the Load Test Analyzer, choose **Graphs** on the toolbar to make sure that the graph is displayed.

2.  In the **Counters** window, expand the node of the scenario in which you are interested (for example, `Scenario1`).

3.  Expand the node of the Web performance test in which you are interested.

4.  Expand the node **Pages**.

5.  Expand the node of the page in which you are interested.

6.  Right-click **% Pages Meeting Goal** and then choose **Show Counter on Graph**.

     The data is added to the graph.

7.  (Optional) Repeat the previous step for Avg. Page Time, Page Response Time Goal, and Total Pages.

    > [!NOTE]
    > Page Response Time Goal is constant.

 For more information, see [Analyze Load Test Results in the Graphs View](../test/analyze-load-test-results-in-the-graphs-view.md).

## See also

- [Analyze Load Test Results and Errors in the Tables View](../test/analyze-load-test-results-and-errors-in-the-tables-view.md)
- [How to: Access Load Test Results for Analysis](../test/how-to-access-load-test-results-for-analysis.md)
- [Analyze Load Test Results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)