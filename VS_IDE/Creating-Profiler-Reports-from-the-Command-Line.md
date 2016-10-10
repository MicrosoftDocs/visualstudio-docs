---
title: "Creating Profiler Reports from the Command Line"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c886f8af-2014-4fec-9b24-d98b68ecafb7
caps.latest.revision: 7
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
# Creating Profiler Reports from the Command Line
The **VSPerfReport** command-line tool enables you to create .xml or comma-separated value (.csv) reports from profiling data (.vsp) files. VSPerfReport report types closely match the table-based views of the interface for Visual Studio. You can filter the report to show only your code and to show only a segment of the profiling data file. For more information, see [VSPerfReport](../VS_IDE/VSPerfReport.md).  
  
 You can also make your profiling data files easier to share by embedding symbols in the .vsp files and by creating pre-analyzed report (.vsps) files that are smaller and quicker to open.  
  
## Common Tasks  
  
|Task|Related Content|  
|----------|---------------------|  
|**Create a basic report.** Create all or a subset of the VSPerfReport report types.|-   [Creating Basic Reports](../VS_IDE/Creating-Basic-Profiling-Reports-from-the-Command-Line.md)|  
|**Compare two profiling data files.** Create a "diff" report that compares performance data in two profiling data files.|-   [How to: Create a Profiler Comparison Report from a Command Prompt](../VS_IDE/How-to--Create-a-Profiler-Comparison-Report-from-a-Command-Prompt.md)|  
|**View call trace and Event Trace for Windows (ETW) data.** Create a call trace report that lists timing information for each entry and exit point to your application's functions and each call to other functions by your function. Or create a detailed listing of all ETW events that were collected in a profiling run.|-   [How to: Create a Call Trace Report](../VS_IDE/How-to--Create-a-Profiling-Tools-Call-Trace-Report.md)|  
|**Filter a report.** Limit a report to only the functions in your code or to a specific time in the profiling data file.|-   [How to: Filter Reports from the Command Line](../VS_IDE/How-to--Filter-Reports-from-the-Command-Line.md)|  
|**Create portable profiling data files.** To make sharing of profiling data easier, you can embed the symbols for a profiling run into the .vsp file. You can also create a pre-analyzed profiling data (.vsps) file that is smaller and quicker to open.|-   [Creating Portable Profiling Data Files](../VS_IDE/Creating-Portable-Profiling-Data-Files-from-the-Command-Line.md)|