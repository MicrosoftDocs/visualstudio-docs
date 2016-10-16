---
title: "Using MSTest from the command line"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: da19a039-f142-4c4a-959e-70146d11a943
caps.latest.revision: 7
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
# Using MSTest from the command line
You can use the MSTest.exe program to run automated tests in a test assembly from a command line. You can also view the test results from these test runs, save the results to disk, and save your results to [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)].  
  
> [!WARNING]
>  MSTest is used to run load test in [!INCLUDE[vs_dev11_long](../codequality/includes/vs_dev11_long_md.md)]. By default, unit tests and coded UI tests use VSTest.Console.exe in [!INCLUDE[vs_dev11_long](../codequality/includes/vs_dev11_long_md.md)]. However, MSTest is used for compatibility with test projects created using [!INCLUDE[vs2010](../codequality/includes/vs2010_md.md)], or if a .testsettings file is manually added to a [!INCLUDE[vs_dev11_long](../codequality/includes/vs_dev11_long_md.md)] solution containing a unit test project, or coded UI test project.  
  
 You can also use tcm.exe to run test cases with associated automation from the command line using a test environment.  
  
## Tasks  
 Use the following topics to help you run automated tests from the command line:  
  
|Tasks|Associated Topics|  
|-----------|-----------------------|  
|**Running automated tests from the command line using mstest.exe:** You can run automated tests from the command line either locally or by using a test controller or test agents.|-   [Run automated tests from the command line using MSTest](../test/run-automated-tests-from-the-command-line-using-mstest.md)<br />-   [MSTest.exe command-line options](../test/mstest.exe-command-line-options.md)<br />-   [Walkthrough: using the command-line test utility](../test/walkthrough--using-the-command-line-test-utility.md)|  
|**Running test cases with associated automation from the command line using tcm.exe:** You can run automated tests from the command line either locally or by using a test controller or test agents.|-   [Run automated tests from the command line using tcm](../test/run-automated-tests-from-the-command-line-using-tcm.md)<br />-   [Tracking software quality](../test/tracking-software-quality.md)|  
|**Saving automated test results:** You can save the automated test results from your test runs from the command line to your [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)].|-   [Command-Line test results](../test/command-line-test-results.md)<br />-   [Command-Line options for publishing test results](../test/command-line-options-for-publishing-test-results.md)|  
|**Viewing results for your automated test runs:** You can view the results for your test run.|-   [How to: Save and Open Web Performance and Load Test Results in Visual Studio](../test/how-to--save-and-open-web-performance-and-load-test-results-in-visual-studio.md)|  
  
## See Also  
 [Running Automated Tests Using Microsoft Visual Studio](../test/running-automated-tests-using-microsoft-visual-studio.md)   
 [Creating Automated Tests Using Visual Studio](../test/creating-automated-tests-using-visual-studio.md)   
 [Plan your tests](../test/planning-manual-tests-using-the-web-portal.md)