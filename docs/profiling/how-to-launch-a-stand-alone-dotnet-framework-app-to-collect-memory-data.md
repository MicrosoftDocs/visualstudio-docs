---
title: Profiler command line - Open client .NET Framework app, get memory data
description: Learn how to use the Visual Studio Profiling Tools command-line tools to start a .NET Framework stand-alone app and collect memory activity data.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: 3bc53041-91b7-4ad0-8413-f8bf2c4b3f5e
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - dotnet
---
# How to: Launch a stand-alone .NET Framework application with the profiler to collect memory data by using the command line
This topic describes how to use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools command-line tools to start a .NET Framework stand-alone (client) application and collect memory data.

 A profiling session has three parts:

- Starting the application by using the profiler.

- Collecting profiling data.

- Ending the profiling session.

> [!NOTE]
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.

## Start the application with the profiler
 To start a target application by using the profiler, you use the **VSPerfCmd.exe/start** and **/launch** options to initialize the profiler and start the application. You can specify **/start** and **/launch** and their respective options on one command line.

 You can also add the **/globaloff** options to pause data collection at the start of the target application. You then use **/globalon** to start to collect data.

#### To start an application by using the profiler

1. Open a Command Prompt window.

2. Start the profiler. Type:

    **VSPerfCmd /start:sample /output:** `OutputFile` [`Options`]

   - The [/start](../profiling/start.md)**:sample** option initializes the profiler.

   - The [/output](../profiling/output.md)**:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.

     You can use any of the following options with the **/start:sample** option.

   | Option | Description |
   | - | - |
   | [/wincounter](../profiling/wincounter.md) **:** `WinCounterPath` | Specifies a Windows performance counter to be collected during profiling. |
   | [/automark](../profiling/automark.md) **:** `Interval` | Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms. |

3. Start the target application. Type:

    **VSPerfCmd**  [/launch](../profiling/launch.md) **:** `appName` **/gc:**{**allocation**&#124;**lifetime**}[`Options`]

   - The [/gc](../profiling/gc-vsperfcmd.md)**:**`Keyword` option is required to collect .NET Framework memory data. The keyword parameter specifies whether to collect memory allocation data, or to collect both memory allocation and object lifetime data.

     |Keyword|Description|
     |-------------|-----------------|
     |**allocation**|Collect memory allocation data only.|
     |**lifetime**|Collect both memory allocation and object lifetime data.|

     You can use any of the following options with the **/launch** option.

   |Option|Description|
   |------------|-----------------|
   |[/args](../profiling/args.md) **:** `Arguments`|Specifies a string that contains the command-line arguments to be passed to the target application.|
   |[/console](../profiling/console.md)|Starts the target command-line application in a separate window.|
   |[/events](../profiling/events-vsperfcmd.md) **:** `Config`|Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file.|
   |[/targetclr](../profiling/targetclr.md) **:** `Version`|Specifies the version of the common language runtime (CLR) to profile when more than one version of the runtime is loaded in an application.|

## Control data collection
 When the target application is running, you can control data collection by starting and stopping the writing of data to the file by using *VSPerfCmd.exe* options. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the application.

#### To start and stop data collection

- The following pairs of options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.

    |Option|Description|
    |------------|-----------------|
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process that is specified by the process ID (`PID`).|
    |[/attach](../profiling/attach.md) **:** `PID` [/detach](../profiling/detach.md)|**/attach** starts to collect data for the process that is specified by `PID` (the process ID). **/detach** stops data collection for all processes.|

- You can also use the **VSPerfCmd.exe**[/mark](../profiling/mark.md) option to insert a profiling mark into the data file. The **/mark** command adds an identifier, a time stamp, and an optional user-defined text string. Marks can be used to filter the data.

## End the profiling session
 To end a profiling session, the profiler must be detached from all profiled processes and the profiler must be explicitly shut down. You can detach the profiler from an application that was profiled by using the sampling method by closing the application or by calling the **VSPerfCmd /detach** option. You then call the **VSPerfCmd /shutdown** option to turn off the profiler and close the profiling data file. The **VSPerfClrEnv /off** command clears the profiling environment variables.

#### To end a profiling session

1. Perform one of the following steps to detach the profiler from the target application:

    - Close the target application.

         -or-

    - Type **VSPerfCmd /detach**

2. Shut down the profiler. Type:

     **VSPerfCmd**  [/shutdown](../profiling/shutdown.md)

## See also
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [.NET memory data views](../profiling/dotnet-memory-data-views.md)
