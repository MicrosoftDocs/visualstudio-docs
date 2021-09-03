---
title: Filter Reports from the Command Line | Microsoft Docs
description: Use VSPerfReport.exe to restrict reporting to a specific time period, or to selected processes and threads. This article lists the options, with descriptions.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: 6e9b140f-b44f-4a5c-bd65-d868ddc94023
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# How to: Filter reports from the command line
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
