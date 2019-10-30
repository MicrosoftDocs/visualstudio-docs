---
title: "Analyze Virtual User Activity for load tests"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "virtual user activity chart, viewing"
ms.assetid: 8bda19b3-91c1-4daf-b6c7-09108bddadff
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Analyze what virtual users are doing during a load test using the virtual user activity chart

View the virtual user activity that's associated with your load test by using the **Virtual User Activity Chart**. Each row in the chart represents an individual virtual user. The **Virtual User Activity Chart** shows you exactly what each virtual user was executing during the test. You can see patterns of user activity, load patterns, correlate failed or slow tests, and see requests with other virtual user activity. The **Virtual User Activity Chart** is available only after the load test has finished running.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

The procedures below demonstrate how to view the **Virtual User Activity Chart**, how to investigate a specific user's activity, and how to use filtering.

## To view the Virtual User Activity Chart in your load test results

1. To view the virtual user data, you must first configure the **All Individual Details** setting for the **Timing Details Storage** property that is associated with your load test. Then run the load test.

2. After your load test runs, the test results summary page is displayed. Choose the **User Detail** button on the toolbar.

     -or-

     Open the Graphs view by choosing the **Graphs** button on the toolbar. Right-click a graph and then select **Go to user detail**.

     If you use this option, the **Virtual User Activity Chart** will auto-zoom to the part of the test that you right-clicked. For example, if your pointer is located on approximately the 30 second mark, the detail view will display approximately on the 30 second mark in the **Zoom to time period** tool at the bottom of the **Virtual User Activity Chart**.

     Next, you can use investigate a specific user's activity details in the **Virtual User Activity Chart**.

## To investigate a specific user's activity in the Virtual User Activity Chart

1. Use the Zoom to time period tool at the bottom of the **Virtual User Activity Chart** to select an area on the chart where you want to investigate details on a specific user.

2. Hover your pointer over a detail in the graph. Notice that the following information is displayed in the tool tip:

   - **User Id**

   - **Scenario**

   - **Test**

   - **URL** (Does not display in a test or transaction)

   - **Outcome**

   - **Browser** (Does not display in a test or transaction)

   - **Network**

   - **Start Time**

   - **Duration**

   - **Agent**

   - **Test log** (Link to the test log)

     > [!NOTE]
     > To assist in debugging your application, if you choose the **Test log** link, the web test result or unit test result associated with the log open.

     Next, you can use the filtering and highlighting operations available in the **Virtual User Activity Chart**.

## To use filtering options in the Virtual User Activity Chart

1. In the **Details Legend**, use the drop-down list to select either **Test**, **Page**, or **Transaction**.

    **Details Legend panel**

    ![Details legend panel](../test/media/ltest_detailslegend.png)

2. Select or clear the check boxes for the errors, logs, tests, search, and aspx pages that are associated with the load test.

    The **Virtual User Activity Chart** updates accordingly.

    The **Virtual User Activity Chart** provides the ability to filter out tests, pages, and transactions based on several different criteria. You can remove certain tests from the view, or remove all successful tests, or remove tests that failed with certain failures. You can also remove all tests that do not have logs.

    For example, you can select the **(Highlight errors)** option, which displays all errors on the chart colored in red. You can also select the **(Highlight results with logs)** option, which displays all the test results that have logs colored in green in the chart.

    **Filter results panel**

    ![Filter results panel](../test/media/ltest_filterresults.png)

3. In the **Filter results**, select or clear the check boxes for the following filter options:

   - **Show only results with logs** Displays only test results that have test logs associated with them.

   - **Show successful results** Displays successful results.

   - **Show results with errors** Displays results with errors that can assist in debugging.

     > [!NOTE]
     > The list of error types that are listed under the **Show results with errors** node can be further investigated by choosing the **Tables** button in the **Web Performance Test Results Viewer** toolbar. For more information, see  [Analyze load test results and errors in the Tables view](../test/analyze-load-test-results-and-errors-in-the-tables-view.md).

     The **Virtual User Activity Chart** updates accordingly.

## See also

- [Analyze virtual user activity in the Details view](../test/analyze-load-test-virtual-user-activity-in-the-details-view.md)
- [Walkthrough: Using the virtual user activity chart to isolate issues](../test/walkthrough-use-the-virtual-user-activity-chart-to-isolate-issues.md)