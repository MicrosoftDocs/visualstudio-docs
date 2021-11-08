---
title: Profiler command line - Launch stand-alone app, get app stats
description: Learn how to use the Visual Studio Profiling Tools command-line tools to start a stand-alone app and collect performance data using the sampling method.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: 52dcee2b-f178-4a76-bddc-e36c50bfcb78
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# How to: Launch a stand-alone application with the profiler and collect application statistics by using the command line
This topic describes how to use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools command-line tools to start a stand-alone (client) application and collect performance statistics by using the sampling method.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).
>
> Adding tier interaction data to a profiling run requires specific procedures with the command-line profiling tools. See [Collect tier interaction data](../profiling/adding-tier-interaction-data-from-the-command-line.md)

 To use the profiler command-line tools, you must add the path to the PATH environment variable of the Command Prompt window or add it to the command itself. You can run the profiling tools on a machine where Visual Studio is installed from a Visual Studio command window.

1. If you are running the profiling tools on a machine where Visual Studio is installed a Visual Studio command window sets the correct paths. On the **Tools** menu, choose **VS command prompt**

> [!NOTE]
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.

## Start the application with the profiler
 To start a target application by using the profiler, you use the VSPerfCmd **/start** and **/launch** options to initialize the profiler and start the application. You can specify **/start** and **/launch** and their respective options on a single command line.

 You can also add the **/globaloff** option to pause data collection at the start of the target application. You then use **/globalon** to start to collect data.

#### To start an application by using the profiler

1. Open a Command Prompt window.

2. Start the profiler. Type:

    **VSPerfCmd /start:sample /output:** `OutputFile` [`Options`]

   - The [/start](../profiling/start.md)**:sample** option initializes the profiler.

   - The [/output](../profiling/output.md)**:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.

     You can use any of the following options with the **/start:sample** option.

   | Option | Description |
   | - | - |
   | [/wincounter](../profiling/wincounter.md) **:** `WinCounterPath` | Specifies a Windows performance counter to be collected during profiling. |
   | [/automark](../profiling/automark.md) **:** `Interval` | Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms. |
   | [/events](../profiling/events-vsperfcmd.md) **:** `Config` | Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.*etl*) file. |

3. Start the target application. Type:**VSPerfCmd /launch:**`appName` [`Options`] [`Sample Event`]

    You can use one or more of the following options with the **/launch** option.

   |Option|Description|
   |------------|-----------------|
   |[/args](../profiling/args.md) **:** `Arguments`|Specifies a string that contains the command-line arguments to be passed to the target application.|
   |[/console](../profiling/console.md)|Starts the target command-line application in a separate window.|

    By default, performance data is sampled every 10,000,000 non-halted processor clock cycles. This is approximately one time every 10 seconds on a 1GHz processor. You can specify one of the following options to change the clock cycle interval or to specify a different sampling event.

   |Sample event|Description|
   |------------------|-----------------|
   |[/timer](../profiling/timer.md) **:** `Interval`|Changes the sampling interval to the number of non-halted clock cycles that are specified by `Interval`.|
   |[/pf](../profiling/pf.md)[**:**`Interval`]|Changes the sampling event to page faults. If `Interval` is specified, sets the number of page faults between samples. Default is 10.|
   |[/sys](../profiling/sys-vsperfcmd.md)[**:**`Interval`]|Changes the sampling event to system calls from the process to the operating system kernel (syscalls). If `Interval` is specified, sets the number of calls between samples. Default is 10.|
   |[/counter](../profiling/counter.md) **:** `Config`|Changes the sampling event and interval to the processor performance counter and interval that are specified in `Config`.|

## Control data collection
 When the target application is running, you can control data collection by starting and stopping the writing of data to the profiler data file by using *VSPerfCmd.exe* options. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the application.

#### To start and stop data collection

- The following pairs of options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.

    |Option|Description|
    |------------|-----------------|
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID`  [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the process ID (`PID`).|
    |[/attach](../profiling/attach.md) **:**{`PID`&#124;`ProcName`} [/detach](../profiling/detach.md)[**:**{`PID`&#124;`ProcName`}]|**/attach** starts to collect data for the process specified by the `PID` or process name (ProcName). **/detach** stops data collection for the specified process or for all processes if a specific process is not specified.|

## End the profiling session
 To end a profiling session, the profiler must not be attached to any profiled process and the profiler must be explicitly shut down. You can detach the profiler from an application that was profiled by using the sampling method by closing the application or by calling the **VSPerfCmd /detach** option. You then call the **VSPerfCmd /shutdown** option to turn the profiler off and close the profiling data file. The **VSPerfClrEnv /off** command clears the profiling environment variables.

#### To end a profiling session

1. Perform one of the following steps to detach the profiler from the target application:

    - Close the target application.

         -or-

    - Type **VSPerfCmd /detach**

2. Shut down the profiler. Type:

     **VSPerfCmd**  [/shutdown](../profiling/shutdown.md)

## See also
- [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)
- [Sampling method data views](../profiling/profiler-sampling-method-data-views.md)
