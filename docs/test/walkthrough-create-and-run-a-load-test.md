---
title: Create and run a load test
description: Learn how to create a load test that contains unit tests. You create and run load tests using Visual Studio Enterprise.
ms.custom: SEO-VS-2020
ms.date: 10/01/2016
ms.topic: conceptual
helpviewer_keywords:
- unit tests, in load tests
- unit tests, load test walkthrough
- load tests, walkthrough
ms.assetid: bbf075a5-96d5-48ed-a03c-330f0fc04748
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# Walkthrough: Create and run a load test that contains unit tests

In this walkthrough you create a load test that contains unit tests.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

This walkthrough steps you through creating and then running a load test using Visual Studio Enterprise. A load test is a container of web performance tests and unit tests. You create load tests with the **New Load Test Wizard**.

A load test also exposes many run-time properties that can be modified to generate the desired load simulation. In this walkthrough, you use the **New Load Test Wizard** to add unit tests to a load test.

In this walkthrough, you will complete the following tasks:

- Create a load test that uses unit tests.

- Change some of the load test settings.

- Run a load test.

- Perform the steps in [Walkthrough: Creating and running unit tests for managed code](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md) to create a simple C# class library that contains a web performance and load test project with some unit tests in it.

## Create a load test containing unit tests using the New Load Test Wizard

### To start the New Load Test Wizard

1. Make sure you have installed the **Web performance and load testing tools** component described in [Create a load test project](../test/quickstart-create-a-load-test-project.md).

1. Open the Bank solution that you created in [Walkthrough: Creating and running unit tests for managed code](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md).

1. In **Solution Explorer**, open the shortcut menu for the Bank solution node, choose **Add**, and then choose **New Project**.

     The **Add New Project** dialog box displays.

1. In the **Add New Project** dialog box, expand **Visual C#** and choose **Test**. From the list of templates, choose **Web Performance and Load Test Project** and in the **Name** field, type `BankLoadTest`. Choose **OK**.

     The BankLoadTest web performance and load test project is added to the solution.

1. Open the shortcut menu for the new BankLoadTest web performance and load test project, choose **Add**, and then choose **Load Test**.

1. The **New Load Test Wizard** starts.

1. The **Welcome** page of the **New Load Test Wizard** is the first page.

1. Choose **Next**.

### To edit settings for load test scenario

1. In the **Enter a name for the load test scenario** text box, type **ScenarioSample**.

     A *scenario* is a grouping mechanism. It consists of a set of tests and the properties for running those tests under load.

2. Set the **Time Profile Think** to `Use normal distribution centered on recorded think times`. Think times represent the time that a user would ponder a web page before going on to the next page.

1. Choose **Next** when you are finished.

### To edit load pattern setting for test scenario

1. Choose **Step load**.

    > [!NOTE]
    > You can choose from two types of load patterns: constant and step. Each type has its function in load testing, but for the purposes of this walkthrough choose **Step load**.

2. Set **Start user count** to 10 users.

3. Set **Step duration** to 10 seconds.

4. Set **Step user count** to 10 users/step.

5. Set **Maximum user count** to 100 users.

6. Choose **Next**.

### To select test mix model for the scenario

1. Under **How should the test mix be modeled**, select **Based on the total number of test**.

2. Choose **Next**.

### To add unit tests to the scenario

1. The next step is to **Add tests to a load test scenario and edit test mix**.

2. Choose **Add** to select tests.

3. Choose the **CreditTest** unit tests listed in the **Available Tests** pane, which lists all the web performance tests and unit tests in the web performance and load test project.

4. Choose the arrow to add the **CreditTest** unit test to the **Selected Tests** pane.

5. Repeat steps 3 and 4 for the **DebitTest** and **FreezeAccountTest** unit tests.

6. When you have finished adding the three unit tests, choose **OK**.

     You are presented with the test mix.

7. Move the slider under **Distribution** for the **CreditTest** slightly to the right to adjust the test distribution. Notice that the other sliders move to the left automatically so that the distribution remains at 100%.

8. Choose **Next**.

### To select network mix for test scenario

1. Select the LAN connection type to add to the network bandwidth mix.

     You can add more network types. Use the sliders to adjust the test distribution and weighting.

2. Choose **Next**.

### To specify computers to monitor with counter sets during load test run

1. Choose **Next**.

     For more information about the counter sets, see [Specify the counter sets and threshold rules for computers in a load test](../test/specify-counter-sets-and-threshold-rules-for-load-testing.md).

### To edit run setting for load test

1. Select **Load test duration** and then set **Run Duration** to 2 minutes in order to *smoke test* your load test.

     When you build your load tests, it is a good practice to validate that everything is configured correctly and running as expected by running a short, light load test. This process is known as *smoke testing*.

2. Choose **Finish**. Your Load test is opened in the **Load Test Editor**.

## Run the load test
 After you have created the Load test, run it to view how your bank application responds to the load simulation. While a load test is running, you see the **Load Test Analyzer** window.

### To run the load test

1. With a Load test open in the **Load Test Editor**, choose the green **Run Test** button in the toolbar. Your load test starts to run.

2. If your test simulation exceeds any thresholds, icons appear in the tree control nodes to indicate a threshold violation. Errors have a red circle overlay, warnings have a yellow triangle overlay. You can find a counter that exceeded the threshold and graph it by dragging the icon onto the graph. You can do this while the test is running.

## See also

- [Edit the test mix to specify which tests to include in a load test scenario](../test/edit-the-test-mix-to-specify-which-web-browsers-types-in-a-load-test-scenario.md)
- [Specify virtual network types](../test/specify-virtual-network-types-in-a-load-test-scenario.md)
- [Edit load test scenarios](../test/edit-load-test-scenarios.md)
- [Edit load patterns to model virtual user activities](../test/edit-load-patterns-to-model-virtual-user-activities.md)
- [Edit text mix models to specify the probability of a virtual user running a test](../test/edit-test-mix-models-to-specify-the-probability-of-a-virtual-user-running-a-test.md)
