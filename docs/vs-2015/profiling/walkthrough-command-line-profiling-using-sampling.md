---
title: "Walkthrough: Command-Line Profiling Using Sampling | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "profiling tools, walkthroughs"
  - "performance tools, walkthroughs"
  - "performance tools, command-line tools"
ms.assetid: 1d53972f-6f35-4842-8c74-1b627f18c70a
caps.latest.revision: 26
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Walkthrough: Command-Line Profiling Using Sampling
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This walkthrough demonstrates how to profile an application by using command-line tools and sampling to identify performance problems.  
  
 In this walkthrough, you will step through the process of profiling a managed application by using command-line tools, and use sampling to isolate and identify performance problems in the application.  
  
 In this walkthrough, you will follow these steps:  
  
- Profile an application by using command line tools and sampling.  
  
- Analyze sampled profiling results to locate and fix performance issues.  
  
## Prerequisites  
  
- [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)], [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)], or [!INCLUDE[vsPro](../includes/vspro-md.md)]  
  
- Intermediate understanding of [!INCLUDE[csharp_current_short](../includes/csharp-current-short-md.md)]  
  
- Intermediate understanding of working with command line tools  
  
- A copy of the [PeopleTrax Sample](../profiling/peopletrax-sample-profiling-tools.md)  
  
- To work with the information provided by profiling, it is best to have debugging symbol information available.  
  
## Command Line Profiling Using the Sampling Method  
 Sampling is a profiling method by which a specific process is periodically polled to determine the active function. The resulting data provides a count of how frequently the function was on top of the call stack when the process was sampled.  
  
> [!NOTE]
> Command-line tools of the Profiling Tools are located in the \Team Tools\Performance Tools subdirectory of the Visual Studio installation directory. On 64 bit computers, both 64 bit and 32 bit versions of the tools are available. To use the profiler command-line tools, you must add the path to the PATH environment variable of the command prompt window or add it to the command itself. For more information, see [Specifying the Path to Command Line Tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). PeopleTrax is a 32-bit application.  
  
#### To profile the PeopleTrax application by using the sampling method  
  
1. Install the PeopleTrax sample application and build the release version of the application.  
  
2. Open a command prompt window and add the Profiling Tools directory to the local Path environment variable.  
  
3. Change the working directory to the directory that contain the PeopleTrax binaries.  
  
4. Type the following command to set the appropriate environment variables:  
  
    ```  
    VSPerfCLREnv /sampleon  
    ```  
  
5. Start profiling by running VSPerfCmd.exe, which is the command-line tool that controls the profiler. The following command starts the application and profiler in the sampling mode:  
  
    ```  
    VsPerfCmd /start:sample /output:PeopleTraxReport.vsp /launch:PeopleTrax.exe  
    ```  
  
     The profiler process starts and attaches to the PeopleTrax.exe process. The profiler process starts to write the collected profiling data to the report file.  
  
6. Click **Get People**.  
  
7. Click **ExportData**.  
  
     Notepad opens and displays a new file that contains the exported data from **PeopleTrax**.  
  
8. Close Notepad, and then close the **PeopleTrax** application.  
  
9. Shut down the profiler. Type the following command:  
  
    ```  
    VSPerfCmd /shutdown  
    ```  
  
10. Use the following command to reset the environmental variables:  
  
    ```  
    VSPerfCLREnv /sampleoff  
    ```  
  
11. Profiling data is stored in the.vsp file Analyze the results by using one of the following methods:  
  
    - Open the.vsp file in the Visual Studio IDE.  
  
         — or —  
  
    - Generate a comma-separated value (.csv) file by using the command-line tool VSPerfReport.exe. To generate reports for use outside the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] IDE use the following command:  
  
        ```  
        VSPerfReport <dir> PeopleTraxReport.vsp /output:<dir> /summary:all  
        ```  
  
## See Also  
 [Performance Session Overview](../profiling/performance-session-overview.md)   
 [Profiling from the Command-Line](../profiling/using-the-profiling-tools-from-the-command-line.md)   
 [VSPerfCmd](../profiling/vsperfcmd.md)   
 [Understanding Sampling Data Values](../profiling/understanding-sampling-data-values.md)   
 [Performance Report Views](../profiling/performance-report-views.md)
