---
title: "How to: Add a Threshold Rule Using the Load Test Editor"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, monitoring"
  - "load tests, thresholds"
  - "load tests, analyzing"
  - "thresholds in load tests"
ms.assetid: 3d8fac8f-426f-4155-9ced-f7cd4c79792c
caps.latest.revision: 31
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
# How to: Add a Threshold Rule Using the Load Test Editor
Threshold rules in load tests compare a performance counter value with either a constant value or another performance counter value.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
## Adding a Threshold Rule  
  
#### To add a threshold rule  
  
1.  Open a load test.  
  
2.  In the Load Test Editor, expand the **Counter Sets** node.  
  
3.  Expand one of the **Counter Categories** in one of the Counter Sets. For example, you can select **LoadTest:Scenario**. Expand the node.  
  
4.  Right-click one of the counters, for example, **User Load**, under **LoadTest:Scenario**. Select **Add Threshold Rule**.  
  
     The **Add Threshold Rule** dialog box is displayed.  
  
5.  You can choose from two types of rules: Compare Constant and Compare Counter. Select the appropriate type and set the values.  
  
    > [!NOTE]
    >  Set the **Alert If Over** property to **True** to indicate that exceeding a threshold is a problem. Set the **Alert If Over** property to **False** to indicate that falling below a threshold is a problem.  
  
## See Also  
 [Analyzing Threshold Rule Violations](../test/analyzing-threshold-rule-violations-in-load-tests-using-the-load-test-analyzer.md)   
 [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../test/specifying-the-counter-sets-and-threshold-rules-for-computers-in-a-load-test.md)   
 [Analyzing Load Test Results](../test/analyzing-load-test-results-using-the-load-test-analyzer.md)   
 [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../test/specifying-the-counter-sets-and-threshold-rules-for-computers-in-a-load-test.md)