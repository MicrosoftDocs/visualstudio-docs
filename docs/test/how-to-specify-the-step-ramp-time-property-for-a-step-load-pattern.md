---
title: "Step Ramp Time for a Step Load Pattern for load testing"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, load patterns"
ms.assetid: 4a69e857-f93b-4907-9a01-fd1b66291205
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Specify the step ramp time property for a step load pattern

After you create your load test with the **New Load Test Wizard**, you can use the **Load Test Editor** to change the scenarios properties to meet your testing needs and goals. For more information, see [Walkthrough: Create and run a load test](../test/walkthrough-create-and-run-a-load-test.md).

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

> [!NOTE]
> For a full list of the load test scenario properties and their descriptions, see [Load test scenario properties](../test/load-test-scenario-properties.md).

The **Step Ramp Time** property is set in the **Properties** window. You edit load test scenario properties in the **Load Test Editor**.

The **Step Ramp Time** property is only used with a step load pattern. For more information, see [Edit load patterns to model virtual user activities](../test/edit-load-patterns-to-model-virtual-user-activities.md).

A step load pattern is used to increase the load on the server or servers as the load test runs so that you can see how performance varies as the user load increases. For example, to see how your server or servers perform as the user load increasing to 2,000 users, you might run a 10-hour load test using a step load pattern with the following properties:

- Initial User Count: 100

- Maximum User Count: 2000

- Step Duration (seconds): 1800

- Step Ramp Time (seconds): 20

- Step User Count: 100

These settings have the load test running for 30 minutes (1800 seconds) at user loads of 100, 200, 300, up to 2,000 users.

> [!NOTE]
> The **Step Ramp Time** property is the only one of these properties that is not available to choose in the **New Load Test Wizard**.

The **Step Ramp Time** property allows the increase from one step to the next (for example from 100 to 200 users) to be gradual rather than immediate. In the example, the user load would be increased from 100 to 200 users over a 20 second period (an increase of 5 users every second).

## To edit the step ramp time property for a step load pattern

1. Open a load test.

     The **Load Test Editor** appears. The load test tree is displayed.

2. In the load test trees **Scenarios** folder, open the scenario node you want to specify the step ramp time for.

3. Select the **Step Load Pattern** node.

    > [!NOTE]
    > The load pattern for the scenario must be a step load pattern. If it is not, the load pattern will display the load pattern type that is currently associated with the scenario. For more information, see [Edit load patterns to model virtual user activities](../test/edit-load-patterns-to-model-virtual-user-activities.md).

4. On the **View** menu, select **Properties Window**.

     The scenario's categories and properties are displayed in the **Properties** window.

5. Set the value for the **Step Ramp Time** property by entering a number for the seconds taken in each step to gradually add the users specified by the **Step User Count** property.

6. After you have finished changing the property, choose **Save** on the **File** menu. You can then run your load test using the new **Step Ramp Time** value.

## See also

- [Edit load test scenarios](../test/edit-load-test-scenarios.md)
- [Test controllers and test agents](configure-test-agents-and-controllers-for-load-tests.md)
- [Load test scenario properties](../test/load-test-scenario-properties.md)
- [Edit load patterns to model virtual user activities](../test/edit-load-patterns-to-model-virtual-user-activities.md)