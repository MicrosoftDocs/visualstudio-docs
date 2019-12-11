---
title: "Analyze load test results"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "results, load test"
  - "load test results, accessing"
  - "Load Test Viewer"
  - "load tests, accessing"
  - "load tests, analyzing"
  - "load tests, results"
  - "Load Test Viewer, viewing"
ms.assetid: b0a3e694-2894-479b-b270-7e61e9fafacd
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Access load test results for analysis

When you run a load test from the Load Test Editor, the load test results open automatically and the running load test is displayed in the **Load Test Analyzer**. When you run a load test from the command line, you must access the load test results manually.

The load test result for the completed load test contains performance counter samples and error information that was collected periodically from the computers-under-test. A large number of performance counter samples can be collected over the course of a load test run. The amount of performance data that is collected depends on the length of the test run, the sampling interval, the number of computers under test, the number of counters being collected, the data collectors that are configured, and the logging levels. For a large load test, the amount of performance data that is collected can easily be several gigabytes. For more information, see [Test controllers and test agents](configure-test-agents-and-controllers-for-load-tests.md).

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## To access a load test result

1. From a web performance and load test project, open a load test.

2. In the Load Test Editor's toolbar, choose the **Open and Manage Results** button.

     The **Open and Manage Results** dialog box appears.

3. In **Enter a controller name to find load test results**, select a controller. Select **\<local> - No controller** to access results stored locally.

4. In **Show results for the following load test**, select the load test whose results you want to view. Select **\<Show results for all tests>** to see all results for all tests.

     If there are load test results available, they appear in the **Load test results** list. The columns are **Time**, **Duration**, **User**, **Outcome**, **Test**, and **Description**. **Test** contains the name of the test, and **Description** contains the optional description that is added before the test is run.

    > [!NOTE]
    > The results appear with the most recent results at the top of the list.

5. In the **Load test results** list, select the load test results you want to analyze and choose **Open**.

6. The **Load Test Analyzer** appears. The selected load test result is displayed in the Summary view. For more information, see [Load test results summary overview](../test/load-test-results-summary-overview.md).

     You can manage other aspects of load test results in the **Open and Manage Results** dialog box including importing, exporting, and removing load test results. For more information, see [Manage load test results in the load test results repository](../test/manage-load-test-results-in-the-load-test-results-repository.md).

## See also

- [Analyze load test results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)