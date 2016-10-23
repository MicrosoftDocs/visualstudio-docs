---
title: "How to: Attach the Profiler to an ASP.NET Web Application to Collect Memory Data by Using the Command Line"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d608f85a-41ae-4ca7-85e6-b96624dbc83c
caps.latest.revision: 31
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
# How to: Attach the Profiler to an ASP.NET Web Application to Collect Memory Data by Using the Command Line
This topic describes how to use Visual Studio Profiling Tools command-line tools to attach the profiler to a ASP.NET Web application and collect data about the number and size of .NET Framework memory allocations. You can also collect data about the lifetime of .NET Framework memory objects.  
  
> [!NOTE]
>  Command-line tools of the Profiling Tools are located in the \Team Tools\Performance Tools subdirectory of the Visual Studio installation directory. On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself. For more information, see [Specifying the Path to Command Line Tools](../VS_IDE/Specifying-the-Path-to-Profiling-Tools-Command-Line-Tools.md).  
  
 To collect performance data from a ASP.NET Web application, you must use the [VSPerfCLREnv.cmd](../VS_IDE/VSPerfCLREnv.md) tool to initialize the appropriate environment variables on the computer that hosts the ASP.NET Web application. You must then restart the computer to configure the Web server for profiling.  
  
 You then use the [VSPerfCmd.exe](../VS_IDE/VSPerfCmd.md) tool to attach the profiler to the ASP.NET worker process that hosts your Web site. When the profiler is attached to the application, you can pause and resume data collection.  
  
 To end a profiling session, the profiler must no longer be attached to the application and the profiler must be explicitly shut down. In most cases, we recommend clearing the profiling environment variables at the end of a session.  
  
## Attaching the Profiler  
  
#### To attach the Profiler to an ASP.NET Web application  
  
1.  Open a Command Prompt window.  
  
2.  Initialize the profiling environment variables. Type:  
  
     **VSPerfClrEnv** {**/globalsamplegc** &#124; **/globalsamplegclife**} [**/samplelineoff**]  
  
    -   The options **/globalsamplegc** and **/globalsamplegclife** specify the type of memory data to collect.  
  
         Specify one and only one of the following options.  
  
        |Option|Description|  
        |------------|-----------------|  
        |**/globalsamplegc**|Enables the collection of memory allocation data.|  
        |**/globalsamplegclife**|Enables the collection of both memory allocation data and object lifetime data.|  
  
    -   The option **/samplelineoff** disables the assignment of collected data to specific source code lines. If this option is specified, data is assigned at the function level.  
  
3.  Restart the computer to set the new environment configuration.  
  
4.  Open a Command Prompt window. If necessary, set the profiler path enviroment variable.  
  
5.  Start the profiler. Type:  
  
     **VSPerfCmd**  [/start](../VS_IDE/Start.md) **:sample**  [/output](../VS_IDE/Output.md) **:** `OutputFile` [`Options`]  
  
    -   The **/start:sample** option initializes the profiler.  
  
    -   The **/output:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.  
  
     You can use any of the following options with the **/start:sample** option.  
  
    > [!NOTE]
    >  The **/user** and **/crosssession** options are usually required for ASP.NET applications.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/user](../VS_IDE/User--VSPerfCmd-.md) **:**[`Domain`**\\**]`UserName`|Specifies the domain and user name of the account that owns the ASP.NET worker process. This option is required if the process is running as a user other than the logged-on user. The process owner is listed in the User Name column on the Processes tab of Windows Task Manager.|  
    |[/crosssession](../VS_IDE/CrossSession.md)|Enables profiling of processes in other logon sessions. This option is required if the ASP.NET application is running in a different session. The session idenitifier is listed in the Session ID column on the Processes tab of Windows Task Manager. **/CS** can be specified as an abbreviation for **/crosssession**.|  
    |[/waitstart](../VS_IDE/WaitStart.md) [**:**`Interval`]|Specifies the number of seconds to wait for the profiler to initialize before it returns an error. If `Interval` is not specified, the profiler waits indefinitely. By default, **/start** returns immediately.|  
    |[/wincounter](../VS_IDE/WinCounter.md) **:** `WinCounterPath`|Specifies a Windows performance counter to be collected during profiling.|  
    |[/automark](../VS_IDE/AutoMark.md) **:** `Interval`|Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms.|  
    |[/events](../VS_IDE/Events--VSPerfCmd-.md) **:** `Config`|Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file.|  
  
6.  Start the ASP.NET Web application in the typical way.  
  
7.  Attach the profiler to the ASP.NET worker process. Type:  
  
     **VSPerfCmd**  [/attach](../VS_IDE/Attach.md) **:**{`PID`&#124;`ProcName`} [[/targetclr](../VS_IDE/TargetCLR.md)**:**`Version`]  
  
    -   The process ID `(PID)` specifies the process ID or the process name of the ASP.NET worker process. You can view the process IDs of all running processes in Windows Task Manager.  
  
    -   **/targetclr:** `Version` specifies the version of the common language runtime (CLR) to profile when more than one version of the runtime is loaded in an application.  
  
## Controlling Data Collection  
 While the application is running, you can control data collection by starting and stopping the writing of data to the profiler data file by using **VSPerfCmd.exe** options. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the application.  
  
#### To start and stop data collection  
  
-   The following pairs of **VSPerfCmd** options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/globalon /globaloff](../VS_IDE/GlobalOn-and-GlobalOff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|  
    |[/processon](../VS_IDE/ProcessOn-and-ProcessOff.md) **:** `PID` [/processoff](../VS_IDE/ProcessOn-and-ProcessOff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the `PID`.|  
    |**/attach:**{`PID`&#124;`ProcName`} [/detach](../VS_IDE/Detach.md)[**:**{`PID`&#124;:`ProcName`}]|**/attach** starts to collect data for the process that is specified by the process ID or process name. **/detach** stops data collection for the specified process or for all processes if a specific process is not specified.|  
  
## Ending the Profiling Session  
 To end a profiling session, the profiler must be detached from the Web application. You can stop the collection of data from an application that is profiled with the sampling method by restarting the ASP.NET worker process or by calling the **VSPerfCmd /detach** option. You then call the **VSPerfCmd** [/shutdown](../VS_IDE/Shutdown.md) option to turn off the profiler and close the profiling data file. The **VSPerfClrEnv /globaloff** command clears the profiling environment variables, but the system configuration is not reset until the computer is restarted.  
  
#### To end a profiling session  
  
1.  Perform one of the following steps to detach the profiler from the target application:  
  
    -   Type **VSPerfCmd** [/detach](../VS_IDE/Detach.md)  
  
         -or-  
  
    -   Close the ASP.NET worker process. Type:  
  
     **IISReset /stop**  
  
2.  Shut down the profiler. Type:  
  
     **VSPerfCmd /shutdown**  
  
3.  (Optional) Clear the profiling environment variables. Type:  
  
     **VSPerfCmd /globaloff**  
  
4.  Restart the computer. If necessary, restart Internet Information Services (IIS). Type:  
  
     **IISReset /start**  
  
## See Also  
 [Profiling ASP.NET Web Applications](../VS_IDE/Command-Line-Profiling-of-ASP.NET-Web-Applications.md)   
 [.NET Memory Data Views](../VS_IDE/.NET-Memory-Data-Views.md)