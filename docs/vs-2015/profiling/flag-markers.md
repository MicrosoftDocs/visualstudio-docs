---
title: "Flag Markers | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.cv.markers.flag"
ms.assetid: f3ec919e-63e5-484b-adbf-8f0e79342e75
caps.latest.revision: 14
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Flag Markers
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A flag marker represents something that occurred at an instant in time in an app. A flag can represent many kinds of application events. For example, a flag could show when a particular work item was scheduled or when an exception was thrown. Runtimes such as the Task Parallel Library can also generate flags.  
  
## Flag Importance  
 Flags are displayed in different sizes depending on their importance. Like any marker, the importance can be low, normal, high, or critical.  This illustration shows the appearance of markers by importance level:  
  
 ![Low, Normal, High, and Critical importance markers](../profiling/media/cvmarkerimportance.png "CVMarkerImportance")  
Markers showing flag importance  
  
## Flag Category  
 A flag is displayed in one of five different colors depending on its category. The colors are reused if there are more than five categories. You cannot choose the color. Like any marker, the category can be any integer. The next illustration shows the colors for the first five categories.  
  
 ![Five colors of category markers](../profiling/media/cvmarkercategory.png "CVMarkerCategory")  
Markers showing categories  
  
## Alerts  
 An alert is a red-colored flag that represents a critical application event, such as an exception.  Here's an alert:  
  
 ![The Concurrency Visualizer Alert Marker](../profiling/media/cvmarkeralert.png "CVMarkerAlert")  
An alert marker  
  
## Aggregation Flags  
 Sometimes flags occur so close to one another in the Concurrency Visualizer that they can’t be drawn individually. When this occurs, a gray *aggregation flag* that represents the underlying flags is shown. When you rest the pointer on one of these icons, a tooltip displays the number of underlying flags that are represented. To view the flags, zoom in. If you zoom in all the way and still get an aggregation flag, you can view the underlying flags in the [Markers Report](../profiling/markers-report.md).  
  
 Aggregation flags are drawn in different sizes. The size depends on the importance level of the most important flag in the aggregation. The following illustration shows aggregation flags in increasing order of importance.  
  
 ![Aggregate flags showing four levels of importance](../profiling/media/cvmarkeraggregate.png "CVMarkerAggregate")  
Aggregation flags by level of importance  
  
## See Also  
 [Concurrency Visualizer Markers](../profiling/concurrency-visualizer-markers.md)   
 [Concurrency Visualizer SDK](../profiling/concurrency-visualizer-sdk.md)
