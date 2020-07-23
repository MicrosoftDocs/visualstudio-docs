---
title: Profiler command line - Instrument .NET service, get timing detail
ms.date: 11/04/2016
ms.topic: how-to
author: mikejo5000
ms.author: mikejo
manager: jillfra
monikerRange: 'vs-2017'
ms.workload: 
  - dotnet
---
# How to: Instrument a .NET service and collect detailed timing data by using the profiler command line

This article describes how to use Visual Studio Profiling Tools command-line tools to instrument a .NET Framework service and collect detailed timing data.

> [!NOTE]
> You cannot profile a service with the instrumentation method if the service cannot be restarted after the computer starts, such a service that starts only when the operating system starts.
>
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.
>
> Adding tier interaction data to a profiling run requires specific procedures with the command-line profiling tools. See [Collect tier interaction data](../profiling/adding-tier-interaction-data-from-the-command-line.md).

To collect detailed timing data from a .NET Framework service by using the instrumentation method, you use the [VSInstr.exe](../profiling/vsinstr.md) tool to generate an instrumented version of the component. You then replace the non-instrumented version of the service with the instrumented version, making sure that the service is configured to start manually. You use the [VSPerfCLREnv.cmd](../profiling/vsperfclrenv.md) tool to initialize the global profiling environment variables and then restart the host computer. You then start the profiler.

When the service is started, timing data is automatically collected to a data file. You can pause and resume data collection during the profiling session.

To end a profiling session, you turn off the service and then explicitly shut down the profiler. In most cases, we recommend clearing the profiling environment variables at the end of a session.

## Start the application with the profiler

1. Open a command prompt window.

2. Use the **VSInstr** tool to generate an instrumented version of the service binary.

3. Replace the original binary with the instrumented version. In the Windows Service Control Manager, make sure that the service Startup Type is set to Manual.

4. Initialize the .NET Framework profiling environment variables. Type:

     **VSPerfClrEnv /globaltraceon**

5. Restart the computer.

6. Open a command prompt window.

7. Start the profiler. Type:

     **VSPerfCmd /start:trace /output:** `OutputFile` [`Options`]

   - The [/start](../profiling/start.md)**:trace** option initializes the profiler.

   - The [/output](../profiling/output.md)**:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.*vsp*) file.

     You can use any one of the following options with the **/start:trace** option.

     > [!NOTE]
     > The **/user** and **/crosssession** options are usually required for profiling services.

     | Option | Description |
     | - | - |
     | [/user](../profiling/user-vsperfcmd.md) **:**[`Domain`**\\**]`UserName` | Specifies the domain and user name of the account that owns the profiled process. This option is required only if the process is running as a user other than the logged on user. The process owner is listed in the **User Name** column on the **Processes** tab of Windows Task Manager. |
     | [/crosssession](../profiling/crosssession.md) | Enables profiling of processes in other sessions. This option is required if the application is running in a different session. The session ID is listed in the **Session ID** column on the **Processes** tab of Windows Task Manager. **/CS** can be specified as an abbreviation for **/crosssession**. |
     | [/waitstart](../profiling/waitstart.md)[**:**`Interval`] | Specifies the number of seconds to wait for the profiler to initialize before it returns an error. If `Interval` is not specified, the profiler waits indefinitely. By default, **/start** returns immediately. |
     | [/globaloff](../profiling/globalon-and-globaloff.md) | To start the profiler with data collection paused, add the **/globaloff** option to the **/start** command line. Use **/globalon** to resume profiling. |
     | [/counter](../profiling/counter.md) **:** `Config` | Collects information from the processor performance counter specified in Config. Counter information is added to the data collected at each profiling event. |
     | [/wincounter](../profiling/wincounter.md) **:** `WinCounterPath` | Specifies a Windows performance counter to be collected during profiling. |
     | [/automark](../profiling/automark.md) **:** `Interval` | Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms. |
     | [/events](../profiling/events-vsperfcmd.md) **:** `Config` | Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.*etl*) file. |

8. Start the service from Windows Service Control Manager.

## Control data collection

When the service is running, you can use *VSPerfCmd.exe* options to start and stop the writing of data to the profiler data file. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the service.

- The following pairs of **VSPerfCmd** options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.

    |Option|Description|
    |------------|-----------------|
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the process ID (`PID`).|
    |[/threadon](../profiling/threadon-and-threadoff.md) **:** `TID` [/threadoff](../profiling/threadon-and-threadoff.md) **:** `TID`|Starts (**/threadon**) or stops (**/threadoff**) data collection for the thread specified by the thread ID (`TID`).|

## End the profiling session

To end a profiling session, stop the service that is running the instrumented component, and then call the **VSPerfCmd** [/shutdown](../profiling/shutdown.md) option to turn the profiler off and close the profiling data file. The **VSPerfClrEnv /globaloff** command clears the profiling environment variables.

You must restart the computer for the new environment settings to be applied.

1. Stop the service from Service Control Manager.

2. Shut down the profiler. Type:

     **VSPerfCmd /shutdown**

3. When you have completed all profiling, clear the profiling environment variables. Type:

     **VSPerfClrEnv /globaloff**

4. Replace the instrumented module with the original. If necessary, reconfigure the Startup Type of the service.

5. Restart the computer.

## See also

[Profile services](../profiling/command-line-profiling-of-services.md)
[Instrumentation method data views](../profiling/instrumentation-method-data-views.md)
