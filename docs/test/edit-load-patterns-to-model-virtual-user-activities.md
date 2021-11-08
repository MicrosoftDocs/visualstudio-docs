---
title: Load patterns for load testing
description: Learn about the built-in load patterns that Visual Studio provides. Choose the load pattern and adjust the properties to appropriate levels for your load test.
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
- load tests, load patterns
- load tests, scenarios
- load tests, virtual users
ms.assetid: 0ba0363b-7f50-4bde-a919-0e3bce7bc115
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# Edit load patterns to model virtual user activities

The load pattern properties specify how the simulated user load is adjusted during a load test. Visual Studio provides three built-in load patterns: constant, step, and goal-based. You choose the load pattern and adjust the properties to appropriate levels for your load test goals.

The load pattern is a component of a scenario. The scenarios, together with their defined load patterns, comprise a load test.

> [!NOTE]
> In all Load Patterns, the load that Visual Studio generates is a simulated load of virtual users.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## Load patterns

### Constant

The constant load pattern is used to specify a user load that does not change during the load test. For example, when you run a smoke test on a web application, you might want to set a light, constant load of 10 users.

#### Constant load pattern considerations

A constant load pattern is used to run the same user load during the run of a load test. Be careful about using a constant load pattern that has a high user count; doing so may place an unreasonable and unrealistic demand on your server or servers at the beginning of the load test. For example, if your load test contains a web test that starts with a request to a home page, and you set up the load test with a constant load of 1,000 users, the load test will submit the first 1,000 requests to the home page as fast as possible. This may not be a realistic simulation of real-world access to your website. To mitigate this, consider using a step load pattern that increases gradually to 1,000 users, or specify a warm-up period in the Load Test Run Settings. If a warm-up period is specified, the load test will automatically increase the load gradually during the warm-up period. For more information, see [Configure scenario start delays](../test/configure-scenario-start-delays.md).

### Step

The step load pattern is used to specify a user load that increases with time up to a defined maximum user load. For stepping loads, you specify the **Initial User Count**, **Maximum User Count**, **Step Duration (seconds)**, and **Step User Count**.

For example a Step load with an **Initial User Count** of one, **Maximum User Count** of 100, **Step Duration (seconds)** of 10, and a **Step User Count** of 1 creates a user load pattern that starts at 1, increases by 1 every 10 seconds until it reaches 100 Users.

> [!NOTE]
> If the total test duration is shorter than the time that is required to step up to the maximum user load, then the test stops after the elapsed duration and does not reach the **Maximum User Count** target.

You can use the Step goal to increase the load until the server reaches a point that where performance diminishes significantly. As load increases, the server will eventually run out of resources. The step load is a good way to determine the number of users at which this occurs. With the stepping load, you also have to monitor agent resources closely to make sure that the agents can generate the desired load.

Ordinarily, you should conduct several runs that have different step durations and step user counts so that you can obtain good measurements for a given load. Frequently, loads show an initial spike for each step as users are added. Holding the load at that rate allows you to measure system performance after the system recovers from the initial spike.

#### Step load pattern considerations

A step load pattern can be used to increase the load on the server or servers as the load test runs so that you can see how performance varies as the user load increases. For example, to see how your server or servers perform as the user load increases to 2,000 users, you might run a 10-hour load test by using a step load pattern that has the following properties:

- **Initial User Count**: 100

- **Maximum User Count**: 2,000

- **Step Duration (seconds)**: 1,800

- **Step Ramp Time (seconds)**: 20

- **Step User Count**: 100

  These settings run the load test for 30 minutes (1,800 seconds) at user loads of 100, 200, 300, and up to 2,000 users. The **Step Ramp Time** property is worth special mention, because it is the only one of these properties that is not available for selection in the **New Load Test Wizard**. This property allows the increase from one step to the next (for example from 100 to 200 users) to occur gradually rather than immediately. In the example, the user load would be increased from 100 to 200 users over a 20 second period (an increase of five users every second). For more information, see [How to: Specify the step ramp time property for a step load pattern](../test/how-to-specify-the-step-ramp-time-property-for-a-step-load-pattern.md).

### Goal-based

A goal-based load pattern resembles the step pattern but adjusts the user load based on performance counter thresholds versus periodic user load adjustments. Goal based loads are useful for a variety of different purposes:

- Maximizing output from the agents: measure the key limiting metric on the agent to maximize the output of the agents. Typically, it is CPU; However, it could also be memory.

- Reaching some target resource level, typically CPU, on the target server, then measuring throughput at that level. This enables you to do run-to-run comparisons of throughput given a consistent level of resource usage on the server.

- Reaching a target throughput level on the server.

  In the following table, an example shows a goal-based pattern with the following property settings:

|Property Group|Property|Value|
|-|--------------|-|
|Performance Counter|Category|Processor|
|Performance Counter|Computer|ContosoServer1|
|Performance Counter|Counter|% Processor Time|
|Performance Counter|Instance|_Total|
|Target Range for Performance Counter|High End|90|
|Target Range for Performance Counter|Low End|70|
|User Count Limits|Initial User Count|1|
|User Count Limits|Maximum User Count|100|
|User Count Limits|Maximum User Count Decrement|5|
|User Count Limits|Maximum User Count Increment|5|
|User Count Limits|Minimum User Count|1|

Those settings cause the **Load Test Analyzer** to adjust the user load between 1 and 100 during a test run in such a way that the **Counter** for `% Processor Time` of the WebServer01 hovers between `70%` and `90%.`

The size of the each user load adjustment is determined by **Maximum User Count Increment** and **Maximum User Count Decrement** settings. The user count limits are set by the **Maximum User Count** and **Minimum User Count** properties.

#### Goal-based load pattern considerations

A goal-based load pattern is useful when you want to determine the number of users that your system can support before it reaches some level of resource utilization. This option works best when you have already identified the limiting resource (that is, the bottleneck) in your system.

For example, suppose you know that the limiting resource in your system is the CPU on your database server, and you want to see how many users can be supported when the CPU on the database server is approximately 75 percent busy. You could use a goal-based load pattern that has the goal of keeping the value of the performance counter "%Processor Time" between 70 percent and 80 percent.

One thing to watch out for is if some other resource is limiting the throughput of the system. Such resources can cause the goal that is specified by the goal-based load pattern to never be reached. Also, the user load will continue to rise until the value that is specified for the **Maximum User Count** is reached. This is usually not the desired load, so be careful about the choice of the performance counter in the goal-based load pattern.

## Tasks

|Tasks|Associated Topics|
|-|-----------------------|
|**Specifying the initial load pattern for your load test:** When you create a load test by using the **New Load Test Wizard**, you select a load pattern.|-   [Change the load pattern](../test/edit-load-patterns-to-model-virtual-user-activities.md#change-the-load-pattern)|
|**Editing the load pattern for your load test:** After you create your load test, you can edit the load pattern in the **Load Test Editor**.|-   [How to: Specify the step ramp time property for a step load pattern](../test/how-to-specify-the-step-ramp-time-property-for-a-step-load-pattern.md)|
|**Specifying whether the virtual users in your load test scenario should include web cache data:** You can change the **Percentage of new Users** property to affect the way in which the load test simulates the web caching that would be performed by a web browser for the virtual users.|-   [How to: Specify the percentage of virtual users that use web cache data](../test/how-to-specify-the-percentage-of-virtual-users-that-use-web-cache-data.md)|
|**Specifying the step ramp time for a step load pattern:** The **Step Ramp Time** property allows the increase from one step to the next (for example from 100 to 200 users) to occur gradually rather than immediately.|-   [How to: Specify the step ramp time property for a step load pattern](../test/how-to-specify-the-step-ramp-time-property-for-a-step-load-pattern.md)|

## Change the load pattern

After you create your load test with the **New Load Test Wizard**, you can use the **Load Test Editor** to change the load pattern properties associated with a scenario to levels that meet your test goals.

> [!NOTE]
> For a full list of the load test scenario properties and their descriptions, see [Load test scenario properties](../test/load-test-scenario-properties.md).

A load pattern specifies the number of virtual users active during a load test, and the rate at which new users are added. You can choose from the three available patterns: step pattern, constant and goal based. For more information, see [Specify the number of virtual users with load patterns in a load test scenario](../test/edit-load-patterns-to-model-virtual-user-activities.md).

> [!NOTE]
> You can also change your load properties programmatically by using a load test plug-in. For more information, see [How to: Create a load test plug-in](../test/how-to-create-a-load-test-plug-in.md).

### To change the load pattern

1. Open a load test.

2. In the **Load Test Editor**, in the *Scenarios* folder, expand the scenario you want to edit the load pattern for and choose the load pattern for the scenario.

    > [!NOTE]
    > The wording of the load pattern node, as it is displayed in the scenario tree of your load test, reflects the load profile you that you chose when you created the load test. It can be either **Constant Load Profile** or **Step Load Profile**.

3. Press **F4** to display the **Properties** window.

     The **Load Pattern** and the **Parameters** categories are displayed in the **Properties** window.

4. (Optional) Change the **Pattern** property in the **Load Pattern** category.

     Your choices for the **Pattern** property are **Step**, **Constant**, and **Goal Based**. For more information about the load pattern types, see [Specify the number of virtual users with load patterns in a load test scenario](../test/edit-load-patterns-to-model-virtual-user-activities.md).

5. (Optional) In the **Parameters** category, change the values.

    > [!NOTE]
    > The values you can set for **Parameters** differ according to the value that was selected for **Pattern** property.

6. After you have finished changing the properties, choose **Save** on the **File** menu. You can then run your load test with the new load pattern.

## See also

- [Edit load test scenarios](../test/edit-load-test-scenarios.md)
- [How to: Specify the percentage of virtual users that use web cache data](../test/how-to-specify-the-percentage-of-virtual-users-that-use-web-cache-data.md)
- [How to: Specify the step ramp time property for a step load pattern](../test/how-to-specify-the-step-ramp-time-property-for-a-step-load-pattern.md)
