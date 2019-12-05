---
title: "VSPerfCmd: Attach profiler to native service to get concurrency data"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 283a1ee1-b43e-4daf-95ae-1311925a42a8
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "cplusplus"
---
# How to: Attach the profiler to a native service to collect concurrency data by using the command line
This article describes how to use the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools command-line tools to attach the profiler to a native (C/C++) service and collect process and thread concurrency data by using the sampling method.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).

> [!NOTE]
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.

 While the profiler is attached to the service, you can pause and resume data collection. To end a profiling session, the profiler must no longer be attached to the service, and the Profiler must be explicitly shut down.

## Attach the profiler
 To attach the profiler to a native service, you use the **VSPerfCmd/start** and **/attach** options to initialize the profiler and attach it to the target application. You can specify **/start** and **/attach** and their respective options on a single command line. You can also add the **/globaloff** option to pause data collection at the start of the target application. You then use **/globalon** to begin to collect data.

#### To attach the profiler to a native service

1. If the service is not running, start the service.

2. Start the profiler by typing the following at a command prompt:

    [VSPerfCmd](../profiling/vsperfcmd.md) **/start:concurrency   /output:** `OutputFile` [`Options`]

   - The [/output](../profiling/output.md)**:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and the location of the profiling data (.vsp) file.

     You can use any option in the following table with the **/start** option.

   > [!NOTE]
   > Most services require the **/user** and **/crosssession** option.

   | Option | Description |
   | - | - |
   | [/user](../profiling/user-vsperfcmd.md) **:**[`Domain\`]`UserName` | Specifies the optional domain and user name of the account to be granted access to the profiler. |
   | [/crosssession](../profiling/crosssession.md) | Enables profiling of processes in other logon sessions. |
   | [/wincounter](../profiling/wincounter.md) **:** `WinCounterPath` | Specifies a Windows performance counter to be collected during profiling. |
   | [/automark](../profiling/automark.md) **:** `Interval` | Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. The default value is 500. |
   | [/events](../profiling/events-vsperfcmd.md) **:** `Config` | Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file. |

3. Attach the profiler to the service by typing the following command at a command prompt:

    **VSPerfCmd /attach:** `PID`

    `PID` specifies the process ID or process name of the target application. You can view the process IDs of all running processes in Windows Task Manager.

## Control data collection
 While the target application is running, you can control data collection by starting and stopping the writing of data to the file with *VSPerfCmd.exe* options. By controlling data collection, you can collect data for a specific part of program execution, such as the starting or shutting down of the application.

#### To start and stop data collection

- The pairs of options in the following table start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.

    |Option|Description|
    |------------|-----------------|
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process that the process ID (`PID`) specifies.|
    |[/attach](../profiling/attach.md) **:**{`PID`&#124;`ProcName`} [/detach](../profiling/detach.md)[**:**{`PID`&#124;`ProcName`}]|**/attach** starts to collect data for the process that the process ID (`PID`) or process name (*ProcName*) specifies. **/detach** stops data collection for the specified process or for all processes if no process is specified.|

## End the profiling session
 To end a profiling session, the profiler must not be collecting data. You can stop collecting data from a native service that is being profiled with the concurrency method by stopping the service or by invoking the **VSPerfCmd /detach** option. You then invoke the **VSPerfCmd /shutdown** option to turn off the profiler and close the profiling data file.

#### To end a profiling session

1. Detach the profiler from the target application by stopping the service or by typing the following command at a command prompt:

     Type **VSPerfCmd /detach**

2. Shut down the profiler by typing the following command at a command prompt:

     **VSPerfCmd**  [/shutdown](../profiling/shutdown.md)
