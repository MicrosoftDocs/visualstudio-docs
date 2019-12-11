---
title: "Profiler command line: Instrument static ASP.NET app, get memory data"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: ea1dcb7c-1dc3-49ff-9418-8795b5b3d3bc
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# How to: Instrument a statically compiled ASP.NET web application and collect memory data by using the profiler command line
This article describes how to use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools command-line tools to instrument a pre-compiled [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] web component or web site and collect .NET memory allocation, object lifetime, and detailed timing data.

> [!NOTE]
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.

 To collect data from a [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web component by using the instrumentation method, you use the [VSInstr.exe](../profiling/vsinstr.md) tool to generate an instrumented version of the component. On the computer that hosts the component, you replace the non-instrumented version of the component with the instrumented version. You then use the [VSPerfCLREnv.cmd](../profiling/vsperfclrenv.md) tool to initialize the global profiling environment variables and restart the host computer. You then start the profiler.

 When the instrumented component is executed, timing data is automatically collected to a data file. You can pause and resume data collection during the profiling session.

 To end a profiling session, you close the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process that hosts the component and then explicitly shut down the profiler. In most cases, we recommend clearing the profiling environment variables at the end of a session.

## Start to profile

#### To instrument an ASP.NET Web component and start profiling

1. Use the **VSInstr** tool to generate an instrumented version of the target application. If necessary, replace the application binaries on the ASP.NET host computer with the instrumented binaries.

2. Open a command prompt window

3. Initialize the .NET profiling environment variables. In a command prompt window, type:

    **VSPerfClrEnv /globaltracegc**

    -or-

    **VSPerfClrEnv /globaltracegclife**

   - **/globaltracegc** collects .NET memory allocation and timing data.

   - **/globaltracegclife** collects .NET memory allocation, object lifetime, and detailed timing data.

4. Restart the computer.

5. Open a command prompt window.

6. Start the profiler. In a command prompt window, type:

    **VSPerfCmd /start:trace /output:** `OutputFile` [`Options`]

   - The [/start](../profiling/start.md)**:trace** option initializes the profiler.

   - The [/output](../profiling/output.md)**:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.

     You can use any of the following options with the **/start:trace** option.

   > [!NOTE]
   > The **/user** and **/crosssession** options are usually required for ASP.NET applications.

   | Option | Description |
   | - | - |
   | [/user](../profiling/user-vsperfcmd.md) **:**[`Domain`**\\**]`UserName` | Specifies the optional domain and user name of the account that owns the ASP.NET worker process. This option is required if the process is running as a user that is different than the logged on user.The name is listed in the **User Name** column on the **Processes** tab of Windows Task Manager. |
   | [/crosssession](../profiling/crosssession.md) | Enables profiling of processes in other sessions. This option is required if the application is running in a different session. The session ID is listed in the Session ID column on the **Processes** tab of Windows Task Manager. **/CS** can be specified as an abbreviation for **/crosssession**. |
   | [/wincounter](../profiling/wincounter.md) **:** `WinCounterPath` | Specifies a Windows performance counter to be collected during profiling. |
   | [/automark](../profiling/automark.md) **:** `Interval` | Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms. |
   | [/events](../profiling/events-vsperfcmd.md) **:** `Config` | Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file. |
   | [/globaloff](../profiling/globalon-and-globaloff.md) | To start the profiler with data collection paused, add the **/globaloff** option to the **/start** command line. Use **/globalon** to resume profiling. |

7. Open the web site that contains the instrumented component.

## Control data collection
 While the target application is running, you can control data collection by starting and stopping the writing of data to the file by using *VSPerfCmd.exe* options. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the application.

#### To start and stop data collection

- The following pairs of options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.

    |Option|Description|
    |------------|-----------------|
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the process ID (`PID`).|
    |[/threadon](../profiling/threadon-and-threadoff.md) **:** `TID` [/threadoff](../profiling/threadon-and-threadoff.md) **:** `TID`|Starts (**/threadon**) or stops (**/threadoff**) data collection for the thread specified by the thread ID (`TID`).|

## End the profiling session
 To end a profiling session, close the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] web application, and then use the Internet Information Services (IIS) **IISReset** command to close the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process. Call the **VSPerfCmd** [/shutdown](../profiling/shutdown.md) option to turn the profiler off and close the profiling data file. The **VSPerfClrEnv /globaloff** command clears the profiling environment variables. You must restart the computer for the new environment settings to be applied.

#### To end a profiling session

1. Close the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] web application.

2. Close the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process. Type:

    **IISReset /stop**

3. Shut down the profiler. Type:

    **VSPerfCmd /shutdown**

4. (Optional). Clear the profiling environment variables. Type:

    **VSPerfCmd /globaloff**

5. Restart the computer. If necessary, restart IIS. Type:

    **IISReset /start**

## See also
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [.NET memory data views](../profiling/dotnet-memory-data-views.md)
