---
title: Create a Profiling Tools Call Trace Report | Microsoft Docs
description: Create a Performance Tools call trace report to see timing information for your functions and for functions called by your functions. 
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords: 
  - performance tools, viewing ETW data
  - ETW [Visual Studio ALM], viewing data
ms.assetid: 7640520a-7d3c-456c-b184-872a5d2f82f3
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# How to: Create a profiling tools call trace report
The  *call trace report* for the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools lists timing information for each entry and exit point to your application's functions and each call to other functions by your function. Call trace reports are available for profiling data only if it was collected with the instrumentation method.

> [!NOTE]
> You cannot display call trace reports in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. You must use the **VSPerfReport** command-line tool to generate a comma-separated value (.*csv*) or .*xml* file. For more information about this tool, see [VSPerfReport](../profiling/vsperfreport.md).

### To create a call trace report

1. Open a **Command Prompt** window.

2. At the command prompt, type the following command:

     *ToolsPath* **VSPerfReport** *VSPFile*  **/CallTrace [/Xml]**

    |Item|Description|
    |-|-|
    |*ToolsPath*|The path of Profiling Tools command-line tools. For more information, see [Specify the path to command-line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md).|
    |*VSPFile*|The profiling data (.*vsp* or .*vsps*) file. Full and partial paths are accepted.|
    |Xml|Generates an XML formatted report.|

## See also
- [How to: Collect Event Tracing for Windows (ETW) data](../profiling/how-to-collect-event-tracing-for-windows-etw-data.md)
- [Profiling tools APIs](../profiling/profiling-tools-apis.md)
