---
title: Profiler command line - Open native client app, get concurrency data
description: Learn how to use the Visual Studio Profiling Tools command-line tools to start a native stand-alone client app and collect process and thread concurrency data.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: e5aed651-afed-4b70-9a7e-1a6032cc614f
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - cplusplus
---
# How to: Launch a stand-alone native application with the profiler to collect concurrency data by using the command line
This topic describes how to use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools command-line tools to start a native stand-alone (client) application and collect process and thread concurrency data.

 A profiling session has the following parts:

- Starting the application with the profiler

- Controlling data collection

- Ending the profiling session

> [!NOTE]
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.

## Start the application with the profiler
 To start a target application with the profiler, you use the [VSPerfCmd.exe](../profiling/vsperfcmd.md)**/start** and **/launch** options to initialize the Profiler and start the application. You can specify **/start** and **/launch** and their respective options. You can also add the **/globaloff** option to pause data collection at the start of the target application. You then use **/globalon** to begin to collect data.

#### To start an application with the profiler

1. At a command prompt, type the following command:

     [VSPerfCmd](../profiling/vsperfcmd.md) **/start:concurrency  /output:** `OutputFile` [`Options`]

     The [/output](../profiling/output.md)**:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.

     You can use any of the options in the following table with the **/start:concurrency** option.

    |Option|Description|
    |------------|-----------------|
    |[/wincounter](../profiling/wincounter.md) **:** `WinCounterPath`|Specifies a Windows performance counter to be collected during profiling.|
    |[/automark](../profiling/automark.md) **:** `Interval`|Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. The default value is 500.|
    |[/events](../profiling/events-vsperfcmd.md) **:** `Config`|Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file.|

2. Start the target application by typing:

     **VSPerfCmd**  [/launch](../profiling/launch.md) **:** `AppName` [`Options`]

     You can use any of the options in the following table with the **/launch** option.

    |Option|Description|
    |------------|-----------------|
    |[/args](../profiling/args.md) **:** `Arguments`|Specifies a string that contains the command-line arguments to be passed to the target application.|
    |[/console](../profiling/console.md)|Starts the target command-line application in a separate window.|
    |[/targetclr](../profiling/targetclr.md) **:** `CLRVersion`|Specifies the version of the common language runtime (CLR) to profile if the application loads more than one version of the CLR.|

## Control data collection
 While the target application is running, you can control data collection by starting and stopping the writing of data to the file with *VSPerfCmd.exe* options. By controlling data collection, you can collect data for a specific part of program execution, such as the starting or shutting down of the application.

#### To start and stop data collection

- The pairs of options in the following table start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.

    |Option|Description|
    |------------|-----------------|
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process that the process ID (`PID`) specifies.|
    |[/attach](../profiling/attach.md) **:**{`PID`&#124;`ProcName`} [/detach](../profiling/detach.md)[**:**{`PID`&#124;`ProcName`}]|**/attach** starts to collect data for the process that the process ID (`PID`) or process name (*ProcName*) specifies. **/detach** stops data collection for the specified process or for all processes if no process is specified.|

- You can also use the **VSPerfCmd.exe**[/mark](../profiling/mark.md) option to insert a profiling mark into the data file. The **/mark** command adds an identifier, a time stamp, and an optional user-defined text string. Marks can be used to filter the data in profiler reports and data views.

## End the profiling session
 To end a profiling session, the profiler must not be collecting data. You can stop collecting concurrency data by closing the profiled application or by invoking the **VSPerfCmd /detach** option. You then invoke the **VSPerfCmd /shutdown** option to turn off the profiler and close the profiling data file.

#### To end a profiling session

1. Detach the profiler from the target application by closing it or by typing the following command at a command prompt:

     **VSPerfCmd /detach**

2. Shut down the profiler by typing the following command at a command prompt:

     **VSPerfCmd**  [/shutdown](../profiling/shutdown.md)