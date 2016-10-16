---
title: "Configuring Test Controllers and Test Agents for Load Testing"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, test controllers"
  - "load tests, test agents"
  - "load tests, test controller and agents, configuring"
  - "test agents"
  - "test controllers"
ms.assetid: 272e6e8d-46ae-47fb-9979-d59953fd7248
caps.latest.revision: 110
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
# Configuring Test Controllers and Test Agents for Load Testing
Visual Studio Enterprise can generate simulated load for your app by using physical or virtual machines. These machines must be set up as a single test controller and one or more test agents. You can use the test controller and test agents to generate more load than a single computer can generate alone.  
  
 Don’t want to use your resources and set up your own machines to create this load? You can use cloud-based load testing to provide virtual machines in the cloud that generate the load of many users accessing your web site at the same time. All you need is a [Visual Studio Team Services account](http://go.microsoft.com/fwlink/?LinkId=307137). Learn more about this [cloud-based load testing service](http://go.microsoft.com/fwlink/?LinkID=317257) that provides 15,000 free virtual user minutes of load testing every month.  
  
 If you do want to load test your app with on-premises resources, follow the instructions in this topic.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
## Load Simulation Architecture  
 The load simulation architecture consists of a Visual Studio client, test controller, and test agents.  
  
-   The client is used to develop tests, run tests, and view test results.  
  
-   The test controller is used to administer the test agents and collect test results.  
  
-   The test agents are used to run the tests, and collect data including system information and ASP.NET profiling data defined in the test setting.  
  
 This architecture provides the following benefits:  
  
-   The ability to scale out load generation by adding additional test agents to a test controller.  
  
-   Flexibility for installing the client, test controller, and test agent software on the same or different computers. For example:  
  
     **Local configuration:**  
  
    -   Machine1: Visual Studio, controller, agent.  
  
     ![Local machine using controller and agent](../test/media/ltest_configa.png "LTest_ConfigA")  
  
     **Typical remote configuration:**  
  
    -   Machine1 and 2: Visual Studio (multiple testers can use the same controller).  
  
    -   Machine3: Controller (can have agents installed, too).  
  
    -   Machine4-n: Agent or agents all associated with the controller on Machine3.  
  
     ![Remote machines using controller and agents](../test/media/ltest_configb.png "LTest_ConfigB")  
  
 Even though a test controller typically manages several test agents, an agent can only be associated with a single controller. Each test agent can be shared by a team of developers. This architecture makes it easy to increase the number of test agents, thereby generating larger loads.  
  
## Test Agent and Test Controller Interaction  
 The test controller manages a set of test agents to run tests. The test controller communicates with test agents to start tests, stop tests, track test agent status, and collect test results.  
  
### Test Controller  
 The test controller provides a general architecture for running tests, and includes special features for running load tests. The test controller sends the load test to all test agents and waits until all the test agents have initialized the test. When all test agents are ready, the test controller sends a message to the test agents to start the test.  
  
### Test Agent  
 The test agent runs as a service that listens for requests from the test controller to start a new test. When the test agent receives a request, the test agent service starts a process on which to run the tests. Each test agent runs the same load test.  
  
 Test agents are assigned a weight by the administrator, and load is distributed according to a test agent’s weighting. For example, if test agent 1 has a weighting of 30, and test agent 2 has a weighting of 70, and the load is set to 1000 users, then test agent 1 simulates 300 virtual users whereas test agent 2 simulates 700 virtual users. See [Managing Test Controllers and Test Agents with Visual Studio](../test/managing-test-controllers-and-test-agents-with-visual-studio.md).  
  
 The test agent takes a set of tests and a set of simulation parameters as input. A key concept is that tests are independent of the computer where they're run.  
  
## Test Controller and Test Agent Connection Points  
 The following illustration shows the connection points between the test controller, the test agent, and the client. It outlines which ports are used for incoming and outgoing connections as well as security restrictions used on these ports.  
  
 ![Test contoller and test agent ports and security](../test/media/testcontrolleragentfirewall.png "TestControllerAgentFirewall")  
  
 For more information see [Configuring Ports for Test Controllers and Test Agents](../test/configuring-ports-for-test-controllers-and-test-agents.md).  
  
## Test Controller and Agent Installation Information  
 For important information about hardware and software requirements for test controllers and test agents, the procedures for installing them, and configuring your environment for optimal performance, see [Install and configure test agents](../test/install-and-configure-test-agents.md) and [Test Controller and Test Agent Requirements for Load Testing](../test/test-controller-and-test-agent-requirements-for-load-testing.md).  
  
## Using the Test Controller and Test Agent with Unit Tests  
 After you have installed a test controller and one or more agents, you can specify whether to use a remote execution with the test controller in the test setting for your load tests. Additionally, you can specify the data and diagnostic adapters to use with the role that is associated with the agents in the test setting. For more information, see [How to: Create a Test Setting for a Distributed Load Test](../test/how-to--create-a-test-setting-for-a-distributed-load-test.md) and [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md).  
  
## See Also  
 [How to: Run a Load Test Using Test Controllers and Test Agents Specified in a Test Setting](../test_notintoc/how-to--run-a-load-test-using-test-controllers-and-test-agents-specified-in-a-test-setting.md)   
 [How to: Run a Test Using Test Controllers and Test Agents](../test/how-to--run-a-test-using-test-controllers-and-test-agents.md)   
 [Web performance and load tests in Visual Studio](../test_notintoc/web-performance-and-load-tests-in-visual-studio.md)   
 [Running Load and Web Performance Tests](assetId:///a4fd686e-69ec-485d-a335-acf12348aa30)   
 [Walkthrough: Using a Test Controller and Test Agents in a Load Test](../test/walkthrough--using-a-test-controller-and-test-agents-in-a-load-test.md)   
 [How to: Create a Test Setting for a Distributed Load Test](../test/how-to--create-a-test-setting-for-a-distributed-load-test.md)   
 [How to: Access Load Test Results for Analysis](../test/how-to--access-load-test-results-for-analysis.md)   
 [Test Controller and Test Agent Requirements for Load Testing](../test/test-controller-and-test-agent-requirements-for-load-testing.md)