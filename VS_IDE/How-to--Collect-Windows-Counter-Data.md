---
title: "How to: Collect Windows Counter Data"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: db4fbac2-bea5-4558-aa8b-160fcccf4b33
caps.latest.revision: 13
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
# How to: Collect Windows Counter Data
Windows Counters are system performance counters that can be collected at set intervals during profiling. In the Marks view of the Profiling Tools report, a row is labeled **AutoMark** for each collection interval. The row contains columns that describe the performance counter values at that interval. To restrict the analysis to a period of time between two particular marks, select the marks, right-click, and then select **Filter By** ->  **Marks** from the shortcut menu.  
  
 **Requirements**  
  
-   Visual Studio Ultimate, Visual Studio Premium, Visual Studio Professional  
  
> [!NOTE]
>  Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../VS_IDE/Performance-Tools-on-Windows-8-and-Windows-Server-2012-applications.md).  
  
### To collect Windows counter data  
  
1.  In Performance Explorer, right-click the session for which you want to configure Windows counters and select **Properties**.  
  
2.  In the **Property Pages**, click **Windows Counters**.  
  
3.  Select the **Collect Windows Counters** check box.  
  
4.  In the **Collection interval (msecs)** text box, type a time interval.  
  
5.  Select a category from the **Counter Category** drop-down list.  
  
6.  Select an instance from the **Instance** drop-down list.  
  
7.  Select the counters you want to use when you profile your application.  
  
8.  Click **Apply.**  
  
## See Also  
 [Configuring Performance Sessions](../VS_IDE/Configuring-Performance-Sessions.md)   
 [Performance Session Properties](../VS_IDE/Performance-Session-Properties.md)   
 [CPU and Windows Counters](../VS_IDE/CPU-and-Windows-Counters.md)