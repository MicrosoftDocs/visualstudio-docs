---
title: "Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6e67a587-8aad-48cc-a8c0-6d4b399f3731
caps.latest.revision: 41
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
# Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents
Visual Studio Enterprise can use physical or virtual machines to generate simulated load for your app. These machines must be set up as a single test controller and one or more test agents. You can use the test controller and test agents to generate more load than a single computer can generate alone.  
  
 Don’t want to use your resources and set up your own machines to create this load? You can use cloud-based load testing to provide virtual machines in the cloud that generate the load of many users accessing your web site at the same time. All you need is a [Visual Studio Team Services account](http://go.microsoft.com/fwlink/?LinkId=307137). Learn more about this [cloud-based load testing service](http://go.microsoft.com/fwlink/?LinkID=317257) that provides 20,000 free virtual user minutes of load testing every month.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
## Tasks for On-Premises Test Controllers and Test Agents  
  
|Tasks|Associated topics|  
|-----------|-----------------------|  
|**Configure test agents and controllers:** You can use test controllers and test agents to configure tests to run remotely on one or more computers.|-   [Configuring Test Controllers and Test Agents for Load Testing](../dv_TeamTestALM/Configuring-Test-Controllers-and-Test-Agents-for-Load-Testing.md)<br />-   [Install and configure test agents](../dv_TeamTestALM/Install-and-configure-test-agents.md)<br />-   [Walkthrough: Using a Test Controller and Test Agents in a Load Test](../dv_TeamTestALM/Walkthrough--Using-a-Test-Controller-and-Test-Agents-in-a-Load-Test.md)<br />-   [Test Controller and Test Agent Requirements for Load Testing](../dv_TeamTestALM/Test-Controller-and-Test-Agent-Requirements-for-Load-Testing.md)|  
|**Create and select a test setting that uses test controllers and agents:** After you install and configure test controllers and test agents, you must create a new test setting that uses the test controller and test agents to run your load test in a distributed environment.|-   [How to: Create a Test Setting for a Distributed Load Test](../dv_TeamTestALM/How-to--Create-a-Test-Setting-for-a-Distributed-Load-Test.md)|  
|**Troubleshooting test controllers and test agents:** If you encounter issues while you are using test controllers and test agents in your load test, you can review the troubleshooting material covered in the documentation.|-   [Strategies for Troubleshooting Test Controllers and Test Agents in Load Tests](../dv_TeamTestALM/Strategies-for-Troubleshooting-Test-Controllers-and-Test-Agents-in-Load-Tests.md)|  
|**Running a load test using test controller and tests agents:** After you have created a test setting that uses a controller and one or more agents, you can configure Visual Studio to use the test setting and run your load test.|-   [How to: Run a Load Test Using Test Controllers and Test Agents Specified in a Test Setting](../Topic/How%20to:%20Run%20a%20Load%20Test%20Using%20Test%20Controllers%20and%20Test%20Agents%20Specified%20in%20a%20Test%20Setting.md)|  
  
## External resources  
  
### Guidance  
 [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 6: A Testing Toolbox](http://go.microsoft.com/fwlink/?LinkID=255203)  
  
## See Also  
 [Performance test your app before release](../dv_TeamTestALM/Performance-test-your-app-before-release.md)   
 [Install and configure test agents](../dv_TeamTestALM/Install-and-configure-test-agents.md)   
 [Walkthrough: Using a Test Controller and Test Agents in a Load Test](../dv_TeamTestALM/Walkthrough--Using-a-Test-Controller-and-Test-Agents-in-a-Load-Test.md)