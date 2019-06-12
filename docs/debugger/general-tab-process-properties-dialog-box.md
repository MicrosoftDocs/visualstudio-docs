---
title: "General Tab, Process Properties Dialog Box | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
helpviewer_keywords:
  - "Process properties for Windows NT"
ms.assetid: 86f4d61d-a594-4aac-8960-c5279b4a10fd
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# General Tab, Process Properties Dialog Box
Use the **General** tab to find out more about a specific process. To display the [Process Properties Dialog Box](../debugger/process-properties-dialog-box.md), move the focus to a [Processes View](../debugger/processes-view.md) window. Select any process node in the tree, then choose **Properties** from the **View** menu.

 The following settings are available on the **General** tab:

|Entry|Description|
|-----------|-----------------|
|**Module Name**|The name of the module.|
|**Process ID**|The unique ID of this process. Process ID numbers are reused, so they identify a process only for the lifetime of that process. The Process object type is created when a program is run. All the threads in a process share the same address space and have access to the same data.|
|**Priority Base**|The current base priority of this process. Threads within a process can raise and lower their own base priority relative to the process's base priority.|
|**Threads**|The number of threads currently active in this process.|
|**CPU Time**|Total CPU time spent on this process and its threads. Equal to User Time plus Privileged Time.|
|**User Time**|The cumulative elapsed time that this process's threads have spent executing code in User Mode in non-idle threads. Applications execute in User Mode, as do subsystems such as the window manager and the graphics engine.|
|**Privileged Time**|The total elapsed time this process has been running in Privileged Mode in non-idle threads. The service layer, the Executive routines, and the Kernel execute in Privileged Mode. Device drivers for most devices other than graphics adapters and printers also execute in Privileged Mode. Some work that Windows does for your application may appear in other subsystem processes in addition to Privileged Time.|
|**Elapsed Time**|The total elapsed time this process has been running.|