---
title: "Marks View | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.performance.view.marks"
helpviewer_keywords: 
  - "profiling tools, Marks view"
  - "profiling tools reports, Marks view"
ms.assetid: b2773344-8081-4116-85a1-58f770448f6a
caps.latest.revision: 23
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Marks View
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Marks view displays sampling and ETW events that were inserted into the application.  
  
 The default marks that are prepopulated in the report label the start of the program and the end of the program.  
  
 Windows counters data from automatically generated marks is also presented in this view. For more information, see [How to: Collect Windows Counter Data](../profiling/how-to-collect-windows-counter-data.md).  
  
 To create a filter between two marks, select the marks, right-click, and then click **Add Filter by Marks** or **Add Filter by Timestamp**.  
  
 The following table provides the definitions of columns that are available in the Marks view.  
  
 **Mark ID**  
 Unique Identifier of the profiling mark.  
  
 **Mark Name**  
 The name of the event.  
  
 **Timestamp**  
 Time from the start of profiling to the time that the event is recorded.  
  
 Windows performance counter data  
 When Windows performance counter data is collected the values are displayed in a column that has the name of the counter.  
  
## See Also  
 [Performance Report Overview](../profiling/performance-report-overview.md)   
 [<PAVE_OVER> How to: Configure Profiling Marks](https://msdn.microsoft.com/library/65a23880-e5e8-4d5a-82b3-6498b9ef8975)   
 [<PAVE_OVER> How to: Insert Marks in a Profiler Data File](https://msdn.microsoft.com/library/856bfc81-a60f-42e5-a9bc-71b986c1e09d)   
 [How to: Collect Windows Counter Data](../profiling/how-to-collect-windows-counter-data.md)   
 [&#91;NIB&#93; Data Collection Control Window](https://msdn.microsoft.com/98d740d8-459f-4605-bf04-fb17aafaaa8f)
