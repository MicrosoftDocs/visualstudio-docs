---
title: "Automated Testing with Coded UI Tests"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: f2c5b045-c851-4657-9f88-ff24bc857293
caps.latest.revision: 10
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
# Automated Testing with Coded UI Tests
Automated tests of the user interface (UI) are known as *coded UI tests*. These tests provide functional testing of the UI and validation of UI controls. You can create coded UI tests to determine that the UI is functioning correctly after code changes.  
  
 Coded UI tests are often used in Visual Studio solutions to quickly verify correct code functionality and as a quality gate prior to checking in code changes. Coded UI tests can complement the unit tests in a Visual Studio solution. For more information, see [Use UI Automation To Test Your Code](../codequality/use-ui-automation-to-test-your-code.md) and [Unit Test Your Code](../codequality/unit-test-your-code.md).  
  
 You can also create coded UI tests to automate manual tests that you created in [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. These automated manual tests can then be included in your Team Build configurations as part of your integration testing.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
## Tasks  
  
|Tasks|Associated Topics|  
|-----------|-----------------------|  
|**Creating an Automated UI Test from an Existing Manual Test:** Create an automated UI test from an existing action recording from a manual test case.|-   [Generating a Coded UI Test from an Existing Action Recording](../test/generating-a-coded-ui-test-from-an-existing-action-recording.md)<br />-   [- How to: Create an Action Recording](../test_notintoc/--how-to--create-an-action-recording.md)|  
|**Record User Actions to Create an Automated UI Test:** Record the user actions that you want to use to create an automated UI test and generate the code for a coded UI test from this recording. You can then add custom code to your coded UI test using the Code Editor, or by using the Coded UI Test Editor.|-   [How to: Generate a Coded UI Test by Recording the Application Under Development](../misc/how-to--generate-a-coded-ui-test-by-recording-the-application-under-development.md)<br />-   [Walkthrough: Creating, Editing and Maintaining a Coded UI Test](../codequality/walkthrough--creating--editing-and-maintaining-a-coded-ui-test.md)<br />-   [Making Coded UI Tests Wait For Specific Events During Playback](../codequality/making-coded-ui-tests-wait-for-specific-events-during-playback.md)<br />-   [How to: Record Mouse Hovers in Coded UI Tests](../misc/how-to--record-mouse-hovers-in-coded-ui-tests.md)<br />-   [How to: Select a Control Using the Keyboard  in Coded UI Tests](../misc/how-to--select-a-control-using-the-keyboard--in-coded-ui-tests.md)<br />-   [Using HTML5 Controls in Coded UI Tests](../codequality/using-html5-controls-in-coded-ui-tests.md)<br />-   [How to: Use UI Control Actions and Properties in Your Coded UI Tests](../misc/how-to--use-ui-control-actions-and-properties-in-your-coded-ui-tests.md)<br />-   [Editing Coded UI Tests Using the Coded UI Test Editor](../codequality/editing-coded-ui-tests-using-the-coded-ui-test-editor.md)|  
|**Add UI Controls and Validation to Your Automated UI Test:** Add UI controls to your coded UI test and verify the values and the properties of the controls using the Coded UI Test Builder.<br /><br /> If you are testing a large application, you might have to use multiple UI maps to help create your coded UI tests.|-   [How to: Add UI Controls and Validation Code Using the Coded UI Test Builder](../misc/how-to--add-ui-controls-and-validation-code-using-the-coded-ui-test-builder.md)<br />-   [Using HTML5 Controls in Coded UI Tests](../codequality/using-html5-controls-in-coded-ui-tests.md)<br />-   [Anatomy of a Coded UI Test](../codequality/anatomy-of-a-coded-ui-test.md)<br />-   [Testing a Large Application with Multiple UI Maps](../codequality/testing-a-large-application-with-multiple-ui-maps.md)|  
|**Add Parameters from a Data Source to Use with Your Coded UI Test:**  Make your coded UI test into a data-driven test by adding a data source for your test method and using the test context to run the test method for each set of data in your data source.|-   [Creating a Data-Driven Coded UI Test](../codequality/creating-a-data-driven-coded-ui-test.md)|  
|**Link Test Cases to User Requirements:** Link your automated UI tests to user requirements. You can then determine how many automated tests you have for your user requirements.|-   [How to: Add Product Backlog Items, User Story, or Requirements Work Items to Your Test Plan](../test_notintoc/how-to--add-product-backlog-items--user-story--or-requirements-work-items-to-your-test-plan.md)|  
|**Edit coded UI tests using the Coded UI Test Editor:** The Coded UI Test Editor lets you easily modify your coded UI tests. Using the Coded UI Test Editor, you can locate, view, and edit your test methods, UI actions and their associated controls in the UI control map.|-   [Editing Coded UI Tests Using the Coded UI Test Editor](../codequality/editing-coded-ui-tests-using-the-coded-ui-test-editor.md)|  
|**Running Automated UI Tests:** Run coded UI tests directly from Visual Studio, from [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], from [!INCLUDE[esprbuild](../codequality/includes/esprbuild_md.md)]. Coded UI tests have to interact with the desktop when you run them, unlike other automated tests.|-   [Running Automated Tests Using Microsoft Visual Studio](../test/running-automated-tests-using-microsoft-visual-studio.md)<br />-   [Run tests in your build process](../Topic/Run%20tests%20in%20your%20build%20process.md)<br />-   [Running automated tests from the command line](../test/running-automated-tests-from-the-command-line.md)<br />-   [How to: Set Up Your Test Agent to Run Tests that Interact with the Desktop](../test/how-to--set-up-your-test-agent-to-run-tests-that-interact-with-the-desktop.md)<br />-   [Can I include coded UI tests in load tests?](assetId:///7041cbcf-9ab1-4579-98ff-8f296aeaded4#CreateRunLoadTest_QA_IncludeCUIT)<br />-   [Analyzing Coded UI Tests Using Coded UI Test Logs](../codequality/analyzing-coded-ui-tests-using-coded-ui-test-logs.md)|  
|**Adding Support for Custom Controls:** The coded UI testing framework does not support every possible UI and might not support the UI you want to test. For example, you cannot immediately create a coded UI test of the UI for [!INCLUDE[ofprexcel](../codequality/includes/ofprexcel_md.md)]. However, you can create an extension to the coded UI testing framework that will support a custom control.|-   [Enable Coded UI Testing of Your Controls](../codequality/enable-coded-ui-testing-of-your-controls.md)<br />-   [Extending Coded UI Tests and Action Recordings to Support Microsoft Excel](../codequality/extending-coded-ui-tests-and-action-recordings-to-support-microsoft-excel.md)|  
|**Best Practices for Coded UI Tests:** Write coded UI tests that reduce the effect of a changing UI on the program under test.|-   [Best Practices for Coded UI Tests](../codequality/best-practices-for-coded-ui-tests.md)|  
  
## Related Scenarios  
 [Supported Configurations and Platforms for Coded UI Tests and Action Recordings](../codequality/supported-configurations-and-platforms-for-coded-ui-tests-and-action-recordings.md)  
  
 If you want to verify which configurations are supported for coded UI tests, you can find the current list of operating systems, browsers, and supported technologies.  
  
## External Resources  
  
### Guidance  
 [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 2: Unit Testing: Testing the Inside](http://go.microsoft.com/fwlink/?LinkID=255188)  
  
 [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 5: Automating System Tests](http://go.microsoft.com/fwlink/?LinkID=255196)  
  
### FAQ  
 [Coded UI Tests FAQ - 1](http://go.microsoft.com/fwlink/?LinkID=230576)  
  
 [Coded UI Tests FAQ -2](http://go.microsoft.com/fwlink/?LinkID=230578)  
  
### Forum  
 [Visual Studio UI Automation Testing (includes CodedUI)](http://go.microsoft.com/fwlink/?LinkID=224497)