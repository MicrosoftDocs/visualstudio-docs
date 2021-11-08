---
title: Attach performance tools to running processes
description: Learn to use the Visual Studio profiler to attach to or detach from a running process to make sampling and gathering performance data easier.

ms.date: 11/04/2016
ms.topic: how-to
f1_keywords: 
  - vs.performance.attach
helpviewer_keywords: 
  - performance tools, attach process
  - profiling tools, detach process
  - profiling tools, attach process
  - performance tools, detach process
  - profiler
ms.assetid: 56a99c39-e7f6-4f48-ae56-04ab8e022bf7
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# How to: Attach and detach performance tools to running processes
The profiler can be used to attach to or detach from a running process to make sampling and gathering performance data easier. You can use this method to profile a process when you want to avoid gathering data about application load time, or to monitor the performance of a process after it reaches a specific state.

> [!NOTE]
> The following steps apply to attaching and detaching processes from within the [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)] integrated development environmnent (IDE). For information about how to use command line tools, see [Profile from the command-line](../profiling/using-the-profiling-tools-from-the-command-line.md). For information about how to profile services, see [Profile services](../profiling/command-line-profiling-of-services.md).

 The processes that are available to profile depend on the User Access Permissions that are set by an administrator of the computer. A User account may, for example, have permission for any of the following:

- Advanced profiling features, when the administrator has set the driver and service to start.

- Sample profiling only (domain users).

- Deny access to profiling to everybody.

  For more information, see [Profiling and Windows Vista security](../profiling/profiling-and-windows-vista-security.md) and the ADMIN options in [VSPerfCmd](../profiling/vsperfcmd.md).

### To attach to a running process

1. On the **Debug** menu, point to **Profiler**, then **Performance Explorer**, and then click **Attach**.

     The **Attach Profiler to Process** dialog box appears.

2. Click the name of the process that you want to attach to.

3. Click **Attach**.

### To detach from a running process

1. n the **Debug** menu, point to **Profiler**, then **Performance Explorer**, and then click **Detach**.

     The **Attach Profiler to Process** dialog box appears.

2. Click the image name from which you want to detach.

3. Click **Detach**.

## See also
- [Control data collection](../profiling/controlling-data-collection.md)
- [Performance session overview](../profiling/performance-session-overview.md)
- [How to: Start and end performance data collection](../profiling/how-to-start-and-end-performance-data-collection.md)
- [Profiling and Windows Vista security](../profiling/profiling-and-windows-vista-security.md)
- [VSPerfCmd](../profiling/vsperfcmd.md)
