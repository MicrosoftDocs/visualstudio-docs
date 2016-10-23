---
title: "How to: Launch a Stand-Alone Native Application with the Profiler to Collect Concurrency Data by Using the Command Line"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e5aed651-afed-4b70-9a7e-1a6032cc614f
caps.latest.revision: 23
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# How to: Launch a Stand-Alone Native Application with the Profiler to Collect Concurrency Data by Using the Command Line
This topic describes how to use Visual Studio Profiling Tools command-line tools to start a native stand-alone (client) application and collect process and thread concurrency data.  
  
 A profiling session has the following parts:  
  
-   Starting the application with the profiler  
  
-   Controlling data collection  
  
-   Ending the profiling session  
  
> [!NOTE]
>  Command-line tools of the Profiling Tools are located in the \Team Tools\Performance Tools subdirectory of the Visual Studio installation directory. On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler at a command prompt, you must add the tools path to the PATH environment variable of the **Command Prompt** window or add it to the command itself. For more information, see [Specifying the Path to Command Line Tools](../VS_IDE/Specifying-the-Path-to-Profiling-Tools-Command-Line-Tools.md).  
  
## Starting the Application with the Profiler  
 To start a target application with the profiler, you use the [VSPerfCmd.exe](../VS_IDE/VSPerfCmd.md)**/start** and **/launch** options to initialize the Profiler and start the application. You can specify **/start** and **/launch** and their respective options. You can also add the **/globaloff** option to pause data collection at the start of the target application. You then use **/globalon** to begin to collect data.  
  
#### To start an application with the Profiler  
  
1.  At a command prompt, type the following command:  
  
     [VSPerfCmd](../VS_IDE/VSPerfCmd.md) **/start:concurrency  /output:** `OutputFile` [`Options`]  
  
     The [/output](../VS_IDE/Output.md)**:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.  
  
     You can use any of the options in the following table with the **/start:concurrency** option.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/wincounter](../VS_IDE/WinCounter.md) **:** `WinCounterPath`|Specifies a Windows performance counter to be collected during profiling.|  
    |[/automark](../VS_IDE/AutoMark.md) **:** `Interval`|Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. The default value is 500.|  
    |[/events](../VS_IDE/Events--VSPerfCmd-.md) **:** `Config`|Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file.|  
  
2.  Start the target application by typing:  
  
     **VSPerfCmd**  [/launch](../VS_IDE/Launch.md) **:** `AppName` [`Options`]  
  
     You can use any of the options in the following table with the **/launch** option.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/args](../VS_IDE/Args.md) **:** `Arguments`|Specifies a string that contains the command-line arguments to be passed to the target application.|  
    |[/console](../VS_IDE/Console.md)|Starts the target command-line application in a separate window.|  
    |[/targetclr](../VS_IDE/TargetCLR.md) **:** `CLRVersion`|Specifies the version of the common language runtime (CLR) to profile if the application loads more than one version of the CLR.|  
  
## Controlling Data Collection  
 While the target application is running, you can control data collection by starting and stopping the writing of data to the file with VSPerfCmd.exe options. By controlling data collection, you can collect data for a specific part of program execution, such as the starting or shutting down of the application.  
  
#### To start and stop data collection  
  
-   The pairs of options in the following table start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/globalon /globaloff](../VS_IDE/GlobalOn-and-GlobalOff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|  
    |[/processon](../VS_IDE/ProcessOn-and-ProcessOff.md) **:** `PID` [/processoff](../VS_IDE/ProcessOn-and-ProcessOff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process that the process ID (`PID`) specifies.|  
    |[/attach](../VS_IDE/Attach.md) **:**{`PID`&#124;`ProcName`} [/detach](../VS_IDE/Detach.md)[**:**{`PID`&#124;`ProcName`}]|**/attach** starts to collect data for the process that the process ID (`PID`) or process name (*ProcName*) specifies. **/detach** stops data collection for the specified process or for all processes if no process is specified.|  
  
-   You can also use the **VSPerfCmd.exe**[/mark](../VS_IDE/Mark.md) option to insert a profiling mark into the data file. The **/mark** command adds an identifier, a time stamp, and an optional user-defined text string. Marks can be used to filter the data in profiler reports and data views.  
  
## Ending the Profiling Session  
 To end a profiling session, the profiler must not be collecting data. You can stop collecting concurrency data by closing the profiled application or by invoking the **VSPerfCmd /detach** option. You then invoke the **VSPerfCmd /shutdown** option to turn off the profiler and close the profiling data file.  
  
#### To end a profiling session  
  
1.  Detach the profiler from the target application by closing it or by typing the following command at a command prompt:  
  
     **VSPerfCmd /detach**  
  
2.  Shut down the profiler by typing the following command at a command prompt:  
  
     **VSPerfCmd**  [/shutdown](../VS_IDE/Shutdown.md)