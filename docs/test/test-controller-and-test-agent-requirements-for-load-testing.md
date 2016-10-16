---
title: "Test Controller and Test Agent Requirements for Load Testing"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "agents, requirements"
  - "controllers, requirements"
ms.assetid: 372d97ce-12e4-46a9-9863-da508adba68f
caps.latest.revision: 22
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
# Test Controller and Test Agent Requirements for Load Testing
Several test types including unit, web performance, load, and manual tests are integrated into Visual Studio. [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)] enables [!INCLUDE[vsprvsts](../codequality/includes/vsprvsts_md.md)] users to run tests on remote computers using a test controller and one or more agents. See [Install and configure test agents](../test/install-and-configure-test-agents.md).  
  
## Hardware and Software Requirements  
 Both the test controller and test agent computers have specific hardware and software requirements. In addition, if you want to deploy the test controller and test agent computers across multiple languages, you must plan how to support those languages.  
  
### Hardware Requirements  
 The following table shows the recommended hardware requirements for deploying a test controller and test agents.  
  
|**Configuration**|**Component**|**CPU**|**HD**|**Memory**|  
|-----------------------|-------------------|-------------|------------|----------------|  
|< 500 virtual users|Test agent|2.6 GHz|10 GB|2 GB|  
|< 1000 virtual users|Test agent|Dual processor 2.6 GHz|10 GB|2 GB|  
|N x 1000 virtual users|Test agent|Scale out to N agents each with Dual 2.6 Ghz|10GB|2GB|  
|\< 30 computers in the test environment. This includes agents and servers under test.|Test Controller|2.6 GHz|||  
|N x 30 computers in the test environment. This includes agents and servers under test.|Test Controller|N 2.6 GHz processors|||  
  
> [!NOTE]
>  The number of virtual users will vary widely from test to test. A key cause of this variance is variance in *think times*, or user delays. [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)][Editing Think Times to Simulate Website Human Interaction Delays](../test/editing-think-times-to-simulate-website-human-interaction-delays-in-load-tests-scenarios.md). In a load test, Web tests are generally more efficient and generate more load than unit tests. The numbers in the preceding table are valid for running Web tests with 3-5 second think times on a typical Web application.  
  
 The guidelines presented here are provided as general guidance for hardware planning. Test performance will vary greatly based on the amount of test data and the number of test agents. For test agents, the CPU speed and memory available will limit the test load. Test controllers need greater resources, depending on the number of test agents and the amount of data involved in the tests.  
  
 The server that is running [!INCLUDE[vstsTestEssShort](../test/includes/vststestessshort_md.md)] should have a reliable network connection with a minimum bandwidth of 1 Mbps and a latency maximum of 350ms. There should be no firewall between the test agents and the test controller. If your test performance does not meet your expectations, consider upgrading your hardware configuration.  
  
#### Additional Hardware Considerations  
 Test agents generate a large amount of data on the test controllers, depending on the duration of the test and the size of the test. Generally, you should plan for an additional 10 GB of hard disk storage for every 24 hours of test data.  
  
 In addition to the hardware recommended here, you should consider additional hardware for critical servers, such as redundant power supplies and redundant fans.  
  
### Software Requirements  
 You can use test controllers and test agents with any of the following client editions of Visual Studio:  
  
-   [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
-   Visual Studio Enterprise  
  
 You can also use test agents with [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] and [!INCLUDE[vstsLabLong](../test/includes/vstslablong_md.md)].  
  
 **Operating systems:**  
  
-   [!INCLUDE[win8](../codequality/includes/win8_md.md)]  
  
-   Windows Server 2008 Release 2 or later versions  
  
-   Windows Server 2008 SP2 or later versions  
  
-   Windows Server 2008 Beta  
  
-   Windows 7 Original release or later versions  
  
 **.NET Framework:**  
  
-   Version 4 or later versions  
  
 In addition to the required software listed here, you should consider whether you want to install additional management or security software, such as backup software or firewalls.  
  
### Language Requirements  
 To avoid confusion and simplify operation, a test controller and test agents should be configured to use the same language as the computer's operating system and that of [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)]. If the test agent and test controller are installed on different computers, they must be configured to use the same language. You can, however, install another language version of [!INCLUDE[vstsTestEssShort](../test/includes/vststestessshort_md.md)] on an English-language operating system, as long as that language matches that of the [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] deployment.  
  
## Monitoring Agent Resources  
 You can monitor agent machines to determine their resource needs by observing the **QTAgent\*.exe** processes that execute and scale during tests. The most common bottleneck on the QTAgent*.exe processes is CPU utilization. If the CPU utilization is consistently in the high nineties then it is an indication that the agent is being loaded heavily. The next common bottleneck is the memory usage. For demanding tests, monitoring these resources can help determine if you should increase the machines resources, or distribute your tests differently.  
  
## See Also  
 [Install and configure test agents](../test/install-and-configure-test-agents.md)   
 [Using Test Controllers and Test Agents with Load Tests](../test/using-test-controllers-and-test-agents-with-load-tests.md)