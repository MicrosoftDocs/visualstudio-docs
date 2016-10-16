---
title: "How to: Analyze Errors Using the Counters Panel"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Load Test Analyzer, counters panel"
ms.assetid: 981b4f1e-505a-4078-a06d-58ae17d996b4
caps.latest.revision: 16
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
# How to: Analyze Errors Using the Counters Panel
The Counters panel is visible in the Graphs view and the Tables view in the Load Test Analyzer while a load test is running, or when you are analyzing a load test result. For more information, see [Analyzing Load Test Results in the Graphs View](../test/analyzing-load-test-results-in-the-graphs-view-of-the-load-test-analyzer.md), [Analyzing Load Test Results and Errors in the Tables View](../test/analyzing-load-test-results-and-errors-in-the-tables-view-of-the-load-test-analyzer.md) and [How to: Access Load Test Results for Analysis](../test/how-to--access-load-test-results-for-analysis.md).  
  
 The **Errors** node in the Counters panel contains all the errors that were detected during the load test. The Errors node contains several sub-category error nodes that are specific to different kinds of errors. For example, **Exceptions** and **HTTP Errors**.  
  
 ![Counter panel's error node](../test/media/ltest_errornode.png "LTest_ErrorNode")  
Errors Node in Counters Panel  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
## Analyzing Errors  
  
#### To analyze errors in the Counters panel  
  
1.  After a load test completes, or after you load a test result, in the Load Test Analyzer's toolbar, choose either **Graphs** or **Tables**.  
  
     The **Counters** panel displays in either the Graphs view or the Tables view.  
  
2.  If the Counters panel is not visible, choose **Show Counters Panel** on the toolbar.  
  
3.  Expand the **Errors** and select either an error category, or an error sub-category that you want to analyze.  
  
4.  Right-click the error and select one of the following options:  
  
    -   **Show Counter on Graph**: In the Graphs view, the error is added and highlighted on the selected graph. For more information, see [How to: Add and Delete Counters on Graphs](../test/how-to--add-and-delete-counters-on-graphs-in-load-test-results.md).  
  
    -   **Show Counter on Legend**: The error is added and selected in the Legend. For more information, see [Using the Graphs View Legend to Analyze Load Tests](../test/using-the-graphs-view-legend-to-analyze-load-tests.md).  
  
    -   **Add Graph**:  
  
    1.  The **Enter Graph Name** dialog box is displayed.  
  
    2.  In the **Graph name** text box, type a name for the new graph and then choose **OK**.  
  
    3.  (Optional) Right-click the error again and select **Show Counter on Graph**.  
  
         For more information, see [How to: Create Custom Graphs](../test/how-to--create-custom-graphs-in-load-test-results.md).  
  
5.  (Optional) If you are analyzing an error in a completed load test result, consider using the zoom features while in the Graphs. For more information, see [How to: Zoom in on a Region of the Graph](../test/how-to--zoom-in-on-a-region-of-the-graph-in-load-test-results.md).  
  
    > [!TIP]
    >  If any errors were detected during the load test run, a link titled errors including the number found will be present in the Load Test Analyzer status bar. You can choose the link to display all the errors in the **Errors** table of the Tables view.  
  
## See Also  
 [Using the Counters Panel in Graphs View and Tables View](../test/using-the-counters-panel-in-graphs-view-and-tables-view.md)   
 [Analyzing Load Test Results](../test/analyzing-load-test-results-using-the-load-test-analyzer.md)   
 [Load Test Analyzer Overview](../test/load-test-analyzer-overview.md)