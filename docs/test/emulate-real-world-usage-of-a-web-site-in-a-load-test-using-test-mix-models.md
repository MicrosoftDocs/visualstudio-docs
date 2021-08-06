---
title: Emulate real-world usage of a website for load testing
description: Use load modeling options to more accurately predict the expected real-world usage of a website or application that you are load testing. 
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
- load model, specifying
- load test load model, specifying
ms.assetid: b7fae849-0538-40d1-ab35-2bb3a0fe4393
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# Test mix models overview

You use load modeling options to more accurately predict the expected real-world usage of a website or application that you are load testing. It's important to do this because a load test that's not based on an accurate load model can generate misleading results.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## Test mix model enhancements

Using the Load Test Editor or the test mix model wizard, you can specify the following types of test mix for a load test scenario. For more information, see [Change the test mix model in a scenario](../test/edit-test-mix-models-to-specify-the-probability-of-a-virtual-user-running-a-test.md).

You can specify one of the following test mix model options for your load test scenario:

- **Based on the total number of tests:** Determines which web performance or unit test is run when a virtual user starts a test iteration. At the end of the load test, the number of times that a particular test run matched the assigned test distribution. Use this test mix model when you are basing the test mix on transaction percentages in an IIS log or in production data. For more information, see [Percentage based on tests started](#BasedOnTestsStarted).

- **Based on the number of virtual users:** Determines the percentage of virtual users who will run a particular web performance or unit test. At any point in the load test, the number of users who are running a particular test matches the assigned distribution. Use this test mix model when you are basing the test mix on the percentage of users who are running a particular test. For more information, see [Percentage based on virtual users](#PercentageBasedonVirtualUsers).

- **Based on user pace:** Over the course of the load test, each web performance test or unit test is run a specified number of times per users, per hour. Use this test mix model when you want virtual users to run test at a certain pace throughout the load test. For more information, see [Pacing test mix](#PacingTestMix).

    > [!TIP]
    > When do you choose **Percentage test mix** and when do you choose **Percentage based on virtual users**? The difference between these two choices is important when some tests in the test mix have a much longer duration than other tests. In this situation, you should probably choose **Percentage based on virtual users**. This choice helps avoid a test run in which the probability increases that too many users will be running long-duration tests. However, if the tests all have similar durations, you can more safely choose **Percentage test mix**.

- **Based on sequential order:** Each virtual user runs the web performance or unit tests in the order that the tests are defined in the scenario. The virtual user continues cycling through the tests in this order until the load test is complete. For more information, see [Sequential order](#SequentialOrder).

### <a name="BasedOnTestsStarted"></a> Percentage based on tests started

For each test in the mix, you can specify a percentage that determines how frequently the test is selected as the next test to run. For example, you might assign the following percentage values to three tests:

- TestA (50%)

- TestB (35%)

- TestC (15%)

If you use this setting, the next test to start is based on the assigned percentages. You do this without taking into account the number of virtual users who are currently running each test.

### <a name="PercentageBasedonVirtualUsers"></a> Percentage based on virtual users
This model of test mix determines the percentage of virtual users who will run a particular test. If you use this model of test mix, the next test to start is based not only on the assigned percentages but also on the percentage of virtual users who are currently running a particular test. At any point in the load test, the number of users who are running a particular test matches the assigned distribution as closely as possible.

### <a name="PacingTestMix"></a> Pacing test mix

If you specify a pacing test mix, you set a rate of test execution for each virtual user for each test in the test mix. For each test, this rate is expressed as tests run per virtual user per hour. For example, you might assign the following pacing test mix to the following tests:

- TestA: 4 tests per user per hour

- TestB: 2 tests per user per hour

- TestC: 0.125 tests per user per hour

If you use the pacing test mix model, the load test runtime engine guarantees that the actual rate at which tests are started is less than or equal to the specified rate. If the tests run too long for the assigned number to be completed, an error is returned.

The **Think Time Between Test Iterations** setting does not apply when you use a pacing test mix.

#### Apply distribution to pacing delay
The value for the **Apply Distribution to Pacing Delay** property in a load test scenario can be set to either true or false:

- **True**: The scenario will apply typical statistical distribution delays specified by the value in the **Tests Per User Per Hour** column in the **Edit Test Mix** dialog. For more information, see [Edit text mix models to specify the probability of a virtual user running a test](../test/edit-test-mix-models-to-specify-the-probability-of-a-virtual-user-running-a-test.md).

   For example, assume that you have **Tests Per User Per Hour** value in the **Edit Test Mix** dialog for the test set to 2 users per hour. If **Apply Distribution to Pacing Delay** property is set to **True**, a typical statistical distribution is applied to the wait time between the tests. The tests will still run 2 tests per hour, but it will not necessarily be 30 minutes between them. The first test could run after 4 minutes and the second test after 45 minutes.

- **False**: The tests will run at the specific pace you specified for the value in the **Tests Per User Per Hour** column in the **Edit Test Mix** dialog. For more information, see [Edit text mix models to specify the probability of a virtual user running a test](../test/edit-test-mix-models-to-specify-the-probability-of-a-virtual-user-running-a-test.md).

   For example, assume that you have **Tests Per User Per Hour** value in the **Edit Test Mix** dialog for the test set to 2 users per hour. If the **Apply Distribution to Pacing Delay** property is set to **False**, you are basically giving no leeway when your tests run. The test will run every 30 minutes. This makes sure that you execute 2 tests per hour.

  For more information, see [How to: Apply distribution to pacing delay when using a user pace test mix model](../test/how-to-apply-distribution-to-pacing-delay-when-using-a-user-pace-test-mix-model.md).

### <a name="SequentialOrder"></a> Sequential order
Selecting the Based on sequential test order option makes each virtual user run all the tests in the scenario in the order that the tests were defined.

## Test iterations property
In the Run Settings properties, you can specify a value for the Test Iterations property. This value is the number of test iterations to run in a load test. After the specified number of test iterations has been started, no additional test iterations will be started despite the settings of any of the load profiles. After the number of test iterations specified has been completed, the load test ends. For more information, see [How to: Specify the number of test iterations in a run setting](../test/how-to-specify-the-number-of-test-iterations-in-a-load-test.md).

## Initialize and terminate tests
You can select tests to run at the beginning and end of each virtual user's load testing session. For more information, see [Edit text mix models to specify the probability of a virtual user running a test](../test/edit-test-mix-models-to-specify-the-probability-of-a-virtual-user-running-a-test.md).

- **Initialize test**. This test is run by each virtual user before any of the tests in the test mix are run.

- **Terminate test**. This test is run after all tests for a particular virtual user are run.

  Please note the following about the initialize test and the terminate test:

- You can specify the load test duration by time instead of by iteration count. In this case, when the load test run duration has completed, the terminate test will not be run.

- If the initialize test is a unit test or a web performance test, the state of the TestContext, or WebTestContext, object after the completion of the initialize test is saved. It will then be used as the starting context for iterations of tests in the test mix.

- New Users, as defined in the scenario property Percentage of New Users, always execute the initialize test, one iteration of a test from the test mix, and the terminate test.

## See also

- [Edit text mix models to specify the probability of a virtual user running a test](../test/edit-test-mix-models-to-specify-the-probability-of-a-virtual-user-running-a-test.md)
- [Edit load patterns to model virtual user activities](../test/edit-load-patterns-to-model-virtual-user-activities.md)
- [Edit the test mix to specify which tests to include in a load test scenario](../test/edit-the-test-mix-to-specify-which-web-browsers-types-in-a-load-test-scenario.md)
- [Configure load test run settings](../test/configure-load-test-run-settings.md)
- [Load test scenario properties](../test/load-test-scenario-properties.md)
- [Change the test mix model in a scenario](../test/edit-test-mix-models-to-specify-the-probability-of-a-virtual-user-running-a-test.md)
