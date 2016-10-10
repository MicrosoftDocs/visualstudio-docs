---
title: "How to: Configure ASP.NET Profiler for Load Tests Using Test Settings in Visual Studio"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6832fe39-04d5-4d94-8a18-3e2730bad423
caps.latest.revision: 89
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
# How to: Configure ASP.NET Profiler for Load Tests Using Test Settings in Visual Studio
You can use the ASP.NET profiler diagnostic data adapter to collect ASP.NET profiler information. This diagnostic data adapter collects performance data for ASP.NET applications.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
> [!NOTE]
>  This diagnostic data adapter cannot be used for tests that are run using Microsoft Test Manager. You may use the ASP.NET Profiler diagnostic adapter with load tests using websites only which requires Visual Studio Enterprise.  
  
 The ASP.NET profiler diagnostic data adapter lets you collect ASP.NET profiler data from the application tier when you run a load test. You should not run the profiler for long load tests, for example, load tests that run longer than one hour. This is because the profiler file can become large, perhaps hundreds of megabytes. Instead, run shorter load tests by using the ASP.NET profiler, which will still give you the benefit of deep diagnosis of performance problems.  
  
> [!NOTE]
>  The ASP.NET profiler diagnostic data adapter profiles the Internet Information Services (IIS) process. Therefore, it will not work against a development Web server. To profile the Web site in your load test, you have to install a test agent on the machine on which the IIS is running. The test agent will not generate load, but will be an agent for collection only. For more information, see [Install and configure test agents](../dv_TeamTestALM/Install-and-configure-test-agents.md).  
  
 For more information, see [How to: Create a Test Setting for a Distributed Load Test](../dv_TeamTestALM/How-to--Create-a-Test-Setting-for-a-Distributed-Load-Test.md).  
  
 The following procedure describes how to configure the diagnostic data adapter for the ASP.NET profiler.  
  
## To Configure the ASP.NET Profiler for Your Test Settings  
 Before you perform the steps in this procedure, you must open your test settings from Visual Studio and select the **Data and Diagnostics** page. For more information, see[Specifying Test Settings for Visual Studio Tests](../dv_TeamTestALM/Specifying-Test-Settings-for-Visual-Studio-Tests.md).  
  
#### To configure the ASP.NET profiler for your test settings  
  
1.  Select the role to use to collect the ASP.NET profiler data.  
  
    > [!CAUTION]
    >  This role must be a Web server.  
  
2.  Select **ASP.NET Profiler** to enable collecting ASP.NET profiling data, and then choose **Configure**.  
  
     The dialog box to configure ASP.NET profiling data collection is displayed.  
  
3.  In **Profiler Sampling interval**, type a value that indicates how many non-halted CPU clock cycles to wait between taking ASP.NET profiling samples.  
  
4.  To enable tier interaction profiling, select **Enable Tier Interaction Profiling**.  
  
     Tier interaction profiling counts the number of requests that are sent to the Web server for each artifact (for example, MyPage.aspx or CompanyLogo.gif) and the time it took to service each request. Additionally, tier interaction profiling collects which ADO.NET connections were used as a part of the page request, and how many queries and stored procedure calls were executed as a part of servicing that request.  
  
     Two different sets of timing information are collected:  
  
    -   The timing information (Min, Max, Average, and Total) for servicing each web request.  
  
    -   The timing information (Min, Max, Average and Total) of executing each query.  
  
 With the ASP.NET profiler diagnostic data adapter configured in your test setting, you can now collect ASP.NET profiling data on your ASP.NET Web application. For more information about how to configure the IIS, the test agent that is required on the IIS machine, and how to test your ASP.NET web application see [How to: Run a Load Test Containing Web Tests While Collecting ASP.NET Profiler Data](assetId:///7c3363b6-2dec-4cfc-baff-720bca4b61e8).  
  
## See Also  
 [Specifying Test Settings for Visual Studio Tests](../dv_TeamTestALM/Specifying-Test-Settings-for-Visual-Studio-Tests.md)   
 [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../dv_TeamTestALM/Setting-Up-Machines-and-Collecting-Diagnostic-Information-Using-Test-Settings.md)   
 [Running Automated Tests in Microsoft Test Manager](assetId:///0632f265-63fe-4859-a413-9bb934c66835)   
 [Web performance and load tests in Visual Studio](../Topic/Web%20performance%20and%20load%20tests%20in%20Visual%20Studio.md)   
 [How to: Create a Test Setting for a Distributed Load Test](../dv_TeamTestALM/How-to--Create-a-Test-Setting-for-a-Distributed-Load-Test.md)   
 [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../dv_TeamTestALM/Distributing-Load-Test-Runs-Across-Multiple-Test-Machines-Using-Test-Controllers-and-Test-Agents.md)   
 [How to: Run a Load Test Containing Web Tests While Collecting ASP.NET Profiler Data](assetId:///7c3363b6-2dec-4cfc-baff-720bca4b61e8)