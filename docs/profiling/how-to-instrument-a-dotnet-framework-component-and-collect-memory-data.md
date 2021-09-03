---
title: Profiler command line - Instrument stand-alone .NET component, get memory data
description: Learn how to use the Visual Studio Profiling Tools command-line tools to collect memory data for a .NET Framework component of a stand-alone application.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: d09cc46a-70f5-48f9-aa24-89913e67b359
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - dotnet
---
# How to: Instrument a stand-alone .NET Framework component and collect memory data with the profiler by using the command line
This article describes how to use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools command-line tools to instrument a .NET Framework component of a stand-alone application such as an .exe or .dll file and collect memory information by using the profiler.

> [!NOTE]
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.

 To collect memory data from a .NET Framework component by using the instrumentation method, you use the [VSInstr.exe](../profiling/vsinstr.md) tool to generate an instrumented version of the component and the [VSPerfCLREnv.cmd](../profiling/vsperfclrenv.md) tool to initialize profiling environment variables. You then start the profiler by using the *VSPerfCmd.exe* tool.

 When the instrumented component is executed, memory data is automatically collected to a data file. You can pause and resume data collection during the profiling session.

 To end a profiling session, you close the target application and explicitly shut down the profiler. In most cases, we recommend clearing the profiling environment variables at the end of a session.

## Start the application with the profiler

#### To attach the profiler to a running .NET Framework application

1. Open a Command Prompt window.

2. Use the **VSInstr** tool to generate an instrumented version of the target application.

3. Initialize the .NET Framework profiling environment variables. Type:

    **VSPerfClrEnv** {**/tracegc** &#124; **/tracegclife**}

   - The **/tracegc** and **/tracegclife** options initialize the environment variables to collect only memory allocation data, or to collect both memory allocation and object lifetime data.

       |Option|Description|
       |------------|-----------------|
       |**/tracegc**|Enables collection of memory allocation data only.|
       |**/tracegclife**|Enables collection of both memory allocation and object lifetime data.|

4. Start the profiler. Type:

    **VSPerfCmd /start:trace /output:** `OutputFile` [`Options`]

   - The [/start](../profiling/start.md)**:trace** option initializes the profiler.

   - The [/output](../profiling/output.md)**:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.*vsp*) file.

     You can use any of the following options with the **/start:trace** option.

   | Option | Description |
   | - | - |
   | [/user](../profiling/user-vsperfcmd.md) **:**[`Domain`**\\**]`UserName` | Specifies the domain and user name of the account that owns the profiled process. This option is required only if the process is running as a user other than the logged-on user. The process owner is listed in the User Name column on the **Processes** tab of Windows Task Manager. |
   | [/crosssession](../profiling/crosssession.md) | Enables profiling of processes in other sessions. This option is required if the application is running in a different session. The session identifier is listed in the **Session ID** column on the **Processes** tab of Windows Task Manager. **/CS** can be specified as an abbreviation for **/crosssession**. |
   | [/globaloff](../profiling/globalon-and-globaloff.md) | To start the profiler with data collection paused, add the **/globaloff** option to the **/start** command line. Use **/globalon** to resume profiling. |
   | [/wincounter](../profiling/wincounter.md) **:** `WinCounterPath` | Specifies a Windows performance counter to be collected during profiling. |
   | [/automark](../profiling/automark.md) **:** `Interval` | Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms. |
   | [/counter](../profiling/counter.md) **:** `Config` | Collects information from the processor performance counter that is specified in Config. Counter information is added to the data that is collected at each profiling event. |
   | [events](../profiling/events-vsperfcmd.md) **:** `Config` | Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.*etl*) file. |

5. Start the target application from the Command Prompt window.

## Control data collection
 While the target application is running, you can control data collection by starting and stopping the writing of data to the file by using *VSPerfCmd.exe* options. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the application.

#### To start and stop data collection

- The following pairs of **VSPerfCmd** options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.

    |Option|Description|
    |------------|-----------------|
    |[/globalon](../profiling/globalon-and-globaloff.md) [/globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process that is specified by the process ID (`PID`).|
    |[/threadon](../profiling/threadon-and-threadoff.md) **:** `TID` [/threadoff](../profiling/threadon-and-threadoff.md) **:** `TID`|Starts (**/threadon**) or stops (**/threadoff**) data collection for the thread that is specified by the thread ID (`TID`).|

## End the profiling session
 To end a profiling session, close the application that is running the instrumented component, and then call the **VSPerfCmd** [/shutdown](../profiling/shutdown.md) option to turn off the profiler and close the profiling data file. The **VSPerfClrEnv /off** command clears the profiling environment variables.

#### To end a profiling session

1. Close the target application.

2. Shut down the profiler. Type:

     **VSPerfCmd /shutdown**

3. (Optional) Clear the profiling environment variables. Type:

     **VSPerfCmd /off**

## See also
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [.NET memory data views](../profiling/dotnet-memory-data-views.md)
