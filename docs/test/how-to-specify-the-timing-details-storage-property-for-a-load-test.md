---
title: "Timing Details Storage Property for a Load Test Run Setting"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, properties"
  - "load tests, run settings"
ms.assetid: 867a9c21-0909-4963-bc02-d41e9393008c
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Specify the timing details storage property for a load test run setting

After you create your load test with the **New Load Test Wizard**, you can use the **Load Test Editor** to change the settings to meet your testing needs and goals.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

You can edit a run setting's **Timing Details Storage** property's value in the **Properties** window. The **Timing Details Storage** property can be set to any of the following options:

- **All Individual Details:** Collects and stores individual timing data for each test, transaction, and page issued during the test.

  > [!NOTE]
  > The **All Individual Details** option must be selected to enable virtual user data information in your load test results. For more information, see [Analyze virtual user activity in the Details view](../test/analyze-load-test-virtual-user-activity-in-the-details-view.md).

- **None:** Does not collect any individual timing details. However, the average values are still available.

- **Statistics Only:** Stores individual timing data, but only as percentile data. This saves space resources.

  **Considerations for the Timing Details Storage Property**

  If the **Timing Details Storage** property is enabled, then the time to execute each individual test, transaction, and page during the load test will be stored in the load test results repository. This allows for 90th and 95th percentile data to be shown in the **Load Test Analyzer** in the **Tests**, **Transactions**, and **Pages** tables.

  If the **Timing Details Storage** property is enabled, by setting its value to either **StatisticsOnly** or **AllIndividualDetails**, all the individual tests, pages, and transactions are timed, and percentile data is calculated from the individual timing data. The difference is that with the **StatisticsOnly** option, after the percentile data has been calculated, the individual timing data is deleted from the repository. This reduces the amount of space that is required in the repository when timing details are used. However, you might want to process the timing detail data in other ways by using SQL tools, in which case the **AllIndividualDetails** option should be used so that the timing detail data is available for that processing. Additionally, if you set the property to **AllIndividualDetails**, then you can analyze the virtual user activity using the **Virtual User Activity Chart** in the **Load Test Analyzer** after the load test completes running. For more information, see [Analyze virtual user activity in the Details view](../test/analyze-load-test-virtual-user-activity-in-the-details-view.md).

  The amount of space required in the load test results repository to store the timing details data can be very large, especially for longer running load tests. Also, the time to store this data in the load test results repository at the end of the load test is longer because this data is stored on the load test agents until the load test has finished executing, at which time the data is stored into the repository. The **Timing Details Storage** property is enabled by default. If this is an issue for your testing environment, you may wish to set the **Timing Details Storage** to **None**.

  The timing details data is stored in the *LoadTestItemResults.dat* file during the run and is sent back to the controller after the load test is complete. For a load test running for a long duration, the size of the file is large. If there is not enough disk space on the agent machine, this will be an issue.

  If you are upgrading a project from a previous version of Visual Studio load test, use the following procedure to enable full detail collection.

## To configure the timing details storage property in a load test

1. Open a load test in the load test editor.

2. Expand the **Run Settings** node in the load test.

3. Choose on the run settings that you want to configure, for example **Run Settings1[Active]**.

4. Open the **Properties** Window. On the **View** menu, select **Properties Window**.

5. Under the **Results** category, choose the **Timing Details Storage** property and select **All Individual Details**.

     After you have configured the **All Individual Details** setting for the **Timing Details Storage** property, you can run your load test and view the **Virtual User Activity Chart**. For more information, see [How to: Analyze what virtual users are doing during a load test](../test/how-to-analyze-virtual-user-activity-during-a-load-test.md).

## See also

- [Analyze virtual user activity in the Details view](../test/analyze-load-test-virtual-user-activity-in-the-details-view.md)
- [Walkthrough: Using the Virtual User Activity Chart to isolate issues](../test/walkthrough-use-the-virtual-user-activity-chart-to-isolate-issues.md)