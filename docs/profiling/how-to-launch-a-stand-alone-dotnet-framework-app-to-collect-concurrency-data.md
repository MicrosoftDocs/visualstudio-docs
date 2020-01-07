---
title: "Profiler command line: Open client .NET app, get concurrency data"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 17a48848-bd3e-44ef-9971-e39836ff1df2
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "dotnet"
---
# How to: Launch a stand-alone .NET Framework application with the profiler to collect concurrency data by using the command line
This topic describes how to use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools command-line tools to start a .NET Framework stand-alone (client) application and collect process and thread concurrency data

> [!NOTE]
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.

 While the profiler is attached to the application, you can pause and resume data collection. To end a profiling session, the Profiler must no longer be attached to the application and the Profiler must be explicitly shut down.

## Start the application with the profiler
 To launch a .NET Framework target application with the Profiler, you use *VSPerfClrEnv.exe* to set the .NET Framework profiling variables. You then use the VSPerfCmd **/start** and **/launch** options to initialize the Profiler and start the application. You can specify **/start** and **/launch** and their respective options on a single command line. You can also add the **/globaloff** option to the command line to pause data collection when the target application starts. You then use **/globalon** on a separate command line to start to collect data.

#### To start an application with the profiler

1. Open a command prompt window.

2. Start the profiler. Type:

    [VSPerfCmd](../profiling/vsperfcmd.md) **/start:concurrency**[**,**{**ResourceOnly**&#124;**ThreadOnly**}] **/output:**`OutputFile` [`Options`]

   - The [/start](../profiling/start.md) option initializes the profiler.

     | | |
     |-------------------------------------| - |
     | **/start:concurrency** | Enables collecting both resource contention and thread execution data. |
     | **/start:concurrency,resourceonly** | Enables collecting only resource contention data. |
     | **/start:concurrency,threadonly** | Enables collecting only thread execution data. |

   - The [/output](../profiling/output.md)**:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.

     You can use any of the following options with the **/start:concurrency** option.

   | Option | Description |
   | - | - |
   | [/user](../profiling/user-vsperfcmd.md) **:**[`domain\`]`username` | Specifies the optional domain and user name of the account to be granted access to the profiler. |
   | [/crosssession](../profiling/crosssession.md) | Enables profiling of processes in other logon sessions. |
   | [/wincounter](../profiling/wincounter.md) **:** `WinCounterPath` | Specifies a Windows performance counter to be collected during profiling. |
   | [/automark](../profiling/automark.md) **:** `Interval` | Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms. |
   | [/events](../profiling/events-vsperfcmd.md) **:** `Config` | Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.*etl*) file. |

3. Start the target application. Type:

    **VSPerfCmd**  [/launch](../profiling/launch.md) **:** `AppName` [`Options`] [`Sample Event`]

    You can use any of the following options with the **/launch** option.

   |Option|Description|
   |------------|-----------------|
   |[/args](../profiling/args.md) **:** `Arguments`|Specifies a string that contains the command-line arguments to be passed to the target application.|
   |[/console](../profiling/console.md)|Starts the target command-line application in a separate window.|
   |[/targetclr](../profiling/targetclr.md) **:** `Version`|Specifies the version of the common language runtime (CLR) to profile when more than one version of the runtime is loaded in an application.|

## Control data collection
 While the target application is running, you can control data collection by starting and stopping the writing of data to the file by using *VSPerfCmd.exe* options. Controlling data collection enables you to collect data for a specific part of program execution, such as the starting or shutdown of the application.

#### To start and stop data collection

1. The following pairs of *VSPerfCmd.exe* options start and stop data collection. Specify each option on a separate command-line. You can turn data collection on and off multiple times.

    |Option|Description|
    |------------|-----------------|
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the process ID (`PID`).|
    |[/attach](../profiling/attach.md) **:**{`PID`&#124;`ProcName`} [/detach](../profiling/detach.md)[**:**{`PID`&#124;`ProcName`}]|**/attach** starts to collect data for the process specified by the process ID (`PID`) or process name (ProcName). **/detach** stops data collection for the specified process or for all processes if a specific process is not specified.|

## End the profiling session
 To end a profiling session, the profiler must not be collecting data. You can stop collecting concurrency data by closing the profiled application or by invoking the **VSPerfCmd /detach** option. You then invoke the **VSPerfCmd /shutdown** option to turn off the profiler and close the profiling data file. The **VSPerfClrEnv /off** command clears the profiling environment variables.

#### To end a profiling session

1. Do one of the following to detach the profiler from the target application.

    - Close the target application.

         -or-

    - Type **VSPerfCmd /detach**

2. Shut down the profiler

     **VSPerfCmd**  [/shutdown](../profiling/shutdown.md)

## See also
- [Collect concurrency data](../profiling/collecting-concurrency-data-for-stand-alone-applications.md)
