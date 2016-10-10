---
title: "Event Tracing for Windows (ETW) Report"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 81e88162-b88a-40b6-8b85-a232c8096a47
caps.latest.revision: 12
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
# Event Tracing for Windows (ETW) Report
The Event Tracing for Windows (ETW) report lists the ETW events that were recorded in a performance session of Visual Studio Profiling Tools. ETW data is collected in a binary (.etl) file.  
  
> [!NOTE]
>  You cannot display ETW reports in Visual Studio interface.  
  
-   For information about how to collect ETW by using the Profiling Tools from Visual Studio interface, see [How to: Collect Event Tracing for Windows (ETW) Data](../VS_IDE/How-to--Collect-Event-Tracing-for-Windows--ETW--Data.md).  
  
-   For information about how to collect ETW data by using the [VSPerfCmd](../VS_IDE/VSPerfCmd.md) command line tools, see [Events](../VS_IDE/Events--VSPerfCmd-.md).  
  
-   You generate the ETW report by using the **VSReport/Summary:ETW** command. For more information, see [VSPerfReport](../VS_IDE/VSPerfReport.md).  
  
|Column|Description|  
|------------|-----------------|  
|**Timestamp**|Identifies when the event occurred.|  
|**Process ID**|Identifies the process that generated the event.|  
|**Thread ID**|Identifies the thread that generated the event.|  
|**Description**|Identifies the event provider.|  
|**Type**|Identifies the event type.|  
|**Properties**|The properties of the event. Each event is a comma-separated, name-value pair that is enclosed in brackets.|