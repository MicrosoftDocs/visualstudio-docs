---
title: "Using the Profiling Tools From the Command-Line | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "command line, performance tools"
  - "command-line tools, performance tools"
  - "profiling tools,command line"
  - "tools, command-line"
  - "command line, tools"
ms.assetid: 6593fa82-181e-4009-a0ed-02aa24c2c063
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Use the Profiling Tools from the command-line
You can use the command-line tools of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools to profile applications at the command prompt and to automate profiling by using batch files and scripting. You can also generate report files at a command prompt. You can use the lightweight stand-alone profiler to collect data on computers that do not have [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] installed.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).

## Common tasks

| Task | Related Content |
| - | - |
| **Set the location of symbols:** To display the names of functions and parameters, the profiler must have access to the symbol (.*pdb*) files of the profiled binaries. These files should include the symbol files for the Microsoft operating system and applications that you want to view in your analysis. You can use the public Microsoft symbol server to make sure that you have the correct .*pdb* files for the Microsoft binaries. | -   [How to: Specify symbol file locations from the command line](../profiling/how-to-specify-symbol-file-locations-from-the-command-line.md) |
| **Profile your application:** The command-line tools and options that you use to profile a target application depend on the type of the application, the profiling method, and whether the target is a managed or native application. | -   [Use profiling methods from the command line](../profiling/using-profiling-methods-to-collect-performance-data-from-the-command-line.md)<br />-   [Profile stand-alone applications](../profiling/command-line-profiling-of-stand-alone-applications.md)<br />-   [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)<br />-   [Profile services](../profiling/command-line-profiling-of-services.md) |
| **Create .xml and .csv reports:** Profiling at the command prompt creates data files that can be viewed in the interface for [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. You can also generate .*xml* or comma-separated value (.*csv*) files of the data by using the VSPerfReport command-line tool. | -   [Create profiler reports from the command line](../profiling/creating-profiler-reports-from-the-command-line.md)<br />-   [VSPerfReport](../profiling/vsperfreport.md) |
| **Profile code on computers without Visual Studio:** You can use the Profiling Tools stand-alone profiler to collect data for applications on computers that do not have [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] installed. | -   [How to: Install the stand-alone profiler](../profiling/how-to-install-the-stand-alone-profiler.md) |

## Reference
- [Command-line Profiling Tools reference](../profiling/command-line-profiling-tools-reference.md)

## See also
- [Performance Explorer](../profiling/performance-explorer.md)
