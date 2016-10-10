---
title: "How to: Specify Test Agents to Use in Load Test Scenarios"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e86806dd-5897-4e4c-bfd4-8d687fb72a6e
caps.latest.revision: 34
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
# How to: Specify Test Agents to Use in Load Test Scenarios
After you create your load test by using the **New Load Test Wizard**, you can use the **Load Test Editor** to change the scenarios properties to meet your testing needs and goals. See [Step 2.0 - Creating and Changing a Scenario in the New Load Test Wizard](../Topic/Creating%20load%20tests.md#CreatingLoadTestsUsingWizardStep2).  
  
> [!NOTE]
>  For a full list of the load test scenario properties and their descriptions, see [Load Test Scenario Properties](../dv_TeamTestALM/Load-Test-Scenario-Properties.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 The agents are specified by using the Load Test Editor to change the **Agents to Use** property in the Properties window.  
  
 You can specify the agents that you want your scenario to use if you are using controllers and agents to run the load test remotely. For example, you might want to specify a specific set of agents so that you maintain consistency when you analyze performance trends. Also, agents may be geographically distributed, so that an affinity exists between which scripts they run and where the agent is located.  
  
> [!TIP]
>  Rather than physically putting an agent at the remote site, another option is to use network emulation to emulate the slow network. For more information, see [Specifying Virtual Network Types](../dv_TeamTestALM/Specifying-Virtual-Network-Types-in-a-Load-Test-Scenario.md) and [Specifying Virtual Network Types](../dv_TeamTestALM/Specifying-Virtual-Network-Types-in-a-Load-Test-Scenario.md).  
  
 For more information, see [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../dv_TeamTestALM/Distributing-Load-Test-Runs-Across-Multiple-Test-Machines-Using-Test-Controllers-and-Test-Agents.md).  
  
 Another reason is that some, but not all, agents might have software installed on them that is required for a particular scenario.  
  
 You can control agent selection for a given test run by using roles in test settings. For more information, see [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../dv_TeamTestALM/Setting-Up-Machines-and-Collecting-Diagnostic-Information-Using-Test-Settings.md) and [Walkthrough: Using a Test Controller and Test Agents in a Load Test](../dv_TeamTestALM/Walkthrough--Using-a-Test-Controller-and-Test-Agents-in-a-Load-Test.md).  
  
 If a test agent machine has more than 75 percent CPU utilization or has less than 10 percent of physical memory available, add more agents to your load test to make sure that the agent machine does not become the bottleneck in your load test.  
  
### To specify the agents to use for a scenario  
  
1.  Open a load test.  
  
     The Load Test Editor appears. The load test tree is displayed.  
  
2.  In the load test trees **Scenarios** folder, choose the scenario node for which you want to specify the agents to use.  
  
3.  On the **View** menu, select **Properties Window**.  
  
     The categories and properties of the scenario are displayed in the Properties window.  
  
4.  In the text box for the **Agents to Use** property, type the list of agents on which the scenario may run.  
  
     Agents must be separated by commas, for example "**Agent1, Agent2, Agent3**". Leaving the property blank specifies that the scenario should use all available agents.  
  
    > [!NOTE]
    >  The **Agents to Use** property is ignored for local runs. For remote runs, if none of the agents specified in **Agents to Use** exist, tests in the scenario will not run.  
  
5.  After you change the property, choose **Save** on the **File** menu. You can then run your load test by using the new **Agents to Use** value.  
  
## See Also  
 [Editing Load Test Scenarios](../dv_TeamTestALM/Editing-Load-Test-Scenarios-Using-the-Load-Test-Editor.md)   
 [Creating load tests](../Topic/Creating%20load%20tests.md)   
 [Step 2.0 - Creating and Changing a Scenario in the New Load Test Wizard](../Topic/Creating%20load%20tests.md#CreatingLoadTestsUsingWizardStep2)   
 [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../dv_TeamTestALM/Distributing-Load-Test-Runs-Across-Multiple-Test-Machines-Using-Test-Controllers-and-Test-Agents.md)   
 [How to: Run a Load Test Using Test Controllers and Test Agents Specified in a Test Setting](../Topic/How%20to:%20Run%20a%20Load%20Test%20Using%20Test%20Controllers%20and%20Test%20Agents%20Specified%20in%20a%20Test%20Setting.md)   
 [Load Test Scenario Properties](../dv_TeamTestALM/Load-Test-Scenario-Properties.md)