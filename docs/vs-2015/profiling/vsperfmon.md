---
title: "VSPerfMon | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "VSPerfMon tool"
  - "command line, tools"
  - "command-line tools, VSPerfMon tool"
  - "data [Visual Studio ALM], VSPerfMon tool"
  - "performance data, VSPerfMon tool"
  - "performance tools, VSPerfMon tool"
  - "profilng tools,VSPerfCmd"
ms.assetid: 37052afb-7a58-441f-bb17-f1587cc57068
caps.latest.revision: 35
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# VSPerfMon
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use VSPerfMon tool to collect performance data for an application; typically this tool is launched by VSPerfCmd.exe. VSPerfMon displays additional information about process attach or detach which is not available by using the VSPerfCmd tool. To view this information, start VSPerfMon in a separate window. To invoke VSPerfMon use the following syntax:  
  
```  
VSPerfMon [/U] </TRACE [/COUNTER:cfg] | /SAMPLE | /COVERAGE> /CROSSSESSION /OUTPUT <file name> [/WINCOUNTER:cfg] [/USER [DOMAIN\]username]  
```  
  
 The following table describes VSPerfMon tool options:  
  
|Options|Description|  
|-------------|-----------------|  
|**U**|Redirected console output is written as Unicode.  This must be the first option specified.|  
|**OUTPUT:** `<` *file name* `>`|Redirects output to the specified file name.|  
|**TRACE**|Starts performance monitor for instrumented profiling.|  
|**SAMPLE**|Starts the performance monitor for sampling profiling.|  
|**COVERAGE**|Starts the performance monitor for code coverage collection.|  
|**CONCURRENCY**|Starts the performance monitor for resource contention profiling.|  
|**USER:** `[` *domain* `\]` *username*|Allows client access to the performance monitor from the specified account.|  
|**CROSSSESSION**|Enables cross-session profiling.|  
|**COUNTER** `:cfg`|When the instrumentation (TRACE) profiling method is used, specifies a CPU counter to be collected at each instrumentation point. You can collect multiple counter data by specifying multiple Counter options.<br /><br /> Use the following syntax to specify the counter (*cfg*) data:<br /><br /> **CounterName** [**,Reload**[,**FriendlyName**]]<br /><br /> -   **CounterName** is the name of a counter returned by the VSPerfCmd /QueryCounters command.<br />-   **Reload** is the counter event sampling interval. Do not use *Reload* with the instrumentation method.<br />-   When specified, **FriendlyName** replaces **CounterName** in Profiling Tools report column names.|  
|**WINCOUNTER** `:path`|Specifies a Windows performance counter to include with mark data. `path` is a Windows Performance counter string in PDH counter path format. For example:<br /><br /> \Processor(0)\\% Processor Time<br /><br /> \System\Context Switches/sec|  
|**AUTOMARK** `:n`|Specifies the time interval (in milliseconds) between automatic marks when you use /WINCOUNTER. Rounded up to the nearest 500ms.<br /><br /> Use 0 to disable automatic marks. (default=500ms if unspecified)|  
  
## See Also  
 [VSInstr](../profiling/vsinstr.md)   
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [VSPerfReport](../profiling/vsperfreport.md)   
 [Performance Report Views](../profiling/performance-report-views.md)
