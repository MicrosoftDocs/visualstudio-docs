---
title: Collect Line-Level Sampling Data | Microsoft Docs
description: Learn how the profiler's line-level sampling can reveal the code that uses large amounts of processor time. It works with both managed and native code.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords: 
  - performance tools, line-level sampling
ms.assetid: 44803aad-dd39-4c2e-9209-d35185d44983
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# How to: Collect line-level sampling data
Line-level sampling is the ability of the profiler to determine where in the code of a processor-intensive function, such as a function that has high exclusive samples, the processor has to spend most of its time.

## Overview
 For line-level sampling, the profiler walks the program call stack at set intervals and aggregates those results. These results show what instructions the processor was executing when the samples were taken. The collected data about exclusive samples is then analyzed to identify the lines of code and the instruction pointer (IP).

 Line-level sampling works for managed as well as native code. Performance reports that display this data include the Lines view and the Modules view.

 Character begin/end information is not available for native code. For multiline statements, line begin information is not available for native code; only line end information is available.

### Available data
 Available line-level sampling data includes the following information:

- Function name.

- Function address.

- Lines begin -line number of the sampled code.

- Line end - ending source line number. This is generally the same as the "Line begin" data except when a single program statement spans multiple source code lines.

- Characters begin - beginning column of the aggregate sample. This is generally 0 except when a single line contains multiple program statements.

- Character end - ending column of the aggregate sample.

- IP - address where the aggregate sample was taken (IP view only).

  In **Modules** view, if a function has line-level statistics, the statistics are nested under each function. Additionally, IP-level statistics that are nested under each line are presented.

### Turn off line-level sampling for managed code
 By default, line-level sampling is turned on. You can turn off line-level data collection for managed code by using one of the following commands:

- Before profiling, type **VSPerfCLREnv /samplelineoff**. This affects both applications and services.

     — or —

- When starting an application, type **VSPerfCmd /lineoff \<other arguments>**.

## See also
- [Configure performance sessions](../profiling/configuring-performance-sessions.md)
- [Analyze performance tools data](../profiling/analyzing-performance-tools-data.md)
