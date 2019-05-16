---
title: "Visualizing EventSource Events as Markers | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 3a10022a-5c37-48b1-a833-dd35902176b6
caps.latest.revision: 15
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Visualizing EventSource Events as Markers
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Concurrency Visualizer can display EventSource events as markers, and you can control how the markers are displayed. To view the EventSource markers, register the ETW provider GUID by using the [Advanced Settings](../profiling/advanced-settings-dialog-box-concurrency-visualizer.md) dialog box. The Concurrency Visualizer has default conventions to represent EventSource events as [Flag Markers](../profiling/flag-markers.md), [Span Markers](../profiling/span-markers.md), and [Message Markers](../profiling/message-markers.md). You can customize how EventSource events are displayed by adding custom fields to the events. For more information about markers, see [Concurrency Visualizer Markers](../profiling/concurrency-visualizer-markers.md). For more information about EventSource events, see <xref:System.Diagnostics.Tracing>.  
  
## Default Visualization of EventSource Events  
 By default, the Concurrency Visualizer uses the following conventions to represent EventSource events.  
  
### Marker Type  
  
1. Events that have [Opcode](https://msdn.microsoft.com/d97953df-669b-4c55-b1a8-925022b339b7) win:Start or win:Stop are treated as the beginning or end of a span, respectively.  Nested or overlapping spans cannot be displayed. Event pairs that begin on one thread and end on another cannot be displayed.  
  
2. An event whose Opcode is neither win:Start nor win:Stop is treated as a marker flag unless its [Level](https://msdn.microsoft.com/dfa4e0a9-4d89-4f50-aef9-1dae0dc11726) (field of EVENT_RECORD.EVENT_HEADER.EVENT_DESCRIPTOR) is win:Verbose or higher.  
  
3. In all other cases, the event is treated as a message.  
  
### Importance  
 The following table defines how the event level maps to the marker importance.  
  
|ETW Level|Concurrency Visualizer Importance|  
|---------------|---------------------------------------|  
|win:LogAlways|Normal|  
|win:Critical|Critical|  
|win:Error|Critical|  
|win:Warning|High|  
|win:Informational|Normal|  
|win:Verbose|Low|  
|Greater than win:verbose|Low|  
  
### Series Name  
 The task name of the event is used for the series name. Series name is empty if no task was defined for the event.  
  
### Category  
 If the Level is win:Critical or win:Error, then the category is Alert (-1). Otherwise, the category is the default (0).  
  
### Text  
 If a printf-type formatted text message was defined for the event, it is displayed as the description of the Marker. Otherwise, the description is the name of the event and the value of each payload field.  
  
## Customizing Visualization of EventSource Events  
 You can customize how EventSource events are displayed by adding the appropriate fields to the event, as described in the following sections.  
  
### Marker Type  
 Use the `cvType` field, a byte, to control the kind of marker that's used to represent the event. Here are the available values for cvType:  
  
|cvType value|Resulting Marker Type|  
|------------------|---------------------------|  
|0|Message|  
|1|Span Start|  
|2|Span End|  
|3|Flag|  
|All other values|Message|  
  
### Importance  
 You can use the `cvImportance` field, a byte, to control the importance setting for an EventSource event. However, we recommend that you control the displayed importance of an event by using its Level.  
  
|cvImportance value|Concurrency Visualizer Importance|  
|------------------------|---------------------------------------|  
|0|Normal|  
|1|Critical|  
|2|High|  
|3|High|  
|4|Normal|  
|5|Low|  
|All other values|Low|  
  
### Series Name  
 Use the `cvSeries` event field, a string, to control the series name that the Concurrency Visualizer gives to an EventSource event.  
  
### Category  
 Use the `cvCategory` field, a byte, to control the category that the Concurrency Visualizer gives to an EventSource event.  
  
### Text  
 Use the `cvTextW` field, a string, to control the description that the Concurrency Visualizer gives to an EventSource event.  
  
### SpanID  
 Use the cvSpanId field, an int, to match pairs of events. The value for each pair of start/stop events that represent a span must be unique. Typically for concurrent code, this requires the use of synchronization primitives such as <xref:System.Threading.Interlocked.Exchange%2A> to ensure that the key (the value that's used for CvSpanID) is correct.  
  
> [!NOTE]
> The use of SpanID to nest spans, allow them to partially overlap on the same thread, or allow them to start on one thread and end on another is not supported.  
  
## See Also  
 [Concurrency Visualizer Markers](../profiling/concurrency-visualizer-markers.md)
