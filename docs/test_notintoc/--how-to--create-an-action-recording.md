---
title: "- How to: Create an Action Recording"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "action recording, creating"
  - "Test Runner, creating action recordings"
ms.assetid: 492b7bfb-4e4d-41ff-b5c3-0c21099524fa
caps.latest.revision: 86
ms.author: "ahomer"
manager: "kamrani"
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
# - How to: Create an Action Recording
In [!INCLUDE[mtrlong](../codequality/includes/mtrlong_md.md)], you have the option of recording a manual test so that it can be played back later or reused in other tests. You do this by creating an *action recording*. An action recording is useful in manual tests that you need to run multiple times and for recycling common steps in different manual tests that contain shared steps. For more information, see [-How to: Create an Action Recording for Shared Steps](../test_notintoc/-how-to--create-an-action-recording-for-shared-steps.md).  
  
 After you create the action recording, you can invoke it during a test. When an action recording runs, it automatically plays back the steps that you recorded. For more information, see [- How to: Play Back an Action Recording](../test_notintoc/--how-to--play-back-an-action-recording.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
> [!NOTE]
>  Input to an Input Method Editor (IME) is not supported for creating an action recording because an action recording cannot aggregate actions into a single action. (An IME is a program that allows computer users to enter complex characters and symbols, such as Japanese characters, using a standard keyboard.)  
  
 The following procedures describe how to create an action recording.  
  
## Load a Test into Test Runner  
 ![Selecting test to run in Microsoft Test Manager](../test_notintoc/media/runtest.png "RunTest")  
  
> [!NOTE]
>  If you have configured test settings to create an action log for the test being run, selecting the **Create action recording** option when you start a test will use the settings that you configured. If you did not configure the actions diagnostic data adapter in your test settings, then the default values are used to create your action recording. For more information, see [How to: Choose the applications that are recorded](../test_notintoc/how-to--choose-the-applications-that-are-recorded-in-a-manual-test.md).  
  
#### To load a test into Test Runner  
  
1.  Open [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)].  
  
    > [!NOTE]
    >  To display the [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] window, choose Start, All Programs, Microsoft Visual Studio, Microsoft Test Manager.  
  
2.  On the center group switcher, choose the down-arrow and then choose **Testing Center**.  
  
3.  On the center group menu bar, choose **Test**.  
  
4.  In the menu under the center group menu bar, choose **Run Tests** if it is not already selected.  
  
5.  In the left pane, under **Run Tests**, select either the test plan or the test suite listed under the test plan that contains the test that you want to run.  
  
6.  The right side pane displays the test cases within the selected test suite.  
  
7.  In the right side pane, choose the test case and then choose **Run**.  
  
     The **Test Runner** opens.  
  
    > [!NOTE]
    >  Select **Run with options** to specify a build to run the test on, or to override the test settings and environment settings for the test plan. For more information, see [How to: Override Settings in Your Test Plan for Test Runs](assetId:///832576d2-44bd-4237-8cde-612349a3ab50).  
  
## Record an Action Recording  
 You must first load the test that you want to record into [!INCLUDE[mtrlong](../codequality/includes/mtrlong_md.md)]. For more information, see the previous procedure, "Load a Test into Test Runner."  
  
 ![Creating an action recording in Test Runner](../test_notintoc/media/how_actrecord.png "How_ActRecord")  
  
#### To record an action recording  
  
1.  Upon loading a test from [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] into [!INCLUDE[mtrshort](../test_notintoc/includes/mtrshort_md.md)], you are prompted to **Start Test** with the option **Create action recording**. Select **Create action recording** and click **Start Test**.  
  
    > [!NOTE]
    >  If the test contains an existing action recording, you are prompted with the option **Overwrite existing action recording**. Select this option to create a new recording that replaces the previous action recording, and then choose **Start Test**.  
  
     The action recording can be played by using the **Play** option in the toolbar. For more information, see [- How to: Play Back an Action Recording](../test_notintoc/--how-to--play-back-an-action-recording.md).  
  
     You can specify which applications to record in your test settings for the actions diagnostic data adapter. If you have configured test settings to create an action log for the test being run, selecting the **Create action recording** option when you start a test will use the settings that you configured. If you did not configure the actions diagnostic data adapter in your test settings, then the default values are used to create your action recording. For more information, see [How to: Choose the applications that are recorded](../test_notintoc/how-to--choose-the-applications-that-are-recorded-in-a-manual-test.md).  
  
     Each test step including launching the application is recorded after you choose **Start Test**.  
  
    > [!NOTE]
    >  If your test setting includes collecting IntelliTrace data, you must start the application after the test is started. For more information, see [How to: Collect IntelliTrace Data to Help Debug Difficult Issues](../test/how-to--collect-intellitrace-data-to-help-debug-difficult-issues.md).  
  
2.  Perform the steps of the test case and mark each step with a result. Use the drop-down arrow to the right of the step and select either **Pass** or **Fail**.  
  
     The words **Currently Recording** appear in the title bar of each application that is being recorded. An *action recording section,* presented as a blue indicator, is displayed to the right of the test. The blue indicator is divided into individual sections that correspond to the steps of your test.  
  
    > [!NOTE]
    >  If you do not mark each test step as either passed or failed, then the action recording section can span several test steps. It includes all unmarked test steps since the last step that was marked as passed or failed.  
  
3.  (Optional) Recorded actions can be deleted at any step while the test is running. To delete a recorded action, follow these steps:  
  
    1.  Choose the up-arrow displayed in the bottom panel of [!INCLUDE[mtrlong](../codequality/includes/mtrlong_md.md)].  
  
    2.  All the actions which took place up to this step are displayed.  
  
    3.  Select the action you want to delete and then right-click the selection and point to **Delete recorded actions**.  
  
4.  Choose **End Test**.  
  
5.  In the toolbar at the top of [!INCLUDE[mtrshort](../test_notintoc/includes/mtrshort_md.md)], choose one of the following options:  
  
    -   Choose **Save and Close** to save your test results to the [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] and close [!INCLUDE[mtrshort](../test_notintoc/includes/mtrshort_md.md)].  
  
    -   Choose **Save** to save the test results to the [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)].  
  
    -   Choose **Close** to close [!INCLUDE[mtrshort](../test_notintoc/includes/mtrshort_md.md)] and not save the test results.  
  
    > [!NOTE]
    >  If an existing action recording already exists for the test, the **Test Runner - Microsoft Test Manager** dialog box appears. You have the option to either **Overwrite existing recording** or **Discard new recording**.  
  
     The action recording can now be replayed when you run this in the test case future. For more information, see [- How to: Play Back an Action Recording](../test_notintoc/--how-to--play-back-an-action-recording.md).  
  
## See Also  
 [Reviewing Test Results in Microsoft Test Manager](assetId:///9fb3e429-78df-4fe2-89ed-0ad1db0738f4)   
 [- How to: Play Back an Action Recording](../test_notintoc/--how-to--play-back-an-action-recording.md)   
 [How to: Include Recordings of the Screen and Voice During Tests Using Test Settings](../test/how-to--include-recordings-of-the-screen-and-voice-during-tests-using-test-settings.md)   
 [-How to: Create an Action Recording for Shared Steps](../test_notintoc/-how-to--create-an-action-recording-for-shared-steps.md)   
 [Record and play back manual tests](../test/record-and-play-back-manual-tests.md)   
 [Supported Configurations and Platforms for Coded UI Tests and Action Recordings](../codequality/supported-configurations-and-platforms-for-coded-ui-tests-and-action-recordings.md)