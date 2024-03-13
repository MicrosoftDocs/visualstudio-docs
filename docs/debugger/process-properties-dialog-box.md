---
title: "Spy++ Process Properties dialog box"
description: "Use Process Properties to find out more about a process that you select in Processes view. There are four tabs: General, memory, Page File, and Space."
ms.date: 02/05/2024
ms.topic: "ui-reference"
helpviewer_keywords:
  - "Spy++. process properties"
  - "process properties, Spy++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Process Properties dialog box

Use this dialog box to find out more about a specific process. To display this dialog box, move the focus to a [Processes view](processes-view.md) window. Select any process node in the tree, then choose **Properties** from the **View** menu.

## General tab, Process Properties

Use the **General** tab to find out more about a specific process. The following settings are available:

|Entry|Description|
|-----------|-----------------|
|**Module Name**|The name of the module.|
|**Process ID**|The unique ID of this process. Process ID numbers are reused, so they identify a process only for the lifetime of that process. The Process object type is created when a program is run. All the threads in a process share the same address space and have access to the same data.|
|**Priority Base**|The current base priority of this process. Threads within a process can raise and lower their own base priority relative to the process's base priority.|
|**Threads**|The number of threads currently active in this process.|
|**CPU Time**|Total CPU time spent on this process and its threads. Equal to User Time plus Privileged Time.|
|**User Time**|The cumulative elapsed time that this process's threads have spent executing code in User Mode in non-idle threads. Applications execute in User Mode, as do subsystems such as the window manager and the graphics engine.|
|**Privileged Time**|The total elapsed time this process has been running in Privileged Mode in non-idle threads. The service layer, the Executive routines, and the Kernel execute in Privileged Mode. Device drivers for most devices other than graphics adapters and printers also execute in Privileged Mode. Some work that Windows does for your application might appear in other subsystem processes in addition to Privileged Time.|
|**Elapsed Time**|The total elapsed time this process has been running.|

## Memory tab, Process Properties

Use the **Memory** tab to show how a process uses memory. The following settings are available:

|Entry|Description|
|-----------|-----------------|
|**Virtual Bytes**|The current size (in bytes) of the virtual address space the process is using. The use of virtual address space doesn't necessarily imply corresponding use of either disk or main memory pages. However, virtual space is finite, and using too much might limit the ability of the process to load libraries.|
|**Peak Virtual Bytes**|The maximum number of bytes of virtual address space the process has used at any one time.|
|**Working Set**|The set of memory pages touched recently by the threads in the process. If free memory in the computer is above a threshold, pages are left in the Working Set of a process even if they're not in use. When free memory falls below a threshold, pages are trimmed from the Working Set. If they're needed, they're soft-faulted back into the Working Set before they leave main memory.|
|**Peak Working Set**|The maximum number of pages in the working set of this process at any point in time.|
|**Paged Pool Bytes**|The current amount of paged pool allocated by the process. Paged pool is a system memory area where operating system components acquire space as they accomplish their appointed tasks. Paged pool pages can be paged out to the paging file when not accessed by the system for sustained periods of time.|
|**Nonpaged Pool Bytes**|The current number of bytes in the nonpaged pool allocated by the process. The nonpaged pool is a system memory area where space is acquired by operating system components as they accomplish their appointed tasks. Nonpaged pool pages can't be paged out to the paging file; they remain in main memory as long as they're allocated.|
|**Private Bytes**|The current number of bytes allocated by this process that can't be shared with other processes.|
|**Free Bytes**|The total unused virtual address space of this process.|
|**Reserved Bytes**|The total amount of virtual memory reserved for future use by this process.|
|**Free Image Bytes**|The amount of virtual address space that isn't in use or reserved by images within this process.|
|**Reserved Image Bytes**|The sum of all virtual memory reserved by images run within this process.|

## Page File tab, Process Properties

Use the **Page File** tab to examine the paging file of a process. The following settings are available:

|Entry|Description|
|-----------|-----------------|
|**Page File Bytes**|The current number of pages that this process is using in the paging file. The paging file stores pages of data used by the process but not contained in other files. The paging file is used by all processes, and lack of space in the paging file can cause errors while other processes are running.|
|**Peak Page File Bytes**|The maximum number of pages that this process has used in the paging file.|
|**Page Faults**|The number of Page Faults by the threads executing in this process. A page fault occurs when a thread refers to a virtual memory page that isn't in its working set in main memory. Thus, the page isn't retrieved from disk if it's on the standby list and hence already in main memory, or if it's being used by another process with which the page is shared.|

## Space tab, Process Properties

Use the **Space** tab to examine the address space of a process. The following settings are available:

|Entry|Description|
|-----------|-----------------|
|**Show for space marked as**|Use this list box to select the category of space (image, mapped, reserved, or unassigned).|
|**Executable Bytes**|For the selected category, the sum of all the address space that this process is using. Executable memory is memory that can be executed by programs, but might not be read or written.|
|**Exec-Read-Only Bytes**|For the selected category, the sum of all the address space in use with read-only properties that this process is using. Exec-read-only memory is memory that can be executed as well as read.|
|**Exec-Read-Write Bytes**|For the selected category, the sum of all the address space in use with read-write properties that this process is using. Exec-read-write memory is memory that can be executed by programs as well as read and modified.|
|**Exec-Write Copy Bytes**|For the selected category, the sum of all the address space that can be executed by programs as well as read and written. This type of protection is used when memory needs to be shared between processes. If the sharing processes only read the memory, then they all use the same memory. If a sharing process desires write access, then a copy of this memory is made for the process.|
|**No-Access Bytes**|For the selected category, the sum of all the address space that prevents a process from using it. An access violation is generated if writing or reading is attempted.|
|**Read-Only Bytes**|For the selected category, the sum of all the address space that can be executed as well as read.|
|**Read-Write Bytes**|For the selected category, the sum of all the address space that allows reading and writing.|
|**Write-Copy Bytes**|For the selected category, the sum of all the address space that allows memory sharing for reading but not for writing. When processes are reading this memory, they can share the same memory. However, when a sharing process wants to have read/write access to this shared memory, a copy of that memory is made for writing.|

## Related sections

- [Searching for a process in Processes view](how-to-search-for-a-process-in-processes-view.md): Explains how to find a specific process in Processes View.
- [Process Search dialog box](search-tools-for-spy-increment-views.md#process-search): Used to find the node for a specific process in Process view.
- [Spy++ reference](spy-increment-reference.md): Includes sections describing each Spy++ menu and dialog box.
- [Processes view](processes-view.md): Displays a tree view of active processes.
- [Using Spy++](using-spy-increment.md): Introduces the Spy++ tool and explains how it can be used.