---
title: "Walkthrough: Command-Line Profiling Using Sampling | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "profiling tools, walkthroughs"
  - "performance tools, walkthroughs"
  - "performance tools, command-line tools"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Walkthrough: Command-line profiling using sampling

This walkthrough demonstrates how to profile an application by using command-line tools and sampling to identify performance problems.

In this walkthrough, you will step through the process of profiling a managed application by using command-line tools, and use sampling to isolate and identify performance problems in the application.

In this walkthrough, you will follow these steps:

- Profile an application by using command line tools and sampling.
- Analyze sampled profiling results to locate and fix performance issues.

## Prerequisites

- Intermediate understanding of [!INCLUDE[csharp_current_short](../misc/includes/csharp_current_short_md.md)]
- Intermediate understanding of working with command line tools
- A copy of the [PeopleTrax Sample](performance-explorer.md)
- To work with the information provided by profiling, it is best to have debugging symbol information available.

## Command-line profiling using the sampling method

Sampling is a profiling method by which a specific process is periodically polled to determine the active function. The resulting data provides a count of how frequently the function was on top of the call stack when the process was sampled.

> [!NOTE]
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.

### To profile the PeopleTrax application by using the sampling method

1. Install the PeopleTrax sample application and build the release version of the application.

2. Open a command prompt window and add the Profiling Tools directory to the local Path environment variable.

3. Change the working directory to the directory that contain the PeopleTrax binaries.

4. Type the following command to set the appropriate environment variables:

    ```cmd
    VSPerfCLREnv /sampleon
    ```

5. Start profiling by running *VSPerfCmd.exe*, which is the command-line tool that controls the profiler. The following command starts the application and profiler in the sampling mode:

    ```cmd
    VsPerfCmd /start:sample /output:PeopleTraxReport.vsp /launch:PeopleTrax.exe
    ```

     The profiler process starts and attaches to the *PeopleTrax.exe* process. The profiler process starts to write the collected profiling data to the report file.

6. Click **Get People**.

7. Click **ExportData**.

     Notepad opens and displays a new file that contains the exported data from **PeopleTrax**.

8. Close Notepad, and then close the **PeopleTrax** application.

9. Shut down the profiler. Type the following command:

    ```cmd
    VSPerfCmd /shutdown
    ```

10. Use the following command to reset the environmental variables:

    ```cmd
    VSPerfCLREnv /sampleoff
    ```

11. Profiling data is stored in the .*vsp* file Analyze the results by using one of the following methods:

    - Open the .*vsp* file in the Visual Studio IDE.

         — or —

    - Generate a comma-separated value (.*csv*) file by using the command-line tool *VSPerfReport.exe*. To generate reports for use outside the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] IDE use the following command:

        ```cmd
        VSPerfReport <dir> PeopleTraxReport.vsp /output:<dir> /summary:all
        ```

## See also

[Performance session overview](../profiling/performance-session-overview.md)
[Profile from the command-line](../profiling/using-the-profiling-tools-from-the-command-line.md)
[VSPerfCmd](../profiling/vsperfcmd.md)
[Understand sampling data values](../profiling/understanding-sampling-data-values.md)
[Performance report views](../profiling/performance-report-views.md)
