---
title: "How to: Refresh the View | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "refreshing views"
ms.assetid: 2ed0ba66-7259-486b-a518-aab6e45030aa
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Refresh the View
Spy++ takes a "snapshot" of the system tables and refreshes a view based on this information. It is important that you periodically refresh your system views. If you have a Spy++ view open and have not refreshed the view, you will not see those processes, threads, and windows that are subsequently created. Also, you may see items that no longer exist. The **Refresh** command is available for all views except the Messages view.  
  
### To refresh the currently active view  
  
-   Choose **Refresh** from the **Window** menu, or click the **Refresh** button in the toolbar.  
  
## See Also  
 [Using Spy++](../debugger/using-spy-increment.md)   
 [Spy++ Views](../debugger/spy-increment-views.md)   
 [Spy++ Reference](../debugger/spy-increment-reference.md)