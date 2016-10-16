---
title: "How to: Choose Collection Methods"
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
  - "performance tools, choosing collection method"
  - "profiling tools, choosing collection method"
  - "performance collection methods"
ms.assetid: c87cfd3a-0fc7-49ae-9c05-d8480891cc63
caps.latest.revision: 34
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
# How to: Choose Collection Methods
The [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Profiling Tools support three methods of collecting performance data: sampling, instrumentation, and concurrency. You can also use either the sampling or instrumentation method to collect .NET memory allocation and lifetime data.  
  
 **Requirements**  
  
-   [!INCLUDE[vsUltLong](../codequality/includes/vsultlong_md.md)], [!INCLUDE[vsPreLong](../codequality/includes/vsprelong_md.md)], [!INCLUDE[vsPro](../codequality/includes/vspro_md.md)]  
  
 You can use the performance session **Method** property to specify the most appropriate collection method for your application. You can set the collection method from Performance Wizard, Performance Explorer, or from the property pages of a performance session. If you are using command-line tools, see [Profiling from the Command-Line](../profiling/using-the-profiling-tools-from-the-command-line.md) for more information.  
  
## Performance Wizard  
  
#### To select a collection method using the Performance Wizard  
  
-   On the first page of the wizard, select one of the following options:  
  
|Option|Description|  
|------------|-----------------|  
|**CPU Sampling**|Collects application statistics that are useful for initial analysis and for analyzing CPU utilization issues.|  
|**Instrumentation**|Collects detailed timing data that are useful for focused analysis and for analyzing input/output performance issues.|  
|**.NET Memory Allocation**|Collects [!INCLUDE[dnprdnshort](../codequality/includes/dnprdnshort_md.md)] memory allocation data by using the sampling profiling method.|  
|**Concurrency**|Collects numeric resource contention data.|  
  
## Performance Explorer  
  
#### To select a collection method using Performance Explorer  
  
1.  On the **Performance Explorer** toolbar, click the arrow next to the **Method** drop-down list.  
  
2.  Click the collection method that you prefer.  
  
## Performance Session Property Pages  
  
#### To select the sampling or instrumentation method using performance session properties  
  
1.  In **Performance Explorer**, select the performance session.  
  
     A performance session file name has a .psess extension.  
  
2.  Right-click the performance session, and then click **Properties**.  
  
3.  In the **Property Pages**, click **General**.  
  
4.  Click the collection method that you prefer.  
  
    -   For information about the other options that are available when you are collecting sampling data, see [Collecting Performance Statistics by Using Sampling](../profiling/collecting-performance-statistics-by-using-sampling.md)  
  
    -   For information about the other options that are available when you are collecting sampling data, see [Collecting Detailed Timing Data by Using Instrumentation](../profiling/collecting-detailed-timing-data-by-using-instrumentation.md).  
  
#### To select .NET memory data collection by using performance session properties  
  
1.  In **Performance Explorer**, select the performance session.  
  
     A performance session file name has a .psess extension.  
  
2.  Right-click the performance session, and then click **Properties**.  
  
3.  In the **Property Pages**, click **General**.  
  
4.  Click **Sampling** or **Instrumentation**.  
  
5.  Click **Collect .NET object allocation information** to collect the size and number of [!INCLUDE[dnprdnshort](../codequality/includes/dnprdnshort_md.md)] object allocations.  
  
6.  (Optional) Click **Also collect .NET object lifetime information** to collect data about the garbage collection generations in which the object memory was reclaimed.  
  
     For information about the other options that are available when you are collecting .NET memory data, see [Collecting .NET Memory Allocation and Lifetime Data](../profiling/collecting-.net-memory-allocation-and-lifetime-data.md).  
  
#### To select concurrency data collection by using performance session properties  
  
1.  In **Performance Explorer**, right-click the performance session, and then click **Properties**.  
  
2.  In the **Property Pages**, click **General**.  
  
3.  Click **Concurrency**.  
  
## See Also  
 [Configuring Performance Sessions](../profiling/configuring-performance-sessions.md)   
 [Understanding Sampling Data Values](../profiling/understanding-sampling-data-values.md)   
 [Performance Session Properties](../profiling/performance-session-properties.md)