---
title: "VSPerf | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: b5854e62-279e-4850-bfeb-0c6ef82f4805
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# VSPerf
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Use the **VsPerf** command line tool to:  
  
1. Profile Windows Store apps from the command line when Visual Studio is not installed on the device.  
  
2. Profile Windows 8 desktop applications and Windows Server 2012 applications using the sampling profiling method.  
  
   For more information about your profiling options, see [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  
  
## <a name="BKMK_In_this_topic"></a> In this topic  
 This topic describes the options that you can use with the `vsperf.exe` command line tool. The topic contains the following sections:  
  
 [Windows Store apps only](#BKMK_windows_store_apps_only)  
  
 [Windows 8 desktop applications and Windows Server 2012 applications only](#BKMK_Windows_8_classic_applications_and_Windows_Server_2012_applications_only)  
  
 [All applications](#BKMK_All_applications)  
  
## <a name="BKMK_windows_store_apps_only"></a> Windows Store apps only  
 These options apply only to Windows Store apps.  
  
|||  
|-|-|  
|**/app:{AppName}**|Starts the profiler and waits for the specified app to be launched from the Start menu.<br /><br /> Run `vsperf /listapps` to view the app Name and PackageFullName of installed apps.|  
|**/package:{PackageFullName}**|Starts the profiler and waits for the specified app to be launched from the Start menu.<br /><br /> Run `vsperf /listapps` to view the app Name and PackageFullName of installed apps.|  
|**/js**|Required for profiling JavaScript apps.<br /><br /> Collect performance data from JavaScript apps.<br /><br /> Use only with /package or /attach.|  
|**/noclr**|Optional. Do not collect CLR data.<br /><br /> Use only with /package or /attach.<br /><br /> Optimization, no managed symbols will resolve.|  
|**/listapps**|List installed app Names and PackageFullNames.|  
  
## <a name="BKMK_Windows_8_classic_applications_and_Windows_Server_2012_applications_only"></a> Windows 8 desktop applications and Windows Server 2012 applications only  
 These options do not work on Windows Store apps.  
  
|||  
|-|-|  
|**/launch:{Executable}**|Starts and begins profiling the specified executable file.|  
|**/args:{ExecutableArguments}**|Specifies command line arguments to pass the **/launch** target.|  
|**/console**|Runs the **/launch** target in a new command window.|  
  
## <a name="BKMK_All_applications"></a> All applications  
 These option apply to any Windows 8 or Windows Server 2012 application.  
  
|||  
|-|-|  
|**/attach:{PID&#124;ProcessName}[,PID&#124;ProcessName]...**|Collects data from the specified processes.<br /><br /> Use Task Manager to view the process id (PID) and process names of running apps.|  
|**/file:{ReportName}**|Optional. Specifies output file (overwrites existing file).<br /><br /> Use only with /package or /attach.|  
|**/pause**|Pause data collection.|  
|**/resume**|Resume data collection.|  
|**/stop**|Stop data collection and terminate target processes.|  
|**/detach**|Stop data collection, but let target processes continue to run.|  
|**/status**|Show profiler status.|  
  
## See Also  
 [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md)   
 [Profiling from the Command-Line](../profiling/using-the-profiling-tools-from-the-command-line.md)
