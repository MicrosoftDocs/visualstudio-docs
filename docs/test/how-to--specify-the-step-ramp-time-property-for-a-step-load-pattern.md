---
title: "How to: Specify the Step Ramp Time Property for a Step Load Pattern"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, load patterns"
ms.assetid: 4a69e857-f93b-4907-9a01-fd1b66291205
caps.latest.revision: 15
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
# How to: Specify the Step Ramp Time Property for a Step Load Pattern
After you create your load test with the **New Load Test Wizard**, you can use the **Load Test Editor** to change the scenarios properties to meet your testing needs and goals. [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)][Creating load tests](../test_notintoc/creating-load-tests.md).  
  
> [!NOTE]
>  For a full list of the load test scenario properties and their descriptions, see [Load Test Scenario Properties](../test/load-test-scenario-properties.md).  
  
 The **Step Ramp Time** property is set in the Properties window. You edit load test scenario properties in the Load Test Editor.  
  
 The **Step Ramp Time** property is only used with a step load pattern. For more information, see [Editing Load Patterns to Model Virtual User Activities](../test/editing-load-patterns-to-model-virtual-user-activities.md).  
  
 A step load pattern is used to increase the load on the server or servers as the load test runs so that you can see how performance varies as the user load increases. For example, to see how your server or servers perform as the user load increasing to 2,000 users, you might run a 10-hour load test using a step load pattern with the following properties:  
  
-   Initial User Count: 100  
  
-   Maximum User Count: 2000  
  
-   Step Duration (seconds): 1800  
  
-   Step Ramp Time (seconds): 20  
  
-   Step User Count: 100  
  
 These settings have the load test running for 30 minutes (1800 seconds) at user loads of 100, 200, 300, up to 2,000 users.  
  
> [!NOTE]
>  The **Step Ramp Time** property is the only one of these properties that is not available to choose in the New Load Test Wizard. For more information, see [Step 2.1 - Choosing a Load Pattern in the New Load Test Wizard](../test_notintoc/creating-load-tests.md#CreatingLoadTestsUsingWizardStep2_1).  
  
 The **Step Ramp Time** property allows the increase from one step to the next (for example from 100 to 200 users) to be gradual rather than immediate. In the example, the user load would be increased from 100 to 200 users over a 20 second period (an increase of 5 users every second).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
### To edit the Step Ramp Time property for a step load pattern  
  
1.  Open a load test.  
  
     The **Load Test Editor** appears. The load test tree is displayed.  
  
2.  In the load test trees **Scenarios** folder, open the scenario node you want to specify the step ramp time for.  
  
3.  Select the **Step Load Pattern** node.  
  
    > [!NOTE]
    >  The load pattern for the scenario must be a step load pattern. If it is not, the load pattern will display the load pattern type that is currently associated with the scenario. For more information, see [Editing Load Patterns to Model Virtual User Activities](../test/editing-load-patterns-to-model-virtual-user-activities.md).  
  
4.  On the **View** menu, select **Properties Window**.  
  
     The scenario's categories and properties are displayed in the Properties window.  
  
5.  Set the value for the **Step Ramp Time** property by entering a number for the seconds taken in each step to gradually add the users specified by the **Step User Count** property.  
  
6.  After you have finished changing the property, choose **Save** on the **File** menu. You can then run your load test using the new **Step Ramp Time** value.  
  
## See Also  
 [Editing Load Test Scenarios](../test/editing-load-test-scenarios-using-the-load-test-editor.md)   
 [Step 2.0 - Creating and Changing a Scenario in the New Load Test Wizard](../test_notintoc/creating-load-tests.md#CreatingLoadTestsUsingWizardStep2)   
 [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md)   
 [How to: Run a Load Test Using Test Controllers and Test Agents Specified in a Test Setting](../test_notintoc/how-to--run-a-load-test-using-test-controllers-and-test-agents-specified-in-a-test-setting.md)   
 [Load Test Scenario Properties](../test/load-test-scenario-properties.md)   
 [Editing Load Patterns to Model Virtual User Activities](../test/editing-load-patterns-to-model-virtual-user-activities.md)