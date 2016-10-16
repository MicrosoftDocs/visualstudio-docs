---
title: "Walkthrough: Creating and Running a Load Test Containing Unit Tests"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "unit tests, in load tests"
  - "unit tests, load test walkthrough"
  - "load tests, walkthrough"
ms.assetid: bbf075a5-96d5-48ed-a03c-330f0fc04748
caps.latest.revision: 30
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
# Walkthrough: Creating and Running a Load Test Containing Unit Tests
In this walkthrough you create a load test that contains unit tests.  
  
 This walkthrough steps you through creating and then running a load test using Visual Studio Enterprise. A load test is a container of Web performance tests and unit tests. You create load tests with the New Load Test Wizard. To find out more about load tests, see [Creating and Editing Load Tests](assetId:///e2985d15-60a7-4177-93b4-f986c2936337).  
  
 A load test also exposes many run-time properties that can be modified to generate the desired load simulation. In this walkthrough, you use the New Load Test Wizard to add unit tests to a load test. For more information about Web performance tests, see [Creating and Editing Web Performance Tests](assetId:///8bf5f2a7-c693-47d6-9282-5946480151dc).  
  
 In this walkthrough, you will complete the following tasks:  
  
-   Create a load test that uses unit tests.  
  
-   Change some of the load test settings.  
  
-   Run a load test.  
  
## Prerequisites  
  
-   Visual Studio Enterprise  
  
-   Perform the steps in [Walkthrough: Creating and Running Unit Tests for Managed Code](../codequality/walkthrough--creating-and-running-unit-tests-for-managed-code.md) to create a simple C# class library that contains a Web performance and load test project with some unit tests in it.  
  
## Create a Load Test Containing Unit Tests Using the New Load Test Wizard  
  
#### To start the New Load Test Wizard  
  
1.  Open the Bank solution that you created in [Walkthrough: Creating and Running Unit Tests for Managed Code](../codequality/walkthrough--creating-and-running-unit-tests-for-managed-code.md).  
  
2.  In **Solution Explorer**, open the shortcut menu for the Bank solution node, choose **Add**, and then choose **New Project**.  
  
     The Add New Project dialog box displays.  
  
3.  In the Add New Project dialog box, expand **Visual C#** and choose **Test**. From the list of templates, choose **Web Performance and Load Test Project** and in the **Name** field, type `BankLoadTest`. Choose **OK**.  
  
     The BankLoadTest web performance and load test project is added to the solution.  
  
4.  Open the shortcut menu for the new BankLoadTest web performance and load test project, choose **Add**, and then choose **Load Test**.  
  
5.  The **New Load Test Wizard** starts.  
  
6.  The **Welcome** page of the **New Load Test Wizard** is the first page.  
  
7.  Choose **Next**.  
  
#### To edit settings for load test scenario  
  
1.  In the **Enter a name for the load test scenario** text box, type **ScenarioSample**.  
  
     A *scenario* is a grouping mechanism. It consists of a set of tests and the properties for running those tests under load.  
  
2.  Set the **Time Profile Think** to `Use normal distribution centered on recorded think times`. Think times represent the time that a user would ponder a Web page before going on to the next page. [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)] [How to: Set Think Times to Simulate Human Pausing in a Web Performance Test](../test_notintoc/how-to--set-think-times-to-simulate-human-pausing-in-a-web-performance-test.md).  
  
3.  Choose **Next** when you are finished.  
  
#### To edit load pattern setting for test scenario  
  
1.  Choose **Step load**.  
  
    > [!NOTE]
    >  You can choose from two types of load patterns: constant and step. Each type has its function in load testing, but for the purposes of this walkthrough choose **Step load**.  
  
2.  Set **Start user count** to 10 users.  
  
3.  Set **Step duration** to 10 seconds.  
  
4.  Set **Step user count** to 10 users/step.  
  
5.  Set **Maximum user count** to 100 users.  
  
6.  Choose **Next**.  
  
#### To select test mix model for the scenario  
  
1.  Under How should the test mix be modeled, select **Based on the total number of test**.  
  
2.  Choose **Next**.  
  
#### To add unit tests to the scenario  
  
1.  The next step is to **Add tests to a load test scenario and edit test mix**.  
  
2.  Choose **Add** to select tests.  
  
3.  Choose the CreditTest unit tests listed in the **Available Tests** pane, which lists all the Web performance tests and unit tests in the Web performance and load test project.  
  
4.  Choose the arrow to add the CreditTest unit test to the **Selected Tests** pane.  
  
5.  Repeat steps 3 and 4 for the DebitTest and FreezeAccountTest unit tests.  
  
6.  When you have finished adding the three unit tests, choose **OK**.  
  
     You are presented with the test mix.  
  
7.  Move the slider under Distribution for the CreditTest slightly to the right to adjust the test distribution. Notice that the other sliders move to the left automatically so that the distribution remains at 100%.  
  
8.  Choose **Next**.  
  
#### To select network mix for test scenario  
  
1.  Select the LAN connection type to add to the network bandwidth mix.  
  
     You can add more network types. Use the sliders to adjust the test distribution and weighting.  
  
2.  Choose **Next**.  
  
#### To specify computers to monitor with counter sets during load test run  
  
1.  Choose **Next**.  
  
     [!INCLUDE[crabout](../codequality/includes/crabout_md.md)] the counter sets, see [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../test/specifying-the-counter-sets-and-threshold-rules-for-computers-in-a-load-test.md) and [Create and run a load test](assetId:///7041cbcf-9ab1-4579-98ff-8f296aeaded4).  
  
#### To edit run setting for load test  
  
1.  Select **Load test duration** and then set **Run Duration** to 2 minutes in order to *smoke test* your load test.  
  
     When you build your load tests, it is a good practice to validate that everything is configured correctly and running as expected by running a short, light load test. This process is known as *smoke testing*.  
  
2.  Choose **Finish**. Your Load test is opened in the **Load Test Editor**.  
  
## Running the Load Test  
 After you have created the Load test, run it to view how your bank application responds to the load simulation. While a load test is running, you see the **Load Test Analyzer** window.  
  
#### To run the load test  
  
1.  With a Load test open in the **Load Test Editor**, choose the green **Run Test** button in the toolbar. Your load test starts to run.  
  
2.  If your test simulation exceeds any thresholds, icons appear in the tree control nodes to indicate a threshold violation. Errors have a red circle overlay, warnings have a yellow triangle overlay. You can find a counter that exceeded the threshold and graph it by dragging the icon onto the graph. You can do this while the test is running.  
  
## See Also  
 [Getting Started with Load and Web Performance Test Walkthroughs](assetId:///5d754a49-565c-4f1b-9e5f-ac40ae3fff27)   
 [Unit Test Your Code](../codequality/unit-test-your-code.md)   
 [Editing the Test Mix to Specify Which Tests to Include in a Load Test Scenario](../test/303e1d70-5d98-424a-b51e-e0898e16d3f8.md)   
 [Creating load tests](../test_notintoc/creating-load-tests.md)   
 [Step 4 - Specifying Run Settings in the New Load Test Wizard](../test_notintoc/creating-load-tests.md#CreatingLoadTestsUsingWizardStep4)   
 [Specifying Virtual Network Types](../test/specifying-virtual-network-types-in-a-load-test-scenario.md)   
 [Editing Load Test Scenarios](../test/editing-load-test-scenarios-using-the-load-test-editor.md)   
 [Editing Load Patterns to Model Virtual User Activities](../test/editing-load-patterns-to-model-virtual-user-activities.md)   
 [Editing Text Mix Models to Specify the Probability of a Virtual User Running a Test](../test/editing-text-mix-models-to-specify-the-probability-of-a-virtual-user-running-a-test.md)   
 [Walkthrough: Using a Test Controller and Test Agents in a Load Test](../test/walkthrough--using-a-test-controller-and-test-agents-in-a-load-test.md)