---
title: "Editing Load Test Scenarios Using the Load Test Editor"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: fec04f2e-bf38-4d44-b2ec-fa50f58fd0d9
caps.latest.revision: 50
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
# Editing Load Test Scenarios Using the Load Test Editor
Load tests contain scenarios, which contain Web performance tests or unit tests. A *scenario* is the container within a load test where you specify load pattern, test mix, browser mix, and network mix. Scenarios are important because they give you flexibility in configuring test characteristics that allow for simulation of complex, realistic workloads.  
  
 For example, you might be testing an e-commerce site that has an Internet front-end used by hundreds of concurrent customers coming in over many connection speeds and using different browsers. The same site might also have an administration function that is used by internal employees to update products and to view statistics. These internal users would typically access the site by using the same browser and a high-speed LAN connection. You would want to encapsulate the properties of these two different groups of users in different scenarios. Each scenario can contain a virtual user type. In this case, a load test scenario can be made to represent virtual customers and another scenario can be made to represent virtual internal users of a Web site.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 **Scenarios That Are Created in the New Load Test Wizard**  
  
 Any initial configuration options and settings that you specified in the New Load Test Wizard for the scenario when you created a load test can be modified in the Load Test Editor after the wizard is finished. The Load Test Editor lets you modify the properties of an existing scenario or add new scenarios to the load test. Additionally, you can also add more counter sets and run settings.  
  
 Scenarios contain the following components:  
  
|||  
|-|-|  
|Term|Definition|  
|Browser Mix|Simulates that virtual users examine a Web site through a variety of Web browsers, in addition to Internet Explorer.|  
|Load Pattern|Specifies the number of virtual users active during a load test and the rate at which new users are started. For example: step, constant, and goal-based.|  
|Test Mix Model|Specifies the probability of a virtual user running a given test in a load test scenario. For example: 20% chance to run TestA and 80% chance to run TestB.<br /><br /> The test mix model should reflect the objectives of your test for a particular scenario.|  
|Test Mix|The test mix is the selection of Web performance and unit tests that are contained within the scenario and the distribution of those tests within the scenario.|  
|Network Mix|Simulates that virtual users examine a Web site through a variety of network connections. The Network Mix offers options that include LAN, cable modem, and other options.|  
|Counter Sets|When you create a load test with the New Load Test Wizard, you add an initial set of counters. These offer you a set of predefined and important counter sets for your load test. You manage your counters in the Load Test Editor.<br /><br /> Load tests provide named counter sets that are useful when you analyze performance counter data. The counter sets are organized by technology and include Load Test, IIS, ASP.NET, and SQL. Counter sets can be selected for the computers that you specify for inclusion in the load test scenario.|  
  
 ![Load Test Scenarios](../dv_TeamTestALM/media/LoadTestEditinScenarios.png "LoadTestEditinScenarios")  
Load Test Scenarios  
  
 In addition, a scenario has several other properties that you can edit by using the Load Test Editor. For more information, see [Load Test Scenario Properties](../dv_TeamTestALM/Load-Test-Scenario-Properties.md).  
  
## Tasks  
  
|Tasks|Associated Topics|  
|-----------|-----------------------|  
|**Create and edit load test scenarios:** Load tests contain one or more scenarios, which are used to model how a group of users interacts with a server application. An individual scenario consists of a load pattern, a test mix, a browser mix, and a network mix. Each of these settings corresponds to a page in the New Load Test Wizard. See  [Create and run a load test](https://www.visualstudio.com/docs/test/performance-testing/run-performance-tests-app-before-release).|-   [Q: Can a load test have more than one scenario?](https://www.visualstudio.com/docs/test/performance-testing/run-performance-tests-app-before-release#CreateRunLoadTest_QA_AddScenarios)<br />-   [Load Test Scenario Properties](../dv_TeamTestALM/Load-Test-Scenario-Properties.md)|  
|**Add artificial human interaction pauses in your scenario:** Think times are used to simulate human behavior that causes people to wait between interactions with a Web site. Think times occur between requests in a Web performance test and between test iterations in a load test scenario. Using think times in a load test can be useful in creating more accurate load simulations.|-   [Editing Think Times to Simulate Website Human Interaction Delays](../dv_TeamTestALM/Editing-Think-Times-to-Simulate-Website-Human-Interaction-Delays-in-Load-Tests-Scenarios.md)|  
|**Specify the number of virtual users for your scenario:** You can configure the load pattern properties to specify how the simulated user load is adjusted during a load test. You get three built-in load patterns: constant, step, and goal-based. You choose the load pattern and adjust the properties to appropriate levels for your load test goals.|-   [Editing Load Patterns to Model Virtual User Activities](../dv_TeamTestALM/Editing-Load-Patterns-to-Model-Virtual-User-Activities.md)|  
|**Configure the probability of a virtual user running a test in the scenario:** You can use the test mix, which specifies the probability of a virtual user running a given test in a load test scenario. This lets you simulate load more realistically. Instead of having just one workflow through your applications, you can have several workflows, which is a closer approximation of how end-users interact with your applications.|-   [Editing Text Mix Models to Specify the Probability of a Virtual User Running a Test](../dv_TeamTestALM/Editing-Text-Mix-Models-to-Specify-the-Probability-of-a-Virtual-User-Running-a-Test.md)|  
|**Add or remove a Web performance or unit test to a load test scenario:** You can add or remove a Web performance or unit test from a load test in a scenario. A load test contains one or more scenarios, each of which contains one or more Web performance or unit tests.|-   [Editing the Test Mix to Specify Which Tests to Include in a Load Test Scenario](../dv_TeamTestALM/Editing-the-Test-Mix-to-Specify-Which-Web-Performance--Unit-and-Coded-UI-Tests-to-Include-in-a-Load-Test-Scenario.md)<br />-   [About the Mix Control](../dv_TeamTestALM/Editing-the-Test-Mix-to-Specify-Which-Web-Performance--Unit-and-Coded-UI-Tests-to-Include-in-a-Load-Test-Scenario.md#EditingTestMixAboutMixControl)|  
|**Configure the desired network mix for your scenario:** Using the network mix, you can simulate network load more realistically in a load test scenario. Load is generated by using a heterogeneous mix of network types instead of one single network type. You create a closer approximation of how end-users interact with your applications. The network mix model should reflect the objectives of that scenario.|-   [Specifying Virtual Network Types](../dv_TeamTestALM/Specifying-Virtual-Network-Types-in-a-Load-Test-Scenario.md)|  
|**Select the appropriate Web browser mix for your scenario:** Using the browser mix, you can simulate Web load more realistically in a load test scenario. Load is generated by using a heterogeneous mix of browsers instead of one single browser. You create a closer approximation of the browsers that will be used with your applications.|-   [Specifying Web Browsers Types](../dv_TeamTestALM/Editing-the-Test-Mix-to-Specify-Which-Web-Browsers-Types-in-a-Load-Test-Scenario.md)|  
|**Configure test iteration settings for your scenario:** You can edit a load test scenario to configure test iteration settings using the Load Test Editor and the Properties window. By default, a scenario is set up with no maximum test iterations. You can optionally configure the maximum number of iterations in the scenario and how long to pause between them.|-   [Configuring Test Iterations for Scenarios](../dv_TeamTestALM/Configuring-Test-Iterations-in-a-Load-Test-Scenario.md)|  
|**Configure delay settings for your scenario:** Using the Load Test Editor and the Properties window, you can specify a delay before starting a scenario in a load test.<br /><br /> An example of when you might want to use the **Delay Start Time** property is if you need one scenario to start producing items that another scenario consumes. You can delay the consuming scenario to enable the producing scenario to populate some data.|-   [Configuring Scenario Start Delays](../dv_TeamTestALM/Configuring-Scenario-Start-Delays.md)|  
|**Specify remote machines to use in a load test scenario:** After you create a load test, you can edit the properties of your load test scenario to indicate which test agents you want to include.<br /><br /> For more information, see [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../dv_TeamTestALM/Distributing-Load-Test-Runs-Across-Multiple-Test-Machines-Using-Test-Controllers-and-Test-Agents.md).|-   [How to: Specify Test Agents to Use](../dv_TeamTestALM/How-to--Specify-Test-Agents-to-Use-in-Load-Test-Scenarios.md)|  
  
## Related Tasks  
 [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../dv_TeamTestALM/Specifying-the-Counter-Sets-and-Threshold-Rules-for-Computers-in-a-Load-Test.md)  
  
 Load tests provide named counter sets, organized by technology, that are useful when you analyze performance counter data. The counter sets include Load Test, IIS, ASP.NET, and SQL. When you create a load test with the New Load Test Wizard, an initial set of predefined and important counter set are configured by default for the computers you specify to include in the load test. You manage your counters in the Load Test Editor.  
  
 [Configuring Load Test Run Settings](../dv_TeamTestALM/Configuring-Load-Test-Run-Settings.md)  
  
 Run settings are a set of properties that influence the way a load test runs. Run settings are organized by categories in the Properties window.  
  
 [Q: I’m having some performance issues with SQL data used in my test, can I debug this?](https://www.visualstudio.com/docs/test/performance-testing/run-performance-tests-app-before-release#CreateRunLoadTest_QA_SQLTracing)  
  
 You can use the SQL tracing tool in your load tests to help you monitor and improve the performance of your Web applications that use SQL Server to store data.  
  
 [Create and run a load test](https://www.visualstudio.com/docs/test/performance-testing/run-performance-tests-app-before-release)  
  
 You can configure the test setting that you are using with your load test to specify that you want to use 64-bit processes.  
  
 [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../dv_TeamTestALM/Distributing-Load-Test-Runs-Across-Multiple-Test-Machines-Using-Test-Controllers-and-Test-Agents.md)  
  
 You can use a group of computers to generate simulated load for testing, and to run tests remotely and concurrently on several computers.  
  
 [Performance test your app before release](../dv_TeamTestALM/Performance-test-your-app-before-release.md)  
  
 After you are done editing your load test, you can run it to verify that it is functioning correctly. You can continue the cycle of editing that load test and running it until the load test performs correctly.  
  
## See Also  
 [Load Test Analyzer Overview](../dv_TeamTestALM/Load-Test-Analyzer-Overview.md)   
 [Editing Load Test](../dv_TeamTestALM/Editing-Load-Test-Using-the-Load-Test-Editor.md)   
 [Load Test Scenario Properties](../dv_TeamTestALM/Load-Test-Scenario-Properties.md)   
 [Q and A](assetId:///7041cbcf-9ab1-4579-98ff-8f296aeaded4#CreateRunLoadTest_QA)