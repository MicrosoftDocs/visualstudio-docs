---
title: "UI Processing Time | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.cv.threads.timeline.uiprocessing"
helpviewer_keywords: 
  - "Concurrency Visualizer, UI Processing Time"
ms.assetid: 0ddb05a3-8c6b-448b-8488-2751c1e5abcc
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# UI Processing Time
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

These segments in the timeline are associated with blocking times that are categorized as UI Processing. This implies that a thread is pumping Windows messages or performing other user interface (UI) work. During this time, a thread has been blocked in an API that the Concurrency Visualizer is counting as UI Processing. APIs such as `GetMessage()` and `MsgWaitForMultipleObjects()` fall into this group.  
  
 If no pre-defined blocking API is identified, review the call stacks and profile reports to determine the underlying causes of delay.  
  
 The UI Processing category is important for understanding the responsiveness of GUI applications, and is desirable in applications that depend on UI responsiveness. For example, if the UI thread in an application achieves 100% time in UI Processing, it is probably very responsive. However, if the UI thread spends considerable time in other categories, look for the root causes and consider options for reducing non-UI categories on that thread.  
  
## See Also  
 [Threads View](../profiling/threads-view-parallel-performance.md)
