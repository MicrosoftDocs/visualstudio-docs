---
title: "How to: Flag and Unflag Threads"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "treads, switching [debugging]"
ms.assetid: 952d579d-6911-413e-b3e5-54e7e797e70c
caps.latest.revision: 33
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
# How to: Flag and Unflag Threads
You can flag a thread that you want to give special attention by marking it with an icon in the **Threads**, **Parallel Stacks**, **Parallel Watch**, and **GPU Threads** windows. This icon can help you and others distinguish flagged threads from other threads.  
  
 Flagged threads also receive special treatment in the **Thread** list on the **Debug Location** toolbar. This list can show all threads or only flagged threads. When you flag a thread, the **Thread** list automatically switches to show only flagged threads, but you can switch it back to show all threads as appropriate.  
  
### To flag or unflag a thread by using the Threads window  
  
-   In the **Threads** window, find the thread you are interested in and click the flag icon to select or clear the flag.  
  
### To unflag all threads  
  
-   In the **Threads** window, right-click any thread and then click **Unflag All Threads**.  
  
### To display only flagged threads  
  
-   Choose the flag button in the debugging window.  
  
### To flag Just My Code  
  
1.  On the toolbar at the top of the **Threads** window, click the flag icon.  
  
2.  In the drop-down list, click **Flag Just My Code**.  
  
### To flag threads that are associated with selected modules  
  
1.  On the toolbar of the **Threads** window, click the flag icon.  
  
2.  In the drop-down list, click **Flag Custom Module Selection**.  
  
3.  In the **Select Modules** dialog box, select the modules that you want.  
  
4.  (Optional) In the **Search** box, type a string to search for specific modules.  
  
5.  Click **OK**.  
  
## See Also  
 [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)   
 [Walkthrough: Debugging a Multithreaded Application](../debugger/walkthrough--debugging-a-multithreaded-application.md)