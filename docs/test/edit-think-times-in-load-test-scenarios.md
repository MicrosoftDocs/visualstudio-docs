---
title: Think Times for load testing
description: Learn how to edit think time, which simulates human behavior that causes people to wait between interactions with a website.
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
- load tests, think times
- load tests, adding delays
- load tests, changing think times
ms.assetid: 8e03bee5-ab7b-4b40-9497-9dbe91ccb90e
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# Edit think times to simulate website human interaction delays in load tests scenarios

Think times are used to simulate human behavior that causes people to wait between interactions with a website. Think times occur between requests in a web performance test and between test iterations in a load test scenario. Using think times in a load test can be useful in creating more accurate load simulations. You can change whether think times are used or ignored in load tests. You change whether think times are used in your load tests in the **Load Test Editor**.

The *think profile* is a setting that applies to a scenario in a load test. The setting determines whether the think times that are saved in the individual web performance tests are used during the load test. If you want to use think times in some web performance tests but not in others, you must place them in different scenarios. For more information about scenarios, see [Edit load test scenarios](../test/edit-load-test-scenarios.md).

Initially, you set whether you use think times in your load tests when you create the load test using the **New Load Test Wizard**. For more information, see [Edit load test scenarios](../test/edit-load-test-scenarios.md).

The **Think Profile** options are described in the following list:

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

**Off**

Think times are ignored. Use this setting when you want to generate maximum load to heavily stress your web server. Do not use it when you are trying to create more realistic user interactions with a web server.

**On**

Think times are used exactly as they were recorded in the web performance test. Simulates multiple users running the web performance tests exactly as recorded. Because a load test simulates multiple users, using the same think time could create an unnatural load pattern of synchronized virtual users.

**Normal Distribution**

Think times are used, but varied on a normal curve. Provides a more realistic simulation of virtual users by slightly varying the think time between requests.

> [!NOTE]
> For a complete list of the load test scenario properties and their descriptions, see [Load test scenario properties](../test/load-test-scenario-properties.md).

## Change the think profile

### To change a think profile in a load test scenario

1. From the web performance and load test project, open a load test.

2. In the **Load Test Editor**, choose the scenario node where you want to change the **Think Profile**. The **Think Profile** is displayed in the **Properties** window. Press **F4** to display the **Properties** window.

3. Change the **Think Profile** property in the **Properties** window.

4. After you have finished changing the properties, choose **Save** on the **File** menu. You can then run your load test with the new think profile.

## See also

- [Edit load test scenarios](../test/edit-load-test-scenarios.md)
