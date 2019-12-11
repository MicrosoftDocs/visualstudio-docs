---
title: "How to: Search for a Thread in Threads View | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "threads, searching"
ms.assetid: 5609a9b3-c279-4426-9e2e-dd87896a6d6f
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Search for a Thread in Threads View
You can search for a specific thread in Threads view by using its thread ID or module string as search criteria. You can also specify the initial direction of the search. The fields in the dialog box will show the attributes of the selected thread in the thread tree.

### To search for a thread in Threads view

1. Arrange your windows so that Spy++ and an active [Threads View](../debugger/threads-view.md) window are visible.

2. From the **Search** menu, choose **Find Thread**.

    The [Thread Search Dialog Box](../debugger/thread-search-dialog-box.md) opens.

3. Type the thread ID or a module string as search criteria.

4. Clear any fields for which you do not want to specify values.

   > [!TIP]
   > To find all the threads owned by a module, clear the **Thread** text box and type the module name in the **Module** box. Then use **Find Next** to continue searching for threads.

5. Choose **Up** or **Down** for the initial direction of the search.

6. Click **OK**.

   If a matching thread is found, it is highlighted in the Threads view window.