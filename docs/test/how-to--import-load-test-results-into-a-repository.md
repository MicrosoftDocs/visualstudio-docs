---
title: "How to: Import Load Test Results into a Repository"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "results, load test"
  - "load test results, importing"
  - "Load Test Results Repository"
  - "load tests, importing results"
ms.assetid: a955b3d2-c8ad-40dd-8ea3-9f1a271e1eed
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
# How to: Import Load Test Results into a Repository
When you run a load test, information gathered during the run is stored in the Load Test Results Repository. The Load Test Results Repository contains performance counter data and information about any errors. For more information, see [Managing Load Test Results in the Load Test Results Repository](../test/managing-load-test-results-in-the-load-test-results-repository.md).  
  
 You can manage load test results from the Load Test Editor by using the **Open and Manage Load Test Results** dialog box. You can open, import, export, and remove load test results.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
### To import results into a repository  
  
1.  From a Web performance and load test project, open a load test.  
  
2.  On the embedded toolbar, choose **Open and Manage Results**.  
  
     The **Open and Manage Load Test Results** dialog box is displayed.  
  
3.  In **Enter a controller name to find load test results**, select a controller. Select **\<local>** to access results stored locally.  
  
     If there are load test results available, they appear in the **Load test results** list. The columns are **Time**, **Duration**, **User**, **Outcome**, **Test**, and **Description**. **Test** contains the name of the test, and **Description** contains the optional description that is added before the test is run.  
  
4.  Choose **Import**.  
  
     The **Import Load Test Results** dialog box appears.  
  
5.  In the **File name** box, type the name of an archived test results file, and then choose **Open**.  
  
     \- or -  
  
     Browse to the file, and then choose **Open**.  
  
    > [!NOTE]
    >  An archived test results file that you specify in this step must have been created by performing the Export operation.  
  
     The results are imported and appear in the **Load test results** list.  
  
## See Also  
 [Managing Load Test Results in the Load Test Results Repository](../test/managing-load-test-results-in-the-load-test-results-repository.md)   
 [Running Load Tests](../test_notintoc/running-load-tests.md)   
 [Analyzing Load Test Results](../test/analyzing-load-test-results-using-the-load-test-analyzer.md)   
 [How to: Export Load Test Results from a Repository](../test/how-to--export-load-test-results-from-a-repository.md)