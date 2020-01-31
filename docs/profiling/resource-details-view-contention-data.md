---
title: "Resource Details View - Contention Data | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.view.resourcedetails"
helpviewer_keywords:
  - "Resource Details view"
ms.assetid: a4ecfe1c-abbc-4fb3-9ab2-34de50486901
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Resource Details View - Contention Data
The Resource Details view presents a timeline graph of the blocking events that were caused by contentions over a selected resource. A blocking event occurs when a thread is forced to suspend execution because another thread has locked access to the resource.

 This view represents the execution timeline of each thread as a horizontal bar and represents each blocking event as a vertical bar on the thread timeline. When necessary, you can magnify a section of the timeline to view individual events. To view the execution path (call stack) of the functions that led to the event, click the event bar. The functions appear in the **Call Stack** window. When the source code for a function is available, you can click the function name to edit the source file in the interface for [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].

## Procedures

#### To magnify a timeline segment

- Drag the mouse pointer over an area of the timeline.

     When you release the mouse button, the view zooms to the selected time segment. You can repeat the process to further magnify the segment. The scroll box on the time scroll bar represents the relative size of the time segment that appears in the view.

#### To zoom out on a timeline

- Perform one of the following steps:

  - Click **Zoom Out** to return to the previous zoom level.

  - Click **Zoom Reset** to show all of the timeline in the view.

#### To view the call stack of an event

- In the timeline graph, click the event bar.

#### To view or edit the source code of a function in the call stack

- In the **Call Stack** window, click the function name.

  The function source code must be part of the current project.

#### To view the call tree of contention events for the resource

- In the timeline graph, click **Total**.

     The Contentions view appears for the resource. For more information, see [Resource Contentions View](../profiling/resource-contentions-view-contention-data.md).

#### To view all the contention events of a thread

- In the timeline graph, click the name or ID of the thread.

     The Thread Details View appears for the selected thread. For more information, see [Thread Details View](../profiling/thread-details-view-contention-data.md).
