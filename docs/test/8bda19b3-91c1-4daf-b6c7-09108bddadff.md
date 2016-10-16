---
title: "How to: Analyze What Virtual Users Are Doing During a Load Test Using the Virtual User Activity Chart"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "virtual user activity chart, viewing"
ms.assetid: 8bda19b3-91c1-4daf-b6c7-09108bddadff
caps.latest.revision: 29
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
# How to: Analyze What Virtual Users Are Doing During a Load Test Using the Virtual User Activity Chart
View the virtual user activity that's associated with your load test by using the Virtual User Activity Chart. Each row in the chart represents an individual virtual user. The Virtual User Activity Chart shows you exactly what each virtual user was executing during the test. This lets you see patterns of user activity, load patterns, correlate failed or slow tests, and see requests with other virtual user activity. The Virtual User Activity Chart is available only after the load test has finished running.  
  
 The procedures below demonstrate how to view the Virtual User Activity Chart, how to investigate a specific user's activity, and how to use filtering.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
### To view the Virtual User Activity Chart in your load test results  
  
1.  To view the virtual user data, you must first configure the **All Individual Details** setting for the **Timing Details Storage** property that is associated with your load test. Then run the load test. [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)] [How to: Configure Collecting Full Details to Enable the Virtual User Activity Chart](../test/cb22e43b-af4d-4e09-9389-3c3fa00786f7.md).  
  
2.  After your load test runs, the test results summary page is displayed. Choose the **User Detail** button on the toolbar.  
  
     -or-  
  
     Open the Graphs view by choosing the **Graphs** button on the toolbar. Right-click a graph and then select **Go to user detail**.  
  
     If you use this option, the Virtual User Activity Chart will auto-zoom to the part of the test that you right-clicked. For example, if your pointer is located on approximately the 30 second mark, the detail view will display approximately on the 30second mark in the **Zoom to time period** tool at the bottom of the Virtual User Activity chart.  
  
     Next, you can use investigate a specific users activity details in the Virtual User Activity Chart.  
  
### To investigate a specific users activity in the Virtual User Activity Chart  
  
1.  Use the Zoom to time period tool at the bottom of the Virtual User Activity Chart to select an area on the chart where you want to investigate details on a specific user.  
  
2.  Hover your pointer over a detail in the graph. Notice that the following information is displayed in the tool tip:  
  
    -   **User Id**  
  
    -   **Scenario**  
  
    -   **Test**  
  
    -   **URL** (Does not display in a test or transaction)  
  
    -   **Outcome**  
  
    -   **Browser** (Does not display in a test or transaction)  
  
    -   **Network**  
  
    -   **Start Time**  
  
    -   **Duration**  
  
    -   **Agent**  
  
    -   **Test log** (Link to the test log)  
  
        > [!NOTE]
        >  To assist in debugging your application, if you choose the Test log link, the Web test result or unit test result associated with the log will open.  
  
     Next, you can use the filtering and highlighting operations available in the Virtual User Activity Chart.  
  
### To use filtering options in the Virtual User Activity Chart  
  
1.  In the Details Legend, use the drop-down list to select either **Test**, **Page**, or **Transaction**.  
  
     **Details Legend panel**  
  
     ![Details legend panel](../test/media/ltest_detailslegend.png "LTest_DetailsLegend")  
  
2.  Select or clear the check boxes for the errors, logs, tests, search, and aspx pages that are associated with the load test.  
  
     The Virtual User Activity Chart updates accordingly.  
  
     The Virtual User Activity Chart provides the ability to filter out tests, pages, and transactions based on several different criteria. You can remove certain tests from the view, or remove all successful tests, or remove tests that failed with certain failures. You can also remove all tests that do not have logs.  
  
     For example, you can select the **(Highlight errors)** option, which displays all errors on the cart colored in red. You can also select the **(Highlight results with logs)** option, which displays all the test results that have logs colored in green in the chart.  
  
     **Filter results panel**  
  
     ![Filter results panel](../test/media/ltest_filterresults.png "LTest_FilterResults")  
  
3.  In the Filter results, select or clear the check boxes for the following filter options:  
  
    -   **Show only results with logs** Displays only test results that have test logs associated with them.  
  
    -   **Show successful results** Displays successful results.  
  
    -   **Show results with errors** Displays results with errors that can assist in debugging.  
  
        > [!NOTE]
        >  The list of error types that are listed under the **Show results with errors** node can be further investigated by choosing the Tables button in the Web Performance Test Results Viewer toolbar. [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)] [Analyzing Load Test Results and Errors in the Tables View](../test/analyzing-load-test-results-and-errors-in-the-tables-view-of-the-load-test-analyzer.md).  
  
     The Virtual User Activity Chart updates accordingly.  
  
## See Also  
 [Analyzing Virtual User Activity in the Details View](../test/analyzing-load-test-virtual-user-activity-in-the-details-view-of-the-load-test-analyzer.md)   
 [Load Test Analyzer Overview](../test/load-test-analyzer-overview.md)   
 [Walkthrough: Using the Virtual User Activity Chart to Isolate Issues](../test/walkthrough--using-the-virtual-user-activity-chart-to-isolate-issues.md)