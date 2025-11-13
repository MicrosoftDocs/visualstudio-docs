---
title: "Threads view timeline reports in the Concurrency Visualizer"
description: "Learn that in the Threads view, you can use timeline reports to identify which threads are executing code during an execution segment."
ms.date: "05/06/2022"
ms.topic: article
f1_keywords:
  - "vs.cv.threads.timeline.execution"
  - "vs.cv.threads.timeline.io"
  - "vs.cv.threads.timeline.paging"
  - "vs.cv.threads.timeline.preemption"
  - "vs.cv.threads.timeline.sleep"
  - "vs.cv.threads.timeline.synchronization"
  - "vs.cv.threads.timeline.uiprocessing"
helpviewer_keywords:
  - "Concurrency Visualizer, Threads View Timeline Reports (Parallel Performance)"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Threads view timeline reports in the Concurrency Visualizer

 This article provides information about the timeline reports in the Threads view of the Concurrency Visualizer.

## Execution time (Threads View)

These segments in the Threads View timeline represent execution time, when the thread is actively doing work on a logical core in the system.

 Changes in thread status are detected through kernel context switch events. Event Tracing for Windows (ETW) captures sample stacks every millisecond. In a very short green segment, it is possible that no sample is taken. Therefore, some short execution segments may show no call stack.

 When you click an execution segment, the Concurrency Visualizer displays the sample stack closest to the location of the click. The location of that sample stack is shown by a black arrow, or caret, above the timeline and the sample stack appears on the **Current** tab.

 To see a traditional sampling profile for all execution segments in the current view, click **Execution** in the Visible Timeline Profile.

## I/O time (Threads View)

These segments in the timeline are associated with blocking times that are categorized as I/O. This means that a thread is waiting for an I/O operation to finish. The thread may have been blocked in an API, or by an I/O-related kernel wait that the Concurrency Visualizer is counting as I/O. APIs such as `CreateFile()`, `ReadFile()`, and `WSARecv()` fall into this group.

## Memory management time

These segments in the timeline are associated with blocking times that are categorized as Memory Management. This scenario implies that a thread is blocked by an event that is associated with a memory management operation such as Paging. During this time, a thread has been blocked in an API or kernel state that the Concurrency Visualizer is counting as memory management. These include events such as paging and memory allocation.

 Examine the associated call stacks and profile reports to better understand the underlying reasons for blocks that are categorized as Memory Management.

## Preemption time

These segments in the timeline are associated with the blocking time that is categorized as Preemption. This category implies that a thread is switched out because of one of these reasons:

- The scheduler replaced it by using a higher priority thread.

- The execution quantum of the thread expired and other threads were ready to execute.

  During this time, a thread has been blocked by a kernel wait reason that the Concurrency Visualizer is counting as Preemption. Preemption segments start when a thread is pushed out of a logical core, and end when that thread resumes execution.

  The tooltip for a preempted segment displays the name of the process or thread that caused the preemption. However, this does not imply that the process or thread that took over actually ran throughout the preempted period.

## Sleep time

These segments in the timeline are associated with the blocking time that is categorized as Sleep. The sleep category implies that a thread has voluntarily given up its logical core and is doing no work. During this time, a thread has been blocked in an API that the Concurrency Visualizer is counting as Sleep. APIs such as `Sleep()` and `SwitchToThread()` fall into this group.

## Synchronization time

These segments in the timeline are associated with blocking times that are categorized as Synchronization. When a thread is marked as blocked on synchronization, one of these things is implied:

- The execution of the thread may have resulted in a call to a well-known thread synchronization API such as `EnterCriticalSection()` or `WaitForSingleObject()`.

- The API matching algorithm cannot be totally comprehensive, and therefore some APIs that could be mapped to other categories may also appear as synchronization because a frame in the call stack eventually reached an underlying kernel blocking primitive that was mapped to this category.

  To understand the underlying cause for a thread blocking event, carefully examine the blocking call stacks and profile reports.

## UI processing time

These segments in the timeline are associated with blocking times that are categorized as UI Processing. This implies that a thread is pumping Windows messages or performing other user interface (UI) work. During this time, a thread has been blocked in an API that the Concurrency Visualizer is counting as UI Processing. APIs such as `GetMessage()` and `MsgWaitForMultipleObjects()` fall into this group.

 If no pre-defined blocking API is identified, review the call stacks and profile reports to determine the underlying causes of delay.

 The UI Processing category helps you understand the responsiveness of GUI applications, and is desirable in applications that depend on UI responsiveness. For example, if the UI thread in an application achieves 100% time in UI Processing, it's probably responsive. However, if the UI thread spends considerable time in other categories, look for the root causes and consider options for reducing non-UI categories on that thread.

## Related content

- [Concurrency Visualizer](../profiling/concurrency-visualizer.md)
