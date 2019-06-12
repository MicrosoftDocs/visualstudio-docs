---
title: "How to: Collect Windows Counter Data | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.performance.property.syscounter"
  - "vs.performance.property.wincounter"
helpviewer_keywords: 
  - "windows counters"
  - "performance tools, using windows counters"
  - "profiling tools, using windows counters"
ms.assetid: db4fbac2-bea5-4558-aa8b-160fcccf4b33
caps.latest.revision: 18
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Collect Windows Counter Data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Windows Counters are system performance counters that can be collected at set intervals during profiling. In the Marks view of the Profiling Tools report, a row is labeled **AutoMark** for each collection interval. The row contains columns that describe the performance counter values at that interval. To restrict the analysis to a period of time between two particular marks, select the marks, right-click, and then select **Filter By** ->  **Marks** from the shortcut menu.  
  
 **Requirements**  
  
- [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)], [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)], [!INCLUDE[vsPro](../includes/vspro-md.md)]  
  
> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  
  
### To collect Windows counter data  
  
1. In Performance Explorer, right-click the session for which you want to configure Windows counters and select **Properties**.  
  
2. In the **Property Pages**, click **Windows Counters**.  
  
3. Select the **Collect Windows Counters** check box.  
  
4. In the **Collection interval (msecs)** text box, type a time interval.  
  
5. Select a category from the **Counter Category** drop-down list.  
  
6. Select an instance from the **Instance** drop-down list.  
  
7. Select the counters you want to use when you profile your application.  
  
8. Click **Apply.**  
  
## See Also  
 [Configuring Performance Sessions](../profiling/configuring-performance-sessions.md)   
 [Performance Session Properties](../profiling/performance-session-properties.md)   
 [CPU and Windows Counters](../profiling/cpu-and-windows-counters.md)
