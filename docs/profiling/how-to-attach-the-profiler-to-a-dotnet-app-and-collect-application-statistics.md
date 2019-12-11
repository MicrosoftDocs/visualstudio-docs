---
title: "Attach profiler to .NET Framework stand-alone app; get app stats"
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: b62fcbc1-791f-474e-890a-a6c332e0c9ea
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "dotnet"
---
# How to: Attach the profiler to a .NET Framework stand-alone application and collect application statistics by using the command line
This article describes how to use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools command-line tools to attach the profiler to a running .NET Framework stand-alone (client) application and collect performance statistics by using the sampling method.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).
>
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.
>
> Adding tier interaction data to a profiling run requires specific procedures with the command line profiling tools. See [Collect tier interaction data](../profiling/adding-tier-interaction-data-from-the-command-line.md).

 To collect performance data from a .NET Framework application, the appropriate environment variables must be initialized before the target application starts. When the profiler is attached to the application, you can pause and resume data collection.

 To end a profiling session, the profiler must no longer be attached to the application and the profiler must be explicitly shut down. In most cases, we recommend clearing the profiling environment variables at the end of a profiling session.

## Attach the profiler

#### To attach the profiler to a running .NET Framework application

1. Open a Command Prompt window.

2. Initialize the profiling environment variables. Type:

    **VSPerfClrEnv /sampleon** [**/samplelineoff**]

   - The **/samplelineoff** option disables the collection of source code line number data.

3. Start the profiler. Type:

    **VSPerfCmd /start:sample /output:** `OutputFile` [`Options`]

   - The [/start](../profiling/start.md)**:sample** option initializes the profiler.

   - The [/output](../profiling/output.md)**:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.

     You can use any one of the following options with the **/start:sample** option.

   | Option | Description |
   | - | - |
   | [/user](../profiling/user-vsperfcmd.md) **:**[`Domain`**\\**]`UserName` | Specifies the optional domain and user name of the account that owns the profiled process. This option is required only if the profiled application has been started as a user other than the logged on user. |
   | [/crosssession](../profiling/crosssession.md) | Enables profiling of processes in other logon sessions. **/CS** can be specified as an abbreviation for **/crosssession**. This option is required if the application is running in a different session. |
   | [/wincounter](../profiling/wincounter.md) **:** `WinCounterPath` | Specifies a Windows performance counter to be collected during profiling. |
   | [/automark](../profiling/automark.md) **:** `Interval` | Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms. |
   | [/events](../profiling/events-vsperfcmd.md) **:** `Config` | Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.*etl*) file. |

4. If necessary, start the target application in the typical way.

5. Attach the profiler to the target application. Type:

    **VSPerfCmd /attach:**{`PID`&#124;`ProcessName`} [`Sample Event`] [**/targetclr:**`Version`]

   - `PID` specifies the process ID of the target application. `ProcessName` specifies the name of the process. Note that if you specify `ProcessName` and multiple processes that have the same name are running, results are unpredictable. You can view the process IDs of all running processes in Windows Task Manager.

   - [/targetclr](../profiling/targetclr.md) **:** `Version` specifies the version of the common language runtime (CLR) to profile when more than one version of the runtime is loaded in an application. Optional.

   - By default, performance data is sampled every 10,000,000 non-halted processor clock cycles. This is approximately one time every 10 seconds on a 1GH processor. You can specify one of the following options to change the clock cycle interval or to specify a different sampling event.[/targetclr](../profiling/targetclr.md)**:**`Version` specifies the version of the CLR to profile when more than one version of the runtime is loaded in an application. Optional.

   |||
   |-|-|
   |Sample event|Description|
   |[/timer](../profiling/timer.md) **:** `Interval`|Changes the sampling interval to the number of non-halted clock cycles that are specified by `Interval`.|
   |[/pf](../profiling/pf.md) [**:**`Interval`]|Changes the sampling event to page faults. If `Interval` is specified, sets the number of page faults between samples. Default is 10.|
   |[/sys](../profiling/sys-vsperfcmd.md) [**:**`Interval`]|Changes the sampling event to system calls from the process to the operating system kernel (syscalls). If `Interval` is specified, sets the number of calls between samples. Default is 10.|
   |[/counter](../profiling/counter.md) **:** `Config`|Changes the sampling event and interval to the processor performance counter and interval that are specified in `Config`.|

## Control data collection
 When the target application is running, you can control data collection by starting and stopping the writing of data to the profiler data file by using *VSPerfCmd.exe* options. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the application.

#### To start and stop data collection

- The following pairs of options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.

    |Option|Description|
    |------------|-----------------|
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process that is specified by the `PID`.|
    |[/attach](../profiling/attach.md) **:**{`PID`&#124;`ProcName`} [/detach](../profiling/detach.md)[**:**{`PID`&#124;`ProcName`}]|**/attach** starts to collect data for the process that is specified by the `PID` or process name (ProcName). **/detach** stops data collection for the specified process or for all processes if a specific process is not specified.|

## End the profiling session
 To end a profiling session, the profiler must be detached from all profiled processes and the profiler must be explicitly shut down. You can detach the profiler from an application that was profiled by using the sampling method by closing the application or by calling the **VSPerfCmd /detach** option. You then call the **VSPerfCmd /shutdown** option to turn the profiler off and close the profiling data file. The **VSPerfClrEnv /off** command clears the profiling environment variables.

#### To end a profiling session

1. Perform one of the following steps to detach the profiler from the target application:

    - Type **VSPerfCmd /detach**

         -or-

    - Close the target application.

2. Shut down the profiler. Type:

     **VSPerfCmd**  [/shutdown](../profiling/shutdown.md)

3. (Optional) Clear the profiling environment variables. Type:

     **VSPerfClrEnv /off**

## See also
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Sampling method data views](../profiling/profiler-sampling-method-data-views.md)
