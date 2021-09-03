---
title: Collect diagnostic information using test settings
description: Learn how to use Test settings in Visual Studio to collect extra data when you run your tests. Learn about several diagnostic data adapters.
ms.custom: SEO-VS-2020
ms.date: 10/03/2016
ms.topic: how-to
helpviewer_keywords: 
  - load tests, configuring run settings
ms.assetid: 0c86918b-cd63-4468-8f49-6d547a1276dc
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# Collect diagnostic information using test settings

You can use *Test settings* in Visual Studio to collect extra data when you run your tests. For example, you might want to make a video recording as you run your test. There are diagnostic data adapters to:

- Collect each UI action step in text format

- Record each UI action for playing back

- Collect system information

- Collect event log data

- Collect IntelliTrace data to help isolate non-reproducible bugs

Diagnostic data adapters can also be used to change the behavior of a test machine. For example, with a test setting in Visual Studio, you can emulate various network topology bottlenecks to evaluate the performance of your team’s application.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## Use test settings with Visual Studio

To run your unit, coded UI, web performance, or load tests by using Visual Studio, you can add, configure and select the test settings to use when you run your tests. To run your tests, collect data, or affect a test machine remotely, you must specify a test controller to use in your test settings. The test controller has agents that can be used for each role in your test settings.

## Diagnostic data adapter details

The following table provides an overview of the various ways that the diagnostic data adapters can be configured for use with local or remote machine roles.

|Diagnostic data adapter that is used in test setting|Manual Tests on local machine|Automated Tests|Manual Tests: Collecting data by using a set of roles and an environment|Notes|
|-|-|-|-|-|
|**ASP.NET Client Proxy for IntelliTrace and Test Impact:** This proxy lets you collect information about the http calls from a client to a web server for the IntelliTrace and Test Impact diagnostic data adapters.|Yes|Yes|Yes|-   Use this only when either the IntelliTrace or Test Impact diagnostic data adapters are selected for a client role.|
|**ASP.NET profiler:** You can create a test setting that includes ASP.NET profiling, which collects performance data on ASP.NET web applications.|No|Yes (See Notes)|No|-   This diagnostic data adapter is supported only when you run load tests from Visual Studio.|
|**Code coverage:** You can create a test setting that includes code coverage information that is used to investigate how much of your code is covered by tests.|No|Yes (See Notes)|No|-   You can use code coverage only when you run an automated test from Visual Studio or *mstest.exe*, and only from the machine that runs the test. Remote collection is not supported.<br />-   Collecting code coverage data does not work if you also have the test setting configured to collect IntelliTrace information. **Note:**  This diagnostic data adapter is only applicable to Visual Studio test settings. It is not used for test settings in Microsoft Test Manager (deprecated in Visual Studio 2017). Additionally, this adapter is for compatibility with Visual Studio 2010 test projects. **Note:**  For compatibility, the code coverage applies when automated tests are run from Microsoft Test Manager or on a remote Test agent from Visual Studio using the legacy MSTest runner.|
|**Event log:** You can configure a test setting to include event log collecting, which is included in the test results.|Yes|Yes|Yes||
|**IntelliTrace:** You can configure the diagnostic data adapter for *IntelliTrace* to collect specific diagnostic trace information to help isolate bugs that are difficult to reproduce. This creates an IntelliTrace file that contains this information. An IntelliTrace file has an extension of *.iTrace*. When a test fails, you can create a bug. The IntelliTrace file that is saved together with the test results is automatically linked to this bug. The data that is collected in the IntelliTrace file increases debugging productivity by reducing the time that is required to reproduce and diagnose an error in the code. From this IntelliTrace file the local session can be simulated on another computer. This reduces the risk of a bug being non-reproducible.|Yes|Yes|Yes|-   If you enable the collection of IntelliTrace data, collection of code coverage data does not work.<br />-   If you use IntelliTrace for a web client role, you must also select the ASP.NET Client Proxy for IntelliTrace and Test Impact diagnostic data adapter.<br />-   Only the following versions of IIS are supported: IIS 7.0, IIS 7.5 and IIS 8.0.|
|**Network emulation:** You can specify that you want to place an artificial network load on your test by using a test setting. Network emulation affects the communication to and from the machine by emulating a particular network connection speed, such as dial-up. |No|Yes (See Notes)|No|You can use the network emulation diagnostic data adapter for a client or server role. You do not have to use the adapter on both these roles that communicate with each other. **Note:**  This diagnostic data adapter is only applicable to Visual Studio test settings. It is not used for test settings in Microsoft Test Manager (deprecated in Visual Studio 2017). **Note:**  Network emulation cannot be used to increase the network connection speed. **Warning:**  If you include the network emulation diagnostic data adapter in the test settings and you intend to use it on your local machine, then you must also bind the network emulation driver to one of your machine’s network adapters. The network emulation driver is required for the network emulation diagnostic data adapter to function. The network emulation driver is installed and bound to your adapter in two ways: <ul><li>**Network emulation driver installed with Microsoft Visual Studio Test Agent:** The Visual Studio Test Agent can be used on both remote machines and your local machine. When you install a Visual Studio Test Agent, the installation process includes a configuration step that binds the network emulation driver to your network card. For more information, see [Install and configure test agents](../test/lab-management/install-configure-test-agents.md).</li><li>**Network emulation driver installed with Microsoft Visual Studio Test Professional:** When you use network emulation for the first time, you are prompted to bind the network emulation driver to a network card.</li></ul> You can also install the network emulation driver from the command line on your local machine without installing the Visual Studio test agent by using the following command: **VSTestConfig NETWORKEMULATION /install** **Warning:**  The Network Emulation adapter is ignored by load tests. Instead, load tests use the settings that are specified in the network mix of the load test scenario.|
|**System information:** A test setting can be set up to include the system information about the machine on which the test is run.|Yes|Yes|Yes||
|**Test impact:** You can collect information about which methods of your applications code were used when a test case was run. This can be used together with changes to the application code that was made by developers to determine which tests were affected by those development changes.|Yes|Yes|Yes|-   If you are collecting test impact data for a web client role, you must also select the ASP.NET Client Proxy for IntelliTrace and Test Impact diagnostic data adapter.<br />-   Only the following versions of IIS are supported: IIS 7.0, IIS 7.5 and IIS 8.0.|
|**Video Recorder:** You can create a video recording of your desktop session when you run a test. The video can help other team members isolate application issues that are difficult to reproduce.|Yes|Yes (See Notes)|Yes|-   If you enable the test agent software to run as a process instead of a service, you can create a video recording when you run automated tests.|
