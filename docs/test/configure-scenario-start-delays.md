---
title: Configure Scenario Start Delays for load testing
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, scenarios, start delays"
ms.assetid: 2f634fba-8dfa-4c7a-a8b9-be867b78d16a
author: jillre
ms.author: jillfra
manager: jillfra
---
# Configure scenario start delays in load tests

Specify a delay before a scenario starts in a load test by using the Load Test Editor and the **Properties** window.

For example, you might want to use the **Delay Start Time** property if you need one scenario to start producing items that another scenario consumes. You can delay the consuming scenario to enable the producing scenario to populate some data.

Another example is that you might have one scenario that is only run at a certain time of the day. So, you want to delay the start of the scenario to simulate this.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## Specify the delay start time of a scenario

You can specify a delay before the start of a scenario in a load test by using the Load Test Editor to change the **Delay Start Time** property in the **Properties** window.

> [!NOTE]
> For a full list of the load test scenario properties and their descriptions, see [Load test scenario properties](../test/load-test-scenario-properties.md).

An example of an instance when you might want to use the **Delay Start Time** property is when you need one scenario to start producing items that another scenario consumes. You can delay the consuming scenario to enable the producing scenario to populate some data.

Another example is that you might have one scenario that is run only at a certain time of day. Therefore, you want to delay the start of the scenario to simulate this.

> [!NOTE]
> For a full list of the run settings properties and their descriptions, see [Load test scenario properties](../test/load-test-scenario-properties.md).

### To specify the delay start time for a scenario

1. Open a load test.

     The Load Test Editor appears. The load test tree is displayed.

2. In the load test trees **Scenarios** folder, choose the scenario node for which you want to specify the delay start time.

3. On the **View** menu, select **Properties Window**.

     The categories and properties of the scenario are displayed in the **Properties** window.

4. In the text box for the **Delay Start Time** property, type a time value that indicates the time to wait after the load test starts before starting the scenario when the load test is run.

    > [!NOTE]
    > If the value for the **Disable During Warmup** property for the scenario is set to **True**, then the **Delay Start Time** properties time value will be applied after the warm-up period. You can control which scenarios are included in warm-up by using the **Disable During Warmup** scenario property.

5. After you change the property, choose **Save** on the **File** menu. You can then run your load test by using the new **Delay Start Time** value.

## Enable and disable whether a scenario runs during the warm-up period

The **Disable During Warmup** property is set by using the **Properties** window. Editing load test scenario properties is set by the Load Test Editor.

The **Disable During Warmup** property is used to indicate whether the scenario should run or not run during the warm-up period that is specified in the **Delay Start Time** property. For more information, review the previous procedure [Specify the delay start time of a scenario](#specify-the-delay-start-time-of-a-scenario).

> [!NOTE]
> For a complete list of the run settings properties and their descriptions, see [Load test scenario properties](../test/load-test-scenario-properties.md).

### To enable or disable the warm-up period for a scenario

1. Open a load test.

     The **Load Test Editor** appears. The load test tree is displayed.

2. In the load test trees **Scenarios** folder, choose the scenario node that you want to change the warmup behavior for.

3. On the **View** menu, select **Properties Window**.

     The scenario's categories and properties are displayed in the **Properties** window.

     In the **Disable During Warmup** property, select either **True** or **False.**

4. After you have finished changing the property, choose **Save** on the **File** menu. You can then run your load test using the new **Disable During Warmup** value.

## See also

- [Editing load test scenarios](../test/edit-load-test-scenarios.md)
- [Configure test agents and test controllers for load tests](../test/configure-test-agents-and-controllers-for-load-tests.md)
- [Load test scenario properties](../test/load-test-scenario-properties.md)