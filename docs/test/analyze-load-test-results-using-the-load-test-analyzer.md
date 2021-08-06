---
title: Analyzing Load Test Results
description: Learn how to use the Load Test Analyzer to find bottlenecks, identify errors, and measure improvements in your app.
ms.custom: SEO-VS-2020
ms.date: 10/20/2016
ms.topic: conceptual
helpviewer_keywords:
- load tests, test results
- load tests, analyzing test results
- load tests, managing test results
ms.assetid: 8a4ba300-425d-447c-91d9-c53f4345feee
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# Analyze load test results using the Load Test Analyzer

Find bottlenecks, identify errors, and measure improvements in your app when you use the **Load Test Analyzer**.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

Analyze load test results in these ways:

- Monitor a load test when it is running.

- Analyze a load test after it has completed.

- View results from a previous load test.

You can also create reports that compare two or more reports for trend analysis to share with stakeholders. See [Reporting load tests results for test comparisons or trend analysis](../test/compare-load-test-results.md).

You can complete these tasks whether you run your load test from Visual Studio Enterprise or from the command line, and whether you run your load test on a single computer or on a remote machine.

## Differences between analyzing a running and a completed load test

When you run a load test, the **Load Test Analyzer** displays in a separate tab, together with the name of your load test and the time that the test was started (for example, **LoadTest1 [12:40 PM]**). When a load test runs, a smaller set of the performance counter data is maintained in memory. You can monitor this set of data when your load test runs. After a load test has completed, you can analyze the full set of data from the database. Differences exist in what data is displayed when a load test runs and what data that you can see after a load test has completed. For example, 90 percent and 95 percent response time data is not calculated until the load test has completed. Some differences also occur in the functionality of the tools that are available to analyze the data.

When you run the load test, two views are available: The **Graphs** view and the **Tables** view. The **Graphs** view allows you to graph performance counters that are collected. The **Tables** view gives you information about each of the tests, pages, transactions, and requests that are collected. You also get a table that lists the errors.

By default, when the load test run has completed, the **Summary** view is displayed. You can switch between the **Summary**, **Graphs**, **Tables**, and **Details** views by using the toolbar. The **Load Test Analyzer** can be docked or set to float by using the usual Visual Studio window manipulation techniques. When you analyze completed load test runs, you can have multiple **Load Test Analyzers** open at the same time to compare the different load test runs.

## Tasks

|Tasks|Associated topics|
|-|-|
|**Accessing the results of your load test:** When you run a load test from the Load Test Editor, the load test results open automatically and the running load test is displayed in the **Load Test Analyzer**.|-   [How to: Access load test results for analysis](../test/how-to-access-load-test-results-for-analysis.md)|
|**Add analysis notes to your load test:** You can add comments to your load test when you conduct your analysis. The comments are stored permanently, together with the load test result. The description that you enter also displays in the **Description** column that is associated with the load test in the **Open and Manage Test Results** dialog box in the Load Test Editor.<br /><br /> For more information, see [How to: Access load test results for analysis](../test/how-to-access-load-test-results-for-analysis.md).<br /><br /> Additionally, the comments are displayed when you create an Excel report for the load test results.<br /><br /> For more information, see [Reporting load tests results for test comparisons or trend analysis](../test/compare-load-test-results.md).||
|**Analyzing the results of your load test:** After you access the load test run data, you can analyze the resulting data. You can view the Load Test Summary to understand the results quickly. The load test summary shows the key results in a compact and easily read format.<br /><br /> You can print the load test summary. This makes it convenient to use when you communicate results to stakeholders.<br /><br /> You can analyze the details of your load test results by using the graphs and tables in the results. These include **Errors**, **Pages**, **Requests**, **SQL Trace**, **Tests**, **Thresholds**, and **Transactions**.|-   [Load test results summary overview](../test/load-test-results-summary-overview.md)<br />-   [How to: View web page response](../test/how-to-view-web-page-response-time-in-a-load-test.md)<br />-   [Analyzing threshold rule violations](../test/analyze-threshold-rule-violations-in-load-tests.md)<br />-   [Analyze load test results in the Graphs view](../test/analyze-load-test-results-in-the-graphs-view.md)<br />-   [Analyze load test results and errors in the Tables view](../test/analyze-load-test-results-and-errors-in-the-tables-view.md)|
|**Analyzing the virtual user activity in your load test results to isolate performance issues:** You can use the Virtual User Activity Chart to visualize what virtual users are doing during a load test. This can help you isolate spikes in a CPU or drops in requests/sec, and determine which tests or pages are running during these spikes and drops.|-   [Analyzing virtual user activity in the Details view](../test/analyze-load-test-virtual-user-activity-in-the-details-view.md)|
