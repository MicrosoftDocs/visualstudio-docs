---
title: "Start | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: b85d0fe9-f67a-4b7c-8d48-7eecf3f2dfe9
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Start
The **Start** option is a *VSPerfCmd.exe* option that initializes the profiler to the specified profiling method.

## Syntax

```cmd
VSPerfCmd.exe /Start:Method /Output:FileName [Options]
```

#### Parameters
 `Method`
 Must be one of the following keywords:

- **TRACE** - Specifies the instrumentation method.

- **SAMPLE** - Specifies the sampling method.

- **COVERAGE** - Specifies code coverage.

- **CONCURRENCY** - Specifies the resource contention method.

## Required options
 The **Output** option must be specified when **Start** is specified on the command line.

 **Output:** `filename`
 Specifies the output file name.

## Exclusive options
 The following options can only be used with the **Start** option on a command line.

 **CrossSession**&#124;**CS**
 Enables cross-process profiling. The option names **CrossSession** and **CS** are both supported.

 **User:**[`domain\`]`username`
 Enables client access to the monitor from the specified account.

 **WinCounter:** `Path` [**Automark**:`n`]
 **WinCounter** specifies a Windows performance counter to include as a mark in the profiling data file. **AutoMark** specifies the interval in milliseconds between collections of the data file.

## Invalid options
 The following options cannot be used with the **Start** option on a command line.

 **Status**
 **Status** applies to those processes that are profiled. It lists processes and threads and their current profile state (On/Off). For example, if a process is stopped, **Status** will not indicate this in the report. **Status** will show that the process is either profiled or not.

 **Shutdown**[**:**`Timeout`]
 Turns the profiler off.

## Example
 The following example demonstrates how to use the *VSPerfCmd.exe* **Start** option to initialize the profiler.

```cmd
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp
VSPerfCmd.exe /Launch:TestApp.exe
```

## See also
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profile services](../profiling/command-line-profiling-of-services.md)
