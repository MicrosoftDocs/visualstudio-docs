---
title: "How to: Apply Distribution to Pacing Delay When Using a User Pace Test Mix Model"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, test mix model"
ms.assetid: ae8b35f9-d465-4d72-8d7d-7b56ae6ffd22
caps.latest.revision: 23
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
# How to: Apply Distribution to Pacing Delay When Using a User Pace Test Mix Model
After you create your load test by using the New Load Test Wizard, you can use the Load Test Editor to change the scenarios properties to meet your testing needs and goals. See [Step 2.2 - Choosing a Test Mix Model in the New Load Test Wizard](../test_notintoc/creating-load-tests.md#CreatingLoadTestsUsingWizardStep2_2).  
  
> [!NOTE]
>  For a complete list of the load test scenario properties and their descriptions, see [Load Test Scenario Properties](../test/load-test-scenario-properties.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 The **Apply Distribution to Pacing Delay** property is set by using the Properties window. Load test scenario properties are modified by using the Load Test Editor.  
  
> [!NOTE]
>  The **Apply Distribution to Pacing Delay** property applies only if the *load test mix* is configured based on the user pace. For more information, see [Editing Text Mix Models to Specify the Probability of a Virtual User Running a Test](../test/editing-text-mix-models-to-specify-the-probability-of-a-virtual-user-running-a-test.md).  
  
 The value for the **Apply Distribution to Pacing Delay** can be set to either true or false:  
  
-   **True**: The scenario will apply normal statistical distribution delays that are specified by the value in the **Tests Per User Per Hour** column in the Edit Test Mix dialog box. For more information, see [Editing Text Mix Models to Specify the Probability of a Virtual User Running a Test](../test/editing-text-mix-models-to-specify-the-probability-of-a-virtual-user-running-a-test.md).  
  
     For example, assume that you have **Tests Per User Per Hour** value in the Edit Test Mix dialog box for the test set to two users per hour. If **Apply Distribution to Pacing Delay** property is set to **True**, a normal statistical distribution is applied to the wait time between the tests. The tests will still run two tests per hour, but it will not necessarily be 30 minute delay between them. The first test could run after four minutes and the second test after 45 minutes.  
  
-   **False**: The tests will run at the pace that you specified for the value in the **Tests Per User Per Hour** column in the Edit Test Mix dialog box. For more information, see [Editing Text Mix Models to Specify the Probability of a Virtual User Running a Test](../test/editing-text-mix-models-to-specify-the-probability-of-a-virtual-user-running-a-test.md).  
  
     For example, assume that you have **Tests Per User Per Hour** value in the Edit Test Mix dialog box for the test set to two users per hour. If the **Apply Distribution to Pacing Delay** property is set to **False**, you are giving no leeway when your tests run. The test will run every 30 minutes. This makes sure that you execute two tests per hour.  
  
### To specify the Apply Distribution to Pacing Delay property setting for a scenario  
  
1.  Open a load test.  
  
     The **Load Test Editor** appears. The load test tree is displayed.  
  
2.  In the **Scenarios** folder of the load test tree, choose the scenario node for which you want to specify the agents to use.  
  
3.  On the **View** menu, select **Properties Window**.  
  
     The categories and properties of the scenario are displayed in the **Properties** window.  
  
4.  In the property value for the **Apply Distribution to Pacing Delay**, select either **True** or **False**.  
  
5.  After you change the property, choose **Save** on the **File** menu. You can then run your load test by using the new **Apply Distribution to Pacing Delay** value.  
  
## See Also  
 [Editing Load Test Scenarios](../test/editing-load-test-scenarios-using-the-load-test-editor.md)   
 [Creating load tests](../test_notintoc/creating-load-tests.md)   
 [Step 2.0 - Creating and Changing a Scenario in the New Load Test Wizard](../test_notintoc/creating-load-tests.md#CreatingLoadTestsUsingWizardStep2)   
 [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md)   
 [How to: Run a Load Test Using Test Controllers and Test Agents Specified in a Test Setting](../test_notintoc/how-to--run-a-load-test-using-test-controllers-and-test-agents-specified-in-a-test-setting.md)   
 [Load Test Scenario Properties](../test/load-test-scenario-properties.md)