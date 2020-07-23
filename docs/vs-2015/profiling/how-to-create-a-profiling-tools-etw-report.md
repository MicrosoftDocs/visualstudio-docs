---
title: "How to: Create a Profiling Tools ETW Report | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: bf5547b3-f6c7-4989-9d47-2fe4f1261444
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Create a Profiling Tools ETW Report
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Event Tracing for Windows (ETW) report lists the ETW events that are recorded in a performance session of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Profiling Tools. ETW data is collected in a binary (.etl) file. For more information about this report, see [Event Tracing for Windows (ETW) Report](../profiling/event-tracing-for-windows-etw-report.md).  
  
> [!NOTE]
> You cannot display ETW reports in the interface for [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].  
  
- For information about how to collect ETW data by using the interface for [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], see [How to: Collect Event Tracing for Windows (ETW) Data](../profiling/how-to-collect-event-tracing-for-windows-etw-data.md).  
  
- For information about how to collect ETW data from a command prompt, see [VSPerfCmd](../profiling/vsperfcmd.md) and [Events](../profiling/events-vsperfcmd.md).  
  
  You generate the ETW report by using the **VSReport/summary:etw** command. The .etl that contains the ETW data must be in the same directory as the profiling data (.vsp or .vsps) file. By default, the report is generated as a comma-separated value (.csv) file. For more information, see [VSPerfReport](../profiling/vsperfreport.md).  
  
### To generate an ETW report  
  
- In a **Command Prompt** window, type the following command line:  
  
     *ToolsPath* **VSPerfReport** *VSPFile*  **/Summary:ETW [/Xml]**  
  
    |Command element|Description|  
    |-|-|  
    |*ToolsPath*|The path of the Profiling Tools utility. For more information, see [Specifying the Path to Command Line Tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md).|  
    |*VSPFile*|The profiling data (.vsp or .vsps) file. Full and partial paths are accepted.|  
    |Xml|Generates a report that is formatted in XML.|
