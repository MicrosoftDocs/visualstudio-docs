---
title: "Test controller/test agent requirements (load testing)"
description: Learn about test controller and test agent requirements for load testing. Visual Studio supports several test types.
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
- agents, requirements
- controllers, requirements
ms.assetid: 372d97ce-12e4-46a9-9863-da508adba68f
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# Test controller and test agent requirements for load testing

Several test types including unit, web performance, load, and manual tests are integrated into Visual Studio. Visual Studio enables Visual Studio Application Lifecycle Management users to run tests on remote computers using a test controller and one or more agents. See [Install and configure test agents](../test/lab-management/install-configure-test-agents.md).

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## Hardware and software requirements

Both the test controller and test agent computers have specific hardware and software requirements. In addition, if you want to deploy the test controller and test agent computers across multiple languages, you must plan how to support those languages.

### Hardware requirements

The following table shows the recommended hardware requirements for deploying a test controller and test agents.

|**Configuration**|**Component**|**CPU**|**HD**|**Memory**|
|-|-------------------|-|------------|-|
|< 500 virtual users|Test agent|2.6 GHz|10 GB|2 GB|
|< 1000 virtual users|Test agent|Dual processor 2.6 GHz|10 GB|2 GB|
|N x 1000 virtual users|Test agent|Scale out to N agents each with Dual 2.6 Ghz|10GB|2GB|
|\< 30 computers in the test environment. This includes agents and servers under test.|Test Controller|2.6 GHz|||
|N x 30 computers in the test environment. This includes agents and servers under test.|Test Controller|N 2.6 GHz processors|||

> [!NOTE]
> The number of virtual users will vary widely from test to test. A key cause of this variance is variance in *think times*, or user delays. For more information, see [Edit think times to simulate website human interaction delays](../test/edit-think-times-in-load-test-scenarios.md). In a load test, web tests are generally more efficient and generate more load than unit tests. The numbers in the preceding table are valid for running web tests with 3-5 second think times on a typical web application.

The guidelines presented here are provided as general guidance for hardware planning. Test performance will vary greatly based on the amount of test data and the number of test agents. For test agents, the CPU speed and memory available will limit the test load. Test controllers need greater resources, depending on the number of test agents and the amount of data involved in the tests.

The server that is running Visual Studio should have a reliable network connection with a minimum bandwidth of 1 Mbps and a latency maximum of 350ms. There should be no firewall between the test agents and the test controller. If your test performance does not meet your expectations, consider upgrading your hardware configuration.

### Additional hardware considerations

Test agents generate a large amount of data on the test controllers, depending on the duration of the test and the size of the test. Generally, you should plan for an additional 10 GB of hard disk storage for every 24 hours of test data.

In addition to the hardware recommended here, you should consider additional hardware for critical servers, such as redundant power supplies and redundant fans.

### Language requirements

To avoid confusion and simplify operation, a test controller and test agents should be configured to use the same language as the computer's operating system and that of Team Foundation Server. If the test agent and test controller are installed on different computers, they must be configured to use the same language. You can, however, install another language version of Visual Studio on an English-language operating system, as long as that language matches that of the Team Foundation Server deployment.

## Monitor agent resources

You can monitor agent machines to determine their resource needs by observing the *QTAgent\*.exe* processes that execute and scale during tests. The most common bottleneck on the *QTAgent\*.exe* processes is CPU utilization. If the CPU utilization is consistently in the high nineties then it is an indication that the agent is being loaded heavily. The next common bottleneck is the memory usage. For demanding tests, monitoring these resources can help determine if you should increase the machines resources, or distribute your tests differently.

## See also

- [Install and configure test agents](../test/lab-management/install-configure-test-agents.md)
