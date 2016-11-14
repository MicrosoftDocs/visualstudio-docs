---
title: "Span Markers | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.cv.markers.span"
ms.assetid: 736b7765-9c71-44d7-85e5-79787d13d91c
caps.latest.revision: 9
author: "mikejo5000"
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
# Span Markers
A span marker represents a meaningful phase of an application. For example, you can use a span to represent an interval of time during which a particular work item is being processed. Its length represents the duration of the corresponding application phase. This illustration shows a span in Concurrency Visualizer:  
  
 ![A span marker in Concurrency Visualizer](../profiling/media/cvmarkerspan.png "CVMarkerSpan")  
A span marker in the Concurrency Visualizer  
  
## Span Category  
 A span marker is displayed in one of five different colors, depending on its category. The colors are repeated if there are more than five categories. The category can be any integer. This illustration shows the five possible colors:  
  
 ![Five spans in different categories](../profiling/media/cvmarkerspancategory.png "CVMarkerSpanCategory")  
The colors of the first five span categories  
  
## Span Aggregation Markers  
 Sometimes span markers occur so close to one another in the Concurrency Visualizer that they can’t be drawn individually. When this occurs, a gray *span aggregation marker* that represents the underlying spans is shown. When you rest the pointer on one of these icons, a tooltip displays the number of underlying spans that are represented. To view the spans, zoom in. If you zoom in all the way and still get an span aggregation marker, you can view the underlying span markers in the [Markers Report](../profiling/markers-report.md). This illustration shows a span aggregation marker:  
  
 ![An aggregate span marker in Concurrency Visualizer](../profiling/media/cvmarkerspanaggregate.png "CVMarkerSpanAggregate")  
A span aggregation marker  
  
## See Also  
 [Concurrency Visualizer Markers](../profiling/concurrency-visualizer-markers.md)   
 [Concurrency Visualizer SDK](../profiling/concurrency-visualizer-sdk.md)