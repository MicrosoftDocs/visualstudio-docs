---
title: "How to: Launch a Stand-Alone .NET Framework Application with the Profiler to Collect Concurrency Data by Using the Command Line"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 17a48848-bd3e-44ef-9971-e39836ff1df2
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
# How to: Launch a Stand-Alone .NET Framework Application with the Profiler to Collect Concurrency Data by Using the Command Line
This topic describes how to use Visual Studio Profiling Tools command-line tools to start a .NET Framework stand-alone (client) application and collect process and thread concurrency data  
  
> [!NOTE]
>  Command-line tools of the Profiling Tools are located in the \Team Tools\Performance Tools subdirectory of the Visual Studio installation directory. On 64 bit computers, both 64 bit and 32 bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the command prompt window or add it to the command itself. For more information, see [Specifying the Path to Command Line Tools](../VS_IDE/Specifying-the-Path-to-Profiling-Tools-Command-Line-Tools.md).  
  
 While the profiler is attached to the application, you can pause and resume data collection. To end a profiling session, the Profiler must no longer be attached to the application and the Profiler must be explicitly shut down.  
  
## Starting the Application with the Profiler  
 To launch a .NET Framework target application with the Profiler, you use VSPerfClrEnv.exe to set the .NET Framework profiling variables. You then use the VSPerfCmd **/start** and **/launch** options to initialize the Profiler and start the application. You can specify **/start** and **/launch** and their respective options on a single command line. You can also add the **/globaloff** option to the command line to pause data collection when the target application starts. You then use **/globalon** on a separate command line to start to collect data.  
  
#### To start an application with the Profiler  
  
1.  Open a command prompt window.  
  
2.  Start the profiler. Type:  
  
     [VSPerfCmd](../VS_IDE/VSPerfCmd.md) **/start:concurrency**[**,**{**ResourceOnly**&#124;**ThreadOnly**}] **/output:**`OutputFile` [`Options`]  
  
    -   The [/start](../VS_IDE/Start.md) option initializes the profiler.  
  
        |||  
        |-|-|  
        |**/start:concurrency**|Enables collecting both resource contention and thread execution data.|  
        |**/start:concurrency,resourceonly**|Enables collecting only resource contention data.|  
        |**/start:concurrency,threadonly**|Enables collecting only thread execution data.|  
  
    -   The [/output](../VS_IDE/Output.md)**:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.  
  
     You can use any of the following options with the **/start:concurrency** option.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/user](../VS_IDE/User--VSPerfCmd-.md) **:**[`domain\`]`username`|Specifies the optional domain and user name of the account to be granted access to the profiler.|  
    |[/crosssession](../VS_IDE/CrossSession.md)|Enables profiling of processes in other logon sessions.|  
    |[/wincounter](../VS_IDE/WinCounter.md) **:** `WinCounterPath`|Specifies a Windows performance counter to be collected during profiling.|  
    |[/automark](../VS_IDE/AutoMark.md) **:** `Interval`|Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms.|  
    |[/events](../VS_IDE/Events--VSPerfCmd-.md) **:** `Config`|Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file.|  
  
3.  Start the target application. Type:  
  
     **VSPerfCmd**  [/launch](../VS_IDE/Launch.md) **:** `AppName` [`Options`] [`Sample Event`]  
  
     You can use any of the following options with the **/launch** option.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/args](../VS_IDE/Args.md) **:** `Arguments`|Specifies a string that contains the command-line arguments to be passed to the target application.|  
    |[/console](../VS_IDE/Console.md)|Starts the target command-line application in a separate window.|  
    |[/targetclr](../VS_IDE/TargetCLR.md) **:** `Version`|Specifies the version of the common language runtime (CLR) to profile when more than one version of the runtime is loaded in an application.|  
  
## Controlling Data Collection  
 While the target application is running, you can control data collection by starting and stopping the writing of data to the file by using VSPerfCmd.exe options. Controlling data collection enables you to collect data for a specific part of program execution, such as the starting or shutdown of the application.  
  
#### To start and stop data collection  
  
1.  The following pairs of VSPerfCmd.exe options start and stop data collection. Specify each option on a separate command-line. You can turn data collection on and off multiple times.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/globalon /globaloff](../VS_IDE/GlobalOn-and-GlobalOff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|  
    |[/processon](../VS_IDE/ProcessOn-and-ProcessOff.md) **:** `PID` [/processoff](../VS_IDE/ProcessOn-and-ProcessOff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the process ID (`PID`).|  
    |[/attach](../VS_IDE/Attach.md) **:**{`PID`&#124;`ProcName`} [/detach](../VS_IDE/Detach.md)[**:**{`PID`&#124;`ProcName`}]|**/attach** starts to collect data for the process specified by the process ID (`PID`) or process name (ProcName). **/detach** stops data collection for the specified process or for all processes if a specific process is not specified.|  
  
## Ending the profiling session  
 To end a profiling session, the profiler must not be collecting data. You can stop collecting concurrency data by closing the profiled application or by invoking the **VSPerfCmd /detach** option. You then invoke the **VSPerfCmd /shutdown** option to turn off the profiler and close the profiling data file. The **VSPerfClrEnv /off** command clears the profiling environment variables.  
  
#### To end a profiling session  
  
1.  Do one of the following to detach the profiler from the target application.  
  
    -   Close the target application.  
  
         -or-  
  
    -   Type **VSPerfCmd /detach**  
  
2.  Shut down the profiler  
  
     **VSPerfCmd**  [/shutdown](../VS_IDE/Shutdown.md)  
  
## See Also  
 [Collecting Concurrency Data](../VS_IDE/Collecting-Concurrency-Data-for-Stand-Alone-Applications-by-Using-the-Profiler-Command-Line.md)