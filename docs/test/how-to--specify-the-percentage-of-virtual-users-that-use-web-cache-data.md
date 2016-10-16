---
title: "How to: Specify the Percentage of Virtual Users that Use Web Cache Data"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, virtual users"
ms.assetid: f66d5d43-4121-4487-b27f-d0a0baaf7601
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
# How to: Specify the Percentage of Virtual Users that Use Web Cache Data
After you create your load test with the **New Load Test Wizard**, you can change the scenarios properties to meet your testing needs and goals by using the **Load Test Editor**. See [Step 2.1 - Choosing a Load Pattern in the New Load Test Wizard](../test_notintoc/creating-load-tests.md#CreatingLoadTestsUsingWizardStep2_1). For a full list of the load test scenario properties and their descriptions, see [Load Test Scenario Properties](../test/load-test-scenario-properties.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 The **Percentage of new Users** property is set in the Properties window. You edit load test scenario properties in the Load Test Editor.  
  
 The **Percentage of new Users** property affects the way in which the load test simulates the caching that would be performed by a Web browser. By default, the **Percentage of new Users** property is set to 0%. If the value for the **Percentage of new Users** property is set to 100%, each Web performance test run in a load test is treated like a first time user to the Web site who does not have any content from the Web site in their browser cache from previous visits. Thus, all requests in the Web test, including all dependent requests such as images, are downloaded.  
  
> [!NOTE]
>  When the same cacheable resource is requested more than once in a web test, the requests are not downloaded.  
  
 If you are load testing a Web site that has a significant number of return users who are likely to have images and other cacheable content cached locally, then a setting of 100% for **Percentage of new Users** property will generate more download requests than would occur in real-world usage. In this case, you should estimate the percentage of visits to your Web site that are from first time users of the web site, and set **Percentage of new Users** property accordingly.  
  
### To specify the agents to use for a scenario  
  
1.  Open a load test.  
  
     The **Load Test Editor** appears. The load test tree is displayed.  
  
2.  In the load test trees **Scenarios** folder, choose the scenario node you want to specify the agents to use for.  
  
3.  On the **View** menu, select **Properties Window**.  
  
     The scenario's categories and properties are displayed in the Properties window.  
  
4.  Set the value for the **Percentage of new Users** property by entering a number for the percentage of new users.  
  
5.  After you have finished changing the property, choose **Save** on the **File** menu. You can then run your load test using the new **Percentage of new Users** value.  
  
## See Also  
 [Editing Load Test Scenarios](../test/editing-load-test-scenarios-using-the-load-test-editor.md)   
 [Creating load tests](../test_notintoc/creating-load-tests.md)   
 [Creating Additional Scenarios for an Existing Load Test](../test_notintoc/creating-additional-scenarios-for-an-existing-load-test.md)   
 [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md)   
 [How to: Run a Load Test Using Test Controllers and Test Agents Specified in a Test Setting](../test_notintoc/how-to--run-a-load-test-using-test-controllers-and-test-agents-specified-in-a-test-setting.md)   
 [Load Test Scenario Properties](../test/load-test-scenario-properties.md)   
 [Editing Load Patterns to Model Virtual User Activities](../test/editing-load-patterns-to-model-virtual-user-activities.md)