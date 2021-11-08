---
title: "QueryCounters | Microsoft Docs"
description: Learn how the QueryCounters option lists the CPU (hardware) performance counters that are available on the computer.
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 8059d4b2-af61-4a47-a6c2-8da5c0741c74
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# QueryCounters
The **QueryCounters** option lists the CPU (hardware) performance counters that are available on the computer.

 **QueryCounters** must be the only option on the command line.

## Syntax

```cmd
VSPerfCmd.exe /QueryCounters
```

#### Parameters
 None

## Remarks
 When you are using the instrumentation method, the profiler can collect the values of one or more CPU performance counters at each data collection event. When you are using the sampling profiling method, you can specify one counter event and the number of event occurrences to be used as the sampling interval.

 Different processors expose different CPU performance counters. The profiler defines a set of generic counters that can be used on almost all processors. The **QueryCounters** option lists both the names of the generic counters and the names of the counters that are specific to the processor.

## See also
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profile services](../profiling/command-line-profiling-of-services.md)
