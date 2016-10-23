---
title: "How to: Analyze Errors Using the Counters Panel"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 981b4f1e-505a-4078-a06d-58ae17d996b4
caps.latest.revision: 16
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Analyze Errors Using the Counters Panel
The Counters panel is visible in the Graphs view and the Tables view in the Load Test Analyzer while a load test is running, or when you are analyzing a load test result. For more information, see [Analyzing Load Test Results in the Graphs View](../dv_TeamTestALM/Analyzing-Load-Test-Results-in-the-Graphs-View-of-the-Load-Test-Analyzer.md), [Analyzing Load Test Results and Errors in the Tables View](../dv_TeamTestALM/Analyzing-Load-Test-Results-and-Errors-in-the-Tables-View-of-the-Load-Test-Analyzer.md) and [How to: Access Load Test Results for Analysis](../dv_TeamTestALM/How-to--Access-Load-Test-Results-for-Analysis.md).  
  
 The **Errors** node in the Counters panel contains all the errors that were detected during the load test. The Errors node contains several sub-category error nodes that are specific to different kinds of errors. For example, **Exceptions** and **HTTP Errors**.  
  
 ![Counter panel's error node](../dv_TeamTestALM/media/LTest_ErrorNode.png "LTest_ErrorNode")  
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
  
    -   **Show Counter on Graph**: In the Graphs view, the error is added and highlighted on the selected graph. For more information, see [How to: Add and Delete Counters on Graphs](../dv_TeamTestALM/How-to--Add-and-Delete-Counters-on-Graphs-in-Load-Test-Results.md).  
  
    -   **Show Counter on Legend**: The error is added and selected in the Legend. For more information, see [Using the Graphs View Legend to Analyze Load Tests](../dv_TeamTestALM/Using-the-Graphs-View-Legend-to-Analyze-Load-Tests.md).  
  
    -   **Add Graph**:  
  
    1.  The **Enter Graph Name** dialog box is displayed.  
  
    2.  In the **Graph name** text box, type a name for the new graph and then choose **OK**.  
  
    3.  (Optional) Right-click the error again and select **Show Counter on Graph**.  
  
         For more information, see [How to: Create Custom Graphs](../dv_TeamTestALM/How-to--Create-Custom-Graphs-in-Load-Test-Results.md).  
  
5.  (Optional) If you are analyzing an error in a completed load test result, consider using the zoom features while in the Graphs. For more information, see [How to: Zoom in on a Region of the Graph](../dv_TeamTestALM/How-to--Zoom-in-on-a-Region-of-the-Graph-in-Load-Test-Results.md).  
  
    > [!TIP]
    >  If any errors were detected during the load test run, a link titled errors including the number found will be present in the Load Test Analyzer status bar. You can choose the link to display all the errors in the **Errors** table of the Tables view.  
  
## See Also  
 [Using the Counters Panel in Graphs View and Tables View](../dv_TeamTestALM/Using-the-Counters-Panel-in-Graphs-View-and-Tables-View.md)   
 [Analyzing Load Test Results](../dv_TeamTestALM/Analyzing-Load-Test-Results-Using-the-Load-Test-Analyzer.md)   
 [Load Test Analyzer Overview](../dv_TeamTestALM/Load-Test-Analyzer-Overview.md)