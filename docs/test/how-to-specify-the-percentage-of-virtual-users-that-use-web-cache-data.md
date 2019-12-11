---
title: "Load test: Set virtual user percentage using web cache data"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, virtual users"
ms.assetid: f66d5d43-4121-4487-b27f-d0a0baaf7601
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Specify the percentage of virtual users that use web cache data

After you create your load test with the **New Load Test Wizard**, you can change the scenarios properties to meet your testing needs and goals by using the **Load Test Editor**. For a full list of the load test scenario properties and their descriptions, see [Load test scenario properties](../test/load-test-scenario-properties.md).

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

The **Percentage of new Users** property is set in the **Properties** window. You edit load test scenario properties in the **Load Test Editor**.

The **Percentage of new Users** property affects the way in which the load test simulates the caching that would be performed by a web browser. By default, the **Percentage of new Users** property is set to 0%. If the value for the **Percentage of new Users** property is set to 100%, each web performance test run in a load test is treated like a first time user to the website who does not have any content from the website in their browser cache from previous visits. Thus, all requests in the web test, including all dependent requests such as images, are downloaded.

> [!NOTE]
> When the same cacheable resource is requested more than once in a web test, the requests are not downloaded.

If you are load testing a website that has a significant number of return users who are likely to have images and other cacheable content cached locally, then a setting of 100% for **Percentage of new Users** property will generate more download requests than would occur in real-world usage. In this case, you should estimate the percentage of visits to your website that are from first time users of the website, and set **Percentage of new Users** property accordingly.

## To specify the percentage of new users for a scenario

1. Open a load test.

     The **Load Test Editor** appears. The load test tree is displayed.

2. In the load test trees **Scenarios** folder, choose the scenario node you want to change the new user percentage value for.

3. On the **View** menu, select **Properties Window**.

     The scenario's categories and properties are displayed in the **Properties** window.

4. Set the value for the **Percentage of New Users** property by entering a number for the percentage of new users.

5. After you have finished changing the property, choose **Save** on the **File** menu. You can then run your load test using the new **Percentage of New Users** value.

## See also

- [Edit load test scenarios](../test/edit-load-test-scenarios.md)
- [Walkthrough: Create and run a load test](../test/walkthrough-create-and-run-a-load-test.md)
- [Test controllers and test agents](configure-test-agents-and-controllers-for-load-tests.md)
- [Load test scenario properties](../test/load-test-scenario-properties.md)
- [Edit load patterns to model virtual user activities](../test/edit-load-patterns-to-model-virtual-user-activities.md)