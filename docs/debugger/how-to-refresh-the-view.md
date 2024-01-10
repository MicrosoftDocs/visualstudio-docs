---
title: Refresh the View in the Spy++ tool when debugging
description: Refresh a view in the Spy++ tool when debugging in Visual Studio by taking a snapshot of the system tables and updating your view based on the snapshot.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords: 
  - refreshing views
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.subservice: vs-ide-debug
---
# Refresh the View

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Spy++ takes a "snapshot" of the system tables and refreshes a view based on this information. It is important that you periodically refresh your system views. If you have a Spy++ view open and have not refreshed the view, you will not see those processes, threads, and windows that are subsequently created. Also, you may see items that no longer exist. The **Refresh** command is available for all views except the Messages view.

### To refresh the currently active view

- Choose **Refresh** from the **Window** menu, or click the **Refresh** button in the toolbar.

## Related content
- [Using Spy++](../debugger/using-spy-increment.md)
- [SSpy++ Views](../debugger/spy-increment-views.md)
- [Spy++ Reference](../debugger/spy-increment-reference.md)