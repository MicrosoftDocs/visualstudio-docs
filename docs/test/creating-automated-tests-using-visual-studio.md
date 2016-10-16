---
title: "Creating Automated Tests Using Visual Studio"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: a574d7fa-10bd-453a-8ce0-b899178aee5b
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
# Creating Automated Tests Using Visual Studio
Using Visual Studio, you can create, manage, and run unit tests, coded UI tests, web performance tests, and load tests.  
  
 [!INCLUDE[crabout](../codequality/includes/crabout_md.md)] web performance and load tests see [Web performance and load tests in Visual Studio](../test_notintoc/web-performance-and-load-tests-in-visual-studio.md).  
  
 Unit tests and coded UI tests are generally used by developers, or by team members who use Visual Studio, to validate the quality of their code in an app. For example, you might run these tests prior to checking your code into [version control](../Topic/Use%20version%20control.md). For more information, see [Unit Test Your Code](../codequality/unit-test-your-code.md) and [Use UI Automation To Test Your Code](../codequality/use-ui-automation-to-test-your-code.md). However, team members involved in testing the application can also use these tests types for converting manual tests to automated tests and for isolating bugs that come out of integration testing from [Team Foundation builds](../Topic/Build%20the%20application.md).  
  
## Tasks  
  
|Tasks|Associated Topics|  
|-----------|-----------------------|  
|**Creating system tests in Visual Studio:** Using Visual Studio, you can create coded UI tests from an existing action recording, for example an action recording created from a manual test. This allows you to automate your team’s [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] manual testing efforts.|-   [Automated Testing with Coded UI Tests](../test/automated-testing-with-coded-ui-tests.md)|  
|**Categorizing tests:** If you have created automated tests using Visual Studio you can manage these tests by categorizing them with test categories. When you run these automated tests using Visual Studio, Team Foundation Build, or mstest.exe, you can use these test categories to easily select which tests you run. You add test categories as attributes to your test methods.|-   [Defining Test Categories to Group Your Tests](../test/defining-test-categories-to-group-your-tests.md)|  
|**Specify a group of test to run in a specific order:** An ordered test contains other tests that are meant to be run in a specified order. An ordered test is displayed as a single test in Test Explorer.|-   [Setting Up Your Test Run Sequence Using Ordered Tests](../test/setting-up-your-test-run-sequence-using-ordered-tests.md)|  
|**Using generic test to wrap an existing test, program, or third-party tool:** You use generic tests to call external programs and tests. After you have done this, the generic test is treated by the test engine as any other test type. For example, you can run generic tests from Test Explorer and you can obtain and publish results from generic tests just as you do from other tests.|-   [Creating an Automated Test That Runs an Executable Using Generic Tests](../test/creating-an-automated-test-that-runs-an-executable-using-generic-tests.md)|  
  
## Related Tasks  
 Coded UI tests can be used while developing an application to validate continuous functionality with code changes. [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)][Use UI Automation To Test Your Code](../codequality/use-ui-automation-to-test-your-code.md).  
  
 In addition to coded UI tests, Visual Studio also includes unit tests. Unit tests are used primarily to verify an isolated unit of code for quality and functionality while you are developing an app. [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)][Unit Test Your Code](../codequality/unit-test-your-code.md).  
  
## See Also  
 [Create, manage, and run unit tests, coded UI tests, web performance tests, and load tests](../test/create--manage--and-run-unit-tests--coded-ui-tests--web-performance-tests--and-load-tests.md)   
 [Running Automated Tests Using Microsoft Visual Studio](../test/running-automated-tests-using-microsoft-visual-studio.md)