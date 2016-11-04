---
title: "Collecting Memory Data from an ASP.NET Web Application by Using the Profiler Command Line | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - ".NET memory profiling method"
  - "profiling tools,.NET memory method"
ms.assetid: 57acf2b0-327a-4c0e-8078-ac2f6d99457d
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
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
# Collecting Memory Data from an ASP.NET Web Application by Using the Profiler Command Line
This section describes the procedures and options for collecting memory allocation and object lifetime data for an ASP.NET Web application by using the **VSPerfCmd** command-line tool.  
  
> [!NOTE]
>  The **VSPerfCmd** tool provides you with complete access to Profiling Tools functionality, including pausing and resuming profiling, and collecting additional data from processor and Windows performance counters. You can also use the  **VSPerfASPNETCmd** command-line tool when you do not need this functionality. Compared with the [VSPerfCmd](../profiling/vsperfcmd.md) command line tool, no environment variables need to be set, and rebooting the computer is not required. For more information, see [Rapid Web Site Profiling with VSPerfASPNETCmd](../profiling/rapid-web-site-profiling-with-vsperfaspnetcmd.md).  
  
## Common Tasks  
  
|Task|Related Content|  
|----------|---------------------|  
|**Attach the profiler to a running ASP.NET application**|-   [How to: Attach the Profiler to an ASP.NET Web Application to Collect Memory Data](../profiling/how-to-attach-the-profiler-to-an-aspnet-web-application-to-collect-memory-data-by-using-the-command-line.md)|  
|**Instrument statically compiled binaries**|-   [How to: Instrument a Statically Compiled ASP.NET Application and Collect Memory Data](../profiling/how-to-instrument-a-statically-compiled-aspnet-web-application-and-collect-memory-data-by-using-the-profiler-command-line.md)|  
|**Instrument dynamically compiled binaries**|-   [How to: Instrument a Dynamically Compiled ASP.NET Application and Collect Memory Data](../profiling/how-to-instrument-a-dynamically-compiled-aspnet-web-application-and-collect-memory-data-by-using-the-profiler-command-line.md)|  
  
## Related Tasks  
  
### Profiling ASP.NET Web Applications  
  
|Task|Related Content|  
|----------|---------------------|  
|**Profile by using the sampling method**|-   [Collecting Application Statistics Using Sampling](../profiling/collecting-application-statistics-for-aspnet-web-applications-using-the-profiler-sampling-method-from-the-command-line.md)|  
|**Profile by using the instrumentation method**|-   [Collecting Detailed Timing Data Using Instrumentation](../profiling/collecting-detailed-timing-data-for-an-aspnet-web-application-using-the-profiler-instrumentation-method-from-the-command-line.md)|  
|**Profile resource contention and thread activity**|-   [Collecting Concurrency Data](../profiling/collecting-concurrency-data-for-an-aspnet-web-application-using-the-profiler-command-line.md)|  
  
### Profiling .NET Framework Memory Data  
  
|Task|Related Content|  
|----------|---------------------|  
|**Profile stand-alone (client) applications**|-   [Collecting .NET Framework Memory Data](../profiling/collecting-dotnet-framework-memory-data-for-stand-alone-applications-by-using-the-profiler-command-line.md)|  
|**Profile services**|-   [Collecting .NET Memory Data](../profiling/collecting-memory-data-from-dotnet-framework-services-by-using-the-profiler-command-line.md)|  
  
### Analyzing .NET Memory Data Views and Reports  
 [.NET Memory Data Views](../profiling/dotnet-memory-data-views.md)  
  
## Reference  
 [Command-Line Profiling Tools Reference](../profiling/command-line-profiling-tools-reference.md)