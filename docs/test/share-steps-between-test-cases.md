---
title: "Share steps between test cases"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "shared steps"
ms.assetid: 5b7b1bfa-d958-442d-ab90-a0339b8baf0a
caps.latest.revision: 43
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
# Share steps between test cases
When you [plan manual tests](../test/planning-manual-tests-using-the-web-portal.md) there are some sequences of steps, such as logging in, that occur in many test cases. To avoid having to enter these sequences again and again, create *shared steps*.  
  
## Create shared steps  
 While you’re editing a test case, select a sequence of steps that you want to share:  
  
-   ![Create shared steps](../test/media/almt_ws31createsharedsteps.png "ALMT_ws31CreateSharedSteps")  
  
 The steps you selected are replaced with a link to the new shared steps work item:  
  
-   ![Resulting test case with a shared step.](../test/media/almt_ws34createsharedresult.png "ALMT_ws34CreateSharedResult")  
  
## Use shared steps  
 Now you can use the shared steps in another test case:  
  
-   ![Use shared steps in test cases.](../test/media/almt_ws32usesharedsteps.png "ALMT_ws32UseSharedSteps")  
  
 A TFS query opens. Run it to find the steps you want to insert:  
  
-   ![Run the query to find shared steps](../test/media/almt_ws33sharedstepquery.png "ALMT_ws33SharedStepQuery")  
  
## When you run a test with shared steps  
 When you [run a test](../test/running-manual-tests-using-the-web-portal.md), you can either mark the whole shared sequence as passed or failed, or mark each step separately:  
  
-   ![Shared steps in Test Runner.](../test/media/almt_ws33runsharedsteps.png "ALMT_ws33RunSharedSteps")  
  
## Q & A  
 **Q: How do I use shared steps in Microsoft Test Manager?**  
 It’s almost exactly the same in [Microsoft Test Manager](../test/testing-your-application-using-microsoft-test-manager.md) as in the web portal. The buttons look slightly different.  
  
 **Q: Can I find all my shared steps, and all the test cases where they are used?**  
 Yes. [Open Microsoft Test Manager](../test/connect-microsoft-test-manager-to-your-team-project-and-test-plan.md) and look under **Organize**, **Shared Steps Manager**.  
  
 Shared steps and test cases are stored as work items in Team Foundation Server.  
  
 **Q: Can I share steps between test plans and team projects?**  
 Yes. But don’t forget that if you edit shared steps, the changes appear in every place you use them.  
  
 **Q: Can I use parameters in shared steps?**  
 Yes. You provide values for the [parameters](../test/repeat-a-test-with-different-data.md) in the test cases where the shared steps are used.  
  
 You don’t have to provide values in the shared steps definition. However, you can provide one default row of values, which is used when you create an action recording of a standalone shared step.