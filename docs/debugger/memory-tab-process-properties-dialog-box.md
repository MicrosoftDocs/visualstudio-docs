---
title: "Memory Tab, Process Properties Dialog Box | Microsoft Docs"
description: Use the Memory tab of Process Properties to view how a process uses memory. There is information about space used, shared space, and virtual space used.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
helpviewer_keywords:
  - "Process properties for Windows NT"
ms.assetid: a70785f2-5997-40ec-a90f-80a52449768b
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Memory Tab, Process Properties Dialog Box
Use the **Memory** tab to show how a process uses memory. To display the [Process Properties Dialog Box](../debugger/process-properties-dialog-box.md), move the focus to a [Processes View](../debugger/processes-view.md) window. Select any process node in the tree, then choose **Properties** from the **View** menu.

 The following settings are available on the **Memory** tab:

|Entry|Description|
|-----------|-----------------|
|**Virtual Bytes**|The current size (in bytes) of the virtual address space the process is using. The use of virtual address space does not necessarily imply corresponding use of either disk or main memory pages. However, virtual space is finite, and using too much may limit the ability of the process to load libraries.|
|**Peak Virtual Bytes**|The maximum number of bytes of virtual address space the process has used at any one time.|
|**Working Set**|The set of memory pages touched recently by the threads in the process. If free memory in the computer is above a threshold, pages are left in the Working Set of a process even if they are not in use. When free memory falls below a threshold, pages are trimmed from the Working Set. If they are needed, they will be soft-faulted back into the Working Set before they leave main memory.|
|**Peak Working Set**|The maximum number of pages in the working set of this process at any point in time.|
|**Paged Pool Bytes**|The current amount of paged pool the process has allocated. Paged pool is a system memory area where operating system components acquire space as they accomplish their appointed tasks. Paged pool pages can be paged out to the paging file when not accessed by the system for sustained periods of time.|
|**Nonpaged Pool Bytes**|The current number of bytes in the nonpaged pool allocated by the process. The nonpaged pool is a system memory area where space is acquired by operating system components as they accomplish their appointed tasks. Nonpaged pool pages cannot be paged out to the paging file; they remain in main memory as long as they are allocated.|
|**Private Bytes**|The current number of bytes this process has allocated that cannot be shared with other processes.|
|**Free Bytes**|The total unused virtual address space of this process.|
|**Reserved Bytes**|The total amount of virtual memory reserved for future use by this process.|
|**Free Image Bytes**|The amount of virtual address space that is not in use or reserved by images within this process.|
|**Reserved Image Bytes**|The sum of all virtual memory reserved by images run within this process.|