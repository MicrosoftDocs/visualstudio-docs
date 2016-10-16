---
title: "Load Test Scenario Properties"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, properties"
  - "load tests, scenarios"
ms.assetid: 4414a638-1fa2-40ad-b1f4-b99f90b62e62
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
# Load Test Scenario Properties
Change your load test scenario property settings in Visual Studio Enterprise to meet your load testing requirements.  
  
 For example, here's how you can specify the maximum test iterations for a Load Test Scenario.  
  
 ![Specifying test iterations in a scenario](../test/media/loadtest_prop.png "LoadTest_Prop")  
  
 See [Editing Load Test Scenarios](../test/editing-load-test-scenarios-using-the-load-test-editor.md) and [Load Test Analyzer Overview](../test/load-test-analyzer-overview.md).  
  
## General  
 Here are the load test scenario settings properties that you can change.  
  
|Property|Definition|  
|--------------|----------------|  
|**Name**|The name for the scenario.<br /><br /> For more information, see [Creating load tests](../test_notintoc/creating-load-tests.md) and [Create and run a load test](assetId:///7041cbcf-9ab1-4579-98ff-8f296aeaded4).|  
  
## Mix  
  
|Property|Definition|  
|--------------|----------------|  
|**Browser Mix**|Specifies the Web browser mix for the load test. You can specify different Web browser types and their load distribution.<br /><br /> Choose the ellipsis (…) button to open the Edit Browser Mix dialog and use **Add** and **Remove** to select the Web browser types in the load test.<br /><br /> For more information, see [Specifying Web Browsers Types](../test/editing-the-test-mix-to-specify-which-web-browsers-types-in-a-load-test-scenario.md).|  
|**Network Mix**|Specifies the network mix for the load test. You can specify which network types to include and their load distribution.<br /><br /> Choose the ellipsis (…) button to open the **Edit Network Mix** dialog box and use **Add** and **Remove** to select the network types in the load test.<br /><br /> For more information, see [Specifying Virtual Network Types](../test/specifying-virtual-network-types-in-a-load-test-scenario.md).|  
|**Test Mix**|Specifies the Web performance and unit test mix for the load test. You can specify which tests to include and their load distribution.<br /><br /> Choose the ellipsis (…) button to open the **Edit Test Mix** dialog box and use **Add** and **Remove** to select the tests in the load test.<br /><br /> For more information, [Editing the Test Mix to Specify Which Tests to Include in a Load Test Scenario](../test/303e1d70-5d98-424a-b51e-e0898e16d3f8.md).|  
|**Test Mix Type**|Specifies the test mix model that is used for the load test.<br /><br /> Choose the ellipsis (…) button to open the **Edit Test Mix** dialog box and use the drop-down under **Test mix model** to select the test mix model to use in the load test.<br /><br /> For more information, see [Editing Text Mix Models to Specify the Probability of a Virtual User Running a Test](../test/editing-text-mix-models-to-specify-the-probability-of-a-virtual-user-running-a-test.md).|  
  
## Options  
  
|Property|Definition|  
|--------------|----------------|  
|**Agents to Use**|Specifies the agents that you want your scenario to use if you are using controllers and agents to run the load test remotely. For example, you might want to specify a specific set of agents so that you maintain consistency when you analyze performance trends. Also, agents may be geographically distributed so that there is an affinity between which scripts they run and where the agent is located.<br /><br /> Agents must be separated by commas, for example "**Agent1, Agent2, Agent3**". Leaving the property blank specifies that the scenario should use all available agents.<br /><br /> For more information, see [How to: Specify Test Agents to Use](../test/how-to--specify-test-agents-to-use-in-load-test-scenarios.md).|  
|**Apply Distribution to Pacing Delay**|Boolean value that is used to specify if you want to apply typical distribution delays in the user pacing test mix model. This property only applies if the **Test Mix Type** property is set to **Based on user pace**.<br /><br /> For more information, see [How to: Apply Distribution to Pacing Delay When Using a User Pace Test Mix Model](../test/how-to--apply-distribution-to-pacing-delay-when-using-a-user-pace-test-mix-model.md)|  
|**IP Switching**|Boolean value uses to specify if IP switching is used.<br /><br /> IP switching enables a test agent to send requests to a server by using a range of different IP addresses. This simulates calls that come from different client computers. IP switching is important when you test against a load balanced Web farm. Most load balancers establish affinity between a client and a particular Web server by using the IP address of the client. If all requests seem like they are coming from a single client, the load balancer will not balance the load. To obtain good load balance in the Web farm, it is important that requests come from a range of IP addresses.<br /><br /> IP switching is available only with the test agent.|  
|**Maximum Test Iterations**|Numeric value that is used to specify the maximum number of tests to run in the scenario. A value of 0 specifies no maximum.<br /><br /> For more information, see [Configuring Test Iterations for Scenarios](../test/configuring-test-iterations-in-a-load-test-scenario.md).|  
|**Percentage of New Users**|Numeric value that specifies the percentage of new users or first time visitors in the scenario.<br /><br /> For more information, see [How to: Specify the Percentage of Virtual Users that Use Web Cache Data](../test/how-to--specify-the-percentage-of-virtual-users-that-use-web-cache-data.md).|  
|**Think Profile**|Specifies if the scenario will use **Normal Distribution**, or if the think profile is **On** or **Off**.<br /><br /> For more information, see [Editing Think Times to Simulate Website Human Interaction Delays](../test/editing-think-times-to-simulate-website-human-interaction-delays-in-load-tests-scenarios.md).|  
|**Think Times Between Test Iterations**|Numeric value that is used to specify the wait time in seconds between test iterations.<br /><br /> For more information, see [Editing Think Times to Simulate Website Human Interaction Delays](../test/editing-think-times-to-simulate-website-human-interaction-delays-in-load-tests-scenarios.md).|  
  
## Timing  
  
|Property|Definition|  
|--------------|----------------|  
|**Delay Start Time**|A time value that indicates how many hours, minutes and seconds to delay starting the scenario after the load test starts. If **Disable During Warmup** property is set to **True**, the amount of time to wait applies after the completion of the warm-up period.<br /><br /> For more information, see [Configuring Scenario Start Delays](../test/configuring-scenario-start-delays.md).|  
|**Disable During Warmup**|Boolean value that is used to specify if the scenario should run or not during the **Warm Up Duration** property time value specified in the load test's run setting.<br /><br /> For more information about the load test run setting properties, see [Load Test Run Settings Properties](../test/load-test-run-settings-properties.md).<br /><br /> For more information, see [Configuring Scenario Start Delays](../test/configuring-scenario-start-delays.md).|  
  
## See Also  
 [Editing Load Test Scenarios](../test/editing-load-test-scenarios-using-the-load-test-editor.md)   
 [Creating and Editing Load Tests](assetId:///e2985d15-60a7-4177-93b4-f986c2936337)   
 [Running Load Tests](../test_notintoc/running-load-tests.md)