---
title: "How to: Refresh the View | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "refreshing views"
ms.assetid: 2ed0ba66-7259-486b-a518-aab6e45030aa
caps.latest.revision: 8
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Refresh the View
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Spy++ takes a "snapshot" of the system tables and refreshes a view based on this information. It is important that you periodically refresh your system views. If you have a Spy++ view open and have not refreshed the view, you will not see those processes, threads, and windows that are subsequently created. Also, you may see items that no longer exist. The **Refresh** command is available for all views except the Messages view.  
  
### To refresh the currently active view  
  
- Choose **Refresh** from the **Window** menu, or click the **Refresh** button in the toolbar.  
  
## See Also  
 [Using Spy++](../debugger/using-spy-increment.md)   
 [Spy++ Views](../debugger/spy-increment-views.md)   
 [Spy++ Reference](../debugger/spy-increment-reference.md)
