---
title: DA0505 - Average Private Bytes allocated for the Process being profiled | Microsoft Docs
description: "This message reports the average amount of virtual memory that the process has currently allocated in bytes (Private bytes)."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - vs.performance.DA0505
  - vs.performance.rules.DA0505
  - vs.performance.505
ms.assetid: 32c612ea-d077-44ba-8e6f-3a96333bad00
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# DA0505: Average Private Bytes allocated for the Process being profiled

|Item|Value|
|-|-|
|Rule Id|DA0505|
|Category|Resource Management|
|Profiling method|All|
|Message|This information was gathered for information only. The Process Private Bytes counter measures virtual memory allocated by the process that you are profiling. The value reported is the average computed over all measurement intervals.|
|Rule type|Information|

 When you profile by using the sampling, .NET memory, or resource contention methods, you must collect at least 10 samples to trigger this rule.

## Rule description
 This message reports the average amount of virtual memory that the process has currently allocated in bytes (Private bytes). Private bytes represents virtual memory locations that were allocated by the process that can only be accessed by threads running inside the process.

 For 32-bit processes running on a 32-bit machine, the upper limit of the private portion of the process address space is 2 GB. Using the [/3GB](https://support.microsoft.com/help/833721/available-switch-options-for-the-windows-xp-and-the-windows-server-200) Boot.ini switch, 32-bit processes can acquire up to 3 GB of virtual memory. A 32-bit process that is running on a 64-bit machine can acquire up to 4 GB of private virtual memory.

 A 64-bit process that is running on a 64-bit machine can acquire up to 8 TB of private virtual memory.

 The value reported is the average over all the measurement intervals in which the process being profiled was active.

 For more information about process address spaces, see [Virtual Address Space](/windows/win32/memory/virtual-address-space) in the Windows Memory Management documentation.

## How to use rule data
 Use the reported value to compare the performance of different versions or builds of the program or to understand the performance of the application under different profiling scenarios.
