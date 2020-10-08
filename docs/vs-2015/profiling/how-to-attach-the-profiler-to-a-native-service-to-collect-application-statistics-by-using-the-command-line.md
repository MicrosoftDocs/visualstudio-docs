---
title: "How to: Attach the Profiler to a Native Service to Collect Application Statistics by Using the Command Line | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: f783817f-77a0-4eb8-985b-ec3b77eadc42
caps.latest.revision: 30
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Attach the Profiler to a Native Service to Collect Application Statistics by Using the Command Line
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic describes how to use the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Profiling Tools command-line tools to attach the profiler to a native service and collect performance statistics by using the sampling method.  

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  

> [!NOTE]
> Command-line tools of the Profiling Tools are located in the \Team Tools\Performance Tools subdirectory of the [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] installation directory. On 64 bit computers, both 64 bit and 32 bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the command prompt window or add it to the command itself. For more information, see [Specifying the Path to Command Line Tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md).  

 While the profiler is attached to the service, you can pause and resume data collection.  

 To end a profiling session, the profiler must be detached from the service and the profiler must be explicitly shut down.  

## Starting the Application with the Profiler  
 To attach the profiler to a native service, you use the **VSPerfCmd.exe**[/start](../profiling/start.md) and [/attach](../profiling/attach.md) options to initialize the profiler and attach it to the target application. You can specify **/start** and **/attach** and their respective options on a single command line. You can also add the [/globaloff](../profiling/globalon-and-globaloff.md) option to pause data collection at the start of the target application. You can then use [/globalon](../profiling/globalon-and-globaloff.md) to begin collecting data.  

#### To attach the Profiler to a native service  

1. If necessary, start the service.  

2. Open a command prompt window.  

3. Start the profiler. Type:  

    **VSPerfCmd /start:sample**  [/output](../profiling/output.md) **:** `OutputFile` [`Options`]  

   - The **/start:sample** option initializes the profiler.  

   - The **/output:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.  

     You can use any of the following options with the **/start:sample** option.  

   > [!NOTE]
   > The **/user** and **/crosssession** options are usually required for services.  

   |                                 Option                                  |                                                                                                                                            Description                                                                                                                                             |
   |-------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   | [/user](../profiling/user-vsperfcmd.md) **:**[`Domain`**\\**]`UserName` |        Specifies the domain and user name of the account that owns the profiled process. This option is required only if the process is running as a user other than the logged on user. The process owner is listed in the User Name column on the Processes tab of Windows Task Manager.         |
   |              [/crosssession](../profiling/crosssession.md)              | Enables profiling of processes in other sessions. This option is required if the application is running in a different session. The session id is listed in the Session ID column on the Processes tab of Windows Task Manager. **/CS** can be specified as an abbreviation for **/crosssession**. |
   |    [/wincounter](../profiling/wincounter.md) **:** `WinCounterPath`     |                                                                                                             Specifies a Windows performance counter to be collected during profiling.                                                                                                              |
   |         [/automark](../profiling/automark.md) **:** `Interval`          |                                                                           Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms.                                                                            |
   |       [/events](../profiling/events-vsperfcmd.md) **:** `Config`        |                                                                              Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file.                                                                              |

4. Attach the profiler to the service. Type:  

    **VSPerfCmd /attach:** `PID` [`Sample Event`]  

    `PID` specifies the process ID of the target application. You can view the process IDs of all running processes in Windows Task Manager.  

    By default, performance data is sampled every 10,000,000 non-halted processor clock cycles. This is approximately once every 10 seconds on a 1GH processor. You can specify one of the following options to change the clock cycle interval or to specify a different sampling event.  

   |Sample Event|Description|  
   |------------------|-----------------|  
   |[/timer](../profiling/timer.md) **:** `Interval`|Changes the sampling interval to the number of non-halted clock cycles specified by `Interval`.|  
   |[/pf](../profiling/pf.md)[**:**`Interval`]|Changes the sampling event to page faults. If `Interval` is specified, sets the number of page faults between samples. Default is 10.|  
   |[/sys](../profiling/sys-vsperfcmd.md) [**:**`Interval`]|Changes the sampling event to system calls from the process to the operating system kernel (syscalls). If `Interval` is specified, sets the number of calls between samples. Default is 10.|  
   |[/counter](../profiling/counter.md) **:** `Config`|Changes the sampling event and interval to the processor performance counter and interval specified in `Config`.|  

## Controlling Data Collection  
 While the target application is running, you can use **VSPerfCmd.exe** options to start and stop the writing of data to the profiler data file. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the application.  

#### To start and stop data collection  

- The following pairs of **VSPerfCmd** options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.  

    |Option|Description|  
    |------------|-----------------|  
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|  
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the process ID (`PID`).|  
    |**/attach:** {`PID`&#124;`ProcName`} [/detach](../profiling/detach.md)[:{`PID`&#124;`ProcName`}]|**/attach** starts to collect data for the process specified by the process ID or process name. **/detach** stops data collection for the specified process, or for all processes if a process is not specified.|  

## Ending the Profiling Session  
 To end a profiling session, the profiler must be detached from the service and then explicitly shut down. You can detach native service that is being profiled with the sampling method by stopping the service or by calling the **VSPerfCmd /detach** option. You then call the **VSPerfCmd** [/shutdown](../profiling/shutdown.md) option to turn the profiler off and close the profiling data file.  

#### To end a profiling session  

1. Do one of the following to detach the profiler from the target application:  

    - Stop the service.  

         -or-  

    - Type **VSPerfCmd /detach**  

2. Shut down the profiler. Type:  

     **VSPerfCmd /shutdown**  

## See Also  
 [Profiling Services](../profiling/command-line-profiling-of-services.md)   
 [Sampling Method Data Views](../profiling/profiler-sampling-method-data-views.md)
