---
title: "How to: Run a Test Using Test Controllers and Test Agents"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, running"
  - "load tests, executing"
ms.assetid: 9d70a2cf-42a1-4237-9cda-e28edc639284
caps.latest.revision: 63
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
# How to: Run a Test Using Test Controllers and Test Agents
After you create a test and run the test and it passes, you might want to proceed with more exhaustive performance testing, or run the test remotely on a regular basis, by using a test controller and test agents. For more information, see [Setting Up Test Machines to Run Tests or Collect Data](../test/setting-up-test-machines-to-run-tests-or-collect-data.md).  
  
 This topic is about using Visual Studio. However, if you have to plan your testing effort and run your tests as part of a test plan, you can use [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] is included with Visual Studio Enterprise and [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]. See [Defining a Test Plan](../test_notintoc/defining-a-test-plan.md).  
  
 Your tests can be run from the following windows in Visual Studio:  
  
-   Test Explorer  
  
-   Web Performance Test Editor  
  
-   Load Test Editor  
  
 You use the same windows to run your test using a test controller and test agents, but first you must specify which test controller and test agents to use in the test settings.  
  
### To run unit tests, coded UI tests using a test controller and test agents  
  
1.  Either open a Visual Studio 2010 solution that included a test project with a .testsettings file.  
  
     -or-  
  
     Add a test settings file to your solution containing either a unit test project or coded UI test project. For more information, see [How to: Add a Test Settings File from Microsoft Visual Studio](../test_notintoc/how-to--add-a-test-settings-file-from-microsoft-visual-studio.md).  
  
2.  In Solution Explorer, double-click the .testsettings file in the solution.  
  
     The **Test Settings** dialog box is displayed. On the **Roles** page, you can specify the test controller that you want to use. For more information about selecting the test controller, roles, and test agents, see [Specifying Test Settings for Visual Studio Tests](../test/specifying-test-settings-for-visual-studio-tests.md).  
  
3.  In Solution Explorer, right-click the .testsettings file in the solution and choose **Active Load and Web Test Settings**.  
  
4.  Run your test using the Test Explorer or one of the run options under the **Test** menu.  
  
     Your test runs on the remote controller and agents. To view tests that have run on a controller, use the **Test Run** window on the **Test** menu. For more information, see [How to: Save and Open Web Performance and Load Test Results in Visual Studio](../test/how-to--save-and-open-web-performance-and-load-test-results-in-visual-studio.md).  
  
### To run a Web performance or load test using a test controller and test agents  
  
1.  In Solution Explorer, double-click the .testsettings file in the solution.  
  
     The **Test Settings** dialog box is displayed. On the **Roles** page, you can specify the test controller that you want to use. For more information about selecting the test controller, roles, and test agents, see [Specifying Test Settings for Visual Studio Tests](../test/specifying-test-settings-for-visual-studio-tests.md).  
  
2.  In Solution Explorer, right-click the .testsettings file in the solution and choose **Active Load and Web Test Settings**.  
  
3.  In the Web Performance Test Editor, choose **Run Test** from the toolbar.  
  
     -or-  
  
     In the Load Test Editor, choose **Run Load Test** from the toolbar.  
  
     Your test runs on the remote controller and agents. To view tests that have run on a controller, use the **Test Run** window on the **Test** menu. For more information, see [How to: Save and Open Web Performance and Load Test Results in Visual Studio](../test/how-to--save-and-open-web-performance-and-load-test-results-in-visual-studio.md).  
  
## See Also  
 [How to: Run Tests from Microsoft Visual Studio](../test/how-to--run-tests-from-microsoft-visual-studio.md)   
 [How to: Run a Load Test Using Test Controllers and Test Agents Specified in a Test Setting](../test_notintoc/how-to--run-a-load-test-using-test-controllers-and-test-agents-specified-in-a-test-setting.md)