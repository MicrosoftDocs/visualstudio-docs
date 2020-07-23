---
title: Attach profiler to .NET service to collect app statistics
ms.custom: seodec18
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: a0046c47-26c8-4bec-96a0-81da05e5104a
author: mikejo5000
ms.author: mikejo
manager: jillfra
monikerRange: 'vs-2017'
ms.workload: 
  - dotnet
---
# How to: Attach the profiler to a .NET service to collect application statistics by using the command line
This article describes how to use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools command-line tools to attach the profiler to a .NET Framework service and collect performance statistics by using the sampling method.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).
>
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.
>
> Adding tier interaction data to a profiling run requires specific procedures with the command line profiling tools. See [Collect tier interaction data](../profiling/adding-tier-interaction-data-from-the-command-line.md).

 To collect performance data from a .NET Framework service, you must use the [VSPerfCLREnv.cmd](../profiling/vsperfclrenv.md) tool to initialize the appropriate environment variables. You must then restart the computer that hosts the service and configure that computer for profiling. You then attach the profiler to the service process. When the profiler is attached to the service, you can pause and resume data collection.

 To end a profiling session, the profiler must be detached from the service and the profiler must be explicitly shut down. In most cases, we recommend clearing the profiling environment variables at the end of a session.

## Attach the profiler

#### To attach the profiler to a .NET Framework service

1. Install the service.

2. Open a command prompt window.

3. Initialize the profiling environment variables. Type:

    **VSPerfClrEnv /globalsampleon** [**/samplelineoff**]

   - **/globalsampleon** enables sampling.

   - **/samplelineoff** disables the assignment of collected data to specific source code lines. When this option is specified, data is assigned only to functions.

4. Restart the computer.

5. Open a command prompt window.

6. Start the profiler. Type:

    **VSPerfCmd**  [/start](../profiling/start.md) **:sample**  [/output](../profiling/output.md) **:** `OutputFile` [`Options`]

   - The **/start:sample** option initializes the profiler.

   - The **/output:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.

     You can use any of the following options with the **/start:sample** option.

   > [!NOTE]
   > The **/user** and **/crosssession** options are usually required for services.

   | Option | Description |
   | - | - |
   | [/user](../profiling/user-vsperfcmd.md) **:**[`Domain`**\\**]`UserName` | Specifies the domain and user name of the account that owns the profiled process. This option is required only if the process is running as a user other than the logged on user. The process owner is listed in the User Name column on the Processes tab of Windows Task Manager. |
   | [/crosssession](../profiling/crosssession.md) | Enables profiling of processes in other sessions. This option is required if the service is running in a different session. The session id is listed in the Session ID column on the Processes tab of Windows Task Manager. **/CS** can be specified as an abbreviation for **/crosssession**. |
   | [/wincounter](../profiling/wincounter.md) **:** `WinCounterPath` | Specifies a Windows performance counter to be collected during profiling. |
   | [/automark](../profiling/automark.md) **:** `Interval` | Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms. |
   | [/events](../profiling/events-vsperfcmd.md) **:** `Config` | Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file. |

7. If necessary, start the service.

8. Attach the profiler to the service. Type:

    **VSPerfCmd**  [/attach](../profiling/attach.md) **:** {`PID`&#124;`ProcName`} [`Sample Event`] [[/targetclr](../profiling/targetclr.md)**:**`Version`]

   - Specify the process ID (`PID`) or process name (ProcName) of the service. You can view the process IDs and names of all running processes in Windows Task Manager.

     By default, performance data is sampled every 10,000,000 non-halted processor clock cycles. This is approximately 100 samples per second on a 1GH processor. You can specify one of the following options to change the clock cycle interval or to specify a different sampling event.

   |Sample Event|Description|
   |------------------|-----------------|
   |[/timer](../profiling/timer.md) **:** `Interval`|Changes the sampling interval to the number of non-halted clock cycles specified by `Interval`.|
   |[/pf](../profiling/pf.md)[**:**`Interval`]|Changes the sampling event to page faults. If `Interval` is specified, sets the number of page faults between samples. Default is 10.|
   |[/sys](../profiling/sys-vsperfcmd.md)[`:``Interval`]|Changes the sampling event to system calls from the process to the operating system kernel (syscalls). If `Interval` is specified, sets the number of calls between samples. Default is 10.|
   |[/counter](../profiling/counter.md) **:** `Config`|Changes the sampling event and interval to the processor performance counter and interval specified in `Config`.|

   - **targetclr:** `Version` specifies the version of the common language runtime (CLR) to profile when more than one version of the runtime is loaded in an application. Optional.

## Control data collection
 When the service is running, you can use *VSPerfCmd.exe* options to start and stop the writing of data to the profiler data file. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the application.

#### To start and stop data collection

- The following pairs of **VSPerfCmd** options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.

    |Option|Description|
    |------------|-----------------|
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the process ID (`PID`).|
    |**/attach:**{`PID`&#124;`ProcName`} [/detach](../profiling/detach.md)[:{`PID`&#124;`ProcName`}]|**/attach** starts to collect data for the process specified by the process ID or process name. **/detach** stops data collection for the specified process or for all processes if a specific process is not specified.|

## End the profiling session
 To end a profiling session, the profiler must be detached from all profiled processes and the profiler must be explicitly shut down. You can detach the from an application profiled with the sampling method by closing the application or by calling the **VSPerfCmd /detach** option. You then call the **VSPerfCmd /shutdown** option to turn the profiler off and close the profiling data file.

 The **VSPerfClrEnv /globaloff** command clears the profiling environment variables, but the system configuration is not reset until the computer is restarted.

#### To end a profiling session

1. Do one of the following to detach the profiler from the target application:

    - Stop the service.

         -or-

    - Type **VSPerfCmd /detach**

2. Shut down the profiler. Type:

     **VSPerfCmd /shutdown**

3. (Optional) Clear the profiling environment variables. Type:

     **VSPerfClrEnv /globaloff**

4. Restart the computer.

## See also
- [Profile services](../profiling/command-line-profiling-of-services.md)
- [Sampling method data views](../profiling/profiler-sampling-method-data-views.md)
