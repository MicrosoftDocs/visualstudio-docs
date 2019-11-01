---
title: "Using the Profiling Tools From the Command-Line | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "command line, performance tools"
  - "command-line tools, performance tools"
  - "profiling tools,command line"
  - "tools, command-line"
  - "command line, tools"
ms.assetid: 6593fa82-181e-4009-a0ed-02aa24c2c063
caps.latest.revision: 40
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Using the Profiling Tools From the Command-Line
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use the command-line tools of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Profiling Tools to profile applications at the command prompt and to automate profiling by using batch files and scripting. You can also generate report files at a command prompt. You can use the lightweight stand-alone profiler to collect data on computers that do not have [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] installed.  
  
> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  
  
## Common Tasks  
  
|Task|Related Content|  
|----------|---------------------|  
|**Set the location of symbols:** To display the names of functions and parameters, the profiler must have access to the symbol (.pdb) files of the profiled binaries. These files should include the symbol files for the Microsoft operating system and applications that you want to view in your analysis. You can use the public Microsoft symbol server to make sure that you have the correct .pdb files for the Microsoft binaries.|-   [How to: Specify Symbol File Locations from the Command Line](../profiling/how-to-specify-symbol-file-locations-from-the-command-line.md)|  
|**Profile your application:** The command-line tools and options that you use to profile a target application depend on the type of the application, the profiling method, and whether the target is a managed or native application.|-   [Using Profiling Methods From the Command Line](../profiling/using-profiling-methods-to-collect-performance-data-from-the-command-line.md)<br />-   [Profiling Stand-Alone Applications](../profiling/command-line-profiling-of-stand-alone-applications.md)<br />-   [Profiling ASP.NET Web Applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)<br />-   [Profiling Services](../profiling/command-line-profiling-of-services.md)|  
|**Create .xml and .csv reports:** Profiling at the command prompt creates data files that can be viewed in the interface for [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. You can also generate .xml or comma-separated value (.csv) files of the data by using the VSPerfReport command-line tool.|-   [Creating Profiler Reports from the Command Line](../profiling/creating-profiler-reports-from-the-command-line.md)<br />-   [VSPerfReport](../profiling/vsperfreport.md)|  
|**Profile code on computers without Visual Studio:** You can use the Profiling Tools stand-alone profiler to collect data for applications on computers that do not have [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] installed.|-   [How to: Install the Stand-Alone Profiler](../profiling/how-to-install-the-stand-alone-profiler.md)|  
  
## Reference  
 [Command-Line Profiling Tools Reference](../profiling/command-line-profiling-tools-reference.md)  
  
## See Also  
 [Performance Explorer](../profiling/performance-explorer.md)
