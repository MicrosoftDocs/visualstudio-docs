---
title: "Load Test Run Settings Properties"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: de10dabb-02ed-403b-9e6f-0b735524988c
caps.latest.revision: 35
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Load Test Run Settings Properties
The run settings of a load test determine a variety of other settings, including the duration of the test, results collection detail level, and the counter sets that are collected when the test runs. You can create and store multiple run settings for each load test, and then select one particular setting to use when you run the test. An initial run setting is added to your load test when you create your load test using the New Load Test Wizard. For more information, see [Create and run a load test](assetId:///7041cbcf-9ab1-4579-98ff-8f296aeaded4).  
  
 The following tables describe the various properties for load test run settings. You can modify these properties to meet your specific load testing requirements.  
  
 For more information, see [Load Test Analyzer Overview](../dv_TeamTestALM/Load-Test-Analyzer-Overview.md) and [Configuring Load Test Run Settings](../dv_TeamTestALM/Configuring-Load-Test-Run-Settings.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 **In this topic:**  
  
-   [General Properties](../dv_TeamTestALM/Load-Test-Run-Settings-Properties.md#LoadTestRunSettingProperties_General)  
  
-   [Logging Properties](../dv_TeamTestALM/Load-Test-Run-Settings-Properties.md#LoadTestRunSettingProperties_Logging)  
  
-   [Results Properties](../dv_TeamTestALM/Load-Test-Run-Settings-Properties.md#LoadTestRunSettingProperties_Results)  
  
-   [SQL Tracing Properties](../dv_TeamTestALM/Load-Test-Run-Settings-Properties.md#LoadTestRunSettingProperties_SQLTracing)  
  
-   [Test Iterations Properties](../dv_TeamTestALM/Load-Test-Run-Settings-Properties.md#LoadTestRunSettingProperties_TestIterations)  
  
-   [Timing Properties](../dv_TeamTestALM/Load-Test-Run-Settings-Properties.md#LoadTestRunSettingProperties_Timing)  
  
-   [WebTest Connections Properties](../dv_TeamTestALM/Load-Test-Run-Settings-Properties.md#LoadTestRunSettingProperties_WebTestConnections)  
  
-   [Changing Run Setting Properties](../dv_TeamTestALM/Load-Test-Run-Settings-Properties.md#LoadTestRunSettingsHowToChange)  
  
##  <a name="LoadTestRunSettingProperties_General"></a> General Properties  
  
|Property|Definition|  
|--------------|----------------|  
|**Description**|A description of the Run Settings.|  
|**Maximum Error per Type**|The maximum number of errors per type to save for the load test.<br /><br /> You can increase this number if you have to, but doing this will also increase the size and processing time of the load test result.|  
|**Maximum Request URLs Reported**|The maximum number of unique Web performance test request URLs on which to report results in this load test.<br /><br /> You can increase this number if you have to, but doing this will also increase the size and processing time of the load test result.|  
|**Maximum Threshold violations**|The maximum number of threshold violations to save for this load test.<br /><br /> You can increase this number if you have to, but doing this will also increase the size and processing time of the load test result.|  
|**Run unit tests in application domain**|A Boolean value that determines whether each unit test assembly will run in a separate application domain when the load test contains unit tests. The default setting is True.<br /><br /> If your unit tests do not require a separate application domain or app.config file to function correctly, your unit tests might run faster by setting the value of this property to `False`.|  
|**Name**|The name of the Run Setting as it appears in the **Run Settings** node of the **Load Test Editor**.|  
|**Validation Level**|This defines the highest level of validation rule that will run in a load test. Validation rules are associated with Web performance test requests. Each validation rule has an associated validation level: **High**, **Medium**, or **Low**. This load test run setting will specify which validation rules will run while the Web performance test is run in the load test. For example, if this run setting is set to **Medium**, all validation rules marked as **Medium**, or **Low** will be run.|  
  
##  <a name="LoadTestRunSettingProperties_Logging"></a> Logging Properties  
  
|Property|Definition|  
|--------------|----------------|  
|**Maximum Test Logs**|Specifies the maximum number of test logs to save for the load test. When the value entered for the maximum number of test logs is reached, the load test will stop collecting logs. Therefore, the logs will be collected at the beginning of the test, not the end. The load test will continue to run until it is completed.|  
|**Save Log Frequency for Completed Tests**|Specifies the frequency at which the test log will be written. The number indicates that one out of every entered number of tests will be saved to the test log. For example, entering the value of ten specifies that the tenth, twentieth, thirtieth and so on will be written to the test log. Setting the value to 0 specifies that no test logs will be saved.<br /><br /> For more information, see [How to: Specify How Frequently Test Logs are Saved](../dv_TeamTestALM/How-to--Specify-How-Frequently-Test-Logs-are-Saved-Using-the-Load-Test-Editor.md)|  
|**Save Log on Test Failure**|A Boolean value that determines whether if test logs are saved if a test fails in a load test. The default is `True`.<br /><br /> For more information, see [How to: Specify if Test Failures are Saved to Test Logs](../dv_TeamTestALM/How-to--Specify-if-Test-Failures-are-Saved-to-Test-Logs-Using-the-Load-Test-Editor.md)|  
  
 For more information, see [Modifying Load Test Logging Settings](../dv_TeamTestALM/Modifying-Load-Test-Logging-Settings.md).  
  
##  <a name="LoadTestRunSettingProperties_Results"></a> Results Properties  
  
|Property|Definition|  
|--------------|----------------|  
|**Storage Type**|The way to store the performance counters that are obtained in a load test. The options are as follows:<br /><br /> -   **Database** - Requires an SQL database that has a **Load Test Results Store**.<br />-   **None**.|  
|**Timing Details Storage**|This is used to determine which details will be stored in the **Load Test Results Store**. Three values are available:<br /><br /> -   **AllIndividualDetails** - Collect and store individual timing values for each test, transaction, and page that was run or issued during the load test in the **Load Test Results Store**. It is required if you intend to use the Virtual User Activity chart in the Load Test Analyzer.<br />     For more information, see [Analyzing Virtual User Activity in the Details View](../dv_TeamTestALM/Analyzing-Load-Test-Virtual-User-Activity-in-the-Details-View-of-the-Load-Test-Analyzer.md).<br />-   **None** - Do not collect any individual timing values. This is the default value for Visual Studio 2013 Update 4 and later releases.<br />-   **StatisticsOnly** - Collect and store only the statistics instead of storing the individual timing values for each test, transaction, and page that was executed or issued during the load test in the **Load Test Results Store**.<br /><br /> For more information, see [How to: Specify the Timing Details Storage Property](../dv_TeamTestALM/How-to--Specify-the-Timing-Details-Storage-Property-for-a-Load-Test-Run-Setting.md).|  
  
##  <a name="LoadTestRunSettingProperties_SQLTracing"></a> SQL Tracing Properties  
  
|Property|Definition|  
|--------------|----------------|  
|**Minimum Duration of Traced SQL Operations**|The minimum duration of a SQL operation to be captured by the SQL Trace, in milliseconds. For example, this lets you ignore operations that complete quickly if you are trying to find SQL operations that are slow under load.|  
|**SQL Tracing Connect String**|The connection string that is used to access the database to be traced.|  
|**SQL Tracing Directory**|The location where the SQL Trace file is put after the trace ends. This directory must have write permissions for SQL Server and read permissions for the controller.|  
|**SQL Tracing Enabled**|This enables the tracing of SQL operations. The default value is `False`.|  
  
 For more information, see [Q: I’m having some performance issues with SQL data used in my test, can I debug this?](assetId:///7041cbcf-9ab1-4579-98ff-8f296aeaded4#CreateRunLoadTest_QA_SQLTracing).  
  
##  <a name="LoadTestRunSettingProperties_TestIterations"></a> Test Iterations Properties  
  
|Property|Definition|  
|--------------|----------------|  
|**Test Iterations**|Specifies the total number of individual tests to run before the load test is complete. This property only applies when the property "Use Test Iterations" is `True`.|  
|**Use Test Iterations**|If Use Test Iterations is `True`, then the load test runs until the number of individual tests completed within the load test reaches the number that is specified by the "Test Iterations" property. In this case, the time-based settings, which are Warm up Duration, Run Duration, and Cool-down Duration, are ignored. If "Use Test Iterations" is `False`, all the timing settings apply, and "Test Iterations" is ignored.|  
  
 For more information, see [How to: Specify the Number of Test Iterations in a Run Setting](../dv_TeamTestALM/How-to--Specify-the-Number-of-Test-Iterations-in-a-Load-Test-Run-Setting.md).  
  
##  <a name="LoadTestRunSettingProperties_Timing"></a> Timing Properties  
  
|Property|Definition|  
|--------------|----------------|  
|**Cool-down Duration**|The duration of the test cool-down period, expressed in hh:mm:ss format. Individual tests within a load test might still be running when the load test finishes. During the cool-down period, those tests can continue until they complete or the end of the cool-down period is reached. By default, there is no cool-down period, and individual tests are terminated when the load test finishes based on the Run Duration setting.|  
|**Run Duration**|The length of the test, in hh:mm:ss format.|  
|**Sample Rate**|The interval at which to capture performance counter values, in hh:mm:ss format.<br /><br /> For more information, see [How to: Specify the Sample Rate](../dv_TeamTestALM/How-to--Specify-the-Sample-Rate-for-a-Load-Test-Run-Setting.md).|  
|**Warm up Duration**|The period between the beginning of the test and when the data samples start being recorded, in hh:mm:ss format. This is frequently used to step load virtual users to reach a certain load level before recording sample values. The sample values that are captured before the warm-up period ends are shown in the **Load Test Analyzer**.|  
  
##  <a name="LoadTestRunSettingProperties_WebTestConnections"></a> WebTest Connections Properties  
  
|Property|Definition|  
|--------------|----------------|  
|**WebTest Connection Model**|This controls the usage of connections from the load test agent to the Web server for Web performance tests that run inside a load test. Three Web performance test connection model options are available:<br /><br /> -   The **Connection Per User** model simulates the behavior of a user who is using a real browser. When Internet Explorer 6 or Internet Explorer 7 is simulated, each virtual user who is running a Web performance test uses one or two dedicated connections to the Web server. The first connection is established when the first request in the Web performance test is issued. A second connection may be used when a page contains more than one dependent request. These requests are issued in parallel by using the two connections. These connections are reused for subsequent requests in the Web performance test. The connections are closed when the Web performance test finishes. A drawback to this model is that the number of connections that is held open on the agent computer might be high (up to two times the user load). Consequently, the resources that are required to support this high connection count might limit the user load that can be driven from a single load test agent. When Internet Explorer 8 is simulated, six concurrent connections are supported.<br />-   The **Connection Pool** model conserves the resources on the load test agent by sharing connections to the Web server among multiple virtual Web performance test users. If the user load is larger than the connection pool size, the Web performance tests that are run by different virtual users will share a connection. This could mean that one Web performance test might have to wait before it issues a request when another Web performance test is using the connection. The average time that a Web performance test waits before it submits a request is tracked by the load test performance counter Average Connection Wait Time. This number should be less than the average response time for a page. If it is not, the connection pool size is probably too small.<br />-   The **Connection Per Test Iteration** model specifies the use of dedicated connections for each test iteration.|  
|**WebTest Connection Pool Size**|This specifies the maximum number of connections to make between the load test agent and the Web server. This applies only to the **Connection Pool** model.|  
  
##  <a name="LoadTestRunSettingsHowToChange"></a> Changing Run Setting Properties  
 You can add more run settings to your load test with different property settings so that you can run the load test under different conditions. For example, you can add a new test setting and use a different sample rate, or specify a longer run duration. You can only use one run setting at a time and you must specify which run setting to use by marking it as active. For an example, see [How to: Select the Active Run Setting for a Load Test](../dv_TeamTestALM/How-to--Select-the-Active-Run-Setting-for-a-Load-Test.md).  
  
#### To change run settings  
  
1.  Open a load test.  
  
2.  Expand the **Run Settings** folder.  
  
3.  Choose a **Run Settings** node.  
  
4.  On the **View** menu, choose **Properties Window**.  
  
     The **Properties Window** is displayed and the properties for the selected run setting are displayed.  
  
5.  Use the **Properties Window** to change the run settings. For example, change the run duration to **00:05:00** to run your test for five minutes.  
  
    > [!NOTE]
    >  For a complete list of the run settings properties and their descriptions, see [Load Test Run Setting Properties](../dv_TeamTestALM/Load-Test-Run-Settings-Properties.md).  
  
6.  When you are finished changing properties, save your load test. On the **File** menu, choose **Save**.  
  
> [!NOTE]
>  Counter set mappings are also a part of run settings. For more information, see [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../dv_TeamTestALM/Specifying-the-Counter-Sets-and-Threshold-Rules-for-Computers-in-a-Load-Test.md).  
  
## See Also  
 [Configuring Load Test Run Settings](../dv_TeamTestALM/Configuring-Load-Test-Run-Settings.md)   
 [Create and run a load test](assetId:///7041cbcf-9ab1-4579-98ff-8f296aeaded4)