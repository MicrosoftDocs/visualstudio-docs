---
title: "Troubleshooting Performance Tools Issues | Microsoft Docs"
description: Learn about various you may experience when troubleshooting Performance Tools issues, for example when no data is collected by the profiling tools.
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 0b61cdf7-75b7-4abd-aff2-7bd997717626
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Troubleshoot performance tools issues
You might experience one of the following issues when you use the Profiling Tools:

- [No data is collected by the profiling tools](#no-data-is-collected-by-the-profiling-tools)

- [Performance Views and reports display numbers for function names](#performance-views-and-reports-display-numbers-for-function-names)

## No data is collected by the profiling tools
 After you profile an application, a profiling data (.*vsp*) file is not created and you receive the following warning in the **Output** window or in the command window:

 PRF0025: No data was collected.

 This problem can be caused by several issues:

- A process that was profiled by using the sampling or the .NET memory method starts a child process that becomes the process that performs the application work. For example, some applications read the command line to determine whether they were started as a Windows application or as a command-line application. If a Windows application was requested, the original process starts a new process configured as a Windows application and then the original process exits. Because the Profiling Tools do not automatically collect data for child processes, no data is collected.

     To collect profiling data in this situation, attach the profiler to the child process instead of starting the application with the profiler. For more information, see [How to: Attach and detach performance tools to running processes](../profiling/how-to-attach-and-detach-performance-tools-to-running-processes.md) and [Attach (VSPerfCmd)](../profiling/attach.md)

## Performance views and reports display numbers for function names
 After you profile an application, you see numbers instead of function names in reports and views.

 This problem is caused by the Profiling Tools analysis engine being unable to find the .*pdb* files that contain the symbol information that maps source code information, such function names and line numbers to the compiled file. By default, the compiler creates the .*pdb* file when the application file is built. A reference to the local directory of the .*pdb* file is stored in the compiled application. The analysis engine looks in the referenced directory for the .*pdb* file and then in the file that currently contains the application file. If the .*pdb* file is not found, the analysis engine uses the function offsets instead of the function names.

 You can fix the problem in one of two ways:

- Find the .*pdb* files and place them in the same directory as the application files.

- Embed the symbol information in the profiling data (.*vsp*) file. For more information, see [Save symbol information with performance data files](../profiling/saving-symbol-information-with-performance-data-files.md).

> [!NOTE]
> The analysis engine requires that the .*pdb* file is the same version as the compiled application file. A .*pdb* file from an earlier or later build of the application file will not work.
