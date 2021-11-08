---
title: Save load test log for test failures
description: Learn how to specify if you want to have the test log saved if a test fails in a load test by changing the Save Log on Test Failure property.
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: how-to
helpviewer_keywords: 
  - load tests, scenarios
  - load tests, logging
ms.assetid: 08a7fe98-a7f7-4b8d-94a3-ec82b65a2aaf
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# How to: Specify if test failures are saved to test logs using the Load Test Editor

After you create your load test with the **New Load Test Wizard**, you can use the **Load Test Editor** to change the load test properties to meet your testing needs and goals. See [Walkthrough: Create and run a load test](../test/walkthrough-create-and-run-a-load-test.md). You can specify if you want to have the test log saved if a test fails in a load test by changing the **Save Log on Test Failure** property.

> [!NOTE]
> For a complete list of the run settings properties and their descriptions, see [Load test run settings properties](../test/load-test-run-settings-properties.md).

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## To specify if the test log is saved when a test fails in a scenario

1. Open a load test.

     The **Load Test Editor** appears. The load test tree is displayed.

2. In the load test trees **Run Settings** folder, choose the run settings node that you want to specify the maximum number of test iterations for.

3. On the **View** menu, select **Properties Window**.

     The run settings categories and properties are displayed in the **Properties** window.

4. In the **Save Log on Test Failure** property, select either **True** or **False** to specify if you want to save the test log in the event of a test failure in the scenario.

     After you have finished changing the property, choose **Save** on the **File** menu.

     The data that is saved in the log can be viewed using the Load Test Analyzer's Tables view. For more information, see [Analyze load test results and errors in the Tables view](../test/analyze-load-test-results-and-errors-in-the-tables-view.md).

## See also

- [Edit load test scenarios](../test/edit-load-test-scenarios.md)
- [Walkthrough: Create and run a load test](../test/walkthrough-create-and-run-a-load-test.md)
