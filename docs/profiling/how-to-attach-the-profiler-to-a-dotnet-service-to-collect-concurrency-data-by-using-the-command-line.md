---
title: "Attach profiler to .NET to collect concurrency data - Command line"
titleSuffix: ""
description: Use Visual Studio Profiling Tools to attach the profiler to a .NET Framework service and get process and thread concurrency data using the sampling method.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: ffbdfe37-8325-44be-bd36-2c8aab2dec7b
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - dotnet
---
# How to: Attach the profiler to a .NET service to collect concurrency data by using the command line
This article describes how to use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools command-line tools to attach the profiler to a .NET Framework service and collect process and thread concurrency data using the sampling method.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).

> [!NOTE]
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.

 To collect concurrency data, you attach the profiler to the service process. While the profiler is attached to the service, you can pause and resume data collection. To end a profiling session, the profiler must no longer be attached to the service and the profiler must be explicitly shut down. In most cases, we recommend clearing the profiling environment variables at the end of a session.

## Attach the profiler

#### To attach the profiler to a .NET Framework service

1. Install the service.

2. Open a command window.

3. Initialize the profiling environment variables. Type:

     [VSPerfClrEnv](../profiling/vsperfclrenv.md) **/globalsampleon** [**/samplelineoff**]

    - **/globalsampleon** enables sampling.

    - **/samplelineoff** disables the assignment of collected data to specific source code lines. When this option is specified, data is assigned only to functions.

4. Restart the computer.

5. Start the profiler. Type:

     [VSPerfCmd](../profiling/vsperfcmd.md) **/start:concurrency  /output:** `OutputFile` [`Options`]

     The [/output](../profiling/output.md)**:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.

     You can use any of the following options with the **/start** option.

    > [!NOTE]
    > The **/user** and **/crosssession** options are usually required for services.

    |Option|Description|
    |------------|-----------------|
    |[/user](../profiling/user-vsperfcmd.md) **:**[`Domain`**\\**]`UserName`|Specifies the domain and user name of the account that owns the profiled process. This option is required only if the process is running as a user other than the logged on user. The process owner is listed in the **User Name** column on the **Processes** tab of Windows Task Manager.|
    |[/crosssession](../profiling/crosssession.md)|Enables profiling of processes in other sessions. This option is required if the service is running in a different session. The session ID is listed in the **Session ID** column on the **Processes** tab of Windows Task Manager. **/CS** can be specified as an abbreviation for **/crosssession**.|
    |[/wincounter](../profiling/wincounter.md) **:** `WinCounterPath`|Specifies a Windows performance counter to be collected during profiling.|
    |[/automark](../profiling/automark.md) **:** `Interval`|Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms.|
    |[/events](../profiling/events-vsperfcmd.md) **:** `Config`|Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.*etl*) file.|

6. If necessary, start the service.

7. Attach the profiler to the service. Type:

     **VSPerfCmd /attach:** `PID` [[/targetclr](../profiling/targetclr.md)**:**`Version`]

    - `PID` specifies the process ID or process name of the service. You can view the process IDs of all running processes in Windows Task Manager.

    - **targetclr:** `Version` specifies the version of the common language runtime (CLR) to profile when more than one version of the runtime is loaded in an application. Optional.

## Control data collection
 While the service is running, you can control data collection by starting and stopping the writing of data to the file by using *VSPerfCmd.exe* options. Controlling data collection enables you to collect data for a specific part of program execution, such as the starting or shutdown of the application.

#### To start and stop data collection

- The following pairs of **VSPerfCmd** options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.

    |Option|Description|
    |------------|-----------------|
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the process ID (`PID`).|
    |**/attach:**{`PID`&#124;`ProcName`} [/detach](../profiling/detach.md)[:{`PID`&#124;`ProcName`}]|**/attach** starts to collect data for the process specified by the process ID or process name. **/detach** stops data collection for the specified process or for all processes if a specific process is not specified.|

- You can also use the **VSPerfCmd.exe**[/mark](../profiling/mark.md) option to insert a profiling mark into the data file. The **/mark** command adds an identifier, a time stamp, and an optional user-defined text string. Marks can be used to filter the data in profiler reports and data views. The following pairs of VSPerfCmd options start and stop data collection. Specify each option on a separate command-line. You can turn data collection on and off multiple times.

## End the profiling session
 To end a profiling session, the profiler must not be collecting data. You can stop collecting data from a application profiled with the concurrency method by stopping the service or by invoking the **VSPerfCmd /detach** option. You then invoke the **VSPerfCmd /shutdown** option to turn the profiler off and close the profiling data file. The **VSPerfClrEnv /globaloff** command clears the profiling environment variables, but the system configuration is not reset until the computer is restarted.

#### To end a profiling session

1. Do one of the following to detach the profiler from the target application.

    - Stop the service.

         -or-

    - Type **VSPerfCmd /detach.**

2. Shut down the profiler. Type:

     **VSPerfCmd**  [Shutdown](../profiling/shutdown.md)
