---
title: "Testing your application using Microsoft Test Manager"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 147522ee-519f-44b3-9b42-bd5275a48d48
caps.latest.revision: 14
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
# Testing your application using Microsoft Test Manager
Use Microsoft Test Manager (MTM) to help you test the application you built. MTM stores your test plans and results on Team Foundation Server (TFS).  
  
 **Should I use Microsoft Test Manager or the web portal?**  
  
 If you don’t need all the features of Microsoft Test Manager, you can use the web portal to [plan](../test/planning-manual-tests-using-the-web-portal.md) and [run](../test/running-manual-tests-using-the-web-portal.md) your tests.  
  
 The web portal lets you create test cases and organize them into test plans and suites. When you perform a test, the web portal displays the test steps and lets you mark which steps passed or failed.  
  
 In addition, Microsoft Test Manager can record your actions, screenshots, Intellitrace logs and other diagnostic data. It also lets you manage lab environments.  
  
 But you don’t have to decide upfront - you can always use either tool to edit your test plans or run your tests.  
  
 **Where do I get Microsoft Test Manager?**  
  
 It’s installed with Visual Studio Enterprise and [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)].  
  
## What you can do with Microsoft Test Manager  
 Go to one of the topics below for how-to information.  
  
|Topic|What you can do|  
|-----------|---------------------|  
|[Exploratory testing](../test/exploratory-testing-using-microsoft-test-manager.md)|Record your actions while you perform a test without pre-planned steps.|  
|[Plan manual tests with Microsoft Test Manager](../test/plan-manual-tests-with-microsoft-test-manager.md)|Plan tests with the option of creating steps from recorded actions.|  
|[Run manual tests with Microsoft Test Manager](../test/run-manual-tests-with-microsoft-test-manager.md)|Display the test case at the side of the screen while you perform the test. Automatically record your actions, screenshots, and other diagnostic data for inclusion in test results and bug reports.|  
|[Test configurations: specifying test platforms](../test/test-configurations--specifying-test-platforms.md)|Create multiple versions of a test, to be performed on different hardware or software configurations.|  
|[Collect more diagnostic data](../test/collect-more-diagnostic-data-in-manual-tests.md)|Collect event logs, IntelliTrace data, video, and other diagnostic data while you perform a test.|  
|[Testing Windows Store apps](../test/testing-windows-store-apps.md)|Collect diagnostic data and screenshots while you perform tests on a Windows 8 device or PC, with Microsoft Test Manager running on a separate PC.|  
|[Copying and cloning test suites and test cases](../test/copying-and-cloning-test-suites-and-test-cases.md)|Copy test suites or plans from one project to another.|  
|[Record and play back manual tests](../test/record-and-play-back-manual-tests.md)|Record your keystrokes and gestures while you perform a test, and then repeat the actions rapidly on a later occasion.|  
|[Plan tests from Excel or Word](../test/plan-application-tests-from-a-microsoft-excel-or-microsoft-word-document.md)|Use Microsoft Excel to edit test plans in bulk, and synchronize with plans embedded in Microsoft Word documents.|  
|[Test on a lab environment](../test/test-on-a-lab-environment.md)|Gather diagnostic data from servers while you perform a test. Manage the assignment of server machines to testers. Quickly set up fresh test configurations by using virtual machines.|  
|[Tracking software quality](../test/tracking-software-quality.md)|Monitor the progress of your project by tracking the tests that pass or fail. Manage bugs.|  
|[Automate system tests](../test/automate-system-tests.md)|Link test methods in code to emulate your manual tests, so that they can be repeated regularly. Automate the deployment of your application and tests to a lab environment. Set up a completely automatic build-deploy-test workflow.<br /><br /> Add existing automated tests from Visual Studio to your test suites.|  
|[Keyboard shortcuts for Microsoft Test Manager](../test/keyboard-shortcuts-for-microsoft-test-manager.md)||