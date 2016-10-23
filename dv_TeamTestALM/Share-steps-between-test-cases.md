---
title: "Share steps between test cases"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 5b7b1bfa-d958-442d-ab90-a0339b8baf0a
caps.latest.revision: 43
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
# Share steps between test cases
When you [plan manual tests](../dv_TeamTestALM/Planning-manual-tests-using-the-web-portal.md) there are some sequences of steps, such as logging in, that occur in many test cases. To avoid having to enter these sequences again and again, create *shared steps*.  
  
## Create shared steps  
 While you’re editing a test case, select a sequence of steps that you want to share:  
  
-   ![Create shared steps](../dv_TeamTestALM/media/ALMT_ws31CreateSharedSteps.png "ALMT_ws31CreateSharedSteps")  
  
 The steps you selected are replaced with a link to the new shared steps work item:  
  
-   ![Resulting test case with a shared step.](../dv_TeamTestALM/media/ALMT_ws34CreateSharedResult.png "ALMT_ws34CreateSharedResult")  
  
## Use shared steps  
 Now you can use the shared steps in another test case:  
  
-   ![Use shared steps in test cases.](../dv_TeamTestALM/media/ALMT_ws32UseSharedSteps.png "ALMT_ws32UseSharedSteps")  
  
 A TFS query opens. Run it to find the steps you want to insert:  
  
-   ![Run the query to find shared steps](../dv_TeamTestALM/media/ALMT_ws33SharedStepQuery.png "ALMT_ws33SharedStepQuery")  
  
## When you run a test with shared steps  
 When you [run a test](../dv_TeamTestALM/Running-manual-tests-using-the-web-portal.md), you can either mark the whole shared sequence as passed or failed, or mark each step separately:  
  
-   ![Shared steps in Test Runner.](../dv_TeamTestALM/media/ALMT_ws33RunSharedSteps.png "ALMT_ws33RunSharedSteps")  
  
## Q & A  
 **Q: How do I use shared steps in Microsoft Test Manager?**  
 It’s almost exactly the same in [Microsoft Test Manager](../dv_TeamTestALM/Testing-your-application-using-Microsoft-Test-Manager.md) as in the web portal. The buttons look slightly different.  
  
 **Q: Can I find all my shared steps, and all the test cases where they are used?**  
 Yes. [Open Microsoft Test Manager](../dv_TeamTestALM/Connect-Microsoft-Test-Manager-to-your-team-project-and-test-plan.md) and look under **Organize**, **Shared Steps Manager**.  
  
 Shared steps and test cases are stored as work items in Team Foundation Server.  
  
 **Q: Can I share steps between test plans and team projects?**  
 Yes. But don’t forget that if you edit shared steps, the changes appear in every place you use them.  
  
 **Q: Can I use parameters in shared steps?**  
 Yes. You provide values for the [parameters](../dv_TeamTestALM/Repeat-a-test-with-different-data.md) in the test cases where the shared steps are used.  
  
 You don’t have to provide values in the shared steps definition. However, you can provide one default row of values, which is used when you create an action recording of a standalone shared step.