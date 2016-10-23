---
title: "How to: Attach the Profiler to an ASP.NET Web Application to Collect Application Statistics by Using the Command Line"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3725ddbe-ce91-4469-991e-8c5ed048c618
caps.latest.revision: 33
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
# How to: Attach the Profiler to an ASP.NET Web Application to Collect Application Statistics by Using the Command Line
This topic describes how to use Visual Studio Profiling Tools command-line tools to attach the profiler to an ASP.NET Web application and collect performance statistics by using the sampling method.  
  
> [!NOTE]
>  Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../VS_IDE/Performance-Tools-on-Windows-8-and-Windows-Server-2012-applications.md).  
>   
>  Adding tier interaction data to a profiling run requires specific procedures with the command line profiling tools. See [Collecting tier interaction data](../VS_IDE/Adding-tier-interaction-data-from-the-command-line.md).  
>   
>  Command-line tools of the Profiling Tools are located in the \Team Tools\Performance Tools subdirectory of the Visual Studio installation directory. On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the command Prompt window or add it to the command itself. For more information, see [Specifying the Path to Command Line Tools](../VS_IDE/Specifying-the-Path-to-Profiling-Tools-Command-Line-Tools.md).  
  
 To collect performance data from an ASP.NET Web application, the appropriate environment variables must be initialized and the computer that hosts the ASP.NET Web application must be restarted to configure the Web server for profiling.  
  
 You then attach the profiler to the ASP.NET worker process that hosts your Web site. When the profiler is attached to the application, you can pause and resume data collection.  
  
 To end a profiling session, the profiler must be detached from the profiled application and the profiler must be explicitly shut down. In most cases, we recommend clearing the profiling environment variables at the end of a session.  
  
## Starting the Profiler and Attaching to an ASP.NET Web Application  
  
#### To attach the Profiler to an ASP.NET Web application  
  
1.  Open a command Prompt window.  
  
2.  Initialize the profiling environment variables. Type:  
  
     **VSPerfClrEnv /globalsampleon** [**/samplelineoff**]  
  
    -   **/globalsampleon** enables sampling.  
  
    -   **/samplelineoff** disables the assignment of collected data to specific source code lines. When this option is specified, data is assigned only to functions.  
  
3.  Restart the computer.  
  
4.  Start the profiler. Type:**VSPerfCmd** [/start](../VS_IDE/Start.md)**:sample** [/output](../VS_IDE/Output.md)**:**`OutputFile`[`Options`]  
  
    -   The **/start:sample** option initializes the profiler.  
  
    -   The **/output:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.  
  
     You can use any one of the following options with the **/start:sample** option.  
  
    > [!NOTE]
    >  The **/user** and **/crosssession** options are usually required for ASP.NET applications.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/user](../VS_IDE/User--VSPerfCmd-.md) **:**[`Domain`**\\**]`UserName`|Specifies the domain and user name of the account that owns the ASP.NET worker process. This option is required if the process is running as a user other than the logged-on user. The process owner is listed in the User Name column on the Processes tab of Windows Task Manager.|  
    |[/crosssession](../VS_IDE/CrossSession.md)|Enables profiling of processes in other logon sessions. This option is required if the ASP.NET application is running in a different session. The session idenitifier is listed in the Session ID column on the Processes tab of Windows Task Manager. **/CS** can be specified as an abbreviation for **/crosssession**.|  
    |[/wincounter](../VS_IDE/WinCounter.md) **:** `WinCounterPath`|Specifies a Windows performance counter to be collected during profiling.|  
    |[/automark](../VS_IDE/AutoMark.md) **:** `Interval`|Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms.|  
    |[/events](../VS_IDE/Events--VSPerfCmd-.md) **:** `Config`|Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file.|  
  
5.  Start the ASP.NET Web application in the typical way.  
  
6.  Attach the profiler to the ASP.NET worker process. Type:**VSPerfCmd** [/attach](../VS_IDE/Attach.md)**:**{`PID`&#124;`ProcName`} [`Sample Event`] [[/targetclr](../VS_IDE/TargetCLR.md)**:**`Version`]  
  
    -   `PID` specifies the process ID of the ASP.NET worker process; `ProcName` specifies the name of the worker process. You can view the process IDs and names of all running processes in Windows Task Manager.  
  
    -   By default, performance data is sampled every 10,000,000 non-halted processor clock cycles. This is approximately 100 times per second on a 1GH processor. You can specify one of the following **VSPerfCmd** options to change the clock cycle interval or to specify a different sampling event.  
  
    |Sample event|Description|  
    |------------------|-----------------|  
    |[/timer](../VS_IDE/Timer.md) **:** `Interval`|Changes the sampling interval to the number of non-halted clock cycles that are specified by `Interval`.|  
    |[/pf](../VS_IDE/PF.md)[**:**`Interval`]|Changes the sampling event to page faults. If `Interval` is specified, sets the number of page faults between samples. Default is 10.|  
    |[/sys](../VS_IDE/Sys--VSPerfCmd-.md)[`:``Interval`]|Changes the sampling event to system calls from the process to the operating system kernel (syscalls). If `Interval` is specified, sets the number of calls between samples. Default is 10.|  
    |[/counter](../VS_IDE/Counter.md) **:** `Config`|Changes the sampling event and interval to the processor performance counter and interval that are specified in `Config`.|  
    |[/targetclr](../VS_IDE/TargetCLR.md) **:** `Version`|Specifies the version of the common language runtime (CLR) to profile when more than one version of the runtime is loaded in an application.|  
  
    -   **targetclr:** `Version` specifies the version of the CLR to profile when more than one version of the runtime is loaded in an application. Optional.  
  
## Controlling Data Collection  
 When the application is running, you can control data collection by starting and stopping the writing of data to the file by using **VSPerfCmd.exe** options. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the application.  
  
#### To start and stop data collection  
  
-   The following pairs of **VSPerfCmd** options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/globalon /globaloff](../VS_IDE/GlobalOn-and-GlobalOff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|  
    |[/processon](../VS_IDE/ProcessOn-and-ProcessOff.md) **:** `PID` **/processoff:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process that is specified by the `PID`.|  
    |[/attach](../VS_IDE/Attach.md) **:**{`PID`&#124;`ProcName`} [/detach](../VS_IDE/Detach.md)[**:**{`PID`&#124;`ProcName`}]|**/attach** starts to collect data for the process specified by the `PID` or process name (ProcName). **/detach** stops data collection for the specified process or for all processes if a specific process is not specified.|  
  
## Ending the Profiling Session  
 To end a profiling session, close the ASP.NET Web application, and then use the Internet Information Services (IIS) **IISReset** command to close the ASP.NET worker process. Call the **VSPerfCmd** [/shutdown](../VS_IDE/Shutdown.md) option to turn off the profiler and close the profiling data file.  
  
 The **VSPerfClrEnv /globaloff** command clears the profiling environment variables. You must restart the computer for the new environment settings to be applied.  
  
 The **VSPerfClrEnv /globaloff** command clears the profiling environment variables, but the system configuration is not reset until the computer is restarted.  
  
#### To end a profiling session  
  
1.  Do one of the following to detach the profiler from the target application:  
  
    -   Type **VSPerfCmd /detach**  
  
         -or-  
  
    -   Close the ASP.NET worker process.  
  
2.  Shut down the profiler. Type:**VSPerfCmd** [/shutdown](../VS_IDE/Shutdown.md)  
  
3.  (Optional) Clear the profiling environment variables. Type:  
  
     **VSPerfCmd /globaloff**  
  
4.  Restart the computer.  
  
## See Also  
 [Profiling ASP.NET Web Applications](../VS_IDE/Command-Line-Profiling-of-ASP.NET-Web-Applications.md)   
 [Sampling Method Data Views](../VS_IDE/Profiler-Sampling-Method-Data-Views.md)