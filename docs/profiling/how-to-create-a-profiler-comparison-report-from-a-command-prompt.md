---
title: Create a profiler comparison report (command line)
description: Use VSPerfReport.exe from the command-line to compare results of two profiler data files. The comparison shows differences between the profiling sessions.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: 00548d16-eb5b-46f7-8a65-862f98a43831
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# How to: Create a profiler comparison report from a command prompt
You can generate a [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools report that compares the performance data of two profiling data (.*vsp* /or .*vsps*) files. The report shows the differences, performance regressions, and improvements that occurred from one profiling session to the other. The values in the report present the delta, or change, from the baseline of the first file that you specify. This delta is calculated by determining the difference between the old value, which is the baseline value, and the result value from the new analysis. Comparisons of profiler data can be based on the functions in the code, modules in the application, lines, instruction pointers (IPs), and types.

 To list the identifiers of the comparison categories and fields, type the following command line:

 **VSPerfReport /querydifftables**  *VspFileName1* *VspFileName2*

 Use the following syntax to create the comparison report:

 **VSPerfReport /diff**  `VspFileName1` *VspFileName2* [**/**`Options`]

 You can add options from the following table to the **VSPerfReport /diff** command line.

|Option|Description|
|------------|-----------------|
|**DiffThreshold:**[*Value*]|Disregard the difference if it is below this percentage threshold value. Also, new data with values that are below this threshold will not appear.|
|**DiffTable:** *TableName*|Use this table to compare files. By default, the functions table is used. Specify the identifier that is listed in **VSPerfReport /querydifftables**.|
|**DiffColumn:** *ColumnName*|Use this column to compare values. By default, the exclusive samples percent column is used. Specify the identifier that is listed in **VSPerfReport /querydifftables**.|
