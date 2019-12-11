---
title: "Thread Details View - Contention Data | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.view.threaddetails"
helpviewer_keywords:
  - "Thread Details view"
ms.assetid: 874c3b1c-88d8-479a-bb35-1291d9aa8e67
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Thread Details view - contention data
The Thread Details view presents a timeline graph of the blocking events in the selected thread of a profiling run that were caused by contentions over resources. A blocking event occurs when the thread is forced to suspend execution because another thread has locked access to a resource.

 This view represents the execution timeline of the thread as a horizontal bar and the blocking events as vertical bar on a horizontal timeline for the thread. When necessary, you can zoom in on a section of the timeline to view the individual events. To view the execution path of the functions that led to the event, click the event bar. The functions appear in the **Call Stack** window. When the source code for a function is available, you can click the function name to edit the source file in the Visual Studio IDE.

## Navigate the timeline

#### To zoom in on a timeline segment

- Click and drag the mouse pointer to select an area of the timeline.

     When you release the mouse, the view zooms to the selected time segment. You can repeat the process to zoom in greater detail. The scroll box on the time scroll bar represents the relative size of the time segment that is displayed in the view.

#### To zoom out on a timeline

- Click **Zoom Out** to return to the previous zoom level.

- Click **Zoom Reset** to show the entire timeline in the view.

#### To view the call stack of an event

- In the timeline graph, click the vertical bar that represents the event.

#### To view or edit the source code of a function in the call stack

- In the **Call Stack** window, click the function name.

  The function source code must be part of the current project.

#### To view the contention events of a resource in all threads in the profiling run

- In the timeline graph, click the name or ID of the resource.

     The [Resource Details View](../profiling/resource-details-view-contention-data.md) appears for the selected resource.

#### To view the thread contention data in the Processes window

- In the timeline graph, click **Total**.

     The [Process View](../profiling/process-view-contention-data.md) appears with the thread selected.
