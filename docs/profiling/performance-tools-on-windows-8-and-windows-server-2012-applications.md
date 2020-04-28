---
title: "Performance tools on Windows 8 & Windows Server 2012 apps"
ms.date: "06/19/2017"
ms.topic: "conceptual"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Performance tools on Windows 8 and Windows Server 2012 applications

Enhanced security features starting in Windows 8 and Windows Server 2012 required significant changes in the way Visual Studio performance tools collect data on these platforms. UWP apps also require new collection techniques. This topic describes the changes for performance tools starting on Windows 8 and Windows Server 2012 platforms.

> [!NOTE]
> Performance tools for other supported versions of Windows (Windows 7, Windows Server 2008 R2) have not changed.

## Collect data on UWP apps from the Visual Studio IDE

When you profile a UWP app that is written in JavaScript and HTML 5, you collect instrumentation data for the JavaScript code. When you profile a UWP app or component that is written in Visual C++, Visual C#, or Visual Basic, you collect sampling data for the native and managed code. You can profile your app locally or on a remote machine.

These profiling features and options are not supported when profiling UWP apps:

- Profiling JavaScript apps using the sampling method.
- Profiling managed and native code using the instrumentation method.
- Concurrency profiling
- .NET memory profiling
- Tier interaction profiling (TIP)
- Sampling options, such as setting the sampling event and timing interval, or collecting additional performance counter data.
- Instrumentation options, such as collecting performance and windows counter data, or specifying additional command-line options.

For more information about profiling UWP apps, see the following articles:

- [Run UWP apps on the local machine](../debugger/start-a-debugging-session-for-a-store-app-in-visual-studio-vb-csharp-cpp-and-xaml.md)
- [Run UWP apps on a remote machine](../debugger/run-windows-store-apps-on-a-remote-machine.md)
- [First look at profiling tools](profiling-feature-tour.md)
- [JavaScript memory](../profiling/javascript-memory.md)
- [Profile Visual C++, Visual C#, and Visual Basic code in UWP apps on a local machine](https://msdn.microsoft.com/2d0c939e-0bac-48c5-b727-46f6c6113060)
- [Profile Visual C++, Visual C#, and Visual Basic code in UWP apps on a remote device](https://msdn.microsoft.com/b932a2be-11b0-40fd-b996-75c6b6a79d22)
- [Analyze performance data for Visual C++, Visual C#, and Visual Basic code in UWP apps](https://msdn.microsoft.com/5de4a413-d924-425f-afc4-e1ecfb0fca18)

## Collect data on apps running on the Windows 8 desktop or on Windows Server 2012 from the Visual Studio IDE

Profiling using the instrumentation method has not changed for Windows 8.

Tier interaction profiling (TIP) is not supported using the sampling method.

## Collect data on apps running on the Windows 8 desktop or on Windows Server 2012 by using sampling from the Visual Studio IDE

These profiling features and options are not supported when profiling Windows 8 desktop applications or Windows Server 2012 applications using the sampling method:

- Tier interaction profiling (TIP). Collecting TIP data is supported using instrumentation.

- Sampling options such as setting the sampling event and timing interval, or collecting additional performance counter data.

## Profile from the command line

You use two command line tools to collect profiling data on Windows 8 and Windows Server 2012 devices, including devices that do not have an installation of Visual Studio:

|Tool name|Description|
|---------------|-----------------|
|[VSPerf](../profiling/vsperf.md)|Collects profiling data from UWP apps and collects sample profiling data from Windows 8 desktop applications and Windows Server 2012 applications..|
|[VSPerfCmd](../profiling/vsperfcmd.md)|Collects instrumentation, concurrency, and tier interaction profiling data from apps that are running on theWindows 8 desktop or Windows Server 2012. Collects all types of profiling data from previous versions of Windows.|

Both tools are installed with Visual Studio for use on the local computer.

To profile applications on devices that do not have Visual Studio installed, do one of the following:

- Download the tools as part of the Remote Tools for Visual Studio from the [MSDN web site](https://visualstudio.microsoft.com/#downloads+d-additional-software).

- Copy and run the stand-alone profiler tools installation program from your Visual Studio computer. To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). Choose the setup program for the operating system (x86/x64) of the remote computer.

> [!NOTE]
> To collect TIP profiling data, you must install the stand-alone profiler from your Visual Studio machine on the remote computer.

These profiling features and options are not supported when profiling Windows 8 and Windows Server 2012 applications from the command line:

- Collecting data from Windows 8 and Windows Server 2012 web apps by using sampling mode with [VSPerfASPNetCmd](../profiling/vsperfaspnetcmd.md).

- Collecting sampling data by using VsPerfCmd.exe.

- Sampling options such as setting the sampling event and timing interval, or collecting additional performance counter data.

## Collect tier interaction (TIP) data

Tier interaction profiling provides additional information about the execution times of functions of multi-tiered applications that communicate with databases through ADO.NET services. Data is collected only for synchronous function calls.

**Visual Studio editions**

Tier interaction profiling data can be collected using any edition of Visual Studio. However, tier interaction profiling data can be viewed only in Visual Studio Enterprise.

**Windows 8 and Windows Server 2012**

1. To collect tier interaction data from apps that are running on the Windows 8 desktop or Windows Server 2012, you must use the instrumentation method.

2. You cannot collect tier interaction data for UWP apps.

3. You can include tier interaction data in all profiling methods on other supported version of Windows.

**Performance Wizard and Performance Explorer**

You must add the tier interaction data collection option to a profiling run from the Performance Explorer. You must also add the project, executable, or website to the Target node of Performance Explorer. See [Collect tier interaction data](../profiling/collecting-tier-interaction-data.md).

**Collecting TIP data on a remote machine**

To collect tier interaction data on a remote machine, you must copy the **vs\_profiler\_**_\<Platform>_**\_**_\<Language>_**.exe** file from the *%VSInstallDir%\Team Tools\Performance Tools\Setups* folder of a Visual Studio machine to the remote computer and install it. You cannot use the profiling tools in the [Remote Debugging](../debugger/remote-debugging.md) download package.

You can use [VSPerfCmd](../profiling/vsperfcmd.md) or [VSPerfASPNetCmd](../profiling/vsperfaspnetcmd.md) to collect the profiling data.

**TIP reports**

Tier interaction data can only be viewed in Visual Studio Enterprise. File based tier interaction reports through [VSPerfReport](../profiling/vsperfreport.md) are not available.

## See also

[Performance Explorer](../profiling/performance-explorer.md)
[Configure performance sessions](../profiling/configuring-performance-sessions.md)
[Profile from the command line](../profiling/using-the-profiling-tools-from-the-command-line.md)
