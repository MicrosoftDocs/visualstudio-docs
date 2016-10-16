---
title: "Command-Line Profiling of ASP.NET Web Applications"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "profiling ASP.NET applications"
  - "profling tools,ASP.NET applications"
ms.assetid: 897c00d5-5767-433b-a960-4a29c6023ede
caps.latest.revision: 21
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
# Command-Line Profiling of ASP.NET Web Applications
This section describes the procedures and options for collecting performance data for [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] Web applications by using [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Profiling Tools from the command line.  
  
> [!NOTE]
>  Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  
  
## Common Tasks  
  
|Task|Related Content|  
|----------|---------------------|  
|**Collect basic ASP.NET profiling data easily:** Use the **VSPerfASPNETCmd** tool to collect sampling, instrumentation, .NET memory, contention, or tier interaction data without the configuration requirements and the Internet Information Services (IIS) restarts that are needed for **VSPerfCmd**. **VSPerfASPNETCmd** does not allow you to collect additional data or to control data collection. **Note:**  **VSPerfASPNETCmd** is the preferred tool to use you use the standalone profiler to profile ASP.NET Web sites.|-   [Rapid Web Site Profiling with VSPerfASPNETCmd](../profiling/rapid-web-site-profiling-with-vsperfaspnetcmd.md)|  
|**Collect application statistics:** Use the sampling method to collect performance statistics. Sampling data is useful for analyzing CPU usage issues and for understanding the general performance characteristics of an application.|-   [Collecting Application Statistics Using Sampling](../profiling/f8383ab1-eb49-4d3f-8608-d8b4d51a81be.md)|  
|**Collect detailed timing data:** Use the instrumentation method to collect detailed timing information. Instrumentation data is useful for analyzing IO issues and for fine-grained analysis of application scenarios.|-   [Collecting Detailed Timing Data Using Instrumentation](../profiling/29f2fc55-aaf7-4e18-a672-8815455fba73.md)|  
|**Collect .NET memory data:** Use sampling or instrumentation to collect .NET memory allocation data that shows you the size and number of allocated objects. You can also collect object lifetime data that shows you the size and number of objects that are reclaimed in each garbage collection generation.|-   [Collecting Memory Data](../profiling/collecting-memory-data-from-an-asp.net-web-application-by-using-the-profiler-command-line.md)|  
|**Collect concurrency data:** Use the concurrency method to collect resource contention data. **Note:**  Collecting thread activity and visualization data is not supported for Web applications.|-   [Collecting Concurrency Data](../profiling/collecting-concurrency-data-for-an-asp.net-web-application-using-the-profiler-command-line.md)|  
|**Add tier interaction data:** You can add performance data about synchronous [!INCLUDE[vstecado](../datatools/includes/vstecado_md.md)] calls that the [!INCLUDE[vstecasp](../codequality/includes/vstecasp_md.md)] Web application makes to a Microsoft [!INCLUDE[ssNoVersion](../datatools/includes/ssnoversion_md.md)] database.|-   [Collecting tier interaction data](../profiling/adding-tier-interaction-data-from-the-command-line.md)|  
  
## Related Tasks  
  
|Task|Related Content|  
|----------|---------------------|  
|**Profile stand-alone (client) applications**|-   [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)|  
|**Profile services**|-   [Profiling Services](../profiling/command-line-profiling-of-services.md)|