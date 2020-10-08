---
title: "Space Tab, Process Properties Dialog Box | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
helpviewer_keywords:
  - "Process properties for Windows NT"
ms.assetid: c4de1866-7447-48f7-aa88-28ad92c0b930
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Space Tab, Process Properties Dialog Box
Use the **Space** tab to examine the address space of a process. To display the [Process Properties Dialog Box](../debugger/process-properties-dialog-box.md), move the focus to a [Processes View](../debugger/processes-view.md) window. Select any process node in the tree, then choose **Properties** from the **View** menu.

 The following settings are available on the **Space** tab:

|Entry|Description|
|-----------|-----------------|
|**Show for space marked as**|Use this list box to select the category of space (image, mapped, reserved, or unassigned).|
|**Executable Bytes**|For the selected category, the sum of all the address space that this process is using. Executable memory is memory that can be executed by programs, but may not be read or written.|
|**Exec-Read-Only Bytes**|For the selected category, the sum of all the address space in use with read-only properties that this process is using. Exec-read-only memory is memory that can be executed as well as read.|
|**Exec-Read-Write Bytes**|For the selected category, the sum of all the address space in use with read-write properties that this process is using. Exec-read-write memory is memory that can be executed by programs as well as read and modified.|
|**Exec-Write Copy Bytes**|For the selected category, the sum of all the address space that can be executed by programs as well as read and written. This type of protection is used when memory needs to be shared between processes. If the sharing processes only read the memory, then they will all use the same memory. If a sharing process desires write access, then a copy of this memory will be made for the process.|
|**No-Access Bytes**|For the selected category, the sum of all the address space that prevents a process from using it. An access violation is generated if writing or reading is attempted.|
|**Read-Only Bytes**|For the selected category, the sum of all the address space that can be executed as well as read.|
|**Read-Write Bytes**|For the selected category, the sum of all the address space that allows reading and writing.|
|**Write-Copy Bytes**|For the selected category, the sum of all the address space that allows memory sharing for reading but not for writing. When processes are reading this memory, they can share the same memory. However, when a sharing process wants to have read/write access to this shared memory, a copy of that memory is made for writing.|