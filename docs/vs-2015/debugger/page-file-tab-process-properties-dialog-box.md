---
title: "Page File Tab, Process Properties Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "Process properties for Windows NT"
ms.assetid: daf41a06-8a55-48f6-95f5-49a8416bd308
caps.latest.revision: 7
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Page File Tab, Process Properties Dialog Box
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Use the **Page File** tab to examine the paging file of a process. To display the [Process Properties Dialog Box](../debugger/process-properties-dialog-box.md), move the focus to a [Processes View](../debugger/processes-view.md) window. Select any process node in the tree, then choose **Properties** from the **View** menu.  
  
 The following settings are available on the **Page File** tab:  
  
|Entry|Description|  
|-----------|-----------------|  
|**Page File Bytes**|The current number of pages that this process is using in the paging file. The paging file stores pages of data used by the process but not contained in other files. The paging file is used by all processes, and lack of space in the paging file can cause errors while other processes are running.|  
|**Peak Page File Bytes**|The maximum number of pages that this process has used in the paging file.|  
|**Page Faults**|The number of Page Faults by the threads executing in this process. A page fault occurs when a thread refers to a virtual memory page that is not in its working set in main memory. Thus, the page will not be retrieved from disk if it is on the standby list and hence already in main memory, or if it is being used by another process with which the page is shared.|
