---
title: "Configuring Scenario Start Delays"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, scenarios, start delays"
ms.assetid: 2f634fba-8dfa-4c7a-a8b9-be867b78d16a
caps.latest.revision: 20
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
# Configuring Scenario Start Delays
Specify a delay before a scenario starts in a load test by using the Load Test Editor and the Properties window.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 For example, you might want to use the **Delay Start Time** property if you need one scenario to start producing items that another scenario consumes. You can delay the consuming scenario to enable the producing scenario to populate some data.  
  
 Another example is that you might have one scenario that is only run at a certain time of the day. So, you want to delay the start of the scenario to simulate this.  
  
 **In this topic:**  
  
1.  [Specifying the Delay Start Time of a Scenario](../test/configuring-scenario-start-delays.md#ConfiguringScenarioStartDelayHowTo) **:** You can add or change the **Delay start time** property, which is the time that elapses between the beginning of the load test and when the scenario starts. For example, this can be useful in situations where a scenario has dependencies on another scenario's data.  
  
2.  [Enabling and Disabling Whether a Scenario Runs During the Warm-Up Period](../test/configuring-scenario-start-delays.md#ConfiguringScenarioStartDelayEnableDisableRun): You can configure whether the scenario should run or not run during the warm-up period that is specified in the **Delay Start Time** property.  
  
##  <a name="ConfiguringScenarioStartDelayHowTo"></a> Specifying the Delay Start Time of a Scenario  
 You can specify a delay before the start of a scenario in a load test by using the Load Test Editor to change the **Delay Start Time** property in the Properties window.  
  
> [!NOTE]
>  For a full list of the load test scenario properties and their descriptions, see [Load Test Scenario Properties](../test/load-test-scenario-properties.md).  
  
 An example of an instance when you might want to use the **Delay Start Time** property is when you need one scenario to start producing items that another scenario consumes. You can delay the consuming scenario to enable the producing scenario to populate some data.  
  
 Another example is that you might have one scenario that is run only at a certain time of day. Therefore, you want to delay the start of the scenario to simulate this.  
  
> [!NOTE]
>  For a full list of the run settings properties and their descriptions, see [Load Test Scenario Properties](../test/load-test-scenario-properties.md).  
  
#### To specify the delay start time for a scenario  
  
1.  Open a load test.  
  
     The Load Test Editor appears. The load test tree is displayed.  
  
2.  In the load test trees **Scenarios** folder, choose the scenario node for which you want to specify the delay start time.  
  
3.  On the **View** menu, select **Properties Window**.  
  
     The categories and properties of the scenario are displayed in the Properties window.  
  
4.  In the text box for the **Delay Start Time** property, type a time value that indicates the time to wait after the load test starts before starting the scenario when the load test is run.  
  
    > [!NOTE]
    >  If the value for the **Disable During Warmup** property for the scenario is set to **True**, then the **Delay Start Time** properties time value will be applied after the warm-up period. You can control which scenarios are included in warm-up by using the **Disable During Warmup** scenario property.  
  
5.  After you change the property, choose **Save** on the **File** menu. You can then run your load test by using the new **Delay Start Time** value.  
  
##  <a name="ConfiguringScenarioStartDelayEnableDisableRun"></a> Enabling and Disabling Whether a Scenario Runs During the Warm-Up Period  
 The **Disable During Warmup** property is set by using the Properties window. Editing load test scenario properties is set by the Load Test Editor.  
  
 The **Disable During Warmup** property is used to indicate whether the scenario should run or not run during the warm-up period that is specified in the **Delay Start Time** property. For more information, review the previous procedure [Specifying the Delay Start Time of a Scenario](../test/configuring-scenario-start-delays.md#ConfiguringScenarioStartDelayHowTo).  
  
> [!NOTE]
>  For a complete list of the run settings properties and their descriptions, see [Load Test Scenario Properties](../test/load-test-scenario-properties.md).  
  
#### To enable or disable the warm-up period for a scenario  
  
1.  Open a load test.  
  
     The **Load Test Editor** appears. The load test tree is displayed.  
  
2.  In the load test trees **Scenarios** folder, choose the scenario node that you want to specify the agents to use.  
  
3.  On the **View** menu, select **Properties Window**.  
  
     The scenario's categories and properties are displayed in the Properties window.  
  
     In the **Disable During Warmup** property, select either **True** or **False.**  
  
4.  After you have finished changing the property, choose **Save** on the **File** menu. You can then run your load test using the new **Disable During Warmup** value.  
  
## See Also  
 [Editing Load Test Scenarios](../test/editing-load-test-scenarios-using-the-load-test-editor.md)   
 [Step 2.0 - Creating and Changing a Scenario](../test_notintoc/creating-load-tests.md#CreatingLoadTestsUsingWizardStep2)   
 [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md)   
 [How to: Run a Load Test Using Test Controllers and Test Agents Specified in a Test Setting](../test_notintoc/how-to--run-a-load-test-using-test-controllers-and-test-agents-specified-in-a-test-setting.md)   
 [Load Test Scenario Properties](../test/load-test-scenario-properties.md)