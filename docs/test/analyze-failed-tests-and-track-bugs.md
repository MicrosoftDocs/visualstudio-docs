---
title: "Analyze failed tests and track bugs"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "bugs, tracking"
ms.assetid: b7ce36bf-ca2e-49ac-83aa-bce538cecae9
caps.latest.revision: 38
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
# Analyze failed tests and track bugs
## Submitting bugs while testing  
 You can create bug work items while you are performing a test, either with [the web portal](../test/running-manual-tests-using-the-web-portal.md) or [Microsoft Test Manager](../test/run-manual-tests-with-microsoft-test-manager.md), and also when you are [reviewing test results](../test/track-your-test-results.md).  
  
 Bugs that you create in these tools are automatically linked to the test that you were performing. They include the list of passed and failed steps that you performed. If you entered any comments or attached files while performing the test, they are also attached to the bug.  
  
 ![Submitting bugs in Test Runner](../test/media/how_bug.png "How_Bug")  
  
### Additional diagnostic data  
 If you want bugs to include diagnostic data such as screenshots and system information, [perform your tests with Microsoft Test Manager](../test/run-manual-tests-with-microsoft-test-manager.md). To attach IntelliTrace logs, event logs, video recordings, and other data, [define test settings](../test/collect-more-diagnostic-data-in-manual-tests.md).  
  
 To collect diagnostic data from your application’s server components while you perform a test, deploy the servers on a [lab environment](../test/test-on-a-lab-environment.md).  
  
 If you want to be able to take snapshots of the machine states, use virtual machines in an [SCVMM environment](../test/scvmm--virtual--environments.md).  
  
## Analyzing tests  
 When you have finished a series of manual or [automated](../test/automate-system-tests.md) tests, you can inspect the results and decide what to do about them.  
  
 ![Analyse runs page in MTM](../test/media/almt_wsa10analyseruns.png "ALMT_wsa10analyseRuns")  
  
 Open a test run to inspect the results of individual tests. For each test, you can indicate the type of failure and resolution, add comments, and assign the result to a team member. You can also create bugs.  
  
 ![Analyse test run page in MTM](../test/media/almt_wsa11analysetest.png "ALMT_wsa11analyseTest")  
  
 Analysis is optional, but is particularly useful for automated tests.  
  
## Tracking bugs  
 Use the Verify Bugs page to run the queries that finds bug created by you or assigned to you. If you created a bug, it will be assigned back to you when the developer has checked in the fixed code and has set the bug’s state to **Done**.  
  
 You can also create your own TFS query to use on the Verify Bugs page.  
  
### Verify a bug fix  
 Use **Verify** to re-run the test case that is linked to a bug. [Run the test in the usual way](../test/run-manual-tests-with-microsoft-test-manager.md).  
  
 ![How to Verify a Bug](../test/media/howto_verifybug.png "HowTo_VerifyBug")  
  
### Create a test case from a bug  
 You can create a test case that has steps automatically created from the actions you performed before you created the bug. This generates a test case that directly verifies that the bug has been fixed. The test case can also be run again in later sprints to make sure the bug hasn’t come back.  
  
 ![Create a Test Case From a Bug](../test/media/testcase_bug.png "TestCase_Bug")  
  
 If the bug was created while you were investigating a test case, then you probably won’t need to generate a new one.