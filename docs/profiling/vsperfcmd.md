---
title: VSPerfCmd | Microsoft Docs
description: Learn how the VSPerfCmd.exe tool is used to start and stop performance data collection. Also learn about various VSPerfCmd tool options.
ms.date: 11/11/2022
ms.topic: reference
helpviewer_keywords: 
  - performance tools, VSPerfCmd tool
  - command-line tools, VSPerfCmd tool
  - command line, tools
  - profiling tools,VSPerfCmd
  - VSPerfCmd tool
ms.assetid: 778bc105-7643-46c4-a338-f3620e31125a
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# VSPerfCmd

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

The *VSPerfCmd.exe* tool is used to start and stop performance data collection. It uses the following syntax:

```cmd
VSPerfCmd [/U] [/options]
```

 The following tables describe *VSPerfCmd.exe* tool options.

|Option|Description|
|------------|-----------------|
|**U**|Redirected console output is written as Unicode. Must be the first option specified.|
|[Start](/previous-versions/visualstudio/visual-studio-2017/profiling/start.md) **:** `mode`|Starts the profiling service in the specified mode.|
|[Output](/previous-versions/visualstudio/visual-studio-2017/profiling/output.md) **:** `filename`|Specifies the output file name. Use only with **Start**.|
|[CrossSession&#124;CS](/previous-versions/visualstudio/visual-studio-2017/profiling/crosssession.md)|Enables profiling across Windows sessions. Use only with **Start**, **Attach**, **or Launch**.|
|[User](/previous-versions/visualstudio/visual-studio-2017/profiling/user-vsperfcmd.md) **:**[`domain\`]`username`|Enables the specified account access to the profiler service. Use only with **Start**.|
|[WaitStart](/previous-versions/visualstudio/visual-studio-2017/profiling/waitstart.md)[**:**`n`]|Waits for the data collection logger to initialize. If `n` is specified, **VSPerfCmd** will wait at most `n` seconds. If `n` is not specified, **VSPerfCmd** will wait indefinitely. This eases use of **VSPerfCmd** as part of a batch process.|
|[Counter](/previous-versions/visualstudio/visual-studio-2017/profiling/counter.md) **:** `cfg`|When the sample profiling method is used, specifies a CPU counter and the number of events to use as the sampling interval. You can sample only one counter value.<br /><br /> When the instrumentation profiling method is used, specifies a CPU counter to be collected at each instrumentation point. Use only with **Start:**`Trace`, **Attach**, or **Launch**.|
|[QueryCounters](/previous-versions/visualstudio/visual-studio-2017/profiling/querycounters.md)|Displays a list of valid CPU counters for the current machine.|
|[WinCounter](/previous-versions/visualstudio/visual-studio-2017/profiling/wincounter.md) **:** *path*|Specifies a Windows performance counter event to include with profile mark data. Use only with **Start**.|
|[AutoMark](/previous-versions/visualstudio/visual-studio-2017/profiling/automark.md) **:** *n*|Specifies the time interval (in milliseconds) between Windows performance counter data collection events. Use with **WinCounter**.|
|[Events](/previous-versions/visualstudio/visual-studio-2017/profiling/events-vsperfcmd.md) **:** `option`|Controls collection of specified Event Tracing for Windows (ETW) events. ETW data is collected to an .*itl* file that is not the profiling data (.*vsp*) file.|
|[Status](/previous-versions/visualstudio/visual-studio-2017/profiling/status.md)|Displays the state of the profiler, information about processes that are currently being profiled, and accounts that have authority to control the profiler.|
|[Shutdown](/previous-versions/visualstudio/visual-studio-2017/profiling/shutdown.md)[**:**`n`]|Closes the profiling data file and turns the profiler off.|
|[GlobalOn](/previous-versions/visualstudio/visual-studio-2017/profiling/globalon-and-globaloff.md)|Resumes data collection after a call to **VSPerfCmdGlobalOff**.|
|[GlobalOff](/previous-versions/visualstudio/visual-studio-2017/profiling/globalon-and-globaloff.md)|Stops all data collection, but does not end the profiling session.|
|[ProcessOn](/previous-versions/visualstudio/visual-studio-2017/profiling/processon-and-processoff.md) **:** `pid`|Resumes data collection for the specified process after profiling was paused by a call to **VSPerfCmdProcessOff**.|
|[ProcessOff](/previous-versions/visualstudio/visual-studio-2017/profiling/processon-and-processoff.md) **:** `pid`|Stops data collection for the specified process.|
|[ThreadOn and ThreadOff](/previous-versions/visualstudio/visual-studio-2017/profiling/threadon-and-threadoff.md) **:** *tid*|Resumes profiling for the specified process after profiling was paused by a call to **VSPerfCmdThreadOff**. Use **ThreadOn** only when profiling with the instrumentation method.|
|[ThreadOn and ThreadOff](/previous-versions/visualstudio/visual-studio-2017/profiling/threadon-and-threadoff.md) **:** *tid*|Pauses profiling for the specified thread. Use **ThreadOff** only when profiling with the instrumentation method.|
|[Mark](/previous-versions/visualstudio/visual-studio-2017/profiling/mark.md) **:** _MarkNum_[**,**_MarkText_**]**|Inserts a mark into the profiling data file, with optional text.|

## See also

- [VSInstr](../profiling/vsinstr.md)
