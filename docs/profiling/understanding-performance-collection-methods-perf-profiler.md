---
title: Understand profiler performance collection methods
description: Learn about the data collection methods that tools within the Visual Studio Performance Profiler utilize.
ms.date: "4/30/2020"
ms.topic: "conceptual"
f1_keywords:
helpviewer_keywords:
  - "Performance Profiler, profiling methods"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: '>= vs-2017'
ms.workload:
  - "multiple"
---

# Understand profiler performance collection methods

This document outlines the data collection methods that tools within the Visual Studio Performance Profiler utilize. 

## Sampling

Sampling methods for profiling collect statistical data about the work that is performed by an application during a profiling run. Data collection is done by collecting information on the application at a regular interval or sampling frequency such as every millisecond and then analyzing this data to create a model of where time was spent in the application. The sampling method is lightweight and has little effect on the execution of the application being profiled. Tools in the Performance Profiler that utilize the sampling method include the [CPU Usage](../profiling/cpu-usage.md) tool.

## Instrumentation

Instrumentation profiling collects detailed information about the work that is performed by an application during a profiling run. Data collection is done by tools that either inject code into a binary file that captures timing information or by using callback hooks to collect and emit exact timing and call count information while an application runs. The instrumentation method has a high overhead when compared to sampling-based approaches. Tools in the Performance Profiler that use instrumentation include the [.NET Object Allocation](../profiling/dotnet-alloc-tool.md) Tool.