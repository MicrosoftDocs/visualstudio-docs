---
title: "Load Test Results Summary Overview"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.test.load.monitor.summary.view"
helpviewer_keywords: 
  - "load test results, summary"
  - "load tests, summary in analyzer"
  - "load tests, results summary"
  - "Load Test Viewer, summary"
  - "load tests, summary in Load Test Viewer"
ms.assetid: 326b6c3c-5378-452b-8ca3-ba5a06ab3d41
caps.latest.revision: 33
ms.author: "ahomer"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Load Test Results Summary Overview
After you run a load test, you can view the load test summary to understand the results quickly. The load test summary provides the key results in a compact and easy to read format. You can also print the load test summary. This makes it convenient to use when you communicate results to stakeholders. The load test summary is also the default view when you open a load test result from a previously run load test. For more information, see [How to: Access Load Test Results for Analysis](../test/how-to--access-load-test-results-for-analysis.md).  
  
 ![Summary view](../test/media/ltest_summaryview.png "LTest_SummaryView")  
Summary view in Load Test Analyzer  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
## The Load Test Summary  
 The load test summary is divided into sections. The initial sections appear at the top of the summary, and are always visible. When you view the load test summary, the following items are first:  
  
-   [Test Run Information](#TestRunInformation)  
  
-   [Overall Results](#OverallResults)  
  
-   [Key Statistic: Top 5 Slowest Pages](#SlowestPages)  
  
-   [Key Statistic: Top 5 Slowest Tests](#SlowestTests)  
  
-   [Key Statistic: Top 5 Slowest SQL Operations](#SlowestQueries)  
  
    > [!NOTE]
    >  The SQL Operations section is displayed only if SQL tracing is enabled in the load test.  
  
 The closing sections appear at the end of the summary, and can be collapsed to save space. The following items appear at the end of the load test summary:  
  
-   [Test Results](#TestResults)  
  
-   [Page Results](#PageResults)  
  
-   [Transaction Results](#TransactionResults)  
  
-   [System Under Test Resources](#SystemUnderTest)  
  
-   [Controller and Agent Resources](#ControllerAndAgent)  
  
-   [Errors](#Errors)  
  
###  <a name="TestRunInformation"></a> Test Run Information  
 The test run information section contains general information about the run including the name of the test, the start and end times, and the controller that ran the test. This section also contains the optional description of the run that you add when you run the load test.  
  
###  <a name="OverallResults"></a> Overall Results  
 The overall results section contains summary results of the test including the number of requests per second, the total number of failed requests, the average response time, and the average page time.  
  
###  <a name="SlowestPages"></a> Key Statistic: Top 5 Slowest Pages  
 The slowest pages section contains the top 5 slowest pages in the load test. The URL and the average page load time are displayed for each page. The pages are listed in descending order. You can choose the URL of a page to open the **Pages** table and inspect more details for that page. For more information, see [How to: View Web Page Response](../test/how-to--view-web-page-response-time-in-a-load-test-using-the-load-test-analyzer.md).  
  
 The percentile value for **95% Page Time (sec)** report that 95% of the pages completed in less than this time in seconds.  
  
###  <a name="SlowestTests"></a> Key Statistic: Top 5 Slowest Tests  
 The slowest tests section contains the top 5 slowest tests in the load test. The name of the test and the average test time are displayed for each test. The tests are listed in descending order. You can choose the name of a test to open the **Tests** table and inspect more details for that test. For more information, see [Analyzing Load Test Results and Errors in the Tables View](../test/analyzing-load-test-results-and-errors-in-the-tables-view-of-the-load-test-analyzer.md).  
  
 The percentile value for **95% Test Time (sec)** report that 95% of the tests completed in less than this time in seconds.  
  
###  <a name="SlowestQueries"></a> Key Statistic: Top 5 Slowest SQL Operations  
 If SQL tracing is enabled in the load test, the slowest queries section contains the top 5 slowest queries in the load test. The name of the operation and the duration are displayed for each test. The duration is displayed in microseconds ([!INCLUDE[sqprsqlong](../debugger/includes/sqprsqlong_md.md)]) or milliseconds (SQL Server 2000 and earlier). The tests are listed in descending order by duration. You can choose the name of an operation to open the **SQL Trace** table and inspect more details for that operation. For more information, see [The SQL Trace Data Table](../test/analyzing-load-test-results-and-errors-in-the-tables-view-of-the-load-test-analyzer.md#AnalyzingLoadTestResultsErrorsTablesViewViewingTheSQLTraceDataTable).  
  
###  <a name="TestResults"></a> Test Results  
 The test results section contains a list of all the tests and scenarios in the load test. The name of the test, the scenario, the number of times it ran, the number of times it failed, and the average test time are displayed. You can choose the name of a test to open the **Tests** table and inspect more details for that test. For more information, see [Analyzing Load Test Results and Errors in the Tables View](../test/analyzing-load-test-results-and-errors-in-the-tables-view-of-the-load-test-analyzer.md).  
  
> [!NOTE]
>  You can collapse and expand this section by choosing the arrow to the left of the section title.  
  
###  <a name="PageResults"></a> Page Results  
 The page results section contains a list of all the Web pages in the load test. The URL, the scenario, the name of the test, the average page time, and the count are displayed. You can choose the URL of a page to open the **Pages** table and inspect more details for that page. For more information, see [How to: View Web Page Response](../test/how-to--view-web-page-response-time-in-a-load-test-using-the-load-test-analyzer.md).  
  
> [!NOTE]
>  You can collapse and expand this section by choosing the arrow to the left of the section title.  
  
###  <a name="TransactionResults"></a> Transaction Results  
 The transaction results section contains a list of all the transactions in the load test. The name of the transaction, the scenario, the test, the response time, the elapsed time, and the count are displayed. You can choose the name of a transaction to open the **Transactions** table and inspect more details for that transaction. For more information, see [Analyzing Load Test Results and Errors in the Tables View](../test/analyzing-load-test-results-and-errors-in-the-tables-view-of-the-load-test-analyzer.md).  
  
> [!NOTE]
>  You can collapse and expand this section by choosing the arrow to the left of the section title.  
  
 The percentile values report the following transaction information:  
  
-   90% of the total transactions were completed in less than \<time> seconds.  
  
-   95% of the total transactions were completed in less than \<time> seconds.  
  
###  <a name="SystemUnderTest"></a> System Under Test Resources  
 The system under test resources section contains a list of computers that are the set of target computers for which load is being generated. This includes any computer from which you collect counter sets other than Agent or Controller. The computer name, % processor time, and available memory are displayed. You can choose a computer name to open the **System under Test** graph and see the resource usage over time. For more information, see [Analyzing Load Test Results in the Graphs View](../test/analyzing-load-test-results-in-the-graphs-view-of-the-load-test-analyzer.md).  
  
> [!NOTE]
>  You can collapse and expand this section by choosing the arrow to the left of the section title.  
  
###  <a name="ControllerAndAgent"></a> Controller and Agent Resources  
 The controller and agent resources section contains a list of the computers that are used to run the test. The computer name, % processor time, and available memory are displayed. You can choose a computer name to open the **Controller and Agents** graph and see the resource usage over time. For more information, see [Analyzing Load Test Results in the Graphs View](../test/analyzing-load-test-results-in-the-graphs-view-of-the-load-test-analyzer.md).  
  
> [!NOTE]
>  You can collapse and expand this section by choosing the arrow to the left of the section title.  
  
###  <a name="Errors"></a> Errors  
 The errors section contains a list of all the errors that occurred during the load test. The type and subtype of the error, the count, and the last message are displayed. You can choose an error to open the **Errors** table and inspect more details for that error. For more information, see [Analyzing Load Test Results and Errors in the Tables View](../test/analyzing-load-test-results-and-errors-in-the-tables-view-of-the-load-test-analyzer.md) and [How to: Analyze Errors Using the Counters Panel](../test/how-to--analyze-errors-using-the-counters-panel.md).  
  
> [!NOTE]
>  You can collapse and expand this section by choosing the arrow to the left of the section title.  
  
## Printing a Summary  
 You can print the load test summary by choosing **Print** on the shortcut menu on the summary. You can preview the print first by choosing **Print Preview** on the shortcut menu on the summary. You can also print directly from the preview screen.  
  
## See Also  
 [Load Test Analyzer Overview](../test/load-test-analyzer-overview.md)   
 [Analyzing Threshold Rule Violations](../test/analyzing-threshold-rule-violations-in-load-tests-using-the-load-test-analyzer.md)   
 [Analyzing Load Test Results](../test/analyzing-load-test-results-using-the-load-test-analyzer.md)