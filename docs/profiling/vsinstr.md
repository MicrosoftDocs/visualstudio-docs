---
title: "VSInstr | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "performance tools, instrumentation"
  - "instrumentation, VSInstr tool"
  - "profiling tools,VSInstr"
  - "command-line tools, instrumentation"
  - "command line, tools"
  - "VSInstr"
  - "VSInstr tool"
  - "performance tools, VSInstr tool"
ms.assetid: 7b1334f7-f9b0-4a82-a145-d0607bfa8467
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# VSInstr
The VSInstr tool is used to instrument binaries. It is invoked by using the following syntax:

```cmd
VSInstr [/U] filename [/options]
```

 The following table describes VSInstr tool options:

|Options|Description|
|-------------|-----------------|
|**Help** or **?**|Displays help.|
|**U**|Writes the redirected console output as Unicode. It must be first option specified.|
|`@filename`|Specifies the name of a response file that contains one command option per line.  Do not use quotation marks.|
|**OutputPath** `:path`|Specifies a destination directory for the instrumented image. If an output path is not specified, the original binary is renamed by appending "Orig" to the file name in the same directory, and a copy of the binary is instrumented.|
|**Exclude** `:funcspec`|Specifies a function specification to exclude from instrumentation by probes. It is useful when profiling probe insertion in a function causes unpredictable or unwanted results.<br /><br /> Do not use **Exclude** and **Include** options that refer to functions in the same binary.<br /><br /> You can specify multiple function specification with separate **Exclude** options.<br /><br /> `funcspec` is a defined as:<br /><br /> [namespace\<separator1>] [class\<separator2>]function<br /><br /> \<separator1> is `::` for native code, and `.` for managed code.<br /><br /> \<separator2> is always `::`<br /><br /> **Exclude** is supported with code coverage.<br /><br /> The wildcard character \* is supported. For example, to exclude all functions in a namespace use:<br /><br /> MyNamespace::\*<br /><br /> You can use **VSInstr /DumpFuncs** to list the complete names of functions in the specified binary.|
|**Include** `:funcspec`|Specifies a function specification in a binary to instrument with probes. All other functions in the binaries are not instrumented.<br /><br /> You can specify multiple function specifications with separate **Include** options.<br /><br /> Do not use **Include** and **Exclude** options that refer to functions in the same binary.<br /><br /> **Include** is not supported with code coverage.<br /><br /> `funcspec` is a defined as:<br /><br /> [namespace\<separator1>] [class\<separator2>]function<br /><br /> \<separator1> is `::` for native code, and `.` for managed code.<br /><br /> \<separator2> is always `::`<br /><br /> The wildcard character \* is supported. For example, to include all functions in a namespace use:<br /><br /> MyNamespace::\*<br /><br /> You can use **VSInstr /DumpFuncs** to list the complete names of functions in the specified binary.|
|**DumpFuncs**|Lists the functions within the specified image. No instrumentation is performed.|
|**ExcludeSmallFuncs**|Excludes small functions, which are short functions that do not make any function calls, from instrumentation. The **ExcludeSmallFuncs** option provides for less instrumentation overhead a thus improved instrumentation speed.<br /><br /> The exclusion of small functions also reduces the .*vsp* file size and time required for analysis.|
|**Mark:**{**Before**`&#124;`**After**`&#124;`**Top**`&#124;`**Bottom**}`,funcname,markid`|Inserts a profile mark (an identifier used to delimit the data in reports) that you can use to identify the start or end of a data range in the .vsp report file.<br /><br /> **Before** - Immediately before the target function entry.<br /><br /> **After** - Immediately after the target function exit.<br /><br /> **Top** - Immediately after the target function entry.<br /><br /> **Bottom** - Immediately before each return in the target function.<br /><br /> `funcname` - Name of the target function<br /><br /> `Markid` - A positive integer (long) to use as the identifier of the profile mark.|
|**Coverage**|Performs coverage instrumentation. It can be used only with the following options: **Verbose**, **OutputPath**, **Exclude**, and **Logfile**..|
|**Verbose**|The **Verbose** option is used to view detailed information about the instrumentation process.|
|**NoWarn** `[:[Message Number[;Message Number]]]`|Suppress all or specific warnings.<br /><br /> `Message Number` - the warning number. If `Message Number` is omitted, all warnings are suppressed.<br /><br /> For more information, see [VSInstr Warnings](../profiling/vsinstr-warnings.md).|
|**Control** `:{` **Thread** `&#124;` **Process** `&#124;` **Global** `}`|Specifies the profiling level of the following VSInstr data collection control Options:<br /><br /> **Start**<br /><br /> **StartOnly**<br /><br /> **Suspend**<br /><br /> **StopOnly**<br /><br /> **SuspendOnly**<br /><br /> **ResumeOnly**<br /><br /> **Thread** - specifies thread-level data collection control functions. Profiling is started or stopped only for the current thread. The profiling state of other threads is not affected. The default is thread.<br /><br /> **Process** - specifies process-level profiling data collection control functions. Profiling starts or stops for all threads in the current process. The profiling state of other processes is not affected.<br /><br /> **Global** - specifies global-level (cross-process) data collection control functions.<br /><br /> An error occurs if you do not specify the profiling level.|
|**Start** `:{` **Inside** `&#124;` **Outside** `},funcname`|Limits data collection to the target function and child functions called by that function.<br /><br /> **Inside** - Inserts the StartProfile function immediately after the entry to the target function. Inserts the StopProfile function immediately before each return in the target function.<br /><br /> **Outside** - Inserts the StartProfile function immediately before each call to the target function. Inserts the StopProfile function immediately after each call to the target function.<br /><br /> `funcname` - the name of the target function.|
|**Suspend** `:{` **Inside** `&#124;` **Outside** `},funcname`|Excludes data collection for the target function and child functions called by the function.<br /><br /> **Inside** - Inserts the SuspendProfile function immediately after the entry to the target function. Inserts the ResumeProfile function immediately before each return in the target function.<br /><br /> **Outside** - Inserts the SuspendProfile function immediately before the entry to the target function. Inserts the ResumeProfile function immediately after the exit from the target function.<br /><br /> `funcname` - name of the target function.<br /><br /> If the target function contains a StartProfile function, the SuspendProfile function is inserted before it. If the target function contains a StopProfile function, the ResumeProfile function is inserted after it.|
|**StartOnly:** `{` **Before** `&#124;` **After** `&#124;` **Top** `&#124;` **Bottom** `},funcname`|Begins data collection during a profiling run. It inserts the StartProfile API function at the specified location.<br /><br /> **Before** - immediately before the target function entry.<br /><br /> **After** - immediately after the target function exit.<br /><br /> **Top** - immediately after the target function entry.<br /><br /> **Bottom** - immediately before each return in the target function.<br /><br /> `funcname` - name of the target function.|
|**StopOnly:**{**Before**`&#124;`**After**`&#124;`**Top**`&#124;`**Bottom**}`,funcname`|Halts data collection during a profiling run. It inserts the StopProfile function at the specified location.<br /><br /> **Before** - immediately before the target function entry.<br /><br /> **After** - immediately after the target function exit.<br /><br /> **Top** - immediately after the target function entry.<br /><br /> **Bottom** - immediately before each return in the target function.<br /><br /> `funcname` - name of the target function.|
|**SuspendOnly:**{**Before**`&#124;`**After**`&#124;`**Top**`&#124;`**Bottom**}`,funcname`|Halts data collection during a profiling run. It inserts the SuspendProfile API at the specified location.<br /><br /> **Before** - immediately before the target function entry.<br /><br /> **After** - immediately after the target function exit.<br /><br /> **Top** - immediately after the target function entry.<br /><br /> **Bottom** - immediately before each return in the target function.<br /><br /> `funcname` - name of the target function.<br /><br /> If the target function contains a StartProfile function, the SuspendProfile function is inserted before it.|
|**ResumeOnly:**{**Before**`&#124;`**After**`&#124;`**Top**`&#124;`**Bottom**}`,funcname`|Begins or resumes data collection during a profiling run.<br /><br /> It is usually used to start profiling after a **SuspendOnly** option has stopped profiling. It inserts a ResumeProfile API at the specified location.<br /><br /> **Before** - immediately before the target function entry.<br /><br /> **After** - immediately after the target function exit.<br /><br /> **Top** - immediately after the target function entry.<br /><br /> **Bottom** - immediately before each return in the target function.<br /><br /> `funcname` - name of the target function.<br /><br /> If the target function contains a StopProfile function, the ResumeProfile function is inserted after it.|

## See also
- [VSPerfMon](../profiling/vsperfmon.md)
- [VSPerfCmd](../profiling/vsperfcmd.md)
- [VSPerfReport](../profiling/vsperfreport.md)
- [VSInstr warnings](../profiling/vsinstr-warnings.md)
- [Performance report views](../profiling/performance-report-views.md)
