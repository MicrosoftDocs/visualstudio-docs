---
title: "Attach profiler to native app and collect concurrency data"
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 12d3e0f3-4b74-4e66-8fbf-8ac99bd4f91c
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "cplusplus"
---
# How to: Attach the profiler to a native stand-alone application and collect concurrency data by using the command line
This article describes how to use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools command-line tools to attach the profiler to a running native (C/C++) stand-alone application and collect thread contention data.

> [!NOTE]
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.

 While the profiler is attached to the application, you can pause and resume data collection. To end a profiling session, the Profiler must no longer be attached to the application, and the Profiler must be explicitly shut down.

## Attach the profiler to a running native application

#### To attach the profiler to a running native application

1. At a command prompt, type the following command:

     [VSPerfCmd](../profiling/vsperfcmd.md) **/start:concurrency**

     You can use any of the options in the following table with the **/start:concurrency** option.

    |Option|Description|
    |------------|-----------------|
    |[/user](../profiling/user-vsperfcmd.md) **:**[`Domain\`]`Username`|Specifies the optional domain and user name of the account to be granted access to the profiler.|
    |[/crosssession](../profiling/crosssession.md)|Enables profiling of processes in other logon sessions.|
    |[/wincounter](../profiling/wincounter.md) **:** `WinCounterPath`|Specifies a Windows performance counter to be collected during profiling.|
    |[/automark](../profiling/automark.md) **:** `Interval`|Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. The default value is 500.|
    |[/events](../profiling/events-vsperfcmd.md) **:** `Config`|Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file.|

2. Attach the profiler to the target application by typing the following command:

     **VSPerfCmd**  [/attach](../profiling/attach.md) **:**{`PID`&#124;`ProcName`}

     `PID` specifies the process ID of the target application. You can view the process IDs of all running processes in Windows Task Manager.

## Control data collection
 While the target application is running, you can control data collection by starting and stopping the writing of data to the file by using *VSPerfCmd.exe* options. By controlling data collection, you can collect data for a specific part of program execution, such as the starting or shutting down of the application.

#### To start and stop data collection

- The pairs of options in the following table start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.

    |Option|Description|
    |------------|-----------------|
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process that the process ID (`PID`) specifies.|
    |[/attach](../profiling/attach.md) **:**{`PID`&#124;`ProcName`} [/detach](../profiling/detach.md)[**:**{`PID`&#124;`ProcName`}]|**/attach** starts to collect data for the process that the process ID (`PID`) or process name (*ProcName*) specifies. **/detach** stops data collection for the specified process or for all processes if no process is specified.|

## End the profiling session
 To end a profiling session, the profiler must not be collecting data. You can stop collecting data from an application that is profiled with the sampling method by closing the application or by invoking the **VSPerfCmd /detach** option. You then invoke the **VSPerfCmd /shutdown** option to turn the profiler off and close the profiling data file.

#### To end a profiling session

1. Detach the profiler from the target application by closing it or by typing the following command:

     **VSPerfCmd /detach**

2. Shut down the profiler by typing the following command:

     **VSPerfCmd**  [/shutdown](../profiling/shutdown.md)
