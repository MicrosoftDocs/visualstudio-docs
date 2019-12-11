---
title: "Specify Test Agents to Use in Load Test Scenarios"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "test agents, load tests"
  - "load tests, scenarios"
  - "load tests, specifying for load tests"
  - "tests agents, load tests, specifying"
  - "load tests, test agents"
ms.assetid: e86806dd-5897-4e4c-bfd4-8d687fb72a6e
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Specify test agents to use in load test scenarios

After you create your load test by using the **New Load Test Wizard**, you can use the **Load Test Editor** to change the scenarios properties to meet your testing needs and goals.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

> [!NOTE]
> For a full list of the load test scenario properties and their descriptions, see [Load test scenario properties](../test/load-test-scenario-properties.md).

The agents are specified by using the **Load Test Editor** to change the **Agents to Use** property in the **Properties** window.

You can specify the agents that you want your scenario to use if you are using controllers and agents to run the load test remotely. For example, you might want to specify a specific set of agents so that you maintain consistency when you analyze performance trends. Also, agents may be geographically distributed, so that an affinity exists between which scripts they run and where the agent is located.

> [!TIP]
> Rather than physically putting an agent at the remote site, another option is to use network emulation to emulate the slow network. For more information, see [Specify virtual network types](../test/specify-virtual-network-types-in-a-load-test-scenario.md).

For more information, see  [Test controllers and test agents](configure-test-agents-and-controllers-for-load-tests.md).

Another reason is that some, but not all, agents might have software installed on them that is required for a particular scenario.

You can control agent selection for a given test run by using roles in test settings. For more information, see  [Collect diagnostic information using test settings](../test/collect-diagnostic-information-using-test-settings.md).

If a test agent machine has more than 75 percent CPU utilization or has less than 10 percent of physical memory available, add more agents to your load test to make sure that the agent machine does not become the bottleneck in your load test.

## To specify the agents to use for a scenario

1. Open a load test.

     The **Load Test Editor** appears. The load test tree is displayed.

2. In the load test trees **Scenarios** folder, choose the scenario node for which you want to specify the agents to use.

3. On the **View** menu, select **Properties Window**.

     The categories and properties of the scenario are displayed in the **Properties** window.

4. In the text box for the **Agents to Use** property, type the list of agents on which the scenario may run.

     Agents must be separated by commas, for example "**Agent1, Agent2, Agent3**". Leaving the property blank specifies that the scenario should use all available agents.

    > [!NOTE]
    > The **Agents to Use** property is ignored for local runs. For remote runs, if none of the agents specified in **Agents to Use** exist, tests in the scenario will not run.

5. After you change the property, choose **Save** on the **File** menu. You can then run your load test by using the new **Agents to Use** value.

## See also

- [Edit load test scenarios](../test/edit-load-test-scenarios.md)
- [Walkthrough: Create and run a load test](../test/walkthrough-create-and-run-a-load-test.md)
- [Test controllers and test agents](configure-test-agents-and-controllers-for-load-tests.md)
- [Load test scenario properties](../test/load-test-scenario-properties.md)