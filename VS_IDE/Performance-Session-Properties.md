---
title: "Performance Session Properties"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c3a86913-172b-488f-a31a-cea01a71b2ea
caps.latest.revision: 16
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Performance Session Properties
A **Performance Session** enables you to configure settings that determine how the application is profiled. It also stores reports that are generated for the profiling session.  
  
 **Requirements**  
  
-   Visual Studio Ultimate, Visual Studio Premium, Visual Studio Professional  
  
 You create a **Performance Session** by running the **Performance Wizard** or by manually creating a session. The **Performance Session** is displayed in the **Performance Explorer** after the **Performance Session** has been created.  
  
 To view **Performance Session** properties, select the session name in **Performance Explorer**, right-click it and then select **Properties**.  
  
 The performance session has the following property pages:  
  
## General  
 These settings enable you to select the profiling method, to add .NET object collection and lifetime data, and to specify the default report location and naming conventions.  
  
 For more information, see:  
  
 [How to: Choose Collection Methods](../VS_IDE/How-to--Choose-Collection-Methods.md)  
  
 [Collecting .NET Memory Allocation and Lifetime Data](../VS_IDE/Collecting-.NET-Memory-Allocation-and-Lifetime-Data.md)  
  
 [How to: Set Performance Data File Name Options](../VS_IDE/How-to--Set-Performance-Data-File-Name-Options.md)  
  
## Launch  
 These settings enable you to select from a list of binaries and specify the start order of the binaries.  
  
 For more information, see [How to: Specify the Binary to Start](../VS_IDE/How-to--Specify-the-Binary-to-Start.md)  
  
## Sampling  
 These settings enable you to select the sample event and sampling interval when sampling is used as the profiling method. A sample event is used to collect profiling data at the specified interval. For example, if the sample event is clock cycles and the sampling interval is set to 10,000,000 then profiling data is collected after every 10 million clock cycles. The following four types of sample events are available:  
  
-   Clock Cycles - for CPU bound problems  
  
-   Page Faults - for memory related problems  
  
-   System Calls - for I/O related problems  
  
-   Performance Counters - for low-level performance problems  
  
-   Additional sample events can be specified based on available performance counters  
  
 For more information, see [How to: Choose Sampling Events](../VS_IDE/How-to--Choose-Sampling-Events.md)  
  
## Binary  
 These settings enable you to specify whether you want to relocate the instrumented binary to another location. For example, if you are profiling My.DLL and choose not to relocate the instrumented binary, a backup copy of My.DLL named My.Orig.DLL is created. Subsequently, My.DLL is modified by inserting probes to collect data. If you decide to relocate the instrumented binary, the original binary is not renamed and the instrumented binary is copied to the specified location for use during instrumentation.  
  
 For more information, see [How to: Specify the Binary to Start](../VS_IDE/How-to--Specify-the-Binary-to-Start.md)  
  
## Tier Interactions  
 For more information, see [Collecting tier interaction data](../VS_IDE/Collecting-tier-interaction-data.md)  
  
## Instrumentation  
 These settings enable you to collect performance data for JScript code in ASP.NET Web pages and specify any **Pre-instrument** and **Post-instrument** events that you want to occur before or after the instrumentation process.  
  
 For more information, see:  
  
 [How to: Profile JavaScript Code in Web Pages](../VS_IDE/How-to--Profile-JavaScript-Code-in-Web-Pages.md)  
  
 [How to: Specify Pre- and Post-Instrument Commands](../VS_IDE/How-to--Specify-Pre--and-Post-Instrument-Commands.md)  
  
## CPU Counters  
 These settings enable you to collect data about CPU performance counters when you are using the instrumentation profiling method. Portable Performance counters are available regardless of the CPU design or manufacturer. Platform Events are specific to the CPU design and manufacturer. For more information about on-chip performance counters, see the specific processor documentation.  
  
 For more information, see [How to: Collect CPU Counter Data](../VS_IDE/How-to--Collect-CPU-Counter-Data.md)  
  
## Windows Events  
 During profiling, you can collect data from event trace providers. You can view the data by using the VSPerfReport.exe command line tool `/calltrace` option. For more information about Event Tracing for Windows (ETW), see [About Event Tracing](http://go.microsoft.com/fwlink/?linkid=90752).  
  
 For more information, see:  
  
 [How to: Collect Event Tracing for Windows (ETW) Data](../VS_IDE/How-to--Collect-Event-Tracing-for-Windows--ETW--Data.md)  
  
 [VSPerfReport](../VS_IDE/VSPerfReport.md).  
  
## Windows Counters  
 This option enables you to collect data from Windows Performance Monitor counters. To collect this data, select the check box labeled **Collect Windows Performance Counters**. The collection interval can be set in the **Collection Interval** box. **Counter Category** and **Instance** might be available also. Some default Windows Performance Monitor counters are available.  
  
 For more information, see [How to: Collect Windows Counter Data](../VS_IDE/How-to--Collect-Windows-Counter-Data.md).  
  
## Advanced  
 These settings enable you to add options to the instrumentation process by specifying one or more options of the [VSInstr](../VS_IDE/VSInstr.md) command line profiling tool. You can also specify the version of the Common Runtime to profile when the application is using more than one version.  
  
 For more information, see:  
  
 [How to: Specify the .NET Framework Runtime](../VS_IDE/How-to--Specify-the-.NET-Framework-Runtime.md)  
  
 [How to: Specify Additional Instrumentation Options](../VS_IDE/How-to--Specify-Additional-Instrumentation-Options.md)  
  
## See Also  
 [Overviews](../VS_IDE/Overviews--Performance-Tools-.md)   
 [Configuring Performance Sessions](../VS_IDE/Configuring-Performance-Sessions.md)   
 [Controlling Data Collection](../VS_IDE/Controlling-Data-Collection.md)