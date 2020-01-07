---
title: "ProcessOn and ProcessOff | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: d3dc6a7e-bc0f-48a6-a4ec-f386348bb296
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# ProcessOn and ProcessOff
The VSPerfCmd.exe **ProcessOff** and **ProcessOn** subcommands pause and resume profiling for the specified process in a command-line profiling session. **ProcessOff** stops profiling the process and **ProcessOn** starts profiling the process.

 In most cases, you specify **ProcessOn** or **ProcessOff** as the only option in a VSPerfCmd.exe command line, but they can also be combined with the **GlobalOn**, **GlobalOff**, **ThreadOn**, and **ThreadOff** subcommands.

 The **ProcessOn** and **ProcessOff** subcommands interact with the **GlobalOn** and **GlobalOff** subcommands that control data collection for all processes in a command-line profiling session, and the **ThreadOn** and **ThreadOff** subcommands that control data collection for a specified thread.

 The **ProcessOff** and **ProcessOn** subcommands also affect the Process Start/Stop count that is manipulated by profiler API functions.

- **ProcessOff** immediately sets the Process Start/Stop Count to 0 and therefore pauses profiling.

- **ProcessOn** immediately sets the Process Start/Stop Count to 1 and therefore resumes profiling.

  For more information, see [Profiling Tools APIs](../profiling/profiling-tools-apis.md).

## Syntax

```cmd
VSPerfCmd.exe /{ProcessOff|ProcessOn}:PID [Options]

```

#### Parameters
 `PID`
 The integer identifier of the process to start or stop. Process IDs are listed on the **Process** tab of Windows Task Manager.

## Required Subcommands
 None

## Valid Subcommands
 **ProcessOn** and **ProcessOff** can be specified on command lines that also contain the following subcommands.

 **Start:** `Method`
 Initializes the command-line profiling session and sets the specified profiling method.

 **Launch:** `AppName`
 Starts the specified application and begins profiling with the sampling method.

 **Attach:** `PID`
 Begins profiling the specified process.

 **GlobalOff**&#124;**GlobalOn**
 Stops or starts profiling for all processes in a command-line profiling session.

 {**ThreadOff**&#124;**ThreadOn**}**:**`TID`
 Stops or starts profiling for the specified thread (instrumentation method only).

## Example
 In this example, the **ProcessOff** subcommand is used to collect profiling data for application startup.

```cmd
; Initialize the profiler.
VSPerfCmd.exe /Start:Trace /Output:Instrument.vsp
; Start the instrumented application.
; Stop profiling the process after startup.
VSPerfCmd.exe /ProcessOff:12345
; Shut down the target application.
; Close the profiler.
VSPerfCmd /Shutdown

```

## See also
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profile services](../profiling/command-line-profiling-of-services.md)
