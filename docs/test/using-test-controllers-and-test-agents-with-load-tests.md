---
title: "Using Test Controllers and Test Agents with Load Tests"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, controllers and agents"
ms.assetid: 702d9941-ab98-4eb9-bbfb-7dc8d7cc3269
caps.latest.revision: 33
ms.author: "ahomer"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Using Test Controllers and Test Agents with Load Tests
This topic applies to:  
  
|Visual Studio Enterprise|Visual Studio Professional|Visual Studio Express|  
|------------------------------|--------------------------------|---------------------------|  
|![Topic applies](../test/media/doesapply.gif "DoesApply")|![Topic does not apply](../test/media/doesnotapply.gif "DoesNotApply")|![Topic does not apply](../test/media/doesnotapply.gif "DoesNotApply")|  
  
 You can run load tests by using test controllers and test agents to distribute the load across multiple machines and to simulate multiple virtual users.  
  
 Don’t want to use your resources and set up your own machines to create this load? You can use cloud-based load testing to provide virtual machines in the cloud that generate the load of many users accessing your web site at the same time. All you need is a [Visual Studio Online account](http://go.microsoft.com/fwlink/?LinkId=307137). Learn more about this [cloud-based load testing service](http://go.microsoft.com/fwlink/?LinkID=317257) that provides 15,000 free virtual user minutes of load testing every month.  
  
 To understand the required configurations to load test your app with on-premises resources, follow the information in the rest of this topic.  
  
 **Typical remote configuration:**  
  
-   Machine1 and Machine2: Visual Studio (multiple testers can use the same controller).  
  
-   Machine3: Controller (can have agents installed, too).  
  
-   Machine4-n: Agent or agents all associated with the controller on Machine3.  
  
 ![Remote machines using controller and agents](../test/media/ltest_configb.png "LTest_ConfigB")  
  
 When you run load tests, memory and the processing power of your computer typically control how much load can be generated for the test. The test controller does not generate load, but does collect load test statistics from the test agents and performance counter data from the test agents and system under test. Therefore, the database used by the test controller requires resources both for the amount of data that is stored and the number of test agents involved in running tests. Use the following table as a guide to determine hardware requirements for the test controller and test agent.  
  
|Component|Test Controller Application Tier|Test Controller Data Tier|Test Controller Application/Data Tier|  
|---------------|--------------------------------------|-------------------------------|--------------------------------------------|  
|CPU|Min: 1 GHz<br /><br /> Rec: 2 GHz|Min: 1 GHz<br /><br /> Rec: 2 GHz|Min: 1 GHz<br /><br /> Rec: 2 GHz|  
|Disk – system|Min: 1 GB<br /><br /> Rec: 1 GB|Min: 1 GB<br /><br /> Rec: 1 GB|Min: 1 GB<br /><br /> Rec: 1 GB|  
|Disk - install|Min: 1 GB<br /><br /> Rec: 48 GB|Min: 8 GB<br /><br /> Rec: 48 GB|Min: 8 GB<br /><br /> Rec: 48 GB|  
|Memory|Min: 1 GB<br /><br /> Rec: 1 GB|Min: 1 GB<br /><br /> Rec: 1 GB|Min: 1 GB<br /><br /> Rec: 1 GB|  
  
 To be able to run load tests by using test controllers, you must configure the load test database on the test controller to use an instance of SQL Server to use when you run your load tests. If you do not have SQL Server, you can use SQL Express that is included in Visual Studio Enterprise as your load test store. For more information about how to configure your test controller, see [Install and configure test agents](../test/install-and-configure-test-agents.md).  
  
 Consider the following additional factors when you size the hardware.  
  
|Component|Test agent|Test controller application tier|Test controller data tier|Test controller AT/DT|  
|---------------|----------------|--------------------------------------|-------------------------------|----------------------------|  
|CPU|Depending on the test, the CPU is frequently the limiting factor.|Not heavily used.|Not heavily used.|Not heavily used.|  
|Disk|Heavily used when detailed logging is enabled in your load tests.|Not heavily used.|10 GB space required for 24 hours of test data.|10 GB space required for 24 hours of test data.|  
|Memory|Depending on the test, memory might be the limiting factor.|Not heavily used.|Heavily used by SQL.|Heavily used by SQL.|  
  
 The amount of load that a specific test agent can generate varies widely from test to test. Most tests are bound by the CPU. CPU use is directly proportional to requests per second (RPS). For other load tests, memory is the limiting factor. The RPS you can expect to drive from a load agent depends on many factors. These include the following:  
  
-   User load  
  
-   Think time  
  
-   Authentication scheme  
  
-   Size of requests and responses  
  
-   Response time  
  
-   Level of response validation  
  
-   Test type under load (either Web test or unit test)  
  
 Think time is the primary factor for determining the number of users on a CPU-bound test. Changing think times from 2 seconds to 10 seconds allows you to simulate 5 times more users, but the RPS being generated will be the same. If your goal is to simulate real users, set the think time to a value that reflects how you believe users will behave on your Web site. Increasing think time and the number virtual users will not necessarily place additional stress on your Web application.  
  
 Test agents can be bound by memory on tests that use the Connection Per User connection mode. Two connection modes can be configured in the load test run settings. In Connection Pool mode (the default), connections are pooled, but each user still uses two connections when active. In this mode, all virtual users are multiplexed over the connection pool. This allows you to have 1000 active virtual users who share 100 connections. In Connection Per User mode, each user has a connection that consists of two actual connections open to the server.  
  
 If load testing against a typical ASP.NET application with 3 to 5 second think time using Web tests, you can simulate around 1000 users from a single-processor test agent with a 2 GHz CPU and 1 GB RAM (recommended configuration). The number of users supported is a function of the think time. With longer think times, more users can be supported.  
  
 The server that is running Visual Studio Enterprise should have a reliable network connection with a minimum bandwidth of 1 Mbps and a latency maximum of 350ms. There should be no firewall between the test agents and the test controller. If your test performance does not meet your expectations, consider upgrading your hardware configuration.  
  
## SQL Sizing Considerations  
 By default, SQL Express is installed on the controller and is used by the controller as the default SQL store for load test results. The SQL Express database is license-limited to store 10 GB of data. This is around 24 hours of load test data for a typical load test. The space that is required for load test data varies greatly, depending on the test.  
  
 During a load test, samples are collected for each counter instance on each computer. Therefore, the amount of space that is required in the database depends on the following factors: the number of counters collected, the number of computers involved in the test, and the number of samples taken, as controlled by the sample rate.  
  
 In the run settings for the load test you can collect timing details. This enables the Virtual User Activity Chart. You can also collect detailed virtual user logs.  
  
 A load test run may use one or more diagnostic data adapters to collect information or affect the test machine. These are configured in the test settings for the run. Data from these adapters is also stored in SQL Express and can require a large amount of space depending on the diagnostic data adapter.  
  
 If you can, consider using a separate database to store the load test data. The database can be stored on either the test controller computer or on a different computer. To change the data store, submit the SQL commands that are contained in the .sql file to the instance of SQL server that you want to use for the load test results store. These are two ways to do this. One way is to use the command sqlcmd from a command prompt and specify the options needed to connect to the desired database. Use the –i option to specify the path to loadtestresultsrepository.sql. Another way is to use one of the GUI interfaces to SQL, such as query analyzer, and open the .sql file and submit the connects.  
  
## See Also  
 [Configuring Test Controllers and Test Agents for Load Testing](../test/configuring-test-controllers-and-test-agents-for-load-testing.md)   
 [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md)   
 [Install and configure test agents](../test/install-and-configure-test-agents.md)   
 [Setting Up Test Machines to Run Tests or Collect Data](../test/setting-up-test-machines-to-run-tests-or-collect-data.md)   
 [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md)   
 [Specifying Test Settings for Visual Studio Tests](../test/specifying-test-settings-for-visual-studio-tests.md)   
 [Configuring Test Controllers and Test Agents for Load Testing](../test/configuring-test-controllers-and-test-agents-for-load-testing.md)   
 [How to: Run a Load Test Using Test Controllers and Test Agents Specified in a Test Setting](../test_notintoc/how-to--run-a-load-test-using-test-controllers-and-test-agents-specified-in-a-test-setting.md)   
 [Walkthrough: Using a Test Controller and Test Agents in a Load Test](../test/walkthrough--using-a-test-controller-and-test-agents-in-a-load-test.md)