---
title: Search for a process in Processes view
description: Search for a specific process in the Spy++ tool's Processes view by using its process ID or module string as search criteria when debugging in Visual Studio.
ms.date: 02/05/2024
ms.topic: how-to
helpviewer_keywords: 
  - Processes view
  - processes, searching for
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Search for a process in Processes view

You can search for a specific process in the Processes view by using its process ID or module string as search criteria. You can also specify the initial direction of the search. The fields in the dialog box show the attributes of the selected process in the process tree.

To search for a process in Processes view:

1. Arrange your windows so that Spy++ and an active [Processes view](/previous-versions/visualstudio/visual-studio-2017/debugger/processes-view) window are visible.

2. From the **Search** menu, choose **Find Process**

    The [Process Search dialog box](search-tools-for-spy-increment-views.md#process-search) opens.

3. Type the process ID or a module string as search criteria.

4. Clear any fields for which you don't want to specify values.

   > [!TIP]
   > To find all the processes owned by a module, clear the **Process** box and type the module name in the **Module** box. Then use **Find Next** to continue searching for processes.

5. Choose **Up** or **Down** for the initial direction of the search.

6. Select **OK**.

   If a matching process is found, it's highlighted in the **Processes view** window.