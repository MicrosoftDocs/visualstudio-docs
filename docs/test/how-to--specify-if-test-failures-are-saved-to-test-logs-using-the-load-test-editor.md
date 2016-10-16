---
title: "How to: Specify if Test Failures are Saved to Test Logs Using the Load Test Editor"
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
ms.assetid: 08a7fe98-a7f7-4b8d-94a3-ec82b65a2aaf
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
# How to: Specify if Test Failures are Saved to Test Logs Using the Load Test Editor
After you create your load test with the **New Load Test Wizard**, you can use the **Load Test Editor** to change the load test properties to meet your testing needs and goals. See [Creating load tests](../test_notintoc/creating-load-tests.md).  
  
> [!NOTE]
>  For a complete list of the run settings properties and their descriptions, see [Load Test Run Settings Properties](../test/load-test-run-settings-properties.md).  
  
 You can specify if you want to have the test log saved if a test fails in a load test by using the Load Test Editor to change the **Save Log on Test Failure** property in the Properties window.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
### To specify if the test log is saved when a test fails in a scenario  
  
1.  Open a load test.  
  
     The Load Test Editor appears. The load test tree is displayed.  
  
2.  In the load test trees **Run Settings** folder, choose the run settings node that you want to specify the maximum number of test iterations for.  
  
3.  On the **View** menu, select **Properties Window**.  
  
     The run settings categories and properties are displayed in the Properties window.  
  
4.  In the **Save Log on Test Failure** property, select either True or False to specify if you want to save the test log in the event of a test failure in the scenario.  
  
     After you have finished changing the property, choose **Save** on the **File** menu.  
  
     The data that is saved in the log can be viewed using the Load Test Analyzer's Tables view. For more information, see [Analyzing Load Test Results and Errors in the Tables View](../test/analyzing-load-test-results-and-errors-in-the-tables-view-of-the-load-test-analyzer.md) and [Load Test Analyzer Overview](../test/load-test-analyzer-overview.md).  
  
## See Also  
 [Editing Load Test Scenarios](../test/editing-load-test-scenarios-using-the-load-test-editor.md)   
 [Creating load tests](../test_notintoc/creating-load-tests.md)   
 [Editing Load Test Scenarios](../test/editing-load-test-scenarios-using-the-load-test-editor.md)   
 [How to: Configure Collecting Full Details to Enable the Virtual User Activity Chart](../test/cb22e43b-af4d-4e09-9389-3c3fa00786f7.md)   
 [How to: Specify How Frequently Test Logs are Saved](../test/how-to--specify-how-frequently-test-logs-are-saved-using-the-load-test-editor.md)