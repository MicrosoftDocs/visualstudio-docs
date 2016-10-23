---
title: "How to: Install the Stand-Alone Profiler"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: cae81c95-83cd-4ab6-8a98-84ef977a2f6d
caps.latest.revision: 24
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
# How to: Install the Stand-Alone Profiler
Visual Studio provides a command line based stand-alone profiler that can be run without installing the Visual Studio IDE. This situation occurs when a computer does not or cannot have a development environment installed. For example, you should not install a development environment on a production Web server.  
  
> [!NOTE]
>  When you are using the stand-alone profiler to collect performance data for ASP.NET Web site, the [VSPerfASPNetCmd](../VS_IDE/VSPerfASPNetCmd.md) line tool is recommended over [VSPerfCmd](../VS_IDE/VSPerfCmd.md) tool.  
  
### To install the stand-alone profiler  
  
1.  Locate the stand-alone profile installer (vs_profiler.exe) on the Visual Studio installation media in the directory that includes the \Standalone Profiler path and run it.  
  
2.  Add the paths for vsintr.exe and msdis150.dll to the system path.  
  
    > [!NOTE]
    >  In the default installation of Visual Studio, vsinstr.exe and msdis150.dll are located in \Program Files\Visual Studio 10\Team Tools\Performance Tools.  
  
3.  At the command prompt, type **VSInstr**.  
  
    > [!NOTE]
    >  If the usage information for vsinstr.exe is displayed, everything is set up correctly. If you see an error that states vsinstr.exe or one of its dependencies is not found, make sure that you have your paths set up correctly as described in step 2.  
  
4.  Set up symbol server by setting your **_NT_SYMBOL_PATH** variable to **symsrv\*symsrv.dll\*c:\localcache\*http://msdl.microsoft.com/download/symbols**  
  
5.  After you set up your symbol server by using the system environment variables, run the command line profiler tools at a new command prompt. This allows the new environment variables to take effect. In the command prompt window, type the following command:  
  
     **start %COMSPEC%**  
  
    > [!NOTE]
    >  For detailed instructions about how to set up the symbol server package, see [How to: Reference Windows Symbol Information](../VS_IDE/How-to--Reference-Windows-Symbol-Information.md).  
  
6.  Use the [VSPerfReport](../VS_IDE/VSPerfReport.md) tool to serialize your symbols into the profiling data (.vsp) file. Use the **VSPerfReport /summary:all /packsymbols** switches. If you do not have symbols inserted in your data file, make sure that you have the _NT_SYMBOL_PATH environment variable set.  
  
## See Also  
 [Profiling from the Command-Line](../VS_IDE/Using-the-Profiling-Tools-From-the-Command-Line.md)   
 [Walkthrough: Command-Line Profiling Using Sampling](../VS_IDE/Walkthrough--Command-Line-Profiling-Using-Sampling.md)   
 [Walkthrough: Command-Line Profiling Using Instrumentation](../VS_IDE/Walkthrough--Command-Line-Profiling-Using-Instrumentation.md)   
 [How to: Reference Windows Symbol Information](../VS_IDE/How-to--Reference-Windows-Symbol-Information.md)   
 [VSPerfReport](../VS_IDE/VSPerfReport.md)