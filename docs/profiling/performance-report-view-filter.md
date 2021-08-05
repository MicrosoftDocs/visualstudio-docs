---
title: "Performance Report View Filter | Microsoft Docs"
description: Learn how the Profiler Report View Filter window is located at the top of the Performance Report window. 
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "profiling tools, Profiler Report view filter"
  - "Profiler Report View filter, profiling tools"
ms.assetid: 35f89d86-4683-4db1-aa0c-ae0ce65fa524
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Performance Report View Filter
The **Profiler Report View Filter** window is located at the top of the **Performance Report** window. If you cannot see it, click the **Show Filter** button.

 You can modify each filter clause to refine your results. The following columns are available in the filter builder.

|Filter item|Description|
|-----------------|-----------------|
|And/Or|Choose **And** if this clause and the next clause must both be true to match a result. Choose **Or** if either this clause or the next clause can be true to match a result.|
|Field|Select the field to use in the filter clause from the list of data fields that are available in the current report file.|
|Operator|Choose the operator that specifies the relationship that you want between the field and value.<br /><br /> =    Equals<br /><br /> <>  Not Equals<br /><br /> <    Less Than<br /><br /> >    Greater Than<br /><br /> <=  Less Than or Equals<br /><br /> >=  Greater Than or Equals|
|Value|Select or enter the value to look for. Some fields list the available values for the field.|

 You can add filter clauses until you feel that the filter will give you the best results. Click **Execute Filter** to apply the filter to the data file.

 From the **Marks** report view, you can generate filter clauses to limit the data in the report views to the data that is collected between two marks. Select the marks that you want to start and end report data, then right-click and select either **Add Filter on Marks** or **Add Filter on Timestamps**. Both filters limit the data in the current data file to the same span; **Add Filter on Marks** can be applied to other .vsp files.

 To save the filter, click **Export Filter** on the **Performance Report** toolbar and then specify a location and file name for the .*vspf* file. To load a previously saved filter, click **Import Filter** and locate the saved filter file. Filter files can also be used to filter data files on computers that have the stand-alone Profiling Tools installed. For more information, see [VSPerfReport](../profiling/vsperfreport.md).

## See also
- [Analyze performance tools data](../profiling/analyzing-performance-tools-data.md)
- [VSPerfReport](../profiling/vsperfreport.md)
