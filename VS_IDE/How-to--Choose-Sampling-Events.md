---
title: "How to: Choose Sampling Events"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ce7cb734-80ac-4930-a4ef-e24395e1cc07
caps.latest.revision: 23
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
# How to: Choose Sampling Events
By default, the Visual Studio Profiling Tools collects performance data at an interval that is specified as a number of processor cycles that are used by the profiled process. The default number of cycles in an interval is 10,000,000, which is approximately 0.01 seconds on a 1 GH computer. You can change the number of cycles in an interval, and you can change the sample event. The following sample events are available:  
  
-   Clock cycles - for CPU-bound problems.  
  
-   Page faults - for memory-related problems.  
  
-   System calls - for I/O-related problems.  
  
-   Performance counter - CPU counters for low-level performance problems.  
  
> [!IMPORTANT]
>  If you are collecting .NET memory data (allocations or object lifetimes, or both) by using the sampling method, all user-specified sampling events are ignored and the appropriate memory allocations or garbage collection events, or both, are used to collect data.  
  
### To select a sample event  
  
1.  In **Performance Explorer**, right-click the performance session, and then click **Properties**.  
  
2.  In the **Property Pages**, click the **Sampling** properties.  
  
3.  From the **Sample event** drop-down list, select the sample event you want to use to profile your application.  
  
    > [!NOTE]
    >  The **Available performance counters** are enabled only if you select **Performance counter** from the **Sample event** drop-down list.  
  
4.  If you select **Performance counter**, select a specific CPU counter from the **Available performance counters** tree view control.  
  
    -   Counters in the **Portable Events** node are available on all types of processors.  
  
    -   Counters in the **Platform Events** node are specific to the processor on the current computer and might not be available on other types of processors.  
  
5.  When you select a sample event, a default sampling interval value is displayed in the **Sampling interval** text box. If necessary, you can enter the value that you want in the text box.  
  
## See Also  
 [Configuring Performance Sessions](../VS_IDE/Configuring-Performance-Sessions.md)   
 [How to: Choose Collection Methods](../VS_IDE/How-to--Choose-Collection-Methods.md)   
 [CPU and Windows Counters](../VS_IDE/CPU-and-Windows-Counters.md)   
 [Understanding Sampling Data Values](../VS_IDE/Understanding-Sampling-Data-Values.md)   
 [Profiling from the Command-Line](../VS_IDE/Using-the-Profiling-Tools-From-the-Command-Line.md)