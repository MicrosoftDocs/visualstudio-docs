---
title: "View Data and Diagnostic Attachments for load tests in Visual Studio"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, data and diagnostics attachments"
ms.assetid: 73309bdd-437a-4eb0-88c8-702c3e24b9b0
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# How to: View Data and Diagnostic Attachments Using the Load Test Analyzer

Before you run a load test, you can select a test setting that specifies the diagnostic and data adapters that you want to use. After the load test is finished, you use the Load Test Analyzer to view the details for those diagnostic and data adapters while you analyze the results. To view the data and diagnostic adapter details, choose the **View Data and Diagnostic attachments** button on the Load Test Analyzer's toolbar. For example, if the load test had the system information adapter configured in the test setting, you can view the system information for the machine that was used when the load test was run.

![Choosing Diagnostic Data Adapter Attachment dialog](../test/media/load_adapterdialog.png "Load_AdapterDialog")

Another example is a load test that includes the IntelliTrace adapter in the test setting. The IntelliTrace adapter enables you to open the IntelliTrace Summary page.

![IntelliTrace Summary](../test/media/load_intellitrace.png "Load_IntelliTrace")

For more information, see [Collect Diagnostic Information Using Test Settings](../test/collect-diagnostic-information-using-test-settings.md) and [Collect IntelliTrace data](../test/how-to-collect-intellitrace-data-to-help-debug-difficult-issues.md).

## To view data and diagnostic attachments in a load test from the Load Test Analyzer

1.  After a load test is completed, or after you open a load test result, in the Load Test Analyzer's toolbar, choose **View Data and Diagnostic attachments**.

     The **Choose Diagnostic Data Adapter** dialog box is displayed.

2.  Select the diagnostic data adapter attachment that you want to analyze and then choose **OK**.

## See also

- [Analyze Load Test Results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)