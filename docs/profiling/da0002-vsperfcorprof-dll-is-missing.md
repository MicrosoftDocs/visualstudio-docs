---
title: DA0002 - VSPerfCorProf.dll is missing | Microsoft Docs
description: "This warning occurs when command-line tools for the collection of profiler data are used without using the VSPerfCLREnv.cmd tool to initialize the necessary environment variables, or if another profiler is running when the Profiling Tools start."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - vs.performance.DA0002
  - vs.performance.2
  - vs.performance.rules.DAVsPerfCorProfMissing
  - vs.performance.rules.DA0002
ms.assetid: 76e614b3-ad7e-4b92-b7be-88dc1329be1d
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# DA0002: VSPerfCorProf.dll is missing

|Item|Value|
|-|-|
|Rule Id|DA0002|
|Category|Profiling Tools Usage|
|Profiling methods|Profiling using the VSPerfCmd and VSPerfASPNETCmd command line tools|
|Message|It appears that the file was collected without properly setting the environment variables with *VSPerfCLREnv.cmd*. Symbols for managed binaries may not resolve.|
|Rule type|Information|

## Cause
 The profiler could not find *VSPerfCorProf.dll* during the profiling run. This warning occurs when command-line tools for the collection of profiler data are used without using the *VSPerfCLREnv.cmd* tool to initialize the necessary environment variables. The warning can also fire if another profiler is running when the Profiling Tools start.

## Rule description
 Specific environment variables must be set before a profiling run for the profiler to resolve the symbols in .NET Framework binaries. This warning suggests that the *VSPerfCLREnv.cmd* tool was not run before the profiling data was collected. Symbols for managed binaries might not resolve. For more information about using the Profiling Tools from the command line, see [Profiling from the command-line](../profiling/using-the-profiling-tools-from-the-command-line.md)

## How to fix violations
 When you are profiling managed applications by using the command-line tools in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools, run the [VSPerfCLREnv](../profiling/vsperfclrenv.md) command-line tool before you start collecting data.
