---
title: "How to: Manage Counter Sets Using the Load Test Editor"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.test.load.dialog.countersetmapping"
helpviewer_keywords: 
  - "counters, counter sets"
  - "performance counters"
  - "counter sets"
  - "load tests, counter sets"
ms.assetid: 64315c2f-a0b2-4378-be16-0774b99beef5
caps.latest.revision: 34
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
# How to: Manage Counter Sets Using the Load Test Editor
When you create a load test with the **New Load Test Wizard**, you add an initial set of counters. These offer you a set of predefined counter sets for your load test. [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)] [Step 3 - Specifying Counter Sets in the New Load Test Wizard](../test_notintoc/creating-load-tests.md#CreatingLoadTestsUsingWizardStep3).  
  
> [!NOTE]
>  If your load tests are distributed across remote machines, controller and agent counters are mapped to the controller and agent counter sets. [!INCLUDE[crabout](../codequality/includes/crabout_md.md)] how to use remote machines in your load test, see [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 Managing counter sets involves choosing the set of computers you want to collect performance data from, and assigning a set of counter sets to collect from each individual computer. You manage your counters in the **Load Test Editor**.  
  
 ![Managing Counter Sets](../test/media/loadtestmanagecountersets.png "LoadTestManageCounterSets")  
  
### To manage counter sets  
  
1.  Open a load test.  
  
2.  Choose the **Manage Counter Sets** button.  
  
     – or –  
  
     Right-click **Counter Sets** folder in the load test tree and choose **Manage Counter Sets**.  
  
     The **Manage Counter Sets** dialog box is displayed.  
  
3.  (Optional) In the **Selected computers and counter sets will be added under the following run settings** list box, select a different run setting.  
  
    > [!NOTE]
    >  This only applies if you have more than one run setting in your load test.  
  
4.  (Optional) Choose **Add Computer** to add a new computer to monitor. You will be prompted for a name. Type the name of a computer, and you will see nodes below the new entry. For example **ASP.NET**, **IIS**, **SQL**, and others. Select the check boxes in front of the nodes you want to select. The new counters appear in the **Preview selections** pane.  
  
5.  (Optional) In the **Computer Tags** text box, type a tag to associate with the computer. For example, "TestMachine12 in lab3".  
  
     Computer tags let you identify a computer with an easy-to-recognize name.  
  
     The tags are displayed in the **Counter Set Mappings** node in the tree in the Load Test Editor. More important, the tags are displayed in Excel reports, which help stakeholders identify what role the computer has in the load test. For example, "Web Server1 in lab2" or "SQL Server2 in Phoenix office". For more information, see [Reporting Load Tests Results for Test Comparisons or Trend Analysis](../test/reporting-load-tests-results-for-test-comparisons-or-trend-analysis.md).  
  
6.  Choose **OK**.  
  
## See Also  
 [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md)   
 [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../test/specifying-the-counter-sets-and-threshold-rules-for-computers-in-a-load-test.md)   
 [Configuring Load Test Run Settings](../test/configuring-load-test-run-settings.md)