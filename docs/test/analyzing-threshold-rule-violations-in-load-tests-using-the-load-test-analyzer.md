---
title: "Analyzing Threshold Rule Violations in Load Tests Using the Load Test Analyzer"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.test.load.monitor.threshholdresult"
helpviewer_keywords: 
  - "load tests, thresholds"
  - "threshold violations"
  - "threshold counts"
  - "load tests, threshold violations"
  - "load test results, analyzing threshold violations"
  - "thresholds in load tests"
ms.assetid: 969ed346-cf2e-4d48-82b3-edb3e075e1c0
caps.latest.revision: 33
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
# Analyzing Threshold Rule Violations in Load Tests Using the Load Test Analyzer
Threshold rules are associated with specific performance counters, and violations indicate that a performance counter exceeded or fell below a set value. When you run a load test, you can analyze violations that occur for the threshold rules you set up previously.  
  
 If any violations occurred, a **threshold violations** hyperlink appears on the Load Test Analyzer's status bar and specifies the number of violations that occurred. You choose the hyperlink to display the threshold violations table. You can also view threshold violations in the **Counters** window, and on the graph:  
  
-   [Analyzing Threshold Violations in the in Tables View](#Table)  
  
-   [Analyzing Threshold Violations in Graphs View](#Graph)  
  
-   [Analyzing Threshold Violations Using The Counters Panel](#CountersPanel)  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
##  <a name="Table"></a> Viewing Threshold Violations in the Table  
 The threshold violations table displays the first 1,000 violations. The following table contains these columns:  
  
|Column|Description|Visible By Default|  
|------------|-----------------|------------------------|  
|Time|The time during the load test at which the violation occurred.|Yes|  
|Computer|The name of the computer under test on which the violation occurred. **Note:**  This is important when you run load tests on rigs. For more information, see [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md).|Yes|  
|Category|The category of the performance counter on which the violation occurred.|Yes|  
|Counter|The name of the performance counter on which the violation occurred.|Yes|  
|Instance|The performance counter instance on which the violation occurred.|Yes|  
|Message|A message that describes the threshold violation. For example, **The value 5 exceeds the critical threshold value of 0**.|Yes|  
  
> [!NOTE]
>  You can sort the table by choosing the column headers.  
  
 For more information, see [Analyzing Load Test Results and Errors in the Tables View](../test/analyzing-load-test-results-and-errors-in-the-tables-view-of-the-load-test-analyzer.md).  
  
##  <a name="CountersPanel"></a> Viewing Threshold Violations in the Counters Panel  
 You can view threshold violations in the **Counters** panel, in the tree that lists the performance counters for your load test. Icons in the **Counters** panel communicate threshold violations. The icon will be one of the following:  
  
 The icon will be one of the following:  
  
 ![No threshold violation](../test/media/icon_ltest_1.gif "Icon_LTest_1") No threshold violation.  
  
 ![A critical threshold violation on last interval](../test/media/icon_ltest_2.gif "Icon_LTest_2") A critical threshold violation occurred on the last interval.  
  
 ![A critical threshold violation on a prior interval](../test/media/icon_ltest_3.gif "Icon_LTest_3") A critical threshold violation occurred on a prior interval.  
  
 ![A warning threshold violation on the last interval](../test/media/icon_ltest_4.gif "Icon_LTest_4") A warning threshold violation occurred on the last interval.  
  
 ![A warning threshold violation on a prior interval](../test/media/icon_ltest_5.gif "Icon_LTest_5") A warning threshold violation occurred on a prior interval.  
  
 Optionally, threshold violations can be shown on the graph also. The threshold icon appears on the graph next to the data point where the threshold violation occurred.  
  
 In the counter tree, the icon for a threshold violation is propagated from the specific counter node, up to the root node. This alerts you to a violation on a counter that may not be visible in the tree because the tree has not been expanded.  
  
 For more information, see [Using the Counters Panel in Graphs View and Tables View](../test/using-the-counters-panel-in-graphs-view-and-tables-view.md).  
  
##  <a name="Graph"></a> Viewing Threshold Violations on the Graph  
 You can view threshold violations on the graph. Similar to the **Counters** panel, icons communicate threshold violations on the graph. The icons appear on the graph next to the data point where the threshold violation occurred. If a threshold violation occurs on a counter that does not appear on the graph, you can add it to the graph by dragging it from the **Counters** panel to the graph.  
  
 For more information, see [Analyzing Load Test Results in the Graphs View](../test/analyzing-load-test-results-in-the-graphs-view-of-the-load-test-analyzer.md).  
  
## See Also  
 [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../test/specifying-the-counter-sets-and-threshold-rules-for-computers-in-a-load-test.md)   
 [Analyzing Load Test Results](../test/analyzing-load-test-results-using-the-load-test-analyzer.md)   
 [Analyzing Load Test Results and Errors in the Tables View](../test/analyzing-load-test-results-and-errors-in-the-tables-view-of-the-load-test-analyzer.md)