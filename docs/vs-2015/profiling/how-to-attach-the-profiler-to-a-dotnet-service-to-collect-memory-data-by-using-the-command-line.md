---
title: "How to: Attach the Profiler to a .NET Service to Collect Memory Data by Using the Command Line | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: aeac39af-ad99-479f-aa36-4104356ca512
caps.latest.revision: 33
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Attach the Profiler to a .NET Service to Collect Memory Data by Using the Command Line
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic describes how to use [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Profiling Tools command-line tools to attach the profiler to a [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] service and collect memory data. You can collect data about the number and size of memory allocations, and you can also collect data about the lifetime of memory objects.  

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  

> [!NOTE]
> Command-line tools of the Profiling Tools are located in the \Team Tools\Performance Tools subdirectory of the [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] installation directory. On 64 bit computers, both 64 bit and 32 bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the command prompt window or add it to the command itself. For more information, see [Specifying the Path to Command Line Tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md).  

 To collect memory data from a [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] service, you use the [VSPerfCLREnv.cmd](../profiling/vsperfclrenv.md) tool to initialize the appropriate environment variables on the computer that hosts the service. The computer must be restarted to configure it for profiling.  

 You then use the [VSPerfCmd](../profiling/vsperfcmd.md) tool to attach the profiler to the service process. While the profiler is attached to the service, you can pause and resume data collection.  

 To end a profiling session, the profiler must be detached from the service and the profiler must be explicitly shut down. In most cases, we recommend clearing the profiling environment variables at the end of a session.  

## Attaching the Profiler  

#### To attach the Profiler to a .NET Framework service  

1. If necessary, install the service.  

2. Open a command prompt window.  

3. Initialize the profiling environment variables. Type:  

    **VSPerfClrEnv** {**/globalsamplegc /globalsamplegclife**}[**/samplelineoff**]  

   - The options **/globalsamplegclife** and **/globalsamplegclife** specify the type of memory data to collect. Specify one and only one of the following options.  

     **/globalsamplegc**  
     Enables the collection of memory allocation data.  

     **/globalsamplegclife**  
     Enables the collection of both memory allocation data and object lifetime data.  

   - The **/samplelineoff** option disables the collection of source code line number data.  

4. Restart the computer to set the new environment configuration.  

5. If necessary, start the service.  

6. Open a command prompt window. If necessary, add the profiler path to the PATH environment variable.  

7. Start the profiler. Type:  

    **VSPerfCmd**  [/start](../profiling/start.md) **:sample**  [/output](../profiling/output.md) **:** `OutputFile` [`Options`]  

   - The **/start:sample** option initializes the profiler.  

   - The **/output:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.  

     You can use one or more of the following options with the **/start:sample** option.  

   > [!NOTE]
   > The **/user** and **/crosssession** options are usually required for services.  

   |                                 Option                                  |                                                                                                                                                   Description                                                                                                                                                    |
   |-------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   | [/user](../profiling/user-vsperfcmd.md) **:**[`Domain`**\\**]`UserName` |                      Specifies the domain and user name of the account that owns the process. This option is required if the process is running as a user other than the logged on user. The process owner is listed in the User Name column on the Processes tab of Windows Task Manager.                       |
   |              [/crosssession](../profiling/crosssession.md)              | Enables profiling of processes in other logon sessions. This option is required if the ASP.NET application is running in a different session. The session id is listed in the Session ID column on the Processes tab of Windows Task Manager. **/CS** can be specified as an abbreviation for **/crosssession**. |
   | [/user](../profiling/user-vsperfcmd.md) **:**[`Domain`**\\**]`UserName` |                                                    Specifies the optional domain and user name of the logon account under which the service runs. The logon account is listed in the Log On As column of the service in the Windows Service Control Manager.                                                     |
   |          [/crosssession&#124;cs](../profiling/crosssession.md)          |                                                                                                                             Enables profiling of processes in other logon sessions.                                                                                                                              |
   |    [/wincounter](../profiling/wincounter.md) **:** `WinCounterPath`     |                                                                                                                    Specifies a Windows performance counter to be collected during profiling.                                                                                                                     |
   |         [/automark](../profiling/automark.md) **:** `Interval`          |                                                                                  Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms.                                                                                   |
   |       [/events](../profiling/events-vsperfcmd.md) **:** `Config`        |                                                                                     Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file.                                                                                     |

8. Attach the profiler to the service. Type:  

    **VSPerfCmd**  [/attach](../profiling/attach.md) **:**{`PID`&#124;`ProcName`} [[/targetclr](../profiling/targetclr.md)**:**`Version`]  

   - Specify either the process ID or the process name of the service. You can view the process IDs and names of all running processes in Windows Task Manager.  

   - **targetclr:** `Version` specifies the version of the common language runtime (CLR) to profile when more than one version of the runtime is loaded in an application. Optional.  

## Controlling Data Collection  
 While the service is running, you can use **VSPerfCmd.exe** options to stop and start the writing of data to the profiler data file. Controlling data collection enables you to collect data for a specific part of the program execution, such as starting or shutting down the application.  

#### To start and stop data collection  

- The following pairs of **VSPerfCmd** options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.  

    |Option|Description|  
    |------------|-----------------|  
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|  
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the process ID (`PID`).|  
    |**/attach:**{`PID`&#124;`ProcName`} [/detach](../profiling/detach.md)[:{`PID`&#124;`ProcName`}]|**/attach** starts to collect data for the process specified by the process ID or process name. **/detach** stops data collection for the specified process, or for all processes if a specific process is not specified.|  

## Ending the Profiling Session  
 To end a profiling session, the profiler must not be collecting data. You can stop the collection of data from an application profiled with the sampling method by stopping the service or by calling the **VSPerfCmd /detach** option. You then call the **VSPerfCmd** [/shutdown](../profiling/shutdown.md) option to turn the profiler off and close the profiling data file. The **VSPerfClrEnv /globaloff** command clears the profiling environment variables, but the system configuration is not reset until the computer is restarted.  

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

## See Also  
 [Profiling Services](../profiling/command-line-profiling-of-services.md)   
 [.NET Memory Data Views](../profiling/dotnet-memory-data-views.md)
