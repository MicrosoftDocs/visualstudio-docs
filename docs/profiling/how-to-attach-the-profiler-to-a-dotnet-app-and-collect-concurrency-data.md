---
title: "Attach the profiler to a .NET app to collect concurrency data | Microsoft Docs"
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: fdd41576-797e-4312-8520-fee7bb767e4a
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "dotnet"
---
# How to: Attach the profiler to a .NET Framework stand-alone application to collect concurrency data by using the command line
This article describes how to use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools command-line tools to attach the profiler to a running .NET Framework stand-alone (client) application and collect process and thread concurrency data.

> [!NOTE]
> To get the path to the profiling tools, see [Walkthrough: Using profiler APIs](../profiling/walkthrough-using-profiler-apis.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the command prompt window or add it to  the command itself. For more information, see [Specify the path to command-line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md).

 While the profiler is attached to the application, you can pause and resume data collection. To end a profiling session, the profiler must no longer be attached to the application and the Profiler must be explicitly shut down.

## Attach the profiler

#### To attach the profiler to a running .NET Framework application

1. Open a command prompt window.

2. Start the profiler. Type:

     [VSPerfCmd](../profiling/vsperfcmd.md) **/start:concurrency  /output:** `OutputFile` [`Options`]

     The [/output](../profiling/output.md)**:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.

     You can use any of the following options with the **/start:concurrency** option.

    |Option|Description|
    |------------|-----------------|
    |[/wincounter](../profiling/wincounter.md) **:** `WinCounterPath`|Specifies a Windows performance counter to be collected during profiling.|
    |[/automark](../profiling/automark.md) **:** `Interval`|Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms.|
    |[/events](../profiling/events-vsperfcmd.md) **:** `Config`|Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file.|

3. Start the target application in the typical way.

4. Attach the profiler to the target application. Type:

     **VSPerfCmd /attach:** `PID` [**/lineoff**] [**/targetclr:**`Version`]

    - `PID` specifies the process ID of the target application. You can view the process IDs of all running processes in Windows Task Manager.

    - [/lineoff](../profiling/lineoff.md) disables the collection of line number data.

    - [/targetclr](../profiling/targetclr.md) **:** `Version` specifies the version of the common language runtime (CLR) to profile when more than one version of the runtime is loaded in an application. Optional.

## Control data collection
 While the target application is running, you can control data collection by starting and stopping the writing of data to the file by using *VSPerfCmd.exe* options. Controlling data collection enables you to collect data for a specific part of program execution, such as the starting or shutting down of the application.

#### To start and stop data collection

- The following pairs of *VSPerfCmd.exe* options start and stop data collection. Specify each option on a separate command-line. You can turn data collection on and off multiple times.

    |Option|Description|
    |------------|-----------------|
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the process ID (`PID`).|
    |[/attach](../profiling/attach.md) **:**{`PID`&#124;`ProcName`} [/detach](../profiling/detach.md)[**:**{`PID`&#124;`ProcName`}]|**/attach** starts to collect data for the process specified by the process ID (`PID`) or process name (ProcName). **/detach** stops data collection for the specified process or for all processes if a specific process is not specified.|

## End the profiling session
 To end a profiling session, the profiler must not be collecting data. You can stop collecting data from a application profiled with the concurrency method by closing the application or by invoking the **VSPerfCmd /detach** option. You then invoke the **VSPerfCmd /shutdown** option to turn the profiler off and close the profiling data file. The **VSPerfClrEnv /off** command clears the profiling environment variables.

#### To end a profiling session

1. Do one of the following to detach the profiler from the target application.

    - Type **VSPerfCmd /detach**

         -or-

    - Close the target application.

2. Shut down the profiler. Type:

     VSPerfCmd[/shutdown](../profiling/shutdown.md)
