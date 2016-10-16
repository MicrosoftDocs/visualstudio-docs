---
title: "How to: View Data and Diagnostic Attachments Using the Load Test Analyzer"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, data and diagnostics attachments"
ms.assetid: 73309bdd-437a-4eb0-88c8-702c3e24b9b0
caps.latest.revision: 18
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
# How to: View Data and Diagnostic Attachments Using the Load Test Analyzer
Before you run a load test, you can select a test setting that specifies the diagnostic and data adapters that you want to use. After the load test is finished, you use the Load Test Analyzer to view the details for those diagnostic and data adapters while you analyze the results. See [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 To view the data and diagnostic adapter details, choose the **View Data and Diagnostic attachments** button on the Load Test Analyzer's toolbar. For example, if the load test had the system information adapter configured in the test setting, you can view the system information for the machine that was used when the load test was run.  
  
 ![Choosing Diagnostic Data Adapter Attachment dialog](../test/media/load_adapterdialog.png "Load_AdapterDialog")  
Choose Diagnostic Data Adapter dialog box  
  
 Another example is a load test that includes the IntelliTrace adapter in the test setting. The IntelliTrace adapter enables you to open the IntelliTrace Summary page.  
  
 ![IntelliTrace Summary](../test/media/load_intellitrace.png "Load_IntelliTrace")  
IntelliTrace Summary for a load test  
  
 For more information, see [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md) and [Using IntelliTrace](../debugger/intellitrace.md).  
  
### To view data and diagnostic attachments in a load test from the Load Test Analyzer  
  
1.  After a load test is completed, or after you open a load test result, in the Load Test Analyzer's toolbar, choose **View Data and Diagnostic attachments**.  
  
     The **Choose Diagnostic Data Adapter** dialog box is displayed.  
  
2.  Select the diagnostic data adapter attachment that you want to analyze and then choose **OK**.  
  
## See Also  
 [Analyzing Load Test Results](../test/analyzing-load-test-results-using-the-load-test-analyzer.md)   
 [Load Test Analyzer Overview](../test/load-test-analyzer-overview.md)