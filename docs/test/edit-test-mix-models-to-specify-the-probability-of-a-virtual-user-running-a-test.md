---
title: "Editing Text Mix Models"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, scenarios"
  - "load tests, virtual users"
ms.assetid: e3b7d952-9012-400a-8131-3444390a6066
author: jillre
ms.author: jillfra
manager: jillfra
---
# Edit test mix models to specify the probability of a virtual user running a test

The *test mix model* specifies the probability of a virtual user running a given test in a load test scenario. This lets you simulate load more realistically. Instead of having just one workflow through your applications, you can have several workflows, which is a closer approximation of how end-users interact with your applications.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## Test mix model options

You can specify one of the following test mix model options for your load test scenario:

- **Based on the total number of tests:** Determines which web performance or unit test is run when a virtual user starts a test iteration. At the end of the load test, the number of times that a particular test was run matches the assigned test distribution. Use this test mix model when you are basing the test mix on transaction percentages in an IIS log or in production data.

- **Based on the number of virtual users:** Determines the percentage of virtual users who will run a particular web performance or unit test. At any point in the load test, the number of users who are running a particular test matches the assigned distribution. Use this test mix model when you are basing the test mix on the percentage of users running a particular test.

- **Based on user pace:** Over the course of the load test, each web performance test or unit test is run a specified number of times per users, per hour. Use this test mix model when you want virtual users to run test at a certain pace throughout the load test.

- **Based on sequential order:** Each virtual user runs the web performance or unit tests in the order that the tests are defined in the scenario. The virtual user continues cycling through the tests in this order until the load test is complete.

## Tasks

|Tasks|Associated Topics|
|-|-----------------------|
|**Specifying the test mix for your load test:** When you create a load test, you specify settings for the load test in the **New Load Test Wizard**. In the **New Load Test Wizard**, you choose existing web and unit tests to add to the initial scenario. After you have added tests to the scenario, you specify the test mix for the scenario.<br /><br /> You use load modeling options to more accurately predict the expected real-world usage of a website or application that you are load-testing. It is important to do this because a load test that is not based on an accurate load model can generate misleading results.|-   [Emulate expected real-world usage of a website or application](../test/emulate-real-world-usage-of-a-web-site-in-a-load-test-using-test-mix-models.md)|
|**Edit the test mix model:** You can change a load test scenario to use one of the test mix models by using the **Load Test Editor**.||
|**Configure pacing delay for a user paced test mix model:** If your load test scenario is configured to use the **Based on user pace test mix model**, you can specify how you want the distribution Pacing Delay configured.|-   [How to: Apply distribution to pacing delay when using a user pace test mix model](../test/how-to-apply-distribution-to-pacing-delay-when-using-a-user-pace-test-mix-model.md)|

## Change the test mix model in a scenario

After you create your load test by using the **New Load Test Wizard**, you can use the **Load Test Editor** to change the scenarios properties to meet your testing needs and goals.

> [!NOTE]
> For a complete list of the load settings properties and their descriptions, see [Load test scenario properties](../test/load-test-scenario-properties.md).

Using the **Load Test Editor**, you can change the test mix model in a load test scenario by editing the **Test Mix Type** property in the **Properties** window.

### To change the test mix model

1. Open a load test.

     The **Load Test Editor** appears. The load test tree is displayed.

2. In *Scenarios* folder of the load test tree, choose the scenario node for which you want to specify the maximum number of test iterations.

3. On the **View** menu, select **Properties Window**.

     The categories and properties of the scenario are displayed.

4. In the **Test Mix Type** property, choose the ellipsis button ( **…**).

     The **Edit Test Mix** dialog box is displayed.

5. Choose the drop-down list under **Test mix model** and select the test mix model that you want to use for the scenario.

6. (Optional) Modify the test mix by using the **Add**, **Remove** and **Distribute** buttons and distribution sliders. For more information, see [Edit the test mix to specify which tests to include in a load test scenario](../test/edit-the-test-mix-to-specify-which-web-browsers-types-in-a-load-test-scenario.md).

7. (Optional) Specify a web performance and unit test to initialize or end by using the check boxes and selecting the desired tests. For more information, see [Emulate expected real-world usage of a website or application](../test/emulate-real-world-usage-of-a-web-site-in-a-load-test-using-test-mix-models.md).

8. Choose **OK**.

     The **Properties** window displays the new test mix model for the **Test Mix Type** property.

9. After you change the property, choose **Save** on the **File** menu. You can then run your load test by using the new **Test Mix Type** value.

## See also

- [Edit load test scenarios](../test/edit-load-test-scenarios.md)
- [Load test scenario properties](../test/load-test-scenario-properties.md)