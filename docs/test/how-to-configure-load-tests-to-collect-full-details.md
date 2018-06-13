---
title: "Collect Full Details for virtual users for load testing in Visual Studio"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, virtual user activity chart, configuring"
  - "virtual user activity chart, configuring"
ms.assetid: cb22e43b-af4d-4e09-9389-3c3fa00786f7
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# How to: Configure Load Tests to Collect Full Details to Enable Virtual User Activity in Test Results

To use the Virtual User Activity Chart for your load test, you must configure your load test to collect full details. To configure the load test to do this, select the **All Individual Details** setting for the **Timing Details Storage** property associated with your load test. In this mode your load test will collect detailed information about every test, page, and transaction.

 If you are upgrading a project from a previous version of Visual Studio load test, use the steps in the following procedure to enable full detail collection.

 The **All Individual Details** setting for the **Timing Details Storage** property can be set to any of the following options:

-   **All Individual Details:** Collects and stores individual timing data for each test, transaction, and page issued during the test.

    > [!NOTE]
    > The **All Individual Details** option must be selected to enable virtual user data information in your load test results.

-   **None:** Does not collect any individual timing details. However, the average values are still available.

-   **Statistics Only:** Stores individual timing data, but only as percentile data. This saves space resources.

## To configure the timing details storage property in a load test

1.  Open a load test in the load test editor.

2.  Expand the **Run Settings** node in the load test.

3.  Choose on the run settings that you want to configure, for example **Run Settings1[Active]**.

4.  Open the Properties Window. On the **View** menu, select **Properties Window**.

5.  Under the **Results** category, choose the **Timing Details Storage** property and select **All Individual Details**.

     After you have configured the **All Individual Details** setting for the **Timing Details Storage** property, you can run your load test and view the Virtual User Activity Chart. For more information, see [How to: Analyze What Virtual Users Are Doing During a Load Test](../test/how-to-analyze-virtual-user-activity-during-a-load-test.md).

## See also

- [Analyzing Virtual User Activity in the Details View](../test/analyze-load-test-virtual-user-activity-in-the-details-view.md)
- [Walkthrough: Using the Virtual User Activity Chart to Isolate Issues](../test/walkthrough-use-the-virtual-user-activity-chart-to-isolate-issues.md)