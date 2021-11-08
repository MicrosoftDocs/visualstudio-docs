---
title: Load Test Logging Settings
description: Learn how to modify load test logging settings to control the amount of performance data collected, which can lead to very large result files.
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
- load tests, logging, modifying
ms.assetid: 9649226a-857d-41ef-8ec7-047b6e498033
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# Modify load test logging settings

The load test result for the completed load test contains performance counter samples and error information that was collected in a log periodically from the computers-under-test. A large number of performance counter samples can be collected over the course of a load test run. The amount of performance data that is collected depends on the length of the run, the sampling interval, the number of computers under test, and the number of counters to collect. For a large load test, the amount of performance data that is collected can easily be several gigabytes; therefore, you might consider modifying how often data is saved to the log. See [Test controllers and test agents](configure-test-agents-and-controllers-for-load-tests.md).

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

The *test controller* spools all collected load test sample data to a database log while the test is running. Additional data, such as timing details and error details, is loaded into the database when the test completes.

|Task|Associated topics|
|-|-----------------------|
|**Save logs if a load test fails:** You can specify if you want to save the test log whenever a load test fails.|-   [How to: Specify if test failures are saved to test logs](../test/how-to-specify-if-test-failures-are-saved-to-test-logs.md)|
|**Set the maximum file size for the log file:** You can edit the XML configuration file that is associated with the test controller service to specify the maximum file size you want to use for the log file.|Modify `<add key="LogSizeLimitInMegs" value="20"/>` in the *QTCcontroller.exe.config* XML configuration file.|

## See also

- [Configure load test run settings](../test/configure-load-test-run-settings.md)
