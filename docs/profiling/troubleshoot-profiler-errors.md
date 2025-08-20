---
title: Troubleshoot profiling errors
description: Troubleshoot profiling errors, including no data in filters, slow results, and source information unavailable, and follow error message guidance to fix issues.
ms.date: 08/19/2025
ms.topic: how-to
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Troubleshoot profiling errors and fix issues

This article provides solutions for some of the most common errors that can prevent using or getting sufficient data from the Performance Profiler in Visual Studio.

## No results

Error: "There is no data in the current set of filters"

When opening a *diagsession* file, certain filters are applied such as hiding native code, or hiding non-user code to make the trace easier to understand. Additionally, there are other filters that can be applied such as **time selection** and **thread**, which further narrow down the data shown. If these filters are applied in a way that there's no data remaining to show, then you see this warning.

**How to fix** 
- Ensure that your time selection has data in it. If you changed your time selection in the graph above the data, select **Clear Selection** to reset it.
- Next, if there's still no data, ensure that all categories and threads are enabled in their respective dropdowns.
- If the application you're profiling is native code, then be sure to enable the **Show Native Code** option in the **Settings** drop-down. 
- If you still have no data, then the trace you collected likely was too short for any data to be present. Make sure the program you're collecting data for doesn't complete too quickly (less than a second).

See also: [Show External Code](../profiling/optimize-profiler-settings.md)

## Taking a long time for the results to complete

If analyzing the heap after collection seems slow to load, see the following possible solutions that can help resolve wait time issues.

**How to fix**
Sometimes it can take longer when trying to analyze snapshots from memory-intensive applications, but upgrading to a more recent version of Visual Studio should reduce the analysis wait time. If this issue is persistent after upgrading, there might be a performance bug on the tool. Create a feedback ticket and share the *diagsession* file that was created. With the file, we can determine why the data is slow to analyze and find where we can make performance improvements.

Be sure to provide a trace and heap dump files in the Feedback ticket.

See also: 
- [How to collect a ETW trace](../ide/how-to-report-a-problem-with-visual-studio.md)
- [For symbol loading issues](../profiling/optimize-profiler-settings.md)

## Error "Could not create a manifest file for this *diagsession*" or "error could not create manifest file for *diagsession*, Visual Studio will not able to reopen this session."

This issue means there was a problem when preparing the memory snapshot data to be analyzed and displayed after stopping to collect data. There are multiple potential causes for the issue to appear, from a failure to get the correct information from the collection agents to the actual data processing. Therefore, it won't be possible to diagnose what the issue is without further logging.

**How to fix**
Reply to your Feedback ticket with additional logging information so that we can diagnose the issue. You can get the log information by running the following commands from an elevated command prompt:

```console
reg add HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\DiagnosticsHub /v LogLevel /t REG_SZ /d All /reg:32
reg add HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\DiagnosticsHub /v LogDirectory /t REG_SZ /d [directory of your choice] /reg:32
```
 
After running these commands, start Visual Studio, reproduce your scenario, close Visual Studio, then zip up your chosen DiagnosticsHub log directory and attach it to this ticket. From that point, we should be able to better diagnose what is happening.

After adding the log to your ticket, run these commands to disable logging:

```console
reg delete HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\DiagnosticsHub /f /v LogLevel /reg:32
reg delete HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\DiagnosticsHub /f /v LogDirectory /reg:32
```

## Error: "Source information not available."
In order to view source information, you need to have PDBs available from the time of collection. So, for example, if you collect a CPU usage 
*diagsession* file, make some changes to your code, recompile (which replaces the old PBD), then open the *.diagsession* again, you wouldn't likely be able to see source information for the modules of your code that you updated. 

**How to fix**
The easiest workaround for this issue is to collect a new *diagsession* after making changes. This way you can be sure your PDBs are up to date. 

## Error: "Memory analysis failed due to an internal error."

After a long memory profiling session, any attempt to analyze the result is met with the error.

There was a mismatch between the snapshot information captured by the memory tool and that of the collection agent. This result means that the memory tool wasn't able to find the heap state file for a native snapshot. Or, this result the memory tool couldn't match the GC start time of the snapshot to the one registered in the *diagsession* file to retrieve the GCStats.

**How to fix**
This issue was due to a bug in the tool that was fixed in Visual Studio 2022 version 17.3. Upgrading to a later version should solve the issue. If the issue is still persistent after upgrading, create a feedback ticket and attach to the ticket:

- The *diagsession* file
- A minidump of Visual Studio
- A screenshot of the memory snapshots that were taken.

There isn't a workaround for this issue and the profiling session will need to be restarted.

## Error: “X diagnostic events dropped, some information in the report may be missing or inaccurate”

Sometimes during data capture, events can be dropped that can cause the resulting profiling report to be inaccurate or unusable. Dropped events can happen for many different reasons, but it primarily occurs when the system is unable to flush events out to disk faster than the incoming rate.

**How to fix**
To help reduce dropped events, you can close other disk- and CPU-intensive operations while profiling. By closing these operations, the system can dedicate more resources to flushing the incoming events. You can also try reducing the sampling frequencies on the tools that support these configuration settings, such as the CPU Usage tool and .NET Allocation tool, and thereby reduce overhead.

## Error: ETW resources have been exhausted

The Visual Studio profiler uses Event Tracing for Windows (ETW) to collect its performance information. There are a finite number of ETW sessions available for use on a system and if all the sessions are already in use you get the following error: `ETW resources have been exhausted`. These sessions are used by other programs such as the SysInternals suite of tools, other profilers, and other diagnostic tools. You can resolve this issue by either:

- Closing the programs that are using the sessions to free up resources, or
- Setting aside more resources by running the following from an elevated command prompt and then rebooting:

  ```cmd
  reg add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI" /v EtwMaxLoggers /t REG_DWORD /d 128
  ```

  Running this command increases the default number of sessions from 64 to 128 (256 is the max number of sessions allowed on a system).

## Error: CPU Usage tool doesn’t work on ARM64 VM

The Visual Studio profiler uses Event Tracing for Windows (ETW) to collect its performance information. Currently, collecting profile samples using ETW is unsupported on Windows for ARM64 when running in a Virtual Machine (VM). To work around this limitation, you can either use the CPU Usage tool on an actual ARM64 device or use the Instrumentation tool to capture timing information.

## Error: Memory Usage tool doesn't work on .NET 7 and .NET Runtime 8.0.0-8.0.1 with Server GC enabled

Due to an issue introduced with the .NET 7 runtime and propagated to .NET 8 runtime versions 8.0.0 and 8.0.1, it isn't possible to enumerate objects when using server garbage collection. Server garbage collection is enabled by default for ASP.NET Core applications.

**How to fix**

To work around this issue:
- Disable server garbage collection when taking a snapshot or collecting a dump of your application.
- Use an unaffected version of the .NET Runtime.

See also:
- [Workstation and server garbage collection](/dotnet/standard/garbage-collection/workstation-server-gc)
- [Runtime configuration options for garbage collection](/dotnet/core/runtime-config/garbage-collector)
- [DAC fails to enumerate heap objects on .NET 7+ due to GC Regions](https://github.com/dotnet/runtime/issues/96568)

## Related content

- [Analyze performance by using CPU profiling](../profiling/cpu-usage.md)
- [Identify hot paths with Flame Graph](../profiling/flame-graph.md)
