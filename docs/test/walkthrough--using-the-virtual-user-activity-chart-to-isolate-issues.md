---
title: "Walkthrough: Using the Virtual User Activity Chart to Isolate Issues"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, virtual user activity chart"
  - "virtual user activity chart, isolating performance issues"
ms.assetid: d1c10fb9-cfeb-4e7f-9991-2d1e1103699e
caps.latest.revision: 36
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
# Walkthrough: Using the Virtual User Activity Chart to Isolate Issues
In this walkthrough you will learn how to use the Virtual User Activity Chart to isolate errors that occurred for individual virtual users that ran your load test.  
  
 The Virtual User Activity Chart lets you visualize the virtual user activity that is associated with your load test. Each row in the chart represents an individual virtual user. The Virtual User Activity Chart shows you exactly what each virtual user was executing during the test. This lets you isolate performance issues by seeing patterns of user activity, load patterns, correlate failed or slow tests, and see requests with other virtual user activity. The Virtual User Activity Chart is available only after the load after has finished running.  
  
 In this walkthrough, you will complete the following tasks:  
  
-   Learn how to use the following tools associated with the Virtual User Activity Chart:  
  
    -   Use the **Zoom to time period** tool to specify a specific time period on the chart that you want to analyze.  
  
    -   Use the **Details Legend** panel and the **Filter results** panel, to apply filtering to the chart to help isolate issues.  
  
-   Use the Virtual User Activity Chart to analyze an error that occurred for a specific virtual user and view the problematic error type details.  
  
 For more information, see [Analyzing Virtual User Activity in the Details View](../test/analyzing-load-test-virtual-user-activity-in-the-details-view-of-the-load-test-analyzer.md).  
  
## Prerequisites  
  
-   Visual Studio Enterprise  
  
-   Complete these procedures:  
  
    -   [Record and run a web performance test](assetId:///bd0a82fd-cec0-4861-bc09-e1b0b2d258ef).  
  
    -   [Create and run a load test](assetId:///7041cbcf-9ab1-4579-98ff-8f296aeaded4)  
  
## Open the ColorWebApp Solution Created in the Previous Walkthroughs  
  
#### Open the solution  
  
1.  Start Visual Studio.  
  
2.  Open the ColorWebApp solution that contains the LoadTest1.loadtest. This load test results from conducting the steps in the three walkthroughs that are listed at the beginning of this topic in the prerequisites section.  
  
     The remaining steps in this walkthrough assume a Web application named ColorWebApp, a Web performance test named ColorWebAppTest.webtest and a load test named LoadTest1.loadtest.  
  
## Run the Load Test  
 Run your load test to collect virtual user activity data.  
  
#### Run the load test to collect virtual user activity data  
  
-   In the Load Test Editor, choose the **Run** button on the toolbar. LoadTest1 starts to run.  
  
     As in the previous walkthrough, you should see some threshold violation icons appear on the **Page Response Time** graph. For more information, see [Create and run a load test](assetId:///7041cbcf-9ab1-4579-98ff-8f296aeaded4).  
  
## Isolate Issues in the Virtual User Activity Chart  
 After you have run your load test and collected the virtual user activity data, you can view the data in the load test results by using the load Test Analyzer's Details view in the Virtual User Activity chart. Additionally, you can use the Virtual User Activity Chart to help isolate performance issues in your load test.  
  
#### To use the Virtual User Activity Chart in your load test results  
  
1.  After the load test is finished running, the Summary page for the load test results is displayed in the Load Test Analyzer. Choose the **Graphs** button on the toolbar.  
  
     The Graphs view is displayed.  
  
2.  On the **Page Response Time** graph, right-click near one of the threshold violation icons and select **Go to user detail**.  
  
    > [!NOTE]
    >  You can use the **Details** button in the Load Test Editor's toolbar to open the User Activity chart too. However, if you use the **Go to user detail** option, the Virtual User Activity Chart will automatically zoom in on the part of the test that you right clicked in the graph.  
  
     The Details view is displayed with the **Virtual User Activity Chart** focused on the time period when the threshold violations occurred.  
  
     On the y-axis, the horizontal plots represent individual virtual users. The x-axis displays time line for the load test run.  
  
3.  In the **Zoom to time period** tool below the **Virtual User Activity Chart**, adjust the left and right sliders until both are close to the threshold violation icon. This changes the time scale in the **Virtual User Activity Chart**  
  
4.  In the **Details Legend**, select the check box for **(Highlight errors)**. Notice that the virtual user who caused the threshold violation is highlighted.  
  
5.  In the **Filter results** panel, clear the check boxes for **Show successful results** and **HttpError** but leave the **ValidationRuleError** check box selected.  
  
     The **Virtual User Activity Chart** displays only the virtual users that spent more than 3 seconds on the Red.aspx page as specified by the threshold violation configured in the previous walkthrough. For more information, see [Create and run a load test](assetId:///7041cbcf-9ab1-4579-98ff-8f296aeaded4).  
  
6.  Rest the mouse pointer over the horizontal line that represents the virtual user with the validation rule error for the threshold violation.  
  
7.  A tool tip is displayed with the following information:  
  
    -   **User Id**  
  
    -   **Scenario**  
  
    -   **Test**  
  
    -   **Outcome**  
  
    -   **Network**  
  
    -   **Start Time**  
  
    -   **Duration**  
  
    -   **Agent**  
  
    -   **Test log**  
  
8.  Notice that **Test log** is a link. Choose the **Test log** link.  
  
9. The ColorWebTest Web performance test that is associated with the log opens in the Web Performance Test Results Viewer. This lets you isolate where the threshold violations occurred.  
  
     You can use various settings in both the **Details Legend** and **Filter results** panels to help in isolating performance issues, and errors in your load tests. Experiment with these settings and the **Zoom to time period** tool to see how the virtual user data is presented in the **Virtual User Activity Chart**.  
  
## See Also  
 [Analyzing Virtual User Activity in the Details View](../test/analyzing-load-test-virtual-user-activity-in-the-details-view-of-the-load-test-analyzer.md)   
 [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md)   
 [How to: Create a Test Setting for a Distributed Load Test](../test/how-to--create-a-test-setting-for-a-distributed-load-test.md)   
 [Install and configure test agents](../test/install-and-configure-test-agents.md)   
 [Using Test Controllers and Test Agents with Load Tests](../test/using-test-controllers-and-test-agents-with-load-tests.md)   
 [Configuring Test Controllers and Test Agents for Load Testing](../test/configuring-test-controllers-and-test-agents-for-load-testing.md)   
 [How to: Specify 64-Bit Process Using Test Settings](../test_notintoc/how-to--specify-64-bit-process-using-test-settings.md)   
 [Load Test Analyzer Overview](../test/load-test-analyzer-overview.md)   
 [Running Load Tests](../test_notintoc/running-load-tests.md)   
 [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md)