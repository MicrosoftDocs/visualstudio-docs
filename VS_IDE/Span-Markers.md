---
title: "Span Markers"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 736b7765-9c71-44d7-85e5-79787d13d91c
caps.latest.revision: 9
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
# Span Markers
A span marker represents a meaningful phase of an application. For example, you can use a span to represent an interval of time during which a particular work item is being processed. Its length represents the duration of the corresponding application phase. This illustration shows a span in Concurrency Visualizer:  
  
 ![A span marker in Concurrency Visualizer](../VS_IDE/media/CVMarkerSpan.png "CVMarkerSpan")  
A span marker in the Concurrency Visualizer  
  
## Span Category  
 A span marker is displayed in one of five different colors, depending on its category. The colors are repeated if there are more than five categories. The category can be any integer. This illustration shows the five possible colors:  
  
 ![Five spans in different categories](../VS_IDE/media/CVMarkerSpanCategory.png "CVMarkerSpanCategory")  
The colors of the first five span categories  
  
## Span Aggregation Markers  
 Sometimes span markers occur so close to one another in the Concurrency Visualizer that they can’t be drawn individually. When this occurs, a gray *span aggregation marker* that represents the underlying spans is shown. When you rest the pointer on one of these icons, a tooltip displays the number of underlying spans that are represented. To view the spans, zoom in. If you zoom in all the way and still get an span aggregation marker, you can view the underlying span markers in the [Markers Report](../VS_IDE/Markers-Report.md). This illustration shows a span aggregation marker:  
  
 ![An aggregate span marker in Concurrency Visualizer](../VS_IDE/media/CVMarkerSpanAggregate.png "CVMarkerSpanAggregate")  
A span aggregation marker  
  
## See Also  
 [Concurrency Visualizer Markers](../VS_IDE/Concurrency-Visualizer-Markers.md)   
 [Concurrency Visualizer SDK](../VS_IDE/Concurrency-Visualizer-SDK.md)