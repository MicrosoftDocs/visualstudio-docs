---
title: "Using the Profiling Tools From the Command-Line"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6593fa82-181e-4009-a0ed-02aa24c2c063
caps.latest.revision: 35
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Using the Profiling Tools From the Command-Line
You can use the command-line tools of Visual Studio Profiling Tools to profile applications at the command prompt and to automate profiling by using batch files and scripting. You can also generate report files at a command prompt. You can use the lightweight stand-alone profiler to collect data on computers that do not have Visual Studio installed.  
  
> [!NOTE]
>  Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../VS_IDE/Performance-Tools-on-Windows-8-and-Windows-Server-2012-applications.md).  
  
## Common Tasks  
  
|Task|Related Content|  
|----------|---------------------|  
|**Set the location of symbols:** To display the names of functions and parameters, the profiler must have access to the symbol (.pdb) files of the profiled binaries. These files should include the symbol files for the Microsoft operating system and applications that you want to view in your analysis. You can use the public Microsoft symbol server to make sure that you have the correct .pdb files for the Microsoft binaries.|-   [How to: Specify Symbol File Locations from the Command Line](../VS_IDE/How-to--Specify-Symbol-File-Locations-from-the-Command-Line.md)|  
|**Profile your application:** The command-line tools and options that you use to profile a target application depend on the type of the application, the profiling method, and whether the target is a managed or native application.|-   [Using Profiling Methods From the Command Line](../VS_IDE/Using-Profiling-Methods-to-Collect-Performance-Data-from-the-Command-Line.md)<br />-   [Profiling Stand-Alone Applications](../VS_IDE/Command-Line-Profiling-of-Stand-Alone-Applications.md)<br />-   [Profiling ASP.NET Web Applications](../VS_IDE/Command-Line-Profiling-of-ASP.NET-Web-Applications.md)<br />-   [Profiling Services](../VS_IDE/Command-Line-Profiling-of-Services.md)|  
|**Create .xml and .csv reports:** Profiling at the command prompt creates data files that can be viewed in the interface for Visual Studio. You can also generate .xml or comma-separated value (.csv) files of the data by using the VSPerfReport command-line tool.|-   [Creating Profiler Reports from the Command Line](../VS_IDE/Creating-Profiler-Reports-from-the-Command-Line.md)<br />-   [VSPerfReport](../VS_IDE/VSPerfReport.md)|  
|**Profile code on computers without Visual Studio:** You can use the Profiling Tools stand-alone profiler to collect data for applications on computers that do not have Visual Studio installed.|-   [How to: Install the Stand-Alone Profiler](../VS_IDE/How-to--Install-the-Stand-Alone-Profiler.md)|  
  
## Reference  
 [Command-Line Profiling Tools Reference](../VS_IDE/Command-Line-Profiling-Tools-Reference.md)  
  
## See Also  
 [Performance Explorer](../VS_IDE/Performance-Explorer.md)