---
title: DA0502 - Maximum CPU consumption by the Process being profiled | Microsoft Docs
description: "This message reports the maximum percentage of time that a processor was busy executing instructions from the application."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - vs.performance.rules.DA0502
  - vs.performance.DA0502
  - vs.performance.502
ms.assetid: 1ee53df5-b0dc-4265-9d4f-527830d08725
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# DA0502: Maximum CPU consumption by the process being profiled

|Item|Value|
|-|-|
|Rule Id|DA0502|
|Category|Resource Monitoring|
|Profiling method|All|
|Message|This rule is for information only. The Process()\\% Processor Time counter measures CPU consumption of the process that you are profiling. The value reported is the maximum observed over all measurement intervals.|
|Rule type|Informational|

 When you profile by using the sampling, .NET memory, or resource contention methods, you must collect at least 10 samples to trigger this rule.

## Rule description
 This message reports the maximum percentage of time that a processor was busy executing instructions from the application. The reported value is the maximum value reported among all the measurement intervals in which the process being profiled was active. The percentage can be greater than 100% on a machine with more than one processor.

## How to use the rule data
 Use the rule value to compare the performance of different versions or builds of the program or to understand the performance of the application under different profiling scenarios.
