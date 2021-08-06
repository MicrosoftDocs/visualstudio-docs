---
title: Refresh the View | Microsoft Docs
description: See how to refresh a view in the Spy++ tool when debugging in Visual Studio. Spy++ takes a snapshot of the system tables and refreshes a view based on this information.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords: 
  - refreshing views
ms.assetid: 2ed0ba66-7259-486b-a518-aab6e45030aa
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# How to: Refresh the View
Spy++ takes a "snapshot" of the system tables and refreshes a view based on this information. It is important that you periodically refresh your system views. If you have a Spy++ view open and have not refreshed the view, you will not see those processes, threads, and windows that are subsequently created. Also, you may see items that no longer exist. The **Refresh** command is available for all views except the Messages view.

### To refresh the currently active view

- Choose **Refresh** from the **Window** menu, or click the **Refresh** button in the toolbar.

## See also
- [Using Spy++](../debugger/using-spy-increment.md)
- [SSpy++ Views](../debugger/spy-increment-views.md)
- [Spy++ Reference](../debugger/spy-increment-reference.md)