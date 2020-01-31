---
title: "Attach the profiler to a .NET app to collect memory data"
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "conceptual"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "dotnet"
---
# How to: Attach the profiler to a .NET Framework stand-alone application to collect memory data by using the command line

This article describes how to use Visual Studio Profiling Tools command-line tools to attach the profiler to a running .NET Framework stand-alone (client) application and collect memory data.

> [!NOTE]
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.

To attach to a .NET Framework application and collect memory data, you must use the [VSPerfCLREnv.cmd](../profiling/vsperfclrenv.md) tool to initialize the appropriate environment variables before the target application starts. When the profiler is attached to the application, you can use the *VSPerfCmd.exe* tool to pause and resume data collection.

To end a profiling session, the profiler must be detached from all profiled processes and the profiler must be explicitly shut down. In most cases, we recommend clearing the profiling environment variables at the end of a session.

## Attach the profiler

### To attach the profiler to a running .NET Framework application

1. Open a Command Prompt window.

2. Initialize the profiling environment variables. Type:

     **VSPerfClrEnv** {**/samplegc** &#124; **/samplegclife**} [**/samplelineoff**]

    - The **/samplegc** and **/samplegclife** options specify whether to collect only memory allocation data, or to collect both memory allocation and object lifetime data. One and only one option must be specified.

        |Option|Descriptions|
        |------------|------------------|
        |**/samplegc**|Collect only memory allocation data.|
        |**/samplegclife**|Collect both memory allocation and object lifetime data.|

    - The **/samplelineoff** option disables the collection of source code line number data.

3. Start the profiler. Type:

     **VSPerfCmd /start:sample /output:** `OutputFile` [`Options`]

   - The [/start](../profiling/start.md)**:sample** option initializes the profiler.

   - The [/output](../profiling/output.md)**:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.

     You can use any of the following options with the **/start:sample** option.

     | Option | Description |
     | - | - |
     | [/user](../profiling/user-vsperfcmd.md) **:**[`Domain`**\\**]`UserName` | Specifies the domain and user name of the account that owns the profiled process. This option is required only if the process is running as a user other than the logged-on user. The process owner is listed in the User Name column on the Processes tab of Windows Task Manager. |
     | [/crosssession &#124; /cs](../profiling/crosssession.md) | Enables profiling of processes in other sessions. This option is required if the application is running in a different session. The session idenitifer is listed in the Session ID column on the Processes tab of Windows Task Manager. **/CS** can be specified as an abbreviation for **/crosssession**. |
     | [/wincounter](../profiling/wincounter.md) **:** `WinCounterPath` | Specifies a Windows performance counter to be collected during profiling. |
     | [/automark](../profiling/automark.md) **:** `Interval` | Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms. |

4. If necessary, start the target application in the typical way.

5. Attach the profiler to the target application. Type:

     **VSPerfCmd**  [/attach](../profiling/attach.md) **:**{`PID`&#124;`ProcName`} [[/targetclr](../profiling/targetclr.md)**:**`Version`]

    - `PID` specifies the process ID of the target application. `ProcessName` specifies the name of the process. Note that if you specify `ProcessName` and multiple processes that have the same name are running, results are unpredictable. You can view the process IDs of all running processes in Windows Task Manager.

    - **/targetclr:** `Version` specifies the version of the common language runtime (CLR) to profile when more than one version of the runtime is loaded in an application. Optional.

## Control data collection

When the target application is running, you can control data collection by starting and stopping the writing of data to the file by using *VSPerfCmd.exe* options. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the application.

### To start and stop data collection

- The following pairs of options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.

    |Option|Description|
    |------------|-----------------|
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process that is specified by the `PID`.|
    |[/attach](../profiling/attach.md) **:**{`PID`&#124;`ProcName`} [/detach](../profiling/detach.md)[**:**{`PID`&#124;`ProcName`}]|**/attach** starts to collect data for the process that is specified by the `PID` or process name (ProcName). **/detach** stops data collection for the specified process or for all processes if a specific process is not specified.|

## End the profiling session

To end a profiling session, the profiler must be detached from all profiled processes and the profiler must be explicitly shut down. You can detach the profiler from an application that was profiled by using the sampling method by closing the application or by calling the **VSPerfCmd /detach** option. You then call the **VSPerfCmd /shutdown** option to turn off the profiler and close the profiling data file. The **VSPerfClrEnv /off** command clears the profiling environment variables.

### To end a profiling session

1. Perform one of the following steps to detach the profiler from the target application:

    - Type **VSPerfCmd /detach**

         -or-

    - Close the target application.

2. Shut down the profiler. Type:

     **VSPerfCmd**  [/shutdown](../profiling/shutdown.md)

3. (Optional) Clear the profiling environment variables. Type:

     **VSPerfCmd /off**

## See also

[Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
[.NET memory data views](../profiling/dotnet-memory-data-views.md)
