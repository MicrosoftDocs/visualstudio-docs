---
title: "How to: Collect CPU Counter Data"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.performance.property.cpucounters"
helpviewer_keywords: 
  - "profiling tools, using portable CPU counters"
  - "performance tools, portable CPU counters"
ms.assetid: 102fb6ca-5fbf-4b05-925f-56912ce3f44b
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
# How to: Collect CPU Counter Data
A CPU event counter is used to collect hardware-specific performance data. This topic shows you how to collect event counter data when you use the instrumentation profiling method.  
  
 **Requirements**  
  
-   [!INCLUDE[vsUltLong](../codequality/includes/vsultlong_md.md)], [!INCLUDE[vsPreLong](../codequality/includes/vsprelong_md.md)], [!INCLUDE[vsPro](../codequality/includes/vspro_md.md)]  
  
 Two types of CPU counter events occur:  
  
-   Portable events - CPU events that can be collected, regardless of the specific CPU.  
  
-   Platform events - CPU events that are coupled to a specific CPU.  
  
 Portable events include general events, such as Instructions Retired and Non Halted Cycles, CPU buffer events, branching events, and L2 cache events. The available platform event counters are determined by the processor manufacturer.  
  
 Categories of events can be shared between portable and platform counters. For example, the following categories of data are frequently common to both types:  
  
-   Memory events.  
  
-   Front end events.  
  
-   Branch events.  
  
 You can collect performance counter data in two ways in the Profiler:  
  
-   Collect data from one or more counters when you profile by instrumentation.  
  
-   Specify a counter event as the sampling interval when you profile by sampling. For more information, see [How to: Choose Sampling Events](../profiling/how-to--choose-sampling-events.md).  
  
### To collect CPU performance counter data when you profile by instrumentation  
  
1.  On the performance session **Property Pages**, click **CPU Counters.**  
  
2.  Select the **Collect CPU Counters** check box.  
  
3.  Expand the **Available performance counters** tree until you find the sample events that you want to collect.  
  
4.  For each event that you want to collect, select the event and then click the right arrow to add the event to the **Selected Counters** list.  
  
    > [!NOTE]
    >  **Available performance counters** is enabled only if you select the **Collect CPU counters** check box.  
  
## See Also  
 [Configuring Performance Sessions](../profiling/configuring-performance-sessions.md)   
 [Performance Session Properties](../profiling/performance-session-properties.md)   
 [CPU and Windows Counters](../profiling/cpu-and-windows-counters.md)   
 [How to: Choose Sampling Events](../profiling/how-to--choose-sampling-events.md)