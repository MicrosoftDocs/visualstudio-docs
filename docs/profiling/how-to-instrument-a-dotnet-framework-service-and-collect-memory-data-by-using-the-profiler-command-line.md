---
title: Profiler command line - Instrument .NET service, get memory data
description: Learn how to use the Visual Studio Profiling Tools command-line tools to collect memory allocation and object lifetime data for a .NET Framework service.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: 2fa072fc-05fe-4420-99c0-51d2ea3ac4ce
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - dotnet
---
# How to: Instrument a .NET Framework service and collect memory data by using the profiler command line

This article describes how to use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools command-line tools to instrument a .NET Framework service and collect memory usage data. You can collect memory allocation data, or you can collect both memory allocation and object lifetime data.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).
>
> [!NOTE]
> You cannot profile a service with the instrumentation method if the service cannot be restarted after the computer starts, such a service that start when the operating system starts.
>
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.

## Start the profiling session
 To collect performance data from a .NET Framework service, you use the [VSPerfCLREnv.cmd](../profiling/vsperfclrenv.md) tool to initialize the appropriate environment variables and the [VSInstr.exe](../profiling/vsinstr.md) tool to create an instrumented copy of the service binary file.

 The computer that hosts the service must be restarted to configure it for profiling. You must also start the service manually from the Service Control Manager. You then start the profiler, and then start the .NET Framework service.

 When the instrumented component is executed, memory data is automatically collected to a data file. You can pause and resume data collection during the profiling session.

 To end a profiling session, you close the service and explicitly shut down the profiler. In most cases, we recommend clearing the profiling environment variables at the end of a session.

#### To begin profiling a .NET Framework service

1. Open a command prompt window.

2. Use the **VSInstr** tool to generate an instrumented version of the service binary.

3. Use Service Control Manager to replace the original binary with the instrumented version. Make sure that the service Startup Type is set to Manual.

4. Initialize the profiling environment variables. Type:

    **VSPerfClrEnv** {**/globaltracegc** &#124; **/globaltracegclife**}

   - **/globaltracegc** and **/globaltracegclife** enable the collection of memory allocation and object lifetime data.

       |Option|Description|
       |------------|-----------------|
       |**/globaltracegc**|Collects memory allocation data only.|
       |**/globaltracegclife**|Collects memory allocation and object lifetime data.|

5. Restart the computer.

6. Open a command prompt window.

7. Start the profiler. Type:

    **VSPerfCmd**  [/start](../profiling/start.md) **:trace**  [/output](../profiling/output.md) **:** `OutputFile` [`Options`]

   - The **/start: contention** option initializes the profiler.

   - The **/output:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.

     You can use any of the following options with the **/start:sample** option.

   > [!NOTE]
   > The **/user** and **/crosssession** options are usually required for services.

   | Option | Description |
   | - | - |
   | [/user](../profiling/user-vsperfcmd.md) **:**[`Domain`**\\**]`UserName` | Specifies the domain and user name of the account that owns the ASP.NET worker process. This option is required if the process is running as a user other than the logged on user. The process owner is listed in the User Name column on the Processes tab of Windows Task Manager. |
   | [/crosssession](../profiling/crosssession.md) | Enables profiling of processes in other logon sessions. This option is required if the ASP.NET application is running in a different session. The session id is listed in the **Session ID** column on the **Processes** tab of Windows Task Manager. **/CS** can be specified as an abbreviation for **/crosssession**. |
   | [/waitstart](../profiling/waitstart.md)[**:**`Interval`] | Specifies the number of seconds to wait for the profiler to initialize before it returns an error. If `Interval` is not specified, the profiler waits indefinitely. By default, **/start** returns immediately. |
   | [/globaloff](../profiling/globalon-and-globaloff.md) | To start the profiler with data collection paused, add the **/globaloff** option to the **/start** command line. Use **/globalon** to resume profiling. |
   | [/counter](../profiling/counter.md) **:** `Config` | Collects information from the processor performance counter specified in Config. Counter information is added to the data collected at each profiling event. |
   | [/wincounter](../profiling/wincounter.md) **:** `WinCounterPath` | Specifies a Windows performance counter to be collected during profiling. |
   | [/automark](../profiling/automark.md) **:** `Interval` | Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms. |
   | [/events](../profiling/events-vsperfcmd.md) **:** `Config` | Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.*etl*) file. |

8. If necessary, start the service.

9. Attach the profiler to the service. Type:

     **VSPerfCmd /attach:** `PID`&#124;`ProcessName`

    - Specify the process ID or process name of the service. You can view the process IDs and names of all running processes in Windows Task Manager.

## Control data collection
 While the service is running, you can control data collection by starting and stopping the writing of data to the file with *VSPerfCmd.exe* options. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the application.

#### To start and stop data collection

- The following pairs of **VSPerfCmd** options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.

    |Option|Description|
    |------------|-----------------|
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the process ID (`PID`).|
    |[/threadon](../profiling/threadon-and-threadoff.md) **:** `TID` [/threadoff](../profiling/threadon-and-threadoff.md) **:** `TID`|Starts (**/threadon**) or stops (**/threadoff**) data collection for the thread specified by the thread ID (`TID`).|

## End the profiling session
 To end a profiling session, close the application that is running the instrumented component, then start the **VSPerfCmd** [/shutdown](../profiling/shutdown.md) option to turn the profiler off and close the profiling data file. The **VSPerfClrEnv /globaloff** command clears the profiling environment variables.

#### To end a profiling session

1. Stop the service from Service Control Manager.

2. Shut down the profiler. Type:

     **VSPerfCmd /shutdown**

3. When you have completed all profiling, clear the profiling environment variables. Type:

     **VSPerfClrEnv /globaloff**

     Replace the instrumented module with the original. If necessary, reconfigure the Startup Type of the service.

4. Restart the computer.

## See also
- [Profile services](../profiling/command-line-profiling-of-services.md)
- [.NET memory data views](../profiling/dotnet-memory-data-views.md)
