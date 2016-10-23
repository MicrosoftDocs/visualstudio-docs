---
title: "VSPerfCmd"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 778bc105-7643-46c4-a338-f3620e31125a
caps.latest.revision: 49
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
# VSPerfCmd
The **VSPerfCmd.exe** tool is used to start and stop performance data collection. It uses the following syntax:  
  
```  
VSPerfCmd [/U] [/options]  
```  
  
 The following tables describe **VSPerfCmd.exe** tool options.  
  
|Option|Description|  
|------------|-----------------|  
|**U**|Redirected console output is written as Unicode. Must be the first option specified.|  
|[Start](../VS_IDE/Start.md) **:** `mode`|Starts the profiling service in the specified mode.|  
|[Output](../VS_IDE/Output.md) **:** `filename`|Specifies the output file name. Use only with **Start**.|  
|[CrossSession&#124;CS](../VS_IDE/CrossSession.md)|Enables profiling across Windows sessions. Use only with **Start**, **Attach**, **or Launch**.|  
|[User](../VS_IDE/User--VSPerfCmd-.md) **:**[`domain\`]`username`|Enables the specified account access to the profiler service. Use only with **Start**.|  
|[WaitStart](../VS_IDE/WaitStart.md)[**:**`n`]|Waits for the data collection logger to initialize. If `n` is specified, **VSPerfCmd** will wait at most `n` seconds. If `n` is not specified, **VSPerfCmd** will wait indefinitely. This eases use of **VSPerfCmd** as part of a batch process.|  
|[Counter](../VS_IDE/Counter.md) **:** `cfg`|When the sample profiling method is used, specifies a CPU counter and the number of events to use as the sampling interval. You can sample only one counter value.<br /><br /> When the instrumentation profiling method is used, specifies a CPU counter to be collected at each instrumentation point. Use only with **Start:**`Trace`, **Attach**,or **Launch**.|  
|[QueryCounters](../VS_IDE/QueryCounters.md)|Displays a list of valid CPU counters for the current machine.|  
|[WinCounter](../VS_IDE/WinCounter.md) **:** *path*|Specifies a Windows performance counter event to include with profile mark data. Use only with **Start**.|  
|[AutoMark](../VS_IDE/AutoMark.md) **:** *n*|Specifies the time interval (in milliseconds) between Windows performance counter data collection events. Use with **WinCounter**.|  
|[Events](../VS_IDE/Events--VSPerfCmd-.md) **:** `option`|Controls collection of specified Event Tracing for Windows (ETW) events. ETW data is collected to an .itl file that is not the profiling data (.vsp) file.|  
|[Status](../VS_IDE/Status.md)|Displays the state of the profiler, information about processes that are currently being profiled, and accounts that have authority to control the profiler.|  
|[Shutdown](../VS_IDE/Shutdown.md)[**:**`n`]|Closes the profiling data file and turns the profiler off.|  
|[GlobalOn](../VS_IDE/GlobalOn-and-GlobalOff.md)|Resumes data collection after a call to **VSPerfCmdGlobalOff**.|  
|[GlobalOff](../VS_IDE/GlobalOn-and-GlobalOff.md)|Stops all data collection, but does not end the profiling session.|  
|[ProcessOn](../VS_IDE/ProcessOn-and-ProcessOff.md) **:** `pid`|Resumes data collection for the specified process after profiling was paused by a call to **VSPerfCmdProcessOff**.|  
|[ProcessOff](../VS_IDE/ProcessOn-and-ProcessOff.md) **:** `pid`|Stops data collection for the specified process.|  
|[ThreadOn and ThreadOff](../VS_IDE/ThreadOn-and-ThreadOff.md) **:** *tid*|Resumes profiling for the specified process after profiling was paused by a call to **VSPerfCmdThreadOff**. Use **ThreadOn** only when profiling with the instrumentation method.|  
|[ThreadOn and ThreadOff](../VS_IDE/ThreadOn-and-ThreadOff.md) **:** *tid*|Pauses profiling for the specified thread. Use **ThreadOff** only when profiling with the instrumentation method.|  
|[Mark](../VS_IDE/Mark.md) **:** *MarkNum*[**,***MarkText***]**|Inserts a mark into the profiling data file, with optional text.|  
  
## Sampling Method Options  
 The following options are only available when you are using the sampling profiling method.  
  
|Option|Description|  
|------------|-----------------|  
|[Launch](../VS_IDE/Launch.md) **:** *Executable*|Starts the specified application and begins profiling.|  
|[Args](../VS_IDE/Args.md) **:** *Arguments*|Specifies command line arguments to pass to the launched application.|  
|[Console](../VS_IDE/Console.md)|Starts the specified command in a new command prompt window.|  
|[Attach](../VS_IDE/Attach.md) **:** *PID*[**,***PID*]|Begins profiling the specified processes. Processes can be identified by the process id or by the process name.|  
|[Detach](../VS_IDE/Detach.md)[**:***PID*[,*PID*]]|Stops profiling the specified processes. Processes can be identified by the process id or by the process name. If no process is specified, profiling is halted for all processes.|  
|[GC](../VS_IDE/GC--VSPerfCmd-.md)[**:**{**Allocation**`&#124;`**Lifetime**}]|Collects .NET memory allocation and object lifetime data. Use only with the **VSPerfCmdLaunch** option.|  
  
### Sampling Interval Options  
 The following options specify the type and duration of sampling intervals. The default is **Timer**. You can also specify a CPU counter as the interval by using the **Counter** option. These options can only be specified with **Launch** or with the first **Attach** of a profiling session.  
  
|Option|Description|  
|------------|-----------------|  
|[PF](../VS_IDE/PF.md)[**:***n*]|Samples on every n-th page fault (default=10).|  
|[Sys](../VS_IDE/Sys--VSPerfCmd-.md)[**:***n*]|Samples on every n-th system call (default=10).|  
|[Timer](../VS_IDE/Timer.md)[**:***n*]|Samples on every n-th processor cycle (default=10000000).|  
  
## Service Component and Kernel Mode Device Options  
 The following Admin options support profiling service components or kernel mode device drivers. The Admin options set profiling permissions and control the profiled service or device driver.  
  
 Admin options must be executed at a command prompt that is running with administrative credentials.  
  
|Option|Description|  
|------------|-----------------|  
|**Admin:Security** <**ALLOW&#124;DENY**> *Right*[ *Right*] <*User*&#124;*Group*>|Allows or denies the specified user or group access to profiling services.<br /><br /> `Right` can be:<br /><br /> CrossSession - gives the user access to the service to do cross session profiling.<br /><br /> SampleProfiling - gives the user access to the driver to enable sampling profiling. Also used to access kernel transition information during trace profiling.<br /><br /> FullAccess - gives the user both CrossSession and SampleProfiling access.|  
|**Admin:Security, List**|Lists the current state of profiling services and lists user permissions.|  
|**Admin:** <*Service*&#124;*Driver*><**START**&#124;**STOP**&#124;**INSTALL**&#124;**UNINSTALL**>|Starts, stops, installs, or uninstalls the profiling service component (service) or kernel mode device driver (driver).|  
|**Admin:** <*Service*&#124;*Driver*>**AutoStart**<**ON**&#124;**OFF**>|Enables or disables automatically starting the profiling service (service) or kernel mode device driver (driver) after a restart.|  
  
## VSPerfCmd /Driver  
 The **VSPerfCmd /Driver** option is now obsolete. Use the **VsPerfCmdAdmin** options for this functionality.  
  
## See Also  
 [VSInstr](../VS_IDE/VSInstr.md)   
 [VSPerfMon](../VS_IDE/VSPerfMon.md)   
 [VSPerfReport](../VS_IDE/VSPerfReport.md)