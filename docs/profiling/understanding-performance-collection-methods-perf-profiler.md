---
title: Understand profiler performance collection methods
description: Explore data collection methods that tools within the Visual Studio Performance Profiler utilize, including sampling, tracing, and instrumentation.
ms.date: "4/30/2020"
ms.topic: concept-article
f1_keywords:
helpviewer_keywords:
  - "Performance Profiler, profiling methods"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Understand profiler performance collection methods

This document outlines the data collection methods that tools within the Visual Studio Performance Profiler utilize. 

## Sampling

Sampling collects statistical data about the work that is performed by an application during profiling and it’s a good starting place to find areas to speed up your application. At specified intervals, the Sampling method collects information about the functions that are executing in your application. Data collection is done by collecting information on the application at a regular interval or sampling frequency such as every millisecond. The collected data is analyzed to create a model of where the time was spent in the application. If you need accurate measurements of call times or are looking for performance issues in an application for the first time, then you may want to use sampling.

Sampling has less accuracy in the number of calls, but is low cost to the profiler and has little effect on the execution of the application being profiled. Tools in the Performance Profiler that utilize the sampling method include the [CPU Usage](../profiling/cpu-usage.md) tool.

After you finish data collection, the CPU Usage tool analyzes the captured data and displays the report.

## Tracing

Tracing provides better information on how often a method was executed. If you need accurate measures of call numbers, use tracing.
Tracing can have a larger impact on the performance of your code during collection, but sampling has only a small overhead. Additionally, tracing can be slower to analyze because it takes longer to view the data after collection.

## Instrumentation

Instrumentation profiling collects detailed information about the work that is performed by an application during a profiling run. Data collection is done by tools that either inject code into a binary file that captures timing information or by using callback hooks to collect and emit exact timing and call count information while an application runs. The instrumentation method has a high overhead when compared to sampling-based approaches. Tools in the Performance Profiler that use instrumentation include the [Instrumentation](../profiling/instrumentation-overview.md) tools and the [.NET Object Allocation](../profiling/dotnet-alloc-tool.md) tool.

## Sampling versus instrumentation

The value of sampling is that it has less overhead and for this reason is more likely to be statistically representative of the application running in production. The value of instrumentation profiling is that you can get exact call counts on how many times your functions were called. This gives you much more detailed information than normal sampling, which can distort the time taken in some scenarios. For example, functions that don't do much, but are called frequently, will show up more than they would in a real world scenario.

With instrumentation, every function call selected in your application is annotated and instrumented so that when it gets invoked it's added to the trace along with information about the caller. With sampling, the current call stack executing is polled from the CPU at an interval and then each frame is added to the trace.
