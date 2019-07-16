---
title: "Message Markers | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.cv.markers.message"
ms.assetid: 721f40ca-5af2-4a01-b8b6-2b90f6cb7f89
caps.latest.revision: 18
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Message Markers
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A message marker represents log output. A message is a string that's issued by a specific thread at a specific time. You can export messages to a text file for use with other tools. You can rest the pointer on a message in the Concurrency Visualizer to view the message string. And you can view all the message markers in the [Markers Report](../profiling/markers-report.md).  The following illustration shows a message marker.  
  
## Message Aggregation Markers  
 Sometimes multiple messages occur so close to one another in the Concurrency Visualizer that they can’t be drawn individually. When this occurs, a *message aggregation marker* that represents the underlying messages is shown. When you rest the pointer on one of these icons, a tooltip displays the number of underlying messages that are represented. To view the messages, zoom in.  If you zoom in all the way and still get an aggregation marker, you can view the underlying messages in the [Markers Report](../profiling/markers-report.md).  
  
## See Also  
 [Concurrency Visualizer Markers](../profiling/concurrency-visualizer-markers.md)   
 [Concurrency Visualizer SDK](../profiling/concurrency-visualizer-sdk.md)
