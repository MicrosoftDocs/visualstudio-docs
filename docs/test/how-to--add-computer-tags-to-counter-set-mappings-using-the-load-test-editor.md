---
title: "How to: Add Computer Tags to Counter Set Mappings Using the Load Test Editor"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, counter set mappings, computer tags"
ms.assetid: f52a73e1-036a-4b28-a6c8-848284bf4488
caps.latest.revision: 15
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
# How to: Add Computer Tags to Counter Set Mappings Using the Load Test Editor
Computer tags let you identify a computer with an easy-to-recognize name. The tags are displayed in the **Counter Set Mappings** node in the tree in the Load Test Editor. More important, the tags are displayed in Excel reports, which help stakeholders identify what role the computer has in the load test. For example, "Web Server1 in lab2" or "SQL Server2 in Phoenix office". For more information, see [Reporting Load Tests Results for Test Comparisons or Trend Analysis](../test/reporting-load-tests-results-for-test-comparisons-or-trend-analysis.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
## Adding a Tag to a Computer in Counter Sets  
  
#### To add a tag to a computer  
  
1.  Open a load test.  
  
2.  Choose the **Manage Counter Sets** button.  
  
     – or –  
  
     Right-click **Counter Sets** folder in the load test tree and choose **Manage Counter Sets**.  
  
     The **Manage Counter Sets** dialog box is displayed.  
  
3.  (Optional) In the **Selected computers and counter sets will be added under the following run settings** list box, select a different run setting.  
  
    > [!NOTE]
    >  This only applies if you have more than one run setting in your load test.  
  
4.  Under **Computer and counter sets to monitor**, select the computer that you want to apply the tag to.  
  
    > [!NOTE]
    >  For information about how to add a computer, see [How to: Manage Counter Sets](../test/how-to--manage-counter-sets-using-the-load-test-editor.md).  
  
5.  In the **Computer Tags** text box, type a tag to associate with the computer. For example, "TestMachine12 in lab3".  
  
6.  Choose **OK**.  
  
## See Also  
 [Analyzing Threshold Rule Violations](../test/analyzing-threshold-rule-violations-in-load-tests-using-the-load-test-analyzer.md)   
 [Analyzing Load Test Results](../test/analyzing-load-test-results-using-the-load-test-analyzer.md)   
 [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../test/specifying-the-counter-sets-and-threshold-rules-for-computers-in-a-load-test.md)   
 [How to: Manage Counter Sets](../test/how-to--manage-counter-sets-using-the-load-test-editor.md)