---
title: "Apply Distribution to Pacing Delay for load testing in Visual Studio | Microsoft Docs"
ms.date: "10/19/2016"
ms.topic: "article"
helpviewer_keywords:
  - "load tests, test mix model"
ms.assetid: ae8b35f9-d465-4d72-8d7d-7b56ae6ffd22
author: gewarren
ms.author: gewarren
manager: ghogen
ms.technology: vs-ide-test
---
# How to: Apply Distribution to Pacing Delay When Using a User Pace Test Mix Model

After you create your load test by using the New Load Test Wizard, you can use the Load Test Editor to change the scenario's properties to meet your testing needs and goals.

The **Apply Distribution to Pacing Delay** property is set by using the Properties window. Load test scenario properties are modified by using the Load Test Editor.

> [!NOTE]
> The **Apply Distribution to Pacing Delay** property applies only if the *load test mix* is configured based on the user pace. For more information, see [Editing Text Mix Models to Specify the Probability of a Virtual User Running a Test](../test/edit-test-mix-models-to-specify-the-probability-of-a-virtual-user-running-a-test.md).

The value for the **Apply Distribution to Pacing Delay** can be set to either true or false:

-   **True**: The scenario will apply normal statistical distribution delays that are specified by the value in the **Tests Per User Per Hour** column in the Edit Test Mix dialog box. For more information, see [Editing Text Mix Models to Specify the Probability of a Virtual User Running a Test](../test/edit-test-mix-models-to-specify-the-probability-of-a-virtual-user-running-a-test.md).

     For example, assume that you have **Tests Per User Per Hour** value in the Edit Test Mix dialog box for the test set to two users per hour. If **Apply Distribution to Pacing Delay** property is set to **True**, a normal statistical distribution is applied to the wait time between the tests. The tests will still run two tests per hour, but it will not necessarily be 30 minute delay between them. The first test could run after four minutes and the second test after 45 minutes.

-   **False**: The tests will run at the pace that you specified for the value in the **Tests Per User Per Hour** column in the Edit Test Mix dialog box. For more information, see [Editing Text Mix Models to Specify the Probability of a Virtual User Running a Test](../test/edit-test-mix-models-to-specify-the-probability-of-a-virtual-user-running-a-test.md).

     For example, assume that you have **Tests Per User Per Hour** value in the Edit Test Mix dialog box for the test set to two users per hour. If the **Apply Distribution to Pacing Delay** property is set to **False**, you are giving no leeway when your tests run. The test will run every 30 minutes. This makes sure that you execute two tests per hour.

## To specify the Apply Distribution to Pacing Delay property setting for a scenario

1.  Open a load test.

     The **Load Test Editor** appears. The load test tree is displayed.

2.  In the **Scenarios** folder of the load test tree, choose the scenario node for which you want to specify the agents to use.

3.  On the **View** menu, select **Properties Window**.

     The categories and properties of the scenario are displayed in the **Properties** window.

4.  In the property value for the **Apply Distribution to Pacing Delay**, select either **True** or **False**.

5.  After you change the property, choose **Save** on the **File** menu. You can then run your load test by using the new **Apply Distribution to Pacing Delay** value.

## See also

- [Editing Load Test Scenarios](../test/edit-load-test-scenarios.md)
- [Walkthrough: Create and run a load test](../test/walkthrough-create-and-run-a-load-test.md)
- [Test controllers and test agents](configure-test-agents-and-controllers-for-load-tests.md)
- [Load Test Scenario Properties](../test/load-test-scenario-properties.md)