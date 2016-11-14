---
title: "DA0506: Maximum Private Bytes allocated for the Process being profiled | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.performance.rules.DA0506"
  - "vs.performance.DA0506"
  - "vs.performance.506"
ms.assetid: e9c43554-9a85-4d98-9fa4-3b19986e7b62
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
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
  
## Rule Description  
 This message reports the maximum amount of virtual memory that the process has currently allocated in bytes (Private bytes). Private bytes represents virtual memory locations that were allocated by the process that can only be accessed by threads running inside the process.  
  
 For 32-bit processes running on a 32-bit machine, the upper limit of the private portion of the process address space is 2 GB. Using the [/3 GB](http://go.microsoft.com/fwlink/?LinkId=177831) Boot.ini switch, 32-bit processes can acquire up to 3 GB of virtual memory. A 32-bit process that is running on a 64-bit machine can acquire up to 4 GB of private virtual memory.  
  
 A 64-bit process that is running on a 64-bit machine can acquire up to 8 TB of private virtual memory.  
  
 The value reported is the maximum over all the measurement intervals in which the process being profiled was active.  
  
 For more information about process address spaces, see [Virtual Address Space](http://go.microsoft.com/fwlink/?LinkId=177832) in the Windows Memory Management documentation.  
  
## How to Use Rule Data  
 Use the reported value to compare the performance of different versions or builds of the program or to understand the performance of the application under different profiling scenarios.  
  
 A maximum value of process private bytes that is approaching the architectural limit of how large a process address space can grow can lead to out of memory exceptions. For more information, see [Investigating Memory Issues](http://go.microsoft.com/fwlink/?LinkID=177833) in the MSDN Magazine.