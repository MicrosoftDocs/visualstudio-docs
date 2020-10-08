---
title: "Instruction Pointers (IPs) View - Contention Data | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Instruction Pointers view"
ms.assetid: f5e49c24-d4cf-4f87-977d-37e3223d1196
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Instruction Pointers (IPs) View - contention data
The IPs view of contention data lists data for the assembly instructions that were blocked from executing in the profiling run.

 The following table explains the values of the columns in the Instruction Pointers view.

|Column|Description|
|------------|-----------------|
|**Exclusive Blocked Time**|The blocked time in this function.|
|**Exclusive Blocked Time %**|The percentage of blocked time while the instruction was executed.|
|**Exclusive Contentions**|The number of contentions that occurred while the instruction was executed.|
|**Exclusive Contentions %**|The percentage of all contentions in the profiling run that occurred while the instruction was executed.|
|**Function Address**|The starting memory address of the function in the loaded binary.|
|**Function Name**|The name of the function that contains the instruction.|
|**Instruction Address**|The memory address of the instruction in the loaded binary.|
|**Function Line Number**|The line number of the start of this function in the source file.|
|**Module Name**|The name of the module that contains the instruction.|
|**Module Path**|The path of the module that contains the instruction.|
|**Process ID**|The process ID (PID) of the profiled process.|
|**Process Name**|The name of the process.|
|**Source Character Begin**|The offset of the character in the source file line at which this instruction starts.|
|**Source Character End**|The offset of the character in the source file line at which this instruction ends.|
|**Source File**|The source file that contains the instruction.|
|**Source Line Begin**|The line number in the source file at which this instruction starts.|
|**Source Line End**|The line number in the source file at which this instruction ends.|

## See also
- [How to: Customize report view columns](../profiling/how-to-customize-report-view-columns.md)
- [Instruction Pointers (IPs) View](../profiling/instruction-pointers-ips-view.md)
- [Instruction Pointers (IPs) View - sampling](../profiling/instruction-pointers-ips-view-dotnet-memory-sampling-data.md)
- [Instruction Pointers (IPs) View](../profiling/instruction-pointers-ips-view-sampling-data.md)
