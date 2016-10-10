---
title: "How to: Analyze Threshold Violations Using the Counters Panel in Load Test Analyzer"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0126d7b7-0538-4ea9-9046-6556654b3b9d
caps.latest.revision: 18
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
# How to: Analyze Threshold Violations Using the Counters Panel in Load Test Analyzer
The Counters panel is visible in the Graphs view and the Tables view in the Load Test Analyzer while a load test is running, or when you are analyzing a load test result. See [Analyzing Load Test Results in the Graphs View](../dv_TeamTestALM/Analyzing-Load-Test-Results-in-the-Graphs-View-of-the-Load-Test-Analyzer.md), [Analyzing Load Test Results and Errors in the Tables View](../dv_TeamTestALM/Analyzing-Load-Test-Results-and-Errors-in-the-Tables-View-of-the-Load-Test-Analyzer.md) and [How to: Access Load Test Results for Analysis](../dv_TeamTestALM/How-to--Access-Load-Test-Results-for-Analysis.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 Threshold violations are associated with specific performance counters, and indicate that the performance counter either exceeded or fell below a set threshold value. Icons in the counters panel communicate threshold violations.  
  
 ![Counter panel's computer node](../dv_TeamTestALM/media/LTest_CompNode.png "LTest_CompNode")  
Computers Node in Counters Panel with threshold violation  
  
 The icon for a threshold violation is propagated from the tree node where the failed counter resides to the root. The icon alerts the user to a violation on a counter that might not be visible in the tree because the tree has not been expanded. An example of the icon can be seen in the **Computers Node** in Counters Panel in the previous illustration.  
  
 The icon will be one of the following:  
  
 ![No threshold violation](../dv_TeamTestALM/media/Icon_LTest_1.gif "Icon_LTest_1") No threshold violation.  
  
 ![A critical threshold violation on last interval](../dv_TeamTestALM/media/Icon_LTest_2.gif "Icon_LTest_2") A critical threshold violation occurred on the last interval.  
  
 ![A critical threshold violation on a prior interval](../dv_TeamTestALM/media/Icon_LTest_3.gif "Icon_LTest_3") A critical threshold violation occurred on a prior interval.  
  
 ![A warning threshold violation on the last interval](../dv_TeamTestALM/media/Icon_LTest_4.gif "Icon_LTest_4") A warning threshold violation occurred on the last interval.  
  
 ![A warning threshold violation on a prior interval](../dv_TeamTestALM/media/Icon_LTest_5.gif "Icon_LTest_5") A warning threshold violation occurred on a prior interval.  
  
### To analyze threshold violations in the Counters panel  
  
1.  After a load test completes, or after you load a test result, in the Load Test Analyzer's toolbar, choose either **Graphs** or **Tables**.  
  
     The Counters panel displays in either the Graphs view or the Tables view.  
  
2.  If the Counters panel is not visible, choose **Show Counters Panel** on the toolbar.  
  
     Any nodes that contain threshold violations will include one of the icons listed above.  
  
3.  Expand the node that contains a threshold icon, such as the **Computers** node, as shown in the previous illustration titled "Computers Node in Counters Panel with threshold violation." Continue to expand the node until you reach the performance counter with the threshold violation. For example, the illustration shows the failed instance of the **Microsoft Virtual Machine Failed Bus Network Adapter**.  
  
4.  (Optional) Right-click the performance counter with the threshold violation and select one of the following options:  
  
    -   **Show Counter on Graph**: In the Graphs view, the performance counter is added and highlighted on the selected graph. For more information, see [How to: Add and Delete Counters on Graphs](../dv_TeamTestALM/How-to--Add-and-Delete-Counters-on-Graphs-in-Load-Test-Results.md).  
  
        > [!NOTE]
        >  Threshold violation icons can also be shown on the graph in the Graphs view. The threshold icon appears on the graph next to the data point where the threshold violation occurred. To do this, choose **Show Legend** drop-down on the toolbar and select **Show Threshold Violations on Graph**.  
  
    -   **Show Counter on Legend**: In the legend, the performance counter is added and selected. For more information, see [Using the Graphs View Legend to Analyze Load Tests](../dv_TeamTestALM/Using-the-Graphs-View-Legend-to-Analyze-Load-Tests.md).  
  
    -   **Add Graph**:  
  
    1.  The **Enter Graph Name** dialog box is displayed.  
  
    2.  In the **Graph name** text box, type a name for the new graph and then choose **OK**.  
  
    3.  (Optional) Right-click the performance counter again and select **Show Counter on Graph**.  
  
         For more information, see [How to: Create Custom Graphs](../dv_TeamTestALM/How-to--Create-Custom-Graphs-in-Load-Test-Results.md).  
  
5.  (Optional) If you are analyzing the threshold violation in a completed load test result, consider using the zoom features in the Graphs view. For more information, see [How to: Zoom in on a Region of the Graph](../dv_TeamTestALM/How-to--Zoom-in-on-a-Region-of-the-Graph-in-Load-Test-Results.md).  
  
    > [!TIP]
    >  If any threshold violations were detected during the load test run, a link titled "threshold violations," including the number of violations, will be present in the Load Test Analyzer status bar. You can choose the link to display all the threshold violations in the **Thresholds** table of the Tables view.  
  
## See Also  
 [Using the Counters Panel in Graphs View and Tables View](../dv_TeamTestALM/Using-the-Counters-Panel-in-Graphs-View-and-Tables-View.md)   
 [Analyzing Load Test Results](../dv_TeamTestALM/Analyzing-Load-Test-Results-Using-the-Load-Test-Analyzer.md)   
 [Load Test Analyzer Overview](../dv_TeamTestALM/Load-Test-Analyzer-Overview.md)