---
title: "Configuring Test Iterations in a Load Test Scenario"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, scenarios, iterations"
  - "load test, iterations"
  - "load tests, sceanrios"
ms.assetid: ac480fb7-f4f7-47dc-9ae5-98be3aca4fba
caps.latest.revision: 22
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
# Configuring Test Iterations in a Load Test Scenario
To configure test iteration settings, edit a load test scenario using the Load Test Editor and the Properties window. By default, a load test scenario is set up without specifying maximum test iterations. You have the option to configure the maximum number of iterations in the scenario and how long to pause between them.  
  
 **In this topic:**  
  
-   [Specifying the MaximumTest Iterations for a Scenario](../test/configuring-test-iterations-in-a-load-test-scenario.md#ConfiguringTestIterationsHowToMaxIterationSetting) **:** You can specify the maximum number of times that you want your Web performance and unit tests to run in a scenario.  
  
-   [Specifying Think Times Between Test Iterations for a Scenario](../test/configuring-test-iterations-in-a-load-test-scenario.md#ConfiguringTestIterationsHowToMaxIterationThinkTime) **:** You can specify how many seconds to simulate human pausing by adjusting the think times between test iterations in a load test scenario.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
##  <a name="ConfiguringTestIterationsHowToMaxIterationSetting"></a> Specifying the MaximumTest Iterations for a Scenario  
 You can specify the maximum number of times that you want your tests to run for a scenario by using the Load Test Editor to change the **Maximum Test Iterations** property in the Properties window.  
  
 The **Maximum Test Iterations** property controls the maximum number of test iterations to run for the scenario. Just as for the **Test Iterations** property in the load test run settings, this is the maximum across all users on all agents, not a per user setting.  
  
> [!NOTE]
>  For a full list of the load test scenario properties and their descriptions, see [Load Test Scenario Properties](../test/load-test-scenario-properties.md).  
  
 For sequential test mix, one iteration is one pass through all the tests in the mix. For all other test mixes, each test execution counts as an iteration. For more information, see [About the Mix Control](../test/303e1d70-5d98-424a-b51e-e0898e16d3f8.md#EditingTestMixAboutMixControl).  
  
 If the load test is a duration-based load test, and the duration expires before the iteration count is complete, the test will still stop. If the test is iteration-based, and the test iterations are met before scenario iterations, the test will stop. The duration is configured by using the **Run Duration** property in the Properties window associated with a run setting in a load test.  
  
 When the scenario iteration count is met, the scenario will stop running, but any other active scenarios will continue to run.  
  
> [!NOTE]
>  A related property is the **Unique** property on a Web test data source, which moves sequentially through the data, row-by-row, but only one time for each record. For more information, see [Binding a Data Source to a Web Performance Test](../test_notintoc/binding-a-data-source-to-a-web-performance-test.md).  
  
 The **Maximum Test Iterations** property is useful for a variety of situations. Some load testers prefer to conduct iteration-based testing, whereas other load testers prefer to conduct duration-based testing.  
  
 ![Specifying test iterations in a scenario](../test/media/loadtest_prop.png "LoadTest_Prop")  
  
#### To specify the maximum test iterations  
  
1.  Open a load test.  
  
2.  The Load Test Editor appears. The load test tree is displayed.  
  
3.  In the load test trees **Scenarios** folder, choose the scenario node for which you want to specify the maximum number of test iterations.  
  
4.  On the **View** menu, select **Properties Window**.  
  
     The categories and properties of the scenario are displayed in the Properties window.  
  
5.  In the text box for the **Maximum Test Iterations** property, type a value that indicates the maximum number of tests to run for the scenario when the load test is run.  
  
    > [!NOTE]
    >  Using a value of 0 for the **Maximum Test Iterations** property specifies no maximum iterations.  
  
6.  After you have finished changing the property, choose **Save** on the **File** menu. You can then run your load test by using the new **Maximum Test Iterations** value.  
  
##  <a name="ConfiguringTestIterationsHowToMaxIterationThinkTime"></a> Specifying Think Times Between Test Iterations for a Scenario  
 The **Think Time Between Test Iterations** property is set using the Properties window while editing load test scenario properties in the Load Test Editor.  
  
 The **Think Time Between Test Iterations** property is used to specify the amount of seconds to wait before starting a test iteration.  
  
> [!NOTE]
>  For a complete list of the load test scenario properties and their descriptions, see [Load Test Scenario Properties](../test/load-test-scenario-properties.md).  
  
#### To specify the think times between test iterations  
  
1.  Open a load test.  
  
     The **Load Test Editor** appears. The load test tree is displayed.  
  
2.  In the load test trees **Scenarios** folder, choose the scenario node you want to specify the agents to use.  
  
3.  On the **View** menu, select **Properties Window**.  
  
     The scenario's categories and properties are displayed in the Properties window.  
  
4.  In the value for **Think Time Between Test Iterations** property, enter a number representing the number of seconds to wait before starting the next test iteration.  
  
5.  After you have finished changing the property, choose **Save** on the **File** menu. You can then run your load test using the new **Think Time Between Test Iterations** value.  
  
## See Also  
 [Editing Load Test Scenarios](../test/editing-load-test-scenarios-using-the-load-test-editor.md)   
 [Step 2.0 - Creating and Changing a Scenario](../test_notintoc/creating-load-tests.md#CreatingLoadTestsUsingWizardStep2)   
 [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md)   
 [How to: Run a Load Test Using Test Controllers and Test Agents Specified in a Test Setting](../test_notintoc/how-to--run-a-load-test-using-test-controllers-and-test-agents-specified-in-a-test-setting.md)   
 [Load Test Scenario Properties](../test/load-test-scenario-properties.md)   
 [Editing Think Times to Simulate Website Human Interaction Delays](../test/editing-think-times-to-simulate-website-human-interaction-delays-in-load-tests-scenarios.md)