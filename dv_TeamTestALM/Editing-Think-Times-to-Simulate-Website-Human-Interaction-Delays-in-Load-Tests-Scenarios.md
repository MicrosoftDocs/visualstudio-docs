---
title: "Editing Think Times to Simulate Website Human Interaction Delays in Load Tests Scenarios"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8e03bee5-ab7b-4b40-9497-9dbe91ccb90e
caps.latest.revision: 26
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Editing Think Times to Simulate Website Human Interaction Delays in Load Tests Scenarios
Think times are used to simulate human behavior that causes people to wait between interactions with a Web site. Think times occur between requests in a Web performance test and between test iterations in a load test scenario. Using think times in a load test can be useful in creating more accurate load simulations. You can change whether think times are used or ignored in load tests. You change whether think times are used in your load tests in the Load Test Editor.  
  
 The *think profile* is a setting that applies to a scenario in a load test. The setting determines whether the think times that are saved in the individual Web performance tests are used during the load test. If you want to use think times in some Web performance tests but not in others, you must place them in different scenarios. For more information about scenarios, see [Editing Load Test Scenarios](../dv_TeamTestALM/Editing-Load-Test-Scenarios-Using-the-Load-Test-Editor.md).  
  
 Initially, you set whether you use think times in your load tests when you create the load test using the New Load Test Wizard. For more information, see [Editing Load Test Scenarios](../dv_TeamTestALM/Editing-Load-Test-Scenarios-Using-the-Load-Test-Editor.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 The Think Profile options are described in the following list:  
  
 **Off**  
 Think times are ignored. Use this setting when you want to generate maximum load to heavily stress your Web server. Do not use it when you are trying to create more realistic user interactions with a Web server.  
  
 **On**  
 Think times are used exactly as they were recorded in the Web performance test. Simulates multiple users running the Web performance tests exactly as recorded. Because a load test simulates multiple users, using the same think time could create an unnatural load pattern of synchronized virtual users.  
  
 **Normal Distribution**  
 Think times are used, but varied on a normal curve. Provides a more realistic simulation of virtual users by slightly varying the think time between requests.  
  
> [!NOTE]
>  For a complete list of the load test scenario properties and their descriptions, see [Load Test Scenario Properties](../dv_TeamTestALM/Load-Test-Scenario-Properties.md).  
  
##  <a name="EditingThinkTimesChanging"></a> Changing the Think Profile  
  
#### To change a think profile in a load test scenario  
  
1.  From the Web performance and load test project, open a load test.  
  
     For more information about how to create a Web performance and load test project, see [How to: Create and Configure Test Projects for Automated Tests](assetId:///8aabbd72-7d00-4823-93ac-24d02d67503b).  
  
     For more information about how to create a load test, see [Create and run a load test](assetId:///7041cbcf-9ab1-4579-98ff-8f296aeaded4).  
  
2.  In the **Load Test Editor**, choose the scenario node where you want to change the **Think Profile**. The **Think Profile** is displayed in the Properties window. Press F4 to display the Properties window.  
  
3.  Change the **Think Profile** property in the Properties window.  
  
4.  After you have finished changing the properties, choose **Save** on the **File** menu. You can then run your load test with the new think profile.  
  
## See Also  
 [Create and run a load test](assetId:///7041cbcf-9ab1-4579-98ff-8f296aeaded4)   
 [Editing Load Test Scenarios](../dv_TeamTestALM/Editing-Load-Test-Scenarios-Using-the-Load-Test-Editor.md)   
 [How to: Set Think Times to Simulate Human Pausing in a Web Performance Test](../Topic/How%20to:%20Set%20Think%20Times%20to%20Simulate%20Human%20Pausing%20in%20a%20Web%20Performance%20Test.md)   
 [Step 2.0 - Creating and Changing a Scenario](../Topic/Creating%20load%20tests.md#CreatingLoadTestsUsingWizardStep2)