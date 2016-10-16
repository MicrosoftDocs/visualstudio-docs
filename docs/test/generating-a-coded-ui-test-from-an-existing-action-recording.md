---
title: "Generating a Coded UI Test from an Existing Action Recording"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "coded UI tests, generate from action recording"
  - "action recording, generate coded UI tests"
ms.assetid: 56736963-9027-493b-b5c4-2d4e86d1d497
caps.latest.revision: 42
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
# Generating a Coded UI Test from an Existing Action Recording
You can automate manual system tests. [Generate a coded test from recording of a manual test run](#generate) created with [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], or [link the test case to an existing coded test](#linkToCode). You can run the automated test as part of a team build, and the results contribute to the reports of test cases in the same way as the manual test run.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
## Why should I automate system tests?  
 You’ll want to repeat system tests at regular intervals to make sure that recent development work hasn’t introduced bugs. But as the app gets bigger through the life of your project, more and more tests have to be performed. To avoid an impossibly big load of manual testing, it’s good to automate many of your tests.  
  
 As a general rule, manual tests are more effective for testing new features, and automated tests are better for verifying features that have already been tested manually.  
  
 There are two ways to automate manual test cases:  
  
-   [Generate a coded UI test from a recording of a manual test run.](#generate) You can subsequently edit it. For example, you can run the test with multiple test data sets.  
  
     Advantages of this method:  
  
    -   A test can be generated quickly.  
  
    -   The test code is an accurate representation of the manual actions.  
  
    -   The test includes the user interface and any logic that it contains.  
  
    -   Even if you’re more proficient in testing than you are in writing code, you can still create and edit the test.  
  
     Disadvantages:  
  
    -   If the layout of the user interface is significantly changed, the test might become invalid. You might have to create it again, or edit the code that represents the actions.  
  
-   [Link the test case to existing test code.](#linkToCode) It can be any method that can be run by test explorer.  
  
     Advantages:  
  
    -   This is the quickest way if an appropriate test method has already been developed along with the app code.  
  
    -   Changes in the user interface do not affect the test, because the test typically drives the app through the business layer.  
  
     Disadvantages:  
  
    -   The test code might not accurately simulate the manual version of the test case. You have to make sure that the test code is an appropriate implementation of the intention of the test case.  
  
 You can also partially automate a test by recording a test run. On subsequent occasions, you can play back the recorded actions. But you have to be present so that you can verify the results of each step. See [Record and play back manual tests](../test/record-and-play-back-manual-tests.md).  
  
## How do I automate a manual system test?  
 Create coded UI tests from action recordings using Visual Studio Enterprise. Creating a coded UI test requires you to add a coded UI test project to your solution, after which you can easily add coded UI tests that are created from action recordings which are associated with work items. The steps to create these coded UI tests are described in ”Generate a Coded UI Test from an Action Recording” later in this topic.  
  
> [!NOTE]
>  You can also create action recordings directly by recording the app under development. See [How to: Generate a Coded UI Test by Recording the Application Under Development](../misc/how-to--generate-a-coded-ui-test-by-recording-the-application-under-development.md).  
  
##  <a name="generate"></a> Generate a Coded UI Test from an Action Recording  
 **Using Microsoft Test Manager**, run the test case that you want to automate. When you start the test, be sure to select **Create Action Recording**. Work through the test. If you have to attend to something else in the middle of the test, use the **Pause** button to suspend the recording. Don’t worry if you make a mistake—simply repeat part of the sequence. You can edit out the incorrect actions later. When you have completed the test run, choose **Save and Close** to save the action recording.  
  
 For more information about how to create action recordings, see [Record and play back manual tests](../test/record-and-play-back-manual-tests.md).  
  
 **Using Visual Studio**, in Solution Explorer, right-click a coded UI test project, point to **Add**, and then choose **Coded UI Test**. After the **Generate Code for a Coded UI Test** dialog box displays, choose **Use an existing action recording**.  
  
 ![Create coded UI test from action recording](../test/media/cuit_actionrecording1.png "CUIT_ActionRecording1")  
  
 *I don't see the option to add coded UI tests.*  
 You might be using a version of Visual Studio that does not support coded UI tests. To create coded UI tests, you must use Visual Studio Enterprise.  
  
 ![Find existing action recording](../test/media/cuitactionrecording2.png "CUITActionRecording2")  
  
 Using the **Work Items Picker** dialog box, find the work item with an attached action recording.  
  
 When the coded UI test is generated, a method is created for each step in the test case from the action recording. For example, the code below calls three methods based on the steps that were in the action recording that was selected previously:  
  
```  
  
[TestMethod]  
public void CodedUITestMethod1()  
{  
  
    this.UIMap.Navigatetocart();this.UIMap.Changequantity();this.UIMap.Verifytotalchangescorrectly();  
  
}  
```  
  
 Additionally, the UI controls are added to the UI map, and actions are added to your coded UI test.  
  
 *What else should I know?*  
 **Notes**  
  
-   ![Prerequsite](../codequality/media/prereq.png "Prereq") If you are not currently connected to a team project on a Team Foundation Server, when you try to create a coded UI test from an action recording, the **Connect to Team Project** dialog box appears. You must connect to a team project in order to view the work items containing the action recordings. See [Connect from Visual Studio or Team Explorer](../Topic/Connect%20to%20team%20projects%20in%20Team%20Foundation%20Server.md#te).  
  
 **Tips**  
  
-   ![Tip](../codequality/media/tip.png "Tip") If you don’t have a coded UI test project in your solution, you can add one by choosing the **Add New Project** from the Solution Explorer shortcut menu. For more information, see [Creating Solutions and Projects](../ide/creating-solutions-and-projects.md).  
  
-   ![Tip](../codequality/media/tip.png "Tip") If necessary, you can modify the code in your action recordings, or use the Coded UI Test Editor. This provides the ability to do things such as add delays between actions, and split up your methods to further modularize your test. For more information, see [Automated Testing with Coded UI Tests](../test/automated-testing-with-coded-ui-tests.md) and [Editing Coded UI Tests Using the Coded UI Test Editor](../codequality/editing-coded-ui-tests-using-the-coded-ui-test-editor.md).  
  
-   ![Tip](../codequality/media/tip.png "Tip") For additional guidance, see [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 5: Automating System Tests](http://go.microsoft.com/fwlink/?LinkID=255196).  
  
##  <a name="LinktoCode"></a> Associating the test case to existing test code  
 If you have test code that fulfills the intention of the test case, then you can associate the test case to that test method. Typically, the test might be an end-to-end functional test. It does not have to be a coded UI test.  
  
> [!WARNING]
>  If you are automating a test case that already has manual test steps, make sure that the code performs an equivalent test to the manual steps. It should fail in any case in which the manual test would fail.  
  
 You can only associate the automated Visual Studio system test with your manual test case using [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)]. You cannot make this association using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. If you have an existing test case that you want to use, you must first open the test case using [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)], as shown in the next illustration.  
  
 ![Open Test Case Using Microsoft Visual Studio](../test/media/open_testcasevs.png "Open_TestCaseVS")  
  
 Then you can associate the test method with your test case, as shown in the next illustration.  
  
 ![Associate Automation With Test Case](../test/media/associate_automation.png "Associate_Automation")  
  
 For more information on associating a test case with an automated system test in Visual Studio, see [Automate a test case](../test/automate-a-test-case-in-microsoft-test-manager.md).  
  
## What’s next?  
  
-   [Create a Lab Environment and Settings to Run Your Tests](../test/automate-a-test-case-in-microsoft-test-manager.md#AddEnvironment) After automating your manual tests, you can define additional diagnostic data to collect with your tests and specify an environment to run them in.  
  
-   [Run the Automated Test](../test/automate-a-test-case-in-microsoft-test-manager.md#RunTest) Run your automated manual tests from [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)].  
  
-   [Set Your Test Plan to Use Your Build](../test/automate-a-test-case-in-microsoft-test-manager.md#TestPlan) Specify specific builds for your automated manual tests to run against using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)].  
  
-   [View and Update the Test Results](../test/automate-a-test-case-in-microsoft-test-manager.md#ViewTest) Monitor your automated manual tests to verify app integrity.  
  
## See Also  
 [Use UI Automation To Test Your Code](../codequality/use-ui-automation-to-test-your-code.md)   
 [Automated Testing with Coded UI Tests](../test/automated-testing-with-coded-ui-tests.md)   
 [How to: Generate a Coded UI Test by Recording the Application Under Development](../misc/how-to--generate-a-coded-ui-test-by-recording-the-application-under-development.md)   
 [Supported Configurations and Platforms for Coded UI Tests and Action Recordings](../codequality/supported-configurations-and-platforms-for-coded-ui-tests-and-action-recordings.md)   
 [Upgrading Coded UI Tests from Visual Studio 2010](../codequality/upgrading-coded-ui-tests-from-visual-studio-2010.md)