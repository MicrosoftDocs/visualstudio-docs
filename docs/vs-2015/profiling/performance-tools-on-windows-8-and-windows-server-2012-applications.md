---
title: "Performance Tools on Windows 8 and Windows Server 2012 applications | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: a704215d-d252-4087-921b-ac81ebe2a9c9
caps.latest.revision: 20
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Performance Tools on Windows 8 and Windows Server 2012 applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way Visual Studio performance tools collect data on these platforms. Windows Store apps also require new collection techniques. This topic describes the changes for performance tools on Windows 8 and Windows Server 2012 platforms.  
  
> [!NOTE]
> Performance tools for other supported versions of Windows (Windows 7, Windows Server 2008 R2) have not changed.  
  
## <a name="BKMK_In_this_topic"></a> In this topic  
 [Collecting data on Windows Store apps from the Visual Studio IDE](#BKMK_Profiling_Windows_Store_apps_from_the_Visual_Studio_IDE)  
  
 [Collecting data on apps running on the Windows 8 desktop or on Windows Server 2012 from the Visual Studio IDE](#BKMK_Profiling_apps_running_on_the_Windows_8_desktop_or_on_Windows_Server_2012_from_the_Visual_Studio_IDE)  
  
- [Collecting data on apps running on the Windows 8 desktop or on Windows Server 2012 by using sampling from the Visual Studio IDE](#BKMK_Profiling_apps_running_on_the_Windows_8_desktop_or_on_Windows_Server_2012_by_using_sampling_from_the_Visual_Studio_IDE)  
  
  [Profiling from the command line](#BKMK_Profiling_from_the_command_line)  
  
  [Collecting tier interaction (TIP) data](#BKMK_Collecting_tier_interaction__TIP__data)  
  
## <a name="BKMK_Profiling_Windows_Store_apps_from_the_Visual_Studio_IDE"></a> Collecting data on Windows Store apps from the Visual Studio IDE  
 When you profile a Windows Store app that is written in JavaScript and HTML 5, you collect instrumentation data for the JavaScript code. When you profile a Windows Store app or component that is written in Visual C++, Visual C#, or Visual Basic, you collect sampling data for the native and managed code. You can profile your app locally or on a remote machine.  
  
 These profiling features and options are not supported when profiling Windows Store apps:  
  
- Profiling JavaScript apps using the sampling method.  
  
- Profiling managed and native code using the instrumentation method.  
  
- Concurrency profiling  
  
- .NET memory profiling  
  
- Tier interaction profiling (TIP)  
  
- Sampling options, such as setting the sampling event and timing interval, or collecting additional performance counter data.  
  
- Instrumentation options, such as collecting performance and windows counter data, or specifying additional command-line options.  
  
  For more information about profiling Windows Store apps, see the following topics in the Windows Dev Center:  
  
  [Run Windows Store apps on the local machine](../debugger/run-windows-store-apps-on-the-local-machine.md)  
  
  [Run Windows Store apps on a remote machine](../debugger/run-windows-store-apps-on-a-remote-machine.md)  
  
  [Analyze app performance](https://msdn.microsoft.com/library/58acb30b-8428-41a6-b195-b0fdedb89575)  
  
- [JavaScript Function Timing](https://msdn.microsoft.com/library/b2bf49fc-aea7-4d9c-8fcf-cff8b8dd0c03)  
  
- [JavaScript Function Timing on a Remote Device](https://msdn.microsoft.com/library/d78812b6-a97e-46dc-8d99-e724d1d725d8)  
  
- [Analyze JavaScript Function Timing data](https://msdn.microsoft.com/library/b5aea8d8-36df-47ba-a7ca-95406700ca9b)  
  
- [Profile Visual C++, Visual C#, and Visual Basic code in Windows Store apps on a local machine](https://msdn.microsoft.com/2d0c939e-0bac-48c5-b727-46f6c6113060)  
  
- [Profile Visual C++, Visual C#, and Visual Basic code in Windows Store apps on a remote device](https://msdn.microsoft.com/b932a2be-11b0-40fd-b996-75c6b6a79d22)  
  
- [Analyze performance data for Visual C++, Visual C#, and Visual Basic code in Windows Store apps](https://msdn.microsoft.com/5de4a413-d924-425f-afc4-e1ecfb0fca18)  
  
  [In this topic](#BKMK_In_this_topic)  
  
## <a name="BKMK_Profiling_apps_running_on_the_Windows_8_desktop_or_on_Windows_Server_2012_from_the_Visual_Studio_IDE"></a> Collecting data on apps running on the Windows 8 desktop or on Windows Server 2012 from the Visual Studio IDE  
 Profiling using the instrumentation method has not changed for Windows 8.  
  
 Tier interaction profiling (TIP) is not supported using the sampling method.  
  
### <a name="BKMK_Profiling_apps_running_on_the_Windows_8_desktop_or_on_Windows_Server_2012_by_using_sampling_from_the_Visual_Studio_IDE"></a> Collecting data on apps running on the Windows 8 desktop or on Windows Server 2012 by using sampling from the Visual Studio IDE  
 These profiling features and options are not supported when profiling Windows 8 desktop applications or Windows Server 2012 applications using the sampling method:  
  
- Tier interaction profiling (TIP). Collecting TIP data is supported using instrumentation.  
  
- Sampling options such as setting the sampling event and timing interval, or collecting additional performance counter data.  
  
## <a name="BKMK_Profiling_from_the_command_line"></a> Profiling from the command line  
 You use two command line tools to collect profiling data on Windows 8 and Windows Server 2012 devices, including devices that do not have an installation of Visual Studio:  
  
|Tool name|Description|  
|---------------|-----------------|  
|[VSPerf](../profiling/vsperf.md)|Collects profiling data from Windows Store apps and collects sample profiling data from Windows 8 desktop applications and Windows Server 2012 applications..|  
|[VSPerfCmd](../profiling/vsperfcmd.md)|Collects instrumentation, concurrency, and tier interaction profiling data from apps that are running on theWindows 8 desktop or Windows Server 2012. Collects all types of profiling data from previous versions of Windows.|  
  
 Both tools are installed with Visual Studio for use on the local computer.  
  
 To profile applications on devices that do not have Visual Studio installed, do one of the following:  
  
- Download the tools as part of the Remote Tools for Visual Studio from the [MSDN web site](https://go.microsoft.com/fwlink/?LinkID=219549).  
  
- Copy and run the stand-alone profiler tools installation program from your Visual Studio computer. The installation programs are in *%VSInstallDir%* **\Team Tools\Performance Tools\Setups** folder. Choose the setup program for the operating system (x86/x64) of the remote computer.  
  
> [!NOTE]
> To collect TIP profiling data, you must install the stand-alone profiler from your Visual Studio machine on the remote computer.  
  
 These profiling features and options are not supported when profiling Windows 8 and Windows Server 2012 applications from the command line:  
  
- Collecting data from Windows 8 and Windows Server 2012 web apps by using sampling mode with [VSPerfASPNetCmd](../profiling/vsperfaspnetcmd.md).  
  
- Collecting sampling data by using VsPerfCmd.exe.  
  
- Sampling options such as setting the sampling event and timing interval, or collecting additional performance counter data.  
  
## <a name="BKMK_Collecting_tier_interaction__TIP__data"></a> Collecting tier interaction (TIP) data  
 Tier interaction profiling provides additional information about the execution times of functions of multi-tiered applications that communicate with databases through ADO.NET services. Data is collected only for synchronous function calls.  
  
 **Visual Studio editions**  
  
 Tier interaction profiling data can be collected using [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)], [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)], or [!INCLUDE[vs_pro_current_short](../includes/vs-pro-current-short-md.md)]. However, tier interaction profiling data can be viewed only in [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)] and [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)].  
  
 **Windows 8 and Windows Server 2012**  
  
1. To collect tier interaction data from apps that are running on the Windows 8 desktop or Windows Server 2012, you must use the instrumentation method.  
  
2. You cannot collect tier interaction data for Windows Store apps.  
  
3. You can include tier interaction data in all profiling methods on other supported version of Windows.  
  
   **Performance Wizard and Performance Explorer**  
  
   You must add the tier interaction data collection option to a profiling run from the Performance Explorer. You must also add the project, executable, or website to the Target node of Performance Explorer. See [Collecting tier interaction data](../profiling/collecting-tier-interaction-data.md).  
  
   **Collecting TIP data on a remote machine**  
  
   To collect tier interaction data on a remote machine, you must copy the **vs\_profiler\_**_\<Platform>_**\_**_\<Language>_**.exe** file from the _%VSInstallDir%_**\Team Tools\Performance Tools\Setups** folder of a Visual Studio machine to the remote computer and install it. You cannot use the profiling tools in the [Visual Studio Remote Tools](https://msdn.microsoft.com/library/90f45630-0d26-4698-8c1f-63f85a12db9c) download package.  
  
   You can use [VSPerfCmd](../profiling/vsperfcmd.md) or [VSPerfASPNetCmd](../profiling/vsperfaspnetcmd.md) to collect the profiling data.  
  
   **TIP reports**  
  
   Tier interaction data can only be viewed in the [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)] or [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)] IDE. File based tier interaction reports through [VSPerfReport](../profiling/vsperfreport.md) are not available.  
  
## See Also  
 [Performance Explorer](../profiling/performance-explorer.md)   
 [Configuring Performance Sessions](../profiling/configuring-performance-sessions.md)   
 [Profiling from the Command-Line](../profiling/using-the-profiling-tools-from-the-command-line.md)
