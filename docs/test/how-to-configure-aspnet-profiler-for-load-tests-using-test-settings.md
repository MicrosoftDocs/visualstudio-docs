---
title: Configure ASP.NET Profiler for Load Tests
description: Learn how to use the ASP.NET profiler diagnostic data adapter to collect ASP.NET profiler information.
ms.custom: SEO-VS-2020
ms.date: 10/13/2016
ms.topic: how-to
helpviewer_keywords: 
  - test settings, ASP.NET
ms.assetid: 6832fe39-04d5-4d94-8a18-3e2730bad423
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# How to: Configure ASP.NET profiler for load tests using test settings in Visual Studio

You can use the ASP.NET profiler diagnostic data adapter to collect ASP.NET profiler information. This diagnostic data adapter collects performance data for ASP.NET applications.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

> [!NOTE]
> This diagnostic data adapter cannot be used for tests that are run using Microsoft Test Manager (deprecated in Visual Studio 2017). You can use the ASP.NET Profiler diagnostic adapter with load tests using websites only, which requires Visual Studio Enterprise.

The ASP.NET profiler diagnostic data adapter lets you collect ASP.NET profiler data from the application tier when you run a load test. You should not run the profiler for long load tests, for example, load tests that run longer than one hour. This is because the profiler file can become large, perhaps hundreds of megabytes. Instead, run shorter load tests by using the ASP.NET profiler, which will still give you the benefit of deep diagnosis of performance problems.

> [!NOTE]
> The ASP.NET profiler diagnostic data adapter profiles the Internet Information Services (IIS) process. Therefore, it will not work against a development web server. To profile the website in your load test, you have to install a test agent on the machine on which the IIS is running. The test agent will not generate load, but will be an agent for collection only. For more information, see [Install and configure test agents](../test/lab-management/install-configure-test-agents.md).

For more information, see [How to: Create a test setting for a distributed load test](../test/how-to-create-a-test-setting-for-a-distributed-load-test.md).

## Configure the ASP.NET profiler for your test settings

Before you perform the steps in this procedure, you must open your test settings from Visual Studio and select the **Data and Diagnostics** page.

1. Select the role to use to collect the ASP.NET profiler data.

    > [!WARNING]
    > This role must be a web server.

2. Select **ASP.NET Profiler** to enable collecting ASP.NET profiling data, and then choose **Configure**.

     The dialog box to configure ASP.NET profiling data collection is displayed.

3. In **Profiler Sampling interval**, type a value that indicates how many non-halted CPU clock cycles to wait between taking ASP.NET profiling samples.

4. To enable tier interaction profiling, select **Enable Tier Interaction Profiling**.

     Tier interaction profiling counts the number of requests that are sent to the web server for each artifact (for example, *MyPage.aspx* or *CompanyLogo.gif*) and the time it took to service each request. Additionally, tier interaction profiling collects which ADO.NET connections were used as a part of the page request, and how many queries and stored procedure calls were executed as a part of servicing that request.

     Two different sets of timing information are collected:

    - The timing information (Min, Max, Average, and Total) for servicing each web request.

    - The timing information (Min, Max, Average and Total) of executing each query.

With the ASP.NET profiler diagnostic data adapter configured in your test setting, you can now collect ASP.NET profiling data on your ASP.NET web application.

## See also

- [Collect diagnostic information using test settings](../test/collect-diagnostic-information-using-test-settings.md)
- [How to: Create a test setting for a distributed load test](../test/how-to-create-a-test-setting-for-a-distributed-load-test.md)
- [Test controllers and test agents](configure-test-agents-and-controllers-for-load-tests.md)