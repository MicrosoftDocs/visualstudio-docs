---
title: "How to: Instrument a Stand-Alone .NET Framework Component and Collect Timing Data with the Profiler from the Command Line"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b7dcc27b-45c6-4302-9552-6fa5b1e94b56
caps.latest.revision: 28
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Instrument a Stand-Alone .NET Framework Component and Collect Timing Data with the Profiler from the Command Line
This topic describes how to use Visual Studio Profiling Tools command-line tools to instrument a .NET Framework component such as an .exe or .dll file, and to collect detailed timing data.  
  
> [!NOTE]
>  Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../VS_IDE/Performance-Tools-on-Windows-8-and-Windows-Server-2012-applications.md).  
>   
>  Command-line tools of the Profiling Tools are located in the \Team Tools\Performance Tools subdirectory of the Visual Studio installation directory. On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself. For more information, see [Specifying the Path to Command Line Tools](../VS_IDE/Specifying-the-Path-to-Profiling-Tools-Command-Line-Tools.md).  
>   
>  Adding tier interaction data to a profiling run requires specific procedures with the command line profiling tools. See [Collecting tier interaction data](../VS_IDE/Adding-tier-interaction-data-from-the-command-line.md).  
  
 To collect detailed timing data from a .NET Framework component by using the instrumentation method, you use the [VSInstr.exe](../VS_IDE/VSInstr.md) tool to generate an instrumented version of the component and the [VSPerfCLREnv.cmd](../VS_IDE/VSPerfCLREnv.md) tool to initialize profiling environment variables. You then start the profiler.  
  
 When the instrumented component is executed, timing data is automatically collected to a data file. You can pause and resume data collection during the profiling session.  
  
 To end a profiling session, you close the target application and explicitly shut down the profiler. In most cases, we recommend clearing the profiling environment variables at the end of a session.  
  
## Starting the Profiling Session  
  
#### To start profiling by using the instrumentation method  
  
1.  Open a Command Prompt window. If necessary, add the profiler tools directory to your PATH environment variable. The path is not added at installation.  
  
2.  Use the **VSInstr** tool to generate an instrumented version of the target application.  
  
3.  Initialize the .NET Framework profiling environment variables. Type:  
  
     **VSPerfClrEnv /traceon**  
  
4.  Start the profiler. Type:  
  
     **VSPerfCmd /start:trace /output:** `OutputFile` [`Options`]  
  
    -   The [/start](../VS_IDE/Start.md)**:trace** option initializes the profiler.  
  
    -   The [/output](../VS_IDE/Output.md)**:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.  
  
     You can use any one of the following options with the **/start:trace** option.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/user](../VS_IDE/User--VSPerfCmd-.md) **:**[`Domain`**\\**]`UserName`|Specifies the domain and user name of the account that owns the profiled process. This option is required only if the process is running as a user other than the logged-on user. The process owner is listed in the User Name column on the Processes tab of Windows Task Manager.|  
    |[/crosssession](../VS_IDE/CrossSession.md)|Enables profiling of processes in other sessions. This option is required if the ASP.NET application is running in a different session. The session idenitifier is listed in the Session ID column on the Processes tab of Windows Task Manager. **/CS** can be specified as an abbreviation for **/crosssession**.|  
    |[/globaloff](../VS_IDE/GlobalOn-and-GlobalOff.md)|Starts the profiler with data collection paused. Use [/globalon](../VS_IDE/GlobalOn-and-GlobalOff.md) to resume profiling.|  
    |[/counter](../VS_IDE/Counter.md) **:** `Config`|Collects information from the processor performance counter that is specified in `Config`. Counter information is added to the data that is collected at each profiling event.|  
    |[/wincounter](../VS_IDE/WinCounter.md) **:** `WinCounterPath`|Specifies a Windows performance counter to be collected during profiling.|  
    |[/automark](../VS_IDE/AutoMark.md) **:** `Interval`|Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms.|  
    |[/events](../VS_IDE/Events--VSPerfCmd-.md) **:** `Config`|Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file.|  
  
5.  Start the target application from the Command Prompt window.  
  
## Controlling Data Collection  
 When the target application is running, you can control data collection by starting and stopping the writing of data to the profiler data file by using **VSPerfCmd.exe** options. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the application.  
  
#### To start and stop data collection  
  
-   The following pairs of options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/globalon /globaloff](../VS_IDE/GlobalOn-and-GlobalOff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|  
    |[/processon](../VS_IDE/ProcessOn-and-ProcessOff.md) **:** `PID` [/processoff](../VS_IDE/ProcessOn-and-ProcessOff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the process ID (`PID`).|  
    |[/threadon](../VS_IDE/ThreadOn-and-ThreadOff.md) **:** `TID` [/threadoff](../VS_IDE/ThreadOn-and-ThreadOff.md) **:** `TID`|Starts (**/threadon**) or stops (**/threadoff**) data collection for the thread specified by the thread ID (`TID`).|  
  
## Ending the Profiling Session  
 To end a profiling session, close the application that is running the instrumented component. Call the **VSPerfCmd** [/shutdown](../VS_IDE/Shutdown.md) option to turn off the profiler and close the profiling data file. The **VSPerfClrEnv /off** command clears the profiling environment variables.  
  
#### To end a profiling session  
  
1.  Close the target application.  
  
2.  Shut down the profiler. Type:  
  
     **VSPerfCmd /shutdown**  
  
3.  (Optional) Clear the profiling environment variables. Type:  
  
     **VSPerfClrEnv /off**  
  
## See Also  
 [Profiling Stand-Alone Applications](../VS_IDE/Command-Line-Profiling-of-Stand-Alone-Applications.md)   
 [Instrumentation Method Data Views](../VS_IDE/Instrumentation-Method-Data-Views.md)