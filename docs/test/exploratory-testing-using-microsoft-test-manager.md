---
title: "Exploratory testing using Microsoft Test Manager"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Microsoft Test Manager, exploratory testing"
  - "Exploratory testing"
ms.assetid: bf3fc3b0-7e43-407c-b2bc-dcf773ae889f
caps.latest.revision: 69
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
# Exploratory testing using Microsoft Test Manager
While you work with your application, [Microsoft Test Manager](../test/testing-your-application-using-microsoft-test-manager.md) (MTM) can record your actions, comments, screenshots and other data. The recording makes it easy to reproduce bugs. And you can quickly play back your tests whenever the application is updated.  
  
### Exploring your app  
  
1.  Install [the latest build of your application](../Topic/Build%20the%20application.md). If it’s a desktop application, install it on a machine that has MTM. If it’s a server, you can install it on any other machine, but you’ll want to run the browser or client on the same machine where you have MTM.  
  
     (To manage test machines more effectively, see [Test on a lab environment](../test/test-on-a-lab-environment.md).)  
  
2.  [Connect MTM to your test plan](../test/connect-microsoft-test-manager-to-your-team-project-and-test-plan.md) if you haven’t already. The test plan stores default settings and test results.  
  
3.  Start an exploratory test session in Microsoft Test Manager.  
  
     ![Starting exploratory testing](../test/media/almp_t_explore01.png "ALMP_T_Explore01")  
  
     Test Runner appears at the side of the screen. It will stay there while you work with your application.  
  
4.  Get your app ready to start testing. For example, if it’s a website, start the server.  
  
5.  When you’re ready, start recording.  
  
     ![Test Runner highlighting Start button](../test/media/almp_t_explore02a.png "ALMP_T_Explore02a")  
  
6.  While you work with the application, add comments and screenshots in the Test Runner window.  
  
     ![Record your comments and actions while exploring](../test/media/almp_t_explore110.png "ALMP_T_explore110")  
  
     Double-click a screenshot if you want to edit it.  
  
7.  Create a bug if you find a problem. The bug will automatically include a list of your actions and comments.  
  
     ![Bug automatically includes repro steps](../test/media/almp_t_explore112.png "ALMP_T_explore112")  
  
8.  Create a test case.  
  
     Why? When the application is updated, you’ll want to run the test again to make sure everything is still working. With the list of your actions, it’s easy for you or someone else to repeat the same test.  
  
     ![Create a test case from your action recording](../test/media/almp_t_explore113.png "ALMP_T_explore113")  
  
     You’ll probably want to use **Change Steps** to set how many recent actions are included.  
  
9. Pause ![Pause recording](../test/media/almp_t_pausebutton.png "ALMP_T_PauseButton") the recording if you need to attend to something else. You don’t want your emails or passwords included in the recording.  
  
10. Complete your test.  
  
     ![Pausing and completing your recording](../test/media/almp_t_explore114.png "ALMP_T_explore114")  
  
     Give your test run a title that expresses the result, such as "Failed to open account" or "Successfully created an order."  
  
11. Review the exploratory tests in this plan to see how well the sprint is progressing.  
  
     ![Summary of the exploratory test session](../test/media/almp_t_explore14.png "ALMP_T_Explore14")  
  
## Q & A  
  
### How do I enable screen recording during testing?  
 That’s an option in your test settings. Open **Plan**, **Properties** and under **Manual runs** choose **Test settings** = **\<New…>**. In the test settings wizard, give the new settings a name. On the **Data and Diagnostics** page, scroll down and select **Screen and Voice recorder**. Click **Configure** if you want to record your voice along with the screen.  
  
 Close the test settings and **Save and Close** the test plan properties. When you start a test, a real-time screen recording will be added.  
  
 When you want to run tests without real-time recording, go back to the test plan properties and set **Test Settings = \<Default>**.  
  
## Try this next  
  
-   [Plan manual tests with Microsoft Test Manager](../test/plan-manual-tests-with-microsoft-test-manager.md)  
  
### Or, dig deeper:  
  
-   [Collect more diagnostic data](../test/collect-more-diagnostic-data-in-manual-tests.md)  
  
-   [Test on a lab environment](../test/test-on-a-lab-environment.md)