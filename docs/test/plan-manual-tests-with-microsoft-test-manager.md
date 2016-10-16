---
title: "Plan manual tests with Microsoft Test Manager"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "test case parameters, adding"
  - "test cases, creating"
  - "test steps, adding"
ms.assetid: 65e1b24f-2ea2-4390-88bd-f82df6ba42d0
caps.latest.revision: 55
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
# Plan manual tests with Microsoft Test Manager
At the start of a sprint, find out what you need to test. Discussing test cases is a great way to help the team understand the detail of what your users need. Tests planned in this way provide a clear target for the development team.  
  
> [!TIP]
>  You can also use [the web portal to plan manual tests](../test/planning-manual-tests-using-the-web-portal.md). It is generally more convenient for creating test cases.  
  
1.  [Connect to a test plan](../test/connect-microsoft-test-manager-to-your-team-project-and-test-plan.md) if you haven’t already.  
  
     The test plan links together the test cases you’ll use in this sprint.  
  
2.  Add a manual test case to your test plan.  
  
     ![Create a test case](../test/media/almp_t_create04.png "ALMP_T_Create04")  
  
3.  Name the test case.  
  
     ![Give the test case a title](../test/media/almp_t_create05.png "ALMP_T_Create05")  
  
4.  Add the steps to perform during the test. Don’t forget to include the expected results.  
  
     ![Define test case steps](../test/media/almp_t_create06.png "ALMP_T_Create06")  
  
     To add multiple lines in a step, press ALT + Enter.  
  
 Now that you've defined a manual test case, you can run it from MTM and keep the results in TFS.  
  
## Organize your test cases with test suites  
 Test suites are folders inside a test plan that help you organize tests. When you run tests, you can choose to run all the tests in a suite, one after another.  
  
-   Create a new test suite.  
  
     ![Creating a new test suite](../test/media/almp_t_newsuite01.png "ALMP_T_newSuite01")  
  
-   Select a suite and then create new tests in the suite.  
  
     ![Create a test case in a suite](../test/media/almp_t_newsuite02.png "ALMP_T_newSuite02")  
  
-   Drag test cases from one suite to another, or cut and paste.  
  
     ![Drag test cases from one suite to another](../test/media/almp_t_dragsuites.png "ALMP_T_dragSuites")  
  
     CTRL + drag or copy and paste to make the same test case appear in more than one suite.  
  
     These operations don’t affect the test case itself. Suites contain links to test cases, and it’s the links that you’re moving or copying. For the same reason, removing a test case from a suite doesn’t delete the test case from TFS.  
  
## Try this next  
  
-   [Run manual tests with Microsoft Test Manager](../test/run-manual-tests-with-microsoft-test-manager.md)  
  
### Or, dig deeper:  
  
-   [Share steps between test cases](../test/share-steps-between-test-cases.md)  
  
-   [Repeat a test with different data](../test/repeat-a-test-with-different-data.md)  
  
-   [Test configurations: specifying test platforms](../test/test-configurations--specifying-test-platforms.md)  
  
-   [Test on a lab environment](../test/test-on-a-lab-environment.md)