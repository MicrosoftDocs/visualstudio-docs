---
title: "Detach | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: d9d1b52c-7f28-467d-b1e0-512afc4e46c9
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Detach
The VSPerfCmd.exe **Detach** option disconnects the profiler from the specified processes or all processes if none are specified. Profiling must have been initialized by using the sampling method.

 Profiling that was started with either the **Launch** or the **Attach** options can be disconnected with **Detach**. The profiler can be reattched by using subsequent **Attach** commands.

 **Detach** does not close the profiling data file. Use the **Shutdown** option to end profiling and close the data file.

> [!NOTE]
> If the **Start** option was specified with the **Crosssession** option, any calls to **VSPerfCmd /Attach** or to **VSPerfCmd /Detach** must also specify **Crosssession**.

## Syntax

```cmd
VSPerfCmd.exe /Detach[:PIDs|ProcessNames]
```

#### Parameters
 `PIDs|ProcessNames`
 `PID` - The numeric system identifer of one or more processes.

 `ProcessNames` - the name of the process. If multiple instances of the named process are running, results are unpredictable.

 Separate multiple processes with commas.

 If no process is specified, the profiler is detached from all profiled process.

## Valid options
 The following **VSPerfCmd** options can be combined with the **Attach** option on a single command line.

 **Crosssession**
 Enables profiling applications in sessions other than the logon session. Required if the **Start** option was specified with the **Crosssession** option.

## Example
 In this example, the **Detach** command suspends profiling and the **Shutdown** command closes the profiler data file.

```cmd
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp
VSPerfCmd.exe /Launch:TestApp.exe
;REM Excercise the application
VSPerfCmd.exe /Detach
VSPerfCmd.exe /Shutdown
```

## See also
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profile services](../profiling/command-line-profiling-of-services.md)
