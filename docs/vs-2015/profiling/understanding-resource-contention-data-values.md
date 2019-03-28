---
title: "Understanding Resource Contention Data Values | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "concurrency profiling method"
  - "Profiling Tools, concurrency method"
ms.assetid: 071c0f0f-1eba-4dc8-ae87-0810e4086dd0
caps.latest.revision: 14
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Understanding Resource Contention Data Values
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Resource contention profiling collects detailed call stack information each time competing threads in an application are forced to wait for access to a shared resource.  
  
 **Requirements**  
  
- [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)], [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)], [!INCLUDE[vsPro](../includes/vspro-md.md)]  
  
  Resource contention reports display the total number of contentions and the total time that was spent waiting for a resource for the modules, functions, source code lines, and instructions in which the waiting occurred.  
  
- Inclusive values display the total number of contentions that forced a function to wait by resource contentions and the total time that the function waited.  Contentions that were caused by child functions that were called by the function are included in inclusive values.  
  
- Exclusive values display only the number of contentions that forced a function to wait and that were caused by code in the body of the function. Contentions caused by child functions are not included. The exclusive time for the function also includes only the wait times that were caused by statements in the function body.  
  
  Resource contention report views also include timeline graphs that show the individual contention events over time and show the call stacks that created the particular event. For more information, see one of the following topics:  
  
- [Thread Details View](../profiling/thread-details-view-contention-data.md)  
  
- [Resource Details View](../profiling/resource-details-view-contention-data.md)  
  
  For more information about the second mode of concurrency profiling, see [Concurrency Visualizer](../profiling/concurrency-visualizer.md).
