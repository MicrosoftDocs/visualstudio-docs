---
title: "Load Test Run Settings"
ms.date: 10/19/2016
ms.topic: reference
helpviewer_keywords:
  - "load tests, run settings"
ms.assetid: de10dabb-02ed-403b-9e6f-0b735524988c
author: jillre
ms.author: jillfra
manager: jillfra
---
# Load test run settings properties

The run settings of a load test determine a variety of other settings, including the duration of the test, results collection detail level, and the counter sets that are collected when the test runs. You can create and store multiple run settings for each load test, and then select one particular setting to use when you run the test. An initial run setting is added to your load test when you create your load test using the **New Load Test Wizard**.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

The following tables describe the various properties for load test run settings. You can modify these properties to meet your specific load testing requirements.

For more information, see [Configure load test run settings](../test/configure-load-test-run-settings.md).

## General properties

|Property|Definition|
|-|----------------|
|**Description**|A description of the Run Settings.|
|**Maximum Error per Type**|The maximum number of errors per type to save for the load test.<br /><br /> You can increase this number if you have to, but doing this will also increase the size and processing time of the load test result.|
|**Maximum Request URLs Reported**|The maximum number of unique web performance test request URLs on which to report results in this load test.<br /><br /> You can increase this number if you have to, but doing this will also increase the size and processing time of the load test result.|
|**Maximum Threshold violations**|The maximum number of threshold violations to save for this load test.<br /><br /> You can increase this number if you have to, but doing this will also increase the size and processing time of the load test result.|
|**Run unit tests in application domain**|A Boolean value that determines whether each unit test assembly will run in a separate application domain when the load test contains unit tests. The default setting is True.<br /><br /> If your unit tests do not require a separate application domain or app.config file to function correctly, your unit tests might run faster by setting the value of this property to `False`.|
|**Name**|The name of the Run Setting as it appears in the **Run Settings** node of the **Load Test Editor**.|
|**Validation Level**|This defines the highest level of validation rule that will run in a load test. Validation rules are associated with web performance test requests. Each validation rule has an associated validation level: **High**, **Medium**, or **Low**. This load test run setting will specify which validation rules will run while the web performance test is run in the load test. For example, if this run setting is set to **Medium**, all validation rules marked as **Medium**, or **Low** will be run.|

## Logging properties

|Property|Definition|
|-|----------------|
|**Maximum Test Logs**|Specifies the maximum number of test logs to save for the load test. When the value entered for the maximum number of test logs is reached, the load test will stop collecting logs. Therefore, the logs will be collected at the beginning of the test, not the end. The load test will continue to run until it is completed.|
|**Save Log Frequency for Completed Tests**|Specifies the frequency at which the test log will be written. The number indicates that one out of every entered number of tests will be saved to the test log. For example, entering the value of ten specifies that the tenth, twentieth, thirtieth and so on will be written to the test log. Setting the value to 0 specifies that no test logs will be saved.|
|**Save Log on Test Failure**|A Boolean value that determines whether if test logs are saved if a test fails in a load test. The default is `True`.<br /><br /> For more information, see [How to: Specify if test failures are saved to test logs](../test/how-to-specify-if-test-failures-are-saved-to-test-logs.md)|

For more information, see [Modify load test logging settings](../test/modify-load-test-logging-settings.md).

## Results properties

|Property|Definition|
|-|----------------|
|**Storage Type**|The way to store the performance counters that are obtained in a load test. The options are as follows:<br /><br /> -   **Database** - Requires an SQL database that has a **Load Test Results Store**.<br />-   **None**.|
|**Timing Details Storage**|This is used to determine which details will be stored in the **Load Test Results Store**. Three values are available:<br /><br /> -   **AllIndividualDetails** - Collect and store individual timing values for each test, transaction, and page that was run or issued during the load test in the **Load Test Results Store**. It is required if you intend to use the **Virtual User Activity Chart** in the **Load Test Analyzer**.<br />     For more information, see [Analyze virtual user activity in the Details view](../test/analyze-load-test-virtual-user-activity-in-the-details-view.md).<br />-   **None** - Do not collect any individual timing values. This is the default value for Visual Studio 2013 Update 4 and later releases.<br />-   **StatisticsOnly** - Collect and store only the statistics instead of storing the individual timing values for each test, transaction, and page that was executed or issued during the load test in the **Load Test Results Store**.<br /><br /> For more information, see [How to: Specify the timing details storage property](../test/how-to-specify-the-timing-details-storage-property-for-a-load-test.md).|

## SQL tracing properties

|Property|Definition|
|-|----------------|
|**Minimum Duration of Traced SQL Operations**|The minimum duration of a SQL operation to be captured by the SQL Trace, in milliseconds. For example, this lets you ignore operations that complete quickly if you are trying to find SQL operations that are slow under load.|
|**SQL Tracing Connect String**|The connection string that is used to access the database to be traced.|
|**SQL Tracing Directory**|The location where the SQL Trace file is put after the trace ends. This directory must have write permissions for SQL Server  and read permissions for the controller.|
|**SQL Tracing Enabled**|This enables the tracing of SQL operations. The default value is `False`.|

## Test iterations properties

|Property|Definition|
|-|----------------|
|**Test Iterations**|Specifies the total number of individual tests to run before the load test is complete. This property only applies when the property "Use Test Iterations" is `True`.|
|**Use Test Iterations**|If Use Test Iterations is `True`, then the load test runs until the number of individual tests completed within the load test reaches the number that is specified by the "Test Iterations" property. In this case, the time-based settings, which are Warm up Duration, Run Duration, and Cool-down Duration, are ignored. If "Use Test Iterations" is `False`, all the timing settings apply, and "Test Iterations" is ignored.|

For more information, see [How to: Specify the number of test iterations in a run setting](../test/how-to-specify-the-number-of-test-iterations-in-a-load-test.md).

## Timing properties

|Property|Definition|
|-|----------------|
|**Cool-down Duration**|The duration of the test cool-down period, expressed in hh:mm:ss format. Individual tests within a load test might still be running when the load test finishes. During the cool-down period, those tests can continue until they complete or the end of the cool-down period is reached. By default, there is no cool-down period, and individual tests are terminated when the load test finishes based on the Run Duration setting.|
|**Run Duration**|The length of the test, in hh:mm:ss format.|
|**Sample Rate**|The interval at which to capture performance counter values, in hh:mm:ss format.<br /><br /> For more information, see [How to: Specify the sample rate](../test/how-to-specify-the-sample-rate-for-a-load-test.md).|
|**Warm up Duration**|The period between the beginning of the test and when the data samples start being recorded, in hh:mm:ss format. This is frequently used to step load virtual users to reach a certain load level before recording sample values. The sample values that are captured before the warm-up period ends are shown in the **Load Test Analyzer**.|

## WebTest connections properties

|Property|Definition|
|-|----------------|
|**WebTest Connection Model**|This controls the usage of connections from the load test agent to the web server for web performance tests that run inside a load test. Three web performance test connection model options are available:<br /><br /> -   The **Connection Per User** model simulates the behavior of a user who is using a real browser. When Internet Explorer 6 or Internet Explorer 7 is simulated, each virtual user who is running a web performance test uses one or two dedicated connections to the web server. The first connection is established when the first request in the web performance test is issued. A second connection may be used when a page contains more than one dependent request. These requests are issued in parallel by using the two connections. These connections are reused for subsequent requests in the web performance test. The connections are closed when the web performance test finishes. A drawback to this model is that the number of connections that is held open on the agent computer might be high (up to two times the user load). Consequently, the resources that are required to support this high connection count might limit the user load that can be driven from a single load test agent. When Internet Explorer 8 is simulated, six concurrent connections are supported.<br />-   The **Connection Pool** model conserves the resources on the load test agent by sharing connections to the web server among multiple virtual web performance test users. If the user load is larger than the connection pool size, the web performance tests that are run by different virtual users will share a connection. This could mean that one web performance test might have to wait before it issues a request when another web performance test is using the connection. The average time that a web performance test waits before it submits a request is tracked by the load test performance counter Average Connection Wait Time. This number should be less than the average response time for a page. If it is not, the connection pool size is probably too small.<br />-   The **Connection Per Test Iteration** model specifies the use of dedicated connections for each test iteration.|
|**WebTest Connection Pool Size**|This specifies the maximum number of connections to make between the load test agent and the Web server. This applies only to the **Connection Pool** model.|

## Change run setting properties

You can add more run settings to your load test with different property settings so that you can run the load test under different conditions. For example, you can add a new test setting and use a different sample rate, or specify a longer run duration. You can only use one run setting at a time and you must specify which run setting to use by marking it as active. For an example, see [How to: Select the active run setting for a load test](../test/how-to-select-the-active-run-setting-for-a-load-test.md).

To change run settings:

1. Open a load test.

2. Expand the **Run Settings** folder.

3. Choose a **Run Settings** node.

4. On the **View** menu, choose **Properties Window**.

     The **Properties Window** is displayed and the properties for the selected run setting are displayed.

5. Use the **Properties Window** to change the run settings. For example, change the run duration to **00:05:00** to run your test for five minutes.

    > [!NOTE]
    > For a complete list of the run settings properties and their descriptions, see [Load test run setting properties](../test/load-test-run-settings-properties.md).

6. When you are finished changing properties, save your load test. On the **File** menu, choose **Save**.

> [!NOTE]
> Counter set mappings are also a part of run settings. For more information, see [Specify the counter sets and threshold rules for computers in a load test](../test/specify-counter-sets-and-threshold-rules-for-load-testing.md).

## See also

- [Configure load test run settings](../test/configure-load-test-run-settings.md)