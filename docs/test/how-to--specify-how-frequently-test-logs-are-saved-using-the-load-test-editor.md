---
title: "How to: Specify How Frequently Test Logs are Saved Using the Load Test Editor"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, scenarios"
  - "load tests, logging"
ms.assetid: 9ac88d8a-4777-462c-aa0e-244dadb2cfd1
caps.latest.revision: 27
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
# How to: Specify How Frequently Test Logs are Saved Using the Load Test Editor
After you create your load test with the **New Load Test Wizard**, you can use the **Load Test Editor** to change the load tests properties to meet your testing needs and goals. [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)] [Creating load tests](../test_notintoc/creating-load-tests.md).  
  
> [!NOTE]
>  For a complete list of the run settings properties and their descriptions, see [Load Test Run Settings Properties](../test/load-test-run-settings-properties.md).  
  
 You can specify how frequently that the test log is saved in a load test by using the Load Test Editor to change the **Save Log Frequency for Completed Tests** property in the Properties window.  
  
### To specify the frequency for saving the test log in a load test  
  
1.  Open a load test.  
  
     The Load Test Editor appears. It displays the load test tree.  
  
2.  In the load test trees **Run Settings** folder, choose the run setting node that you want to specify how frequently that the test log is saved for.  
  
3.  On the **View** menu, select **Properties Window**.  
  
     The scenario's categories and properties are displayed in the Properties window.  
  
4.  In the text box for the **Save Log Frequency for Completed Tests** property, type a number to indicate the frequency at which the test log will be written. The number indicates that one out of every entered number of tests will be saved to the test log. For example, entering the value of ten specifies that the tenth, twentieth, thirtieth and so on will be written to the test log.  
  
    > [!NOTE]
    >  Using a value of 0 for the **Save Log Frequency for Completed Tests** property specifies that no test logs are saved.  
  
5.  After you have finished changing the property, choose **Save** on the **File** menu.  
  
     The data that is saved in the log can be viewed using the Load Test Analyzer's Tables view. For more information, see [Analyzing Load Test Results and Errors in the Tables View](../test/analyzing-load-test-results-and-errors-in-the-tables-view-of-the-load-test-analyzer.md) and [Load Test Analyzer Overview](../test/load-test-analyzer-overview.md).  
  
## See Also  
 [Editing Load Test Scenarios](../test/editing-load-test-scenarios-using-the-load-test-editor.md)   
 [Creating load tests](../test_notintoc/creating-load-tests.md)   
 [Editing Load Test Scenarios](../test/editing-load-test-scenarios-using-the-load-test-editor.md)   
 [How to: Specify if Test Failures are Saved to Test Logs](../test/how-to--specify-if-test-failures-are-saved-to-test-logs-using-the-load-test-editor.md)   
 [How to: Configure Collecting Full Details to Enable the Virtual User Activity Chart](../test/cb22e43b-af4d-4e09-9389-3c3fa00786f7.md)