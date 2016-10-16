---
title: "How to: Add Custom Counter Sets Using the Load Test Editor"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "counters, counter sets"
  - "counter sets"
  - "load tests, counter sets"
ms.assetid: 499aca80-1069-408d-ac68-326da6a50645
caps.latest.revision: 28
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
# How to: Add Custom Counter Sets Using the Load Test Editor
When you create a load test with the **New Load Test Wizard**, you add an initial set of counters. These offer you a set of predefined counter sets for your load test. For more information, see [Step 3 - Specifying Counter Sets in the New Load Test Wizard](../test_notintoc/creating-load-tests.md#CreatingLoadTestsUsingWizardStep3).  
  
> [!NOTE]
>  If your load tests are distributed across remote machines, controller and agent counters are mapped to the controller and agent counter sets. For more information on using remote machines in your load test, see [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md).  
  
 You manage your counters in the **Load Test Editor**. The counter sets that are already added to the test are visible in the **Counter Sets** node of the load test. After you create a Load test, you can add new custom counter sets to it.  
  
 ![Custom Counter Set](../test/media/loadtestcustomcounter.png "LoadTestCustomCounter")  
Custom Counter Set  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
### To add a custom counter set to a Load Test  
  
1.  Open a load test.  
  
2.  Expand the **Counter Sets** node. All the counter sets that have been added to the load test are visible.  
  
3.  Right-click the **Counter Sets** node and select **Add Custom Counter Set**.  
  
    > [!NOTE]
    >  The counter set is given a default name, such as **Custom1**. You can change the name by using the **Properties** window. Press F4 to display the **Properties** window.  
  
4.  To add counters to your custom counter set, right-click the new counter set and then choose **Add Counters**. For more information about how to add counters, see [How to: Add Counters to Counter Sets](../test/how-to--add-counters-to-counter-sets-using-the-load-test-editor.md).  
  
    > [!NOTE]
    >  It is also possible to add a custom counter set by right-clicking an existing counter set, choosing copy, and then pasting it to the counter sets node. Additional counters that are copied, but not needed, can be deleted. You can change the name of the new counter set by using the **Properties** window.  
  
## See Also  
 [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../test/specifying-the-counter-sets-and-threshold-rules-for-computers-in-a-load-test.md)   
 [Configuring Load Test Run Settings](../test/configuring-load-test-run-settings.md)