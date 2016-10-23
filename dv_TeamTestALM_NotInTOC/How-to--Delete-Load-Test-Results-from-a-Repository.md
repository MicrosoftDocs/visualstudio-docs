---
title: "How to: Delete Load Test Results from a Repository"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c2afe36b-d061-4f0e-9580-c18569ec08f9
caps.latest.revision: 35
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
# How to: Delete Load Test Results from a Repository
When you run a load test, information that was gathered during the run is stored in the Load Test Results Repository. The Load Test Results Repository contains performance counter data and information about any errors. For more information, see [Managing Load Test Results in the Load Test Results Repository](../dv_TeamTestALM/Managing-Load-Test-Results-in-the-Load-Test-Results-Repository.md).  
  
 You can manage load test results from the Load Test Editor by using the **Open and Manage Load Test Results** dialog box. You can open, import, export, and remove load test results.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
### To delete results from a repository  
  
1.  From a Web performance and load test project, open a load test.  
  
2.  On the embedded toolbar, choose **Open and Manage Results**.  
  
     The **Open and Manage Load Test Results** dialog box is displayed.  
  
3.  In **Enter a controller name to find load test results**, select a controller. Select **<Local - No controller>** to access results that are stored locally.  
  
4.  In **Show results for the following load test**, select the load test whose results you want to view. Select **<Show results for all tests\>** to see all results for all tests.  
  
     If load test results are available, they appear in the **Load test results** list. The columns are **Time**, **Duration**, **User**, **Outcome**, **Test**, and **Description**. **Test** contains the name of the test, and **Description** contains the optional description that is added before the test is run. The **Description** column displays the short descriptions that were entered in the **Analysis Comments** for this test result.  
  
5.  In the **Load test results** list, choose a result. You can use the Shift key, the Ctrl key, or both to select more than one result.  
  
6.  Choose **Remove**.  
  
     The results are removed from the repository.  
  
    > [!NOTE]
    >  The **Open and Manage Load Test Results** dialog box remains open after the results are removed.  
  
## See Also  
 [How to: Export Load Test Results from a Repository](../dv_TeamTestALM/How-to--Export-Load-Test-Results-from-a-Repository.md)   
 [Managing Load Test Results in the Load Test Results Repository](../dv_TeamTestALM/Managing-Load-Test-Results-in-the-Load-Test-Results-Repository.md)   
 [Running Load Tests](../Topic/Running%20Load%20Tests.md)   
 [Analyzing Load Test Results](../dv_TeamTestALM/Analyzing-Load-Test-Results-Using-the-Load-Test-Analyzer.md)   
 [How to: Import Load Test Results into a Repository](../dv_TeamTestALM/How-to--Import-Load-Test-Results-into-a-Repository.md)