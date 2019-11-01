---
title: "Switch to another thread while debugging"
ms.custom: "seodec18"
ms.date: "04/27/2017"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "threads, switching [debugging]"
ms.assetid: 5cd76c52-76fa-4fcc-b37e-e9f0ecac0e9e
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Switch to Another Thread While Debugging in Visual Studio (C#, Visual Basic, C++)
When you debug a multithreaded application, you can use any one of several methods to switch from the thread that you have been working with to another thread.

> [!NOTE]
> If you want to control the order in which threads execute, you need to [freeze and thaw threads](../debugger/get-started-debugging-multithreaded-apps.md).

When you examine threads in the code editor and the different multithreaded debugging windows, the yellow arrow indicates the current thread. A green arrow with a curly tail indicates that a non-current thread has the current debugger context.

### To switch to any thread that appears

- In the **Threads** or **Parallel Watch** window, double-click the thread.

### To switch to a thread in a source window

- In the left gutter, right-click a thread marker icon ![Thread Marker](../debugger/media/dbg-thread-marker.png "ThreadMarker"), point to **Switch to**, and then click the name of that thread to which you want to switch. The shortcut menu shows only the threads at that specific location.

     If no thread markers appear, right-click in the **Threads** window and verify that **Show Threads in Source** is selected.

### To switch to a thread in the Debug Location toolbar

1. On the **Debug Location** toolbar, click the **Thread** list.

2. In the list, click the thread to which you want to switch.

## See also
- [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)
