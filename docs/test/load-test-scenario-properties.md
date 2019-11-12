---
title: Load Test Scenario Properties
ms.date: 10/19/2016
ms.topic: reference
helpviewer_keywords:
  - "load tests, properties"
  - "load tests, scenarios"
ms.assetid: 4414a638-1fa2-40ad-b1f4-b99f90b62e62
author: jillre
ms.author: jillfra
manager: jillfra
---
# Load test scenario properties

Change your load test scenario property settings in Visual Studio to meet your load testing requirements. This article lists the various load test scenario properties by category.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## General

|Property|Definition|
|-|----------------|
|**Name**|The name for the scenario.|

## Mix

|Property|Definition|
|-|----------------|
|**Browser Mix**|Specifies the web browser mix for the load test. You can specify different web browser types and their load distribution.<br /><br />Choose the ellipsis **(…)** button to open the **Edit Browser Mix** dialog and use **Add** and **Remove** to select the web browser types in the load test.<br /><br />For more information, see [Specify web browsers types](../test/edit-the-test-mix-to-specify-which-web-browsers-types-in-a-load-test-scenario.md).|
|**Network Mix**|Specifies the network mix for the load test. You can specify which network types to include and their load distribution.<br /><br />Choose the ellipsis **(…)** button to open the **Edit Network Mix** dialog box and use **Add** and **Remove** to select the network types in the load test.<br /><br />For more information, see [Specify virtual network types](../test/specify-virtual-network-types-in-a-load-test-scenario.md).|
|**Test Mix**|Specifies the web performance and unit test mix for the load test. You can specify which tests to include and their load distribution.<br /><br />Choose the ellipsis **(…)** button to open the **Edit Test Mix** dialog box and use **Add** and **Remove** to select the tests in the load test.<br /><br />For more information, [Edit the test mix for a load test scenario](../test/edit-the-test-mix-to-specify-which-web-browsers-types-in-a-load-test-scenario.md).|
|**Test Mix Type**|Specifies the test mix model for the load test.<br /><br />Choose the ellipsis **(…)** button to open the **Edit Test Mix** dialog box and use the drop-down under **Test mix model** to select the test mix model to use in the load test.<br /><br />For more information, see [Edit text mix models](../test/edit-test-mix-models-to-specify-the-probability-of-a-virtual-user-running-a-test.md).|

## Options

|Property|Definition|
|-|----------------|
|**Agents to Use**|Specifies the agents that you want your scenario to use if you are running the load test remotely. For example, you might want to specify a specific set of agents so that you maintain consistency when you analyze performance trends. Also, agents may be geographically distributed so that there is an affinity between which scripts they run and where the agent is located.<br /><br />Agents must be separated by commas, for example "**Agent1, Agent2, Agent3**". Leaving the property blank specifies that the scenario should use all available agents.<br /><br />For more information, see [How to: Specify test agents to use](../test/how-to-specify-test-agents-to-use-in-load-test-scenarios.md).|
|**Apply Distribution to Pacing Delay**|Boolean value that's used to specify if you want to apply typical distribution delays in the user pacing test mix model. This property only applies if the **Test Mix Type** property is set to **Based on user pace**.<br /><br />For more information, see [How to: Apply distribution to pacing delay](../test/how-to-apply-distribution-to-pacing-delay-when-using-a-user-pace-test-mix-model.md)|
|**IP Switching**|Boolean value that's used to specify if IP switching is used.<br /><br />IP switching enables a test agent to send requests to a server by using a range of different IP addresses. This simulates calls that come from different client computers. IP switching is important when you test against a load balanced web farm. Most load balancers establish affinity between a client and a particular web server by using the IP address of the client. If all requests seem like they are coming from a single client, the load balancer will not balance the load. To obtain good load balance in the web farm, it is important that requests come from a range of IP addresses.<br /><br />IP switching is available only with the test agent.|
|**Maximum Test Iterations**|Numeric value that is used to specify the maximum number of tests to run in the scenario. A value of 0 specifies no maximum.<br /><br />For more information, see [Configure test iterations for scenarios](../test/configure-test-iterations-in-a-load-test-scenario.md).|
|**Percentage of New Users**|Numeric value that specifies the percentage of new users or first time visitors in the scenario.<br /><br />For more information, see [How to: Specify the percentage of virtual users that use web cache data](../test/how-to-specify-the-percentage-of-virtual-users-that-use-web-cache-data.md).|
|**Think Profile**|Specifies if the scenario will use **Normal Distribution**, or if the think profile is **On** or **Off**.<br /><br />For more information, see [Edit think times to simulate website human interaction delays](../test/edit-think-times-in-load-test-scenarios.md).|

## Timing

|Property|Definition|
|-|----------------|
|**Delay Start Time**|A time value that indicates how many hours, minutes and seconds to delay starting the scenario after the load test starts. If **Disable During Warmup** property is set to **True**, the amount of time to wait applies after the completion of the warm-up period.<br /><br />For more information, see [Configure scenario start delays](../test/configure-scenario-start-delays.md).|
|**Disable During Warmup**|Boolean value that is used to specify if the scenario should run or not during the **Warm Up Duration** property time value specified in the load test's run setting.<br /><br />For more information about the load test run setting properties, see [Load test run settings properties](../test/load-test-run-settings-properties.md).<br /><br />For more information, see [Configure scenario start delays](../test/configure-scenario-start-delays.md).|
|**Think Times Between Test Iterations**|Numeric value that is used to specify the wait time in seconds between test iterations.<br /><br />For more information, see [Edit think times to simulate website human interaction delays](../test/edit-think-times-in-load-test-scenarios.md).|

## See also

- [Edit load test scenarios](../test/edit-load-test-scenarios.md)