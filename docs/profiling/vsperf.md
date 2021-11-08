---
title: VSPerf | Microsoft Docs
description: Learn how to use the VsPerf command line tool to profile UWP apps from the command line when Visual Studio is not installed on the device.
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: b5854e62-279e-4850-bfeb-0c6ef82f4805
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# VSPerf
Use the **VsPerf** command line tool to:

1. Profile UWP apps from the command line when Visual Studio is not installed on the device.

2. Profile Windows 8 desktop applications and Windows Server 2012 applications using the sampling profiling method.

   For more information about your profiling options, see [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).

## UWP apps only
 These options apply only to UWP apps.

|Option|Description|
|-|-|
|**/app:{AppName}**|Starts the profiler and waits for the specified app to be launched from the Start menu.<br /><br /> Run `vsperf /listapps` to view the app Name and PackageFullName of installed apps.|
|**/package:{PackageFullName}**|Starts the profiler and waits for the specified app to be launched from the Start menu.<br /><br /> Run `vsperf /listapps` to view the app Name and PackageFullName of installed apps.|
|**/js**|Required for profiling JavaScript apps.<br /><br /> Collect performance data from JavaScript apps.<br /><br /> Use only with /package or /attach.|
|**/noclr**|Optional. Do not collect CLR data.<br /><br /> Use only with /package or /attach.<br /><br /> Optimization, no managed symbols will resolve.|
|**/listapps**|List installed app Names and PackageFullNames.|

## Windows 8 desktop applications and Windows Server 2012 applications only
 These options do not work on UWP apps.

|Option|Description|
|-|-|
|**/launch:{Executable}**|Starts and begins profiling the specified executable file.|
|**/args:{ExecutableArguments}**|Specifies command line arguments to pass the **/launch** target.|
|**/console**|Runs the **/launch** target in a new command window.|

## All applications
 These option apply to any Windows 8 or Windows Server 2012 application.

|Option|Description|
|-|-|
|**/attach:{PID&#124;ProcessName}[,PID&#124;ProcessName]...**|Collects data from the specified processes.<br /><br /> Use Task Manager to view the process id (PID) and process names of running apps.|
|**/file:{ReportName}**|Optional. Specifies output file (overwrites existing file).<br /><br /> Use only with /package or /attach.|
|**/pause**|Pause data collection.|
|**/resume**|Resume data collection.|
|**/stop**|Stop data collection and terminate target processes.|
|**/detach**|Stop data collection, but let target processes continue to run.|
|**/status**|Show profiler status.|

## See also
- [Performance tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md)
- [Profile from the command-line](../profiling/using-the-profiling-tools-from-the-command-line.md)
