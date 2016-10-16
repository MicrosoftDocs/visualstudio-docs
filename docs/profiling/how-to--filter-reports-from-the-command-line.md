---
title: "How to: Filter Reports from the Command Line"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 6e9b140f-b44f-4a5c-bd65-d868ddc94023
caps.latest.revision: 6
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Filter Reports from the Command Line
By using options for the **VSPerfReport** command, you can filter reports to a specific time segment of the profiling data file or restrict the data to one or more processes or threads. For more information about this command, see [VSPerfReport](../profiling/vsperfreport.md).  
  
|Options|Description|  
|-------------|-----------------|  
|**StartTime:**[*Value*]|Only show data collected after value (in milliseconds.)|  
|**EndTime:**[*Value*]|Only show data collected before value (in milliseconds.)|  
|**FilterFile:** `VSPFFile`|Specifies the location of a filter file that was generated from the **Visual Studio Performance Report** window.|  
|**MsFilter:**[*StartTime,Duration*]|Only show data from `StartTime` until the length of `Duration` (in milliseconds.)|  
|**Process:**[*Pid*]|Only show data from the specified process.|  
|**Thread:**[*ThreadID*]|Only show data from the specified thread.|  
|**Thread:**[*ThreadID,ProcessID*]|Only show data from the specified thread that is associated with the specified process.|