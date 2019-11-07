---
title: "PF | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: cdc0a094-a986-4629-bd1c-dd5fdca323dc
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# PF
The *VSPerfCmd.exe* **PF** option sets the profiling event that is sampled to page faults, and it optionally changes the number of page faults in a sampling interval from the default of 10.

> [!NOTE]
> **PF** cannot be used on 64-bit systems.

**PF** can only be used in a command line that also contains the **Launch** or the **Attach** option.

 By default, the sampling event is set to non-halted processor clock cycles and the sampling interval is set to 10,000,000. The **Timer**, **PF**, **Sys**, and **Counter** options enable you to set the sample event and sampling interval. The **GC** option collects .NET memory data at each allocation and garbage collection event. Only one of these options can be specified on a command line.

 The sampling event and sampling interval can be set only in the first command line that contains a **Launch** or an **Attach** option.

## Syntax

```cmd
VSPerfCmd.exe {/Launch:AppName|/Attach:PID} /PF[:Events] [Options]
```

#### Parameters
 `Events`
 An integer value that specifies the number of page fault events in a sampling interval. If `Events` is not specified, the interval is set to 10.

## Required options
 **PF** can only be specified on a command line that contains one of the following options.

 **Launch:** `AppName`
 Starts the profiler and the application specified by AppName.

 **Attach:** `PID`
 Attaches the profiler to the process specified by AppName.

## Invalid options
 The following options cannot be specified on the same command line as **PF**.

 **Timer**[**:**`Cycles`]
 Sets the sampling event to processor clock cycles and optionally sets the sampling interval to `Cycles`. The default Timer interval is 10,000,000.

 **Sys**[**:**`Events`]
 Sets the sampling event to calls from the profiled application to the operating system kernel (syscalls) and optionally sets the sampling interval to `Events`. The default Sys interval is 10.

 **Counter:** `Name`[`,Reload`[`,FriendlyName`]]
 Sets the sampling event to the CPU performance counter specified by `Name` and sets the sampling interval to `Reload`.

 **GC**[**:**{**Allocation**&#124;**Lifetime**}]
 Collects .NET memory data. By default (**Allocation**), data is collected at every memory allocation event. When the **Lifetime** parameter is specified, data is also collected at each garbage collection event.

## Example
 This example demonstrates how to set the profiling sample event to page faults and set the sampling interval to 20 page faults.

```cmd
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp
VSPerfCmd.exe /Launch:TestApp.exe /PF:20
```

## See also
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profile services](../profiling/command-line-profiling-of-services.md)
