---
title: "Collecting Application Statistics for ASP.NET Web Applications Using the Profiler Sampling Method from the Command Line | Microsoft Docs"
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
  - "profiling tools, sampling method"
  - "sampling profling method"
ms.assetid: f8383ab1-eb49-4d3f-8608-d8b4d51a81be
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Collecting Application Statistics for ASP.NET Web Applications Using the Profiler Sampling Method from the Command Line
This section describes the procedures and options for collecting performance statistics for an ASP.NET Web application by using the **VSPerfASPNETCmd** and **VSPerfCmd** command-line tool and the sampling profiling method.  
  
> [!NOTE]
>  Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  
  
> [!NOTE]
>  Although the **VSPerfCmd** tool gives you complete access to Profiling Tools functionality, including pausing and resuming profiling, and collecting additional data from processor and Windows performance counters, you should use use the  **VSPerfASPNETCmd** command line tool when you do not need this functionality. The **VSPerfASPNETCmd** command line tool is the preferred method when your are profiling ASP.NET Web sites using the stand-alone profiler. Compared with the [VSPerfCmd](../profiling/vsperfcmd.md) command line tool, no environment variables need to be set, and rebooting the computer is not required. For more information, see [Rapid Web Site Profiling with VSPerfASPNETCmd](../profiling/rapid-web-site-profiling-with-vsperfaspnetcmd.md).  
  
## Common Tasks  
  
|Task|Related Content|  
|----------|---------------------|  
|**Attach the profiler to an ASP.NET application**|-   [How to: Attach the Profiler to an ASP.NET Web Application to Collect Application Statistics](../profiling/how-to-attach-the-profiler-to-an-aspnet-web-application-to-collect-application-statistics-by-using-the-command-line.md)|  
  
## Related Tasks  
  
### Profiling ASP.NET Web Applications  
  
|Task|Related Content|  
|----------|---------------------|  
|**Profile by using the instrumentation method**|-   [Collecting Detailed Timing Data Using Instrumentation](../profiling/collecting-detailed-timing-data-for-an-aspnet-web-application-using-the-profiler-instrumentation-method-from-the-command-line.md)|  
|**Profile memory allocation and garbage collection**|-   [Collecting Memory Data](../profiling/collecting-memory-data-from-an-aspnet-web-application-by-using-the-profiler-command-line.md)|  
|**Profile resource contention and thread activity**|-   [Collecting Concurrency Data](../profiling/collecting-concurrency-data-for-an-aspnet-web-application-using-the-profiler-command-line.md)|  
  
### Sampling Method  
  
|Task|Related Content|  
|----------|---------------------|  
|**Profile stand-alone (client) applications**|-   [Collecting Application Statistics Using Sampling](../profiling/collecting-application-statistics-for-stand-alone-applications-by-using-the-profiler-command-line.md)|  
|-   **Profile services**|-   [Collecting Application Statistics Using Sampling](../profiling/collecting-application-statistics-for-services-by-using-the-profiler-sampling-method.md)|  
  
### Analyzing Sampling Data Views and Reports  
 [Sampling Method Data Views](../profiling/profiler-sampling-method-data-views.md)