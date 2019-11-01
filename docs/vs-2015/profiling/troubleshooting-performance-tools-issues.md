---
title: "Troubleshooting Performance Tools Issues | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: troubleshooting
ms.assetid: 0b61cdf7-75b7-4abd-aff2-7bd997717626
caps.latest.revision: 15
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Troubleshooting Performance Tools Issues
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You might experience one of the following issues when you use the Profiling Tools:  
  
- [No Data is Collected by the Profiling Tools](#NoDataCollected)  
  
- [Performance Views and Reports Display Numbers for Function Names](#NoSymbols)  
  
## <a name="NoDataCollected"></a> No Data is Collected by the Profiling Tools  
 After you profile an application, a profiling data (.vsp) file is not created and you receive the following warning in the Output window or in the command window:  
  
 PRF0025: No data was collected.  
  
 This problem can be caused by several issues:  
  
- A process that was profiled by using the sampling or the .NET memory method starts a child process that becomes the process that performs the application work. For example, some applications read the command line to determine whether they were started as a Windows application or as a command-line application. If a Windows application was requested, the original process starts a new process configured as a Windows application and then the original process exits. Because the Profiling Tools do not automatically collect data for child processes, no data is collected.  
  
     To collect profiling data in this situation, attach the profiler to the child process instead of starting the application with the profiler. For more information, see [How to: Attach and Detach Performance Tools to Running Processes](../profiling/how-to-attach-and-detach-performance-tools-to-running-processes.md) and [Attach (VSPerfCmd)](../profiling/attach.md)  
  
## <a name="NoSymbols"></a> Performance Views and Reports Display Numbers for Function Names  
 After you profile an application, you see numbers instead of function names in reports and views.  
  
 This problem is caused by the Profiling Tools analysis engine being unable to find the .pdb files that contain the symbol information that maps source code information, such function names and line numbers to the compiled file. By default, the compiler creates the .pdb file when the application file is built. A reference to the local directory of the .pdb file is stored in the compiled application. The analysis engine looks in the referenced directory for the .pdb file and then in the file that currently contains the application file. If the .pdb file is not found, the analysis engine uses the function offsets instead of the function names.  
  
 You can fix the problem in one of two ways:  
  
- Find the .pdb files and place them in the same directory as the application files.  
  
- Embed the symbol information in the profiling data (.vsp) file. For more information, see [Saving Symbol Information with Performance Data Files](../profiling/saving-symbol-information-with-performance-data-files.md).  
  
> [!NOTE]
> The analysis engine requires that the .pdb file is the same version as the compiled application file. A .pdb file from an earlier or later build of the application file will not work.
