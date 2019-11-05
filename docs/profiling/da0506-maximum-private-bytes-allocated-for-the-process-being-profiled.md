---
title: "DA0506: Maximum Private Bytes allocated for the Process being profiled | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.rules.DA0506"
  - "vs.performance.DA0506"
  - "vs.performance.506"
ms.assetid: e9c43554-9a85-4d98-9fa4-3b19986e7b62
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# DA0506: Maximum Private Bytes allocated for the Process being profiled

|||
|-|-|
|Rule Id|DA0506|
|Category|Resource Monitoring|
|Profiling method|All|
|Message|This information was gathered for information only. The Process Private Bytes counter measures virtual memory allocated by the process that you are profiling. The value reported is the maximum observed over all measurement intervals.|
|Rule type|Information|

 When you profile by using the sampling, .NET memory, or resource contention methods, you must collect at least 10 samples to trigger this rule.

## Rule description
 This message reports the maximum amount of virtual memory that the process has currently allocated in bytes (Private bytes). Private bytes represents virtual memory locations that were allocated by the process that can only be accessed by threads running inside the process.

 For 32-bit processes running on a 32-bit machine, the upper limit of the private portion of the process address space is 2 GB. Using the [/3 GB](https://support.microsoft.com/help/833721/available-switch-options-for-the-windows-xp-and-the-windows-server-200) Boot.ini switch, 32-bit processes can acquire up to 3 GB of virtual memory. A 32-bit process that is running on a 64-bit machine can acquire up to 4 GB of private virtual memory.

 A 64-bit process that is running on a 64-bit machine can acquire up to 8 TB of private virtual memory.

 The value reported is the maximum over all the measurement intervals in which the process being profiled was active.

 For more information about process address spaces, see [Virtual Address Space](/windows/win32/memory/virtual-address-space) in the Windows Memory Management documentation.

## How to use rule data
 Use the reported value to compare the performance of different versions or builds of the program or to understand the performance of the application under different profiling scenarios.

 A maximum value of process private bytes that is approaching the architectural limit of how large a process address space can grow can lead to out of memory exceptions. For more information, see [Investigating Memory Issues](https://msdn.microsoft.com/magazine/cc163528.aspx) in the MSDN Magazine.
