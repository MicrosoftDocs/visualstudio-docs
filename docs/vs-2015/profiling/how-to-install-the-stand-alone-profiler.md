---
title: "How to: Install the Stand-Alone Profiler | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "performance tools, installing stand-alone profiler"
  - "profiling tools, stand-alone profiler"
ms.assetid: cae81c95-83cd-4ab6-8a98-84ef977a2f6d
caps.latest.revision: 29
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Install the Stand-Alone Profiler
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

[!INCLUDE[vsprvs](../includes/vsprvs-md.md)] provides a command line based stand-alone profiler that can be run without installing the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] IDE. This situation occurs when a computer does not or cannot have a development environment installed. For example, you should not install a development environment on a production Web server.  
  
> [!NOTE]
> When you are using the stand-alone profiler to collect performance data for ASP.NET Web site, the [VSPerfASPNetCmd](../profiling/vsperfaspnetcmd.md) line tool is recommended over [VSPerfCmd](../profiling/vsperfcmd.md) tool.  
  
### To install the stand-alone profiler  
  
1. Locate the stand-alone profile installer (vs_profiler.exe) on the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] installation media in the directory that includes the \Standalone Profiler path and run it.  
  
2. Add the paths for vsintr.exe and msdis150.dll to the system path.  
  
    > [!NOTE]
    > In the default installation of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], vsinstr.exe and msdis150.dll are located in \Program Files\Visual Studio 10\Team Tools\Performance Tools.  
  
3. At the command prompt, type **VSInstr**.  
  
    > [!NOTE]
    > If the usage information for vsinstr.exe is displayed, everything is set up correctly. If you see an error that states vsinstr.exe or one of its dependencies is not found, make sure that you have your paths set up correctly as described in step 2.  
  
4. Set up symbol server by setting your **_NT_SYMBOL_PATH** variable to **symsrv\*symsrv.dll\*c:\localcache\*http://msdl.microsoft.com/download/symbols**  
  
5. After you set up your symbol server by using the system environment variables, run the command line profiler tools at a new command prompt. This allows the new environment variables to take effect. In the command prompt window, type the following command:  
  
     **start %COMSPEC%**  
  
    > [!NOTE]
    > For detailed instructions about how to set up the symbol server package, see [How to: Reference Windows Symbol Information](../profiling/how-to-reference-windows-symbol-information.md).  
  
6. Use the [VSPerfReport](../profiling/vsperfreport.md) tool to serialize your symbols into the profiling data (.vsp) file. Use the **VSPerfReport /summary:all /packsymbols** switches. If you do not have symbols inserted in your data file, make sure that you have the _NT_SYMBOL_PATH environment variable set.  
  
## See Also  
 [Profiling from the Command-Line](../profiling/using-the-profiling-tools-from-the-command-line.md)   
 [Walkthrough: Command-Line Profiling Using Sampling](../profiling/walkthrough-command-line-profiling-using-sampling.md)   
 [Walkthrough: Command-Line Profiling Using Instrumentation](../profiling/walkthrough-command-line-profiling-using-instrumentation.md)   
 [How to: Reference Windows Symbol Information](../profiling/how-to-reference-windows-symbol-information.md)   
 [VSPerfReport](../profiling/vsperfreport.md)
