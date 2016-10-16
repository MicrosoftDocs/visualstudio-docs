---
title: "Automate system tests"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "tests, test plan, Essentials guide"
  - "test plan, essentials guide"
ms.assetid: ed513c69-9059-4d84-b49c-a360ee5e4b63
caps.latest.revision: 17
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
# Automate system tests
In each sprint, you’ll want to focus your [manual test](../test/planning-manual-tests-using-the-web-portal.md) effort on the new requirements that are implemented in each sprint. At the same time, you’ll want to repeat some of the tests from previous sprints, to make sure that recent development work hasn’t introduced bugs into features that were working before. The workload of this regression testing gradually increases through the life of your project. It’s a necessary aspect of agile development, which starts with a simple end-to-end implementation and then revisits each component to add new functionality.  
  
 To reduce the load of regression testing, you can automate the system tests that you performed manually. Typically you create test cases for each requirement and perform them manually for one or two sprints; and then you automate some of them for future sprints.  
  
 There are several ways in which you can automate tests:  
  
-   **[Link a test method to a test case.](../test/automate-a-test-case-in-microsoft-test-manager.md)**  
  
     You can link any unit test to a test case, though typically you would link an integration test that mimics the manual version of the test case. A test case can have both manual and automated versions. You can run the automated test cases from Microsoft Test Manager, and the results will appear along with the manual test cases.  
  
-   **Link a coded UI test to a test case.**  
  
     A coded UI test (CUIT) simulates user gestures. It can click buttons, enter text, and verify the values displayed in text fields. This type of test can provide the most accurate automation of your manual test. You can create a CUIT by recording your actions while you perform the test manually. The CUIT is a test method, which will run within the unit test framework, and which you can link to your test case. You can run it along with other automated and manual tests.  
  
-   **Automated build-deploy-test.**  
  
     You can run system tests as part of the build process. The build process can deploy your server components on lab machines, so as to achieve realistic running conditions.  
  
## Topics in this section  
  
|||  
|-|-|  
|[Automate a test case](../test/automate-a-test-case-in-microsoft-test-manager.md)|Associate the test case with a test method, create a lab environment, and specify where the built test method can be found.<br /><br /> Run automated test cases from Microsoft Test Manager in the same way as manual test cases.|  
|[Use UI Automation To Test Your Code](../codequality/use-ui-automation-to-test-your-code.md)|Create a test method that simulates user actions by recording your manual test.|  
|[Automated build-deploy-test workflows](../test/automated-build-deploy-test-workflows.md)|As part of a server build, automatically deploy the code to a lab environment, run tests, and collect diagnostic data.|  
|[Creating and using a network isolated environment](../test/creating-and-using-a-network-isolated-environment.md)|To allow you to run many tests of a system in parallel, you can define virtual lab environments that have the same internal addresses but are not visible to each other.|  
|[How to run automated tests on multiple computers at the same time](../test/how-to-run-automated-tests-on-multiple-computers-at-the-same-time.md)||