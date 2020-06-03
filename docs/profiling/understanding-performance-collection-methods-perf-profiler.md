---
title: "Understanding Performance Collection Methods | Microsoft Docs"
ms.date: "4/30/2020"
ms.topic: "conceptual"
f1_keywords:
helpviewer_keywords:
  - "Performance Profiler, profiling methods"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: '>= vs-2017'
ms.workload:
  - "multiple"
---

# Understand performance collection methods

This document outlines the data collection methods that tools within the Visual Studio Performance Profiler utilize. 

## Sampling

Sampling profiling methods collect statistical data about the work that is performed by an application during a profiling run. This is done by collecting information on the application at a regular interval or sampling frequency such as every millisecond and then analyzing this to create a model of where time was spent in the application. The sampling method is lightweight and has little effect on the execution of the application being profiled. Tools in the Performance Profiler that utilize this method include the [CPU Usage](../profiling/cpu-usage.md) tool.

## Instrumentation

Instrumentation profiling collects detailed information about the work that is performed by an application during a profiling run. This is done by tools either injecting code into a binary file that captures timing information or using callback hooks to collect and emit exact timing and call count information as an application runs. The instrumentation method has a high overhead when compared to sampling based approaches. Tools in the Performance Profiler that use this include the [.NET Object Allocation](../profiling/dotnet-alloc-tool.md) Tool.