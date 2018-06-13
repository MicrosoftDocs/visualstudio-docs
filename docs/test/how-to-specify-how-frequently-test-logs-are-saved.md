---
title: "Saving load test logs in Visual Studio"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, scenarios"
  - "load tests, logging"
ms.assetid: 9ac88d8a-4777-462c-aa0e-244dadb2cfd1
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# How to: Specify How Frequently Test Logs are Saved Using the Load Test Editor

After you create your load test with the **New Load Test Wizard**, you can use the **Load Test Editor** to change the load tests properties to meet your testing needs and goals. For more information, see  [Walkthrough: Create and run a load test](../test/walkthrough-create-and-run-a-load-test.md).

> [!NOTE]
> For a complete list of the run settings properties and their descriptions, see [Load Test Run Settings Properties](../test/load-test-run-settings-properties.md).

You can specify how frequently that the test log is saved in a load test by using the Load Test Editor to change the **Save Log Frequency for Completed Tests** property in the Properties window.

## To specify the frequency for saving the test log in a load test

1.  Open a load test.

     The Load Test Editor appears. It displays the load test tree.

2.  In the load test trees **Run Settings** folder, choose the run setting node that you want to specify how frequently that the test log is saved for.

3.  On the **View** menu, select **Properties Window**.

     The scenario's categories and properties are displayed in the Properties window.

4.  In the text box for the **Save Log Frequency for Completed Tests** property, type a number to indicate the frequency at which the test log will be written. The number indicates that one out of every entered number of tests will be saved to the test log. For example, entering the value of ten specifies that the tenth, twentieth, thirtieth and so on will be written to the test log.

    > [!NOTE]
    > Using a value of 0 for the **Save Log Frequency for Completed Tests** property specifies that no test logs are saved.

5.  After you have finished changing the property, choose **Save** on the **File** menu.

     The data that is saved in the log can be viewed using the Load Test Analyzer's Tables view. For more information, see [Analyze Load Test Results and Errors in the Tables View](../test/analyze-load-test-results-and-errors-in-the-tables-view.md).

## See also

- [Editing Load Test Scenarios](../test/edit-load-test-scenarios.md)
- [Walkthrough: Create and run a load test](../test/walkthrough-create-and-run-a-load-test.md)
- [Editing Load Test Scenarios](../test/edit-load-test-scenarios.md)
- [How to: Specify if Test Failures are Saved to Test Logs](../test/how-to-specify-if-test-failures-are-saved-to-test-logs.md)
- [How to: Configure Collecting Full Details to Enable the Virtual User Activity Chart](../test/how-to-configure-load-tests-to-collect-full-details.md)