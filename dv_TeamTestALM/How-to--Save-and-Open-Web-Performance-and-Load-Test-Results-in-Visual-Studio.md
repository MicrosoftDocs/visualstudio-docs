---
title: "How to: Save and Open Web Performance and Load Test Results in Visual Studio"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 289a57f0-7785-416a-8bac-c07a0ca4f7fb
caps.latest.revision: 46
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
# How to: Save and Open Web Performance and Load Test Results in Visual Studio
After you run a Web performance test or a load test in Visual Studio Enterprise, the results of the test that was executed in that run are saved automatically on your computer in a test run file. You can open any test runs that were saved, view results of recently run tests, or save copies of test runs to a different location. How many test runs are saved automatically depends on a setting in the Options dialog box.  
  
 This topic is about using Visual Studio to save and open Web performance test and load test results. For information about viewing automated test results in the Test Explorer, see [Run Tests from Test Explorer](../dv_TeamTestALM/How-to--Run-Tests-from-Microsoft-Visual-Studio.md#RunTestsFromUnitTestExplorer). For more information about how to save and open test results in Microsoft Test Manager, see [How to: View Manual Test Case Results Using Microsoft Test Manager](assetId:///400b59bc-1b8c-410d-b5c7-9965bcc4d5a8). Microsoft Test Manager is included with Visual Studio Enterprise and Visual Studio Test Professional.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
## Change how many test runs are automatically saved  
 How many test runs are saved by default dictates how many previously run tests you can open or copy to a different location.  
  
#### To change how many test runs are automatically saved  
  
1.  On the **Tools** menu, choose **Options**.  
  
2.  In the **Options** dialog box expand **Web Performance Test Tools**, choose **Test Execution**, and under **Test Results Management** set the number of tests that you want to have saved automatically.  
  
## Open test results in Visual Studio  
 How you open test results depends on how they were saved. If you run multiple tests in a single session you can quickly open the previously run tests. You can also open tests that were saved automatically, or you can open tests that you saved to a chosen location.  
  
#### To open results of recently run tests  
  
1.  From the **VIEW** menu, choose **Other Windows** and then choose **Test Results**.  
  
2.  In the **Test Results** window, in the **Select Run** list, choose the test run you want to open or choose **Manage test runs** to browse for a test from the Test Runs window.  
  
     How many runs are available depends on how many tests you ran during the current session.  
  
3.  (Optional) In the **Result** list, right-click a test and choose **View Results** to see more information about that particular test.  
  
4.  (Optional) To view test result details, including any data and diagnostic adapter attachments, choose **Run Details** in the toolbar. For more information, see [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../dv_TeamTestALM/Setting-Up-Machines-and-Collecting-Diagnostic-Information-Using-Test-Settings.md).  
  
## See Also  
 [How to: Delete Test Results](assetId:///56436c58-c6a7-4902-b9e0-d7a6f76b1ffb)   
 [Running Tests in Microsoft Test Manager](assetId:///7a154168-c409-4163-bbf2-29971a638458)   
 [Running Automated Tests Using Microsoft Visual Studio](../dv_TeamTestALM/Running-Automated-Tests-Using-Microsoft-Visual-Studio.md)   
 [How to: Analyze Manual Test Runs Using Microsoft Test Manager](assetId:///8fd8b3d5-d71e-4a37-91a4-354ab00e32ed)