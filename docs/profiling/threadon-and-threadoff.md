---
title: "ThreadOn and ThreadOff | Microsoft Docs"
description: Learn how the VSPerfCmd.exe ThreadOff and ThreadOn subcommands are only available in command-line profiling sessions that use the instrumentation method.
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 5cd5a695-0a14-484a-8952-ed47e13d8e92
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# ThreadOn and ThreadOff
The *VSPerfCmd.exe* **ThreadOff** and **ThreadOn** subcommands are only available in command-line profiling sessions that use the instrumentation method. **ThreadOff** and **ThreadOn** pause and resume profiling for the specified thread. **ThreadOff** stops profiling the thread and **ThreadOn** starts profiling the thread.

 In most cases, you specify **ThreadOn** or **ThreadOff** as the only option in a *VSPerfCmd.exe* command line, but they can also be combined with the **GlobalOn**, **GlobalOff**, **ProcessOn**, and **ProcessOff** subcommands.

 The **ThreadOn** and **ThreadOff** subcommands interact with the **GlobalOn** and **GlobalOff** subcommands that control data collection for all processes in a command-line profiling session, and the **ProcessOn** and **ProcessOff** subcommands that control data collection for a specified process.

 The **ThreadOff** and **ThreadOn** subcommands also affect the Thread Start/Stop count that is manipulated by profiler API functions.

- **ThreadOff** immediately sets the Thread Start/Stop Count to 0 and therefore pauses profiling.

- **ThreadOn** immediately sets the Thread Start/Stop Count to 1 and therefore resumes profiling.

  For more information, see [Profiling tools APIs](../profiling/profiling-tools-apis.md).

## Syntax

```cmd
VSPerfCmd.exe /{ThreadOff|ThreadOn}:TID [Options]

```

#### Parameters
 `TID`
 The integer identifier of the thread to start or stop.

## Valid options
 **ThreadOn** and **ThreadOff** can be specified on command lines that also contain the following subcommands.

 **Start:** `Method`
 Initializes the command-line profiling session and sets the specified profiling method.

 **GlobalOff**&#124;**GlobalOn**
 Stops or starts profiling for all processes in a command-line profiling session.

 {**ProcessOff**&#124;**ProcessOn**}**:**`TID`
 Stops or starts profiling for the specified process.

## Example
 In this example, the **ThreadOff** subcommand is used to stop collecting profiling data so that only application startup data is collected.

```cmd
; Initialize the profiler.
VSPerfCmd.exe /Start:Trace /Output:Instrument.vsp
; Start the instrumented application.
; Stop profiling the thread after startup.
VSPerfCmd.exe /ThreadOff:12345
; Shut down the target application.
; Close the profiler.
VSPerfCmd /Shutdown

```

## See also
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [Profile services](../profiling/command-line-profiling-of-services.md)
