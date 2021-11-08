---
title: Analyzing Load Test Results and Errors
description: Learn how to display panes that provide you with different ways to analyze the results of a load test run, such as a graph over time or detailed tables.
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: conceptual
f1_keywords:
- vs.test.load.monitor.pageresult
- vs.test.load.dialog.column
- vs.test.load.monitor.requestresult
- vs.test.load.monitor.testresult
- vs.test.load.monitor.table.view
- vs.test.load.monitor.agentresult
- vs.test.load.monitor.transactionresult
helpviewer_keywords:
- tables, Load Test Viewer options
- load test results, tables
- load tests, Load Test Viewer
- data [Visual Studio ALM], load test tables
- Load Test Viewer, tables
- load tests, results tables
ms.assetid: 0a84bda3-6051-45eb-9c7f-d57419e1f97d
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# Analyze load test results and errors in the Tables view of the Load Test Analyzer

When you view the results of a load test run, you can display different panes that provide you with different ways to analyze the data. You can view the data as a graph, to see how it changes over time, or you can view the data as detailed tables.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

To switch to table view, choose **Tables** on the **load test** toolbar. To switch between the different tables, use the **Table** drop-down list on the toolbar above the table grid. In table view, you can view up to four tables at a time. For more information, see [Tile load test tables](../test/analyze-load-test-results-and-errors-in-the-tables-view.md#tile-load-test-tables) in this topic.

Most numeric values displayed in a table for performance counters are cumulative over the whole load test run. Columns named **Last** are an exception, and represent the value from the most recent sampling interval.

> [!NOTE]
> Columns named **Last** are available only while a load test is executing. After a load test is completed, these columns are not available.

You can sort most tables by choosing the title of the column that you want to sort on. By default, some tables do not display all available columns. You can add columns to tables, if columns are available. To add columns, right-click the table and then choose **Add/Remove Columns**.

> [!NOTE]
> You can copy the data from a table into other applications such as Excel for additional analysis.

## The load test tables

The following table lists the tables that are available to analyze load test runs.

|Table Name|Description|
|-|-|
|Errors|Displays a list of errors that occurred during the load test run. For more information, see [The Errors table](../test/analyze-load-test-results-and-errors-in-the-tables-view.md#the-errors-table) in this topic, and [Analyze load test results](../test/analyze-load-test-results-using-the-load-test-analyzer.md).|
|Pages|Displays a list of pages accessed during a load test run. Some data in this table is available only after a load test has completed. For more information, see [How to: View web page response](../test/how-to-view-web-page-response-time-in-a-load-test.md).|
|Requests|Displays details for individual requests issued during a load test. This includes all HTTP requests, and dependent requests such as images. For more information, see [The Requests table](../test/analyze-load-test-results-and-errors-in-the-tables-view.md#the-requests-table) in this topic.|
|SQL Trace|Displays the results of SQL tracing. This table is available only after a load test has completed, and only if SQL tracing was used during the test. For more information, see [The SQL Trace data table](../test/analyze-load-test-results-and-errors-in-the-tables-view.md#the-sql-trace-data-table) in this topic.|
|Tests|Displays details for individual tests run during a load test. For more information, see [The Tests table](../test/analyze-load-test-results-and-errors-in-the-tables-view.md#the-tests-table) in this topic.|
|Thresholds|Displays a list of threshold rule violations that occurred during the load test run. For more information, see [Analyzing threshold rule violations](../test/analyze-threshold-rule-violations-in-load-tests.md).|
|Transactions|Displays a list of transactions that occurred during a load test run. For more information, see [The Transactions table](../test/analyze-load-test-results-and-errors-in-the-tables-view.md#the-transactions-table) in this topic.|
|Agents|Displays only if your load test is using a test controller and test agents. Displays a list of the agents that were used during the load test run. The Agents table includes how many requests the agent tested and of those requests, how many failed. Additionally, the Agents table includes the number of tests in the load tests test mix that the agent tested and of those, how many failed.|
|Test Details|Displays details for the tests included in the test mix for the load test. The details include the name of the test, the scenario that the test was in, the time that the test started, the length of time it took the test to run, and the test outcome indicating if the test passed or failed. If the test failed, a link is present in the **Details** column. You can choose the link which will take you to the Web Performance Test Editor with the failed request highlighted.|

## Collect percentile data

Some load test tables can contain additional columns, which include percentile data and response times broken into groups based on network emulation. By default, this data is not collected. Percentile data is only available when you save results to a database, and not when you save locally. For more information, see [Managing load test results in the Load Test Results Repository](../test/manage-load-test-results-in-the-load-test-results-repository.md). Additionally, to collect this data, in the **Load Test Editor**, under the **Run Settings** node, select the specific run setting node to change. In the **Properties** window, for the **Timing Details Storage** property, select **StatisticsOnly** or **AllIndividualDetails**. For more information, see [How to: View web page response](../test/how-to-view-web-page-response-time-in-a-load-test.md).

## The Requests table

The **Requests** table displays details for individual requests issued during a load test. This includes all HTTP requests, and dependent requests such as images. The table lists requests by test and scenario, because one request can be included in many tests and scenarios.

The following table lists the columns in the **Requests** table:

|Column|Description|Visible by Default|
|-|-|-|
|**Request**|The URL of the request. For example, *home.html*, or *orange-arrow.gif*.|Yes|
|**Scenario**|The name of the scenario.|Yes|
|**Test**|The name of the test.|Yes|
|**Total**|The total number of this web performance test request issued during the load test run. The total includes passed and failed requests, but does not include cached requests, because they are not issued to the web server.|Yes|
|**Passed**|The number of times the request was issued and passed.|No|
|**Failed**|The number of times the request was issued and failed. The entries in this column appear as hyperlinks. You can choose any hyperlink to view a list of the individual errors in the **Load Test Errors** dialog box. For more information, see [Analyze load test results](../test/analyze-load-test-results-using-the-load-test-analyzer.md).|Yes|
|**Cached**|The total number of times the request was already cached.|No|
|**Requests/Sec**|The rate per second of the request during the load test run.|No|
|**Passed/Sec**|The rate per second of this request during the load test run, for the instances of this request that passed.|No|
|**Failed/Sec**|The rate per second of this request during the load test run, for the instances of this request that failed.|No|
|**First Byte Time**|The average time to receive the first byte of the response, measured from the time the request was sent to the web server. The units are seconds.|No|
|**Response Time**|The average time to receive the entire response to a request, measured from the time the request was sent to the web server. The units are seconds.|Yes|
|**Content Length**|The average length of the content of the response to the request. The units are bytes.|Yes|

## The Tests table

The **Tests** table displays details for individual tests run during a load test. The table lists tests by test and scenario, because one test can be included in many scenarios.

The following table lists the columns in the **Tests** table.

|Column|Description|Visible by Default|
|-|-|-|
|**Test**|The name of the test.|Yes|
|**Scenario**|The name of the scenario.|Yes|
|**Total**|The total number of times the test was run in the scenario. This includes the number of times the test passed and failed.|Yes|
|**Passed**|The number of times the test was run in the scenario and passed.|Yes|
|**Failed**|The number of times the test was run in the scenario and failed. The entries in this column appear as hyperlinks. You can choose any hyperlink to view a list of the individual errors in the **Load Test Errors** dialog box. For more information, see [Analyze load test results](../test/analyze-load-test-results-using-the-load-test-analyzer.md).|Yes|
|**Tests/Sec**|The rate per second of the test during the load test run.|Yes|
|**Passed/Sec**|The rate per second of this test during the load test run, for the instances of this test that passed.|No|
|**Failed/Sec**|The rate per second of this test during the load test run, for the instances of this test that failed.|No|
|**Test Time**|The average time to execute the test during the load test run. The units are seconds.|Yes|
|**90% Test Time**|The 90th percentile value for Test Time.|No|
|**95% Test Time**|The 95th percentile value for Test Time.|Yes|
|**Requests/Test**|The average number of requests in the test if it is a web performance test.|No|

## The Transactions table

The **Transactions** table displays a list of transactions that occurred during a load test run. Transactions refer to either transactions defined in a web performance test, or timers defined in a unit test. Transaction does not refer to database transactions.

The following table lists the columns in the **Transactions** table.

> [!NOTE]
> To view all columns, you must enable the Timing Details Storage property that is associated with the active run setting. For more information, see [How to: Specify the Timing Details Storage property](../test/how-to-specify-the-timing-details-storage-property-for-a-load-test.md).

|Column|Description|Visible without timing details|
|-|-|-|
|**Transaction**|The name of the transaction.|Yes|
|**Scenario**|The name of the scenario.|Yes|
|**Test**|The name of the test.|Yes|
|**Total**|The total number of transactions issued during the load test run.|Yes|
|**Transaction Time**|The time to execute the transaction during a load test run. For web performance tests, think time is included in the calculation. The units are seconds.|No|
|**Response Time**|The response time for the web performance test transaction in a load test run. Response Time is different from Transaction Time in that Response Time does not include any think time that occurred during the transaction. The units are seconds.|No|
|**Ave. Transaction Time**|The average transaction time. This time includes think times. For example, if you have three requests and each has a think time, this time will include those think times and the actual time to execute requests.|No|
|**Ave. Response Time**|The average response time for a web performance test transaction in a load test run. Response Time is different from Transaction Time in that Response Time does not include any think time that occurred during the transaction. The units are seconds.|No|
|**Min Response Time**|This does not include think times.|No|
|**Max Response Time**|This does not include think times.|No|
|**Median Response Time**|This does not include think times.|No|
|**90% Response Time**|The 90th percentile value for Transaction Time. This does not include think times. **Note:**  This is different from Visual Studio Team System 2008 Test Load Agent, which used the **90% Transaction Time** value.|No|
|**95% Response Time**|The 95th percentile value for Transaction Time. This does not include think times. **Note:**  This is different from Visual Studio Team System 2008 Test Load Agent, which used the **95% Transaction Time** value.|No|
|**99% Response Time**|The 99th percentile value for Transaction Time. This does not include think times.|No|
|**Std Dev Response Time**|This does not include think times.|No|

## The Errors table

When you run a load test, you can analyze errors that occur. Analyzing errors and adjusting your tests are an important part of the load test process. If any errors occurred, an **errors** hyperlink appears on the load test status bar and specifies the number of errors that occurred. To display the errors table, you choose the hyperlink.

The errors table groups the errors that occurred during a load test by the type and subtype of the error. There is also a **total** line in the table that specifies the total count of all the errors that occurred.

The errors table contains the following columns:

|Column|Description|Visible by default|
|-|-|-|
|Type|The type of the error. For example, HttpError.|Yes|
|SubType|The subtype of the error. For example, LoadTestException.|Yes|
|Count|The number of errors of this type that occurred during the load test. The entries in this column appear as hyperlinks. You can choose any hyperlink to view a list of the individual errors.|Yes|
|Last Message|A message that describes the error. For example, 404 - NotFound.|Yes|

For more information, see [Working with load test tables](../test/analyze-load-test-results-and-errors-in-the-tables-view.md).

### Drill down to the error list

The errors table groups the errors by the type and subtype of the error. To view a table of the individual errors, you display the **Load Test Errors** dialog box. To display the dialog box, choose a hyperlink in the **Count** column of the errors table. You can also display the dialog box by right-clicking a row in the errors table that is populated, and choosing **Errors**.

> [!NOTE]
> Only the first 1,000 instances of any error type and subtype combination are collected. When you display the **Load Test Errors** dialog box, you will see at most the first 1,000 instances that error.

The **Load Test Errors** table contains the following columns:

|Column|Description|
|-|-|
|**Time**|The time during the load test at which the error occurred.|
|**Agent**|The name of the agent computer on which the error occurred. This is important when you run load tests using test controllers and test agents. For more information, see [Install and configure test agents](../test/lab-management/install-configure-test-agents.md).|
|**Test**|The name of the web performance test in which the error occurred.|
|**Scenario**|The name of the scenario in which the error occurred.|
|**Request**|The URL of the request in which the error occurred.|
|**Type**|The type of the error. For example, HttpError.|
|**SubType**|The subtype of the error. For example, LoadTestException.|
|**Text**|The text of the error message. For example, 404 - NotFound.|
|**Stack**|The entries in this column are either empty, or the word **Stack** is formatted as a hyperlink. You can choose the hyperlink to view a stack trace of the error.|
|**Details**|The entries in this column are either empty, or the word **TestLog** is formatted as a hyperlink. This link can help you isolate errors in the load test. For example, choosing the **TestLog** link on a web performance test request error will open up the results for the web performance test in the Web Performance Test Results Viewer and highlight the request error.|

> [!NOTE]
> You can sort the table by choosing the column headers.

## The SQL Trace data table

You can collect SQL trace data during a load test run to analyze later. Collecting trace data lets you identify the slowest running queries and stored procedures in the SQL Server database being tested.

If SQL tracing is enabled, a file is created during the load test run that contains the trace data. This data is automatically saved in the Load Test Results Store at the end of the test run and the trace file is deleted. You analyze the trace data in the **SQL Trace** table after your load test has completed.

### To view SQL trace data

1. In the Load Test Analyzer, choose **Tables** on the toolbar to make sure that the table grid is displayed.

2. In the **Table** drop-down list box, select **SQL Trace**.

3. The trace data that was collected during the run is displayed in the grid. The table lists the slowest running SQL operations sorted by duration, with the slowest at the top. Typically, the **Duration** column is the first column to examine. The data is displayed in milliseconds.

   The columns displayed are as follows:

    - **Event Class**

    - **Duration**

    - **CPU**

    - **Reads**

    - **Writes**

    - **TextData**

    - **StartTime**

    - **EndTime**

   If you want to trace SQL events other than the data identified in these columns, you can set up your own custom SQL tracing using the SQL Profiler tool, separate from Visual Studio.

## Tile load test tables

When you view the results of a load test run, you can view the data as detailed tables. To switch to table view, choose **Tables** on the **load test** toolbar. The tables that are available are **Errors**, **Pages**, **Requests**, **SQL Trace**, **Tests**, **Thresholds**, and **Transactions**. For more information, see [Working with load test tables](../test/analyze-load-test-results-and-errors-in-the-tables-view.md).

In table view, you can view up to four tables at a time without the tables overlapping.

### To tile tables

1. On the **Load Test Analyzer** toolbar, choose **Tables**.

     Table view opens. The default layout is two horizontal panels.

2. On the **Load Test Analyzer** toolbar, choose the **layout** button and then choose one of the following options:

    - **One Panel**

    - **Two Horizontal Panels**

    - **Three Horizontal Panels**

    - **Four Horizontal Panels**

3. To switch between the different tables, use the drop-down list above the table grid in each panel.

    > [!NOTE]
    > You cannot display the same table in more than one panel. If you change the table displayed in one panel to a table already displayed in another panel, the tables switch panels.

## See also

- [Analyze load test results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)
- [How to: Access load test results for analysis](../test/how-to-access-load-test-results-for-analysis.md)
- [Analyze load test results in the Graphs view](../test/analyze-load-test-results-in-the-graphs-view.md)
- [Analyze threshold rule violations](../test/analyze-threshold-rule-violations-in-load-tests.md)
- [Manage load test results in the Load Test Results Repository](../test/manage-load-test-results-in-the-load-test-results-repository.md)
- [Load test results summary overview](../test/load-test-results-summary-overview.md)
