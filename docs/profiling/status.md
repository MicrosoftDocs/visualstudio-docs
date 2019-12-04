---
title: "Status | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: ba656fa4-ef9d-4d8c-a3b6-739c3b5d23ae
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Status
The *VSPerfCmd.exe* **Status** option displays information about the state of the profiler and any processes that are currently being profiled.

 The **Status** option must be the only option specified on the command line. The profiler must be initialized with the *VSPerfCmd.exe* **Start** option before any status can be displayed.

## Syntax

```cmd
VSPerfCmd.exe /Status
```

#### Parameters
 None

## Remarks
 The **Status** option displays the following state information for the profiler.

 **Output File Name**
 The path and file name of the current profiler data file.

 **Collection Mode**
 SAMPLE or TRACE

 **Maximum Processes**
 The maximum number of processes that can be profiled at one time and the number of currently active processes.

 **Maximum Threads**
 The maximum number of threads that can be profiled at one time.

 **Number of Buffers**
 The number of memory buffers dedicated to writing profiling data.

 **Size of Buffers**
 The size in bytes of a memory buffer.

 The **Status** option displays the following state information for each process that is currently being profiled.

 **Process**
 The name of the profiled process.

 **Process ID**
 The system identifier of the process.

 **Num Threads**
 The number of threads currently executing.

 **Start/Stop Count**
 The primary internal profiler count to control data collection for this process. The count must be equal to one to collect data. The Start/Stop count can be manipulated by the profiler APIs and the VSPerfCmd options **GlobalOn**, **GlobalOff**, **ProcessOn**, **ProcessOff**, **ThreadOn**, and **ThreadOff**.

 **Suspend/Resume Count**
 The secondary internal profiler count to control data collection for this process. The count must be less than or equal to zero to collect data. The **Suspend/Resume** count can be manipulated only by the profiler APIs.

 **Users with access rights to monitor**
 Lists the names of users who have access to the profiler. Additional users can be granted access by using the VSPerfCmd.exe **Admin** option

## See also
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profile services](../profiling/command-line-profiling-of-services.md)
