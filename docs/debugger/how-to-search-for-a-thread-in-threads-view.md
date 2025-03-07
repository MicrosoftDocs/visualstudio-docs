---
title: Search for a thread in Threads view
description: Search for a specific thread in the Spy++ tool's Threads view by using its thread ID or module string as search criteria when debugging in Visual Studio.
ms.date: 02/05/2024
ms.topic: how-to
helpviewer_keywords: 
  - threads, searching
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Search for a thread in Threads view

You can search for a specific thread in Threads view by using its thread ID or module string as search criteria. You can also specify the initial direction of the search. The fields in the dialog box show the attributes of the selected thread in the thread tree.

### To search for a thread in Threads view

1. Arrange your windows so that Spy++ and an active [Threads view](/previous-versions/visualstudio/visual-studio-2017/debugger/threads-view) window are visible.

2. From the **Search** menu, choose **Find Thread**.

    The [Thread Search dialog box](search-tools-for-spy-increment-views.md#thread-search) opens.

3. Type the thread ID or a module string as search criteria.

4. Clear any fields for which you don't want to specify values.

   > [!TIP]
   > To find all the threads owned by a module, clear the **Thread** text box and type the module name in the **Module** box. Then use **Find Next** to continue searching for threads.

5. Choose **Up** or **Down** for the initial direction of the search.

6. Select **OK**.

   If a matching thread is found, it's highlighted in the Threads view window.