---
title: "Load Test Logging Settings in Visual Studio"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, logging, modifying"
ms.assetid: 9649226a-857d-41ef-8ec7-047b6e498033
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# Modify Load Test Logging Settings

The load test result for the completed load test contains performance counter samples and error information that was collected in a log periodically from the computers-under-test. A large number of performance counter samples can be collected over the course of a load test run. The amount of performance data that is collected depends on the length of the run, the sampling interval, the number of computers under test, and the number of counters to collect. For a large load test, the amount of performance data that is collected can easily be several gigabytes; therefore, you might consider modifying how often data is saved to the log. See [Test controllers and test agents](configure-test-agents-and-controllers-for-load-tests.md).

The *test controller* spools all collected load test sample data to a database log while the test is running. Additional data, such as timing details and error details, is loaded into the database when the test completes.

|Task|Associated topics|
|----------|-----------------------|
|**Specify how frequently to save logs during a load test run:** You can specify how frequently you want the test log saved when your load test is run.|-   [How to: Specify How Frequently Test Logs are Saved](../test/how-to-specify-how-frequently-test-logs-are-saved.md)|
|**Save logs if a load test fails:** You can specify if you want to save the test log whenever a load test fails.|-   [How to: Specify if Test Failures are Saved to Test Logs](../test/how-to-specify-if-test-failures-are-saved-to-test-logs.md)|
|**Set the maximum file size for the log file:** You can edit the XML configuration file that is associated with the test controller service to specify the maximum file size you want to use for the log file.|[How to: Specify the Maximum Size for the Log File](../test/how-to-specify-the-maximum-size-for-the-log-file.md)|

## Related Tasks

A related property is **Timing Details** Storage. For more information, see  [How to: Configure Collecting Full Details to Enable the Virtual User Activity Chart](../test/how-to-configure-load-tests-to-collect-full-details.md).

## See also

- [Configuring Load Test Run Settings](../test/configure-load-test-run-settings.md)